<%@ page import="java.io.BufferedReader" %>
<%@ page import="java.io.FileReader" %><%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-09-19
  Time: 오후 11:05
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
    <h3>절대 경로를 이용한 파일 읽기</h3>
    <%
        String real = application.getRealPath("test.txt");
        BufferedReader br = new BufferedReader(new FileReader(real));

        while (true){
            String str = br.readLine();
            if (str == null){
                break;
            }
            out.println(str+ "<br>");
        }

        br.close();
    %>
</body>
</html>
