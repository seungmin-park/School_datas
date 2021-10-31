<%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-10-31
  Time: 오후 10:44
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
${varList = [2,11,7,4,8,5]; ''}
${varList.stream().sum()}<br>
${varList.stream().max().get()}<br>
${varList.stream().min().get()}<br>
${varList.stream().average().get()}<br>
${varList.stream().filter(x -> x % 2 == 0).toList()}<br>
${varList.stream().map(x -> x * x).toList()}<br>
${varList.stream().sorted().toList()}<br>
${varList.stream().count()}<br>
<hr>
4.정렬 <br>
${vals=[20,17,30,2,9,23];sorerdVals=vals.stream().sorted().toList()}<br>
${vals=[20,17,30,2,9,23];sorerdVals=vals.stream().sorted((x1,x2) -> x1<x2 ? 1:-1).toList()}<br>
</body>
</html>
