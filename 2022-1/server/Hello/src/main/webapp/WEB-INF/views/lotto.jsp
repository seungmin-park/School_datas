<%@ page session="false" contentType="text/html; charset=UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<html>
<head>
    <title>Lotto</title>
</head>
<body>
<h1>
    Lotto
</h1>

<c:forEach items="${lotto}" var="num">
    <span>${num}</span>
</c:forEach>
</body>
</html>
