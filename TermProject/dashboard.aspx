<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="dashboard.aspx.cs" Inherits="TermProject.dashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ASPX_content" runat="server">
    <div class="row">
        <div class="col-md-10 cold-md-offset-1">
            <div id="authed" runat="server" visible="false">
                <asp:Label ID="lblProtected" Text="You can only see this if youre logged in." runat="server" CssClass="h1"/>
                <asp:Label ID="lblUsername" runat="server" CssClass="h1" />
            </div>
            <div id="unauthed" runat="server" visible="false">
                <h1>NOT LOGGED IN! REDIRECTING!</h1>
            </div>
        </div>
    </div>
    <div class="btn-row btn-group-lg">
        <asp:Button id= "btnLogOut" runat="server" Text="Log Out" OnClick="btnLogOut_Click" />
    </div>
    <div class="btn-row">
        <asp:Button ID="btnSearchFlights" runat="server" Text ="Flights" OnClick="btnSearchFlights_Click" />
        <asp:Button ID="btnSearchHotels" runat="server" Text ="Hotels" OnClick="btnSearchHotels_Click" />
        <asp:Button ID="btnSearchEvents" runat="server" Text ="Events" />
        <asp:Button ID="btnSearchCars" runat="server" Text ="Cars" OnClick="btnSearchCars_Click" />
        <asp:Button ID="btnShoppingCart" runat="server" Text ="Shopping Cart" OnClick="btnShoppingCart_Click" />
    </div>
</asp:Content>
