<%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-09-13
  Time: 오전 12:12
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<%
    String web = request.getParameter("web");
    response.sendRedirect(web);
%>
</body>
</html>
