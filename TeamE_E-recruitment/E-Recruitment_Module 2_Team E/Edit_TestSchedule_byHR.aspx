<%@ Page Title="" Language="C#" MasterPageFile="~/HR.master" MaintainScrollPositionOnPostback="true" AutoEventWireup="true" CodeFile="Edit_TestSchedule_byHR.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .style15
        {
            width: 23%;
        }
        .style16
        {
            width: 29%;
        }
        .style18
        {
            width: 19%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
   
     <center>
     <h2>TEST AND INTERVIEW SCHEDULE:</h2></center>
    <br />
    <center>
    <table style="height: 117px; width: 524px; background-color: #666666;">
    <tr>
    <td style="color: #FFFFFF" class="style18">
        &nbsp;</td>
    <td style="color: #FFFFFF" class="style15">
        &nbsp;</td>
    <td class="style15" valign="middle">
        &nbsp;</td>
        
    
    <td width="40%" valign="middle">
        &nbsp;</td>
        
    
    </tr>
    <tr>
    <td style="color: #FFFFFF" class="style18">
        </td>
    <td style="color: #FFFFFF" class="style15">
        <strong>Vacancy ID:
    </strong>
    </td>
    <td class="style15" style="text-align: left" valign="middle">
    &nbsp;&nbsp;<asp:DropDownList ID="ddlVacancyID" runat="server" style="width:80px;" 
            onselectedindexchanged="ddlVacancyID_SelectedIndexChanged" 
            AutoPostBack="True">
        </asp:DropDownList>
        </td>
        
    
    <td width="40%" align="left" class="style16" valign="middle">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ControlToValidate="ddlVacancyID" Display="Dynamic" 
                ErrorMessage="*Please select a valid choice" ForeColor="Red" 
                InitialValue="--select--" ValidationGroup="submit"></asp:RequiredFieldValidator>
        </td>
        
    
    </tr>
    <tr>
    <td class="style18">&nbsp;</td>
    <td class="style15"></td>
    <td class="style15" valign="middle"><br /></td>
    <td width="40%" valign="middle">&nbsp;</td>
    </tr>
    <tr>
    <td class="style18">&nbsp;</td>
    <td colspan="2" valign="middle">
      <asp:Button ID="btnSubmit" runat="server" Text="Search" 
          onclick="btnSubmit_Click" ValidationGroup="submit" /></td>
    <td width="40%" valign="middle">&nbsp;</td>
    </tr>
    <tr>
    <td class="style18">&nbsp;</td>
    <td class="style15">&nbsp;</td>
    <td class="style15" valign="middle">&nbsp;</td>
    <td width="40%" valign="middle">&nbsp;</td>
    </tr>
    </table>
    </center>
    <br />


        <table align="center" style="color: #FFFFFF;">
        <tr>
        <td></td>
        <td>
  <center>
      &nbsp;&nbsp;&nbsp; </center>  
            <table style="width:100%;">
                <tr>
                    <td>
                        <asp:Label ID="lbWritten" runat="server" 
                            Text="Written test date is successfully updated" Visible="False" 
                            ForeColor="Black"></asp:Label></td>
                             </tr>
                  <tr>  <td>
                        <asp:Label ID="lbTechnical" runat="server" 
                            Text="Technical interview date is successfully updated" Visible="False" 
                            ForeColor="Black"></asp:Label></td> </tr>
                   <tr>  <td>
                        <asp:Label ID="lbHR" runat="server" 
                            Text="HR interview date is successfully updated" Visible="False" 
                            ForeColor="Black"></asp:Label></td>
                </tr>
                
            </table>
    <br />
    <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" 
        Width="89%" onrowcancelingedit="gv_RowCancelingEdit" 
        onrowediting="gv_RowEditing" onrowupdating="gv_RowUpdating" AllowPaging="True" 
                AllowSorting="True" EmptyDataText="No data in the system to display." 
                HorizontalAlign="Center" ForeColor="White" BackColor="#666666" 
                OnPageIndexChanging="gv_PageIndexChanging">
        <Columns>
            <asp:CommandField ShowEditButton="True" >
            <ItemStyle ForeColor="White" />
            </asp:CommandField>
            <asp:TemplateField HeaderText="Candidate ID">
                <EditItemTemplate>
                    <asp:Label ID="CandidateID" runat="server" Text='<%# Eval("CandidateID") %>'></asp:Label>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="CandidateID" runat="server" Text='<%# Bind("CandidateID") %>'></asp:Label>
                </ItemTemplate>
                <ItemStyle Width="60px" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Written Test Date">
                <EditItemTemplate>
                    <asp:TextBox ID="WrittenTestDate" runat="server" Text='<%# Eval("WrittenTestDate") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("WrittenTestDate") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Written Test Status">
                <EditItemTemplate>
                    <asp:Label ID="WrittenTestStatus" runat="server" Text='<%# Eval("WrittenTestStatus") %>'></asp:Label>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label4" runat="server" Text='<%# Bind("WrittenTestStatus") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Technical Interview Date">
                <EditItemTemplate>
                    <asp:TextBox ID="TechnicalInterviewDate" runat="server" 
                        Text='<%# Eval("TechnicalInterviewDate") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" 
                        Text='<%# Bind("TechnicalInterviewDate") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Technical Interview Status">
                <EditItemTemplate>
                    <asp:Label ID="TechnicalInterviewStatus" runat="server" 
                        Text='<%# Eval("TechnicalInterviewStatus") %>'></asp:Label>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label5" runat="server" 
                        Text='<%# Bind("TechnicalInterviewStatus") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="HR Interview Date">
                <EditItemTemplate>
                    <asp:TextBox ID="HRInterviewDate" runat="server" Text='<%# Eval("HRInterviewDate") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("HRInterviewDate") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="HR Interview Status">
                <EditItemTemplate>
                    <asp:Label ID="HRInterviewStatus" runat="server" Text='<%# Eval("HRInterviewStatus") %>'></asp:Label>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label6" runat="server" Text='<%# Bind("HRInterviewStatus") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <HeaderStyle Font-Size="Small" BackColor="#333333" ForeColor="White" />
        <PagerStyle BackColor="#333333" ForeColor="White" HorizontalAlign="Center" />
    </asp:GridView>
    </td>
    <td></td>
    </tr>
   </table>
    <br />
    </asp:Content>


