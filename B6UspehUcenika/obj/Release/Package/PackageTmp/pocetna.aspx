<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="pocetna.aspx.cs" Inherits="B6UspehUcenika.pocetna" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="GridView1" runat="server">
        <HeaderStyle ForeColor="#0066FF" Font-Underline="true" />
    </asp:GridView>
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
</asp:Content>
