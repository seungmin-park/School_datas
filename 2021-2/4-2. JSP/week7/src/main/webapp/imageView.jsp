<%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-10-11
  Time: 오전 12:29
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<%
    String fileName = request.getParameter("fileName");
%>
<h3>파일 내용 보기</h3>
이미지 파일명 = <%=fileName%><br><br>
<img src="fileSave/<%=fileName%>" alt="<%=fileName%>"><p>
<button onclick="location.href='uploadForm.jsp'">돌아가기</button>
</body>
</html>
