<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DateManager.aspx.cs" Inherits="Project3.MainPages.DateManager" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Date Manager</title>

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
                    <h3> Date Manager</h3>
                </div>
            </div>

        <div>
        </div>
         <div class="row justify-content-center">
            <asp:GridView ID="grdViewDates" runat="server" AutoGenerateColumns="False" Font-Size="XX-Small" Width="1148px" OnSelectedIndexChanged="grdViewDates_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="User1" HeaderText="User1" />
                    <asp:BoundField DataField="User2" HeaderText="User2" />
                    <asp:BoundField DataField="Locat" HeaderText="Location" />
                    <asp:BoundField DataField="Time" HeaderText="Time" />
                    <asp:BoundField DataField="Descript" HeaderText="Description" />
                    <asp:TemplateField ShowHeader="False" HeaderText="Edit">
                        <ItemTemplate>
                            <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="false" CommandName="" OnClick="LinkButton1_Click" Text="Edit"></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Remove" ShowHeader="False">
                        <ItemTemplate>
                            <asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="false" CommandName="" OnClick="LinkButton2_Click" Text="Remove"></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
             </div>
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>Homepage</asp:ListItem>
                <asp:ListItem>Match</asp:ListItem>
                <asp:ListItem>Search</asp:ListItem>
                <asp:ListItem>DateManager</asp:ListItem>
            </asp:DropDownList>
                <asp:Button ID="btnGo" runat="server" Text="Go!" OnClick="btnGo_Click" />
    </form>
</body>
</html>
