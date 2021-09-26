<%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-09-26
  Time: 오후 10:54
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
이 페이지는 to.jsp가 생성한 것 입니다.
<%
    String id = request.getParameter("id");
    String pw = request.getParameter("password");
    String name = request.getParameter("name");
    String addr = request.getParameter("addr");
    String email = request.getParameter("email");
%>
<h3> jsp 액션 태그 결과</h3>
<h4>
    아이디 : <%=id%><br>
    패스워드 : <%=pw%><br>
    이름 : <%=name%><br>
    주소 : <%=addr%><br>
    이메일 : <%=email%><br>
</h4>
</body>
</html>
