<%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-11-25
  Time: 오후 6:08
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<%
    Class.forName("com.mysql.jdbc.Driver");

    Connection conn = null;
    ResultSet rs = null;

    String jdbcDriver = "jdbc:mysql://localhost:3306/jspDB?useSSL=false&serverTimeZone=UTC";
    String dbUser = "inhatc";
    String dbPass = "inhatc";

%>
</body>
</html>
