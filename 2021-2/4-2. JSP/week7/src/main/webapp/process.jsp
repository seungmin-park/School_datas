<%@ page import="com.oreilly.servlet.MultipartRequest" %>
<%@ page import="com.oreilly.servlet.multipart.DefaultFileRenamePolicy" %>
<%@ page import="java.util.Enumeration" %><%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-10-10
  Time: 오후 11:02
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<%
    MultipartRequest multi = new MultipartRequest(request, "C:\\upload", 5 * 1024 * 1024, "utf-8", new DefaultFileRenamePolicy());

    String title = multi.getParameter("title");
    out.println("<h3>"+title+"</h3>");

    Enumeration files = multi.getFileNames();
    String name = (String) files.nextElement();

    String fileName = multi.getFilesystemName(name);
    String original = multi.getOriginalFileName(name);

    out.println("실제 파일 이름 : "+ original + "<br>");
    out.println("저장 파일 이름 : "+ fileName + "<br>");
%>
</body>
</html>
