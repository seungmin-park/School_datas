<%@ page import="java.text.SimpleDateFormat" %>
<%@ page import="java.util.Date" %><%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-10-04
  Time: 오전 1:00
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<%
    request.setCharacterEncoding("UTF-8");
    SimpleDateFormat sdf = new SimpleDateFormat("yyyy-MM-dd");
    Date date = new Date();
    String strDate = sdf.format(date);
%>
<jsp:useBean id="book" class="com.example.week6.Book"/>
<jsp:setProperty property="*" name="book"/>
<jsp:setProperty property="pubDate" name="book" value="<%=strDate%>" />
<style>
    .resultIndex{
        background-color: #000E7D;
        color: white;
        text-align: center;
    }
    td{
    }
</style>
<h2>◆ 도서 등록 결과 ◆</h2>
<table border="1">
    <tr class="resultIndex">
        <td>코드</td>
        <td>제목</td>
        <td>저자</td>
        <td>출판일자</td>
    </tr>
    <tr>
        <td><jsp:getProperty property="code" name="book"/></td>
        <td><jsp:getProperty property="title" name="book"/></td>
        <td><jsp:getProperty property="writer" name="book"/></td>
        <td><jsp:getProperty property="pubDate" name="book"/></td>
    </tr>
</table>
</body>
</html>
