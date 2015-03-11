<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="PartyStyles.css" rel="stylesheet" />
</head>
<body>
    <form id="rsvpform" runat="server">
        <div>
            <h1>New Year's Eve at Jacqui's!</h1>
            <p>We're going to have an exciting party. And you're invited!</p>
        </div>
        <asp:ValidationSummary ID="validationSummary" runat="server" ShowModelStateErrors="true" />
        <%-- The reason for this problem is that ASP.NET only looks for elements that have the runat attribute with a value of
server when processing Web Form files. All other elements are ignored and since our input and select elements in
the Default.aspx file don’t have this attribute/value combination, the model binding process isn’t able to find the
values submitted in the HTML form. --%>
        <div><label>Your name:</label><input type="text" id="name" runat="server" /></div>
        <div><label>Your email:</label><input type="text" id="email" runat="server" /></div>
        <div><label>Your phone:</label><input type="text" id="phone" runat="server" /></div>
        <div>
            <label>Will you attend?</label>
            <select id="willattend" runat="server">
                <option value="">Choose an Option</option>
                <option value="true">Yes</option>
                <option value="false">No</option>
            </select>
        </div>
        <div>
            <button type="submit">Submit RSVP</button>
        </div>
    </form>
</body>
</html>
