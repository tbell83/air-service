<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="TermProject.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ASPX_content" runat="server">
    <div class="row">
        <div class="col-md-4 col-md-offset-4">
            <asp:Label ID="lblUsername" Text="Email:" runat="server" CssClass="label" />
            <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control"/>
            <asp:Label ID="lblPassword" Text="Password:" runat="server" CssClass="label" />
            <asp:TextBox ID="txtPassword" runat="server" cssclass="form-control"/>
            <div class="row btn-row"><div class="col-md-12"><asp:Button ID="btnLogin" Text="Login" runat="server" OnClick="btnLogin_Click" CssClass="btn btn-default" /></div></div>
            <div class="row btn-row">
                <div class="col-md-12">
                    <asp:label ID="lblRemember" Text="Remember Me:" runat="server" CssClass="label" />
                    <asp:CheckBox ID="chkRemember" runat="server" CssClass="checkbox-inline"/>
                </div>
            </div>
            <div class="row btn-row"><div class="col-md-12"><asp:LinkButton ID="btnClearCookies" Tex="Clear Cookies" runat="server" OnClick="btnClearCookies_Click">Clear Cookies</asp:LinkButton></div></div>
            <div class="row btn-row"><div class="col-md-12"><asp:LinkButton ID="btnRegister" OnClick="btnRegister_Click" runat="server">Register</asp:LinkButton></div></div>
        </div>
    </div>
</asp:Content>