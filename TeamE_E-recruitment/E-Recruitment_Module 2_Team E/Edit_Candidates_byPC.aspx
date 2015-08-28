<%@ Page Title="" Language="C#" MasterPageFile="~/PlacementConsultant.master" MaintainScrollPositionOnPostback="true" AutoEventWireup="true" CodeFile="Edit_Candidates_byPC.aspx.cs" Inherits="Default2" %>


<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .style18
        {
            height: 2px;
        }
        .style19
        {
            width: 14%;
            height: 2px;
        }
        .style20
        {
            height: 1px;
        }
        .style21
        {
            width: 14%;
            height: 1px;
        }
        .style22
        {
            width: 14%;
        }
        .style23
        {
            height: 19px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">

     <center>
     <h2>EDIT CANDIDATE PROFILE:</h2></center>
    <br />
    <center>
    <table style="height: 26px; width: 662px; background-color: #666666;">
    <tr>
    <td style="color: #FFFFFF" width="30%" class="style20">
        </td>
    <td style="color: #FFFFFF" width="15%" class="style20">
        </td>
    <td class="style21" valign="middle">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="ddlvacancy" ErrorMessage="Please select Vacancy ID" 
            InitialValue="Select" Text="*" ValidationGroup="submit">*</asp:RequiredFieldValidator>
        </td>
        
    
    <td width="40%" valign="middle" class="style20">
        </td>
        
    
    </tr>
    <tr>
    <td style="color: #FFFFFF" width="30%" class="style20">
        </td>
    <td style="color: #FFFFFF" width="15%" class="style20">
        <strong>Vacancy ID:
    </strong>
    </td>
    <td class="style21" style="text-align: left" valign="middle">
    &nbsp;&nbsp;
    <asp:DropDownList ID="ddlvacancy" runat="server" Height="19px" 
       
            style="text-align: left">
        <asp:ListItem>Select</asp:ListItem>
        
    </asp:DropDownList>
        
    &nbsp 
        </td>
        
    
    <td width="40%" align="left" class="style20" valign="middle">
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="#FF3300" 
            style="text-align: left" ValidationGroup="submit" DisplayMode="List" />
        </td>
        
    
    </tr>
    <tr>
    <td width="30%"></td>
    <td width="15%"></td>
    <td class="style22" valign="middle"><br /></td>
    <td width="40%" valign="middle"></td>
    </tr>
    <tr>
    <td width="30%" class="style23"></td>
    <td colspan="2" valign="middle" class="style23"><asp:Button ID="Submit" ValidationGroup="submit" runat="server" Text="Submit" onclick="Submit_Click" /></td>
    <td width="40%" valign="middle" class="style23"></td>
    </tr>
    <tr>
    <td width="30%" class="style18"></td>
    <td width="15%" class="style18"></td>
    <td class="style19" valign="middle"></td>
    <td width="40%" valign="middle" class="style18"></td>
    </tr>
    </table>
    </center>
 <center>&nbsp;&nbsp;&nbsp;
    
     <br />
     
    </center>
    <br />

    <table>
    <tr>
    <td style="width:10%"></td>
    <td style="width:80%" >
    <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" 
        onrowdeleting="gv_RowDeleting" 
        onselectedindexchanged="gv_SelectedIndexChanged" Height="75px" 
        Width="781px" AllowPaging="True" AllowSorting="True" 
        EmptyDataText="No data in the system to display." ForeColor="White" 
            BackColor="#666666" onpageindexchanging="gv_PageIndexChanging">
        <Columns>
            <asp:CommandField SelectText="Edit" ShowSelectButton="True" />
            <asp:CommandField ShowDeleteButton="True" />
            <asp:TemplateField HeaderText="Candidate ID ">
               
                <ItemTemplate>
                    <asp:Label ID="CandidateProfileID" runat="server" 
                        Text='<%# Bind("[CandidateProfileID ]") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Date of birth">
                <ItemTemplate>
                    <asp:Label ID="DOB" runat="server" Text='<%# Bind("DOB") %>'></asp:Label>
                </ItemTemplate>
                
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Location">
                <ItemTemplate>
                    <asp:Label ID="Location" runat="server" Text='<%# Bind("Location") %>'></asp:Label>
                </ItemTemplate>
                
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Gender">
                <ItemTemplate>
                    <asp:Label ID="Gender" runat="server" Text='<%# Bind("Gender") %>'></asp:Label>
                </ItemTemplate>
                
            </asp:TemplateField>
            <asp:TemplateField HeaderText="X Percentage">
                <ItemTemplate>
                    <asp:Label ID="Percentage_10" runat="server" Text='<%# Bind("Percentage_10") %>'></asp:Label>
                </ItemTemplate>
                
            </asp:TemplateField>
            <asp:TemplateField HeaderText="XII Percentage">
                <ItemTemplate>
                    <asp:Label ID="Percentage_12" runat="server" Text='<%# Bind("Percentage_12") %>'></asp:Label>
                </ItemTemplate>
                
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Gap in education">
                <ItemTemplate>
                    <asp:Label ID="GapInEducation" runat="server" Text='<%# Bind("GapInEducation") %>'></asp:Label>
                </ItemTemplate>
               
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Gap in experience">
                <ItemTemplate>
                    <asp:Label ID="GapInExperience" runat="server" Text='<%# Bind("GapInExperience") %>'></asp:Label>
                </ItemTemplate>
                
            </asp:TemplateField>
        </Columns>
        <HeaderStyle Font-Size="Small" BackColor="#333333" ForeColor="White" />
        <PagerStyle HorizontalAlign="Center" ForeColor="White" BackColor="#333333" />
    </asp:GridView>
    
    
    </td>
    <td class="width:10%"></td>
    
    </tr>
    
    </table>

    <br />
    <br />

</asp:Content>


