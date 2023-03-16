<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserCreation.aspx.cs" Inherits="Project3.AccountPages.UserCreationCur" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User Creation</title>

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
                    
                    <asp:Button ID="btnSwitcher" cssclass="col-2"  runat="server" OnClick="btnSwitcher_Click" Text="Switch to Login" Font-Size="Small" />
                </div>
            </div>

        <div class="row justify-content-center ">
                <div class= "form-group col-sm-2">

                    <h3 class="align-content-center"> ENTER YOUR INFORMATION</h3>

                    <h4>Username</h4>
                    <asp:TextBox ID="txtBosUserName" runat="server" ></asp:TextBox>

                    <br></br>
                    <h4>Password</h4>
                    <asp:TextBox ID="txtBoxPassword" runat="server" ></asp:TextBox>
                    <br></br>
                    <h4>Email</h4>
                    <asp:TextBox ID="txtBoxEmail" runat="server" ></asp:TextBox>
                    <br></br>
                    <h4>Fullname</h4>
                    <asp:TextBox ID="txtBoxFullName" runat="server" ></asp:TextBox>
                    <br></br>
                    <asp:Button ID="btnSubmitInfo" runat="server" Text="Submit Info" OnClick="btnSubmitInfo_Click" />

                </div>
        </div>

                        <div class="form-group row justify-content-center">
                    <asp:Label ID="lblFooter" runat="server" Font-Size="30pt" style="z-index: 1; left: 440px; top: 758px; position: absolute; width: 510px" Text="Made by Daniel"></asp:Label>
                </div>

    </form>
</body>
</html>
