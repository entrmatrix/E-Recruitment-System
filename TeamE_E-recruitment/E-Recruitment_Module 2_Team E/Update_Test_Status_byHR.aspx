<%@ Page Title="" Language="C#" MasterPageFile="~/HR.master" MaintainScrollPositionOnPostback="true" AutoEventWireup="true" CodeFile="Update_Test_Status_byHR.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .style16
        {
            height: 14px;
            width: 427px;
        }
        .style18
        {
            height: 14px;
            width: 12%;
        }
        .style22
        {
            height: 14px;
            width: 39%;
        }
        .style23
        {
            width: 12%;
            height: 18px;
        }
        .style25
        {
            width: 427px;
            height: 9px;
        }
        .style26
        {
            width: 37%;
            height: 18px;
        }
        .style29
        {
            width: 427px;
            height: 13px;
        }
        .style30
        {
            height: 13px;
            width: 12%;
        }
        .style32
        {
            height: 13px;
            width: 37%;
        }
        .style33
        {
            height: 18px;
        }
        .style34
        {
            height: 9px;
            width: 12%;
        }
        .style36
        {
            height: 9px;
            width: 37%;
        }
        .style37
        {
            height: 13px;
            width: 39%;
        }
        .style38
        {
            height: 9px;
            width: 39%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <h2><asp:Label ID="Label1" runat="server" Font-Bold="True" 
        Text="TEST STATUS AND INTERVIEW SCHEDULE"></asp:Label></h2><br />


        <center>
    <table style="height: 26px; width: 613px; background-color: #666666;">
    <tr>
    <td style="color: #FFFFFF" class="style30" valign="middle">
        </td>
    <td style="color: #FFFFFF" class="style37" valign="middle">
        </td>
    <td class="style29" valign="middle">
        </td>
        
    
    <td valign="middle" class="style32">
        </td>
        
    
    </tr>
    <tr>
    <td style="color: #FFFFFF" class="style18" height="26px" valign="middle">
        </td>
    <td style="color: #FFFFFF" class="style22" height="26px" valign="middle">
        <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Vacancy ID:
    </strong>
    </td>
    <td class="style16" style="text-align: left" valign="middle" height="26px" colspan="2">
        &nbsp;<asp:DropDownList ID="ddlVacancyID" runat="server" AutoPostBack="True" onselectedindexchanged="ddlVacancyID_SelectedIndexChanged" 
                   >
                </asp:DropDownList>
                &nbsp;&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"  
            ControlToValidate="ddlVacancyID" ErrorMessage="*Please select VacancyID" 
            ForeColor="Red" InitialValue="--select--" ValidationGroup="submit"></asp:RequiredFieldValidator>
        </td>
        
    
    
        
    
    </tr>
    <tr>
    <td class="style34" valign="middle"></td>
    <td class="style38" valign="middle"></td>
    <td class="style25" valign="middle"><br /></td>
    <td valign="middle" class="style36"></td>
    </tr>
    <tr>
    <td class="style23" valign="middle"></td>
    <td colspan="2" valign="middle" class="style33">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="Submit" 
            runat="server" onclick="Submit_Click" Text="Submit" ValidationGroup="submit" />
            &nbsp;&nbsp;</td>
    <td valign="middle" class="style26"></td>
    </tr>
    <tr>
    <td class="style30" valign="middle"></td>
    <td class="style37" valign="middle"></td>
    <td class="style29" valign="middle"></td>
    <td valign="middle" class="style32"></td>
    </tr>
    </table>
    </center>
 <center>&nbsp;&nbsp;&nbsp;
    
     <br />
     
    </center>





    <br />
     
    <table style=" color: #FFFFFF; height: 254px;">
    <tr>
    <td ></td>
    <td>
    <asp:GridView ID="gv_TestStatus" runat="server" AutoGenerateColumns="False" 
        Width="100%" onrowcancelingedit="gv_TestStatus_RowCancelingEdit" 
        onrowupdating="gv_TestStatus_RowUpdating" 
            onrowediting="gv_TestStatus_RowEditing" AllowPaging="True" 
            ForeColor="White" BackColor="#666666" Height="216px" 
            onpageindexchanging="gv_TestStatus_PageIndexChanging">
        <Columns>
            <asp:CommandField ShowEditButton="True" />
            <asp:TemplateField HeaderText="Candidate ID">
                <EditItemTemplate>
                    <asp:Label ID="lbCandidateID" runat="server" Text='<%# Eval("CandidateID") %>'></asp:Label>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("CandidateID") %>'></asp:Label>
                </ItemTemplate>
                <ItemStyle Width="60px" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Written Test Date">
                <EditItemTemplate>
                    <asp:Label ID="lbWrittenTestDate" runat="server" Text='<%# Eval("WrittenTestDate") %>'></asp:Label>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("WrittenTestDate") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Written Test Status">
                <EditItemTemplate>
                 <asp:DropDownList ID="ddlWrittenTestStatus" runat="server" AutoPostBack="True" 
                         Text='<%# Bind("WrittenTestStatus") %>'>
                    <asp:ListItem>pending</asp:ListItem>
                    <asp:ListItem>cleared</asp:ListItem>
                    </asp:DropDownList>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lbWrittenTestStatus" runat="server" Text='<%# Bind("WrittenTestStatus") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Technical Interview Date">
                <EditItemTemplate>
                    <asp:Label ID="lbTechnicalInterviewDate" runat="server" 
                        Text='<%# Eval("TechnicalInterviewDate") %>'></asp:Label>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label4" runat="server" 
                        Text='<%# Bind("TechnicalInterviewDate") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Technical Interview Status">
                <EditItemTemplate>
                
                    <asp:DropDownList ID="ddlTechnicalInterviewStatus" runat="server" 
                        AutoPostBack="True" 
                      Text='<%# Bind("TechnicalInterviewStatus") %>'>
                    <asp:ListItem>pending</asp:ListItem>
                    <asp:ListItem>cleared</asp:ListItem>
                    </asp:DropDownList>
                   
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lbTechnicalInterviewStatus" runat="server" 
                        Text='<%# Bind("TechnicalInterviewStatus") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="HR Interview Date">
                <EditItemTemplate>
                    <asp:Label ID="lbHRInterviewDate" runat="server" Text='<%# Eval("HRInterviewDate") %>'></asp:Label>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label6" runat="server" Text='<%# Bind("HRInterviewDate") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="HR Interview Status">
                <EditItemTemplate>
                    <asp:DropDownList ID="ddlHRInterviewStatus" runat="server" AutoPostBack="True" 
                       Text='<%# Bind("HRInterviewStatus") %>'>
                    <asp:ListItem>pending</asp:ListItem>
                    <asp:ListItem>cleared</asp:ListItem>
                    </asp:DropDownList>
                    
                    
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lbHRInterviewStatus" runat="server" Text='<%# Bind("HRInterviewStatus") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <HeaderStyle BackColor="Black" />
        <PagerStyle BackColor="Black" HorizontalAlign="Center" />
    </asp:GridView>
    </td>
    <td></td>
    </tr>
    </table>
    <br />
    </center>
</asp:Content>
