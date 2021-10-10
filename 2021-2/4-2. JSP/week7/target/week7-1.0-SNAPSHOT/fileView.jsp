<%@ page import="java.io.BufferedReader" %>
<%@ page import="java.io.FileReader" %><%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-10-11
  Time: 오전 12:25
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
    String path = "fileSave/" + fileName;
    String real = application.getRealPath(path);
    BufferedReader br = new BufferedReader(new FileReader(real));
%>
<h3>파일 내용 보기</h3>
파일명 = <%=fileName%><br>
소스패스 = <%=path%><br><br>
<%
    while (true){
        String str = br.readLine();
        if (str == null) {
            break;
        }
        out.println(str+"<br>");
    }
    out.println("br");
    br.close();
%>

<button onclick="location.href='uploadForm.jsp'">돌아가기</button>
</body>
</html>
