<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="corecourses.Details" %>


<html xmlns="http://www.w3.org/1999/xhtml" xml:lang="en" lang="en">
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
         .auto-style1 {
             width: 300px;
             height : 300px;
         }
         .auto-style2 {
            
             width: 142px;
             text-align: center;
         }
       
         .titels {
             text-align: center;
             background-color:#808080;
             color:white;
         }
       
     </style>

    </head>
<body>
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
            <li>   <asp:HyperLink  ID="HyperLink1" runat="server" NavigateUrl="~/Acount.aspx"></asp:HyperLink></li>
            <li><img src="reg.PNG"  height="80px"/></li>
            <li><a href="Login.aspx" > Logout </a></li>
            
 </ul>
</div>
</div>
</nav>


<form id="form1" runat="server">
        <div style="  width:79% ; background-color:#E6E6FA	;margin-top:50px ;border-radius:10px; margin-left:150px;">

    
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:courses %>" DeleteCommand="DELETE FROM [courses] WHERE [id] = @id" InsertCommand="INSERT INTO [courses] ([name], [time], [trainer], [category_id], [detalis], [link_v], [link_t]) VALUES (@name, @time, @trainer, @category_id, @detalis, @link_v, @link_t)" ProviderName="<%$ ConnectionStrings:courses.ProviderName %>" SelectCommand="SELECT courses.id, courses.name, courses.time, courses.trainer, courses.category_id, courses.detalis, courses.link_v, courses.link_t FROM courses INNER JOIN category ON courses.category_id = category.id WHERE (category.id = @idofcat)" UpdateCommand="UPDATE [courses] SET [name] = @name, [time] = @time, [trainer] = @trainer, [category_id] = @category_id, [detalis] = @detalis, [link_v] = @link_v, [link_t] = @link_t WHERE [id] = @id">
                <DeleteParameters>
                    <asp:Parameter Name="id" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="name" Type="String" />
                    <asp:Parameter Name="time" Type="Int32" />
                    <asp:Parameter Name="trainer" Type="String" />
                    <asp:Parameter Name="category_id" Type="Int32" />
                    <asp:Parameter Name="detalis" Type="String" />
                    <asp:Parameter Name="link_v" Type="String" />
                    <asp:Parameter Name="link_t" Type="String" />
                </InsertParameters>
                <SelectParameters>
                    <asp:QueryStringParameter DefaultValue="3" Name="idofcat" QueryStringField="id" />
                </SelectParameters>
                <UpdateParameters>
                    <asp:Parameter Name="name" Type="String" />
                    <asp:Parameter Name="time" Type="Int32" />
                    <asp:Parameter Name="trainer" Type="String" />
                    <asp:Parameter Name="category_id" Type="Int32" />
                    <asp:Parameter Name="detalis" Type="String" />
                    <asp:Parameter Name="link_v" Type="String" />
                    <asp:Parameter Name="link_t" Type="String" />
                    <asp:Parameter Name="id" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
            <asp:Label ID="lblnameofcat" runat="server" Font-Bold="True" Font-Size="20pt" ForeColor="#CC0099" style="text-align: center" Width="100%"></asp:Label>
            <br />
            <br />
            <asp:DataList ID="DataList1"  runat="server" DataKeyField="id" DataSourceID="SqlDataSource1" RepeatColumns="3" RepeatDirection="Horizontal" OnItemCommand="DataList1_ItemCommand">
                <ItemTemplate>
                    <table class="auto-style1" style="margin: auto; padding: 10px; border: thick outset #000000; margin-left:10px;margin-right:10px; ">
                        <tr>
                            <td class="auto-style2" style="padding: 10px; border-color: #000000; font-size: large; font-weight: bold; ">
                                <asp:Label ID="Label1" runat="server" CssClass="titels" Text="Name&nbsp;" Width="300px"></asp:Label>
                                <asp:Label ID="nameLabel" runat="server" Text='<%# Eval("name") %>' />
                                <asp:Label ID="Label2" runat="server" CssClass="titels" Text="Detalis" Width="300px"></asp:Label>
                                <asp:Label ID="detalisLabel" runat="server" Text='<%# Eval("detalis") %>' />
                            </td>
                            
                        </tr>
                    </table>
                    <asp:Button ID="Button1"  runat="server" BackColor="#CC0099" CommandName='<%# Eval("id") %>' Font-Bold="True" Font-Size="15pt" ForeColor="White" Height="27px" Text="Show Course" Width="326px" />
                    <br />
                    <br />
<br />
                </ItemTemplate>
            </asp:DataList>

    
      </div>
    </form>
      
</body>
</html>
