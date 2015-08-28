
<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="HomePage.aspx.cs" Inherits="HomePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
<div style="width: 979px; height: 25px;">
                    &nbsp;&nbsp; <b>&nbsp;&nbsp; Welcome</b>
                    <asp:Label 
                ID="employeeNameLabel" runat="server" Text="Employee Name" Font-Italic="true"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;<b>EmployeeID</b>&nbsp;&nbsp;<asp:Label 
                ID="employeeIDLabel" runat="server" Text="Employee ID" Font-Italic="true"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<b>Designation</b>&nbsp;<asp:Label ID="designationLabel" runat="server" 
                Text="Employee Designation" Font-Italic="true"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <b>Time</b>
                    <asp:Label 
                ID="timelb" runat="server" Text="Time" Font-Italic="true"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
                </div>
                <fieldset>
                <legend><b><h3>TE-Client Services</h3></b> </legend>
        <div>
        <table id="1" style="margin-left: 7px">
        <tr>
        <td>
            <table id="2">
                <tr>
                    <td>
                        The internet, which reaches a large number of people and can get immediate feedback has become the major source of potential job candidates and well known as online recruitment or E-recruitment. TE Client Services are primarily centered around talent acquisition. These capabilities combine to provide what TE Client Services calls “Talent Intelligence,” or an enhanced level of insight into candidates and employees.
                        This is a portal for the online exchange of employment related information. Any information you submit to us will be published and available for access and further processing by the other users of our portal. We do not promise any confidentiality or privacy restrictions and you should have no expectation of privacy with respect to data you share via our portal.
                        In July 2010, TE Client Services introduced a unified approach to talent data called Talent Intelligence, which gives HR managers up-to-date insights into candidates, best practices and industry-level benchmarks. According to TE Client Services, these insights better equip organizations to recruit and mobilize the best talent, while helping managers identify, develop and compensate top performers.
                        <br />
                        <br />
                        We believe that achieving Talent Intelligence requires:
                    </td>
                </tr>
             
                <tr>
                    <td>
                        <ul>
                            <li>Embedding analytics across the spectrum of Talent Management capabilities</li>
                            <li>Giving the experience and skills knowledge a priority in filling out a vacancy</li>
                            <li>Genuine check of the details available in our portal</li>
                            <li>Fulfilling the vendor needs in a qualitative manner</li>
                        </ul>
                    </td>
                </tr>
            </table>
        </td>
        </tr>
        <tr>
            <td>
                <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; We act like a bridge between recruits and recruiters</strong>
            </td>
            <td>
                &nbsp;</td>
        </tr>
            
        </table>
        </div>

</fieldset>
</asp:Content>

