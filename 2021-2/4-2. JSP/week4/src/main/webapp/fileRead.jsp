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
        //같은 webapp 폴더에 있다고 해서 읽어올 수 없다
        //String path = "test.txt";

        //반드 시 workspace 경로를 통해 프로젝트 폴더까지 지정해 주어야 한다.
        String path = "C:\\Users\\tmdla\\OneDrive\\바탕 화면\\github\\School_datas\\2021-2\\4-2. JSP\\week4\\src\\main\\webapp\\test.txt";

        BufferedReader br = new BufferedReader(new FileReader(path));

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
