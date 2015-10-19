<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditSchedule.aspx.cs" Inherits="WebAcadSchedule.Menu.EditSchedule" %>
<asp:Content ID="HeaderContent" ContentPlaceHolderID="HeadContent" runat="server">

</asp:Content>
<asp:Content ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="MainContent" ContentPlaceHolderID="MainContent" runat="server">
    <p>Plan zajęć</p>
        <asp:GridView runat="server" ID="sbjGridView"></asp:GridView>
</asp:Content>
