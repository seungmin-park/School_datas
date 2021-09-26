<%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-09-26
  Time: 오후 10:52
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<%--<jsp:forward> 액션 태그를 실행하면 생성했던 출력 결과는 모두 제거된다--%>
이 페이지는 from.jsp가 생성한 것 입니다.

<%
    request.setCharacterEncoding("UTF-8");
%>
<jsp:forward page="/to.jsp">
    <jsp:param name="id" value="admin" />
    <jsp:param name="password" value="adminpw" />
    <jsp:param name="name" value="홍길동" />
    <jsp:param name="addr" value="서울" />
    <jsp:param name="email" value="hgd@naver.com" />
</jsp:forward>
</body>
</html>
