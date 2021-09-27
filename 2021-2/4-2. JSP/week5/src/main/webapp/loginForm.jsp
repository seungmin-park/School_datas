<%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-09-27
  Time: 오전 12:50
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<style></style>
<h1>★ 로그인 화면 ★</h1>
<form action="loginResult.jsp" method="post">
<table border="1" cellspacing="1" cellpadding="0">
    <tr>
        <td width="65" align="center">아이디</td>
        <td><input type="text" name="name"></td>
    </tr>
    <tr>
        <td width="65" align="center">비밀번호</td>
        <td><input type="password" name="password"></td>
    </tr>
    <tr>
        <td colspan="2" align="center"><input type="submit" value="로그인"></td>
    </tr>
</table>
</form>
</body>
</html>
