<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="shopping_cart.aspx.cs" Inherits="TermProject.shopping_cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ASPX_content" runat="server">
    <div class="row" style="align-items:flex-end">
        <asp:Button id= "btnLogOut" runat="server" Text="Log Out" OnClick="btnLogOut_Click" />
    </div>
    <div class="row col-lg-12 col-md-12">
        <div style="font-size:x-large; text-align:center; padding:5px">Shopping Cart</div>
        <div class=" btn-row"><asp:Button ID="btnReserve" runat="server" Text="Make Reservations" OnClick="btnReserve_Click" /></div>
        <asp:GridView ID="gvCars" runat="server" CssClass="table" AutoGenerateColumns="False" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" OnSelectedIndexChanged="gvCars_SelectedIndexChanged" ShowFooter="true">
            <Columns>
                <asp:CommandField ButtonType="Button" HeaderText="Remove From Cart" SelectText="Remove Item" ShowSelectButton="True" />
                <asp:BoundField DataField="GetCarID" HeaderText="Car ID" />
                <asp:BoundField DataField="GetMake" HeaderText="Make" />
                <asp:BoundField DataField="GetCarType" HeaderText="Model" />
                <asp:BoundField DataField="GetYearMade" HeaderText="Year" />
                <asp:BoundField DataField="GetDailyRate" DataFormatString="{0:c}" HeaderText="Price" />
            </Columns>

            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
            <RowStyle BackColor="White" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />

        </asp:GridView>

        <asp:GridView ID="gvHotels" runat="server" CssClass="table" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" AutoGenerateColumns="False" OnSelectedIndexChanged="gvHotels_SelectedIndexChanged" ShowFooter="true" >
            <Columns>
                <asp:CommandField ButtonType="Button" HeaderText="Remove From Cart" SelectText="Remove Item" ShowSelectButton="True" />
                <asp:BoundField DataField="Hotel" HeaderText="Hotel" />
                <asp:BoundField DataField="RoomNum" HeaderText="Room Number" />
                <asp:BoundField DataField="Price" DataFormatString="{0:c}" HeaderText="Price " />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
            <RowStyle BackColor="White" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />

        </asp:GridView>

        <asp:GridView ID="gvFlights" runat="server" CssClass="table" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" AutoGenerateColumns="false" OnSelectedIndexChanged="gvFlights_SelectedIndexChanged">
            <Columns>
                <asp:CommandField ButtonType="Button" HeaderText="Remove From Cart" SelectText="Remove Item" ShowSelectButton="True" />
                <asp:BoundField DataField="carrierName" HeaderText="Carrier" />
                <asp:BoundField DataField="originCity" HeaderText="Origin City" />
                <asp:BoundField DataField="destinationCity" HeaderText="Destination City" />
                <asp:BoundField DataField="departureTime" HeaderText="Departure" />
                <asp:BoundField DataField="date" HeaderText="Date" />
                <asp:BoundField DataField="economyPrice" DataFormatString="{0:c}" HeaderText="Price " />
                <asp:BoundField DataField="firstClassPrice" DataFormatString="{0:c}" HeaderText="Price " />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
            <RowStyle BackColor="White" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />

        </asp:GridView>

        <asp:GridView ID="gvEvents" runat="server" CssClass="table" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" AutoGenerateColumns="false" OnSelectedIndexChanged="gvEvents_SelectedIndexChanged">
            <Columns>
                <asp:CommandField ButtonType="Button" HeaderText="Remove From Cart" SelectText="Remove Item" ShowSelectButton="True" />
                <asp:BoundField DataField="EventDate" HeaderText="Date" />
                <asp:BoundField DataField="EventTime" HeaderText="Time" />
                <asp:BoundField DataField="EventName" HeaderText="Name" />
                <asp:BoundField DataField="City" HeaderText="City" />
                <asp:BoundField DataField="TicketPrice" HeaderText="Price" DataFormatString="{0:c}" />
                <asp:BoundField DataField="Venue" HeaderText="Venue" />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
            <RowStyle BackColor="White" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />

        </asp:GridView>

        <h1>Total:</h1>
        <asp:Label ID="lblTotal" runat="server" />
        <br />
        <br />
        <asp:Label ID="lblResponse" runat="server" Text ="Congratulations, you've successfully booked your vacation!" Visible="false"/>
        
    </div>
    
</asp:Content>
