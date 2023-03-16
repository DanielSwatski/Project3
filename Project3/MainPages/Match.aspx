<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Match.aspx.cs" Inherits="Project3.MainPages.MatchNew" %>

<!DOCTYPE html>
<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/css/bootstrap.min.css"/>
    <link href="../styling.css" rel="stylesheet" type="text/css" />
    <script src="https://cdn.jsdelivr.net/npm/jquery@3.6.3/dist/jquery.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/js/bootstrap.bundle.min.js"></script>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

</head>
<body>
    <form id="form1" runat="server">

        <div class="jumbotron text-center header" >
                <div class="container">
                    <asp:Label ID="lblHeader" cssclass="col-5" runat="server" Text="Charactr Findr" Font-Size="XX-Large"></asp:Label>
                </div>
            </div>

        
        <div class="row justify-content-center">

            <asp:GridView ID="grdViewLikes" runat="server" AutoGenerateColumns="False" Font-Size="XX-Small" Width="1148px">
                <Columns>
                    <asp:ImageField DataImageUrlField="Picture" HeaderText="ProfilePhoto" ControlStyle-Width="100" ControlStyle-Height = "100">
                    </asp:ImageField>
                    <asp:BoundField DataField="Username" HeaderText="Username" />
                    <asp:BoundField DataField="Occupation" HeaderText="Occupation" />
                    <asp:BoundField DataField="Age" HeaderText="Age" />
                    <asp:BoundField DataField="City" HeaderText="City" />
                    <asp:BoundField DataField="Height" HeaderText="Height" />
                    <asp:BoundField DataField="weigh" HeaderText="weigh" />
                    <asp:BoundField DataField="FavoritePet" HeaderText="FavoritePet" />
                    <asp:BoundField DataField="FavoriteVacation" HeaderText="FavoriteVacation" />
                    <asp:BoundField DataField="FavoriteGenre" HeaderText="FavoriteGenre" />
                    <asp:BoundField DataField="FavoriteFood" HeaderText="FavoriteFood" />
                    <asp:BoundField DataField="Gender" HeaderText="Gender" />
                    <asp:BoundField DataField="descript" HeaderText="Description" />
                    <asp:BoundField DataField="Telephone" HeaderText="Telephone" />
                   
                    <asp:TemplateField HeaderText="Match" ShowHeader="False">
                        <ItemTemplate>
                            <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="false" CommandName="" OnClick="LinkButton1_Click" Text="Match"></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="UnMatch" ShowHeader="False">
                        <ItemTemplate>
                            <asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="false" CommandName="" OnClick="LinkButton2_Click" Text="UnMatch"></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                   
                </Columns>
            </asp:GridView>
                </div>
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>Homepage</asp:ListItem>
                <asp:ListItem>Match</asp:ListItem>
                <asp:ListItem>Search</asp:ListItem>
                <asp:ListItem>DateManager</asp:ListItem>
            </asp:DropDownList>
        <p>
            <asp:Button ID="btnGo" runat="server" OnClick="btnGo_Click" Text="Go!" />
        </p>
    </form>
</body>
</html>
