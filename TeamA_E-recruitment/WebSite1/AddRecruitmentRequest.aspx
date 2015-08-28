<%@ Page Title="Add Recruitment Request" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="AddRecruitmentRequest.aspx.cs" Inherits="AddRecruitmentRequest" %>

<%@ Register assembly="DatePickerControl" namespace="DatePickerControl" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 509px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    
    <fieldset>
  <legend>Add Recruitment Request
  </legend>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Error" runat="server" Text="No Vacancies found"></asp:Label>
        <br />
    <div>
    <table>
        <tr>
        <td></td>
        <td></td>
        <td></td>
        <td>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" 
                CellPadding="2" ForeColor="Black" GridLines="None">
                <AlternatingRowStyle BackColor="PaleGoldenrod" />
                <Columns>
                    <asp:TemplateField>
                        <EditItemTemplate>
                            <asp:CheckBox ID="CheckBox1" runat="server" />
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:CheckBox ID="CheckBox1" runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Vacancy Id" SortExpression="Vacancy Id">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox1" runat="server" Text='<%# Eval("vacancyID") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("vacancyID") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Number of Positions" 
                        SortExpression="Number of Positions">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox2" runat="server" 
                                Text='<%# Eval("noOfPositions") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label2" runat="server" 
                                Text='<%# Eval("noOfPositions") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Skills" SortExpression="Skills">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox4" runat="server" Text='<%# Eval("skills") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label4" runat="server" Text='<%# Eval("skills") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Domain" SortExpression="Domain">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox5" runat="server" Text='<%# Bind("Domain") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label5" runat="server" Text='<%# Bind("Domain") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Experience" SortExpression="Experience">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox6" runat="server" Text='<%# Eval("experience") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label6" runat="server" Text='<%# Eval("experience") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Required Date" SortExpression="Required Date">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox3" runat="server" Text='<%# Eval("requiredDate") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label3" runat="server" Text='<%# Eval("requiredDate") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Location" SortExpression="Loctaion">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox7" runat="server" Text='<%# Eval("location") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label7" runat="server" Text='<%# Eval("location") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Status" SortExpression="Status">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox9" runat="server" Text='<%# Eval("status") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label9" runat="server" Text='<%# Eval("status") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <FooterStyle BackColor="Tan" />
                <HeaderStyle BackColor="Tan" Font-Bold="True" />
                <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" 
                    HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                <SortedAscendingCellStyle BackColor="#FAFAE7" />
                <SortedAscendingHeaderStyle BackColor="#DAC09E" />
                <SortedDescendingCellStyle BackColor="#E1DB9C" />
                <SortedDescendingHeaderStyle BackColor="#C2A47B" />
            </asp:GridView>
        </td>
        </tr>
        <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>
            <asp:Label ID="Label11" runat="server" Text="Label" Visible="False"></asp:Label>
        </td>
        </tr>
        <tr >
        <td></td>
        <td></td>
        <td></td>
        <td>

                    <table>
                    <tr>
                    
                    <td>
                        <asp:Label ID="RequiredDateLabel" runat="server" Text="RequiredDate"></asp:Label>
                    </td>

                    <td class="style1">
                        <cc1:DatePicker ID="RequiredDate" runat="server" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                            ErrorMessage="Please enter the required date" ControlToValidate="RequiredDate"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </td>

                    </tr>

                    <tr>
                    <td>
                        <asp:Label ID="PlacementConsultantLabel" runat="server" Text="PlacementConsultant">
                        </asp:Label>
                    </td>

                    <td class="style1">
                        <asp:DropDownList ID="PlacementConsultantDropDownList" runat="server" 
                            Height="25px" Width="101px">
                        <asp:ListItem>select</asp:ListItem>
                        </asp:DropDownList>

                       <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                       ErrorMessage="Please select an option from the list" 
                       ControlToValidate="PlacementConsultantDropDownList" Display="Dynamic">
                       </asp:RequiredFieldValidator>

                <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Please select an option from the list" 
                ValueToCompare="0" Operator="GreaterThan" ControlToValidate="PlacementConsultantDropDownList" Type="Integer" Display="Dynamic">
                </asp:CompareValidator>
                   </td>
                   
                   <td>
                       &nbsp;</td>
                   </tr>

                    <tr><td>
                        <br />
                        <asp:Button ID="CreateButton" runat="server" 
                        Text="Add Request" onclick="CreateButton_Click" OnClientClick="return confirm('Are you sure you want to continue?');" />
                        <asp:Label ID="Label10" runat="server" Text="Label" Visible="False"></asp:Label>
                    </td>
                    <td class="style1">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Cancel" />
                        </td>
                    </tr>
                    </table>
        </td>
        <td>
        
        </td>
        </tr>
    </table>
    </div>
    </fieldset>
</asp:Content>

