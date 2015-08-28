<%@ Page Title="" Language="C#" MasterPageFile="~/HR.master" MaintainScrollPositionOnPostback="true" AutoEventWireup="true" CodeFile="Display_Candidates_toHR.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">

    <style type="text/css">
        .style15
        {
            width: 89%;
        }
        .style18
        {
            width: 253px;
            text-align: right;
        }
        .style19
        {
            width: 110px;
        }
    </style>

    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">

     <fieldset >
     <center>
   <h2>
       <strong> CANDIDATE PROFILES:</strong>
    </h2>
    <br>
    <table style="color: #FFFFFF;">
    <tr>
    <td></td>
    <td class="style15">
     <asp:Panel ID="Panel1" runat="server" HorizontalAlign="Center">
    <table style="width:68%; height: 126px;" align="center" bgcolor="#666666" >
        <tr>
            <td class="style18">
                &nbsp;</td>
            <td class="style19" style="text-align: left">
                &nbsp;</td>
            <td style="text-align: left"> 
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style18">
                <asp:Label ID="lbVacancyID" runat="server" Text="Vacancy ID:"></asp:Label>
                &nbsp;&nbsp;
            </td>
            <td class="style19" style="text-align: left">
                <asp:DropDownList ID="ddlvacancyID" runat="server">
                </asp:DropDownList>
            </td>
            <td style="text-align: left">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="ddlvacancyID" ErrorMessage="*Please select Vacancy ID" 
                    ForeColor="Red" InitialValue="--select--" ValidationGroup="submit"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr><td class="style18"></td><td class="style19"></td><td></td></tr>
        <tr>
            <td class="style18">
            </td>
            <td class="style19" style="text-align: left" >
                <asp:Button ID="btnSearch" runat="server" Text="Search" 
                    onclick="btnSearch_Click" ValidationGroup="submit" /></td>
            
           
            <td>
            </td>
            
           
        </tr>
        <tr>
            <td class="style18">
                &nbsp;</td>
            <td class="style19" style="text-align: left">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    <br />
    </asp:Panel>
    <br />
    <br />
         <asp:GridView ID="gv_CandidateProfile" runat="server" 
             AutoGenerateColumns="False" AllowPaging="True" AllowSorting="True" 
             onpageindexchanging="gv_CandidateProfile_PageIndexChanging" Width="872px" 
            BackColor="#666666" HorizontalAlign="Center">
             <Columns>
                 <asp:BoundField DataField="get_VacancyID" HeaderText="Vacancy ID" />
                 <asp:BoundField DataField="get_CandidateProfileID" 
                     HeaderText="Candidate ID" />
                 <asp:BoundField DataField="get_DOB" HeaderText="Date of Birth" />
                 <asp:BoundField DataField="get_Gender" HeaderText="Gender" />
                 <asp:BoundField DataField="get_TestID" HeaderText="Test ID" />
                 <asp:BoundField DataField="get_TestStatus" HeaderText="Test Status" />
                 <asp:BoundField DataField="get_WrittenTestDate" 
                     HeaderText="Written Test Date" />
                 <asp:BoundField DataField="get_TechnicalInterviewDate" 
                     HeaderText="Technical Interview Date" />
                 <asp:BoundField DataField="get_HRInterviewDate" HeaderText="HR Interview Date" />
             </Columns>
             <HeaderStyle BackColor="Black" />
             <PagerStyle BackColor="Black" ForeColor="White" HorizontalAlign="Center" />
         </asp:GridView>
         <br />
         <br />
         </td>
         <td style="width:10%"></td>
         </tr>
         </table>
        
        </center>
    </fieldset>
    

</asp:Content>

