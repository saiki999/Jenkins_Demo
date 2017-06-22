<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BaggageTrack.aspx.cs" Inherits="BaggageCheckingApp.BaggageTrack" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Track Your Bag</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="container" style="color:brown;background-color:cornsilk;border:groove">
        <div class="row" style="color:red" >
       
        <div class="col-lg-12" style="text-align:center;background-color:lightcyan">

            <h3>Passenger Baggage Confirmation</h3>
            </div>
            </div>


        <div class="row"> 
            <div class="col-lg-3"> </div> 

              <div class="col-lg-6" style="text-align:center;color:yellow">

 <h4 style="color:black"> Please Enter the Following</h4>
                  <table class="table" style="color:black;text-align:left;border:solid;background-color:lightcyan">
                      <tr>
                          <td>Ship:</td>
                          <td>
                              <asp:DropDownList ID="Ship" runat="server" DataSourceID="SqlDataSource1" DataTextField="Flight_Number" DataValueField="Flight_Number"></asp:DropDownList>
                              <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BagsPassengersDBConnectionString %>" SelectCommand="SELECT [Flight_Number] FROM [FlightDetails]"></asp:SqlDataSource>
                          </td>

                      </tr>

                      <tr>
                          <td>ReturnDate:</td>
                          <td>
                              <asp:Calendar ID="calReturndate" runat="server" SelectedDate="2017-06-20"></asp:Calendar>
                          </td>

                      </tr>

                      <tr>
                          <td>LastName:</td>
                          <td> <asp:TextBox ID="LastName" runat="server"></asp:TextBox></td>
                             
                      </tr>

                       <tr>
                          <td>Cabin:</td>
                          <td> <asp:TextBox ID="Cabin" runat="server"></asp:TextBox></td>
                              
                      </tr>
                      <tr style="text-align:right">
                          <td><asp:Label ID="Label1" runat="server" BackColor="#66FF33" Font-Bold="True" ForeColor="Black" Visible="False"></asp:Label>
                              <asp:Label ID="lblvalresult" runat="server" Text="Label" Visible="False"></asp:Label>
                          </td>
                          <td >
                          
                              <asp:Button ID="Button1" runat="server" Text="Submit" style="background-color:yellow;border:solid" OnClick="Button1_Click" />
                      </td>
                          </tr>
                    
                  </table>
             
              </div>
            
        </div>
        <div class="row">
            <div class="col-lg-3"> </div>
            <div class="col-lg-6" style="text-align:center;color:yellow">
            <asp:Panel ID="Panel1" runat="server" BorderStyle="Solid" Visible="False" style="color:black">
                <asp:Label ID="lblbaglist" runat="server" Text="Label" ForeColor="Black" BackColor="#99FF33" BorderColor="Black" Visible="False"></asp:Label>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Bag_Tag_Number" DataSourceID="SqlDataSource2" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1" CellPadding="4" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="Bag_Tag_Number" HeaderText="Bag_Tag_Number" ReadOnly="True" SortExpression="Bag_Tag_Number" />
                </Columns>
                <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                <RowStyle BackColor="White" ForeColor="#003399" />
                <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                <SortedAscendingCellStyle BackColor="#EDF6F6" />
                <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                <SortedDescendingCellStyle BackColor="#D6DFDF" />
                <SortedDescendingHeaderStyle BackColor="#002876" />
                </asp:GridView>
                <asp:Label ID="lblbagavail" runat="server" BackColor="Red" BorderColor="Black" Visible="False" Font-Bold="True"></asp:Label>
              <%--  <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="SqlDataSource2" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                    <Columns>
                        <asp:TemplateField HeaderText="Bag_Tag_Number">
                            <ItemTemplate>

                                <asp:LinkButton ID="LinkButton1" OnClick="GridView1_SelectedIndexChanged" Text='<%#Eval("Bag_Tag_Number") %>' runat="server">LinkButton</asp:LinkButton>
                            </ItemTemplate>

                        </asp:TemplateField>


                    </Columns>


                    <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                    <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                    <RowStyle BackColor="White" ForeColor="#330099" />
                    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                    <SortedAscendingCellStyle BackColor="#FEFCEB" />
                    <SortedAscendingHeaderStyle BackColor="#AF0101" />
                    <SortedDescendingCellStyle BackColor="#F6F0C0" />
                    <SortedDescendingHeaderStyle BackColor="#7E0000" />


                </asp:GridView>--%>

                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:BagsPassengersDBConnectionString %>" SelectCommand="SELECT [Bag_Tag_Number] FROM [BaggageInfo] WHERE ([PNR] = @PNR)">
                    <SelectParameters>
                        <asp:SessionParameter Name="PNR" SessionField="pnr" Type="Int32" />
                    </SelectParameters>
                </asp:SqlDataSource>

            </asp:Panel>
             </div>         
            </div>
         <div class="row">

             <div class="col-lg-3"> </div>
             <div class="col-lg-6" style="text-align:center;color:blue">
                 
                 <asp:Panel ID="Panel2" runat="server" Visible="False">
                     
                     <h4 style="color:black">Baggage Information</h4>
                     <table class="table" style="color:black;text-align:left;border:solid;background-color:lightcyan">
                         <tr >

                             <td>Bag Tag Number</td>
                             <td>
                                 <asp:Label ID="bagtagnumber" runat="server"></asp:Label></td>

                         </tr>
                                                  <tr >

                             <td>Last Scan Date</td>
                             <td>
                                 <asp:Label ID="lastscandate" runat="server"></asp:Label></td>

                         </tr>
                         <tr >

                             <td>Bag Status</td>
                             <td style="color:orange;text-decoration:solid">
                                 <asp:Label ID="bagstatus" runat="server"></asp:Label></td>

                         </tr>
                         </table>
                     <h4 style="color:black">Flight Information</h4>
                     <table class="table" style="color:black;text-align:left;border:solid;background-color:lightcyan">
                         <tr >

                             <td>Airline</td>
                             <td>
                                 <asp:Label ID="airline" runat="server"></asp:Label></td>

                         </tr>
                                                  <tr >

                             <td>Flight Number</td>
                             <td>
                                 <asp:Label ID="flightnumber" runat="server"></asp:Label></td>

                         </tr>
                         <tr >

                             <td>Departure Time</td>
                             <td>
                                 <asp:Label ID="departuretime" runat="server"></asp:Label></td>

                         </tr>
                         <tr >

                             <td>Departure Airport</td>
                             <td>
                                 <asp:Label ID="departureairport" runat="server"></asp:Label></td>

                         </tr>
                         </table>

                     <h4 style="color:black">Passenger Information</h4>
                     <table class="table" style="color:black;text-align:left;border:solid ;background-color:lightcyan">
                         <tr >

                             <td>PassangerName</td>
                             <td>
                                 <asp:Label ID="passengername" runat="server"></asp:Label></td>

                         </tr>
                                                  <tr >

                             <td>Ship</td>
                             <td>
                                 <asp:Label ID="lblship" runat="server"></asp:Label></td>

                         </tr>
                         <tr >

                             <td>Cabin</td>
                             <td>
                                 <asp:Label ID="lblcabin" runat="server"></asp:Label></td>

                         </tr>
                         <tr >

                             <td>Return Date</td>
                             <td>
                                 <asp:Label ID="returndate" runat="server"></asp:Label></td>

                         </tr>
                         </table>




                 </asp:Panel>

                 </div>
             </div>

      <div class="row" style="text-align:center;color:crimson;background-color:black">
          <footer>
              <p>Created By: SaikiranKommanaboina &copy;copyright 2017</p>
          </footer>

      </div>

            </div>
   
       
    </form>
</body>
</html>
