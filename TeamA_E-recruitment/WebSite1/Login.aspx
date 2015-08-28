<%@ Page title="Login" Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="llogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <script  type="text/javascript" language="javascript">
         function disableBackButton() {
             window.history.forward(1000);
         }
         setTimeout("disableBackButton()", 0); 
</script>
    <style type="text/css">
        #form1
        {
            height: 394px;
            margin-top: 0px;
            width: 911px;
        }
    </style>
</head>
<body style="height: 500px; margin-top: 0px">
<img src="images/TE_ClientServices.jpg" alt="TE-Client Services" 
        style="width: 929px; height: 114px" />
    <form id="form1" runat="server">
        <div style="width: 967px">
            <fieldset Style="background-image: url('images/Resized-bg.jpg'); height: 403px; margin-top: 2px; width: 927px;">
            <legend>
                    Log-In Here
            </legend>
            
            <div style="border-style: ridge; border-width: medium; width: 506px; margin-left: 44px; margin-top: 34px; height: 209px;">
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
                <br />
                <asp:Label ID="login" runat="server" Text="Employee Number" 
                    style="font-weight: 700"></asp:Label>

                :<asp:TextBox ID="empidtb" runat="server" style="margin-left: 38px" 
                    Width="133px"></asp:TextBox>
                
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                ErrorMessage="Please enter only numbers" ControlToValidate="empidtb" 
                    ValidationExpression="^[0-9]*$" Display="Dynamic"></asp:RegularExpressionValidator>
                
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="empidtb" ErrorMessage="Please enter Employee ID" 
                    ValidationGroup="submit" Display="Dynamic"></asp:RequiredFieldValidator>
                
                <br />
                <br />
    
                <asp:Label ID="pass" runat="server" Text="Password" style="font-weight: 700"></asp:Label>
                    :&nbsp;&nbsp;
                
                <asp:TextBox ID="pswtb" runat="server" style="margin-left: 86px" 
                    TextMode="Password"></asp:TextBox>
    
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="pswtb" ErrorMessage="Please enter password" 
                    ValidationGroup="submit"></asp:RequiredFieldValidator>

                

                <br />
                <br />
    
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
                <asp:Button ID="sub" runat="server" onclick="sub_Click" Text="Submit" Style="background-image: url('images/Resized_bi.jpg'); font-weight: 700;" 
                    ValidationGroup="submit" Width="79px" Height="28px"/>
                
                <%--<br />
                <br />
                <br />--%>
                
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        
                <asp:Button ID="reset" 
                    Style="background-image: url('images/Resized_bi.jpg'); font-weight: 700;" 
                    OnClientClick="document.location.href=document.location.href;" Text="Reset" 
                    runat="server" Width="79px" Height="29px" />

                <br />

                
        
                <br />
                <br />
                
                </div>
       &nbsp;<img src="images/Logo1.png" alt="logo" 
                    style="height: 145px; width: 216px; margin-left: 701px; margin-top: 0px" /></fieldset>
           
        </div>

    </form>

</body>

</html>
