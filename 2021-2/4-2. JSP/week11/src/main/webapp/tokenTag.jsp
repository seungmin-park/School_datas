<%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-11-11
  Time: 오후 6:45
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<html>
<head>
      <title>Title</title>
</head>
<body>
<h3>forTokens 태크</h3>
콤마와 점을 구분자로 사용: <br>
<c:forTokens var="token" items="빨강,주황.노랑.초록.,파랑,남색,보라" delims=",.">
      ${token}
</c:forTokens>
</body>
</html>
