<%@ Page Title="" Language="C#" MasterPageFile="~/MasterFiles/HeaderNFooter.Master" AutoEventWireup="true"  Inherits="Project3.WebForm1" %>

<script runat="server">

</script>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2"  ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-md-4"> 
            <asp:Button ID="btnLogin" runat="server" style="z-index: 1; left: 694px; top: 341px; position: absolute; height: 34px; width: 60px;" Text="Login" OnClick="btnLogin_Click" />
            <asp:TextBox ID="txtBoxPassword" runat="server" style="z-index: 1; left: 665px; top: 274px; position: absolute">cornell123</asp:TextBox>
            <asp:TextBox ID="txtBosUserName" runat="server" style="z-index: 1; left: 655px; top: 220px; position: absolute">AndyBernard</asp:TextBox>
        </div>
    </div>
</asp:Content>
