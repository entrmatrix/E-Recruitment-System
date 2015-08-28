<%@ Page Title="Edit/Delete Recruitment Request" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="EditandDeleteRecruitmentRequest.aspx.cs" Inherits="EditandDeleteRecruitmentRequest" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <fieldset>
<legend>

    Edit &amp; Delete Recruitment Request</legend>
    <div>

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;


    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            onrowdeleting="GridView1_RowDeleting1" style="margin-left: 148px; margin-top: 0px" 
        
        >
        <Columns>
            <asp:TemplateField ShowHeader="False">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="false" 
                        CommandName="" Text="Edit" OnClick ="Edit"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:CommandField ShowDeleteButton="True" />
            <asp:TemplateField HeaderText="RecruitmentRequestID" 
                SortExpression="RecruitmentRequestID">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server" 
                        Text='<%# Bind("recruitmentRequestID") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" 
                        Text='<%# Bind("recruitmentRequestID") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Required By Date" 
                SortExpression="Required By Date">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox2" runat="server" 
                        Text='<%# Bind("requiredDate") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("requiredDate") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="PlacementConsultant" 
                SortExpression="PlacementConsultant">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox3" runat="server" 
                        Text='<%# Bind("placementConsultantID") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("placementConsultantID") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
        <br />
        <br />
    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
            style="margin-left: 46px">
        <Columns>
            <asp:TemplateField>
                <EditItemTemplate>
                  <center>  <asp:CheckBox ID="CheckBox1" runat="server" /></center>
                </EditItemTemplate>
                <ItemTemplate>
                   <center> <asp:CheckBox ID="CheckBox1" runat="server" /></center>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Vacancy Id">
                <EditItemTemplate>
                    <asp:Label ID="TextBox1" runat="server" Text='<%# Eval("[Vacancy Id]") %>'></asp:Label>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("[Vacancy Id]") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Number of Positions">
                <EditItemTemplate>
                  <center>  <asp:TextBox ID="noofpos" runat="server" 
                        Text='<%# Eval("[Number of Positions]") %>'></asp:TextBox></center>
                </EditItemTemplate>
                <ItemTemplate>
                    <center><asp:Label ID="Label2" runat="server" 
                        Text='<%# Bind("[Number of Positions]") %>'></asp:Label></center>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Required Date">
                <EditItemTemplate>
                  <center> <asp:TextBox ID="reqdate" runat="server" Text='<%# Eval("[Required Date]") %>'></asp:TextBox></center>
                </EditItemTemplate>
                <ItemTemplate>
                   <center> <asp:Label ID="Label3" runat="server" Text='<%# Bind("[Required Date]") %>'></asp:Label></center>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Skills">
                <EditItemTemplate>
                  <center></center>  <asp:TextBox ID="skills" runat="server" Text='<%# Eval("Skills") %>'></asp:TextBox></center>
                </EditItemTemplate>
                <ItemTemplate>
                  <center>  <asp:Label ID="Label4" runat="server" Text='<%# Bind("Skills") %>'></asp:Label></center>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Domain">
                <EditItemTemplate>
                    <center><asp:Label ID="TextBox2" runat="server" Text='<%# Eval("Domain") %>'></asp:Label></center>
                </EditItemTemplate>
                <ItemTemplate>
                   <center> <asp:Label ID="Label5" runat="server" Text='<%# Bind("Domain") %>'></asp:Label></center>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Experience">
                <EditItemTemplate>
                    <center><asp:TextBox ID="experience" runat="server" Text='<%# Eval("Experience") %>'></asp:TextBox></center>
                </EditItemTemplate>
                <ItemTemplate>
                   <center><asp:Label ID="Label6" runat="server" Text='<%# Bind("Experience") %>'></asp:Label></center>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Location">
                <EditItemTemplate>
                    <center><asp:TextBox ID="location" runat="server" Text='<%# Eval("Loctaion") %>'></asp:TextBox></center>
                </EditItemTemplate>
                <ItemTemplate>
                    <center><asp:Label ID="Label7" runat="server" Text='<%# Bind("Loctaion") %>'></asp:Label></center>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Status">
                <EditItemTemplate>
                   <center> <asp:Label ID="status" runat="server" Text='<%# Eval("Status") %>'></asp:Label></center>
                </EditItemTemplate>
                <ItemTemplate>
                   <center> <asp:Label ID="Label8" runat="server" Text='<%# Bind("Status") %>'></asp:Label></center>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>


    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Submit" 
        Visible="False" />
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button2" runat="server" Text="Cancel" Visible="False" 
            onclick="Button2_Click" />


    </div>
</fieldset></asp:Content>

