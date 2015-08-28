<%@ Page Title="Add Vacancy Request" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Addvacancyrequest.aspx.cs" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
 <script  type="text/javascript" language="javascript">
     function disableBackButton() {
         window.history.forward(1000);
     }
     setTimeout("disableBackButton()", 0);
</script>
    <style type="text/css">
        .style6
        {
            width: 440px;
        }
        .style7
        {
            width: 139px;
        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">

    <div style="width: 836px; margin-left: 37px; margin-top: 20px">
    <fieldset>
     <legend>Vacancy Request</legend>
     <div>
    <table style="width: 97%; height: 82px; margin-top: 16px;">
        <tr>
            <td class="style7">  
            &nbsp;&nbsp;&nbsp;  
            <asp:Label ID="Empll" runat="server" Text="Employee Name"></asp:Label>
            </td>
            <td class="style6">
                &nbsp;
                <asp:Label ID="empname" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style7">
                &nbsp;
                <asp:Label ID="posll" runat="server" Text="Number of Vacancies"></asp:Label>
            </td>
            <td class="style6">
                &nbsp;
                <asp:TextBox ID="posttb" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="posfield" runat="server" 
                    ErrorMessage="Please enter number of vacancies" ValidationGroup="submit" 
                    ControlToValidate="posttb" Display="Dynamic"></asp:RequiredFieldValidator>
                &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server"
                ErrorMessage="Please enter only numbers" 
                Display="Dynamic" ControlToValidate="posttb" ValidationExpression="^[0-9]*$" ValidationGroup="submit"></asp:RegularExpressionValidator>

            </td>
        </tr>
        </table>

        <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="vacbut" runat="server" Text="Submit" Height="25px" 
        onclick="Button1_Click" style="margin-left: 151px; margin-top: 12px" 
        ValidationGroup="submit"/>


    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:Button ID="Button1" runat="server" Height="25px" onclick="Button1_Click1" OnClientClick="return confirm('Are you sure you want to cancel?');"
             Text="Cancel" />


    <br />
    <br />
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="outll" runat="server" Text="Vacancy Request ID:" Visible="False"></asp:Label>
    &nbsp;<br />
    </div>
    </fieldset>

</div>


    </asp:Content>
