<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="Project3.MainPages.Homepag" %>

<!DOCTYPE html>

    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/css/bootstrap.min.css"/>
    <link href="../styling.css" rel="stylesheet" type="text/css" />
    <script src="https://cdn.jsdelivr.net/npm/jquery@3.6.3/dist/jquery.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/js/bootstrap.bundle.min.js"></script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Homepage</title>


</head>
<body>
    

        <form id="form2" runat="server">

        <div class="jumbotron text-center header" >
            <asp:Label ID="lblPageTitle" runat="server"  Text="Home Page" Font-Size="X-Large"></asp:Label>
            <asp:Label ID="lblHeader" runat="server" Font-Size="30pt"  Text="Charactr Findr"></asp:Label>
         </div>

        <div class="container">
            <div class="row">

            <div class="col-sm-4">
 
        <asp:DropDownList ID="ddlThingsToDo" runat="server">
                <asp:ListItem>HomePage</asp:ListItem>
                <asp:ListItem>Search</asp:ListItem>
                <asp:ListItem>Match</asp:ListItem>
                <asp:ListItem>DateManager</asp:ListItem>
            </asp:DropDownList>
        <asp:Button ID="btnSwitcher" class="btn btn-primary" runat="server" Text="Go!" OnClick="btnSwitcher_Click" />

            </div>
        <div class="col-sm-4">
            <asp:TextBox ID="lstBoxUserInfo" TextMode="MultiLine" Rows="15" runat="server"></asp:TextBox>
            <asp:Image ID="imgProfilePhoto" runat="server" />
 
            <asp:Button ID="btnEdit" class="btn btn-primary" runat="server"  Text="Edit your Profile" OnClick="btnEdit_Click" />
   
            <asp:Button ID="btnHide" class="btn btn-primary" runat="server"  Text="Hide or Show Profile" OnClick="btnHide_Click" />
        </div>

        <div class="col-sm-4">
        <table>
            <h3> New Matches</h3>
            <tr style="color: #CC3300;">

                <th>User1</th>

            </tr>
         
            <asp:Repeater ID="rptNewMatches" runat="server">
                <ItemTemplate>
                <tr>

                    <td>
                        <asp:Label ID="User1" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "User1") %>'></asp:Label>
                    </td>

                </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
        

            <table>
            <h3> New Dates</h3>
            <tr style="color: #CC3300;">

                <th>User1</th>

            </tr>
         
            <asp:Repeater ID="rptNewDates" runat="server">
                <ItemTemplate>
                <tr>

                    <td>
                        <asp:Label ID="User1" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "User1") %>'></asp:Label>
                    </td>

                </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
        </div>

        </div>
        </div>
         
        <asp:Label ID="lblFooter" runat="server" Font-Size="30pt" Text="Made by Daniel"></asp:Label>
            


        </form>
            
    </body>
</html>
