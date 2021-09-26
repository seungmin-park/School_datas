<%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-09-26
  Time: 오후 11:02
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
이 페이지는 getAttribute.jsp가 생성한 것 입니다.
<%
     String id = (String)request.getAttribute("id");
     String pw = (String)request.getAttribute("password");
     String name = (String)request.getAttribute("name");
     String addr = (String)request.getAttribute("addr");
     String email = (String)request.getAttribute("email");
%>
<h3>기본 객체의 속성을 이용한 값 전달 결과</h3>
<h4>
    아이디 : <%=id%><br>
    패스워드 : <%=pw%><br>
    이름 : <%=name%><br>
    주소 : <%=addr%><br>
    이메일 : <%=email%><br>
</h4>
</body>
</html>
