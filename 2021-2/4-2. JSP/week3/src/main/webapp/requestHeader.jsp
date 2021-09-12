<%@ page import="java.util.Enumeration" %><%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-09-13
  Time: 오전 12:08
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
    <%
        Enumeration headerEnum = request.getHeaderNames();
        while (headerEnum.hasMoreElements()){
            String hName = (String) headerEnum.nextElement();
            String hValue = request.getHeader(hName);
            out.println(hName + " = " + hValue+"<br>");
        }
    %>
</body>
</html>
