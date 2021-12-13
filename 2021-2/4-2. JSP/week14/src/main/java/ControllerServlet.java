import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.annotation.*;
import java.io.IOException;
import java.util.Date;

@WebServlet(name = "ControllerServlet", value = "/ControllerServlet")
public class ControllerServlet extends HttpServlet {
    private static final long serialVersionUID = 1L;

    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        processRequest(request,response);
    }

    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        processRequest(request,response);
    }

    private void processRequest(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        String type = request.getParameter("type");

        Object resultObj = null;

        if (type == null || type.equals("greeting")) {
            resultObj = "안녕하세요";
        } else if (type.equals("date")) {
            resultObj = new Date();
        } else {
            resultObj = "Invalid type";
        }

        request.setAttribute("result", resultObj);
        RequestDispatcher dispatcher = request.getRequestDispatcher("simpleView.jsp");
        dispatcher.forward(request,response);
    }
}
