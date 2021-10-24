<%@ page import="java.net.URLEncoder" %><%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-10-24
  Time: 오후 10:18
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<%
    Cookie cookie = new Cookie("name", URLEncoder.encode("홍길동","utf-8"));

    response.addCookie(cookie);
%>
<h1>
    <%=cookie.getName()%> 쿠키의 값 = <%=cookie.getValue()%>
</h1>
</body>
</html>
