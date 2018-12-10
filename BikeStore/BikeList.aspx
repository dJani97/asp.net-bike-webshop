<%@ Page Title="Bikes" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BikeList.aspx.cs" Inherits="BikeStore.BikeList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<section>

    <div>
        <hgroup>
            <h2> <%: Page.Title %> </h2>
        </hgroup>
    </div>
    <asp:ListView runat="server" ID="lstViewBikes" GroupItemCount="4" ItemType="BikeStore.Models.Bicycle" DataKeyNames="BicycleID" SelectMethod="GetBikes">

        <EmptyDataTemplate>
            <table>
                <tr><td>No data!</td></tr>
            </table>
        </EmptyDataTemplate>

        <EmptyItemTemplate>
            <td> </td>
        </EmptyItemTemplate>

        <GroupTemplate>
            <tr id="itemPlaceholderContainer" runat="server">
                <td runat="server" id="itemPlaceholder"></td>
            </tr>
        </GroupTemplate>

        <ItemTemplate>
            <td runat="server">
                <table>
                    <tr>
                        <td>
                            <a href="BikeDetails.aspx?BicycleID=<%#: Item.BicycleID %>">
                                <img src="/Catalog/Thumbs/<%#: Item.ImageFile %>" width="100" height="75" style="border:solid"/>
                            </a>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <a href="BikeDetails.aspx?BicycleID=<%#: Item.BicycleID %>">
                                <span> <%#: Item.ModelName %> </span>
                            </a>
                            <br />
                            <span> <b>Recommendations:</b> <%#: Item.Votes %> </span> <br />
                            <span> <b>Ár:</b> <%#: String.Format("{0:c}", Item.Price) %> </span>
                        </td>
                    </tr>
                    <tr>
                       <td>
                           &nbsp;
                       </td>
                    </tr>
                </table>
                <p></p>
            </td>
        </ItemTemplate>

        <LayoutTemplate>
            <table style="width:100%">
                <tbody>
                    <tr>
                        <td>
                            <table id="groupPlaceholderContainer" runat="server" style="width:100%">
                                <tr id="groupPlaceholder"></tr>
                            </table>
                        </td>
                    </tr>
                    <tr><td></td></tr><tr></tr>
                </tbody>
            </table>
        </LayoutTemplate>
    </asp:ListView>
</section>
</asp:Content>