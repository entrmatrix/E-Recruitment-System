<%@ Page Language="C#" AutoEventWireup="true" CodeFile="aboutus.aspx.cs" Inherits="aboutus" %>

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
	<form id="form2" runat="server">
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
                         <li><center>&nbsp;<br />
&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;<asp:Label ID="Label2" runat="server" Text="Date Time"></asp:Label></center></li>
                       </ul>
		        </div>			
		    </div>
             
			</div>
			<div id="main" style="float:left">
                <h2>&nbsp;</h2>
                <h2>&nbsp;&nbsp; About Us</h2>
                <br />
                &nbsp;&nbsp;&nbsp; <strong>&nbsp;This process will  help the company ABC  as follows:
                </strong>
                <br />
                <span class="style6">
                <p>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Reduces the burden of managing incoming resumes without losing candidates who are interested in applying to a company.</p>
                <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Empowers HR to accurately process candidates profiles in depth in order to find the right candidates.</p>
                <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Help company find new employees,employ them in positions that suit their capabilities, promote their professional&nbsp; development and retain them in long term.</p>
                <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Offers effective means for tracking compliance with anti discrimination policies and laws.</p>
                <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Integrate work flows to automate information flow and multiple processes, such as the approval process.</p>
                </span>
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
