<%@ Page Title="Approve Vacancy" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
 CodeFile="Approve.aspx.cs" Inherits="Approve" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <script  type="text/javascript" language="javascript">
     function disableBackButton() {
         window.history.forward(1000);
     }
     setTimeout("disableBackButton()", 0); 
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <div>
<fieldset <%--style="background-image:url('images/Resized-1.jpg');"--%>>
<legend>
Approve Vacancy
</legend>


       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Error" runat="server" Text="Vancies not found" Visible="False"></asp:Label>


       <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        style="margin-left: 27px; margin-top: 21px" 
        BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" 
        CellPadding="2" ForeColor="Black" GridLines="None">
      
           <AlternatingRowStyle BackColor="PaleGoldenrod" />
      
        <Columns>
            
            <asp:TemplateField ShowHeader="False">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="false" 
                        CommandName="" Text="Accept" OnClick="Accept" OnClientClick="return confirm('Are you sure you want to approve?');"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField ShowHeader="False">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="false" 
                        CommandName="" Text="Reject" OnClick="Reject" OnClientClick="return confirm('Are you sure you want to reject?');"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="Vacancy Id">
                <EditItemTemplate>
                    <asp:Label ID="vacncyId" runat="server" Text='<%# Eval("[Vacancy Id]") %>'></asp:Label>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("[Vacancy Id]") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Number of Positions">
                <EditItemTemplate>
                    <asp:TextBox ID="noofpos" runat="server" 
                        Text='<%# Eval("[Number of Positions]") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" 
                        Text='<%# Bind("[Number of Positions]") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Required Date">
                <EditItemTemplate>
                    <asp:TextBox ID="reqdate" runat="server" Text='<%# Eval("[Required Date]") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("[Required Date]") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Skills">
                <EditItemTemplate>
                    <asp:TextBox ID="skills" runat="server" Text='<%# Eval("Skills") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label4" runat="server" Text='<%# Bind("Skills") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Domain">
                <EditItemTemplate>
                    <asp:Label ID="TextBox2" runat="server" Text='<%# Eval("Domain") %>'></asp:Label>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label5" runat="server" Text='<%# Bind("Domain") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Experience">
                <EditItemTemplate>
                    <asp:TextBox ID="experience" runat="server" Text='<%# Eval("Experience") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label6" runat="server" Text='<%# Bind("Experience") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Location">
                <EditItemTemplate>
                    <asp:TextBox ID="location" runat="server" Text='<%# Eval("Loctaion") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label7" runat="server" Text='<%# Bind("Loctaion") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Status">
                <EditItemTemplate>
                    <asp:Label ID="status" runat="server" Text='<%# Eval("Status") %>'></asp:Label>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label8" runat="server" Text='<%# Bind("Status") %>'></asp:Label>
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
    <asp:Label ID="LabelToShowMsg" runat="server" Text="Label" Visible="False"></asp:Label>
 </fieldset>
 </div>
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Cancel" />
</asp:Content>

