<%@ page import="com.oreilly.servlet.MultipartRequest" %>
<%@ page import="com.oreilly.servlet.multipart.DefaultFileRenamePolicy" %>
<%@ page import="java.io.File" %><%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-10-11
  Time: 오전 12:09
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%
    request.setCharacterEncoding("utf-8");

    String fileSave = "/fileSave";

    String real = application.getRealPath(fileSave);

    int max = 1024 * 1024 * 10;

    MultipartRequest mr = new MultipartRequest(request, real, max, "utf-8", new DefaultFileRenamePolicy());

    String title = mr.getParameter("title");
    String writer = mr.getParameter("writer");
    String fileName = mr.getFilesystemName("file");
    String original = mr.getOriginalFileName("file");
    File file = new File(real + "/" + fileName);
    int size = (int) file.length();
%>
<html>
<head>
    <title>Title</title>
</head>
<body>
<h3>파일 업로드 결과</h3>
제목 : <%=title%><br>
작성자 : <%=writer%><br>
파일명 : <%=fileName%><br>
파일원본명 : <%=original%><br>
파일크기 : <%=size%><br>

<form action="uploadViewForm.jsp" method="post">
    <input type="hidden" name="fileName" value="<%=fileName%>">
    <input type="submit" value="파일보기">
</form>
</body>
</html>
