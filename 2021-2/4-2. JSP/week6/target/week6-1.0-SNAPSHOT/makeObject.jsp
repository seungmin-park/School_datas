<%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-10-04
  Time: 오전 12:18
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<jsp:useBean  id="member" class="com.example.week6.MemberInfo" scope="request"/>
<jsp:setProperty property="id" name="member" value="admin" />
<jsp:setProperty property="name" name="member" value="홍길동" />
<jsp:setProperty property="email" name="member" value="admin@inhatc.ac.kr" />
<jsp:forward page="useObject.jsp"></jsp:forward>
</body>
</html>
