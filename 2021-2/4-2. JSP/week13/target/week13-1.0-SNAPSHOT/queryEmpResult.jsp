<%@ page import="java.util.ArrayList" %>
<%@ page import="com.example.week13.Emp" %><%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-11-25
  Time: 오후 5:33
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%@taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<table border="1" style="text-align: center">
    <tr><td colspan=""5>사원 목록 조회</td></tr>
    <tr bgcolor="orange">
        <th>사번</th>
        <th>이름</th>
        <th>부서코드</th>
        <th>업무</th>
        <th>급여</th>
    </tr>
    <%
        response.setContentType("text/html;charset=utf-8");
        request.setCharacterEncoding("utf-8");
        ArrayList<Emp> list = (ArrayList<Emp>) request.getAttribute("list");
    %>
    <c:forEach var="emp" items="${list}">
        <tr>
            <td>${emp.getEmpno()}</td>
            <td>${emp.getName()}</td>
            <td>${emp.getDept()}</td>
            <td>${emp.getJob()}</td>
            <td>${emp.getSal()}</td>
        </tr>
    </c:forEach>
</table>
<br>
<br>
<form action="menu.jsp">
    <input type="submit" value="메뉴화면">
</form>
</body>
</html>
