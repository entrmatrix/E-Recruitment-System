<%@ Page Title="" Language="C#" MasterPageFile="~/PlacementConsultant.master" MaintainScrollPositionOnPostback="true" AutoEventWireup="true" CodeFile="Edit_Candidates_Page 2.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content2" ContentPlaceHolderID="HeadContent" Runat="Server">

  
    <style type="text/css">
        .style1
        {
            width: 625px;
        }
        .style12
        {
            width: 4px;
        }
        .style15
        {
            width: 109px;
        }
        .style16
        {
            width: 1959px;
        }
        .style27
        {
            width: 4096px;
        }
        .style31
        {
            width: 825px;
            height: 413px;
        }
        .style35
        {
            width: 2439px;
        }
        .style36
        {
        }
        .style40
        {
            width: 80px;
        }
        .style41
        {
            width: 1568px;
            height: 16px;
        }
        .style44
        {
            width: 536px;
            height: 16px;
        }
        .style45
        {
            height: 16px;
            width: 141px;
        }
        .style46
        {
            width: 2439px;
            height: 16px;
        }
        .style47
        {
            width: 141px;
        }
        .style48
        {
            width: 1568px;
            height: 20px;
        }
        .style49
        {
            width: 217px;
            height: 20px;
        }
        .style50
        {
            width: 141px;
            height: 20px;
        }
        .style51
        {
            width: 2439px;
            height: 20px;
        }
        .style55
        {
            width: 1496px;
        }
        .style56
        {
            width: 1496px;
            height: 26px;
        }
        .style57
        {
            height: 26px;
        }
        .style58
        {
            width: 141px;
            height: 25px;
        }
        .style59
        {
            width: 2439px;
            height: 25px;
        }
        .style60
        {
            width: 1568px;
            height: 25px;
        }
        .style61
        {
            height: 25px;
        }
        .style62
        {
            width: 1568px;
        }
        </style>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">

     <fieldset >
     <center>
   <h2>
       Ed<strong>it CANDIDATE PROFILE:</strong>&nbsp;</h2>
        
    </center>
    <br />
    <br />
    <div align="center"  >
        <asp:Panel ID="Panel1" runat="server" HorizontalAlign="Left" Width="100%">

      
            <table style="margin-right: 0px; width: 100%;" bgcolor="#666666">
            <tr>
            <td width="5%"></td>
      <td class="style16" style="color: #FFFFFF" width="95%">
      <table style=" margin-right: 2px; margin-top: 2px; margin-left: 0px;" 
              border="0" frame="border" class="style31" align="center">
            <tr>
                <td class="style62" height="31px">
                    &nbsp;</td>
                <td class="style56" width="20%" height="37px" valign="middle">
                    &nbsp;</td>
                <td class="style47" height="37px" valign="middle">
                    &nbsp;</td>
                <td class="style35" height="30px" valign="middle" width="26px">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style62" height="31px">
                    &nbsp;</td>
                <td class="style56" width="20%" height="37px" valign="middle">
                    Vacancy ID:</td>
                <td class="style47" height="37px" valign="middle">
                    <asp:Label ID="vacancy" runat="server" Text="Vacancy"></asp:Label>
                </td>
                <td class="style35" height="30px" valign="middle" width="26px">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
            </tr>
            <tr>
                <td class="style62" height="31px">
                    &nbsp;</td>
                <td class="style56" height="37px" valign="middle" width="20%">
                    Candidate ID:</td>
                <td class="style47" height="37px" valign="middle">
                    <asp:Label ID="Candidate" runat="server" Text="Label"></asp:Label>
                </td>
                <td class="style35" height="30px" valign="middle" width="26px">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style48" height="31px">
                    </td>
                <td class="style49" width="20%" height="37px" valign="middle">
                    Location:</td>
                <td class="style50" height="37px" valign="middle">
                    <asp:TextBox ID="location" runat="server" 
                        Width="128px" BackColor="Silver" ForeColor="Black" Height="20px"></asp:TextBox>
                </td>
                <td class="style51" height="30px" valign="middle" width="26px">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="location"  
                        ErrorMessage="*Please Enter Location" ForeColor="#FF3300" 
                        ValidationGroup="grp_validation" Display="Dynamic"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td  class="style62" height="31px">
                    &nbsp;</td>
                <td class="style56" width="20%" height="37px" valign="middle">
                    Gender:</td>
                <td class="style36" align="left" colspan="2" height="37px" valign="middle">
                    <asp:RadioButtonList  ID="gender" runat="server" 
                       
                        RepeatDirection="Horizontal" BackColor="Silver" Font-Bold="True" 
                        ForeColor="Black" Height="16px" Width="134px">
                        <asp:ListItem Selected="True">Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td class="style41" height="31px">
                    </td>
                <td class="style44" width="20%" height="37px" valign="middle">
                    X Standard Percentage:</td>
                <td class="style45" height="37px" valign="middle">
                    <asp:TextBox ID="tenth" runat="server" Width="128px" BackColor="Silver" 
                        ForeColor="Black" Height="20px"></asp:TextBox>
                </td>
                <td class="style46" height="30px" valign="middle" width="26px">
                    <asp:RangeValidator ID="RangeValidator4" runat="server"  MinimumValue="60" MaximumValue="100"
                    type="Double" ControlToValidate="tenth"
                        ErrorMessage="*Candidate should satisfy criteria of 60% - 100%" 
                        ForeColor="#FF3300" Display="Dynamic" ValidationGroup="grp_validation"></asp:RangeValidator>
                    <br /> 
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" 
                        runat="server" ControlToValidate="tenth" 
                         ErrorMessage="*Please enter Percentage obtained in 10th " ForeColor="#FF3300" 
                        Display="Dynamic" ValidationGroup="grp_validation"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style62" height="31px">
                    &nbsp;</td>
                <td class="style40" style="width:20%" height="37px" 
                    valign="middle">

                    XII Standard Percentage:</td>
                <td class="style47" height="37px" valign="middle">
                    <asp:TextBox ID="twelfth" style=" top: 426px; left: 315px;" 
                        runat="server" Width="128px" BackColor="Silver" 
                        ForeColor="Black" Height="20px"></asp:TextBox>
                </td>
                <td class="style35" height="30px" valign="middle" width="26px">
                    <asp:RangeValidator ID="RangeValidator1" runat="server"  MinimumValue="65" MaximumValue="100"
                    type="Double" ControlToValidate="twelfth"
                        ErrorMessage="*Candidate should satisfy criteria of 65% - 100%" 
                        ForeColor="#FF3300" Display="Dynamic" ValidationGroup="grp_validation"></asp:RangeValidator>
                    <br /> 
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" 
                        runat="server" ControlToValidate="twelfth"
                        Display="Dynamic" ErrorMessage="*Please enter Percentage obtained in 12th" 
                        ForeColor="#FF3300" ValidationGroup="grp_validation"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style62" height="31px">
                    &nbsp;</td>
                <td class="style27" width="20%" valign="middle" height="37px">
                    Gap in Education:</td>
                <td class="style47" valign="middle" height="37px">
                    <asp:DropDownList ID="gapsedu" runat="server" 
                        onselectedindexchanged="gaps_SelectedIndexChanged" style="height: 22px" 
                        AutoPostBack="True" BackColor="Silver" ForeColor="Black">
                        <asp:ListItem>No</asp:ListItem>
                        <asp:ListItem>Yes</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;<asp:DropDownList ID="gapsedu_months" runat="server" AutoPostBack="True" 
                        BackColor="Silver" ForeColor="Black" 
                        onselectedindexchanged="gaps_SelectedIndexChanged" style="height: 22px" 
                        Visible="False">
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                        <asp:ListItem>5</asp:ListItem>
                        <asp:ListItem>6</asp:ListItem>
                        <asp:ListItem>7</asp:ListItem>
                        <asp:ListItem>8</asp:ListItem>
                        <asp:ListItem>9</asp:ListItem>
                        <asp:ListItem>10</asp:ListItem>
                        <asp:ListItem>11</asp:ListItem>
                        <asp:ListItem>12</asp:ListItem>
                        <asp:ListItem>13</asp:ListItem>
                        <asp:ListItem>14</asp:ListItem>
                        <asp:ListItem>15</asp:ListItem>
                        <asp:ListItem>16</asp:ListItem>
                        <asp:ListItem>17</asp:ListItem>
                        <asp:ListItem>18</asp:ListItem>
                        <asp:ListItem>19</asp:ListItem>
                        <asp:ListItem>20</asp:ListItem>
                        <asp:ListItem>21</asp:ListItem>
                        <asp:ListItem>22</asp:ListItem>
                        <asp:ListItem>23</asp:ListItem>
                        <asp:ListItem>24</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;<asp:Label  ID="lb_1" runat="server" Text="MM" Visible="False"></asp:Label>
                    <br />
                </td>
                <td class="style35" valign="middle" height="30px" width="26px">
                    <br /> 
                </td>
            </tr>
            <tr>
                <td class="style62" height="31px">
                    &nbsp;</td>
                <td class="style57" width="20%" height="37px" valign="middle">
                    Gap in Experience:</td>
                <td class="style47" valign="middle" height="37px">
                    <asp:DropDownList ID="gapsexp" runat="server" AutoPostBack="True" 
                        onselectedindexchanged="gapsexp_SelectedIndexChanged" BackColor="Silver" ForeColor="Black" 
                       >
                        <asp:ListItem>No</asp:ListItem>
                        <asp:ListItem>Yes</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;<asp:DropDownList ID="gapsexp_months" runat="server" AutoPostBack="True" 
                        BackColor="Silver" ForeColor="Black" 
                        onselectedindexchanged="gaps_SelectedIndexChanged" style="height: 22px" 
                        Visible="False">
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                        <asp:ListItem>5</asp:ListItem>
                        <asp:ListItem>6</asp:ListItem>
                        <asp:ListItem>7</asp:ListItem>
                        <asp:ListItem>8</asp:ListItem>
                        <asp:ListItem>9</asp:ListItem>
                        <asp:ListItem>10</asp:ListItem>
                        <asp:ListItem>11</asp:ListItem>
                        <asp:ListItem>12</asp:ListItem>
                        <asp:ListItem>13</asp:ListItem>
                        <asp:ListItem>14</asp:ListItem>
                        <asp:ListItem>15</asp:ListItem>
                        <asp:ListItem>16</asp:ListItem>
                        <asp:ListItem>17</asp:ListItem>
                        <asp:ListItem>18</asp:ListItem>
                        <asp:ListItem>19</asp:ListItem>
                        <asp:ListItem>20</asp:ListItem>
                        <asp:ListItem>21</asp:ListItem>
                        <asp:ListItem>22</asp:ListItem>
                        <asp:ListItem>23</asp:ListItem>
                        <asp:ListItem>24</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;<asp:Label ID="lb_2" runat="server" Text="MM" Visible="False"></asp:Label>
                </td>
                <td class="style15" valign="middle" height="30px" width="26px">
              

                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style62" height="31px">
                    &nbsp;<td class="style57" width="20%" height="37px" valign="middle">
                        Date of Birth:</td>
                        <td class="style47" height="37px" valign="middle">
                            <asp:TextBox ID="dob"  runat="server" BackColor="Silver" ForeColor="Black" 
                                Width="128px" Height="20px"></asp:TextBox>
                    </td>
                        <td class="style35" height="30px" valign="middle" width="26px">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                                ErrorMessage="*Please enter Date of Birth" ForeColor="#FF3300" 
                                ControlToValidate="dob" ValidationGroup="grp_validation" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:RangeValidator ID="RangeValidator7" runat="server" ControlToValidate="dob" 
                                Display="Dynamic" 
                                ErrorMessage="*Please Enter Date of Birth in MM-DD-YYYY format" 
                                ForeColor="#FF3300" MaximumValue="08-24-2012" MinimumValue="01-01-1900" 
                                Type="Date" ValidationGroup="grp_validation"></asp:RangeValidator>
                    </td>
                </td>
                </tr>
            <tr>
                <td class="style62" height="31px">
                    &nbsp;<td class="style57" width="20%" height="37px" valign="middle">
                        Upload Resume:</td>
                    <td class="style36" colspan="2" height="37px" valign="middle">
                        <asp:FileUpload ID="FileUpload1" runat="server" Width="211px" 
                            BackColor="#CCCCCC" Height="22px" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                            ControlToValidate="FileUpload1" Display="Dynamic" 
                            ErrorMessage="*Please upload candidate's resume." ForeColor="#FF3300" 
                            ValidationGroup="grp_validation"></asp:RequiredFieldValidator>
                    </td>
                </td>
            </tr>
            <tr>
                <td class="style60">
                    <td class="style61" width="20%" height="37px" valign="middle">
                        </td>
                    <td class="style58" height="37px" valign="middle">
                        </td>
                    <td class="style59" height="30px" valign="middle" width="26px">
                        </td>
                </td>
            </tr>
            <tr>
                <td class="style62" height="31px">
                    &nbsp;<td class="style57" width="20%" height="37px" valign="middle">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        </td>
                    <td class="style47" height="37px" valign="middle">
                        <asp:Button ID="submit" runat="server" onclick="submit_Click1" Text="Submit" 
                            UseSubmitBehavior="True" ValidationGroup="grp_validation" 
                            ForeColor="Black" />
                    </td>
                    <td class="style35" height="30px" valign="middle" width="26px">
                        &nbsp;</td>
                </td>
            </tr>
            <tr>
                <td class="style62" height="31px">
                    &nbsp;<td class="style57" width="20%" height="37px" valign="middle">
                        &nbsp;</td>
                    <td class="style47" height="37px" valign="middle">
                        &nbsp;</td>
                    <td class="style35" height="30px" valign="middle" width="26px">
                        &nbsp;</td>
                </td>
            </tr>
        </table>
        </td>
        </tr>
            </table>
            <br />
       
          </asp:Panel>
          </div>
    </fieldset>
    

</asp:Content>

