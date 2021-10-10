<%@ page import="com.oreilly.servlet.MultipartRequest" %>
<%@ page import="java.util.Enumeration" %>
<%@ page import="com.oreilly.servlet.multipart.DefaultFileRenamePolicy" %>
<%@ page import="java.io.File" %><%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-10-10
  Time: 오후 11:14
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%
    MultipartRequest multi = new MultipartRequest(request, "C:\\upload", 5 * 1024 * 1024, "utf-8", new DefaultFileRenamePolicy());

    String name1 = multi.getParameter("name1");
    String title1 = multi.getParameter("title1");

    String name2 = multi.getParameter("name2");
    String title2 = multi.getParameter("title2");

    String name3 = multi.getParameter("name3");
    String title3 = multi.getParameter("title3");

    Enumeration files = multi.getFileNames();

    String file = (String) files.nextElement();
    String fileName = multi.getFilesystemName(file);

    String file2 = (String) files.nextElement();
    String fileName2 = multi.getFilesystemName(file2);

    String file3 = (String) files.nextElement();
    String fileName3 = multi.getFilesystemName(file3);

%>
<html>
<head>
    <title>Title</title>
</head>
<body>
<table border="1">
    <tr>
        <th width="100%">이름</th>
        <th width="100%">제목</th>
        <th width="100%">파일</th>
    </tr>
    <tr>
        <td><%=name1%></td>
        <td><%=title1%></td>
        <td><%=fileName%></td>
    </tr>
    <tr>
        <td><%=name2%></td>
        <td><%=title2%></td>
        <td><%=fileName2%></td>
    </tr>
    <tr>
        <td><%=name3%></td>
        <td><%=title3%></td>
        <td><%=fileName3%></td>
    </tr>
</table>
</body>
</html>
