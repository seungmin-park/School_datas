<%@ page import="java.io.File" %>
<%@ page import="java.io.FileInputStream" %>
<%@ page import="java.io.ObjectInputStream" %>
<%@ page import="com.example.week8.Book" %>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <link rel="stylesheet" href="css/style.css" type="text/css">
    <title>Title</title>
</head>
<body>
<jsp:include page="header.jsp"/>
<div class="bookListInfo">
    <span class="bookListInfo-header">도서 목록</span>
</div>
<%
    String bookPath = "/bookSave";
    String realPath = application.getRealPath(bookPath);
    File file = new File(realPath);
    File[] files = file.listFiles();

    for (File file1 : files) {
        String fileName = file1.getName();
        FileInputStream fis = new FileInputStream(realPath+"/"+fileName);
        if (fis != null) {
            ObjectInputStream ois = new ObjectInputStream(fis);
            Book book = (Book) ois.readObject();
            out.print("<div class=\"bookListInfo-mainFrame\">\n" +
                    "    <div class=\"bookListInfo-mainFrame-image\">\n" +
                    "        <img src=\"fileSave/"+book.getFileImage()+"\"\n" +
                    "             alt=\""+book.getFileImage()+"\">\n" +
                    "    </div>\n" +
                    "    <div class=\"bookListInfo-mainFrame-info\">\n" +
                    "        <h2 class=\"bookListInfo-mainFrame-info-header\">\n" +
                    "            <h2>"+book.getName()+"</h2>\n" +
                    "        </h2>\n" +
                    "        <div class=\"bookListInfo-mainFrame-info-explanation\">\n" +
                    "          "+book.getInfo()+"</div>\n" +
                    "        <br>\n" +
                    "        <br>\n" +
                    "        <span\n" +
                    "        >"+book.getAuthor()+" |\n" +
                    "          "+book.getPublisher()+" |\n" +
                    "          "+book.getPrice()+"</span>\n" +
                    "    </div>\n" +
                    "</div>");
        }
    }
%>

<jsp:include page="footer.jsp"/>
</body>
</html>
