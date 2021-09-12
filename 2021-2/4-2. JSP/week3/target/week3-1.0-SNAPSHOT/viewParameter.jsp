<%@ page import="java.util.Enumeration" %>
<%@ page import="java.util.Map" %><%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-09-12
  Time: 오후 11:58
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
    <% response.setCharacterEncoding("utf-8");  %>
    <h3>요청 파라미터 출력</h3>
    <h4 style="color: red">request.getParameter() 메서드 사용</h4>
    name 파라미터 = <%=request.getParameter("name")%>,
    addr 파라미터 = <%=request.getParameter("addr")%>,<p>

    <h4 style="color: red">request.getParameterValues() 메서드 사용</h4>
    <%
        String[] values = request.getParameterValues("pet");
        if (values != null){
            for (int i = 0; i < values.length; i ++){
                out.println(values[i]);
            }
        }
    %>
    </p>

    <h4 style="color: red">request.getParameterNames() 메서드 사용</h4>
    <%
        Enumeration paramEnum = request.getParameterNames();
        while (paramEnum.hasMoreElements()){
            String name = (String) paramEnum.nextElement();
            out.println(name);
        }
    %> <p>
    <h4 style="color: red">request.getParameterMap() 메서드 사용</h4>
    <%
        Map paramMap = request.getParameterMap();
        String[] nameParam = (String[]) paramMap.get("pet");
        if (nameParam != null){
            out.println(nameParam[1]);
        }
    %>
    </p>

</body>
</html>
