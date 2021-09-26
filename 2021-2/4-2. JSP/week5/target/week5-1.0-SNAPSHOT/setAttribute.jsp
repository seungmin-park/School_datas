<%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-09-26
  Time: 오후 11:00
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
이 페이지는 setAttribute.jsp가 생성한 것 입니다.
<%
    request.setCharacterEncoding("UTF-8");
    request.setAttribute("id","admin");
    request.setAttribute("password","adminpw");
    request.setAttribute("name","홍길동");
    request.setAttribute("addr","서울");
    request.setAttribute("email","hgd@naver.com");
%>
<jsp:forward page="/getAttribute.jsp" />
</body>
</html>
