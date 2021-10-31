<%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-10-31
  Time: 오후 10:06
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<%
    request.setAttribute("name","홍길동");
    session.setAttribute("ID", "admin");
    application.setAttribute("appValue","EL Object");
%>
<h3>
    요청 URI : ${pageContext.request.requestURI}<br>
    code의 파라미터 : ${param.code}<br>
    쿠키의 JSESSIONID 값 : ${cookie.JSESSIONID.value}<br>
    request의 name 속성 : ${requestScope.name}<br>
    session의 ID 속성 : ${sessionScope.ID}<br>
    appication의 appValue 속석 : ${applicationScope.appValue}<br>
</h3>
<br><br>
<h3>
    request의 name 속성 : ${name} <br>
    session의 ID 속성 : ${ID} <br>
    appication의 appValue 속성 : ${appValue}
</h3>
</body>
</html>
