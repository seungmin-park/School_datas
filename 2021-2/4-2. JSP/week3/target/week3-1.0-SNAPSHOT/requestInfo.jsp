<%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-09-12
  Time: 오후 11:48
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
    <h3>클라이언트 및 서버 정보</h3>
    클라이언트 IP        = <%=request.getRemoteAddr()%><br>
    요청정보 길이        = <%=request.getContentLength()%><br>
    요청정보 인코딩        = <%=request.getCharacterEncoding()%><br>
    요청정보 컨텐츠타입        = <%=request.getContentType()%><br>
    요청정보 프로토콜        = <%=request.getProtocol()%><br>
    요청정보 전송방식        = <%=request.getMethod()%><br>
    요청 URL        = <%=request.getRequestURL()%><br>
    요청 URI        = <%=request.getRequestURI()%><br>
    컨텍스트 정보        = <%=request.getContextPath()%><br>
    서버 이름        = <%=request.getServerName()%><br>
    서버 포트        = <%=request.getServletPath()%><br>
</body>
</html>
