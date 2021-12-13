<%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-11-25
  Time: 오후 5:27
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<form action="inputEmpProc.jsp" name="frm" onsubmit="return check()">
    <table border="1" style="text-align: center">
        <tr><td colspan="2">사원 등록 화면</td></tr>
        <tr>
            <td bgcolor="orange">사번</td>
            <td><input type="text" name="empno" autofocus="autofocus"></td>
        </tr>
        <tr>
            <td bgcolor="orange">이름</td>
            <td><input type="text" name="name"></td>
        </tr>
        <tr>
            <td bgcolor="orange">부서코드</td>
            <td><input type="text" name="dept"></td>
        </tr>
        <tr>
            <td bgcolor="orange">업무</td>
            <td><input type="text" name="job"></td>
        </tr>
        <tr>
            <td bgcolor="orange">급여</td>
            <td><input type="text" name="sal"></td>
        </tr>
        <tr>
            <td colspan="2">
                <input type="submit" value="등록">
                <input type="reset" value="취소">
            </td>
        </tr>
    </table>
</form>
<br>
<br>
<form action="menu.jsp">
    <input type="submit" value="메뉴화면">
</form>
</body>
<script type="text/javascript">
    function check() {
        if (!frm.empno.value) {
            alert("사원번호를 입력하세요");
            frm.empno.focus();
            return false;
        }
        if (!frm.name.value) {
            alert("이름을 입력하세요");
            frm.name.focus();
            return false;
        }
        if (!frm.dept.value) {
            alert("부서코드를 입력하세요");
            frm.dept.focus();
            return false;
        }
        if (!frm.job.value) {
            alert("업무를 입력하세요");
            frm.job.focus();
            return false;
        }
        if (!frm.sal.value) {
            alert("급여를 입력하세요");
            frm.sal.focus();
            return false;
        }
    }
</script>
</html>
