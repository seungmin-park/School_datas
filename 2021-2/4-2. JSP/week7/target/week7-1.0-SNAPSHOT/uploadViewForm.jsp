<%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-10-11
  Time: 오전 12:21
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<%
    String fileSave = "/fileSave";
    String real = application.getRealPath(fileSave);
    request.setCharacterEncoding("UTF-8");
    String fileName = request.getParameter("fileName");
%>
<table border="1" width="300px" style="text-align: center">
    <caption>업로드 파일</caption>
    <tr>
        <th>텍스트</th>
        <td><a href="fileView.jsp?fileName=<%=fileName%>">텍스트 파일 보기</a></td>
    </tr>
    <tr>
    <th>이미지</th>
    <td><a href="imageView.jsp?fileName=<%=fileName%>">이미지 파일 보기</a></td>
    </tr>
    <th>음악</th>
    <td>
        <a href="audio.jsp?fileName=<%=fileName%>">음악 파일 듣기</a>
    </td>
    </tr>
</table>
<br>
<button onclick="location.href='uploadForm.jsp'">돌아가기</button>
</body>
</html>
