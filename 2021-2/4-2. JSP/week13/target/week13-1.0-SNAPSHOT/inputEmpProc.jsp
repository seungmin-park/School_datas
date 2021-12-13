<%@ page import="java.sql.*" %><%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-11-25
  Time: 오후 5:45
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<%
    request.setCharacterEncoding("utf-8");
    String empno = request.getParameter("empno");
    String name = request.getParameter("name");
    String dept = request.getParameter("dept");
    String job = request.getParameter("job");
    int sal = Integer.parseInt(request.getParameter("sal"));

    Class.forName("com.mysql.jdbc.Driver");

    Connection conn = null;
    PreparedStatement pstat = null;
    ResultSet rs = null;

    String jdbcDriver = "jdbc:mysql://localhost:3306/jspDB?useSSL=false&serverTimeZone=UTC";
    String dbUser = "inhatc";
    String dbPass = "inhatc";

    String sql = "insert into emp values(?,?,?,?,?)";
    String sqlQ = "select * from emp where empNo = ?";

    //2.데이터베이스 커넥션 생성
    conn = DriverManager.getConnection(jdbcDriver, dbUser, dbPass);

    //3. Statement 생성
    pstat = conn.prepareStatement(sqlQ);
    pstat.setString(1, empno);
    rs = pstat.executeQuery();

    int empnoChk = 0;
    int result = 0;

    if (rs.next()) {
        empnoChk = 1;
    } else {
        pstat = conn.prepareStatement(sql);
        pstat.setString(1, empno);
        pstat.setString(2, name);
        pstat.setString(3, dept);
        pstat.setString(4, job);
        pstat.setInt(5, sal);

        result = pstat.executeUpdate();
    }

    request.setAttribute("result", result);
    request.setAttribute("empnoChk", empnoChk);

    conn.close();
    pstat.close();
    rs.close();
%>
<jsp:forward page="inputEmpResult.jsp" />
</body>
</html>
