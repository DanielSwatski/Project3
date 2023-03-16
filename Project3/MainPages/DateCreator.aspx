<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DateCreator.aspx.cs" Inherits="Project3.MainPages.DateCreator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Date Creator</title>

    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/css/bootstrap.min.css"/>
    <link href="../styling.css" rel="stylesheet" type="text/css" />
    <script src="https://cdn.jsdelivr.net/npm/jquery@3.6.3/dist/jquery.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/js/bootstrap.bundle.min.js"></script>

</head>
<body>
    <form id="form1" runat="server">
        
                <div class="jumbotron text-center header" >
                <div class="container">
                    <asp:Label ID="lblHeader" cssclass="col-5" runat="server" Text="Charactr Findr" Font-Size="XX-Large"></asp:Label>
                </div>
            </div>

        <div class="row justify-content-center ">
                <div class= "form-group col-sm-2">

            <h3>Users</h3>
            <asp:TextBox ID="txtBoxUser1" runat="server" ReadOnly="True"></asp:TextBox>
            <asp:TextBox ID="txtBoxUser2" runat="server" ReadOnly="True"></asp:TextBox>
                     <br/> <br/> <br/>
            <h3>Date Location</h3>
            <asp:TextBox ID="txtBoxDate" runat="server"></asp:TextBox>
            <h3>Date Time</h3>
            <asp:TextBox ID="txtBoxTime" runat="server"></asp:TextBox>
            <h3>Date Description</h3>
            <asp:TextBox ID="txtBoxDescription" runat="server"></asp:TextBox>
            
            <br/>
            <br/>
            <asp:Button ID="btnAccept" runat="server" Text="Accept" OnClick="btnAccept_Click" />
            <br/>

        </div></div>



    </form>
</body>
</html>
