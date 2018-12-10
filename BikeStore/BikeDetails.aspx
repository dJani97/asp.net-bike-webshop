<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BikeDetails.aspx.cs" Inherits="BikeStore.BikeDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:FormView runat="server" id="Details"
        ItemType="BikeStore.Models.Bicycle" 
        DataKeyNames="BicycleID" 
        SelectMethod="GetOneBike" 
        RenderOuterTable="false">

        <ItemTemplate>
            <div>
                <h1><%#: Item.ModelName %></h1>
            </div>
            <br />
            <table>
                <tr>
                    <td>
                        <img src="/Catalog/<%#: Item.ImageFile %>" style="border:solid; height:300px" />
                    </td>
                    <td>&nbsp</td>
                    <td style="vertical-align:top; text-align:left">
                        <b>Manufacturer:</b> 
                        <%#: Item.Manufacturer %> <br />

                        <b>Price:</b>
                        <%#: Item.Price %>  <br />

                        <b>Type:</b> 
                        <%#: Item.Type %> <br />

                        <b>ID:</b> 
                        <%#: Item.BicycleID %> <br />

                        <b>Recommendations:</b> 
                        <%#: Item.Votes %> <br />
                        <br />

                        <a href="/VoteForBike.aspx?id=<%#: Item.BicycleID %>">Recommendations this Bike!</a>

                    </td>
                </tr>
            </table>
        </ItemTemplate>

    </asp:FormView>

</asp:Content>