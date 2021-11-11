<%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-11-11
  Time: 오후 5:43
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<%
    int[] list = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

    if (list.length > 0) {
        for (int i = 0; i < list.length; i++) {
%>
    <%=list[i]%>
<%      }
    }else{
%>
배열에 저장된 데이터가 없습니다.
<%}
%>
</body>
</html>
