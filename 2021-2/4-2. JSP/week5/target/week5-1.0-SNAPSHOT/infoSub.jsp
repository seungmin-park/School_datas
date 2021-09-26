<%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-09-26
  Time: 오후 10:27
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<%
    String type = request.getParameter("type");
    if (type == null){
        return;
    }
%>
<br>
<table width="100%" border="1" cellspacing="10" cellpadding="10">
    <tr><td>타입</td><td><b><%=type%></b></td></tr>
    <tr><td>특징</td><td>
        <%
            if (type.equals("iphone")) {%>
        수려한 디자인
        <%}else if (type.equals("Galaxy")){%>
        뛰어난 활용성
            <%}%>
    </td></tr>
</table>
</body>
</html>
