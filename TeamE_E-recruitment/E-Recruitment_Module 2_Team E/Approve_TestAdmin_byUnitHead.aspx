<%@ Page Title="" Language="C#" MasterPageFile="~/UnitHead.master" MaintainScrollPositionOnPostback="true" AutoEventWireup="true" CodeFile="Approve_TestAdmin_byUnitHead.aspx.cs" Inherits="Default2" %>


<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .style15
        {
            width: 10%;
            height: 289px;
        }
        .style16
        {
            width: 80%;
            height: 289px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
<br />
        <h2 style="text-align:center"> <strong>Approve Test Administrators</strong> </h2>
    <center>
    <br />
    <table style=" color: #FFFFFF;">
    <tr>
  <td></td>
    <td >
            <asp:GridView ID="gv_testadmin" runat="server" AutoGenerateColumns="False" 
                onselectedindexchanged="gv_testadmin_SelectedIndexChanged1" 
                onrowdeleting="gv_testadmin_RowDeleting" Height="36px" Width="572px" 
            AllowPaging="True" AllowSorting="True" 
            onpageindexchanging="gv_testadmin_PageIndexChanging" 
            EmptyDataText="No employee is available for approval " BackColor="#666666" 
            BorderColor="#666666">
                <Columns>
                    <asp:CommandField SelectText="Approve" ShowSelectButton="True" >
                     <ItemStyle ForeColor="White" />
                    </asp:CommandField>
                     <asp:CommandField DeleteText="Reject" ShowDeleteButton="True" >
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
                <HeaderStyle BackColor="#333333" Font-Size="Small" />
                <PagerStyle BackColor="#333333" ForeColor="White" HorizontalAlign="Center" />
            </asp:GridView>
              <br /><br />
            </td>
            <td ></td>
            </tr>
          </table>
                     
    </center>
</asp:Content>
