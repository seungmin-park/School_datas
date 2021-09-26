<%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-09-26
  Time: 오후 10:44
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
body_sub에서 name 파라미터 값 : <%=request.getParameter("name")%>
<br>
name 파라미터 값 목록
<ul>
    <%
        String[] nameArray = request.getParameterValues("name");
        for (String name : nameArray) {
    %>
    <li><%=name%></li>
    <%}%>
</ul>
</body>
</html>
