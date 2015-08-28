<%@ Page Title="" Language="C#" MasterPageFile="~/TestAdmin_UnitHead.master" MaintainScrollPositionOnPostback="true" AutoEventWireup="true" CodeFile="Update_TestStatus_byTestAdminUH.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .style22
        {
            width: 31%;
            height: 26px;
        }
        .style23
        {
            height: 26px;
            width: 19px;
        }
        .style25
        {
            width: 19px;
        }
        .style26
        {
            width: 22%;
        }
        .style27
        {
            width: 31%;
        }
        .style28
        {
            width: 39px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server"><br />
    <h2><asp:Label ID="Label1" runat="server" Font-Bold="True" 
        Text="TEST STATUS AND INTERVIEW SCHEDULE"></asp:Label></h2>
 
    <br />
      <center>
    <table style="height: 26px; width: 275px; background-color: #666666;">
    <tr>
    <td style="color: #FFFFFF" class="style25" valign="middle">
        </td>
    <td style="color: #FFFFFF" class="style27" valign="middle">
        </td>
    <td class="style28" valign="middle">
        </td>
        
    
    <td valign="middle" class="style32">
        </td>
        
    
    </tr>
    <tr>
    <td style="color: #FFFFFF" class="style25" height="26px" valign="middle">
        </td>
    <td style="color: #FFFFFF" class="style22" height="26px" valign="middle">
        <strong>Vacancy ID:
    </strong>
    </td>
    <td class="style28" style="text-align: left" valign="middle" height="26px">
        &nbsp;<asp:DropDownList ID="ddl_VacancyID" runat="server" 
                   >
                </asp:DropDownList>
        </td>
        
    
    <td align="left" class="style20" valign="middle" height="26px">
                    &nbsp;</td>
        
    
    </tr>
    <tr>
    <td class="style25" valign="middle"></td>
    <td class="style27" valign="middle"></td>
    <td class="style28" valign="middle"><br /></td>
    <td valign="middle" class="style36"></td>
    </tr>
    <tr>
    <td class="style23" valign="middle"></td>
    <td colspan="2" valign="middle" class="style33"><asp:Button ID="Submit" 
            runat="server" onclick="Submit_Click" Text="Submit" ValidationGroup="submit" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
    <td valign="middle" class="style26"></td>
    </tr>
    <tr>
    <td class="style25" valign="middle"></td>
    <td class="style27" valign="middle"></td>
    <td class="style28" valign="middle"></td>
    <td valign="middle" class="style32"></td>
    </tr>
    </table>
    </center>
 <center>&nbsp;&nbsp;&nbsp;
    
     <br />
     
    </center>

    <br />
   <center>
   <table  style="background-color: #CCCCCC; height:241px" >
   <tr>
   <td></td>
   <td>
    <asp:GridView ID="gv_TestStatus" runat="server" AutoGenerateColumns="False" 
        Width="95%" 
        onrowcancelingedit="gv_TestStatus_RowCancelingEdit" onrowediting="gv_TestStatus_RowEditing" 
        onrowupdating="gv_TestStatus_RowUpdating" 
           AllowPaging="True" AllowSorting="True" ForeColor="White" Height="125px" 
           BackColor="#666666" onpageindexchanging="gv_TestStatus_PageIndexChanging">
        <Columns>
            <asp:CommandField ShowEditButton="True" />
            <asp:TemplateField HeaderText="Candidate ID">
                <EditItemTemplate>
                    <asp:Label ID="CandidateID" runat="server" color="White" Text='<%# Eval("CandidateID") %>'></asp:Label>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label4" runat="server" Text='<%# Bind("CandidateID") %>'></asp:Label>
                </ItemTemplate>
                <ItemStyle Width="60px" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Written Test Date">
                <EditItemTemplate>
                    <asp:Label ID="WrittenTestDate" runat="server" Text='<%# Eval("WrittenTestDate") %>'></asp:Label>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="WrittenTestDate" runat="server" Text='<%# Bind("WrittenTestDate") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Written Test Status">
                <EditItemTemplate>
                    <asp:DropDownList ID="WrittenTestStatus" runat="server" AutoPostBack="True" 
                        Text='<%# Bind("WrittenTestStatus") %>'>
                    <asp:ListItem>pending</asp:ListItem>
                    <asp:ListItem>cleared</asp:ListItem>
                    </asp:DropDownList>

                  
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="WrittenTestStatus" runat="server" Text='<%# Bind("WrittenTestStatus") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Technical Interview Date">
                <EditItemTemplate>
                    <asp:Label ID="TechnicalInterviewDate" runat="server" 
                        Text='<%# Eval("TechnicalInterviewDate") %>'></asp:Label>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="TechnicalInterviewDate" runat="server" 
                        Text='<%# Bind("TechnicalInterviewDate") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Technical Interview Status">
                <EditItemTemplate>
                    <asp:DropDownList ID="TechnicalInterviewStatus" runat="server" AutoPostBack="True" 
                    Text='<%# Bind("TechnicalInterviewStatus") %>'>
                    <asp:ListItem>pending</asp:ListItem>
                    <asp:ListItem>cleared</asp:ListItem>
                    </asp:DropDownList>
                  
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="TechnicalInterviewStatus" runat="server" 
                        Text='<%# Bind("TechnicalInterviewStatus") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="HR Interview Date">
                <EditItemTemplate>
                    <asp:Label ID="HRInterviewDate" runat="server" Text='<%# Eval("HRInterviewDate") %>'></asp:Label>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="HRInterviewDate" runat="server" Text='<%# Bind("HRInterviewDate") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="HR Interview Status">
                <EditItemTemplate>
                    <asp:DropDownList ID="HRInterviewStatus" runat="server" AutoPostBack="True" 
                        Text='<%# Bind("HRInterviewStatus") %>'>
                    <asp:ListItem>pending</asp:ListItem>
                    <asp:ListItem>cleared</asp:ListItem>
                    </asp:DropDownList>
                   
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="HRInterviewStatus" runat="server" Text='<%# Bind("HRInterviewStatus") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <HeaderStyle BackColor="Black" ForeColor="White" />
        <PagerStyle BackColor="Black" HorizontalAlign="Center" />
    </asp:GridView>
    </td>
    <td></td>
    </tr>
    </table>
    <br />
       <br />
       <br />
    </center>
</asp:Content>




