<%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-09-26
  Time: 오후 10:25
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<table width="100%" border="1" cellpadding="10" cellspacing="10">
    <tr><td>모델번호</td><td>MQ7E2KH</td></tr>
    <tr><td>가격</td><td>1,000,000원</td></tr>
</table>
<jsp:include page="infoSub.jsp" flush="false">
    <jsp:param name="type" value="iphone"></jsp:param>
</jsp:include>
</body>
</html>
