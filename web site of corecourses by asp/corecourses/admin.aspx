<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="corecourses.admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" xml:lang="en" lang="en">
 <head> 
    <!-- CSS -->
    <link rel="stylesheet" href="./كورسات_files/bootstrap.css">
    <link rel="stylesheet" href="./كورسات_files/bootstrap.rtl.css">
    <link rel="stylesheet" href="./كورسات_files/font-awesome.min.css">
    <link rel="stylesheet" href="./كورسات_files/style.css">
    <link rel="stylesheet" href="./كورسات_files/rtl-xtra.css">
<link rel="shortcut icon" type="image/x-icon" href="coursat.png">
    <!-- JavaScript -->
    <script async="" src="./كورسات_files/analytics.js.download"></script><script src="./كورسات_files/jquery-2.1.4.min.js.download"></script>
    <script src="./كورسات_files/bootstrap.min.js.download"></script>
    <script src="./كورسات_files/rating.js.download"></script>
    <script src="./كورسات_files/plugins.js.download"></script>
     <title>CoreCourses</title>

     <style type="text/css">
         .auto-style1 {
             height: 17px;
         }
         .auto-style3 {
         }
         .auto-style5 {
             width: 245px;
         }
         .auto-style6 {
             height: 22px;
         }
         .auto-style7 {
             height: 22px;
             width: 229px;
         }
         .auto-style9 {
             width: 229px;
         }
         .auto-style10 {
         }
     </style>

    </head>
<body>
     <!--Navbar-->
    <nav class="navbar navbar-inverse navbar-fixed-top">
      <div class="container">
        <div class="navbar-header">
        <a class="navbar-brand" href="Home.aspx"><img src="logo.png" height="75px" alt="Co"></a>
    </div>
<!-- Navbar Right -->

<div class="collapse navbar-collapse js-navbar-collapse" id="ournavbar">

<ul class="nav navbar-nav navbar-left">
              <li>    <img src="login.PNG" height="80px"/></li>
            <li><a href=""> Welcome Admin </a></li>
            <li><img src="reg.PNG"  height="80px"/></li>
            <li><a href="Login.aspx" > Logout</a></li>
            
 </ul>
</div>
</div>
</nav>

    <div style="height:500px; width:550px; background-color:#E6E6FA;margin-top:50px ;border-radius:10px; margin-left:400px;">

<form id="form1" runat="server">

    <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
        <asp:View ID="View1" runat="server">
            <table border="0" class="auto-style1" style="border-color: #FF0000; width: 544px;">
                    <tr>
                        <td class="auto-style1" colspan="3">
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label9" runat="server" Font-Bold="True" ForeColor="#CC0099" Text="To Working With Courses" Font-Size="12pt"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style19" colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style5">
                            &nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label6" runat="server" Text="Select Course " Font-Bold="True" Font-Size="12pt" ForeColor="Black"></asp:Label>
                            <br />
                            <br />
                        </td>
                        <td class="auto-style13">
                            <asp:DropDownList ID="DDLCourseName" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DDLCourseName_SelectedIndexChanged" Width="150px" Font-Bold="True" Font-Size="12pt">
                            </asp:DropDownList>
                        </td>
                        <td class="auto-style42">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style5">
                            &nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label1" runat="server" Text="Course Name" Font-Bold="True" Font-Size="12pt" ForeColor="Black"></asp:Label>
                            <br />
                            <br />
                        </td>
                        <td class="auto-style13">
                            <asp:TextBox ID="txtCname" runat="server" Width="270px" Font-Bold="True" Font-Size="12pt"></asp:TextBox>
                        </td>
                        <td class="auto-style42">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtCname" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style5">
                            &nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label2" runat="server" Text="Course Time" Font-Bold="True" Font-Size="12pt" ForeColor="Black"></asp:Label>
                            <br />
                            <br />
                        </td>
                        <td class="auto-style13">
                            <asp:TextBox ID="txtCTime" runat="server" Width="270px" Font-Bold="True" Font-Size="12pt"></asp:TextBox>
                        </td>
                        <td class="auto-style42">
                            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtCTime" ErrorMessage="*" ForeColor="Red" MaximumValue="450" MinimumValue="1"></asp:RangeValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style5">
                            &nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label3" runat="server" Text="Course Trainer" Font-Bold="True" Font-Size="12pt" ForeColor="Black"></asp:Label>
                            <br />
                            <br />
                        </td>
                        <td class="auto-style25">
                            <asp:TextBox ID="txtCTrainer" runat="server" Width="270px" Font-Bold="True" Font-Size="12pt"></asp:TextBox>
                        </td>
                        <td class="auto-style43">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtCTrainer" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style5" style="font-size: 12px; font-style: bold;">&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label13" runat="server" Font-Bold="True" Font-Size="12pt" Text="Tutorial of Course" ForeColor="Black"></asp:Label>
                            <br />
                            <br />
                        </td>
                        <td class="auto-style25">
                            <asp:TextBox ID="txttutorialcourse" runat="server" Width="270px" Font-Bold="True" Font-Size="12pt"></asp:TextBox>
                        </td>
                        <td class="auto-style43">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style5">
                            &nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label4" runat="server" Text="Course Details" Font-Bold="True" Font-Size="12pt" ForeColor="Black"></asp:Label>
                            <br />
                            <br />
                        </td>
                        <td class="auto-style13">
                            <asp:TextBox ID="txtCDetails" runat="server" TextMode="MultiLine" Width="270px" Font-Bold="True" Font-Size="12pt"></asp:TextBox>
                        </td>
                        <td class="auto-style42">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtCDetails" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style5">
                            &nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label5" runat="server" Text="Category Of Course" Font-Bold="True" Font-Size="12pt" ForeColor="Black"></asp:Label>
                            <br />
                            <br />
                        </td>
                        <td class="auto-style13">
                            <asp:DropDownList ID="DDLCategory" runat="server" Width="150px" Font-Bold="True" Font-Size="12pt" OnSelectedIndexChanged="DDLCategory_SelectedIndexChanged">
                            </asp:DropDownList>
                        </td>
                        <td class="auto-style42">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style3" colspan="3">
                            <br />
                            <br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Button ID="btndelete" runat="server" Font-Bold="True" ForeColor="Black" Height="50px" OnClick="btndelete_Click" Text="Delete Course" Width="120px" Font-Size="10.5pt" />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Button ID="btnUpate" runat="server" Font-Bold="True" ForeColor="Black" Height="50px" OnClick="btnUpate_Click" Text="Update Course" Width="120px" Font-Size="10.5pt" />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Button ID="btnAddCourse" runat="server" Font-Bold="True" ForeColor="Black" Height="50px" OnClick="btnAddCourse_Click" Text="Add New Course" Width="120px" Font-Size="10.5pt" />
                            <br />
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style19" colspan="3">&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
                        </td>
                    </tr>
                </table>
              
        </asp:View>
        <asp:View ID="View2" runat="server">
        <table class="auto-style1"style=" width: 544px;">
                    <tr>
                        <td class="auto-style45" colspan="2">
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label10" runat="server" Font-Bold="True" ForeColor="#CC0099" Text="To Working With Category" Font-Size="12pt"></asp:Label>
                            <br />
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style7">
                            &nbsp;&nbsp;
                            <asp:Label ID="Label8" runat="server" Text="Select Category" Font-Bold="True" Font-Size="12pt" ForeColor="Black"></asp:Label>
                            <br />
                            <br />
                        </td>
                        <td class="auto-style6">
                            <asp:DropDownList ID="ddlnamecategory" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlnamecategory_SelectedIndexChanged" Font-Bold="True" Font-Size="12pt" Width="150px">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style9">
                            &nbsp;&nbsp;
                            <asp:Label ID="Label7" runat="server" Text="Category Name" Font-Bold="True" Font-Size="12pt" ForeColor="Black"></asp:Label>
                            <br />
                            <br />
                        </td>
                        <td class="auto-style44">
                            <asp:TextBox ID="txtcategoryname" runat="server" Font-Bold="True" Font-Size="12pt" Width="270px"></asp:TextBox>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtcategoryname" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style20" colspan="2">
                            <br />
                            <br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Button ID="btnbeletecategory" runat="server" OnClick="btnbeletecategory_Click" Text="Delete" Font-Bold="True" Font-Size="11pt" Height="40px" Width="100px" />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                            <asp:Button ID="btnupdatecategory" runat="server" OnClick="btnupdatecategory_Click" Text="Update" Font-Bold="True" Font-Size="11pt" Height="40px" Width="100px" />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                            <asp:Button ID="btnaNewddcategory" runat="server" OnClick="btnaddcategory_Click" Text="Add" Width="100px" Font-Bold="True" Font-Size="11pt" Height="40px" />
                            <br />
                            <br />
                        </td>
                    </tr>
                </table>
                         
        </asp:View>    
        <asp:View ID="View3" runat="server">
            <table class="nav-justified">
                <tr>
                    <td class="auto-style10" colspan="2">&nbsp;<br />
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label15" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="#CC0099" Text="To Deleted Students"></asp:Label>
                        <br />
                        <br />
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style10">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label11" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="Black" style="text-align: left" Text="Select Name"></asp:Label>
                        <br />
                        <br />
                    </td>
                    <td>
                        <asp:DropDownList ID="DDLStudentName" runat="server" AutoPostBack="True" Font-Bold="True" Font-Size="12pt" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" style="margin-left: 1px" Width="150px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style10" colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <br />
                        <asp:GridView ID="GridView1" runat="server" AllowCustomPaging="True" AllowSorting="True" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" Font-Bold="True" Font-Size="8pt" GridLines="None" Width="274px">
                            <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
                            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
                            <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
                            <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
                            <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
                            <SortedAscendingCellStyle BackColor="#F1F1F1" />
                            <SortedAscendingHeaderStyle BackColor="#594B9C" />
                            <SortedDescendingCellStyle BackColor="#CAC9C9" />
                            <SortedDescendingHeaderStyle BackColor="#33276A" />
                        </asp:GridView>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style10" colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnDeleteStudent" runat="server" Font-Bold="True" Font-Size="11.5pt" Height="40px" OnClick="btnDeleteStudent_Click" Text="Delete Student" Width="150px" />
                        <br />
                        <br />
                    </td>
                </tr>
            </table>
        </asp:View>
       
    </asp:MultiView>
    <div class="text-center">
        
        <br />
                            <asp:Label ID="Label16" runat="server" Font-Bold="True" ForeColor="#CC3300" Text="To active View " Font-Size="12pt"></asp:Label>
                            <br />
        <br />
        <asp:Button ID="Button1" runat="server" BackColor="#CC00CC" ForeColor="White" OnClick="view3" Text="Student" CommandName="st" />
&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" BackColor="#CC00CC" ForeColor="White" OnClick="view1" Text="Course" CommandName="co" />
&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" BackColor="#CC00CC" ForeColor="White" OnClick="view2" Text="Category" CommandName="ca" />
&nbsp;&nbsp;
    </div>
    </form>
    </div>

    <div class="footer text-center">

    <div class="container">

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
</body>
</html>
