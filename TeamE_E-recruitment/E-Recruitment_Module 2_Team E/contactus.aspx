<%@ Page Language="C#" AutoEventWireup="true" CodeFile="contactus.aspx.cs" Inherits="contactus" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" xml:lang="en" lang="en">
<head>
<meta http-equiv="Content-Type" content="text/html;charset=iso-8859-1" />
<title>E-Recruitment</title>
<link type="text/css" rel="stylesheet" href="Styles/login.css"/>
    <style type="text/css">
        .style2
        {
            width: 176px;
            height: 68px;
        }
        .style5
        {
            color: #000000;
            text-align: justify;
        }
        .style6
        {
            color: white;
        }
    </style>
</head>
<body>
	<form id="form1" runat="server">
	<div id="wrapper">
		   <div id="header">
		   <div id="top">
                <div id="logo">   	 
 		            &nbsp;&nbsp;&nbsp;&nbsp;		   	 
 		            <img alt="Oops logo cannot be displayed" class="style2" src="Images/login_Logo.JPG" /></div>
			     <div id="menu" >
					<ul style="float:right">
                        <li> <a href="Login.aspx">&nbsp;Login</a></li>
                        <li><a  href="aboutus.aspx">About Us</a></li>
                         <li><a href="contactus.aspx">Contact Us</a></li>
                         <li><center>
                             <br />
                             &nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="lbdatetime" runat="server" Text="Date Time"></asp:Label></center></li>
                       </ul>
		        </div>			
		    </div>
             
			</div>
			<div id="main" style="float:left" >
                <h2>&nbsp;</h2>
                <h2>&nbsp; Contact Us</h2>
                
                <ul>
                <li></li>
                <span class="style6">
                    <li>&nbsp;&nbsp;&nbsp;<strong>ABC e-Recruitment Company</strong></li>
                    <li>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Technopark Campus</li>
                    <li>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Thiruvananthapuram - 695 581</li>
                    <li>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; India</li>
                    <li></li>
                    <li>&nbsp;&nbsp;&nbsp;<strong>Phone Number:</strong></li>
                    <li>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; +91-471 2828282</li>
                    <li>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; +91-471 2828283</li>
                    <li>&nbsp;&nbsp;&nbsp;<strong>mail ID: </strong> </li>
                    <li>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; erecruitment@abc.com</li>
                    <li></li>
                </span>
                </ul>
           </div>  
			<div id="content">
                <p class="style5">
                    &nbsp;</p>
			</div>
		</div>	
		<div id="footer">
            Copyright	&copy; 2012 ABC E-Recruitment Team. All Rights Reserved.
	    </div>				
	
    </form>
</body>
</html>
