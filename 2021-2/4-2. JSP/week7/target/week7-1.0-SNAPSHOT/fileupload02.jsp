<%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-10-10
  Time: 오후 11:13
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<form action="fileupload02_process.jsp" method="post" enctype="multipart/form-data">
    <p>이름 : <input type="text" name="name1"></p>
    <p>제목 : <input type="text" name="title1"></p>
    <p>파일 : <input type="file" name="fileName1"></p>
    <p>이름2 : <input type="text" name="name2"></p>
    <p>제목2 : <input type="text" name="title2"></p>
    <p>파일2 : <input type="file" name="fileName2"></p>
    <p>이름3 : <input type="text" name="name3"></p>
    <p>제목3 : <input type="text" name="title3"></p>
    <p>파일3 : <input type="file" name="fileName3"></p>
    <p><input type="submit" value="파일올리기"></p>
</form>
</body>
</html>
