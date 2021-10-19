<%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-10-18
  Time: 오후 9:50
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <link rel="stylesheet" href="css/style.css" type="text/css">
    <title>Title</title>
</head>
<body>
<jsp:useBean id="book" class="com.example.week8.Book" scope="application" />
<jsp:include page="header.jsp"/>
<div>
    <span>도서 목록</span>
</div>
<div class="bookListInfo">
    <div>
        <img src="fileSave/<jsp:getProperty name="book" property="fileImage"/>" alt="<jsp:getProperty name="book" property="fileImage"/>">
    </div>
    <div>
        <h2><jsp:getProperty name="book" property="name"/></h2>
        <br>
        <jsp:getProperty name="book" property="info" />
        <br>
        <jsp:getProperty name="book" property="author"/>|<jsp:getProperty name="book" property="publisher"/>|<jsp:getProperty name="book" property="price"/>
    </div>
</div>
<jsp:include page="footer.jsp"/>
</body>
</html>
