<%--
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
<c:set var="name" value="홍길동" scope="request"></c:set>
<c:set var="gender" value="남자" scope="request"></c:set>
<c:set var="age" value="25" scope="request"></c:set>
<c:set var="arrays" value="<%=new int[] {1,2,3,4,5}%>" scope="request"></c:set>
<jsp:forward page="jstlResult.jsp"></jsp:forward>
</body>
</html>
