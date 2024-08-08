<%@ Page Title="" Language="C#" MasterPageFile="~/Tony.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="master_pages_studying_tony.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h2>זהו דף מספר 1</h2>

        <div>
            <h3>תוכן הדף
            </h3>
            <p>
                טקסט משתנה:
            </p>

            <asp:Label ID="text1" runat="server">
                טקסט 1
            </asp:Label>

            <asp:Button runat="server"
                text="שנה טקסט" OnClick="ChangeText"/>
        </div>
    </div>
</asp:Content>
