<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="flight_confirm.aspx.cs" Inherits="TermProject.flight_confirm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ASPX_content" runat="server">
    <div class="row">
        <div class="col-md-10 col-md-offset-1">
            <h3>From Airport ID: <asp:Label ID="lblFrom" runat="server" CssClass="label" /><br />
                To Airport ID: <asp:Label ID="lblTo" runat="server" CssClass="label" /><br />
                Outgoing Date: <asp:Label ID="lblOutgoingDate" runat="server" cssclass="label" /><br />
                Incoming Date: <asp:Label ID="lblIncomingDate" runat="server" CssClass="label" /><br />
                Carrier ID: <asp:Label ID="lblCarrierID" runat="server" CssClass="label" /><br />
                Seat Type: <asp:label ID="lblSeatType" runat="server" CssClass="label" /><br />
                Outgoing Flight: <asp:Label ID="lblOutgoingFlightID" runat="server" CssClass="label" /><br />
                Incoming Flight: <asp:Label ID="lblIncomingFlightID" runat="server" CssClass="label" /><br />
            </h3>
        </div>
    </div>
</asp:Content>
