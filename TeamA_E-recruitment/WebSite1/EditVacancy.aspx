<%@ Page Title="Edit Vacancy" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="EditVacancy.aspx.cs" Inherits="EditVacancyRequest" %>

<%@ Register Assembly="DatePickerControl" Namespace="DatePickerControl" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <div style="width: 886px; margin-left: 38px">
    <fieldset>
    <legend>
    
Edit Vacancy    
    </legend>
    
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Error" runat="server" Text="No Vacancies found" Visible="False"></asp:Label>
    
    
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        onrowcancelingedit="GridView1_RowCancelingEdit" 
        onrowediting="GridView1_RowEditing" onrowupdating="GridView1_RowUpdating" 
        onselectedindexchanged="GridView1_SelectedIndexChanged" 
            style="margin-left: 27px" BackColor="LightGoldenrodYellow" 
            BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" 
            GridLines="None">
        <AlternatingRowStyle BackColor="PaleGoldenrod" />
        <Columns>
            <asp:TemplateField ShowHeader="False">
                <EditItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True" 
                        CommandName="Update" Text="Update"  OnClientClick="return confirm('Are you sure you want to update?');" 
></asp:LinkButton>
                    &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" 
                        CommandName="Cancel" Text="Cancel"  OnClientClick="return confirm('Are you sure you want to cancel updation?');" 
></asp:LinkButton>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton3" runat="server" CausesValidation="False" 
                        CommandName="Edit" Text="Edit"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Vacancy Id">
                <EditItemTemplate>
                   <center> <asp:Label ID="TextBox1" runat="server" Text='<%# Eval("[Vacancy Id]") %>'></asp:Label></center>
                </EditItemTemplate>
                <ItemTemplate>
                    <center><asp:Label ID="Label1" runat="server" Text='<%# Bind("[Vacancy Id]") %>'></asp:Label></center>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Number of Positions">
                <EditItemTemplate>
                    <center><asp:TextBox ID="noofpos" runat="server" 
                        Text='<%# Eval("[Number of Positions]") %>' MaxLength="4" Width="20"></asp:TextBox></center>
                </EditItemTemplate>
                <ItemTemplate>
                    <center><asp:Label ID="Label2" runat="server" 
                        Text='<%# Bind("[Number of Positions]") %>'></asp:Label></center>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Required Date">
                <EditItemTemplate>
                    <center><asp:TextBox ID="reqdate" runat="server" Text='<%# Eval("[Required Date]") %>' 
                    MaxLength="10" Width="63"></asp:TextBox></center>
                   
                </EditItemTemplate>
                <ItemTemplate>
                    <center><asp:Label ID="Label3" runat="server" Text='<%# Bind("[Required Date]") %>'></asp:Label></center>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Skills">
                <EditItemTemplate>
                    <center><asp:TextBox ID="skills" runat="server" Text='<%# Eval("Skills") %>' MaxLength="15" Width="100"></asp:TextBox></center>
                </EditItemTemplate>
                <ItemTemplate>
                    <center><asp:Label ID="Label4" runat="server" Text='<%# Bind("Skills") %>'></asp:Label></center>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Domain">
                <EditItemTemplate>
                    <center><asp:Label ID="TextBox2" runat="server" Text='<%# Eval("Domain") %>'></asp:Label></center>
                </EditItemTemplate>
                <ItemTemplate>
                    <center><asp:Label ID="Label5" runat="server" Text='<%# Bind("Domain") %>'></asp:Label></center>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Experience">
                <EditItemTemplate>
                    <center><asp:TextBox ID="experience" runat="server" MaxLength="2" Width="20" Text='<%# Eval("Experience") %>'></asp:TextBox></center>
                </EditItemTemplate>
                <ItemTemplate>
                    <center><asp:Label ID="Label6" runat="server" Text='<%# Bind("Experience") %>'></asp:Label></center>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Location">
                <EditItemTemplate>
                    <center><asp:TextBox ID="location" runat="server" MaxLength="15" Width="100" Text='<%# Eval("Loctaion") %>'></asp:TextBox></center>
                </EditItemTemplate>
                <ItemTemplate>
                   <center><asp:Label ID="Label7" runat="server" Text='<%# Bind("Loctaion") %>'></asp:Label></center>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Status">
                <EditItemTemplate>
                    <center><asp:Label ID="status" runat="server" Text='<%# Eval("Status") %>'></asp:Label></center>
                </EditItemTemplate>
                <ItemTemplate>
                    <center><asp:Label ID="Label8" runat="server" Text='<%# Bind("Status") %>'></asp:Label></center>
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
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label9" runat="server" Text="No vacancies found" Visible="False"></asp:Label>
    </fieldset>
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
        style="margin-bottom: 0px" Text="Cancel" />
    <br />
    </div>
</asp:Content>

