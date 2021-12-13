<%@ page language="java" contentType="text/html; charset=UTF-8"
         pageEncoding="UTF-8"%>
<%@ page import="java.io.PrintWriter" %>
<!DOCTYPE html>
<html>
<head>
  <meta charset="UTF-8">
  <!-- 화면 최적화 -->
  <meta name="viewport" content="width-device-width", initial-scale="1">
  <!-- 루트 폴더에 부트스트랩을 참조하는 링크 -->
  <link rel="stylesheet" href="css/bootstrap.css">
  <title>오늘의 밥, 당신의 건강한 아침을 위하여</title>
  <style>
    .navbar-default {
      background-color: #f5f5dc;
      border-color: #e7e7e7;
    }
    .form-control {
      height: 30px;
    }
    .input-group {
      display: flex;
      justify-content: center;
      align-items: center;
    }
  </style>
</head>
<body>
<%
  int pageNumber = 1;
  // 메인 페이지로 이동했을 때 세션에 값이 담겨있는지 체크
  String userID = null;
  if(session.getAttribute("userID") != null){
    userID = (String)session.getAttribute("userID");
  }
%>
<nav class="navbar navbar-default" > <!-- 네비게이션 -->
  <div class="navbar-header">    <!-- 네비게이션 상단 부분 -->
    <!-- 네비게이션 상단 박스 영역 -->
    <button type="button" class="navbar-toggle collapsed"
            data-toggle="collapse" data-target="#bs-example-navbar-collapse-1"
            aria-expanded="false">
      <!-- 이 삼줄 버튼은 화면이 좁아지면 우측에 나타난다 -->
      <span class="icon-bar"></span>
      <span class="icon-bar"></span>
      <span class="icon-bar"></span>
    </button>
  </div>
  <!-- 게시판 제목 이름 옆에 나타나는 메뉴 영역 -->
  <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1" >
    <ul class="nav navbar-nav">
      <li>
        <div class="input-group">
          <form method="post" action="searchItem.jsp">
                     <span class="input-group-btn">
                             <input type="text" class="form-control" placeholder="검색어를 입력하세요" name="searchItem">
                              <input type="submit" class="btn btn-sm btn-default" value="검색">
                          </span>
          </form>
        </div>
      </li>
    </ul>
    <%
      // 로그인 하지 않았을 때 보여지는 화면
      if(userID == null){
    %>
    <!-- 헤더 우측에 나타나는 드랍다운 영역 -->
    <ul class="nav navbar-nav navbar-right">
      <li class="dropdown">
        <a href="#" class="dropdown-toggle"
           data-toggle="dropdown" role="button" aria-haspopup="true"
           aria-expanded="false">접속하기<span class="caret"></span></a>
        <!-- 드랍다운 아이템 영역 -->
        <ul class="dropdown-menu">
          <li><a href="login.jsp">로그인</a></li>
          <li><a href="join.jsp">회원가입</a></li>
        </ul>
      </li>
    </ul>
    <%
      // 로그인이 되어 있는 상태에서 보여주는 화면
    }else{
    %>
    <!-- 헤더 우측에 나타나는 드랍다운 영역 -->
    <ul class="nav navbar-nav navbar-right">
      <li class="dropdown">
        <a href="#" class="dropdown-toggle"
           data-toggle="dropdown" role="button" aria-haspopup="true"
           aria-expanded="false">회원관리<span class="caret"></span></a>
        <!-- 드랍다운 아이템 영역 -->
        <ul class="dropdown-menu">
          <li><a href="logoutAction.jsp">로그아웃</a></li>
        </ul>
      </li>
    </ul>
    <%
      }
    %>
  </div>
</nav>


<footer class="footer">
  <div class="container" style="margin-top:20px;">
           <span class="text-muted small">
               ©2021 • <a href="/help/wikidocs" class="normal">전세현</a>
               (문의 uhs2921@gmail.com)
           </span>
  </div>
</footer>

<!-- 부트스트랩 참조 영역 -->
<script src="https://code.jquery.com/jquery-3.1.1.min.js"></script>
<script src="js/bootstrap.js"></script>
</body>
</html>