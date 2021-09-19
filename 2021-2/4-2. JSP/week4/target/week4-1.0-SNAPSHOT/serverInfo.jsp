<%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-09-19
  Time: 오후 10:40
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
    <h3>Server 정보</h3>
    <%=application.getServerInfo()%> <br>
    <h3>Servlet 정보</h3>
    <%=application.getMajorVersion()%>.<%=application.getMinorVersion()%> <br>
    <h3>JSP 정보</h3>
    <%=JspFactory.getDefaultFactory().getEngineInfo().getSpecificationVersion()%> <br>
    <br>

</body>
</html>
