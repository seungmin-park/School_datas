<%@ page import="com.example.week11.MemberInfo" %><%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-11-11
  Time: 오후 5:59
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%@taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<%
    MemberInfo member = new MemberInfo();
%>
<c:set var="m" value="<%=member%>" scope="request" />
<c:set target="${m}" property="id" var="admin" />
<c:set target="${m}" property="password" var="admin" />
<c:set target="${m}" property="name" var="김철수" />
<jsp:forward page="jstlResult2.jsp"></jsp:forward>

</body>
</html>
