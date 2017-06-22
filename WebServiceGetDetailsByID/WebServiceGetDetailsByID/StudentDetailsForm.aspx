<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentDetailsForm.aspx.cs" Inherits="WebServiceGetDetailsByID.StudentDetailsForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }

        .auto-style2 {
            width: 409px;
        }

        .auto-style3 {
            width: 409px;
            text-align: center;
        }
    </style>
    
       <script type="text/javascript">
        
           function GetStudentById() 
           {
               var id = document.getElementById("TextBox1").value;
               WebServiceGetDetailsByID.StudentService.GetStudentById(id, 
                   GetStudentByIdSuccessCallback, GetStudentByIdFailedCallback);
           }

           function GetStudentByIdSuccessCallback(result) 
           {
               document.getElementById("Fname").innerText = result["Fname"];
               document.getElementById("Lname").innerText = result["Lname"];
               
           }


           
           function GetStudentByIdFailedCallback(errors) 
           {
               alert(errors.get_message());
           }

               
    </script>

</head>
<body>
    <form id="form1" runat="server">

        <!-- include SCRIPT Manger control to call web Service specify service and set path to student service -->

        <asp:ScriptManager ID="ScriptManager1" runat="server">
            <Services>

                <asp:ServiceReference Path="~/StudentService.asmx.cs" />

            </Services>


        </asp:ScriptManager>
        
                    <table class="auto-style1">
                <tr>
                    <td class="auto-style3" colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Get Student Details(No Postback to button control(HTML Button) we used javascript to get data through AJAX call )</td>

                </tr>
                <tr>
                    <td class="auto-style2">EnterId:</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <input id="Button1" type="button" value="GetDetails" onclick="GetStudentById()" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;FirstName:</td>
                    <td>
                        <asp:TextBox ID="Fname" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">LastName:</td>
                    <td>
                        <asp:TextBox ID="Lname" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>



        
    </form>
</body>
</html>
