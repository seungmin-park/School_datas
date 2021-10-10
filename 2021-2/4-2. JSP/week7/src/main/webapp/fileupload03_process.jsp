<%@ page import="org.apache.commons.fileupload.DiskFileUpload" %>
<%@ page import="java.util.List" %>
<%@ page import="java.util.Iterator" %>
<%@ page import="org.apache.commons.fileupload.FileItem" %>
<%@ page import="java.io.File" %>
<%@ page import="com.oreilly.servlet.MultipartRequest" %><%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-10-10
  Time: 오후 11:45
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%
    String fileUploadPath = "C:\\upload";
    DiskFileUpload upload = new DiskFileUpload();

    List items = upload.parseRequest(request);

    Iterator params = items.iterator();

    while (params.hasNext()) {
        FileItem fileItem = (FileItem) params.next();
        if (!fileItem.isFormField()) {
            String fileName = fileItem.getName();
            fileName = fileName.substring(fileName.lastIndexOf("\\") + 1);
            File file = new File(fileUploadPath + "/" + fileName);
            fileItem.write(file);
        }
    }
%>
<html>
<head>
    <title>Title</title>
</head>
<body>

</body>
</html>
