<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BikeGrid.aspx.cs" Inherits="BikeStore.BikeGrid" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <hgroup>
            <h2> <%: Page.Title %> 
                <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" AllowSorting="True" AutoGenerateColumns="False" Width="100%">
                    <Columns>
                        <asp:BoundField DataField="ModelName" HeaderText="ModelName" SortExpression="ModelName" />
                        <asp:BoundField DataField="Type" HeaderText="Type" SortExpression="Type" />
                        <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
                        <asp:BoundField DataField="Votes" HeaderText="Votes" SortExpression="Votes" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT ModelName, Type, Price, Votes FROM Bicycles
ORDER BY Votes DESC"></asp:SqlDataSource>
            </h2>
        </hgroup>
    </div>







</asp:Content>