<%--
  Created by IntelliJ IDEA.
  User: tmdla
  Date: 2021-10-11
  Time: 오전 1:17
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
  <title> 재생 </title>
</head>

<body>
<input type="button" onclick="Player.controls.play();" value="재생">
<input type="button" onclick="Player.controls.stop();" value="정지">
<input type="button" onclick="Player.controls.pause();" value="일시정지">

<a href=<%=request.getParameter("file")%>>다운받기</a>



<OBJECT ID="Player" CLASSID="CLSID:6BF52A52-394A-11d3-B153-00C04F79FAA6">
  <PARAM name="autoStart" value="False">
  <PARAM name="URL" value=<%=request.getParameter("file")%>>
  <PARAM name="uiMode" value="invisible">
</OBJECT>
</body>
</html>
</html>
