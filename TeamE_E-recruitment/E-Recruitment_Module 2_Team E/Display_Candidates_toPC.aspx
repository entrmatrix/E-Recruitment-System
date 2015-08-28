<%@ Page Title="" Language="C#" MasterPageFile="~/PlacementConsultant.master" MaintainScrollPositionOnPostback="true" AutoEventWireup="true" CodeFile="Display_Candidates_toPC.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    
    <style type="text/css">
        .style16
        {
            width: 200px;
            text-align: right;
        }
        .style17
        {
            width: 85px;
        }
        .style18
        {
            width: 200px;
            text-align: right;
            height: 24px;
        }
        .style19
        {
            width: 85px;
            height: 24px;
        }
        .style20
        {
            height: 24px;
        }
    </style>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">


  <center>
   <h2>
       <strong> CANDIDATE PROFILES:</strong>&nbsp;</h2>
        
    </center>
    <br />

    <center>
<table style="color: #FFFFFF; width: 896px;">
<tr>
<td style="width:10%"></td>
<td style="width:80%">
    
    <asp:Panel ID="Panel1" runat="server" HorizontalAlign="Center">
    <table style="width:68%;" align="center" bgcolor="#666666" >
        <tr>
            <td class="style16">
                &nbsp;</td>
            <td class="style17" style="text-align: left">
                &nbsp;</td>
            <td style="text-align: left"> 
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style16">
                <asp:Label ID="lbVacancyID" runat="server" Text="Vacancy ID:"></asp:Label>
                &nbsp;&nbsp;
            </td>
            <td class="style17" style="text-align: left">
                <asp:DropDownList ID="ddlvacancyID" runat="server">
                </asp:DropDownList>
            </td>
            <td style="text-align: left">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="ddlvacancyID" ErrorMessage="*Please select Vacancy ID" 
                    ForeColor="Red" InitialValue="--select--" ValidationGroup="submit"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr><td class="style18"></td><td class="style19"></td><td class="style20"></td></tr>
        <tr>
            <td class="style16">
            </td>
            <td class="style17" style="text-align: left" >
                <asp:Button ID="btnSearch" runat="server" Text="Search" 
                    onclick="btnSearch_Click" ValidationGroup="submit" /></td>
            
           
            <td>
            </td>
            
           
        </tr>
        <tr>
            <td class="style16">
                &nbsp;</td>
            <td class="style17" style="text-align: left">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    </asp:Panel>
    
<br />
<br />
    <asp:GridView ID="gv_CandidateProfile" runat="server" 
        AutoGenerateColumns="False" AllowPaging="True" AllowSorting="True" 
        Height="317px" onpageindexchanging="gv_CandidateProfile_PageIndexChanging" 
        Width="789px" BackColor="#666666" >
        
        <Columns>
            <asp:BoundField DataField="get_CandidateProfileID" 
                HeaderText="Candidate ID" />
            <asp:BoundField DataField="get_DOB" HeaderText="Date of Birth" />
            <asp:BoundField DataField="get_Gender" HeaderText="Gender" />
            <asp:BoundField DataField="get_Location" HeaderText="Location" />
            <asp:BoundField DataField="get_Percentage_10" HeaderText="X Percentage" />
            <asp:BoundField DataField="get_Percentage_12" HeaderText="XII Percentage" />
            <asp:BoundField DataField="get_GapInEducation" 
                HeaderText="Gap in Education" />
            <asp:BoundField DataField="get_GapInExperience" HeaderText="Gap in Experience" />
        </Columns>
        <HeaderStyle BackColor="Black" />
        <PagerStyle ForeColor="White" HorizontalAlign="Center" BackColor="#333333" />
    </asp:GridView>
    <br />
<br />
    </td>
    <td style="width:10%"></td>
    </tr>
    </table>
    </center>
</asp:Content>


