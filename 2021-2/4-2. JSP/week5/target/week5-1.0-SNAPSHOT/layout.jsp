<%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-09-26
  Time: 오후 10:15
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<table width="400" border="1" cellpadding="0" cellspacing="0">
    <tr><td colspan="2">
        <jsp:include page="/top.jsp" flush="false"></jsp:include>
    </td>
    </tr>
    <tr><td width="100" valign="top">
        <jsp:include page="/left.jsp" flush="false"></jsp:include>
    </td>
        <td width="300" valign="top">
<%--내용 부분 : 시작--%>
            레이아웃1<br><br><br>
    <jsp:include page="/info.jsp" flush="false"></jsp:include>
    <%--내용 부분 : 끝--%>
        </td>
    </tr>
    <tr><td colspan="2">
        <jsp:include page="/bottom.jsp" flush="false"></jsp:include>
    </td>
    </tr>
</table>
</body>
</html>
