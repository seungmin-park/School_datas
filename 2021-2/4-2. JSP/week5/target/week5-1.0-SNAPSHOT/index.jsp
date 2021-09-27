<%@ page import="java.util.Date" %>
<%@ page import="java.text.SimpleDateFormat" %>
<%@ page contentType="text/html; charset=UTF-8" pageEncoding="UTF-8" %>
<!DOCTYPE html>
<html>
<head>
    <title>JSP - Hello World</title>
</head>
<body>
<%
    Date date = new Date();
    SimpleDateFormat simpleDateFormat = new SimpleDateFormat("yyyy년 MM월 dd일 hh:mm:ss");
%>
<style>
    div{
        display: flex;
        justify-content: center;
        align-items: center;
    }
</style>
<table width="100%" cellpadding="0" cellspacing="0">
    <tr>
        <jsp:include page="menu.jsp" flush="false"/>
    </tr>
    <tr>
        <div style="flex-direction: column;">
            <div style="height: 240px; width: 100%; background-color: #EAEAEA; ">
                <p style="font-weight: 600;font-size: 30px">웹 쇼핑몰에 오신것을 환영합니다</p>
            </div>
            <p style="font-size: 20px"><b>Welcome to Web Market!</b></p>
            <p>현재 접속 시각 : <%=simpleDateFormat.format(date)%></p>
        </div>
    </tr>
    <tr>
        <hr>
        <jsp:include page="footer.jsp" flush="false"/>
    </tr>
</table>
</body>
</html>