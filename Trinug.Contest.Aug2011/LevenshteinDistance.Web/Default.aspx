<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LevenshteinDistance.Web.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>LevenshteinDistance</title>
    <style>
        body 
        {            
            font-size:12px;
            font-family:Candara,Verdana,Courier;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <p>
    File Path: <asp:TextBox ID="txtFilePath" runat="server" Width="400px" Font-Size="Smaller" /> <br /> <br />
        <asp:Button ID="btnCalculateDistance" runat="server" Text="Compute Distances!" OnClick="btnCalculateDistance_Click" /></p>
    <p>
        <asp:TextBox ID="txtResults" runat="server" TextMode="MultiLine" Rows="15" Columns="50"></asp:TextBox></p>
        <div><asp:Label ID="lblTimeTaken" runat="server" Font-Bold="true" ForeColor="Blue" Font-Size="Larger" /></div>
    </form>
</body>
</html>
