    <%@ Page Title="" Language="C#" MasterPageFile="~/MasterFiles/HeaderNFooter.Master" AutoEventWireup="true" CodeBehind="ProfileCreation.aspx.cs" Inherits="Project3.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" style="z-index: 1; left: 540px; top: 586px; position: absolute" Text="Submit to Profile" />
    <asp:TextBox ID="txtBoxDescripiton" runat="server" style="z-index: 1; left: 550px; top: 379px; position: absolute">Description</asp:TextBox>
    <asp:TextBox ID="txtBoxHeight" runat="server" style="z-index: 1; left: 548px; top: 419px; position: absolute">69</asp:TextBox>
    <asp:TextBox ID="txtBoxWeight" runat="server" style="z-index: 1; left: 546px; top: 456px; position: absolute">180</asp:TextBox>
    <asp:TextBox ID="txtBoxCity" runat="server" style="z-index: 1; left: 543px; top: 539px; position: absolute">Philadelphia</asp:TextBox>
    <asp:DropDownList ID="ddlFavoritePet" runat="server" style="z-index: 1; left: 441px; top: 155px; position: absolute">
        <asp:ListItem>Dog</asp:ListItem>
        <asp:ListItem>Cat</asp:ListItem>
        <asp:ListItem>Bird</asp:ListItem>
        <asp:ListItem>Snake</asp:ListItem>
        <asp:ListItem>Fish</asp:ListItem>
        <asp:ListItem>Turtle</asp:ListItem>
        <asp:ListItem>None</asp:ListItem>
    </asp:DropDownList>
    <asp:DropDownList ID="ddlCommintmentType" runat="server" style="z-index: 1; left: 402px; top: 192px; position: absolute; height: 19px; bottom: 427px;">
        <asp:ListItem>Friends</asp:ListItem>
        <asp:ListItem>Relationship</asp:ListItem>
        <asp:ListItem>Marriage</asp:ListItem>
    </asp:DropDownList>
    <asp:DropDownList ID="ddlGender" runat="server" style="z-index: 1; left: 434px; top: 232px; position: absolute">
        <asp:ListItem>Woman</asp:ListItem>
        <asp:ListItem>Man</asp:ListItem>
        <asp:ListItem>Other</asp:ListItem>
    </asp:DropDownList>
    <asp:CheckBoxList ID="chkBoxFoods" runat="server" style="z-index: 1; left: 783px; top: 129px; position: absolute; height: 28px; width: 151px">
        <asp:ListItem>American</asp:ListItem>
        <asp:ListItem>Mexican</asp:ListItem>
        <asp:ListItem>Chinese</asp:ListItem>
        <asp:ListItem>Thai</asp:ListItem>
        <asp:ListItem>Ethiopian</asp:ListItem>
        <asp:ListItem>Indian</asp:ListItem>
        <asp:ListItem>Japanese</asp:ListItem>
        <asp:ListItem>Italian</asp:ListItem>
        <asp:ListItem>MiddleEastern</asp:ListItem>
    </asp:CheckBoxList>
    <asp:CheckBoxList ID="chkBoxMusic" runat="server" style="z-index: 1; left: 237px; top: 127px; position: absolute; height: 28px; width: 116px">
        <asp:ListItem>Rap</asp:ListItem>
        <asp:ListItem>Pop</asp:ListItem>
        <asp:ListItem>Rock</asp:ListItem>
        <asp:ListItem>Jazz</asp:ListItem>
        <asp:ListItem>Classical</asp:ListItem>
        <asp:ListItem>Punk</asp:ListItem>
    </asp:CheckBoxList>
    <asp:CheckBoxList ID="chkBoxVacation" runat="server" style="z-index: 1; left: 957px; top: 131px; position: absolute; height: 28px; width: 130px">
        <asp:ListItem>Beach</asp:ListItem>
        <asp:ListItem>Mountain</asp:ListItem>
        <asp:ListItem>Lake</asp:ListItem>
        <asp:ListItem>Jungle</asp:ListItem>
        <asp:ListItem>City</asp:ListItem>
        <asp:ListItem>Space</asp:ListItem>
    </asp:CheckBoxList>
    <asp:TextBox ID="txtBoxPhone" runat="server" style="z-index: 1; left: 545px; top: 500px; position: absolute">1231231234</asp:TextBox>
    <asp:TextBox ID="txtBoxOccupation" runat="server" style="z-index: 1; left: 559px; top: 194px; position: absolute">Occupation</asp:TextBox>
    <asp:TextBox ID="txtBoxUsername" runat="server" style="z-index: 1; left: 558px; top: 127px; position: absolute"></asp:TextBox>
    <asp:TextBox ID="txtBoxAge" runat="server" style="z-index: 1; left: 556px; top: 235px; position: absolute; height: 25px">100</asp:TextBox>
    <asp:TextBox ID="txtBoxProfileURL" runat="server" style="z-index: 1; left: 552px; top: 289px; position: absolute">Profile URL</asp:TextBox>
</asp:Content>
