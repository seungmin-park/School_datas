<%@ page session="false" contentType="text/html; charset=UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<html>
<head>
	<title>Home</title>
</head>
<body>
<h1>
	Hello world!  
</h1>

<P>  The time on the server is ${serverTime}. </P>
<c:forEach var="j" begin="1" end="9" step="1">
	<br>
	<c:forEach var="i" begin="1" end="9" step="1">
		${j} * ${i} = ${j*i}<br>
	</c:forEach>
</c:forEach>

</body>
</html>
