<%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-10-31
  Time: 오후 10:15
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
${param.id}님 안녕하세요. <br>
관심있는 스포츠 : ${paramValues.sports[0]}
                ${paramValues.sports[1]}
                ${paramValues.sports[2]}
                ${paramValues.sports[3]}
</body>
</html>
