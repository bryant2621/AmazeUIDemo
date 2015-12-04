__CreateJSPath = function (js) {
    var scripts = document.getElementsByTagName("script");
    var path = "";
    for (var i = 0, l = scripts.length; i < l; i++) {
        var src = scripts[i].src;
        if (src.indexOf(js) != -1) {
            var ss = src.split(js);
            path = ss[0];
            break;
        }
    }
    var href = location.href;
    href = href.split("#")[0];
    href = href.split("?")[0];
    var ss = href.split("/");
    ss.length = ss.length - 1;
    href = ss.join("/");
    if (path.indexOf("https:") == -1 && path.indexOf("http:") == -1 && path.indexOf("file:") == -1 && path.indexOf("\/") != 0) {
        path = href + "/" + path;
    }
    return path;
}

var bootPATH = __CreateJSPath("ui.js");

document.write('<meta charset="utf-8">');
document.write('<meta http-equiv="X-UA-Compatible" content="IE=edge">');
document.write('<meta name="description" content="">');
document.write('<meta name="keywords" content="">');
document.write('<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no">');
document.write('<meta name="renderer" content="webkit">');
document.write('<meta http-equiv="Cache-Control" content="no-siteapp" />');
document.write('<link rel="icon" type="image/png" href="' + bootPATH + '/i/favicon.png">');
document.write('<meta name="mobile-web-app-capable" content="yes">');
document.write('<link rel="icon" sizes="192x192" href="' + bootPATH + '/i/app-icon72x72@2x.png">');
document.write('<meta name="apple-mobile-web-app-capable" content="yes">');
document.write('<meta name="apple-mobile-web-app-status-bar-style" content="black">');
document.write('<meta name="apple-mobile-web-app-title" content="Amaze UI" />');
document.write('<link rel="apple-touch-icon-precomposed" href="' + bootPATH + '/i/app-icon72x72@2x.png">');
document.write('<meta name="msapplication-TileImage" content="' + bootPATH + '/i/app-icon72x72@2x.png">');
document.write('<meta name="msapplication-TileColor" content="#0e90d2">');
document.write('<link rel="stylesheet" href="' + bootPATH + '/css/amazeui.min.css">');
document.write('<link rel="stylesheet" href="' + bootPATH + '/css/app.css">');
document.write('<script src="' + bootPATH + '/js/jquery.min.js"></script>');
document.write('<script src="' + bootPATH + '/js/amazeui.js"></script>');
document.write('<script src="' + bootPATH + '/js/handlebars.min.js"></script>');
document.write('<script src="' + bootPATH + '/js/amazeui.widgets.helper.js"></script>');

