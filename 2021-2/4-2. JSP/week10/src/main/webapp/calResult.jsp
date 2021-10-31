<%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-10-31
  Time: 오후 9:52
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<%
    int num1 = (int) request.getAttribute("num1");
    int num2 = (int) request.getAttribute("num2");
    int sum = (int) request.getAttribute("sum");
%>
<h3><%=num1%> 부터 <%=num2%>까지의 합 구하기</h3>
결과 값 = <%=sum%>
</body>
</html>
