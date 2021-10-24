<%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-10-24
  Time: 오후 10:35
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<%
    String id = request.getParameter("id");
    String password = request.getParameter("password");

    if (id.equals(password)) {
        Cookie cookie = new Cookie("id", "admin");
        response.addCookie(cookie);
        out.println("로그인에 성공하였습니다.");
    }else {
        out.println("로그인에 실패하였습니다.");
    }
%>
</body>
</html>
