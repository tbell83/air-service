<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="hotel_rental.aspx.cs" Inherits="TermProject.hotel_rental" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ASPX_content" runat="server">
    <div class="row">
        <div class="row col-lg-8 col-offset-2 col-md-8 col-md-offset-2">
            <br />
            <br />
            <p class="text-center"><span style="font-size: x-large">Hotel Reservation Page</span></p>
            <p class="text-center"><span style ="font-size:large">Please enter a city and select a state to search for hotels in that location.</span></p> 
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
                <p><asp:Button ID="btnSearch" runat="server" Text="Search Hotels" OnClick="btnSearch_Click" /></p>
                <p><asp:Button ID="btnNewSearch" runat="server" Text="New Search" Visible="false" OnClick="btnNewSearch_Click"/></p>
                <br />
                <br />
                <asp:Label ID="lblErrorMsg" runat="server" />
        </div>
        
        
    </div>
    <div class="row col-lg-12 col-md-12">
    <asp:Panel ID="pnlHotels" runat="server" Visible="false">
        <br />
        <br />
        <br />
        
        <div class ="row col-lg-4  col-md-6" style="text-align:center">
            <p class="text-center"><span style ="font-size: large; font:bold" >Hotel List</span></p>
            <br />  
            <asp:GridView ID="gvHotel" runat="server" CssClass="table" />
        </div>

        <div class =" row col-lg-7 col-lg-offset-1 col-md-5 col-md-offset-1 col-sm-12" >
            <p><span style ="font-size:large; text-align:center; font:bold">Search for Rooms</span></p>
            <br />
                <p><span style ="font-size:medium; text-align: center; font:bold">Search by Hotel: </span></p>
                <asp:Label ID="lblSearchRooms" runat="server" Text="Select a hotel from the dropdown list to see all available rooms" style="font-style: italic" /> &nbsp &nbsp &nbsp &nbsp
                
                <asp:DropDownList ID="ddlHotel" runat="server">
                    <%--<asp:ListItem Value="1">Stratosphere</asp:ListItem>
                    <asp:ListItem Value="2">Bellagio</asp:ListItem>
                    <asp:ListItem Value="3">Mirage</asp:ListItem>
                    <asp:ListItem Value="4">MGM</asp:ListItem>--%>
                </asp:DropDownList> 
                <br />
                <br />
                <br />
            
                <p><span style ="font-size:medium; text-align: center; font:bold">Search by Amenities: </span></p>
                <asp:Label ID="lblInstructions2" runat="server" Text="Select amenity preferences from the dropdown lists below to refine your room search." style="font-style: italic"></asp:Label>
                <br />
                <br />
                <div class="row col-lg-4 col-md-4">
                    <asp:Label ID="lblWifi" runat="server" Text="Wifi" /> 
                    <br />
                    <asp:DropDownList ID="ddlWifi" runat="server">
                        <asp:ListItem Value="2">No Preference</asp:ListItem>
                        <asp:ListItem Value="1">Yes</asp:ListItem>
                        <asp:ListItem Value="0">No</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <br />
                </div>
                <div class="row col-lg-4 col-md-4">
                    <asp:Label ID="lblSmoking" runat="server" Text="Smoking  " />
                    <br />
                    <asp:DropDownList ID="ddlSmoking" runat="server">
                        <asp:ListItem Value="2">No Preference</asp:ListItem>
                        <asp:ListItem Value="1">Yes</asp:ListItem>
                        <asp:ListItem Value="0">No</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <br />
                </div>
                <div class="row col-lg-4 col-md-4">
                    <asp:Label ID="lblValetParking" runat="server" Text="Valet Parking  " />
                    <br />
                    <asp:DropDownList ID="ddlValetParking" runat="server">
                        <asp:ListItem Value="2">No Preference</asp:ListItem>
                        <asp:ListItem Value="1">Yes</asp:ListItem>
                        <asp:ListItem Value="0">No</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <br />
                </div>
                <div class="row col-lg-4 col-md-4">
                    <asp:Label ID="lblGym" runat="server" Text="Gym  " />
                    <br />
                    <asp:DropDownList ID="ddlGym" runat="server">
                        <asp:ListItem Value="2">No Preference</asp:ListItem>
                        <asp:ListItem Value="1">Yes</asp:ListItem>
                        <asp:ListItem Value="0">No</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <br />
                </div>
                <div class="row col-lg-4 col-md-4">
                    <asp:Label ID="lblPoolsideBar" runat="server" Text="Poolside Bar  " />
                    <br />
                    <asp:DropDownList ID="ddlPoolsideBar" runat="server">
                        <asp:ListItem Value="2">No Preference</asp:ListItem>
                        <asp:ListItem Value="1">Yes</asp:ListItem>
                        <asp:ListItem Value="0">No</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <br />
                </div>
                <div class=" row col-lg-4 col-md-4">
                    <asp:Label ID="lblBreakfast" runat="server" Text="Free Breakfast  " />
                    <br />
                    <asp:DropDownList ID="ddlBreakfast" runat="server">
                        <asp:ListItem Value="2">No Preference</asp:ListItem>
                        <asp:ListItem Value="1">Yes</asp:ListItem>
                        <asp:ListItem Value="0">No</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <br />
                </div>
            
            <p style="align-items:center"><asp:Button ID="btnSearchRooms" runat="server" Text ="Find Rooms" OnClick="btnSearchRooms_Click"  /></p>
        </div>
      <asp:Panel ID="pnlRooms" runat="server" Visible="false" style="padding-top:15px">
        <div class="btn-row col-lg-12 col-md-12" style="font-size:x-large">Hotel Rooms</div>
        <div class="btn-row col-lg-12 col-md-12 col-sm-12" style="font-size:large">To add a room to your vacation package, click "Add to Cart" in the row for that room. </div>
        <asp:GridView ID="gvRooms" runat="server" CssClass="table table-hover table-bordered" OnSelectedIndexChanged="gvRooms_SelectedIndexChanged" AutoGenerateColumns="False" >
            <Columns>
                <asp:CommandField AccessibleHeaderText="Add to Cart" ButtonType="Button" SelectText="Add to Cart " ShowSelectButton="True" />
                <asp:BoundField DataField="Name" HeaderText="Hotel" />
                <asp:BoundField DataField="RoomID" HeaderText="RoomID" />
                <asp:BoundField DataField="RoomNum" HeaderText="Room Number" />
                <asp:BoundField DataField="Price" DataFormatString="{0:c}" HeaderText="Price" />
                <asp:BoundField DataField="Reserved" HeaderText="Reserved" />
            </Columns>
        </asp:GridView>
          <br />
          <br />
          <div class="btn-row col-lg-12 col-md-12" style ="padding: 15px">
              <asp:Label ID="lblErrorRooms" runat="server" style="font-size:x-large" />
          </div>
        </asp:Panel>
    </asp:Panel>
    </div>
</asp:Content>


