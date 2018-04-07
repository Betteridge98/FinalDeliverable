<%@ Page Title="" Language="C#" MasterPageFile="~/ProjectBank.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p style="height: 224px">
        <asp:ListBox ID="lstSaleItems" runat="server" style="z-index: 1; left: 0px; top: 38px; position: absolute"></asp:ListBox>
        <asp:Button ID="btnPopulate" runat="server" OnClick="btnPopulate_Click" style="z-index: 1; left: 4px; top: 132px; position: absolute" Text="Button" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 98px; top: 225px; position: absolute"></asp:Label>
    </p>
</asp:Content>

