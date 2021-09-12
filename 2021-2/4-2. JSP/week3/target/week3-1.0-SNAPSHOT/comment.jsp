<%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-09-12
  Time: 오후 11:22
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<%-- 이 페이지는 JSP에 의해 생성된 HTML 문서입니다.--%>

<%
    int result = 1;

//    1부터 10 까지 곱하는 반복문
    for (int cnt = 1 ; cnt <= 10; cnt++){
        result *= cnt;
    }
%>
<br>
1부터 10까지 곱한 값은 ? <%-- <%=result%> --%>
</body>
</html>
