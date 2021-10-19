<%@ page contentType="text/html; charset=UTF-8" pageEncoding="UTF-8" %>
<!DOCTYPE html>
<html>
<head>
    <title>JSP - Hello World</title>
    <link rel="stylesheet" href="css/style.css" type="text/css">
</head>
<body>
    <jsp:include page="header.jsp" flush="false"/>
    <div class="indexMainPage">
        <div class="mainPage">
            <p class="pageTitle">도서 웹 쇼핑몰</p>
        </div>
        <div class="subInfo">
            <span class="welcomeMessage">Welcome to Book Market!</span>
            <span class="viewCurrentTime"></span>
        </div>
    </div>
    <jsp:include page="footer.jsp" flush="false"/>
    <script src="js/realTime.js"></script>
</body>
</html>