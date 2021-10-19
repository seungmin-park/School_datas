<%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-10-18
  Time: 오후 9:49
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <link rel="stylesheet" href="css/style.css" type="text/css">
    <title>Title</title>
</head>
<body>
<jsp:include page="header.jsp"/>
<div class="bookInsertFormHeader">
    <span class="bookInsertFormHeader-title">도서 등록</span>
</div>
<div class="bookRegistration">
    <form action="BookInfo.jsp" method="post" enctype="multipart/form-data">
    <table class="bookRegistration-table">
        <tr>
            <td class="bookRegistration-table-title">도서 코드</td>
            <td><input type="text" name="code"></td>
        </tr>
        <tr>
            <td class="bookRegistration-table-title">도서 명</td>
            <td><input type="text" name="name"></td>
        </tr>
        <tr>
            <td class="bookRegistration-table-title">가격</td>
            <td><input type="text" name="price"></td>
        </tr>
        <tr>
            <td class="bookRegistration-table-title">저자</td>
            <td><input type="text" name="author"></td>
        </tr>
        <tr>
            <td class="bookRegistration-table-title">출판사</td>
            <td><input type="text" name="publisher"></td>
        </tr>
        <tr>
            <td class="bookRegistration-table-title">출판일</td>
            <td><input type="text" name="publishingDate"></td>
        </tr>
        <tr>
            <td class="bookRegistration-table-title">총 페이지 수</td>
            <td><input type="text" name="page"></td>
        </tr>
        <tr>
            <td class="bookRegistration-table-title">상세 정보</td>
            <td><textarea name="info" cols="30" rows="10"></textarea></td>
        </tr>
        <tr>
            <td class="bookRegistration-table-title">분류</td>
            <td><input type="text" name="category"></td>
        </tr>
        <tr>
            <td class="bookRegistration-table-title">재고 수</td>
            <td><input type="text" name="count"></td>
        </tr>
        <tr>
            <td class="bookRegistration-table-title">상태</td>
            <td>
            <input type="radio" name="status" value="new">신규도서
            <input type="radio" name="status" value="used">중고도서
            <input type="radio" name="status" value="electro">E-book
            </td>
        </tr>
        <tr>
            <td>이미지</td>
            <td><input type="file" name="fileImage"></td>
        </tr>
        <tr>
            <td colspan="2">
                <input type="submit" value="등록">

            </td>
        </tr>
    </table>
    </form>
</div>
<jsp:include page="footer.jsp"/>
</body>
</html>
