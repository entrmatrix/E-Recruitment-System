<%@ Page Title="" Language="C#" MasterPageFile="~/HR.master"  MaintainScrollPositionOnPostback="true" AutoEventWireup="true" CodeFile="Delete_TestAdmin_byHR.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">

    <center>
        <h2 style="text-align:center"> <strong>Available Test Administrators</strong> </h2>
  
    <table style=" width:100% ;color: #FFFFFF;">
    <tr>
    <td width="10%"></td>
    <td width="80%">
    <br />
        <asp:GridView ID="gv_testadmin" runat="server" AutoGenerateColumns="False" 
            onrowdeleting="gv_testadmin_RowDeleting" AllowPaging="True" 
            AllowSorting="True" style="margin-left: 0px" Width="712px" 
            BackColor="#666666" onpageindexchanging="gv_testadmin_PageIndexChanging">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" >
                <ItemStyle ForeColor="White" />
                </asp:CommandField>
                <asp:TemplateField HeaderText="Employee ID">
                    <EditItemTemplate>
                        <asp:Label ID="EmployeeID" runat="server" Text='<%# Eval("EmployeeID") %>'></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="EmployeeID" runat="server" Text='<%# Bind("EmployeeID") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="EmployeeName" HeaderText="Employee Name" />
                <asp:BoundField DataField="Designation" HeaderText="Designation" />
                <asp:BoundField DataField="Location" HeaderText="Location" />
                <asp:BoundField DataField="Experience" HeaderText="Experience" />
            </Columns>
            <FooterStyle ForeColor="White" />
            <HeaderStyle BackColor="Black" />
            <PagerStyle BackColor="Black" HorizontalAlign="Center" ForeColor="White" />
        </asp:GridView>
        </td>
        <td width="10%"></td>
        </tr>
        </table>
 
    </center>
    <br />
    <br />


</asp:Content>
