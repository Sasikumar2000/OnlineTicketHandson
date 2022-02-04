<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="OnlineTIcketHandsOn.OnlineTicketUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>OnlineTicket</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <style>
       table{
           margin-left:auto;
           margin-right:auto;
           
       }

       td{
           padding: 10px;
       }

       .divmar{
           margin-left:100px;
           margin-right:100px;
       }

       body{
           background-color:aqua;
       }
    .defaultTextBox {
               
            
            height:25px; 
            width: 200px; 
            border-radius: 2em; 
            border: none; 
           
            padding-left: 1.5em; 
            outline: none; 
            box-shadow: 0 4px 6px -5px hsl(0, 0%, 40%), inset 0px 4px 6px -5px hsl(0, 0%, 2%) 
        } 
    h3{
        margin-left:480px;
        margin-right:auto;
    }
 </style>

</head>
<body>
    <h3>Online Ticket Management</h3>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="lblId" runat="server"  Text="BookingId"></asp:Label></td>
                    <td>:</td>
                    <td>
                        <asp:TextBox ID="txtBookingId" class="defaultTextBox" runat="server" ></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblSource" runat="server" Text="Source"></asp:Label></td>
                    <td>:</td>
                    <td>
                        <asp:TextBox ID="txtSource" class="defaultTextBox" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblDestination" runat="server" Text="Destination"></asp:Label></td>
                    <td>:</td>
                    <td>
                        <asp:TextBox ID="txtDestination" class="defaultTextBox" runat="server" ></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblDate" runat="server" Text="Date"></asp:Label></td>
                   <td>:</td>
                    <td>
                        <asp:TextBox ID="txtDate" class="defaultTextBox" runat="server" ></asp:TextBox></td>

                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblTime" runat="server" Text="Time"></asp:Label></td>
                   <td>:</td>
                    <td>
                        <asp:TextBox ID="txtTime" class="defaultTextBox" runat="server" ></asp:TextBox></td>
                    </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblNumberOfPerson" runat="server" Text="NumberOfPerson"></asp:Label></td>
                    <td>:</td>
                    <td>
                        <asp:TextBox ID="txtNumberofperson" class="defaultTextBox" runat="server" ></asp:TextBox></td>

                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblSeatNumber" runat="server" Text="SeatNumber"></asp:Label></td>
                    <td>:</td>
                    <td>
                        <asp:TextBox ID="txtSeatnumber" class="defaultTextBox" runat="server" ></asp:TextBox></td>
                     </tr>
                </table>
                <table>
                <tr>
                    <td>
                        <asp:Button ID="btnsave" runat="server" class="btn btn-success" Text="Save" OnClick="btnsave_Click" Height="43px" Width="120px" /></td>
                    <td>
                        <asp:Button ID="btnupdate" runat="server" class="btn btn-primary" Text="Update" OnClick="btnupdate_Click" Height="44px" Width="122px" /></td>
                    <td>
                        <asp:Button ID="btndelete" runat="server" class="btn btn-danger" Text="Delete" OnClick="btndelete_Click" Height="40px" Width="116px" /></td>
                <td>
                        <asp:Button ID="btnreset" runat="server" class="btn btn-info" Text="Reset" OnClick="btnreset_Click" Height="41px" Width="116px" /></td>
               
                   
                </tr>
            </table>

          <div class="divmar">
            <asp:GridView ID="GVDisplay" class="table table-hover table-responsive" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                <RowStyle ForeColor="#000066" />
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#00547E" />
              </asp:GridView>
              </div>
        </div>
    </form>
</body>
</html>



