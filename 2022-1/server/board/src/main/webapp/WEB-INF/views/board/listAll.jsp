<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c"%>
<%@ taglib prefix="fmt" uri="http://java.sun.com/jsp/jstl/fmt"%>
<%@ page session="false"%>

<%@include file="../include/header.jsp"%>


<h3>LIST ALL PAGE</h3>
			
				
<table>
	<tr>
		<th>BNO</th>
		<th>TITLE</th>
		<th>WRITER</th>
		<th>REGDATE</th>
		<th>VIEWCNT</th>
	</tr>

<%--
controller에서 설정한 model을 통해 반복문
for(BoardVO boardVO : list){
...
}
fmt:formatDate를 사용하여 Date타입 formatting
--%>
<c:forEach items="${list}" var="boardVO">

	<tr>
		<td>${boardVO.bno}</td>
		<td><a href='/board/read?bno=${boardVO.bno}'>${boardVO.title}</a></td>
		<td>${boardVO.writer}</td>
		<td><fmt:formatDate pattern="yyyy-MM-dd HH:mm"
				value="${boardVO.regdate}" /></td>
		<td>${boardVO.viewcnt }</td>
	</tr>

</c:forEach>

</table>

				
<script>
<%--
remove 실행시 listAll로 redirect시 redirect attribute 사용
--%>
    var result = '${msg}';
    
    if(result == 'SUCCESS'){
    	alert("처리가 완료되었습니다.");
    }
    
    </script>

<%@include file="../include/footer.jsp"%>
