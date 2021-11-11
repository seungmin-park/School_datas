<%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-11-11
  Time: 오후 6:01
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<h3>JSTL 코어 태그 결과</h3>
이름 : ${name} <br>
성별 : ${gender} <br>
나이 : ${age} <br>
배열 데이터 : <c:forEach var="data" items="${arrays}">
    ${data}
</c:forEach> <br>
하나씩 건너뛴 데이터 :
<c:forEach var="data" begin="0" end="4" step="2" items="${arrays}">
    ${data}
</c:forEach>
</body>
</html>
