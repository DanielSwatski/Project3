<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProfileCreation.aspx.cs" Inherits="Project3.AccountPages.ProfileCreation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Profile Creation</title>

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


        <div class="row text-center">
            <div class="col-3">
                <h3> Basic Info</h3>
                <h6>Username</h6>
                <asp:TextBox ID="txtBoxUsername" runat="server" ></asp:TextBox>
                <h6>Occupation</h6>
                <asp:TextBox ID="txtBoxOccupation" runat="server" ></asp:TextBox>
                <h6>Age</h6>
                <asp:TextBox ID="txtBoxAge" runat="server" ></asp:TextBox>
                <h6>Profile Photo URL</h6>
                <asp:TextBox ID="txtBoxProfileURL" runat="server" ></asp:TextBox>
                <h6>Gender</h6>
                <asp:DropDownList ID="ddlGender" runat="server">
                    <asp:ListItem>Man</asp:ListItem>
                    <asp:ListItem>Woman</asp:ListItem>
                    <asp:ListItem>Other</asp:ListItem>
                </asp:DropDownList>
                
                <h6>Height</h6>
                 <asp:TextBox ID="txtBoxHeight" runat="server" ></asp:TextBox>
                <h6>Weight</h6>
                <asp:TextBox ID="txtBoxWeight" runat="server" ></asp:TextBox>

            </div>

            <div class="col-3">
                <h3> Contact Info</h3>
                <h6>Phone</h6>
                <asp:TextBox ID="txtBoxPhone" runat="server" ></asp:TextBox>
                <h6>City</h6>
                <asp:TextBox ID="txtBoxCity" runat="server" ></asp:TextBox>
            </div>

            <div class="col-3">
                <h3> About Me</h3>
                <h6>Description</h6>
                <asp:TextBox ID="txtBoxDescription" runat="server" ></asp:TextBox>
               &nbsp;<h6>Favorite Pet
                </h6>
                <asp:DropDownList ID="ddlFavoritePet" runat="server">
                    <asp:ListItem>Dog</asp:ListItem>
                    <asp:ListItem>Cat</asp:ListItem>
                    <asp:ListItem>Bird</asp:ListItem>
                    <asp:ListItem>Snake</asp:ListItem>
                    <asp:ListItem>Fish</asp:ListItem>
                    <asp:ListItem>Turtle</asp:ListItem>
                </asp:DropDownList>
                <h6>Favorite Genre
                </h6>
                <asp:DropDownList ID="chkBoxMusic" runat="server">
                    <asp:ListItem>Rap</asp:ListItem>
                    <asp:ListItem>Rock</asp:ListItem>
                    <asp:ListItem>Pop</asp:ListItem>
                    <asp:ListItem>Jazz</asp:ListItem>
                    <asp:ListItem>Classical</asp:ListItem>
                    <asp:ListItem>Punk</asp:ListItem>
                </asp:DropDownList>
                <h6>Favorite Food
                </h6>
                <asp:DropDownList ID="chkBoxFoods" runat="server">
                    <asp:ListItem>American</asp:ListItem>
                    <asp:ListItem>Mexican</asp:ListItem>
                    <asp:ListItem>Chinese</asp:ListItem>
                    <asp:ListItem>Thai</asp:ListItem>
                    <asp:ListItem>Ethiopian</asp:ListItem>
                    <asp:ListItem>Indian</asp:ListItem>
                    <asp:ListItem>Japanese</asp:ListItem>
                    <asp:ListItem>Italian</asp:ListItem>
                    <asp:ListItem>MiddleEastern</asp:ListItem>
                </asp:DropDownList>
                <h6>Vacation</h6>
                <asp:DropDownList ID="chkBoxVacation" runat="server">
                    <asp:ListItem>Beach</asp:ListItem>
                    <asp:ListItem>Mountain</asp:ListItem>
                    <asp:ListItem>Lake</asp:ListItem>
                    <asp:ListItem>Jungle</asp:ListItem>
                    <asp:ListItem>City</asp:ListItem>
                    <asp:ListItem>Space</asp:ListItem>
                    </asp:DropDownList>

                <h6>CommitmentType</h6>
                <asp:DropDownList ID="ddlCommitmentTypes" runat="server">
                    <asp:ListItem>Friends</asp:ListItem>
                    <asp:ListItem>Relationship</asp:ListItem>
                    <asp:ListItem>Marriage</asp:ListItem>
                </asp:DropDownList>
                
                <br />
                <br />
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                <br />
                <br />
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </div>

        </div>

                        <div class="form-group row justify-content-center">
                    <asp:Label ID="lblFooter" runat="server" Font-Size="30pt" style="z-index: 1; left: 524px; top: 1296px; position: absolute; width: 510px" Text="Made by Daniel"></asp:Label>     
                            
                    </div>


            
    </form>
</body>
</html>
