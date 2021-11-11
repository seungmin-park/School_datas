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
<h3>JSTL 코어 태그 결과2</h3>
id : ${m.getId()} <br>
이름 : ${m.getName()} <br>

<c:if test="${m.getId() == m.getPassword()}">
    로그인에 성공하였습니다.
</c:if>
<c:if test="${m.getId() != m.getPassword()}">
    로그인에 실패하였습니다.
</c:if>
</body>
</html>
