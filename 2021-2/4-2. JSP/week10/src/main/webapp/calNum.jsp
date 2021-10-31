<%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-10-31
  Time: 오후 9:50
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<%
    int num1 = Integer.parseInt(request.getParameter("num1"));
    int num2 = Integer.parseInt(request.getParameter("num2"));

    int sum = 0;
    for (int i = num1; i <= num2; i++) {
        sum += i;
    }
    request.setAttribute("num1",num1);
    request.setAttribute("num2",num2);
    request.setAttribute("sum",sum);
%>
<jsp:forward page="calResult2.jsp"></jsp:forward>
</body>
</html>
