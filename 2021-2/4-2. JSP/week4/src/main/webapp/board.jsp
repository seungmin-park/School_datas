<%@ page import="java.util.Date" %>
<%@ page import="java.io.FileWriter" %>
<%@ page import="java.io.IOException" %><%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-09-19
  Time: 오후 11:17
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
    <h3>게시판 글쓰기 결과화면</h3>
    <%
        request.setCharacterEncoding("utf-8");
        String name = request.getParameter("name");
        String title = request.getParameter("title");
        String content = request.getParameter("content");

        Date date = new Date();
        Long time = date.getTime();
        String fileName = time + ".txt";
        String filePath = application.getRealPath("/WEB-INF/board/" + fileName);

        FileWriter writer = new FileWriter(filePath);
        try {
            String str = "제목 : " + title + "\n";
            str += "글쓴이 : " + name + "\n";
            str += content;
            writer.write(str);
            out.println("저장되었습니다.<br>");
        }catch (IOException e){
            out.println("파일을 저장할 수 없습니다.");
        }finally {
            writer.close();
        }
    %>
    <form action="boardResult.jsp">
        <input type="hidden" name="fileName" value=<%=fileName%>>
        <input type="submit" value="내용보기">
    </form>
</body>
</html>
