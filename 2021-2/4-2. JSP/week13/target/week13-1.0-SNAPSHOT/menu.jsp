<%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-11-25
  Time: 오후 5:24
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<table style="padding : 5px; margin:10px; width: 300px; align-content: center">
    <tr>
        <th colspan="3" align="center">메뉴 선택</th>
    </tr>
    <tr height="10px"></tr>
    <tr>
        <td><button onclick="location.href='queryEmp.jsp'">사원목록</button></td>
        <td><button onclick="location.href='inputEmpForm.jsp'">사원등록</button></td>
        <td><button onclick="location.href='viewEmpForm.jsp'">사원조회</button></td>
    </tr>
</table>
</body>
</html>
