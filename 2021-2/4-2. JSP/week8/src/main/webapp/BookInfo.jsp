<%@ page import="com.oreilly.servlet.MultipartRequest" %>
<%@ page import="com.oreilly.servlet.multipart.DefaultFileRenamePolicy" %>
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
<jsp:useBean id="book" class="com.example.week8.Book" scope="application"/>
<%
    String path = "/fileSave";
    String realPath = application.getRealPath(path);

    int max = 1024 * 1024 * 10;
    MultipartRequest mt = new MultipartRequest(request, realPath, max,"utf-8",new DefaultFileRenamePolicy());
    String code = mt.getParameter("code");
    String name = mt.getParameter("name");
    String price = mt.getParameter("price");
    String author = mt.getParameter("author");
    String publisher = mt.getParameter("publisher");
    String publishingDate = mt.getParameter("publishingDate");
    String bookPage = mt.getParameter("page");
    String info = mt.getParameter("info");
    String category = mt.getParameter("category");
    String count = mt.getParameter("count");
    String status = mt.getParameter("status");
    String fileName = mt.getFilesystemName("fileImage");
    String original = mt.getOriginalFileName("fileImage");
%>
<jsp:setProperty name="book" property="name" value="<%=name%>"/>
<jsp:setProperty name="book" property="code" value="<%=code%>"/>
<jsp:setProperty name="book" property="price" value="<%=price%>"/>
<jsp:setProperty name="book" property="author" value="<%=author%>"/>
<jsp:setProperty name="book" property="publisher" value="<%=publisher%>"/>
<jsp:setProperty name="book" property="publishingDate" value="<%=publishingDate%>"/>
<jsp:setProperty name="book" property="page" value="<%=bookPage%>"/>
<jsp:setProperty name="book" property="info" value="<%=info%>"/>
<jsp:setProperty name="book" property="category" value="<%=category%>"/>
<jsp:setProperty name="book" property="count" value="<%=count%>"/>
<jsp:setProperty name="book" property="status" value="<%=status%>"/>
<jsp:setProperty name="book" property="status" value="<%=status%>"/>
<jsp:setProperty name="book" property="fileImage" value="<%=fileName%>" />
<jsp:include page="header.jsp"/>
<div class="bookInfo">
    <span class="bookInfo-text">도서 정보</span>
</div>
<div class="bookInfoMainFrame">
    <div class="bookInfoMainFrame-image">
        <img src="fileSave/<%=fileName%>" alt="<%=fileName%>">
    </div>
    <div class="bookInfoMainFrame-info">
        <span class="bookInfoMainFrame-info-title">
            <h1><%=name%></h1>
        </span>
        <span class="bookInfoMainFrame-info-explanation">
            <%=info%>
        </span>
        <span class="bookInfoMainFrame-info-bookInfo">
            <span>
                도서코드 : <%=code%> <br>
                저자 : <%=author%><br>
                출판사 : <%=publisher%><br>
                출판일 : <%=publishingDate%><br>
                총 페이지 수 : <%=bookPage%><br>
                재고 수 : <%=count%><br>
                분류 : <%=category%><br>
                상태 : <%=status%><br>
                가격 : <%=price%><br>
            </span>
        </span>
        <form action="BookList.jsp" method="post">
            <input type="submit" value="도서목록">
        </form>
    </div>
</div>

<jsp:include page="footer.jsp"/>
</body>
</html>
