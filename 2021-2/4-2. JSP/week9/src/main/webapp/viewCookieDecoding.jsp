<%@ page import="java.net.URLDecoder" %><%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-10-24
  Time: 오후 10:29
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<h1>쿠키 목록</h1>
<%
    Cookie[] cookies = request.getCookies();

    if (cookies != null && cookies.length > 0) {
        for (Cookie c : cookies) {
            out.println(c.getName() + " = ");
            out.println(URLDecoder.decode(c.getValue(), "utf-8") + "<br>");
        }
    } else {
        out.println("<h3>쿠키가 존재하지 않습니다.</h3>");
    }
%>
</body>
</html>
