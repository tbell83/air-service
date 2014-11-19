<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="TermProject.registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ASPX_content" runat="server">
    <div class="row">
        <div class="col-md-4 col-md-offset-2">
            <asp:Label ID="lblFirstName" Text="First Name:" runat="server" CssClass="label" />
            <asp:TextBox ID="txtFirstName" runat="server" CssClass="form-control" />
        </div>
        <div class="col-md-4">
            <asp:Label ID="lblLastName" Text="Last Name:" runat="server" CssClass="label" />
            <asp:TextBox ID="txtLastName" runat="server" CssClass="form-control" />
        </div>
    </div>
    <div class="row">
        <div class="col-md-4 col-md-offset-2">
            <asp:Label ID="lblAddress" Text="Address:" runat="server" CssClass="label" />
            <asp:TextBox ID="txtAddress" runat="server" CssClass="form-control" />
        </div>
        <div class="col-md-4">
            <asp:Label ID="lblEmail" Text="Email Address:" runat="server" CssClass="label" />
            <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" />
        </div>
    </div>
    <div class="row">
        <div class="col-md-4 col-md-offset-2">
            <asp:Label ID="lblPassword" Text="Password:" runat="server" CssClass="label" />
            <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" />
        </div>
        <div class="col-md-4">
            <asp:Label ID="lblPasswordConfirm" Text="Confirm Password:" runat="server" CssClass="label" />
            <asp:TextBox ID="txtPasswordConfirm" runat="server" CssClass="form-control" />
        </div>
    </div>
    <div class="row btn-row">
        <div class="col-md-12">
            <asp:Button ID="btnRegister" Text="Register" runat="server" CssClass="btn-default btn" OnClick="btnRegister_Click"/>
        </div>
    </div>
    <div class="row btn-row">
        <div class="col-md-12">
            <asp:label ID="lblRemember" Text="Remember Me:" runat="server" CssClass="label" />
            <asp:CheckBox ID="chkRemember" runat="server" CssClass="checkbox-inline"/>
        </div>
    </div>
</asp:Content>