<%@ page import="java.sql.Connection" %>
<%@ page import="java.sql.Statement" %>
<%@ page import="java.sql.ResultSet" %>
<%@ page import="java.sql.DriverManager" %><%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-11-25
  Time: 오후 6:17
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<%@ include file="connectDB.jsp"%>
<%
    request.setCharacterEncoding("utf-8");
    String empno = request.getParameter("empno");

    Class.forName("com.mysql.jdbc.Driver");

    Statement stat = null;

    String sql = "Select * from emp where empno = " + empno;

    conn = DriverManager.getConnection(jdbcDriver, dbUser, dbPass);

    stat = conn.createStatement();
    rs = stat.executeQuery(sql);

    int result = 0;

    if (rs.next()) {
        result = 1;
        request.setAttribute("empno", rs.getString("empno"));
        request.setAttribute("empname", rs.getString("empname"));
        request.setAttribute("empdept", rs.getString("empdept"));
        request.setAttribute("empjob", rs.getString("empjob"));
        request.setAttribute("empsal", rs.getString("empsal"));
    }
    request.setAttribute("result", result);

    rs.close();
    stat.close();
    conn.close();
%>
<jsp:forward page="deleteEmpForm.jsp"></jsp:forward>
</body>
</html>
