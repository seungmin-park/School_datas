package com.example.week14;


import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.annotation.*;
import java.io.FileInputStream;
import java.io.IOException;
import java.util.HashMap;
import java.util.Iterator;
import java.util.Map;
import java.util.Properties;

@WebServlet(urlPatterns = "*.do",initParams = {@WebInitParam(name = "config",value = "/WEB-INF/commandHandler.properties")})
public class ControllerUsingFile extends HttpServlet {

    private static final long serialVersionUID = 1L;

    private Map<String, CommandHandler> commandHandlerMap = new HashMap<>();

    @Override
    public void init(ServletConfig config) throws ServletException {
        String configFile = config.getInitParameter("config");
        Properties prop = new Properties();
        String configFilePath = config.getServletContext().getRealPath(configFile);

        try (FileInputStream fis = new FileInputStream(configFilePath)){
            prop.load(fis);

        } catch (IOException e) {
            throw new ServletException(e);
        }

        Iterator<Object> keyIter = prop.keySet().iterator();
        while (keyIter.hasNext()) {
            String command = (String) keyIter.next();
            String handlerClassName = prop.getProperty(command);
            try {
                Class<?> handlerClass = Class.forName(handlerClassName);
                CommandHandler handlerInstance = (CommandHandler) handlerClass.newInstance();
                commandHandlerMap.put(command, handlerInstance);
            } catch (ClassNotFoundException |
                    InstantiationException |
                    IllegalAccessException
                    e) {
                throw new ServletException(e);
            }
        }
    }

    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        try {
            process(request, response);
        } catch (Exception e) {
            throw new ServletException(e);
        }
    }

    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        try {
            process(request, response);
        } catch (Exception e) {
            throw new ServletException(e);
        }
    }

    private void process(HttpServletRequest request,HttpServletResponse response) throws ServletException, IOException {
        String command = request.getRequestURI();

        command = command.substring(request.getContextPath().length() + 1);

        CommandHandler handler = commandHandlerMap.get(command);

        String viewPage = null;
        try {
            viewPage = handler.process(request, response);
        } catch (Exception e) {
            throw new ServletException(e);
        }

        if (viewPage != null) {
            RequestDispatcher dispatcher = request.getRequestDispatcher(viewPage + ".jsp");
            dispatcher.forward(request,response);
        }
    }
}
