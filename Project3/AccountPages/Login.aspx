<%@ Page Title="" Language="C#" MasterPageFile="~/MasterFiles/HeaderNFooter.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Project3.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="btnLogin" runat="server" style="z-index: 1; left: 570px; top: 249px; position: absolute; height: 34px; width: 60px;" Text="Login" OnClick="btnLogin_Click" />
<asp:TextBox ID="txtBoxPassword" runat="server" style="z-index: 1; left: 511px; top: 196px; position: absolute">PASSWORD</asp:TextBox>
<asp:TextBox ID="txtBosUserName" runat="server" style="z-index: 1; left: 514px; top: 140px; position: absolute">USERNAME</asp:TextBox>
</asp:Content>
