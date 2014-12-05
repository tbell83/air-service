<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="car_rental.aspx.cs" Inherits="TermProject.car_rental" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"> </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ASPX_content" runat="server">
  
        <div class="row col-lg-8 col-offset-2 col-md-8 col-md-offset-2">
            <br />
            <br />
            <p class="text-center"><span style="font-size: x-large">Car Rentals</span></p>
            <p class="text-center"><span style ="font-size:large">Please enter a city and select a state to search for car rentals in that location.</span></p> 
            <div class ="row col-lg-3 col-lg-offset-2 col-md-4 col-md-offset-1">
                <asp:Label ID ="lblCity" runat="server" Text="City  "/>
                <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
            </div>
            <div class ="row col-lg-3 col-lg-offset-2 col-md-4 col-md-offset-2">
                <asp:Label ID ="lblStates" runat="server" Text="State   "/>
                <asp:DropDownList ID="ddlStates" runat="server">
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
                <br />
                <br />
            </div>
            <br />
            <br />
        </div>

     
     <div class="btn-row col-lg-12 col-md-12">
        <p><asp:Button ID="btnSearch" runat="server" Text="Search Car Rentals" OnClick="btnSearch_Click"/></p>
        <p><asp:Button ID="btnNewSearch" runat="server" Text="New Search" Visible="false" OnClick="btnNewSearch_Click"/></p>
        <br />
        <br />
        <asp:Label ID="lblErrorMsg" runat="server" />
     </div>
     <br />
     <br />
    <div class="row col-lg-8 col-md-12" style="text-align:center">
        <p><span style ="font-size:large; text-align:center; font:bold">Car Rental Agencies</span></p>
        <br />
        <div class="btn-row">
            <asp:GridView ID="gvAgencies" runat="server" CssClass="table" >
                <Columns>
                    <asp:TemplateField HeaderText="Cars By Agency">
                        <ItemTemplate>
                            <asp:Button ID="btnSearchByAgency" runat="server" Text="See All Cars" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <br />
        </div>
    </div>

    <div class="row col-lg-3 col-lg-offset-1 col-md-12" style="text-align:center">
        <p><span style ="font-size:large; text-align:center; font:bold">Search for Cars By Amenities</span></p>
        <br />
    </div>
    

  
     
 
</asp:Content>
