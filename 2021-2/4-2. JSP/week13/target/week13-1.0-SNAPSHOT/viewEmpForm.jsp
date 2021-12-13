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
<h3>사원 정보 조회</h3>
<form action="viewEmpQuery.jsp" name="frm" onsubmit="return check()">
    조회할 사원 번호를 입력하세요 : <input type="number" name="empno" autofocus="autofocus">
    <br>
    <br>
    <input type="submit" value="확인">
    <input type="reset" value="취소">
</form>
<br>
<button onsubmit="location.href='menu.jsp'">메뉴화면</button>
</body>
<script type="text/javascript">
    function check() {
        if (!frm.empno.value)
            alert("사원 번호를 입력하세요")
        frm.empno.focus();
        return false;
    }
</script>
</html>
