<%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-11-25
  Time: 오후 6:37
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%@taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<h3>사원 정보 수정 화면</h3>
<form action="updateEmpProc.jsp" name="frm" onsubmit="return check()">
<c:if test="${result == 1}">
    <table border="1" style="width: 300px; text-align: center">
        <tr>
            <td bgcolor="orange">사원번호</td>
            <td>${empno} <input type="hidden" name="empno" value="${empno}"></td>
        </tr>
        <tr>
            <td bgcolor="orange">이름</td>
            <td>${empname}</td>
        </tr>
        <tr>
            <td bgcolor="orange">부서코드</td>
            <td><input type="text" name="empdept" value="${empdept}" autofocus="autofocus"></td>
        </tr>
        <tr>
            <td bgcolor="orange">업무</td>
            <td><input type="text" name="empjob" value="${empjob}"></td>
        </tr>
        <tr>
            <td bgcolor="orange">급여</td>
            <td><input type="text" name="empsal" value="${empsal}"></td>
        </tr>
        <tr>
            <td colspan="2">
                <input type="submit" value="수정">&nbsp;<input type="reset"value="취소">
            </td>
        </tr>
    </table>
</c:if>
</form>
<br>
<br>
<button onclick="location.href='viewEmpQuery.jsp?empno=${empno}'">돌아가기</button>
<script type="text/javascript">
    function check() {
        if (!frm.empdept.value) {
            alert("부서코드를 입력하세요");
            frm.empdept.focus();
            return false;
        }
        if (!frm.empjob.value) {
            alert("부서코드를 입력하세요");
            frm.empjob.focus();
            return false;
        }
        if (!frm.empsal.value) {
            alert("부서코드를 입력하세요");
            frm.empsal.focus();
            return false;
        }
        return true;
    }
</script>
</body>
</html>
