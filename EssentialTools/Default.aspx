<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="EssentialTools_Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../EssentialTools.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div><label>Name:</label><input id="name" runat="server"/></div>
        <div><label>City:</label><input id="city" runat="server" /></div>
        <button type="submit">Submit</button>
    </form>
    <p id="target" runat="server"></p>
</body>
</html>
