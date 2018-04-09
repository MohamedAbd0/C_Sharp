<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="corecourses.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 93%; margin-left: 14px; margin-right: 0px;">
    <tr>
        <td style="width: 179px; height: 21px;"></td>
        <td class="modal-sm" style="height: 21px"></td>
        <td style="width: 31px; height: 21px;"></td>
    </tr>
    <tr>
        <td style="width: 179px; color: #000000; font-size: large; font-weight: bold;">Your F-Name<br />
            <br />
        </td>
        <td class="modal-sm">
            <asp:TextBox ID="txtfname" runat="server" Width="270px" Font-Size="12pt"></asp:TextBox>
        </td>
        <td style="width: 31px">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtfname" ErrorMessage="*" Font-Bold="True" Font-Size="15pt" ForeColor="#FF3300"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td style="width: 179px; color: #000000; font-size: large; font-weight: bold;">Your L-Name<br />
            <br />
        </td>
        <td class="modal-sm">
            <asp:TextBox ID="txtlname" runat="server" Width="270px" Font-Size="12pt"></asp:TextBox>
        </td>
        <td style="width: 31px">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtlname" ErrorMessage="*" Font-Bold="True" Font-Size="15pt" ForeColor="#FF3300"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td style="width: 179px; color: #000000; font-size: large; font-weight: bold;">Your Password<br />
            <br />
        </td>
        <td class="modal-sm">
            <asp:TextBox ID="txtpassword" runat="server" TextMode="Password" Width="270px" Font-Size="12pt"></asp:TextBox>
        </td>
        <td style="width: 31px">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtpassword" ErrorMessage="*" Font-Bold="True" Font-Size="15pt" ForeColor="#FF3300"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td style="width: 179px; color: #000000; font-size: large; font-weight: bold;">Confirm Password<br />
            <br />
        </td>
        <td class="modal-sm">
            <asp:TextBox ID="txtconfirm" runat="server" TextMode="Password" Width="270px" Font-Size="12pt"></asp:TextBox>
        </td>
        <td style="width: 31px">
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtpassword" ControlToValidate="txtconfirm" ErrorMessage="*" Font-Bold="False" ForeColor="Red" Font-Size="15pt"></asp:CompareValidator>
        </td>
    </tr>
    <tr>
        <td style="width: 179px; color: #000000; font-size: large; font-weight: bold;">&nbsp;Your Email<br />
            <br />
        </td>
        <td class="modal-sm">
            <asp:TextBox ID="txtemail" runat="server" Font-Size="12pt" Width="270px"></asp:TextBox>
        </td>
        <td style="width: 31px">
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtemail" ErrorMessage="*" Font-Bold="False" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Font-Size="15pt"></asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr>
        <td style="width: 179px; color: #000000; font-size: large; font-weight: bold;">Your Age<br />
            <br />
        </td>
        <td class="modal-sm">
            <asp:TextBox ID="txtage" runat="server" Font-Size="12pt" Width="270px"></asp:TextBox>
        </td>
        <td style="width: 31px">
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtage" ErrorMessage="*" ForeColor="Red" MaximumValue="75" MinimumValue="19" Font-Size="15pt"></asp:RangeValidator>
        </td>
    </tr>
    <tr>
        <td style="width: 179px; color: #000000; font-size: large; font-weight: bold;">Your Collage<br />
            <br />
        </td>
        <td class="modal-sm">
            <asp:TextBox ID="txtcollage" runat="server" Font-Size="12pt" Width="270px"></asp:TextBox>
        </td>
        <td style="width: 31px">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtcollage" ErrorMessage="*" Font-Bold="True" Font-Size="15pt" ForeColor="#FF3300"></asp:RequiredFieldValidator>
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
        <td style="width: 31px">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="rbtgender" ErrorMessage="*" Font-Bold="True" Font-Size="15pt" ForeColor="#FF3300"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td style="width: 179px">&nbsp;</td>
        <td class="modal-sm">&nbsp;</td>
        <td style="width: 31px">&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 179px">&nbsp;</td>
        <td class="modal-sm">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnsubmit" runat="server" Text="Submit" Width="139px" OnClick="btnsubmit_Click" ForeColor="Black" />
            <br />
        </td>
        <td style="width: 31px">&nbsp;</td>
    </tr>
    </table>
</asp:Content>
