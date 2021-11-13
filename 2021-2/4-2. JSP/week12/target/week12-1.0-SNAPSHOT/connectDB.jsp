<%@ page import="java.sql.Connection" %>
<%@ page import="java.sql.Statement" %>
<%@ page import="java.sql.ResultSet" %>
<%@ page import="java.sql.DriverManager" %><%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-11-12
  Time: 오후 4:14
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<h3>데이터베이스 연결</h3>
<%
    //1.JDBC 드라이버 연결
    Class.forName("com.mysql.jdbc.Driver");

    Connection conn = null;
    Statement stat = null;
    ResultSet rs = null;

    String jdbcDriver = "jdbc:mysql://localhost:3306/jspDB?useSSL=false&serverTimeZone=UTC";
    String dbUser = "root";
    String dbPass = "Tmd1648215";

    String sql = "select * from emp";

    //2.데이터베이스 커넥션 생성
    conn = DriverManager.getConnection(jdbcDriver, dbUser, dbPass);

    //3. Statement 생성
    stat = conn.createStatement();

    //4. 쿼리 실행
    rs = stat.executeQuery(sql);

    //5. 쿼리 실행 결과 출력

    if (rs != null) {
        out.println("데이터베이스 연결 성공~!" + "<br>");
    } else {
        out.println("데이터베이스 연결 실패...");
    }

    //6. 사용한 Statement 종료
    rs.close();

    //7. 커넥션 종료
    conn.close();
%>
</body>
</html>
