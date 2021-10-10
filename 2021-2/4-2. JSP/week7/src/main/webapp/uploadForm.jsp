<%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-10-11
  Time: 오전 12:05
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<form action="upload.jsp" method="post" enctype="multipart/form-data">
    <table border="1">
        <caption>업로드 화면</caption>
        <tr><th>제목</th>
        <td>
            <input type="text" name="title" required="required" autofocus="autofocus">
        </td>
        </tr>
        <tr><th>작성자</th>
            <td>
                <input type="text" name="writer" required="required" autofocus="autofocus">
            </td>
        </tr>
        <tr><th>제목</th>
            <td>
                <input type="file" name="file" required="required" autofocus="autofocus">
            </td>
        </tr>
        <tr><th colspan="2"><input type="submit" value="확인"></th></tr>
    </table>
</form>
</body>
</html>
