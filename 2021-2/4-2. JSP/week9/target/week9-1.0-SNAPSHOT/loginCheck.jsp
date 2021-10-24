<%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-10-24
  Time: 오후 10:36
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<h3>로그인 여부 판단</h3>
<%
  boolean sw = false;
  Cookie[] cookies = request.getCookies();
  if (cookies != null && cookies.length > 0) {
    for (Cookie c : cookies) {
      if (c.getName().equals("id")) {
        out.println("아이디 " + c.getValue() + "로 로그인 한 상태");
        sw = true;
        break;
      }
    }
  }

  if (!sw) {
    out.println("로그인 하지 않은 상태");
  }
%>
</body>
</html>
