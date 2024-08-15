<%@ Page Title="" Language="C#" MasterPageFile="~/Tony.Master" AutoEventWireup="true" CodeBehind="FightersPage.aspx.cs" Inherits="master_pages_studying_tony.FighersPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <asp:Label id="myText" runat="server">
            First Text
    </asp:Label>

    <asp:Button runat="server" 
        text="Change Text"
        onClick="ChangeText"/>

    <h1>Fighters List</h1>
    <asp:Repeater ID="Fighters" runat="server">
        <ItemTemplate>

            <div><%# Container.DataItem %></div>

            <p> 
                Height = <%# Eval("Height") %>
                Name = <%# Eval("Name") %> 
                HasPositiveRecord = <%# ((master_pages_studying_tony.Models.UFC.UFCFighter)Container.DataItem).HasPositiveRecord() %>
            </p>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
