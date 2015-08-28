<%@ Page Title="Add Placement Consultant" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="AddPlacementConsultant.aspx.cs" Inherits="AddPlacementConsultant" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <div>

  <fieldset>
     <legend>Add Placement Consultant</legend>
    <div>
    
    <table>
    <tr>
    <td>
        <asp:Label ID="Label1" runat="server" Text="PlacementConsultantName"></asp:Label>
        </td>
         <td>
        <asp:TextBox ID="NameBox" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please enter placement consultant name" 
            ControlToValidate="NameBox" Display="Dynamic" ValidationGroup="abc"></asp:RequiredFieldValidator>
            
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
             ErrorMessage="Please enter only alphabets" 
                Display="Dynamic" ControlToValidate="NameBox" ValidationExpression="^[a-zA-Z\s]*$" ValidationGroup="abc"></asp:RegularExpressionValidator>
        </td>
       
        </tr>
        <tr>
         <td>
        <asp:Label ID="Label2" runat="server" Text="Password" ></asp:Label>
        </td>
         <td>
        <asp:TextBox ID="PasswordBox" runat="server" TextMode="Password" Width="148px"></asp:TextBox>
        </td>
        <td>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please enter the password"
              ControlToValidate="PasswordBox" Display="Dynamic" ValidationGroup="abc"></asp:RequiredFieldValidator>
        </td>
       
        </tr>
        <tr>
         <td>
        <asp:Label ID="Label3" runat="server" Text="Details"></asp:Label>
        </td>
         <td>
        <asp:TextBox ID="DetailBox" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Please enter the details" 
            ControlToValidate="DetailBox" Display="Dynamic" ValidationGroup="abc"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" 
                runat="server"  ControlToValidate="DetailBox" 
           
            ErrorMessage="Please enter only alphabets"  Display="Dynamic" 
                ValidationExpression="^[a-z A-Z\s]*$" ValidationGroup="abc"></asp:RegularExpressionValidator>
        
        </td>
      
        </tr>
        <tr>
         <td>        
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;        
        <asp:Button ID="Button1" runat="server" Text="Submit"
                 Width="70px" onclick="Button1_Click" ValidationGroup="abc"   />
            </td>
 <td>
        &nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Cancel"  Width="70px" 
            onclick="Button2_Click" OnClientClick="return confirm('Are you sure you want to cancel?');" />
         </td>
        </tr>
        <tr>
         <td>        
             &nbsp;</td>
 <td>
        &nbsp;</td>
        </tr>
    </table>
    </div>
    <div>
    <br />
    <asp:Label ID="Label4" runat="server"  Font-Size="Large" Text="Label" Visible="false"></asp:Label>
    </div>
    </fieldset>
    </div>
</asp:Content>

