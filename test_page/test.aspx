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

        <div class="row">
            <div class="col-md-10 col-md-offset-1">
               <%-- &nbsp;&nbsp;&nbsp;&nbsp; Customer:&nbsp;
                <asp:DropDownList ID="ddlCustomers" runat="server">
                </asp:DropDownList>
                &nbsp;&nbsp;&nbsp;
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;
                Flight 1/ Outgoing flight: 
                <asp:DropDownList ID="ddlOutgoingFlightID" runat="server">
                </asp:DropDownList>
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;
                Flight 2/ Returning flight: (optional) 
                <asp:DropDownList ID="ddlReturningFlightID" runat="server">
                </asp:DropDownList>--%>
                
                Inputs hardcoded into test.aspx.cs for when you press "Make Reservation": <br />
                int custID = 2; <br />
                int flightID1 = 3; <br />
                string seatType1 = "Economy"; <br />
                string flightDate1 = "11/22/2014"; <br />
                int flightID2 = 5; <br />
                string seatType2 = "First Class"; <br />
                string flightDate2 = "11/24/2014"; <br />

                <br />
                <br />
                <asp:Button ID="btnReserve" runat="server" Text="Make Reservation" OnClick="btnReserve_Click" />
                <br />
                <br />
                
            </div>
        </div>
    </form>
</body>
</html>
