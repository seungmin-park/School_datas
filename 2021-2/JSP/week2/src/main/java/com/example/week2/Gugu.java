package com.example.week2;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.annotation.*;
import java.io.IOException;
import java.io.PrintWriter;

@WebServlet(name = "Gugu", value = "/Gugu")
public class Gugu extends HttpServlet {

    private static final long serialVersionUID = 1L;

    public Gugu() {
        super();
    }

    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        response.setContentType("text/html;charset=utf-8");
        int num = Integer.parseInt(request.getParameter("number"));
        PrintWriter out = response.getWriter();
        out.println("<html><body>");
        out.println("<h3>구구단 " + num + " 단 <h3>");
        for (int i = 1; i <= 9; i++) {
            out.println(num + " *" + i +" = " + num * i+"<br>");
        }
        out.println("</body></html>");
        out.close();
    }

    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {

    }
}
