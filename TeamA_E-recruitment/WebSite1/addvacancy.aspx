<%@ Page Title="Add Vacancy" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="addvacancy.aspx.cs" Inherits="_vacancy" %>
<%@ Register assembly="DatePickerControl" namespace="DatePickerControl" tagprefix="cc1" %>
<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">

    <style type="text/css">
        .style1
        {
            width: 156px;
        }
        .style2
        {
            width: 167px;
        }
    </style>

</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">

    <fieldset style="width: 875px; margin-left: 22px">
<legend>Add Vacancy</legend>
<div style="height: 301px">

    <table style="width: 100%;">
        <tr>
            <td class="style1">
                &nbsp;
                <asp:Label ID="vacnoid" runat="server" Text="Vacancy Number"></asp:Label>
            </td>
            <td class="style2">
                <asp:DropDownList ID="DropDownList1" runat="server" AppendDataBoundItems="True" 
                    AutoPostBack="True" 
                    onselectedindexchanged="DropDownList1_SelectedIndexChanged">
                    <asp:ListItem Value="0">-select-</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="DropDownList1" Display="Dynamic" 
                    ErrorMessage="Please select an option" InitialValue="0" ValidationGroup="submit"></asp:RequiredFieldValidator>

                <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Please select an option" ValueToCompare="0" Operator="GreaterThan" ControlToValidate="DropDownList1" Type="Integer" Display="Dynamic">
                </asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;
                <asp:Label ID="poslb" runat="server" Text="No of Positions"></asp:Label>
            </td>
            <td class="style2">
                <asp:TextBox ID="postxt" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="postxt" Display="Dynamic" 
                    ErrorMessage="Please enter the number of vacancies" SetFocusOnError="True" 
                    ValidationGroup="submit"></asp:RequiredFieldValidator>

                <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server"
                ErrorMessage="Please enter only numbers" 
                Display="Dynamic" ControlToValidate="postxt" ValidationExpression="^[0-9]*$" ValidationGroup="submit"></asp:RegularExpressionValidator>

            </td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;
                <asp:Label ID="RBDlb" runat="server" Text="Required by Date"></asp:Label>
            </td>
            <td class="style2">
                <cc1:DatePicker ID="DatePicker1" runat="server" />
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="DatePicker1" Display="Dynamic" 
                    ErrorMessage="Select the date"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;
                <asp:Label ID="skilllb" runat="server" Text="Skills"></asp:Label>
            </td>
            <td class="style2">
                <asp:TextBox ID="skilltb" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                    ControlToValidate="skilltb" Display="Dynamic" 
                    ErrorMessage="Please enter skills" ValidationGroup="submit"></asp:RequiredFieldValidator>
                
                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server"
                ErrorMessage="Please enter only alphabets" 
                Display="Dynamic" ControlToValidate="skilltb" ValidationExpression="^[a-zA-Z\s]*$" ValidationGroup="submit"></asp:RegularExpressionValidator>

            </td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;
                <asp:Label ID="domld" runat="server" Text="Domain"></asp:Label>
            </td>
            <td class="style2">
                <asp:Label ID="domlable" runat="server" Text="Label" Visible="False"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;
                <asp:Label ID="lbexpi" runat="server" Text="Experience"></asp:Label>
            </td>
            <td class="style2">
                <asp:TextBox ID="extb" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                    ControlToValidate="extb" Display="Dynamic" ErrorMessage="Please enter experience" 
                    ValidationGroup="submit"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server"
                ErrorMessage="Please enter only numbers" 
                Display="Dynamic" ControlToValidate="extb" ValidationExpression="^[0-9]*$" ValidationGroup="submit"></asp:RegularExpressionValidator>

            </td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;
                <asp:Label ID="loclb" runat="server" Text="Location"></asp:Label>
            </td>
            <td class="style2">
                <asp:TextBox ID="loctb" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                    ControlToValidate="loctb" Display="Dynamic" 
                    ErrorMessage="Please enter location" ValidationGroup="submit"></asp:RequiredFieldValidator>

                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
                ErrorMessage="Please enter only alphabets" 
                Display="Dynamic" ControlToValidate="loctb" ValidationExpression="^[a-zA-Z]*$" ValidationGroup="submit"></asp:RegularExpressionValidator>


            </td>
        </tr>
    </table>
&nbsp;
    <asp:Button ID="Submit" runat="server" EnableTheming="False" 
        EnableViewState="False" onclick="Button1_Click" 
        style="margin-left: 122px; margin-top: 34px" Text="Submit" 
        ValidationGroup="submit"  />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" Height="25px" onclick="Button1_Click1" 
        Text="Cancel" OnClientClick="return confirm('Are you sure you want to cancel?');" />
    <br />
    <br />
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="True" 
        Font-Size="Medium" Text="Label" Visible="False"></asp:Label>
    &nbsp;&nbsp;
    <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Italic="True" 
        Font-Size="Medium" Text="Label" Visible="False"></asp:Label>
    <br />
    <br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </div>
        </fieldset>
</asp:Content>
