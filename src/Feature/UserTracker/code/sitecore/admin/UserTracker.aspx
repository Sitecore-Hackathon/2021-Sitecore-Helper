<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserTracker.aspx.cs" Inherits="SitecoreHelper2021.Feature.UserTracker.sitecore.admin.UserTracker" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sitecore User Tracker</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="scrptManagerVersionTracker" runat="server"></asp:ScriptManager>
        <div class="page-title">
            Sitecore User Tracker
        </div>
        <div class="form-section">
            <div class="report">
                <asp:Button ID="btnDownloadReport" CssClass="download-report" runat="server" Text="Download Report (CSV)" OnClick="btnDownloadReport_Click" ToolTip="Download the report in CSV format" />
                <asp:Button ID="btnGenerateReport" runat="server" Text="Generate Report" OnClick="btnGenerateReport_Click" ToolTip="Generate the Report" />
            </div>
        </div>
        <asp:Literal ID="ltlReport" runat="server" />
        
    </form>
</body>
</html>
