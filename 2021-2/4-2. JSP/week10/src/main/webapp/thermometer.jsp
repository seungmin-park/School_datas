<%@ page import="com.example.week10.Thermometer" %>
<%@ page import="com.example.week10.FormatUtil" %><%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-10-31
  Time: 오후 10:29
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<%
    Thermometer thermometer = new Thermometer();
    request.setAttribute("th", thermometer);
%>
<h3>온도계 변환 예제</h3>
${th.setCelsius("서울",27.3)}
서울 온도 : 섭씨${th.getCelsius("서울")}도 / 화씨 ${th.getFahrenheit("서울")}
<br>
정보 : ${th.info}<br>
<hr>
가격은 <b>${FormatUtil.number(12345,'#,##0')}</b>원 입니다.
</body>
</html>
