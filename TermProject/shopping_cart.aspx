<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="shopping_cart.aspx.cs" Inherits="TermProject.shopping_cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ASPX_content" runat="server">

    <div class="row col-lg-12 col-md-12">
        <div style="font-size:x-large; text-align:center; padding:5px">Shopping Cart</div>
        <asp:GridView ID="gvCars" runat="server" CssClass="table" AutoGenerateColumns="False" >
            <Columns>
                <asp:CommandField AccessibleHeaderText="Remove From Cart" ButtonType="Button" DeleteText="Remove Item" ShowDeleteButton="True" HeaderText="Remove From Cart" />
                <asp:BoundField DataField="GetCarID" HeaderText="Car ID" />
                <asp:BoundField DataField="GetMake" HeaderText="Make" />
                <asp:BoundField DataField="GetCarType" HeaderText="Model" />
                <asp:BoundField DataField="GetYearMade" HeaderText="Year" />
                <asp:BoundField DataField="GetDailyRate" DataFormatString="{0:c}" HeaderText="Price" />
            </Columns>

        </asp:GridView>

        <asp:GridView ID="gvHotels" runat="server" CssClass="table" >

        </asp:GridView>

        <asp:GridView ID="gvFlights" runat="server" CssClass="table">

        </asp:GridView>

        <asp:GridView ID="gvEvents" runat="server" CssClass="table" >

        </asp:GridView>
    </div>
    
</asp:Content>
