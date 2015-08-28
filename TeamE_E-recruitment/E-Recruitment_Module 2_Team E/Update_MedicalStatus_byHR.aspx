<%@ Page Title="" Language="C#" MasterPageFile="~/HR.master" MaintainScrollPositionOnPostback="true" AutoEventWireup="true" CodeFile="Update_MedicalStatus_byHR.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">

    <style type="text/css">
        .style1
        {
            width: 225px;
        }
        .style2
        {
            width: 226px;
            text-align: right;
        }
        .style8
        {
            width: 226px;
            text-align: right;
            height: 52px;
        }
        .style9
        {
            width: 197px;
            height: 52px;
        }
        .style10
        {
            height: 52px;
            width: 93px;
        }
        .style11
        {
            width: 93px;
        }
        .style15
        {
            width: 265px;
            text-align: right;
            height: 34px;
        }
        .style16
        {
            width: 94px;
            height: 34px;
            text-align: left;
        }
        .style17
        {
            height: 34px;
            width: 262px;
        }
       
        .style22
        {
            width: 265px;
            text-align: right;
            height: 31px;
        }
        .style23
        {
            width: 94px;
            height: 31px;
            text-align: left;
        }
        .style24
        {
            height: 31px;
            width: 262px;
            text-align: left;
        }
        .style25
        {
            width: 108px;
            text-align: left;
            height: 34px;
        }
        .style26
        {
            width: 108px;
            text-align: left;
            height: 31px;
        }
        .style27
        {
            width: 108px;
            text-align: left;
            height: 32px;
        }
         .style18
        {
            width: 226px;
            text-align: right;
            height: 32px;
        }
        .style20
        {
            width: 171px;
            height: 32px;
        }
        .style21
        {
            width: 94px;
            height: 32px;
            text-align: left;
        }
        .style28
        {
            width: 265px;
            text-align: right;
            height: 12px;
        }
        .style29
        {
            width: 108px;
            text-align: left;
            height: 12px;
        }
        .style30
        {
            width: 94px;
            height: 12px;
            text-align: left;
        }
        .style31
        {
            height: 12px;
            width: 262px;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server"><br />
    <center> <h2 style="text-align:center">  
        MEDICAL STATUS PROFILE </h2> 
        </center>
        &nbsp;&nbsp;
        <table style="width: 68%; color: #FFFFFF; background-color: #666666;" 
        align="center">
           
            <tr>
                <td class="style18" height="26px">
                   
                  
                   
                    &nbsp;</td>
                <td class="style27" height="26px">
                   
                  
                   
                    <asp:Label ID="lbVacancyID" runat="server" Font-Bold="True" Font-Size="Small" 
                        Text="Vacancy ID"></asp:Label>
                    :</td>
                <td class="style21" height="26px">
                   <asp:DropDownList ID="ddlVacancyID" runat="server" 
                        AutoPostBack="True" 
                        onselectedindexchanged="ddlVacancyID_SelectedIndexChanged">
                    </asp:DropDownList>
                
                    </td><td class="style20" width="40%" height="26px"> 
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ControlToValidate="ddlVacancyID" Display="Dynamic" InitialValue="--select--"
                        ErrorMessage="*Please choose a valid choice" ValidationGroup="submit" 
                        ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
                
            </tr>
            <tr>
                <td class="style28" height="26px">
                   
                    </td>
                <td class="style29" height="26px">
                   
                    </td>
                <td class="style30" height="26px">
                    
                </td>
                <td class="style31" width="40%" height="26px"> 
                </td>
            </tr>
            <tr>
                <td class="style15" height="26px">
                   
                    &nbsp;</td>
               
                <td colspan="2" valign="middle" >
                    
        <asp:Button ID="btnSubmit" runat="server" Text="Search" onclick="btnSubmit_Click" 
            ValidationGroup="submit" />
                
                </td>
                <td class="style17" width="40%" height="26px">  
                </td>
            </tr>
          </table>
    <center >
        <br />
        </center>
    <br />
    <br />
    <center>
   <table id="tab_1" runat="server" style=" width:100%">
    <tr>
    <td width="10%"></td>
    <td width="80%">
    <asp:GridView ID="gv_UpdateMedicalStatus" runat="server" AutoGenerateColumns="False" 
        HorizontalAlign="Center" 
        onrowcancelingedit="gv_UpdateMedicalStatus_RowCancelingEdit" 
        onrowediting="gv_UpdateMedicalStatus_RowEditing" onrowupdating="gv_UpdateMedicalStatus_RowUpdating" 
       
        AllowSorting="True" EmptyDataText="No data in the system to display" 
        Font-Bold="False" AllowPaging="True" ForeColor="White" 
            Width="741px" BackColor="#666666" 
            onpageindexchanging="gv_UpdateMedicalStatus_PageIndexChanging">
        <Columns>
            <asp:CommandField ShowEditButton="True" />
            <asp:TemplateField HeaderText="Candidate ID">
                <EditItemTemplate>
                    <asp:Label ID="lbCandidateID" runat="server" Text='<%# Eval("CandidateID") %>'></asp:Label>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lbCandidateID" runat="server" Text='<%# Bind("CandidateID") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Test Status">
                <EditItemTemplate>
                    <asp:Label ID="lbTestStatus" runat="server" Text='<%# Eval("TestStatus") %>'></asp:Label>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lbTestStatus" runat="server" Text='<%# Bind("TestStatus") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField  HeaderText="Medical Test Status">
                <EditItemTemplate>
           <asp:DropDownList ID="ddlMedicalStatus"   runat="server" Width="80px" AutoPostBack="false">
           
            <asp:ListItem>cleared</asp:ListItem>
             <asp:ListItem>rejected</asp:ListItem>
                    </asp:DropDownList>
                </EditItemTemplate>

                <ItemTemplate>
                 <asp:Label ID="lbMedicalTestStatus" runat="server" Text='<%# Bind("MedicalTestStatus") %>'></asp:Label>
                 </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <HeaderStyle BackColor="Black" />
        <PagerStyle BackColor="Black" HorizontalAlign="Center" />
    </asp:GridView>
    </td>
     <td width="10%"></td>
    </tr>
    </table>
    </center>
    <br />
    <br />
    </asp:Content>
    
