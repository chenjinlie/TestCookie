<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="F.aspx.cs" Inherits="FCookie.F" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <a href="http://localhost:9902/">Z</a>
        </div>
    </form>
</body>
</html>
<script src="http://libs.baidu.com/jquery/2.0.0/jquery.min.js"></script>
<script type="text/javascript">
    //$(function () {

    //})
    //var script = document.createElement('script');
    //script.type = 'text/javascript';

    //// 传参一个回调函数名给后端，方便后端返回时执行这个在前端定义的回调函数
    //script.src = 'http://localhost:9902/Z.aspx?user=admin&callback=handleCallback';
    //document.head.appendChild(script);
    
    $.getScript("http://localhost:9902/");
    //function handleCallback(res) {
    //    alert(JSON.stringify(res));
    //}

</script>
