<%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-09-06
  Time: 오전 4:30
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
    <%
        int number1 = Integer.parseInt(request.getParameter("number1"));
        int number2 = Integer.parseInt(request.getParameter("number2"));
    %>
  <h2>사칙연산 결과</h2>
    <%=number1%> + <%=number2%> = <%=number1 + number2%> <br>
    <%=number1%> - <%=number2%> = <%=number1 - number2%> <br>
    <%=number1%> * <%=number2%> = <%=number1 * number2%> <br>
    <%=number1%> / <%=number2%> = <%=number1 / number2%> <br>
</body>
</html>
