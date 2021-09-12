<%@ page import="java.util.Map" %>
<%@ page import="java.util.HashMap" %>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<%
    String pet = request.getParameter("pet");
%>
    <h1>당신이 좋아하는 동물은 <%=pet%>입니다.</h1>
</body>
</html>
