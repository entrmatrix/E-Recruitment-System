<%@ Page Title="Contact Us" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Contact Us.aspx.cs" Inherits="Contact_Us" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 400px;
        }
        .style2
        {
            width: 200px;
        }
        .style3
        {
            width: 145px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
<fieldset>
<legend>
Contact Us
</legend>
<div>

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

<table>
<tr>
<td>
</td>
<td class="style1">
        <table>
            <tr>
                <td class="style3">
                    <strong>Global Headquarters</strong>
                </td>
                <td class="style2">
                    TE Client Services
                </td>
            </tr>

            <tr>
                <td class="style3">
                </td>
                <td class="style2">
                    5 Polaris Way
                    <br />
                    Aliso Viejo, CA 92656
                    <br />
                    Phone: (949) 754 - 8000
                    <br />
                    Fax: (949) 754 - 8999
                    <br />
                </td>
            </tr>
    
            <tr>
                <td class="style3">
                    <strong>Email:</strong> 
                </td>
                <td class="style2">
                    info@TEClientServices.com
                </td>
            </tr>
         </table> 

</td>

<td>
<img src="images/ContactUs.jpg" alt="ContactUs" 
        style="width: 250px; height: 173px; margin-left: 68px" />
</td>

</tr>
</table>

</div>
</fieldset>
</asp:Content>

