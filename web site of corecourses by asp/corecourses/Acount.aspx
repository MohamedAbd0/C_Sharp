<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Acount.aspx.cs" Inherits="corecourses.Acount" %>

<!DOCTYPE html>

<html  dir="rtl">
    
    <head> 
    <!-- CSS -->
    <link rel="stylesheet" href="./كورسات_files/bootstrap.css">
    <link rel="stylesheet" href="./كورسات_files/bootstrap.rtl.css">
    <link rel="stylesheet" href="./كورسات_files/font-awesome.min.css">
    <link rel="stylesheet" href="./كورسات_files/style.css">
    <link rel="stylesheet" href="./كورسات_files/rtl-xtra.css">
    
        <title>CoreCourses</title>
        <style type="text/css">
            .auto-style1 {
                width: 179px;
                height: 50px;
            }
            .auto-style2 {
                width: 300px;
                height: 50px;
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


       <div style="height:500px; width:75%; background-color:#E6E6FA;margin-top:50px;border-radius:10px;margin-right:180px;">

    <table style="width: 50%; margin-left: 14px; margin-right: 270px;">
    <tr>
        <td style="color: #000000; font-size: large; font-weight: bold;" class="text-center" colspan="2">Edit Your profile</td>
    </tr>
    <tr>
        <td style="width: 179px; color: #000000; font-size: large; font-weight: bold;">&nbsp;</td>
        <td class="modal-sm">
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 179px; color: #000000; font-size: large; font-weight: bold;">Your F-Name<br />
            <br />
        </td>
        <td class="modal-sm">
            <asp:TextBox ID="txtfname" runat="server" Width="270px" Font-Size="12pt"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 179px; color: #000000; font-size: large; font-weight: bold;">Your L-Name<br />
            <br />
        </td>
        <td class="modal-sm">
            <asp:TextBox ID="txtlname" runat="server" Width="270px" Font-Size="12pt"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 179px; color: #000000; font-size: large; font-weight: bold;">Your Password<br />
            <br />
        </td>
        <td class="modal-sm">
            <asp:TextBox ID="txtpassword" runat="server" TextMode="Password" Width="270px" Font-Size="12pt"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 179px; color: #000000; font-size: large; font-weight: bold;">Confirm Password<br />
            <br />
        </td>
        <td class="modal-sm">
            <asp:TextBox ID="txtconfirm" runat="server" TextMode="Password" Width="270px" Font-Size="12pt"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 179px; color: #000000; font-size: large; font-weight: bold;">&nbsp;Your Email<br />
            <br />
        </td>
        <td class="modal-sm">
            <asp:TextBox ID="txtemail" runat="server" Font-Size="12pt" Width="270px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="color: #000000; font-size: large; font-weight: bold;" class="auto-style1">Your Age<br />
            <br />
        </td>
        <td class="auto-style2">
            <asp:TextBox ID="txtage" runat="server" Font-Size="12pt" Width="270px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 179px; color: #000000; font-size: large; font-weight: bold;">Your Collage<br />
            <br />
        </td>
        <td class="modal-sm">
            <asp:TextBox ID="txtcollage" runat="server" Font-Size="12pt" Width="270px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 179px; color: #000000; font-size: large; font-weight: bold;">Gender</td>
        <td class="modal-sm">
            <asp:RadioButtonList ID="rbtgender" runat="server">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:RadioButtonList>
        </td>
    </tr>
    <tr>
        <td style="width: 179px">&nbsp;</td>
        <td class="modal-sm">&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 179px">&nbsp;</td>
        <td class="modal-sm">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnsubmit" runat="server" Text="Updata My Data" Width="139px" OnClick="btnsubmit_Click" ForeColor="Black" />
            <br />
        </td>
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
<!-- End Footer -->
        </form>
</body></html>
