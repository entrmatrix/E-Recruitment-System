<%@ Page Title="" Language="C#" MasterPageFile="~/HR.master" MaintainScrollPositionOnPostback="true" AutoEventWireup="true" CodeFile="Add_TestAdmin_byHR.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <title>ADD TESTADMINISTRATOR</title>
    <style type="text/css">
        .style8
        {
            width: 131px;
        }
        .style20
        {
            width: 256px;
            height: 35px;
            text-align: right;
        }
        .style22
        {
            width: 256px;
            height: 7px;
        }
        .style24
        {
            height: 16px;
        }
        .style25
        {
            width: 175px;
            height: 35px;
            text-align: left;
        }
        .style27
        {
            width: 103px;
            height: 35px;
            text-align: left;
        }
        .style28
        {
            width: 103px;
            height: 7px;
        }
        .style29
        {
            width: 256px;
            height: 20px;
            text-align: right;
        }
        .style30
        {
            width: 103px;
            height: 20px;
            text-align: left;
        }
        .style31
        {
            width: 175px;
            height: 20px;
        }
        .style32
        {
            height: 16px;
            width: 175px;
        }
        .style33
        {
            width: 175px;
            height: 7px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server"><br />
     <center> <h2>  ADD TESTADMINISTRATOR</h2> </center>
     <br />
     <br />
      <table align="center" style="background-color: #666666; color: #FFFFFF" 
        width="68%">
      <tr>
      <td></td>
      <td align="center" valign="middle">
      <table align="center">
      <tr><td class="style29"></td>
      <td class="style30">  
          </td>
    
      <td class="style31">  
          </td>
    
     </tr>
      <tr><td class="style20"><asp:Label ID="lbTestAdmin" runat="server" Text="Employee ID"></asp:Label>
          :</td>
      <td class="style27">  
          <asp:DropDownList ID="ddlemployees" runat="server" 
              Width="75px" style="margin-left: 9px" >
</asp:DropDownList>   </td>
    
      <td class="style25">  
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ControlToValidate="ddlemployees" Display="Dynamic" InitialValue="--select--"
                        ErrorMessage="*Please select an Employee ID" ValidationGroup="submit" 
                        ForeColor="#FF3300"></asp:RequiredFieldValidator>
          </td>
    
     </tr>
      <tr><td class="style22"></td>
      <td class="style28">  </td>
    
      <td class="style33">  &nbsp;</td>
    
     </tr>
 <tr>
 <td colspan="2" align ="center" class="style24">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
     <asp:Button ID="bttnSubmit" runat="server" 
         Text="Submit" onclick="Submit_Click" ValidationGroup="submit" />
 &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
 </td>
 <td align ="center" class="style32">&nbsp;</td>
 </tr>
 <tr>
 <td colspan="2" align ="center" class="style24">&nbsp;</td>
 <td align ="center" class="style32">&nbsp;</td>
 </tr>
      </table>
      </td>
      <td></td>
      </tr>
      </table>
</asp:Content>

