<%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-09-26
  Time: 오후 10:42
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<%
    request.setCharacterEncoding("UTF-8");
%>
include 전 name  파라미터 값 : <%=request.getParameter("name")%>

<hr>
<jsp:include page="body_sub.jsp" flush="false">
    <jsp:param name="name" value="홍길동"></jsp:param>
</jsp:include>
<hr>
include 후 name 파라미터 값 : <%=request.getParameter("name")%>
</body>
</html>
