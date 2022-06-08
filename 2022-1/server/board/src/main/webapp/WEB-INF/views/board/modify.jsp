<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>

<%@include file="../include/header.jsp"%>

READ BOARD

<form role="form" method="post">
		<div>
			<label>BNO</label>
			 <input type="text"	name='bno'value="${boardVO.bno}"	readonly="readonly">
		</div>

		<div>
			<label>Title</label> 
			<input type="text"	name='title'  value="${boardVO.title}">
		</div>
		<div>
			<label>Content</label>
			<textarea name="content" rows="3">${boardVO.content}</textarea>
		</div>
		<div >
			<label>Writer</label> 
			<input	type="text" name="writer" value="${boardVO.writer}">
		</div>


</form>


<div>
	<button type="submit" class="modify">SAVE</button>
	<button type="submit" class="listall">CANCEL</button>
</div>

<script>
	$(document).ready(function() {

		var formObj = $("form[role='form']");

		console.log(formObj);

		//cancel 버튼 클릭시 /board/listAll로 이동
		$(".listall").on("click", function() {
			self.location = "/board/listAll";
		});

		//save 버튼 클릭시 from submit 실행 -> input value를 통해 update 실행
		$(".modify").on("click", function() {
			formObj.submit();
		});

	});
</script>




<%@include file="../include/footer.jsp"%>
