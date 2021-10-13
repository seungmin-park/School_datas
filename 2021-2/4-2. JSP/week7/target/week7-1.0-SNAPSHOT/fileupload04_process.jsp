<%@ page import="org.apache.commons.fileupload.DiskFileUpload" %>
<%@ page import="java.util.List" %>
<%@ page import="java.util.Iterator" %>
<%@ page import="org.apache.commons.fileupload.FileItem" %>
<%@ page import="java.io.File" %><%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-10-13
  Time: 오후 11:40
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<%
    String path = "C://upload";

    DiskFileUpload upload = new DiskFileUpload();

    upload.setSizeMax(1000000);
    upload.setSizeThreshold(4096);
    upload.setRepositoryPath(path);

    List items = upload.parseRequest(request);
    Iterator params = items.iterator();

    while (params.hasNext()) {
        FileItem item = (FileItem) params.next();
        if (item.isFormField()) {
            String name = item.getFieldName();
            String value = item.getString("utf-8");
            out.println(name + "=" + value + "<br>");
        } else {
            String fileFieldName = item.getFieldName();
            String fileName = item.getName();
            String contentType = item.getContentType();

            fileName = fileName.substring(fileName.lastIndexOf("\\") + 1);
            long fileSize = item.getSize();

            File file = new File(path + "/" + fileName);
            item.write(file);

            out.println("--------------------------------<br>");
            out.println("요청 파라미터 이름 : "+fileFieldName+"<br>");
            out.println("저장 파일 이름 : "+fileName+"<br>");
            out.println("파일 콘텐츠 유형 : "+contentType+"<br>");
            out.println("파일 크기 : "+fileSize);
        }
    }
%>
</body>
</html>
