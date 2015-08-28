<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" xml:lang="en" lang="en">
<head>
<meta http-equiv="Content-Type" content="text/html;charset=iso-8859-1" />
<title>E-Recruitment</title>
<link type="text/css" rel="stylesheet" href="Styles/login.css"/>
    <style type="text/css">
        .style1
        {
            width: 504px;
            height: 284px;
        }
        .style2
        {
            width: 176px;
            height: 68px;
        }
        .style3
        {
            width: 48%;
        }
        .style6
        {
            width: 40%;
        }
        </style>
</head>
<body>
	<form id="form1" runat="server">
	<div id="wrapper" >
		   <div id="header">
		   <div id="top">
                <div id="logo">		   	 
 		            &nbsp;&nbsp;&nbsp;&nbsp;		   	 
 		            <img alt="Oops logo cannot be displayed" class="style2" src="Images/login_Logo.JPG" /></div>
			    <div id="menu"  >

					<ul style="float:right">
                        <li> <a href="Login.aspx">&nbsp;Login</a></li>
                        <li><a  href="aboutus.aspx">About Us</a></li>
                         <li><a href="contactus.aspx">Contact Us</a><center>
&nbsp;&nbsp;&nbsp;
                             <br />
&nbsp;&nbsp;&nbsp;&nbsp;
                             <asp:Label ID="Label2" runat="server" Text="Date Time"></asp:Label>
                             </center>
                        </li>
                       </ul>
		           
		        </div>			
		    </div>
             
			</div>
			<div id="main" style="float:left" >

                <table  id="Table1" runat="server" style="background-color:Black; width: 100%">
                    <tr>
                        <td colspan="2" align="justify" class="style3">
                            <img alt="Oops image cannot be displayed" class="style1" src="Images/home.gif" /></td>
                        <td class="style6">
                            <center>
                                <table id="Table2" border="0" runat="server" 
                                    style="border-style: none; background-color:#597272">
                                    <tr>
                                        <td align="left" 
                                            style="border-color: #597272; padding: 0px; margin: 0px; background-color: #597272; border-collapse: collapse;">
                                            &nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td align="left" 
                                            style="border-color: #597272; padding: 0px; margin: 0px; background-color: #597272; border-collapse: collapse;">
                                            &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label1" runat="server" Text="Log In" ForeColor="White" Font-Size="Medium" Font-Bold="true"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                    <td style="padding: 0px; margin: 0px; border: thick hidden #597272; background-color: #597272; border-collapse: collapse;"></td>
                                    </tr>
                                    <tr>
                                        <td align="left" 
                                            style="border-color: #597272; padding: 0px; margin: 0px; background-color: #597272; border-collapse: collapse;">
                                            &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblUsername" runat="server" Text="User ID" ForeColor="White" Font-Size="Small" Font-Bold="true" ControlToValidate="lblUsername"></asp:Label>
                                            </td>
                                    </tr>
                                    <tr>
                                        <td style="border-color: #597272; padding: 0px; margin: 0px; background-color: #597272; border-collapse: collapse;">
                                            &nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox 
                                                ID="user_id" runat="server" Width="200px" 
                                                BackColor="#CCCCCC" MaxLength="7"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="left" 
                                            style="border-color: #597272; padding: 0px; margin: 0px; background-color: #597272; border-collapse: collapse;">
                                            &nbsp;&nbsp;
                                            &nbsp;<asp:Label ID="lblPassword" runat="server" Text="Password" ForeColor="White" Font-Size="Small" Font-Bold="true"></asp:Label>
                                            </td>
                                    </tr>
                                    <tr>
                                        <td style="border-color: #597272; padding: 0px; margin: 0px; background-color: #597272; border-collapse: collapse;">
                                            &nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="password" runat="server" 
                                                TextMode="Password" Width="200px" BackColor="#CCCCCC"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="border-color: #597272; padding: 0px; margin: 0px; background-color: #597272; border-collapse: collapse;">
                                          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                                            <asp:CheckBox 
                                                ID="cb_rememberme"  runat="server" Text=" Remember me" /> </td>
                                    </tr>
                                    <tr>
                                        <td align="left"
                                            style="border-color: #597272; padding: 0px; margin: 0px; background-color: #597272; border-collapse: collapse;">
                                            </td>
                                    </tr>
                                    <tr>
                                        <td align="right" 
                                            
                                            style="border-color: #597272; padding: 0px; margin: 0px; background-color: #597272; border-collapse: collapse;">
                                        <div align="right">
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="Submit" BackColor="Silver" runat="server" Text="Login" 
                                                onclick="Submit_Click" ForeColor="Black" Font-Bold="true" 
                                                ValidationGroup="submit" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="left"
                                            style="border-color: #597272; padding: 0px; margin: 0px; background-color: #597272; border-collapse: collapse;">
                                            &nbsp;</td>
                                    </tr>
                                    </table>
                            </center>
                        </td>
                        <td>
                            <table width="150">
                                <tr>
                                    <td style="position:static">
                                        <asp:RequiredFieldValidator 
                                                    ID="RequiredFieldValidator1" runat="server" 
                                                    ErrorMessage="* Please enter User ID" Display="Dynamic" 
                                                    ControlToValidate="user_id" ForeColor="#FF6600" 
                                            ValidationGroup="submit" Font-Size="8pt"></asp:RequiredFieldValidator>
                                    </td>
                                </tr>

                                <tr>
                                    <td style="position:static">
                                                &nbsp;</td>
                                </tr>

                                <tr>
                                    <td style="position:static">
                                                &nbsp;</td>
                                </tr>

                                <tr><td style="position:static">
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                                    ErrorMessage="* Please enter Password" Display="Dynamic" 
                                                    ControlToValidate="password" ForeColor="#FF6600" ValidationGroup="submit" 
                                                    BorderColor="Black" Font-Size="8pt"></asp:RequiredFieldValidator>
                                    </td></tr>

                                </table>
                        </td>
                    </tr>
                </table>

            

           </div>
			<%--<div id="content">
               <table>
               <tr>
               <td class="style7" width="20%"></td>
               <td class="style8" width="80%">
               <p class="style5">
               <br /><br />
                    
                </p>
                   <p class="style5">
                       &nbsp;</p>
				<br /><br />
                <br /><br />
               
               </td>
               <td class="style7" width="20%"></td>
               
               </tr>
               
               </table>
                
			</div>--%>
            <br />
            <br />
            
	</div>

    

     <div id="footer">

		        Copyright	&copy; 2012 ABC E-Recruitment Team. All Rights Reserved.
		    </div>	
    </form>
</body>
</html>
