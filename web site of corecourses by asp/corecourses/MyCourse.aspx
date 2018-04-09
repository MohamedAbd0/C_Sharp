<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyCourse.aspx.cs" Inherits="corecourses.MyCourse" %>

<!DOCTYPE html>

<html  dir="rtl">
    
    <head> 
    <!-- CSS -->
    <link rel="stylesheet" href="./كورسات_files/bootstrap.css">
    <link rel="stylesheet" href="./كورسات_files/bootstrap.rtl.css">
    <link rel="stylesheet" href="./كورسات_files/font-awesome.min.css">
    <link rel="stylesheet" href="./كورسات_files/style.css">
    <link rel="stylesheet" href="./كورسات_files/rtl-xtra.css">
    <link rel="shortcut icon" type="image/x-icon" href="coursat.png">
        <title>CoreCourses</title>
        <style type="text/css">
          
             .titlecourse {
         font-size:x-large;
         font:bold;
         color:red;
        }
        .auto-style1 {
            width: 550px;
        }
        .auto-style2 {
            text-align: center;
            width: 300px;
        }
        .auto-style3 {
            text-align: center;
            height: 23px;
            width: 300px;
        }

        td {
            width:300px;
        }
        </style>
    </head>

    <body>

        <form id="form1" runat="server">

    <!--Navbar-->
    <nav class="navbar navbar-inverse navbar-fixed-top">
      <div class="container">
        <div class="navbar-header">
        <a class="navbar-brand" href="Home2.aspx"><img src="logo.png" height="75px" alt="Co"></a>
    </div>
<!-- Navbar Right -->

<div class="collapse navbar-collapse js-navbar-collapse" id="ournavbar">

<ul class="nav navbar-nav navbar-left">
              <li>    <img src="login.PNG" height="80px"/></li>
            <li><a href="Home2.aspx"> Home Page</a></li>
            <li><img src="reg.PNG"  height="80px"/></li>
            <li><a href="Login.aspx" > Logout </a></li>

            
 </ul>
</div>
</div>
</nav>


       <div style=" width:700px; background-color:#E6E6FA;margin-top:50px;border-radius:10px; margin-right:300px;">

    
        <table class="auto-style1" style="margin-right:50px;margin-top:20px;margin-bottom:20px" >
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label1" runat="server" Text="Course Name" CssClass="titlecourse"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblname" runat="server" Font-Size="13pt"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="lable0" runat="server" Text="instructor Name" CssClass="titlecourse"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="lbltrainer" runat="server" Font-Size="13pt"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="labll" runat="server" Text="Time Of Course" CssClass="titlecourse"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="lbltime" runat="server" Font-Size="13pt"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label3" runat="server" Text="Description Of Course" CssClass="titlecourse"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lbldes" runat="server" Font-Size="13pt"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label4" runat="server" Text="Video Of Course" CssClass="titlecourse"></asp:Label>
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <iframe width="500" height="400" src="https://www.youtube.com/embed/playlist?list=PLwj1YcMhLRN24KqNI0xQrNscBfLnYeJpL&loop=1">
                    </iframe>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
            <div class="footer text-center">

    <div class="container">

        <p>
            &nbsp;</p>

    <ul class="list-unstyled footer-links">
        <li><a href=" ">About CoreCourses</a></li>
        <li><a href=" ">Contact us</a></li>
    </ul>

    <div>
        <ul class="list-unstyled footer-social">
            <li><a href="https://twitter.com/CoreCourse">twitter  </a></li>
            <li><a href="https://www.facebook.com/CoreCourse"> facebook  </a></li>
        </ul>
    </div>

    
    
</div>

<div class="copyright text-center">
© 2017 <span><a href=" ">Core Courses</a></span> 
</div>
    
</div>
    </form>

</body>
</html>
