<%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-10-24
  Time: 오후 9:40
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<%
    session.invalidate();
%>
<script type="text/javascript">
    alert("로그아웃 되었습니다.")
    location.href = "sessionLoginForm.jsp";
</script>
</body>
</html>
