<%@ Page language="C#" MasterPageFile="~masterurl/default.master" Inherits="Microsoft.SharePoint.WebPartPages.WebPartPage, Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>

<asp:Content ContentPlaceHolderId="PlaceHolderAdditionalPageHead" runat="server">
    <SharePoint:ScriptLink name="sp.js" runat="server" OnDemand="true" LoadAfterUI="true" Localizable="false" />
</asp:Content>

<asp:Content ContentPlaceHolderID="PlaceHolderPageTitleInTitleArea" runat="server">
    <img src="../Images/RSP_logo.jpg"/>
    
</asp:Content>


<asp:Content ContentPlaceHolderId="PlaceHolderMain" runat="server">

<br />
    <br />
    <br />
    <table border="0" width="640" cellspacing="0" cellpadding="3" bordercolor="#333333">
        <tr>
            <th bgcolor="#FFFFFF" width="125" align="center"><font color="#0000CC"><a href="Default.aspx">| 　打刻・日報　 |</font></th>
            <th bgcolor="#FFFFFF" width="125" align="center"><font color="#0000CC"><a href="PastReport.aspx">| 過去分閲覧・訂正 |</a></font></th>
            <th bgcolor="#FFFFFF" width="125" align="center"><font color="#0000CC"><a href="Approval.aspx">|　　　 承認　　　 |</a></font></th>
            <th bgcolor="#FFFFFF" width="125" align="center"><font color="#DDDDDD">| 　　統計情報　　 |</font></th>
            <th bgcolor="#FFFFFF" width="125" align="center"><font color="#0000CC"><a href="Settings.aspx">|　　　 設定　　　 |</a></font></th>
        </tr>
    </table>
    <br /> 

</asp:Content>
