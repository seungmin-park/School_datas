<%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-10-04
  Time: 오전 12:59
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<style>
    .index{
        background-color: #FEA32A;
    }
</style>
<h2>◆ 도서 등록 화면 ◆</h2>
<form action="bookResult.jsp" method="post">
    <table border="1">
        <tr>
            <td class="index">도서 코드</td>
            <td><input type="text" name="code"></td>
        </tr>
        <tr>
            <td class="index">도서 제목</td>
            <td><input type="text" name="title"></td>
        </tr>
        <tr>
            <td class="index">도서 저자</td>
            <td><input type="text" name="writer"></td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <input type="submit" value="등록">
            </td>
        </tr>
    </table>
</form>
</body>
</html>
