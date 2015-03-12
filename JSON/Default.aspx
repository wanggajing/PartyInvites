<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="JSON_Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Summits</title>
    <link href="../Styles.css" rel="stylesheet" />
    <script src="../Scripts/jquery-2.1.3.js"></script>
    <script src="../Scripts/JSON.js"></script>
</head>
<body>
    <h2>Summits</h2>
    <table id="peaksTable">
        <thead><tr><th class="name">Name</th><th>Height (m)</th></tr></thead>
        <tbody id="tableBody"></tbody>
    </table>
    <input type="button" value="Delete" />
</body>
</html>
