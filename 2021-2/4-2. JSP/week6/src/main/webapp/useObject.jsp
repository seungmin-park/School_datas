<%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-10-04
  Time: 오전 12:21
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<jsp:useBean  id="member" class="com.example.week6.MemberInfo" scope="request"/>
<jsp:getProperty property="name" name="member"/>
(<jsp:getProperty property="id" name="member"/>)회원님, 안녕하세요. <br>
당신의 이메일은 <jsp:getProperty property="email" name="member"/> 입니다.
</body>
</html>
