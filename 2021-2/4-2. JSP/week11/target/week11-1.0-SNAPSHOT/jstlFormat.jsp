<%@ page import="java.util.Date" %><%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-11-11
  Time: 오후 7:19
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%@taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@taglib prefix="fmt" uri="http://java.sun.com/jsp/jstl/fmt" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<c:set var="date" value="<%=new Date()%>" />
[오늘 날짜] <fmt:formatDate value="${date}" /> <br>
[현재 시각] <fmt:formatDate value="${date}" type="time"/> <hr>
[오늘 날짜] <fmt:formatDate value="${date}" type="date" pattern="yyyy/MM/dd(E)"/> <br>
[현재 시각] <fmt:formatDate value="${date}" type="time" pattern="(a)hh:mm:ss"/> <hr>
금액 : <fmt:formatNumber value="1000000" type="currency" currencySymbol="$" /> <br>
퍼센트 : <fmt:formatNumber value="0.95" type="percent" />
<fmt:setLocale value="en" />
지역 설정 변경 : 미국 <br>
[오늘 날짜] <fmt:formatDate value="${date}"/> <br>
[현재 시각] <fmt:formatDate value="${date}" type="time"/><hr>

<fmt:setLocale value="ja_jp" />
지역 설정 변경 : 일본 <br>
[오늘 날짜] <fmt:formatDate value="${date}"/> <br>
[현재 시각] <fmt:formatDate value="${date}" type="time"/><hr>
</body>
</html>
