<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="AddSchedule.aspx.cs" Inherits="WebAcadSchedule.Menu.AddSchedule" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <div>
        <p>Wybierz przedmiot
        <asp:DropDownList runat="server" ID="ddlSubjects" AutoPostBack="true" OnSelectedIndexChanged="Subjects_SelectedIndexChanged"></asp:DropDownList></p>
        <p>Wybierz typ przedmiotu
        <asp:DropDownList runat="server" ID="ddlSubjectTypes" AutoPostBack="true"></asp:DropDownList></p>
        <p>Wybierz dzień
        <asp:DropDownList runat="server" ID="ddlDays"></asp:DropDownList></p>
        <p>Wybierz godzinę
        <asp:DropDownList runat="server" ID="ddlHours"></asp:DropDownList></p>
        <p>Wybierz wykładowcę
        <asp:DropDownList runat="server" ID="ddlInstructors"></asp:DropDownList></p>
        <p>Wybierz salę
        <asp:DropDownList runat="server" ID="ddlClasses"></asp:DropDownList></p>
    </div>
</asp:Content>
