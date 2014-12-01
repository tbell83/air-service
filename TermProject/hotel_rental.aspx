<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="hotel_rental.aspx.cs" Inherits="TermProject.hotel_rental" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ASPX_content" runat="server">
    <div class="row">
        <div class="col-md-4 col-md-offset-4">
            <asp:Label ID="lblHotelPage" runat="server" Text="Hotel Reservation Page" style="font-size: large; font-weight: 700"></asp:Label>
        </div>
    </div>
    <div class ="row col-lg-3 col-lg-offset-2 col-md-2 col-md-offset-2">
        <asp:Label ID ="lblCity" runat="server" Text="City  "></asp:Label>
        <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
     </div>
    <div class =" row col-lg-3 col-lg-offset-2 col-md-2 col-md-offset-2">
        <asp:Label ID ="ddlStates" runat="server" Text="State   "></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Value="AL">Alabama</asp:ListItem>
            <asp:ListItem Value="AK">Alaska</asp:ListItem>
            <asp:ListItem Value="AZ">Arizona</asp:ListItem>
            <asp:ListItem Value="AR">Arkansas</asp:ListItem>
            <asp:ListItem Value="CA">California</asp:ListItem>
            <asp:ListItem Value="CO">Colorado</asp:ListItem>
            <asp:ListItem Value="CT">Connecticut</asp:ListItem>
            <asp:ListItem Value="DE">Delaware</asp:ListItem>
            <asp:ListItem Value="FL">Florida</asp:ListItem>
            <asp:ListItem Value="GA">Georgia</asp:ListItem>
            <asp:ListItem Value="HI">Hawaii</asp:ListItem>
            <asp:ListItem Value="ID">Idaho</asp:ListItem>
            <asp:ListItem Value="IL">Illinois</asp:ListItem>
            <asp:ListItem Value="IN">Indiana</asp:ListItem>
            <asp:ListItem Value="IA">Iowa</asp:ListItem>
            <asp:ListItem Value="KS">Kansas</asp:ListItem>
            <asp:ListItem Value="KY">Kentucky</asp:ListItem>
            <asp:ListItem Value="LA">Louisiana</asp:ListItem>
            <asp:ListItem Value="ME">Maine</asp:ListItem>
            <asp:ListItem Value="MD">Maryland</asp:ListItem>
            <asp:ListItem Value="MA">Massachusetts</asp:ListItem>
            <asp:ListItem Value="MI">Michigan</asp:ListItem>
            <asp:ListItem Value="MN">Minnesota</asp:ListItem>
            <asp:ListItem Value="MS">Mississippi</asp:ListItem>
            <asp:ListItem Value="MO">Missouri</asp:ListItem>
            <asp:ListItem Value="MT">Montana</asp:ListItem>
            <asp:ListItem Value="NE">Nebraska</asp:ListItem>
            <asp:ListItem Value="NV">Nevada</asp:ListItem>
            <asp:ListItem Value="NH">New Hampshire</asp:ListItem>
            <asp:ListItem Value="NJ">New Jersey</asp:ListItem>
            <asp:ListItem Value="NM">New Mexico</asp:ListItem>
            <asp:ListItem Value="NY">New York</asp:ListItem>
            <asp:ListItem Value="NC">North Carolina</asp:ListItem>
            <asp:ListItem Value="ND">North Dakota</asp:ListItem>
            <asp:ListItem Value="OH">Ohio</asp:ListItem>
            <asp:ListItem Value="OK">Oklahoma</asp:ListItem>
            <asp:ListItem Value="OR">Oregon</asp:ListItem>
            <asp:ListItem Value="PA">Pennsylvania</asp:ListItem>
            <asp:ListItem Value="RI">Rhode Island</asp:ListItem>
            <asp:ListItem Value="SC">South Carolina</asp:ListItem>
            <asp:ListItem Value="SD">South Dakota</asp:ListItem>
            <asp:ListItem Value="TN">Tennessee</asp:ListItem>
            <asp:ListItem Value="TX">Texas</asp:ListItem>
            <asp:ListItem Value="UT">Utah</asp:ListItem>
            <asp:ListItem Value="VT">Vermont</asp:ListItem>
            <asp:ListItem Value="VA">Virginia</asp:ListItem>
            <asp:ListItem Value="WA">Washington</asp:ListItem>
            <asp:ListItem Value="WV">West Virginia</asp:ListItem>
            <asp:ListItem Value="WI">Wisconsin</asp:ListItem>
            <asp:ListItem Value="WY">Wyoming</asp:ListItem>
        </asp:DropDownList>
    </div>
</asp:Content>
