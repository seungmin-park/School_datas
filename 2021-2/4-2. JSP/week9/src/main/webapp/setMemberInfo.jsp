<%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-10-24
  Time: 오후 9:36
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<%
    session.setAttribute("id", "admin");
    session.setAttribute("name", "홍길동");
%>
세션에 정보를 저장하였습니다.
</body>
</html>
