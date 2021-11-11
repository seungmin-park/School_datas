<%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-11-11
  Time: 오후 5:52
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<%--<%--%>
<%--    int[] list = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};--%>
<%--%>--%>
<%--<c:if test="<%=list.length != 0%>">--%>
<%--    <c:forEach var="data" items="<%=list%>">--%>
<%--        ${data}--%>
<%--    </c:forEach>--%>
<%--</c:if>--%>
<%--<c:if test="<%=list.length == 0%>">--%>
<%--    데이터가 없습니다.--%>
<%--</c:if>--%>
${list = [1,2,3,4,5,6,7,8,9,10];''}
<c:if test="${list.stream().count() !=0 }">
    <c:forEach var="data" items="${list}">
        ${data}
    </c:forEach>
</c:if>
<c:if test="${list.stream().count == 0}">
    데이터가 없습니다.
</c:if>
</body>
</html>
