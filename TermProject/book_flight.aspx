<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="book_flight.aspx.cs" Inherits="TermProject.book_flight" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ASPX_content" runat="server">
    <div id="row">
        <div id="col-md-10 col-md-offset-1" >
            <h3>Travel Dates:</h3>
            <asp:CheckBox ID="chkFlightType" Text="Round Trip" runat="server" AutoPostBack="true" />
            <div class="row" runat="server" >
                <div class="col-md-6" id="outgoingDate" runat="server">
                    Departure Date:
                    <asp:Calendar ID="calOutgoingDate" runat="server" />
                </div>
                <div class="col-md-6" id="incomingDate" runat="server">
                    Return Date:
                    <asp:Calendar ID="calIncomingDate" runat="server" />
                </div>
            </div>
            <h3>Departing From:</h3>
            <asp:Label ID="lblState" runat="server" Text="State:" CssClass="label" />
            <asp:DropDownList ID="ddlState" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlState_SelectedIndexChanged" AppendDataBoundItems="true" CssClass="dropdown"/>
            <asp:Label ID="lblCity" runat="server" Text="City:" CssClass="label" />
            <asp:DropDownList ID="ddlCity" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlCity_SelectedIndexChanged" AppendDataBoundItems="true" CssClass="dropdown"/>
            <asp:Label ID="lblAirport" runat="server" Text="Airport:" CssClass="label" />
            <asp:DropDownList ID="ddlAirport" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlAirport_SelectedIndexChanged" AppendDataBoundItems="true" CssClass="dropdown"/>
            <h3>Arriving In:</h3>
            <asp:Label ID="lblArrivalState" runat="server" Text="State:" CssClass="label" />
            <asp:DropDownList ID="ddlArrivalState" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlArrivalState_SelectedIndexChanged" AppendDataBoundItems="true" CssClass="dropdown"/>
            <asp:Label ID="lblArrivalCity" runat="server" Text="City:" CssClass="label" />
            <asp:DropDownList ID="ddlArrivalCity" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlArrivalCity_SelectedIndexChanged" AppendDataBoundItems="true" CssClass="dropdown"/>
            <asp:Label ID="lblArrivalAirport" runat="server" Text="Airport:" CssClass="label" />
            <asp:DropDownList ID="ddlArrivalAirport" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlArrivalAirport_SelectedIndexChanged" AppendDataBoundItems="true" CssClass="dropdown"/>
            <h3>From Airport ID: <asp:Label ID="lblFrom" runat="server" CssClass="label" /><br />
                To Airport ID: <asp:Label ID="lblTo" runat="server" CssClass="label" /><br />
                Outgoing Date: <asp:Label ID="lblOutgoingDate" runat="server" cssclass="label" /><br />
                Incoming Date: <asp:Label ID="lblIncomingDate" runat="server" CssClass="label" /><br />
                Carrier ID: <asp:Label ID="lblCarrierID" runat="server" CssClass="label" /><br />
                Seat Type: <asp:label ID="lblSeatType2" runat="server" CssClass="label" /><br />
            </h3>
            <h3>Find Carriers:</h3>
            <asp:Button ID="btnFindCarriers" runat="server" Text="Find Carriers" OnClick="btnFindCarriers_Click" CssClass="btn-default btn"/>
            <asp:Label ID="lblCarriers" runat="server" Text="Carrier" CssClass="label" />
            <asp:DropDownList ID="ddlCarriers" runat="server" CssClass="dropdown">
            </asp:DropDownList><br />
            <h3>Flight Options:</h3>
            <asp:label ID="lblSeatType" Text="Seat Type:" runat="server" CssClass="label"/>
            <asp:DropDownList ID="ddlSeatType" runat="server" CssClass="dropdown">
                <asp:ListItem Text="First Class" />
                <asp:ListItem Text="Economy" Selected="true"/>
            </asp:DropDownList><br />
            <asp:Button ID="btnShowFlights" Text="Show Flights" runat="server" OnClick="btnShowFlights_Click" CssClass="btn-default btn"/>
            <h3>Available Flights:</h3>
            <div class="row" runat="server" id="outgoing">
                <asp:GridView ID="gvAvailableFlights" runat="server" CssClass="table" >
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <input name="rbOutgoingFlightSelection" type="radio" runat="server" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
            <div class="row" runat="server" id="returning" visible="false">
                <asp:GridView ID="gvAvailableFlightsReturning" runat="server" CssClass="table" >
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <input name="rbIncomingFlightSelection" type="radio" runat="server" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
            <div class="row">
                <asp:Button ID="btnAddToCart" runat="server" Text="Add Flight/s to Cart" OnClick="btnAddToCart_Click" CssClass="btn-default btn" /> 
            </div>
        </div>
    </div>
</asp:Content>
