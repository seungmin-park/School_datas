<%@ page session="false" contentType="text/html; charset=UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<html>
<head>
    <title>Gugudan</title>
</head>
<body>
<h1>
    Gugudan
</h1>

<c:forEach items="${numbers}" var="num">
    <p>${num}</p>
</c:forEach>

<hr>
<c:forEach var="j" begin="1" end="9" step="1">
    <br>
    <c:forEach var="i" begin="1" end="9" step="1">
        ${j} * ${i} = ${j*i}<br>
    </c:forEach>
</c:forEach>

</body>
</html>
