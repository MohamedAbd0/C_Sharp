<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="corecourses.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 88%; height: 443px; margin-left: 46px; margin-top: 19px;">
        <tr>
            <td style="width: 101px; height: 32px;"></td>
            <td style="width: 275px; height: 32px;" class="modal-sm"></td>
            <td style="height: 32px"></td>
        </tr>
        <tr>
            <td style="width: 101px; height: 32px;">&nbsp;</td>
            <td style="width: 275px; height: 32px;" class="modal-sm">&nbsp;</td>
            <td style="height: 32px">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 101px">&nbsp;</td>
            <td style="color: #000000; font-weight: bold; font-size: x-large;" class="modal-sm">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Your Email</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 101px; font-size: 15px; color: #000000; font-weight: bold;">&nbsp;</td>
            <td style="width: 275px; height: 26px;">
                &nbsp;</td>
            <td style="height: 26px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 101px; height: 26px; font-size: 15px; color: #000000; font-weight: bold;"></td>
            <td style="width: 275px; height: 26px;">
                <asp:TextBox ID="txtemail" runat="server" Width="250px"></asp:TextBox>
            </td>
            <td style="height: 26px">
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtemail" ErrorMessage="Is Not E-mail" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 101px; font-size: 15px; color: #000000; font-weight: bold;">&nbsp;</td>
            <td style="height: 26px; width: 275px">
                &nbsp;</td>
            <td style="height: 26px">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 101px; font-size: 15px; color: #000000; font-weight: bold;">&nbsp;</td>
            <td style="color: #000000; font-weight: bold; font-size: x-large;">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Your Password</td>
            <td style="height: 26px">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 101px; font-size: 15px; color: #000000; font-weight: bold;">&nbsp;</td>
            <td style="height: 26px; width: 275px">
                &nbsp;</td>
            <td style="height: 26px">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 101px; font-size: 15px; color: #000000; font-weight: bold;">&nbsp;</td>
            <td style="height: 26px; width: 275px">
                <asp:TextBox ID="txtpassword" runat="server" TextMode="Password" Width="250px"></asp:TextBox>
            </td>
            <td style="height: 26px"></td>
        </tr>
        <tr>
            <td style="width: 101px; font-size: 15px; color: #000000; font-weight: bold;">&nbsp;</td>
            <td style="height: 26px; width: 275px">
                &nbsp;</td>
            <td style="height: 26px">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 101px">&nbsp;</td>
            <td style="width: 275px" class="modal-sm">
                <asp:CheckBox ID="chkpassword" runat="server" OnCheckedChanged="chkpassword_CheckedChanged" Text="To Password Visible" AutoPostBack="True" Width="200px" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 101px">
                &nbsp;</td>
            <td style="width: 275px" class="modal-sm">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnlogin" runat="server" OnClick="btnlogin_Click" Text="Login" Width="123px" />
            </td>
        </tr>
    </table>
</asp:Content>
