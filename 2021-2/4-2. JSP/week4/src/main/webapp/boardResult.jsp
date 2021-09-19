<%@ page import="java.io.BufferedReader" %>
<%@ page import="java.io.FileReader" %><%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-09-19
  Time: 오후 11:34
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
    <h3>게시판 내용</h3>
    <%
        String fileName = request.getParameter("fileName");
        String file = application.getRealPath("/WEB-INF/board/"+fileName);

        BufferedReader br = new BufferedReader(new FileReader(file));

        while (true){
            String str = br.readLine();
            if (str == null){
                break;
            }
            out.println(str+"<br>");
        }

        br.close();
    %>
</body>
</html>
