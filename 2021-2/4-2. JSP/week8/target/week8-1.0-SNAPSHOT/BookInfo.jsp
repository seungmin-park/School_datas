<%@ page import="com.oreilly.servlet.MultipartRequest" %>
<%@ page import="com.oreilly.servlet.multipart.DefaultFileRenamePolicy" %>
<%@ page import="java.io.File" %>
<%@ page import="java.io.FileOutputStream" %>
<%@ page import="java.io.ObjectOutputStream" %>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <link rel="stylesheet" href="css/style.css" type="text/css">
    <title>Title</title>
</head>
<body>
<jsp:useBean id="book" class="com.example.week8.Book"/>
<%
    String path = "/fileSave";
    String realPath = application.getRealPath(path);
    File folder = new File(realPath);
    if (!folder.exists()) {
        folder.mkdir();
    }
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
<%
    String bookPath = "/bookSave";
    realPath = application.getRealPath(bookPath);

    File bookFolder = new File(realPath);

    if (!bookFolder.exists()) {
        bookFolder.mkdir();
    }

    realPath = application.getRealPath(bookPath+"/book_" + book.getCode());
    FileOutputStream fos = new FileOutputStream(realPath);
    ObjectOutputStream oos = new ObjectOutputStream(fos);
    oos.writeObject(book);
    oos.close();
%>
<jsp:include page="header.jsp"/>
<div class="bookInfo">
    <span class="bookInfo-text">도서 정보</span>
</div>
<div class="bookInfoMainFrame">
    <div class="bookInfoMainFrame-image">
        <img
                class="bookInfoMainFrame-image-screen"
                src="fileSave/<%=fileName%>"
        />
    </div>
    <div class="bookInfoMainFrame-info">
        <span class="bookInfoMainFrame-info-title">
          <h1 class="bookInfoMainFrame-info-title-name"><%=name%></h1>
        </span>
        <span class="bookInfoMainFrame-info-bookInfo">
          <span class="bookInfoMainFrame-info-explanation">
              <jsp:getProperty name="book" property="info"/>
          </span>
          <br />
          <br />

          <span>
            도서코드 : <%=code%> <br />
            저자 : <%=author%><br />
            출판사 : <%=publisher%><br />
            출판일 : <%=publishingDate%><br />
            총 페이지 수 : <%=bookPage%><br />
            재고 수 : <%=count%><br />
            분류 : <%=category%><br />
            상태 : <%=status%><br />
            가격 : <%=price%><br />
          </span>
        </span>
        <br />
        <form action="BookList.jsp">
            <input type="submit" value="도서목록" />
        </form>
    </div>
</div>
<jsp:include page="footer.jsp"/>
</body>
</html>