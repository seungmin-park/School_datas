<%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-09-06
  Time: 오전 4:24
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
  <%!
      public int multiply(int x, int y){
          return x * y;
      }
  %>
    <h1>두 수 곱하기</h1>
    <h2> 13 * 19 = <%=multiply(13,19)%></h2>
</body>
</html>
