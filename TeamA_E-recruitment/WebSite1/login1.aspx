<%@ Page Title="Login Page" Language="C#" AutoEventWireup="true"
    CodeFile="login1.aspx.cs" Inherits="_login" %>

   

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <fieldset Style="background-image: url(images/Resized-bg.jpg);">
<legend>
Log-In Here
</legend>
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
<div>

    <asp:Label ID="login" runat="server" Text="Employee Number" 
        style="font-weight: 700"></asp:Label>

    <asp:TextBox ID="empidtb" runat="server" style="margin-left: 45px"></asp:TextBox>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
        ControlToValidate="empidtb" Display="Dynamic" 
        ErrorMessage="please enter only number" ondatabinding="sub_Click" 
        ValidationExpression="^[0-9]+$ "></asp:RegularExpressionValidator>
&nbsp;&nbsp;&nbsp;
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ControlToValidate="empidtb" ErrorMessage="employee id required" 
        ValidationGroup="submit"></asp:RequiredFieldValidator>
    <br />
    <br />
    <asp:Label ID="pass" runat="server" Text="Password" style="font-weight: 700"></asp:Label>
    :&nbsp;&nbsp;
    <asp:TextBox ID="pswtb" runat="server" style="margin-left: 86px" 
        TextMode="Password"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
        ControlToValidate="pswtb" ErrorMessage="Password Required" 
        ValidationGroup="submit"></asp:RequiredFieldValidator>
    <br />
    <br />
    <asp:Button ID="sub" runat="server" onclick="sub_Click" Text="Submit" Style="background-image: url('images/Resized_bi.jpg'); font-weight: 700;" 
        ValidationGroup="submit" Width="79px" Height="37px"/>
    <%--<br />
    <br />
    <br />--%>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        
    <asp:Button ID="reset" 
        Style="background-image: url('images/Resized_bi.jpg'); font-weight: 700;" 
        OnClientClick="document.location.href=document.location.href;" Text="Reset" 
        runat="server" Width="79px" Height="37px" />


    
    <br />
    <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
    <br />
    <br />
    </div>
    </fieldset>
    </div>

    </div>
    </form>
</body>
</html>
