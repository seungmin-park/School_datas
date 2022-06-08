<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>

<%@include file="../include/header.jsp"%>

<!-- Main content -->
<section class="content">
	<div class="row">
		<!-- left column -->
		<div class="col-md-12">
			<!-- general form elements -->
			<div class="box box-primary">
				<div class="box-header">
					<h3 class="box-title">MODIFY BOARD</h3>
				</div>
				<!-- /.box-header -->

				<%-- submit 발생 시 /modifyPage 로 이동 수정 전에 있던 페이지로 되돌아가기 위해 hidden input을 사용해 page, perPageNum 사용--%>
				<form role="form" action="modifyPage" method="post">

					<input type='hidden' name='page' value="${cri.page}"> <input
						type='hidden' name='perPageNum' value="${cri.perPageNum}">

					<div class="box-body">

						<div class="form-group">
							<label >BNO</label>
							<input type="text" name='bno' class="form-control" value="${boardVO.bno}" readonly="readonly">
						</div>

						<div class="form-group">
							<label >Title</label>
							<input type="text" name='title' class="form-control" value="${boardVO.title}">
						</div>
						<div class="form-group">
							<label >Content</label>
							<textarea class="form-control" name="content" rows="3">${boardVO.content}</textarea>
						</div>
						<div class="form-group">
							<label >Writer</label> <input type="text" name="writer" class="form-control" value="${boardVO.writer}">
						</div>
					</div>
					<!-- /.box-body -->
				</form>
				<div class="box-footer">
					<button type="submit" class="btn btn-primary">SAVE</button>
					<button type="submit" class="btn btn-warning">CANCEL</button>
				</div>

				<script>
					$(document)
							.ready(
									function() {

										var formObj = $("form[role='form']");

										console.log(formObj);

										//cancel 버튼 클릭시 사용자가 이전에 머물렀던 페이지로 이동
										$(".btn-warning")
												.on(
														"click",
														function() {
															self.location = "/board/listPage?page=${cri.page}&perPageNum=${cri.perPageNum}";
														});

										//save 버튼 클릭시 form submit 실행
										$(".btn-primary").on("click",
												function() {
													formObj.submit();
												});

									});
				</script>




			</div>
			<!-- /.box -->
		</div>
		<!--/.col (left) -->

	</div>
	<!-- /.row -->
</section>
<!-- /.content -->
</div>
<!-- /.content-wrapper -->

<%@include file="../include/footer.jsp"%>
