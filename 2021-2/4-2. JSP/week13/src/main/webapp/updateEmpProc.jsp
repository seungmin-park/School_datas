<%@ page import="java.sql.PreparedStatement" %>
<%@ page import="java.sql.Connection" %>
<%@ page import="java.sql.ResultSet" %>
<%@ page import="java.sql.DriverManager" %><%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-11-25
  Time: 오후 6:39
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
    String empdept = request.getParameter("empdept");
    String empjob = request.getParameter("empjob");
    int empsal = Integer.parseInt(request.getParameter("empsal"));

    PreparedStatement pstat = null;
    int result = 0;

    conn = DriverManager.getConnection(jdbcDriver, dbUser, dbPass);

    String sql = "update emp set empdept = ?, empjob = ?, empsal = ? where empno = ?";

    pstat = conn.prepareStatement(sql);
    pstat.setString(1, empdept);
    pstat.setString(2, empjob);
    pstat.setInt(3,empsal);
    pstat.setString(4, empno);

    result = pstat.executeUpdate();

    request.setAttribute("result", result);
    request.setAttribute("empno", empno);

    pstat.close();
    conn.close();
%>
<jsp:forward page="updateEmpResult.jsp"></jsp:forward>
</body>
</html>
