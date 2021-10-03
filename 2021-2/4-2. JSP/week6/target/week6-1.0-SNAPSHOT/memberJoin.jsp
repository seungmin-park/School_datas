<%@ page import="java.text.SimpleDateFormat" %>
<%@ page import="java.util.Date" %><%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-10-04
  Time: 오전 12:27
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
<jsp:useBean id="memberInfo" class="com.example.week6.MemberInfo"/>
<jsp:setProperty property="*" name="memberInfo"/>
<jsp:setProperty property="password" name="memberInfo" value="<%=memberInfo.getId()%>"/>
<jsp:setProperty property="registerDate" name="memberInfo" value="<%=strDate%>"/>
<table border="1">
    <tr>
        <td>아이디</td>
        <td><jsp:getProperty property="id" name="memberInfo"/></td>
        <td>암호</td>
        <td><jsp:getProperty property="password" name="memberInfo"/></td>
    </tr>
    <tr>
        <td>이름</td>
        <td><jsp:getProperty property="name" name="memberInfo"/></td>
        <td>이메일</td>
        <td><jsp:getProperty property="email" name="memberInfo"/></td>
    </tr>
    <tr>
        <td>등록일자</td>
        <td colspan="3">
            <jsp:getProperty property="registerDate" name="memberInfo"/>
        </td>
    </tr>
</table>
</body>
</html>
