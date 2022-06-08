<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>

<%@include file="../include/header.jsp"%>

READ BOARD

<form role="form" method="post">

	<input type='hidden' name='bno' value="${boardVO.bno}">

</form>

	<div>
		<label>Title</label> 
		<input type="text"	name="title"  value="${boardVO.title}"	readonly="readonly">
	</div>
	<div>
		<label>Content</label>
		<textarea name="content" rows="3" readonly="readonly">${boardVO.content}</textarea>
	</div>
	<div>
		<label>Writer</label> 
		<input type="text"	name="writer"  value="${boardVO.writer}" readonly="readonly">
	</div>


<div>
	<button type="submit" class="modify">Modify</button>
	<button type="submit" class="delete">REMOVE</button>
	<button type="submit" class="listall">LIST ALL</button>
</div>


<script>
					
	$(document).ready(function(){
		
		var formObj = $("form[role='form']");
		
		console.log(formObj);
		
		$(".modify").on("click", function(){
			formObj.attr("action", "/board/modify");
			formObj.attr("method", "get");		
			formObj.submit();
		});
		
		$(".delete").on("click", function(){
			formObj.attr("action", "/board/remove");
			formObj.submit();
		});
		
		$(".listall").on("click", function(){
			self.location = "/board/listAll";
		});
		
	});

</script>




<%@include file="../include/footer.jsp"%>
