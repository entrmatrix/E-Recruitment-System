<%@ Page Title="" Language="C#" MasterPageFile="~/PlacementConsultant.master" MaintainScrollPositionOnPostback="true" AutoEventWireup="true" CodeFile="Add_Candidates_byPC.aspx.cs" Inherits="Default2" %>


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
            height: 23px;
        }
        .style16
        {
            width: 1959px;
            height: 351px;
        }
        .style31
        {
            width: 857px;
            height: 178px;
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
            width: 1002px;
        }
        .style41
        {
            width: 1927px;
            height: 16px;
        }
        .style45
        {
            height: 16px;
            width: 414px;
        }
        .style46
        {
            width: 2439px;
            height: 16px;
        }
        .style48
        {
            width: 1927px;
            height: 12px;
        }
        .style49
        {
            width: 1002px;
            height: 12px;
        }
        .style50
        {
            width: 414px;
            height: 12px;
        }
        .style51
        {
            width: 2439px;
            height: 12px;
        }
        .style68
        {
            width: 1927px;
            height: 26px;
        }
        .style69
        {
            width: 1002px;
            height: 26px;
        }
        .style70
        {
            width: 414px;
            height: 26px;
        }
        .style71
        {
            width: 2439px;
            height: 26px;
        }
        .style72
        {
            width: 1927px;
            height: 23px;
        }
        .style73
        {
            width: 1002px;
            height: 23px;
        }
        .style74
        {
            width: 414px;
            height: 23px;
        }
        .style83
        {
            height: 24px;
        }
        .style86
        {
            width: 414px;
            height: 25px;
        }
        .style87
        {
            width: 1927px;
            height: 25px;
        }
        .style88
        {
            width: 1002px;
            height: 25px;
        }
        .style89
        {
            width: 2439px;
            height: 25px;
        }
        .style90
        {
            width: 1927px;
            height: 24px;
        }
        .style91
        {
            width: 1002px;
            height: 24px;
        }
        .style94
        {
            height: 351px;
        }
         .style18
        {
            width: 226px;
            text-align: right;
            height: 24px;
        }
        .style21
        {
            width: 156px;
            height: 24px;
            text-align: left;
        }
        .style20
        {
            width: 800px;
            height: 24px;
            text-align: left;
        }
        .style28
        {
            width: 265px;
            text-align: right;
            height: 16px;
        }
        .style17
        {
            height: 22px;
            width: 800px;
        }
       
        .style95
        {
            width: 800px;
            height: 16px;
        }
        .style96
        {
            width: 565px;
            text-align: left;
            height: 16px;
        }
        .style97
        {
            width: 156px;
            height: 16px;
            text-align: left;
        }
        .style98
        {
            width: 109px;
            height: 22px;
        }
        .style99
        {
            width: 156px;
            height: 22px;
            text-align: left;
        }
        .style100
        {
            width: 565px;
            text-align: left;
            height: 22px;
        }
        .style101
        {
            width: 565px;
            text-align: right;
            height: 24px;
        }
        .style106
        {
            width: 105px;
            height: 12px;
        }
        .style107
        {
            height: 16px;
            width: 105px;
        }
        .style108
        {
            width: 105px;
            height: 26px;
        }
        .style109
        {
            width: 105px;
            height: 23px;
        }
        .style110
        {
            width: 105px;
            height: 25px;
        }
        .style117
        {
            width: 748px;
            height: 32px;
        }
        .style118
        {
            width: 748px;
            height: 31px;
        }
        .style119
        {
            width: 1002px;
            height: 16px;
        }
        .style120
        {
            width: 248px;
            text-align: right;
        }
        .style121
        {
            width: 1927px;
        }
        .style122
        {
            width: 530px;
        }
        .style123
        {
            width: 414px;
        }
        .style124
        {
            width: 1002px;
            height: 32px;
        }
        .style125
        {
            width: 1002px;
            height: 31px;
        }
        .style126
        {
            width: 105px;
        }
    </style>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">

     <fieldset >
     <center>
   <h2>
       <strong> ADD CANDIDATE PROFILE:</strong>&nbsp;</h2>
        
    </center>
         <br />
        <table style="width: 68%; color: #FFFFFF; background-color: #666666;" 
        align="center">
           
            <tr>
                <td class="style18" height="26px" valign="bottom">
                   
                  
                   
                    &nbsp;</td>
                <td class="style101" height="26px" valign="middle">
                   
                  
                   
                    &nbsp;</td>
                <td class="style21" height="26px" valign="middle">
                    &nbsp;</td><td class="style20" height="26px" valign="middle"> 
                    &nbsp;</td>
                
            </tr>
           
            <tr>
                <td class="style18" height="26px" valign="bottom">
                   
                  
                   
                    </td>
                <td class="style101" height="26px" valign="middle">
                   
                  
                   
                    <asp:Label ID="lbVacancyID" runat="server" Font-Bold="True" Font-Size="Small" 
                        Text="Vacancy ID"></asp:Label>
                    :&nbsp;&nbsp; </td>
                <td class="style21" height="26px" valign="middle">
                   &nbsp;<asp:DropDownList ID="ddl_vacancy" runat="server" BackColor="Silver" 
                        ForeColor="Black" 
                        AutoPostBack="True" style="margin-bottom: 0px" 
                        onselectedindexchanged="ddl_vacancy_SelectedIndexChanged">
              
                        
                    </asp:DropDownList>
                
                    </td><td class="style20" height="26px" valign="middle"> 
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ControlToValidate="ddl_vacancy" Display="Dynamic" InitialValue="--select--"
                        ErrorMessage="*Please choose a Vacancy ID" ValidationGroup="submit" 
                        ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
                
            </tr>
            <tr>
                <td class="style28" valign="bottom">
                   
                    </td>
                <td class="style96" valign="bottom">
                   
                    </td>
                <td class="style97" valign="bottom">
                    
                </td>
                <td class="style95" valign="bottom"> 
                </td>
            </tr>
            <tr>
                <td class="style98" height="26px" valign="bottom">
                   
                    </td>
                <td class="style100" height="26px" valign="bottom">
                   
                    </td>
                <td class="style99" height="26px" valign="middle">
                    
                    &nbsp;<asp:Button ID="btnSubmit" runat="server" Text="Search" onclick="btnSubmit_Click" 
            ValidationGroup="submit" />
                
                </td>
                <td class="style17" height="26px" valign="middle">  
                </td>
            </tr>
            <tr>
                <td class="style98" height="26px" valign="bottom">
                   
                    &nbsp;</td>
                <td class="style100" height="26px" valign="bottom">
                   
                    &nbsp;</td>
                <td class="style99" height="26px" valign="middle">
                    
                    &nbsp;</td>
                <td class="style17" height="26px" valign="middle">  
                    &nbsp;</td>
            </tr>
          </table>
         <br />
       <asp:Panel ID="Panel2" runat="server"  HorizontalAlign="Center" Width="100%" 
             Visible="False">
           <table style="width:68%;" bgcolor="#666666" align="center">
               <tr>
                  <td align="center" class="style120">
                  &nbsp;</td>
                   <td align="center">
                       &nbsp;</td>
               </tr>
               <tr>
                   <td align="center" class="style120" valign="middle">
                       <asp:Label ID="lbVacancyID0" runat="server" Font-Bold="True" Font-Size="Small" 
                           ForeColor="White" Text="Total number of candidates added:"></asp:Label>
                       &nbsp;&nbsp;
                   </td>
                   <td align="center" style="text-align: left" valign="middle">
                       &nbsp;
                       <asp:TextBox ID="tbtotal" runat="server" BackColor="Silver" ForeColor="Black" 
                           Height="19px" ontextchanged="tbtotal_TextChanged" Width="35px"></asp:TextBox>
                       &nbsp;&nbsp;&nbsp;&nbsp;
                       <asp:Button ID="Complete" runat="server" ForeColor="Black" Height="24px" 
                           onclick="Complete_Click" Text="Complete" Width="70px" />
                       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                       <asp:Button ID="Cancel" runat="server" ForeColor="Black" Height="24px" 
                           onclick="Cancel_Click" Text="Cancel" Width="69px" />
                   </td>
               </tr>
               <tr>
                   <td align="center" class="style120">
                       &nbsp;</td>
                   <td align="center">
                       &nbsp;</td>
               </tr>
           </table>
           
          
       <br />
       </asp:Panel>
    <div align="center"  >
        <asp:Panel ID="Panel1" runat="server" HorizontalAlign="Left" Width="100%" 
            Height="474px" Visible="False">

      
            <table style="margin-right: 0px; width: 100%; height: 122px;" bgcolor="#666666">
            <tr>
            <td class="style94"></td>
      <td class="style16" style="color: #FFFFFF">
      <table style=" margin-right: 2px; margin-top: 2px; margin-left: 0px;" 
              border="0" frame="border" class="style31" align="center">
            <tr>
                <td class="style121" height="32px" valign="middle">
                    &nbsp;</td>
                <td class="style124" height="32px">
                    &nbsp;</td>
                <td class="style123" height="36px" valign="middle">
                    &nbsp;</td>
                <td class="style126" height="36px" valign="middle">
                    &nbsp;</td>
                <td class="style35" height="37px" valign="middle">
                 
                    
                </td>
            </tr>
            <tr>
                <td class="style48" height="32px" valign="middle">
                </td>
                <td class="style49" height="32px" valign="middle">
                    Location:</td>
                <td class="style50" height="36px" valign="middle">
                    <asp:TextBox ID="location" runat="server" BackColor="Silver" ForeColor="Black" 
                        Height="19px" Width="128px"></asp:TextBox>
                </td>
                <td class="style106" height="36px" valign="middle">
                    &nbsp;</td>
                <td class="style51" height="37px" valign="middle">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                        ControlToValidate="location" Display="Dynamic" 
                        ErrorMessage="*Please Enter Location" ForeColor="#FF3300" 
                        ValidationGroup="grp_validation"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style121" height="32px" valign="middle">
                    &nbsp;</td>
                <td class="style124" height="32px" valign="middle">
                    Gender:</td>
                <td align="left" class="style36" colspan="3" height="37px" valign="middle" 
                    width="30pc">
                    <asp:RadioButtonList ID="gender" runat="server" BackColor="Silver" 
                        Font-Bold="True" ForeColor="Black" Height="16px" RepeatDirection="Horizontal" 
                        Width="134px">
                        <asp:ListItem Selected="True">Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td class="style41" height="32px" valign="middle">
                </td>
                <td class="style119" height="32px" valign="middle">
                    X Standard Percentage:</td>
                <td class="style45" height="36px" valign="middle">
                    <asp:TextBox ID="tenth" runat="server" BackColor="Silver" ForeColor="Black" 
                        Height="19px" Width="128px"></asp:TextBox>
                </td>
                <td class="style107" height="36px" valign="middle">
                    &nbsp;</td>
                <td class="style46" height="37px" valign="middle">
                    <asp:RangeValidator ID="RangeValidator5" runat="server" 
                        ControlToValidate="tenth" Display="Dynamic" 
                        ErrorMessage="*Candidate should satisfy criteria of 60% - 100%" 
                        ForeColor="#FF3300" MaximumValue="100" MinimumValue="60" type="Double" 
                        ValidationGroup="grp_validation"></asp:RangeValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" 
                        ControlToValidate="tenth" Display="Dynamic" 
                        ErrorMessage="*Please enter Percentage obtained in X" ForeColor="#FF3300" 
                        ValidationGroup="grp_validation"></asp:RequiredFieldValidator>
                    <br />
                </td>
            </tr>
            <tr>
                <td class="style121" height="32px" valign="middle">
                    &nbsp;</td>
                <td class="style40" height="32px" valign="middle">
                    XII Standard Percentage:</td>
                <td class="style123" height="36px" valign="middle">
                    <asp:TextBox ID="twelfth" runat="server" BackColor="Silver" ForeColor="Black" 
                        Height="19px" style=" top: 426px; left: 315px;" Width="128px"></asp:TextBox>
                </td>
                <td class="style126" height="36px" valign="middle">
                    &nbsp;</td>
                <td class="style35" height="37px" valign="middle">
                    <asp:RangeValidator ID="RangeValidator6" runat="server" 
                        ControlToValidate="twelfth" Display="Dynamic" 
                        ErrorMessage="*Candidate should satisfy criteria of 65% - 100%" 
                        ForeColor="#FF3300" MaximumValue="100" MinimumValue="65" type="Double" 
                        ValidationGroup="grp_validation"></asp:RangeValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" 
                        ControlToValidate="twelfth" Display="Dynamic" 
                        ErrorMessage="*Please enter Percentage obtained in XII" ForeColor="#FF3300" 
                        ValidationGroup="grp_validation"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style68" height="32px" valign="middle">
                </td>
                <td class="style69" height="32px" valign="middle">
                    Gap in Education:</td>
                <td class="style70" height="36px" valign="middle">
                    <asp:DropDownList ID="gapsedu" runat="server" AutoPostBack="True" 
                        BackColor="Silver" ForeColor="Black" 
                        onselectedindexchanged="gaps_SelectedIndexChanged" style="height: 22px">
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
                    &nbsp;<asp:Label ID="lb_1" runat="server" Text="MM" Visible="False"></asp:Label>
                </td>
                <td class="style108" height="36px" valign="middle">
                    &nbsp;</td>
                <td class="style71" height="37px" valign="middle">
                    <br />
                </td>
            </tr>
            <tr>
                <td class="style72" height="32px" valign="middle">
                </td>
                <td class="style73" height="32px" valign="middle">
                    Gap in Experience:</td>
                <td class="style74" height="36px" valign="middle">
                    <asp:DropDownList ID="gapsexp" runat="server" AutoPostBack="True" 
                        BackColor="Silver" ForeColor="Black" 
                        onselectedindexchanged="gapsexp_SelectedIndexChanged">
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
                <td class="style109" height="36px" valign="middle">
                    &nbsp;</td>
                <td class="style15" height="37px" valign="middle">
                </td>
            </tr>
            <tr>
                <td class="style121" height="32px" valign="middle">
                    &nbsp;<td class="style125" height="32px" valign="middle">
                        Date of Birth:</td>
                    <td class="style123" height="36px" valign="middle">
                        <asp:TextBox ID="dob" runat="server" BackColor="Silver" ForeColor="Black" 
                            Height="19px" Width="128px"></asp:TextBox>
                    </td>
                    <td class="style126" height="36px" valign="middle">
                        &nbsp;</td>
                    <td class="style35" height="37px" valign="middle">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" 
                            ControlToValidate="dob" Display="Dynamic" 
                            ErrorMessage="*Please enter Date of Birth" ForeColor="#FF3300" 
                            ValidationGroup="grp_validation"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="RangeValidator7" runat="server" ControlToValidate="dob" 
                            Display="Dynamic" 
                            ErrorMessage="*Please Enter Date of Birth in MM-DD-YYYY format" 
                            ForeColor="#FF3300" MaximumValue="08-24-2012" MinimumValue="01-01-1900" 
                            Type="Date" ValidationGroup="grp_validation"></asp:RangeValidator>
                    </td>
                </td>
            </tr>
            <tr>
                <td class="style90" valign="middle" height="32px">
                    <td class="style91" valign="middle" height="32px">
                        Upload Resume:</td>
                    <td class="style83" colspan="3" valign="middle" height="37px" width="30pc">
                        <asp:FileUpload ID="FileUpload2" runat="server" BackColor="#CCCCCC" 
                            Height="22px" Width="163px" />
                        &nbsp;&nbsp;
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" 
                            ControlToValidate="FileUpload2" Display="Dynamic" 
                            ErrorMessage="*Please upload candidate's  resume." ForeColor="#FF3300" 
                            ValidationGroup="grp_validation"></asp:RequiredFieldValidator>
                    </td>
                </td>
            </tr>
            <tr>
                <td class="style87" valign="middle" height="32px">
                    <td class="style88" valign="middle" height="32px">
                        </td>
                    <td class="style86" valign="middle" height="36px">
                        </td>
                    <td class="style110" height="36px" valign="middle">
                        &nbsp;</td>
                    <td class="style89" valign="middle" height="37px">
                        </td>
                </td>
            </tr>
            <tr>
                <td class="style121" height="32px" valign="middle">
                    &nbsp;<td class="style125" height="32px" valign="middle">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
                    <td class="style123" height="36px" valign="middle">
                        <asp:Button ID="submit" runat="server" ForeColor="Black" 
                            onclick="submit_Click1" Text="Submit" UseSubmitBehavior="True" 
                            ValidationGroup="grp_validation" />
                    </td>
                    <td class="style126" height="36px" valign="middle">
                        &nbsp;</td>
                    <td class="style35" height="37px" valign="middle" ID="hf">
                        &nbsp;</td>
                </td>
            </tr>
            <tr>
                <td class="style121" height="32px" valign="middle">
                    &nbsp;<td class="style125" height="32px">
                        &nbsp;</td>
                    <td class="style123" height="36px" valign="middle">
                        &nbsp;</td>
                    <td class="style126" height="36px" valign="middle">
                        &nbsp;</td>
                    <td class="style35" height="37px" valign="middle">
                        &nbsp;</td>
                </td>
            </tr>
        </table>
        </td>
        </tr>
            </table>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
       <br />
          </asp:Panel>
          </div>
    </fieldset>
    

</asp:Content>

