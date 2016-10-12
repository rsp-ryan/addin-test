<%-- The following 4 lines are ASP.NET directives needed when using SharePoint components --%>

<%@ Page Inherits="Microsoft.SharePoint.WebPartPages.WebPartPage, Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" MasterPageFile="~masterurl/default.master" Language="C#" %>

<%@ Register TagPrefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>

<%-- The markup and script in the following Content element will be placed in the <head> of the page --%>
<asp:Content ContentPlaceHolderID="PlaceHolderAdditionalPageHead" runat="server">
    <script type="text/javascript" src="../Scripts/jquery-1.9.1.min.js"></script>
    <SharePoint:ScriptLink name="sp.js" runat="server" OnDemand="true" LoadAfterUI="true" Localizable="false" />
    <meta name="WebPartPageExpansion" content="full" />

    <!-- Add your CSS styles to the following file -->
    <libbnk rel="Stylesheet" type="text/css" href="../Content/App.css" />

    <!-- Add your JavaScript to the following file -->
    <script type="text/javascript" src="../Scripts/Add-in.js"></script>
</asp:Content>

<%-- The markup in the following Content element will be placed in the TitleArea of the page --%>
<asp:Content ContentPlaceHolderID="PlaceHolderPageTitleInTitleArea" runat="server">
    <img src="../Images/RSP_logo.jpg"/>
    
</asp:Content>

<%-- The markup and script in the following Content element will be placed in the <body> of the page --%>
<asp:Content ContentPlaceHolderID="PlaceHolderMain" runat="server">

   <br />
    <br />
    <br />
    <table border="0" width="640" cellspacing="0" cellpadding="3" bordercolor="#333333">
        <tr>
            <th bgcolor="#FFFFFF" width="125" align="center"><font color="#DDDDDD">| 　打刻・日報　 |</font></th>
            <th bgcolor="#FFFFFF" width="125" align="center"><font color="#0000CC"><a href="PastReport.aspx">| 過去分閲覧・訂正 |</a></font></th>
            <th bgcolor="#FFFFFF" width="125" align="center"><font color="#0000CC"><a href="Approval.aspx">|　　　 承認　　　 |</a></font></th>
            <th bgcolor="#FFFFFF" width="125" align="center"><font color="#0000CC"><a href="Statistics.aspx">| 　　統計情報　　 |</a></font></th>
            <th bgcolor="#FFFFFF" width="125" align="center"><font color="#0000CC"><a href="Settings.aspx">|　　　 設定　　　 |</a></font></th>
        </tr>
    </table>
    <br /> 
        
        <table border="0" width="690" cellspacing="0" cellpadding="5" bordercolor="#333333">
<tr>
<th bgcolor="#FF8000"><font color="#FFFFFF">日付</font></th>
<th bgcolor="#FF8000" width="110"><font color="#FFFFFF">出勤</font></th>
<th bgcolor="#FF8000" width="110"><font color="#FFFFFF">退勤</font></th>
<th bgcolor="#FF8000" width="100"><font color="#FFFFFF">勤務時間</font></th>
<th bgcolor="#FF8000" width="100"><font color="#FFFFFF">休憩時間</font></th>
<th bgcolor="#FF8000" width="270"><font color="#FFFFFF">コメント</font></th>
<th bgcolor="#FF8000" width="90"><font color="#FFFFFF">気持ち</font></th>
</tr>
<tr>
<td bgcolor="#58ACFA" align="right" nowrap><div id="reportDate1"></div></td>
<td bgcolor="#FFFFFF" align="center" width="110"><div id="reportClockIn1"></div></td>
<td bgcolor="#FFFFFF" align="center" width="110"><div id="reportClockOut1"></div></td>
<td bgcolor="#FFFFFF" align="center" width="100"><div id="reportWorkTime1"></div></td>
<td bgcolor="#FFFFFF" align="center" width="100"><div id="reportBreakTime1"></div></td>
<td bgcolor="#FFFFFF" valign="top" width="270"><div id="reportComment1"></div></td>
<td bgcolor="#FFFFFF" align="center" width="90"><div id="reportSentiment1"></div></td>
</tr>
            <tr>
<td bgcolor="#58ACFA" align="right" nowrap><div id="reportDate2"></div></td>
<td bgcolor="#FFFFFF" align="center" width="110"><div id="reportClockIn2"></div></td>
<td bgcolor="#FFFFFF" align="center" width="110"><div id="reportClockOut2"></div></td>
<td bgcolor="#FFFFFF" align="center" width="100"><div id="reportWorkTime2"></div></td>
<td bgcolor="#FFFFFF" align="center" width="100"><div id="reportBreakTime2"></div></td>
<td bgcolor="#FFFFFF" valign="top" width="270"><div id="reportComment2"></div></td>
<td bgcolor="#FFFFFF" align="center" width="90"><div id="reportSentiment2"></div></td>
</tr>
<tr>
<td bgcolor="#58ACFA" align="right" nowrap><div id="reportDate3"></div></td>
<td bgcolor="#FFFFFF" align="center" width="110"><div id="reportClockIn3"></div></td>
<td bgcolor="#FFFFFF" align="center" width="110"><div id="reportClockOut3"></div></td>
<td bgcolor="#FFFFFF" align="center" width="100"><div id="reportWorkTime3"></div></td>
<td bgcolor="#FFFFFF" align="center" width="100"><div id="reportBreakTime3"></div></td>
<td bgcolor="#FFFFFF" valign="top" width="270"><div id="reportComment3"></div></td>
<td bgcolor="#FFFFFF" align="center" width="90"><div id="reportSentiment3"></div></td>
</tr>
<tr>
<td bgcolor="#58ACFA" align="right" nowrap><div id="reportDate4"></div></td>
<td bgcolor="#FFFFFF" align="center" width="110"><div id="reportClockIn4"></div></td>
<td bgcolor="#FFFFFF" align="center" width="110"><div id="reportClockOut4"></div></td>
<td bgcolor="#FFFFFF" align="center" width="100"><div id="reportWorkTime4"></div></td>
<td bgcolor="#FFFFFF" align="center" width="100"><div id="reportBreakTime4"></div></td>
<td bgcolor="#FFFFFF" valign="top" width="270"><div id="reportComment4"></div></td>
<td bgcolor="#FFFFFF" align="center" width="90"><div id="reportSentiment4"></div></td>
</tr>
<tr>
<td bgcolor="#58ACFA" align="right" nowrap><div id="reportDate5"></div></td>
<td bgcolor="#FFFFFF" align="center" width="110"><div id="reportClockIn5"></div></td>
<td bgcolor="#FFFFFF" align="center" width="110"><div id="reportClockOut5"></div></td>
<td bgcolor="#FFFFFF" align="center" width="100"><div id="reportWorkTime5"></div></td>
<td bgcolor="#FFFFFF" align="center" width="100"><div id="reportBreakTime5"></div></td>
<td bgcolor="#FFFFFF" valign="top" width="270"><div id="reportComment5"></div></td>
<td bgcolor="#FFFFFF" align="center" width="90"><div id="reportSentiment5"></div></td>
</tr>
<tr>
<td bgcolor="#58ACFA" align="right" nowrap><div id="reportDate6"></div></td>
<td bgcolor="#FFFFFF" align="center" width="110"><div id="reportClockIn6"></div></td>
<td bgcolor="#FFFFFF" align="center" width="110"><div id="reportClockOut6"></div></td>
<td bgcolor="#FFFFFF" align="center" width="100"><div id="reportWorkTime6"></div></td>
<td bgcolor="#FFFFFF" align="center" width="100"><div id="reportBreakTime6"></div></td>
<td bgcolor="#FFFFFF" valign="top" width="270"><div id="reportComment6"></div></td>
<td bgcolor="#FFFFFF" align="center" width="90"><div id="reportSentiment6"></div></td>
</tr>
<tr>
<td bgcolor="#58ACFA" align="right" nowrap><div id="reportDate7"></div></td>
<td bgcolor="#FFFFFF" align="center" width="110"><div id="reportClockIn7"></div></td>
<td bgcolor="#FFFFFF" align="center" width="110"><div id="reportClockOut7"></div></td>
<td bgcolor="#FFFFFF" align="center" width="100"><div id="reportWorkTime7"></div></td>
<td bgcolor="#FFFFFF" align="center" width="100"><div id="reportBreakTime7"></div></td>
<td bgcolor="#FFFFFF" valign="top" width="270"><div id="reportComment7"></div></td>
<td bgcolor="#FFFFFF" align="center" width="90"><div id="reportSentiment7"></div></td>
</tr>
</table>

    
    <br />

    <table border="0" width="400" cellspacing="0" cellpadding="5" bordercolor="#333333">
<th></th>
<tr>
    <td ><div id="clockin"><asp:Button id="clockinbutton" ClientIDMode="Static" Text="出勤打刻"
  ForeColor="#cc3300" Font-Size="Large" Font-Bold="true" Height="40" OnClientClick="return clockinDaily()" runat="server" />
        
    </div> </td>
    <td >    <div id="clockout">
    <asp:Button id="clockoutbutton" ClientIDMode="Static" Text="退勤打刻" 
  ForeColor="#0066cc" Font-Size="Large" Font-Bold="true" Height="40"　OnClientClick="return clockoutDaily()" runat="server" />
    </div>
 </td>
</tr>
        </table>


    <br />
    <br />
    本日の感想<br />
    <asp:TextBox style="OVERFLOW: hidden" TextMode="MultiLine" runat="server" ID="commentbox"></asp:TextBox>
    <br /><br />
    休憩時間：<asp:TextBox runat="server" ID="breaktimebox" Text="60" Columns="3" MaxLength="3"></asp:TextBox>分<br />
    <br />
    本日の気持ち：<asp:DropDownList id="sentiment" runat="server">
      <asp:ListItem Value="最悪">最悪</asp:ListItem>
      <asp:ListItem Value="悪い">悪い</asp:ListItem>
      <asp:ListItem Value="普通">普通</asp:ListItem>
      <asp:ListItem Selected="true"　Value="良好">良好</asp:ListItem>
        <asp:ListItem Value="絶好調">絶好調</asp:ListItem>
    </asp:DropDownList>
    <br />
    <p><asp:HyperLink runat="server" NavigateUrl="JavaScript:window.location = _spPageContextInfo.webAbsoluteUrl + '/Pages/Help.aspx';" 
    Text="ヘルプ：使用方法はこちら" /></p>
    
<p><asp:HyperLink runat="server" NavigateUrl="JavaScript:window.location = _spPageContextInfo.webAbsoluteUrl + '/Lists/NewEmployeesInSeattle/AllItems.aspx';" 
    Text="List View Page for New Employees in Seattle" /></p>
</asp:Content>
