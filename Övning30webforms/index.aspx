<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Övning30webforms.index" %>

<asp:Content ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 188px;
        }
        .auto-style2 {
            width: 190px;
        }
        .auto-style3 {
            width: 621px;
        }
        .auto-style4 {
            width: 46%;
        }
    </style>
</asp:Content>
<asp:Content ContentPlaceHolderID="main" runat="server">
        <div>
            <asp:ListBox ID="ListBoxContacts" runat="server" Height="212px" Width="194px" AutoPostBack="True" OnSelectedIndexChanged="ListBoxContacts_SelectedIndexChanged"></asp:ListBox>
            <table class="auto-style1">  
                <tr>
                    <td class="auto-style1">Firstname:</td>
                    <td class="auto-style2">Lastname:</td>
                    <td class="auto-style3">SSN:</td>
                </tr>
                <tr>
                    <td class="auto-style1"><asp:TextBox ID="TextBoxFirstname" runat="server"></asp:TextBox></td>
                    <td class="auto-style2"><asp:TextBox ID="TextBoxLastname" runat="server"></asp:TextBox></td>
                    <td class="auto-style3"><asp:TextBox ID="TextBoxSSN" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                </tr>
                </table>  
        </div>
        <asp:Button ID="ButtonAddContact" runat="server" OnClick="ButtonAddContact_Click" Text="AddContact" Width="120px" />
            <asp:Button ID="ButtonUpdate" runat="server" OnClick="ButtonUpdate_Click" Text="Update Contact" Width="120px" />
            <asp:Button ID="ButtonDelete" runat="server" OnClick="ButtonDelete_Click" Text="Delete Contact" Width="120px" />
        <asp:Button ID="ButtonAdresses" runat="server" OnClick="ButtonAdresses_Click" Text="Adresses" Width="120px" />
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        </asp:Content>
