<%@ Page Title="" Language="C#" MasterPageFile="~/HR.master" MaintainScrollPositionOnPostback="true"  AutoEventWireup="true" CodeFile="Display_TestAdmin_toHR.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .style1
        {
            text-decoration: underline;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">


    <center>
     <h2>Available Test Administrators</h2>
     <br />
    <table align="center"  style=" color: #FFFFFF;width:100%">
    <tr>
    <td width="10%"></td>
    <td width="80%">
        <asp:GridView ID="gv_testadmin" class="gridview" runat="server" 
            AutoGenerateColumns="False" AllowPaging="True" AllowSorting="True" 
            Width="785px" onpageindexchanging="gv_testadmin_PageIndexChanging" 
         >
            <Columns>
                <asp:BoundField DataField="EmployeeID" HeaderText="Employee ID" />
                <asp:BoundField DataField="EmployeeName" HeaderText="Employee Name" />
                <asp:BoundField DataField="Location" HeaderText="Location" />
                <asp:BoundField DataField="Experience" HeaderText="Experience" />
            </Columns>
            <FooterStyle ForeColor="White" HorizontalAlign="Center" />
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
