var titleArray = new Array();

function GetTaleTitle(grid) {
    $('#' + grid + ' th').each(function () {
        titleArray.push($(this).attr("binding"));
    })
}

function Json2Table(grid, data) {
    var title = new Array();

    $('#' + grid + ' th').each(function () {
        title.push($(this).attr("binding"));
    })
    var tbody = "";
    for (var i = 0; i < eval(data).length; i++) {
        tbody += "<tr>"
        $.each(title, function (n, titledata) {
            $.each(eval(data)[i], function (m, val) {
                if (m == titledata) {
                    tbody += "<td>";
                    tbody += val;
                    tbody += "</td>";
                }
			})
        })
        tbody += "</tr>";
    }
    $('#' + grid + ' tbody').html(tbody);
}