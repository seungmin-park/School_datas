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
    String id = request.getParameter("id");
    String password = request.getParameter("password");
    if (id.equals(password)) {
        session.setAttribute("id", id);

%>
<script type="text/javascript">
    alert("로그인에 성공하였습니다.");
    location.href = "sessionLoginOk.jsp";
</script>
<%}
    else{ //로그인에 실패한 경우%>
<script type="text/javascript">
    alert("로그인에 실패하였습니다.")
    history.go(-1);
</script>
<%
    }
%>
</body>
</html>
