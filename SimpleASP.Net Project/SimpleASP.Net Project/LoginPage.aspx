<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="SimpleASP.Net_Project.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>LoginPage</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <a href="Default.aspx">HomePage</a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <a href="Registration.aspx">RegestrationPage</a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/RegistrationDetails.aspx" Target="_blank">Registered Details</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/StoreInBrowserCacheObject.aspx">Data Using Cache</asp:HyperLink>
    </div>
           <div>

               <asp:Table runat="server">
                   <asp:TableRow>
                       <asp:TableCell>
               <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
                   </asp:TableCell>
                       <asp:TableCell>          
               <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
             </asp:TableCell>
                       </asp:TableRow>
                   
                   <asp:TableRow>
                       <asp:TableCell>
               <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                       </asp:TableCell>
                       <asp:TableCell>
               <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                           </asp:TableCell>    
                       </asp:TableRow>
               </asp:Table>


               <asp:Button ID="Submit" runat="server"  Text="Login" OnClick="Submit_Click"/>
        </div>
    </form>
</body>
</html>
