<%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-11-17
  Time: 오후 10:58
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<h3>사원 정보 조회 화면</h3>
<form action="viewEmpQuery.jsp">
  조회할 사원 번호를 입력하세요 : <input type="number" name="empno"> <br><br>
  <input type="submit" value="조회">
  <input type="reset" value="취소">
</form>
</body>
</html>
