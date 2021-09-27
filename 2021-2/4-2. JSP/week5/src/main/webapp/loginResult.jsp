<%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-09-27
  Time: 오전 1:00
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<%
        try {
            String userId = "admin";
            String name = request.getParameter("name");
            int userPasswd = 1234;
            Integer password = Integer.parseInt(request.getParameter("password"));
            if (!name.equals(userId)){%>
                아이디가 틀립니다.<br>
            <%} else if (userPasswd != password){%>
            비밀번호가 틀립니다.<br>
            <%}else {%>
            <%=name%>님, 안녕하세요!<br>
<%}
        }
        catch (Exception e){%>
            아이디나 비밀번호의 형식이 잘못 됐습니다.<br>
        <%}%>
<br>
<form action="index.jsp"method="get">
    <input type="submit" value="돌아가기">
</form>
</body>
</html>
