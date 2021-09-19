<%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-09-19
  Time: 오후 10:58
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
  <h3>application 기본 객체</h3>
    <%
        String realPath = application.getRealPath("/");
        String contPath = application.getContextPath();
    %>
    루트의 실제파일 결로명 = <%=realPath%> <br>
    웹 어플리케이션의 URL 경로명 = <%=contPath%>
</body>
</html>
