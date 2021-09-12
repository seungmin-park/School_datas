<%@ page import="java.util.Date" %>
<%@ page import="java.text.SimpleDateFormat" %>
<%@ page import="java.util.Calendar" %><%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-09-12
  Time: 오후 10:55
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<%
    Date date = new Date();
    SimpleDateFormat sdf = new SimpleDateFormat("hh:mm:ss");
    String time = sdf.format(date);
    Calendar cal = Calendar.getInstance();
%>
    <h1>오늘은 <%=cal.get(Calendar.YEAR)%>년
                <%=cal.get(Calendar.MONTH)+1%>월
                <%=cal.get(Calendar.DATE)%>일 입니다</h1>
    <h2>현재 시각 <%= time %></h2>
</body>
</html>
