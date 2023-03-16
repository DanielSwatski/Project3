<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="Project3.MainPages.Search" %>

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

        <div>
            <asp:Button ID="btn" runat="server" OnClick="btn_Click" style="z-index: 1; top: 336px; position: absolute; left: 388px; margin-top: 0px" Text="Button Search" />
            <asp:TextBox ID="txtBoxArgs" runat="server" style="z-index: 1; left: 475px; top: 278px; position: absolute; height: 26px; width: 158px;"></asp:TextBox>
            <asp:GridView ID="grdViewSearchResults" runat="server" AutoGenerateColumns="False" style="z-index: 1; left: 658px; top: 216px; position: absolute; height: 152px; width: 674px">
                <Columns>
                    <asp:TemplateField HeaderText="Likes">
                        <ItemTemplate>
                            <asp:CheckBox ID="chkBoxLike" runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:ImageField HeaderText="ProfilePhoto" DataImageUrlField="Picture" ControlStyle-Width="100" ControlStyle-Height = "100">
                    </asp:ImageField>
                    <asp:BoundField DataField="Username" HeaderText="Username" />
                    <asp:BoundField DataField="Occupation" HeaderText="Occupation" />
                    <asp:BoundField DataField="Age" HeaderText="Age" />
                    <asp:BoundField DataField="City" HeaderText="City" />
                    <asp:BoundField DataField="descript" HeaderText="Description" />
                </Columns>
            </asp:GridView>
            <asp:DropDownList ID="ddlSearchCategory" runat="server" style="z-index: 1; left: 301px; top: 275px; position: absolute; width: 152px">
                <asp:ListItem>City</asp:ListItem>
                <asp:ListItem>Gender</asp:ListItem>
                <asp:ListItem>Age</asp:ListItem>
                <asp:ListItem>CommitmentType</asp:ListItem>
            </asp:DropDownList>
            <asp:DropDownList ID="ddlThingsToDo" runat="server" style="z-index: 1; left: 1133px; top: 116px; position: absolute">
                <asp:ListItem>HomePage</asp:ListItem>
                <asp:ListItem>Search</asp:ListItem>
                <asp:ListItem>Match</asp:ListItem>
                <asp:ListItem>DateManager</asp:ListItem>
            </asp:DropDownList>
            <asp:Button ID="btnGo" runat="server" OnClick="btnLike0_Click" style="z-index: 1; top: 119px; position: absolute; left: 1306px; margin-top: 0px; height: 29px;" Text="Go!" />
        </div>
        <p>
            <asp:Button ID="btnLike" runat="server" OnClick="btnLike_Click" style="z-index: 1; top: 159px; position: absolute; left: 647px; margin-top: 0px" Text="Like All your Checks Unlike All not checked" />
            </p>
        <p>
            <asp:Label ID="lblWarning" runat="server" style="z-index: 1; left: 349px; top: 129px; position: absolute; width: 244px" Text="If you are doing age, put the younger age 1st, a space, then the maximum age 2nd"></asp:Label>
        </p>
    </form>
</body>
</html>
