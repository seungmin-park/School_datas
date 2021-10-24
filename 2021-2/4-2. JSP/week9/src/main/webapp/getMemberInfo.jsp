<%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-10-24
  Time: 오후 9:38
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
세션에 저장된 정보(id) : <%=session.getAttribute("id")%> <br>
세션에 저장된 정보(name) : <%=session.getAttribute("name")%>
</body>
</html>
