<%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-11-25
  Time: 오후 6:51
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%@taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<c:if test="${result >0}">
    <script type="text/javascript">
        alert("사원 정보 삭제 성공");
        location.href="queryEmp.jsp";
    </script>
</c:if>
<c:if test="${result == 0}">
    <script type="text/javascript">
        alert("사원 정보 삭제 실패");
        history.go(-1);
    </script>
</c:if>
</body>
</html>
