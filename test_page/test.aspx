<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="test_page.test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/bootstrap.min.css" rel="stylesheet"/>
</head>
<body>
    <form id="form1" runat="server">
        <div class="row">
            <div class="col-md-10 col-md-offset-1">
                <asp:GridView ID="gvCarriers" runat="server" CssClass="table" />
            </div>
        </div>
        <div class="row">
            <div class="col-md-10 col-md-offset-1">
                <asp:GridView ID="gvFindFlights" runat="server" CssClass="table" />
            </div>
        </div>

        <div class="row">
            <div class="col-md-10 col-md-offset-1">
                Inputs used (hardcoded): carrierID = 1 (Delta Blue); Departure City: "Philadelphia"; Departure State= "PA"; Destination City = "Las Vegas"; Destination State = "NV" 

                <asp:GridView ID="gvGetFlights" runat="server" CssClass="table" />
            </div>
        </div>
    </form>
</body>
</html>
