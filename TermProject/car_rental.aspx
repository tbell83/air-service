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
    <asp:Panel ID="pnlCars" runat="server" visible="false">
        <div class="row col-lg-8 col-md-12" style="text-align:center; padding-right:10px">
            <p><span style ="font-size:large; text-align:center; font:bold">Car Rental Agencies</span></p>
            <br />
            <div class="btn-row">
                <asp:GridView ID="gvAgencies" runat="server" CssClass="table" OnSelectedIndexChanged="gvAgencies_SelectedIndexChanged" >
                    <Columns>
                        <asp:CommandField AccessibleHeaderText="Cars By Agency" ButtonType="Button" HeaderText="Cars By Agency" SelectText="See All Cars" ShowSelectButton="True" />
                    </Columns>
                </asp:GridView>
                <br />
            </div>
        </div>

        <div class="row col-lg-4 col-md-12" style="text-align:center">
            <p><span style ="font-size:large; text-align:center; font:bold">Search for Cars By Amenities</span></p>
            <br />
            <div class="col-lg-6" style="padding-bottom:10px">
                <p style="padding-bottom:3px">Make</p>
                <asp:DropDownList ID="ddlMake" runat="server">
                    <asp:ListItem Value="%">No Preference</asp:ListItem>
                    <asp:ListItem Value="Honda">Honda</asp:ListItem>
                    <asp:ListItem Value="Toyota">Toyota</asp:ListItem>
                    <asp:ListItem Value="Ford">Ford</asp:ListItem>
                    <asp:ListItem Value="Jeep">Jeep</asp:ListItem>
                    <asp:ListItem Value="Fiat">Fiat</asp:ListItem>
                    <asp:ListItem Value="Lincoln">Lincoln</asp:ListItem>
                    <asp:ListItem Value="Voltswagon">Voltswagon</asp:ListItem>
                </asp:DropDownList>
             </div>
            <div class="col-lg-6" style="padding-bottom:10px">
                <p style="padding-bottom:3px">Model</p>
                <asp:DropDownList ID="ddlModel" runat="server">
                    <asp:ListItem Value="%">No Preference</asp:ListItem>
                    <asp:ListItem Value="CRV">CRV</asp:ListItem>
                    <asp:ListItem Value="Corola">Corola</asp:ListItem>
                    <asp:ListItem Value="F-150">F-150</asp:ListItem>
                    <asp:ListItem Value="Durango">Durango</asp:ListItem>
                    <asp:ListItem Value="500">500</asp:ListItem>
                    <asp:ListItem Value="Towncar">Towncar</asp:ListItem>
                    <asp:ListItem Value="Camry">Camry</asp:ListItem>
                    <asp:ListItem Value="Camry">Beetle</asp:ListItem>
                </asp:DropDownList>
            </div>
        
            <div class="col-lg-6" style="padding-bottom:10px">
                <p style="padding-bottom:3px">Type</p>
                <asp:DropDownList ID="ddlType" runat="server">
                    <asp:ListItem Value="%">No Preference</asp:ListItem>
                    <asp:ListItem Value="Car">Car</asp:ListItem>
                    <asp:ListItem Value="Truck">Truck</asp:ListItem>
                    <asp:ListItem Value="All-Terrain">All-Terrain</asp:ListItem> 
                </asp:DropDownList>
            </div>
            <div class="col-lg-6" style="padding-bottom:10px">
                <p style="padding-bottom:3px">Doors</p>
                 <asp:DropDownList ID="ddlDoors" runat="server">
                    <asp:ListItem Value="%">No Preference</asp:ListItem>
                    <asp:ListItem Value="2">2</asp:ListItem>
                    <asp:ListItem Value="4">4</asp:ListItem>
                 </asp:DropDownList>
            </div>     
       
            <div class="col-lg-6" style="padding-bottom:10px">
                <p style="padding-bottom:3px">Transmission</p>
                <asp:DropDownList ID="ddlTransmission" runat="server">
                    <asp:ListItem Value="%">No Preference</asp:ListItem>
                    <asp:ListItem Value="2">Automatic</asp:ListItem>
                    <asp:ListItem Value="4">Manual</asp:ListItem>
                </asp:DropDownList>  
            </div>
          
            <div class="col-lg-6" style="padding-bottom:10px">
                <p style="padding-bottom:3px">GPS</p>
                <asp:DropDownList ID="ddlGPS" runat="server">
                    <asp:ListItem Value="%">No Preference</asp:ListItem>
                    <asp:ListItem Value="Yes">Yes</asp:ListItem>
                    <asp:ListItem Value="No">No</asp:ListItem>
                </asp:DropDownList> 
            </div>
        
            <div class="col-lg-6" style="padding-bottom:10px">
                <p style="padding-bottom:3px">Rearview Camera</p>
                <asp:DropDownList ID="ddlRearviewCamera" runat="server">
                    <asp:ListItem Value="%">No Preference</asp:ListItem>
                    <asp:ListItem Value="Yes">Yes</asp:ListItem>
                    <asp:ListItem Value="No">No</asp:ListItem>
                </asp:DropDownList> 
            </div>
        
            <div class="col-lg-6" style="padding-bottom:10px">
                <p style="padding-bottom:3px">Sunroof</p>
                <asp:DropDownList ID="ddlSunroof" runat="server">
                    <asp:ListItem Value="%">No Preference</asp:ListItem>
                    <asp:ListItem Value="Yes">Yes</asp:ListItem>
                    <asp:ListItem Value="No">No</asp:ListItem>
                </asp:DropDownList> 
            </div>
        
            <div class="col-lg-6" style="padding-bottom:10px">
                <p style="padding-bottom:3px">All-Wheel Drive</p>
                <asp:DropDownList ID="ddlAWD" runat="server">
                    <asp:ListItem Value="%">No Preference</asp:ListItem>
                    <asp:ListItem Value="Yes">Yes</asp:ListItem>
                    <asp:ListItem Value="No">No</asp:ListItem>
                </asp:DropDownList>
            </div> 
        
            <div class="col-lg-6" style="padding-bottom:10px">
                <p style="padding-bottom:3px">Year</p> 
                <asp:DropDownList ID="ddlYear" runat="server">
                    <asp:ListItem Value="%">No Preference</asp:ListItem>
                    <asp:ListItem Value="1999">1999</asp:ListItem>
                    <asp:ListItem Value="2000">2000</asp:ListItem>
                    <asp:ListItem Value="2001">2001</asp:ListItem>
                    <asp:ListItem Value="2002">2002</asp:ListItem>
                    <asp:ListItem Value="2003">2003</asp:ListItem>
                    <asp:ListItem Value="2004">2004</asp:ListItem>
                    <asp:ListItem Value="2005">2005</asp:ListItem>
                    <asp:ListItem Value="2006">2006</asp:ListItem>
                    <asp:ListItem Value="2007">2007</asp:ListItem>
                    <asp:ListItem Value="2008">2008</asp:ListItem>
                    <asp:ListItem Value="2009">2009</asp:ListItem>
                    <asp:ListItem Value="2010">2010</asp:ListItem>
                    <asp:ListItem Value="2011">2011</asp:ListItem>
                    <asp:ListItem Value="2012">2012</asp:ListItem>
                    <asp:ListItem Value="2013">2013</asp:ListItem>
                    <asp:ListItem Value="2014">2014</asp:ListItem>
                </asp:DropDownList>    
            </div>
            <div class="col-lg-12" style="padding-bottom:15px">
                <p style="padding-bottom:3px">Color</p>   
                  <asp:DropDownList ID="ddlColor" runat="server">
                    <asp:ListItem Value="%">No Preference</asp:ListItem>
                    <asp:ListItem Value="Blue">Blue</asp:ListItem>   
                    <asp:ListItem Value="Red">Red</asp:ListItem>
                    <asp:ListItem Value="White">White</asp:ListItem>
                    
                </asp:DropDownList> 
            </div>
            <div class="btn-row">
                <asp:Button ID="btnSearchByAmenities" runat="server" Text="Search By Amenities" OnClick="btnSearchByAmenities_Click" />
            </div>
        </div>

        <asp:Panel ID="pnlCarResults" runat="server" Visible="false" style="padding:15px">
            <div class="btn-row col-lg-12 col-md-12" style="font-size:x-large">Cars</div>
            <div class="btn-row col-lg-12 col-md-12 col-sm-12" style="font-size:large">To add a rental car to your vacation package, click the "Add to Cart" button in the row for that car. </div>
            <asp:GridView ID="gvCars" runat="server" CssClass="table" OnSelectedIndexChanged="gvCars_SelectedIndexChanged" AutoGenerateColumns="False" >
                <Columns>
                    <asp:CommandField ButtonType="Button" SelectText="Add to Cart" ShowSelectButton="True" />
                    <asp:BoundField DataField="Car ID" HeaderText="Car ID" />
                    <asp:BoundField DataField="Year" HeaderText="Year" />
                    <asp:BoundField DataField="Make" HeaderText="Make" />
                    <asp:BoundField DataField="Model" HeaderText="Model" />
                    <asp:BoundField DataField="Type" HeaderText="Type" />
                    <asp:BoundField DataField="Doors" HeaderText="Doors" />
                    <asp:BoundField DataField="Transmission" HeaderText="Transmission" />
                    <asp:BoundField DataField="GPS" HeaderText="GPS" />
                    <asp:BoundField DataField="Rearview Camera" HeaderText="Rearview Camera" />
                    <asp:BoundField DataField="Color" HeaderText="Color" />
                    <asp:BoundField DataField="AWD" HeaderText="AWD" />
                    <asp:BoundField DataField="Daily Rate" DataFormatString="{0:c}" HeaderText="Price" />
                </Columns>
            </asp:GridView>
            <br />
            <div class="btn-row col-lg-12 col-md-12" style ="padding: 15px">
              <asp:Label ID="lblErrorCars" runat="server" style="font-size:x-large" />
          </div>
        </asp:Panel>
        
    </asp:Panel>
  
     
 
</asp:Content>
