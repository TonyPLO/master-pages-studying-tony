<%@ Page Title="" Language="C#" MasterPageFile="~/Tony.Master" AutoEventWireup="true" CodeBehind="FightersPageDB.aspx.cs" Inherits="master_pages_studying_tony.FightersPageDB" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="myText" runat="server">
            First Text
    </asp:Label>

    <asp:Button runat="server"
        Text="Change Text"
        OnClick="ChangeText" />

    <h1>Fighters List with DB</h1>
    <asp:Repeater ID="Fighters" runat="server">
        <ItemTemplate>

            <div><%# Container.DataItem %></div>

            <p>
                Height = <%# Eval("Height") %>
                Name = <%# Eval("Name") %> 
                HasPositiveRecord = <%# ((master_pages_studying_tony.Models.UFC.UFCFighter)Container.DataItem).HasPositiveRecord() %>
                LastBattle = <%# ((master_pages_studying_tony.Models.UFC.UFCFighter)Container.DataItem).LastBattle.ToString("dd/MM/yy") %> 
                IsHeavy = <%# ((master_pages_studying_tony.Models.UFC.UFCFighter)Container.DataItem).IsHeavy %>
            </p>
        </ItemTemplate>
    </asp:Repeater>
    <div>
        <asp:Label ID="Name" runat="server" Text="Name:"></asp:Label>
        <asp:TextBox ID="NameInput" runat="server"></asp:TextBox>

        <%-- <asp:Label ID="lblSign" runat="server" Text="Sign:"></asp:Label>--%>

        <%--        <asp:RequiredFieldValidator 
            ID="rfv" 
            runat="server" 
            ControlToValidate="NameInput" 
            ErrorMessage="חייב לרשום טקסט" 
            ForeColor="Green" />--%>

        <%--  <asp:TextBox ID="SignInput" runat="server"></asp:TextBox>--%>
        <asp:Label ID="Height" runat="server" Text="Height:"></asp:Label>
        <asp:TextBox ID="HeightInput" runat="server" TextMode="Number"></asp:TextBox>

        <asp:TextBox ID="Birthday" runat="server" TextMode="Date"></asp:TextBox>

        <asp:Button ID="Button3" runat="server" Text="Add New Fighter" OnClick="AddNewFighterDB" />

        <asp:Label ID="Label3" runat="server"></asp:Label>
    </div>
</asp:Content>