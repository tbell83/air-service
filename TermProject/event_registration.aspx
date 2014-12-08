<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="event_registration.aspx.cs" Inherits="TermProject.event_registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ASPX_content" runat="server">
    <div class="row">
        <div class="col-md-10 col-md-offset-1">
            <div class="row">
                <div class="col-md-4 col-md-offset-4" style="text-align:center">
                    <h3>Select a Location:</h3>
                    <asp:DropDownList ID="ddlLocation" runat="server" CssClass="dropdown">
                        <asp:ListItem Text="Philadelphia, PA" Value="philadelphia,pa" />
                        <asp:ListItem Text="Las Vegas, NV" Value="las vegas,nv" />
                    </asp:DropDownList><br /><br />
                    <asp:Button ID="btnSelectLocation" runat="server" Text="Select Location" CssClass="btn-default btn" OnClick="btnSelectLocation_Click" />
                </div>
            </div>
            <div class="row" id="eventOptions" runat="server" visible="false">
                <div class="col-md-6">
                    <h3>Select a Date:</h3>
                    <asp:Calendar ID="calEventDate" runat="server" />
                    <asp:CheckBox ID="chkShowAllDates" runat="server" Text="Show All Dates" />
                </div>
                <div class="col-md-6">
                    <h3>Select a Venue:</h3>
                    <asp:DropDownList ID="ddlVenues" runat="server" AppendDataBoundItems="true" CssClass="dropdown" />
                    <br />
                    <h3>Select an Activity Type:</h3>
                    <asp:DropDownList ID="ddlActivityType" runat="server" AppendDataBoundItems="true" CssClass="dropdown" />
                    <br />
                    <h3>Select a Time:</h3>
                    <asp:DropDownList ID="ddlHour" runat="server">
                        <asp:ListItem Text="1" Value="1" />
                        <asp:ListItem Text="2" Value="2" />
                        <asp:ListItem Text="3" Value="3" />
                        <asp:ListItem Text="4" Value="4" />
                        <asp:ListItem Text="5" Value="5" />
                        <asp:ListItem Text="6" Value="6" />
                        <asp:ListItem Text="7" Value="7" />
                        <asp:ListItem Text="8" Value="8" />
                        <asp:ListItem Text="9" Value="9" />
                        <asp:ListItem Text="10" Value="10" />
                        <asp:ListItem Text="11" Value="11" />
                        <asp:ListItem Text="12" Value="12" />
                    </asp:DropDownList>
                    <asp:DropDownList ID="ddlMinute" runat="server">
                        <asp:ListItem Text="00" Value="00" />
                        <asp:ListItem Text="15" Value="15" />
                        <asp:ListItem Text="30" Value="30" />
                        <asp:ListItem Text="45" Value="45" />
                    </asp:DropDownList>
                    <asp:DropDownList ID="ddlAMPM" runat="server">
                        <asp:ListItem Text="AM" Value="0" />
                        <asp:ListItem Text="PM" Value="12" />
                    </asp:DropDownList>
                    <asp:CheckBox ID="chkAnyTime" Text="Show All Times" runat="server" />
                </div>
                <div class="row">
                    <div class="col-md-12" style="text-align:center">
                        <asp:Button ID="btnSearch" runat="server" Text="Search Events" CssClass="btn-default btn" OnClick="btnSearch_Click" />
                    </div>
                </div>
            </div>
            <div class="row" id="divResults" runat="server" visible="false">
                <div class="row">
                    <div class="col-md-12">
                        <h3>Available Events:</h3>
                        <asp:GridView ID="gvEvents" runat="server" CssClass="table" AutoGenerateColumns="false">
                            <Columns>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:CheckBox ID="chkSelectEvent" runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="EventDate" HeaderText="Date" />
                                <asp:BoundField DataField="EventTime" HeaderText="Time" />
                                <asp:BoundField DataField="EventName" HeaderText="Name" />
                                <asp:BoundField DataField="TicketPrice" HeaderText="Price" />
                                <asp:BoundField DataField="Venue" HeaderText="Location" />
                                <asp:BoundField DataField="EventID" />
                            </Columns>
                        </asp:GridView>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-4 col-md-offset-4" style="text-align:center">
                        <asp:Button ID="btnSelectEvents" runat="server" Text="Register For Selected Events" OnClick="btnSelectEvents_Click" CssClass="btn-default btn" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
