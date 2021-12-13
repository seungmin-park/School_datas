<%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-11-25
  Time: 오후 5:55
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<c:choose>
    <c:when test="${empnoChk > 0}">
        <script type="text/javascript">
            alert("이미 등록된 사원 번호입니다.");
            history.go(-1);
        </script>
    </c:when>
    <c:when test="${result > 0}">
        <script type="text/javascript">
            alert("사원 등록 성공");
            location.href = "queryEmp.jsp";
        </script>
    </c:when>
    <c:when test="${result <= 0}">
        <script type="text/javascript">
            alert("사원 등록 실패");
            history.go(-1);
        </script>
    </c:when>
</c:choose>
</body>
</html>
