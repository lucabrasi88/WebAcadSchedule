<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebAcadSchedule._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1><%: Title %>.</h1>
                <h2>Modify this template to jump-start your ASP.NET application.</h2>
            </hgroup>
            <p>
            </p>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <ol class="round">
        <li class="one">
            <h5>Przeglądaj plan zajęć</h5>
        </li>
        <li class="two">
            <h5>Dodaj plan zajęć</h5>
        </li>
        <li class="three">
            <h5>Edytuj plan zajęć</h5>            
        </li>
        <li class="four">
            <h5>Dodaj element planu</h5>
        </li>
    </ol>
</asp:Content>
