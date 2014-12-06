<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="book_flight.aspx.cs" Inherits="TermProject.book_flight" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ASPX_content" runat="server">
    <div id="row">
        <div id="col-md-10 col-md-offset-1" >
            <h1>Departing From:</h1>
            <asp:Label ID="lblState" runat="server" Text="State:" CssClass="label" />
            <asp:DropDownList ID="ddlState" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlState_SelectedIndexChanged" AppendDataBoundItems="true" CssClass="dropdown"/>
            <asp:Label ID="lblCity" runat="server" Text="City:" CssClass="label" />
            <asp:DropDownList ID="ddlCity" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlCity_SelectedIndexChanged" AppendDataBoundItems="true" CssClass="dropdown"/>
            <asp:Label ID="lblAirport" runat="server" Text="Airport:" CssClass="label" />
            <asp:DropDownList ID="ddlAirport" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlAirport_SelectedIndexChanged" AppendDataBoundItems="true" CssClass="dropdown"/>
            <h1>Arriving In:</h1>
            <asp:Label ID="lblArrivalState" runat="server" Text="State:" CssClass="label" />
            <asp:DropDownList ID="ddlArrivalState" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlArrivalState_SelectedIndexChanged" AppendDataBoundItems="true" CssClass="dropdown"/>
            <asp:Label ID="lblArrivalCity" runat="server" Text="City:" CssClass="label" />
            <asp:DropDownList ID="ddlArrivalCity" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlArrivalCity_SelectedIndexChanged" AppendDataBoundItems="true" CssClass="dropdown"/>
            <asp:Label ID="lblArrivalAirport" runat="server" Text="Airport:" CssClass="label" />
            <asp:DropDownList ID="ddlArrivalAirport" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlArrivalAirport_SelectedIndexChanged" AppendDataBoundItems="true" CssClass="dropdown"/>
            <h1>From: <asp:Label ID="lblFrom" runat="server" CssClass="label"/> To: <asp:Label ID="lblTo" runat="server" /></h1>
            <h1>Find Carriers:</h1>
            <asp:Button ID="btnFindCarriers" runat="server" Text="Find Carriers" OnClick="btnFindCarriers_Click" CssClass="btn-default btn"/>
            <asp:Label ID="lblCarriers" runat="server" Text="Carrier" CssClass="label" />
            <asp:DropDownList ID="ddlCarriers" runat="server" CssClass="dropdown">
            </asp:DropDownList><br />
            <h1>Flight Options:</h1>
            <asp:label ID="lblSeatType" Text="Seat Type:" runat="server" CssClass="label"/>
            <asp:DropDownList ID="ddlSeatType" runat="server" CssClass="dropdown">
                <asp:ListItem Text="First Class" />
                <asp:ListItem Text="Economy" Selected="true"/>
            </asp:DropDownList><br />
            <asp:CheckBox ID="chkFlightType" Text="Round Trip" runat="server" />
            <asp:Button ID="btnShowFlights" Text="Show Flights" runat="server" OnClick="btnShowFlights_Click" CssClass="btn-default btn"/>
            <h1>Available Flights:</h1>
            <div class="row" runat="server" id="outgoing">
                <asp:GridView ID="gvAvailableFlights" runat="server" CssClass="table" />
            </div>
            <div class="row" runat="server" id="returning" visible="false">
                <asp:GridView ID="gvAvailableFlightsReturning" runat="server" CssClass="table"/>
            </div>
        </div>
    </div>
</asp:Content>
