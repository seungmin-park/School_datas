<%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-11-17
  Time: 오후 11:06
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<h3>사원 정보 조회 결과</h3>
<form action="viewEmp.jsp">
    <table border="1">
        <tr>
            <td>id</td>
            <td>${id}</td>
        </tr>
        <tr>
            <td>이름</td>
            <td>${name}</td>
        </tr>
        <tr>
            <td>부서</td>
            <td>${dept}</td>
        </tr>
        <tr>
            <td>업무</td>
            <td>${job}</td>
        </tr>
        <tr>
            <td>급여</td>
            <td>${sal}</td>
        </tr>
    </table>
    <br>
    <br>
    <input type="submit" value="돌아가기">
</form>
</body>
</html>
