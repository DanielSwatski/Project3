<%@ Page Title="" Language="C#" MasterPageFile="~/MasterFiles/HeaderNFooter.Master" AutoEventWireup="true" CodeBehind="UserCreation.aspx.cs" Inherits="Project3.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:TextBox ID="txtBoxEmail" runat="server" style="z-index: 1; left: 560px; top: 331px; position: absolute">Email INSERTION NOT ORKING YET</asp:TextBox>
<asp:Button ID="btnSubmitInfo" runat="server" style="z-index: 1; left: 559px; top: 379px; position: absolute" Text="Submit Info" OnClick="btnSubmitInfo_Click" />
<asp:TextBox ID="txtBoxFullName" runat="server" style="z-index: 1; left: 560px; top: 285px; position: absolute; height: 20px">Full Name</asp:TextBox>
<asp:TextBox ID="txtBosUserName" runat="server" style="z-index: 1; left: 562px; top: 185px; position: absolute">UserName</asp:TextBox>
<asp:TextBox ID="txtBoxPassword" runat="server" style="z-index: 1; left: 560px; top: 236px; position: absolute">Password</asp:TextBox>
</asp:Content>
