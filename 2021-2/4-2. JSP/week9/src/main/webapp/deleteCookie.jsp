<%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-10-24
  Time: 오후 10:31
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<h3>쿠키 삭제</h3>
<%
    Cookie[] cookies = request.getCookies();
    if (cookies != null && cookies.length > 0) {
        for (Cookie c : cookies) {
            if (c.getName().equals("name")) {
                Cookie cookie = new Cookie("name", "");
                cookie.setMaxAge(0);
                response.addCookie(cookie);
            }
        }
    }
%>
name 쿠키를 삭제하였습니다.
</body>
</html>
