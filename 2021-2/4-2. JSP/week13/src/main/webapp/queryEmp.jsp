<%@ page import="java.sql.Connection" %>
<%@ page import="java.sql.Statement" %>
<%@ page import="java.sql.ResultSet" %>
<%@ page import="java.sql.DriverManager" %>
<%@ page import="java.util.ArrayList" %>
<%@ page import="com.example.week13.Emp" %><%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-11-25
  Time: 오후 5:27
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<%
    response.setContentType("text/html;charset=utf-8");
    //1.JDBC 드라이버 연결
    Class.forName("com.mysql.jdbc.Driver");

    Connection conn = null;
    Statement stat = null;
    ResultSet rs = null;

    String jdbcDriver = "jdbc:mysql://localhost:3306/jspDB?useSSL=false&serverTimeZone=UTC";
    String dbUser = "inhatc";
    String dbPass = "inhatc";

    String sql = "select * from emp";

    //2.데이터베이스 커넥션 생성
    conn = DriverManager.getConnection(jdbcDriver, dbUser, dbPass);

    //3. Statement 생성
    stat = conn.createStatement();

    //4. 쿼리 실행
    rs = stat.executeQuery(sql);

    ArrayList<Emp> list = new ArrayList<Emp>();

    while (rs.next()) {
        Emp emp = new Emp();
        emp.setEmpno(rs.getString(1));
        emp.setName(rs.getString(2));
        emp.setDept(rs.getString(3));
        emp.setJob(rs.getString(4));
        emp.setSal(rs.getString(5));
        list.add(emp);
    }

    request.setAttribute("list",list);

    rs.close();

    conn.close();

    RequestDispatcher rd = request.getRequestDispatcher("queryEmpResult.jsp");
    rd.forward(request, response);
%>
</body>
</html>
