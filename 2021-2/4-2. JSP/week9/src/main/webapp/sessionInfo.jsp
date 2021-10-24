<%@ page import="java.util.Date" %>
<%@ page import="java.text.SimpleDateFormat" %><%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-10-24
  Time: 오후 9:30
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<%
    Date time = new Date();
    SimpleDateFormat sdf = new SimpleDateFormat("yyyy-MM-dd HH:mm:ss");
%>
세션 ID : <%=session.getId()%> <br>
<%
    time.setTime(session.getCreationTime());
%>
세션 생성시간 : <%=sdf.format(time)%> <br>
<%
    time.setTime(session.getLastAccessedTime());
%>
최근 접근시간 : <%=sdf.format(time)%>
</body>
</html>
