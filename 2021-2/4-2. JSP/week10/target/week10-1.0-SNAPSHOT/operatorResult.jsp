<%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-10-31
  Time: 오후 10:19
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<h3>EL 연산자 결과</h3>
x = ${param.num1}, y = ${param.num2}<br>
x + y = ${param.num1 + param.num2}<br>
x - y = ${param.num1 - param.num2}<br>
x * y = ${param.num1 * param.num2}<br>
x / y = ${param.num1 / param.num2}<br>
x % y = ${param.num1 % param.num2}<br>
<hr>
<br>




x와 y가 모두 양수입니까? ${param.num1 > 0 && param.num2 > 0}<br>
x와 y가 같습니까? ${param.num1 == param.num2}<br>
<hr>
<br>
${var = "admin"}<br>
${strArr = ['가','나','다'];''}<br>
strArr의 값은 ${strArr}입니다. <br>
<hr>
<br>
${ var == "admin"} <br>
${strArr[0] += strArr[1] += strArr[2]}<br>
</body>
</html>
