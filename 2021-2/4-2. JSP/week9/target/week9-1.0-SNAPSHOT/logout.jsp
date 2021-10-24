<%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-10-24
  Time: 오후 10:39
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<%
    Cookie[] cookies = request.getCookies();
    if (cookies != null && cookies.length > 0) {
        for (Cookie c : cookies) {
            if (c.getName().equals("id")) {
                Cookie cookie = new Cookie("id", "");
                cookie.setMaxAge(0);
                response.addCookie(cookie);
            }
        }
    }
%>
<h3>로그아웃</h3>
로그아웃하였습니다.
</body>
</html>
