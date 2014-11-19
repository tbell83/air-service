<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="protected.aspx.cs" Inherits="TermProject._protected" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ASPX_content" runat="server">
    <div class="row">
        <div class="col-md-10 cold-md-offset-1">
            <asp:Label ID="lblProtected" Text="You can only see this if youre logged in." runat="server" CssClass="h1"/>
        </div>
    </div>
</asp:Content>
