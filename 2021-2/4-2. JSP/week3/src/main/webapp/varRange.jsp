<%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-09-12
  Time: 오후 11:03
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
  <h3>변수의 범위</h3>
    <%!
        //선언문 - 선언문 내에서 선언된 변수는 전역 변수입니다.
        String strVar = "전역변수 입니다";
    %>

    <%!
        //선언문 - 메소드 선언
        String getStrVar(){
            return strVar;
        }
    %>
    <%
        //스크립틀릿 - 스크립틀릿 내에서 정의된 변수는 지역변수 입니다.
        String strVar2 = "지역변수 입니다.";
    %>
    <br>
    선언문에서     선언한 변수 strVar = <%=getStrVar()%><br>
    스크립틀릿에서 선언한 변수 strVar2 = <%=strVar2%><br>
</body>
</html>
