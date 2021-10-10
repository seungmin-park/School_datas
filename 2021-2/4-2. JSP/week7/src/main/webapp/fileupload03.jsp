<%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-10-10
  Time: 오후 11:44
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<form action="fileupload03_process.jsp" method="post" enctype="multipart/form-data">
    <p> 파일 : <input type="file" name="fileName"></p>
    <p><input type="submit" value="파일 올리기"></p>
</form>
</body>
</html>
