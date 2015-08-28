<%@ Page Title="" Language="C#" MasterPageFile="~/HR.master" AutoEventWireup="true" CodeFile="AddTest_byHR.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .style8
        {
            width: 58px;
        }
        .style9
        {
            width: 285px;
        }
        .style10
        {
            width: 287px;
        }
        .style11
        {
            width: 289px;
        }
        .style12
        {
            width: 290px;
        }
        .style14
        {
            width: 843px;
        }
        .style18
        {
            height: 10px;
            width: 160px;
        }
        .style20
        {
            width: 162px;
        }
        .style21
        {
            width: 287px;
        }
        .style22
        {
            width: 926px;
            height: 103px;
        }
        .style23
        {
            height: 9px;
            width: 160px;
        }
        .style26
        {
            height: 11px;
            width: 160px;
        }
        .style28
        {
            height: 5px;
            width: 160px;
        }
        .style30
        {
            height: 7px;
            width: 160px;
        }
        .style32
        {
            height: 8px;
        }
        .style33
        {
            width: 160px;
        }
        .style34
        {
            height: 9px;
            width: 166px;
        }
        .style35
        {
            height: 10px;
            width: 166px;
        }
        .style36
        {
            height: 11px;
            width: 166px;
        }
        .style37
        {
            height: 5px;
            width: 166px;
        }
        .style38
        {
            height: 7px;
            width: 166px;
        }
        .style39
        {
            width: 166px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <center> <h2>ADD TEST SCHEDULE</h2> </center><br /><br />
<center>
    <table  align="center" width="100%" 
        style="background-color: #666666; color: #FFFFFF; height: 114px;">
<tr> 
<td class="style21"></td>
<td class="style22" height="26px">
<center>
<table style="top: 296px; left: 210px; width: 709px; height: 300px;">
    <tr>
        <td align="left" class="style23" height="23px" >
            
            </td>
        <td align="left" class="style34" height="23px">
            <asp:Label ID="Label3" runat="server" Visible="False"></asp:Label>
        </td>
        <td align="left" class="style20" rowspan="10" >
            <asp:ValidationSummary ID="ValidationSummary2" runat="server" ForeColor="Red" 
                ValidationGroup="submit" />
            <br />
            <br />
        <asp:Calendar ID="Cal" runat="server" Visible="false" 
            onselectionchanged="Cal_SelectionChanged" BackColor="#CCCCCC">
            <DayHeaderStyle ForeColor="Black" />
            <NextPrevStyle ForeColor="Black" />
            <SelectedDayStyle BackColor="Gray" />
            </asp:Calendar>
            <br />
            <br />
            <br />
            <br />
        </td>
    </tr>
    <tr>
        <td align="left" class="style18" height="23px" >
            
            <asp:Label ID="Label1" runat="server" Text="Test Administrator ID:"></asp:Label>
        </td>
        <td align="left" class="style35" height="23px">
            <asp:DropDownList ID="ddltestadminID" runat="server" 
               
                ValidationGroup="submit" 
                onselectedindexchanged="ddltestadminID_SelectedIndexChanged">
            </asp:DropDownList>
        &nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ControlToValidate="ddltestadminID" Display="Dynamic" 
                ErrorMessage="*Please select Test Administrato ID" ForeColor="Red" 
                InitialValue="--select--" ValidationGroup="submit">*</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td align="left" height="23px" class="style26" >
           
            <asp:Label ID="Label2" runat="server" Text="Vacancy ID:"></asp:Label>
        </td>
        <td align="left" class="style36" height="23px">
            <asp:DropDownList ID="ddlvacancyID" runat="server" 
                onselectedindexchanged="ddlvacancyID_SelectedIndexChanged" 
                AutoPostBack="True" ValidationGroup="submit">
            </asp:DropDownList>
        &nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ControlToValidate="ddlvacancyID" Display="Dynamic" 
                ErrorMessage="*Please select vacancy ID" ForeColor="Red" 
                InitialValue="--select--" ValidationGroup="submit">*</asp:RequiredFieldValidator>
       </td>
     </tr>
     <tr>
     <td align="left" height="23px" class="style23" > 
        
         <asp:Label ID="lbRequiredbyDate" runat="server" 
             Text="Required By Date:" Visible="False"></asp:Label>
         </td><td align="left" class="style34" height="23px"> 
             <asp:Label ID="lbReqbyDate" runat="server" Visible="False"></asp:Label>
         </td>
     </tr>
    <tr>
        <td align="left" height="23px" class="style23" >
           
            <asp:Label ID="lbWrittenTestDate" runat="server" Text="Written Test Date" Visible="True"></asp:Label>
        </td>
        <td align="left" class="style34" height="23px">
                            <asp:TextBox ID="tbwritten" runat="server" AutoPostBack="True" BackColor="White" 
                                ForeColor="#333333" ReadOnly="True" 
                                Width="128px" Visible="True" ValidationGroup="submit"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator3"
                       ControlToValidate="tbwritten" ForeColor="Red"
                       runat="server" ErrorMessage="Please enter Written Test Date" 
                                ValidationGroup="submit">*</asp:RequiredFieldValidator>
                     
                                <asp:ImageButton ID="Calwritten" runat="server" Height="26px" 
                                ImageUrl="~/Images/cal.bmp"  Width="25px" onclick="Calwritten_Click" />
        </td>
    </tr>
    <tr>
    <td align="left" height="23px" class="style28" >
        
        <asp:Label ID="lbTechnicalInterviewDate" runat="server" 
            Text="Technical Interview Date:"></asp:Label>
    </td>
    <td align="left" class="style37" height="23px">
                            <asp:TextBox ID="tbtechnical" runat="server" 
            AutoPostBack="True" BackColor="White" ReadOnly="True"
                                ForeColor="#333333"  
                                Width="128px" Visible="True" ValidationGroup="submit"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator4"
                  ControlToValidate="tbtechnical" ForeColor="Red"
                  runat="server" ErrorMessage="Please enter Technical Date "
                  ValidationGroup="submit">*</asp:RequiredFieldValidator>
       
                            <asp:ImageButton ID="CalTechnical" runat="server" Height="26px" 
                                ImageUrl="~/Images/cal.bmp" onclick="CalTechnical_Click" Width="25px" />
                             </td>
    </tr>
    
    <tr>
    <td align="left" height="23px" class="style30" >
       
        <asp:Label ID="lbHRInterviewDate" runat="server" Text="HR Interview Date:"></asp:Label>
        </td>
        <td align="left" class="style38" height="23px">
                            <asp:TextBox ID="tbHR" runat="server" AutoPostBack="True" BackColor="White" 
                                ForeColor="#333333"   ReadOnly="True"
                                Width="128px" Visible="True" ValidationGroup="submit"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5"
                           ControlToValidate="tbHR" ForeColor="Red"
                           runat="server" ErrorMessage="Please enter HR Interview Date" 
                                ValidationGroup="submit">*</asp:RequiredFieldValidator>
                 
                                <asp:ImageButton ID="CalHR" runat="server" Height="26px" 
                                ImageUrl="~/Images/cal.bmp" onclick="CalHR_Click" Width="25px" />
        </td>
    </tr>
     <tr><td height="23px" class="style33" ></td>
         <td class="style39" 
             height="23px"></td></tr>
    <tr><td colspan="2" height="23px" class="style32" >
        <asp:Button ID="Submit" runat="server" Text="Submit" onclick="Submit_Click" 
            ValidationGroup="submit" />&nbsp;&nbsp;&nbsp; </td>
    </tr>
    <tr><td height="23px" class="style33" >&nbsp;</td>
    <td align="left" height="23px" class="style39">
        &nbsp;</td>
    </tr>
</table>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</center>
</td>
<td class="style8"></td>
</tr>
</table>
<br />
<br />
</center>

</asp:Content>

