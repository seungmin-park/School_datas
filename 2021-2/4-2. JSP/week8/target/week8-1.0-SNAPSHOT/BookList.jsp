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
<div class="bookListInfo">
    <span class="bookListInfo-header">도서 목록</span>
</div>
<div class="bookListInfo-mainFrame">
    <div class="bookListInfo-mainFrame-image">
        <img src="fileSave/<jsp:getProperty name="book" property="fileImage" />"
             alt="<jsp:getProperty name="book" property="fileImage" />">
    </div>
    <div class="bookListInfo-mainFrame-info">
        <h2 class="bookListInfo-mainFrame-info-header">
            <h2><jsp:getProperty name="book" property="name" /></h2>
        </h2>
        <div class="bookListInfo-mainFrame-info-explanation">
          <jsp:getProperty name="book" property="info"
          /></div>
        <br>
        <br>
        <span
        ><jsp:getProperty name="book" property="author" /> |
          <jsp:getProperty name="book" property="publisher" /> |
          <jsp:getProperty name="book" property="price"
          /></span>
    </div>
</div>
<jsp:include page="footer.jsp"/>
</body>
</html>
