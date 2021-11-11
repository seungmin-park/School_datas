<%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-11-11
  Time: 오후 7:00
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<c:url value="http://search.daum.net.search" var="searchUrl">
    <c:param name="code" value="blog"></c:param>
    <c:param name="place" value="park"></c:param>
</c:url>
<c:url var="url1" value="/jstlCore3.jsp"></c:url>
<c:url var="url2" value="/tokenTag.jsp"></c:url>
<ul>
    <li>${searchUrl}</li>
    <li>${url1}</li>
    <li>${url2}</li>
</ul>
</body>
</html>
