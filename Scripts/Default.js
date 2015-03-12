/// <reference path="jquery-2.1.3.js" />
$(document).ready(function () {
    $("th").addClass("highlight");
    $("[type][value='Delete']").addClass("highlight");
    $("tr:eq(1)").addClass("highlight");
    $("tr:has(td:contains('Kili'))").addClass("highlight");
    $("td").addClass("highlight").css("color", "blue");

    $("tr").prepend("<td></td>");
    $("<input name='delete' type='radio'/>").prependTo("tbody td:first-child")
    .first().attr("checked", true);

    $(":button").click(function() {
        $(":radio:checked").closest("tr").remove();
        $(":radio").first().attr("checked", true);
    });
});