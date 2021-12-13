<%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-11-25
  Time: 오후 6:14
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%@taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<h3>사원 정보 조회</h3>
<c:if test="${result == 0}">
    <script type="text/javascript">
        alert("사원 번호가 존재하지 않습니다.");
        history.go(-1);
    </script>
</c:if>
<c:if test="${result == 1}">
    <table border="1" style="width: 300px; text-align: center">
        <tr><td>사원번호</td><td>${empno}</td></tr>
        <tr><td>사원번호</td><td>${empname}</td></tr>
        <tr><td>사원번호</td><td>${empdept}</td></tr>
        <tr><td>사원번호</td><td>${empjob}</td></tr>
        <tr><td>사원번호</td><td>${empsal}</td></tr>
    </table>
    <br>
    <br>
    <button onclick="location.href='updateEmp.jsp?empno='+${empno}">사원정보수정</button>
    <button onclick="location.href='deleteEmp.jsp?empno='+${empno}">사원정보삭제</button>
    <button onclick="location.href='viewEmpForm.jsp'">돌아가기</button>
</c:if>
</body>
</html>
