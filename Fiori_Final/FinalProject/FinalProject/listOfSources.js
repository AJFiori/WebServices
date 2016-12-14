


    /*
    var source = document.getElementById("newsSource");
    var news = source.value.replace(" ", "-");
    var news2 = news.toLowerCase();
    */
    var url = 'https://newsapi.org/v1/sources?&apiKey=cd52888677494997b8a81749a50a353d';
    // Cross platform xmlhttprequest

    // Create xmlhttprequest object
    var xmlhttp = null;
    if (window.XMLHttpRequest) {
        xmlhttp = new XMLHttpRequest();
        //make sure that Browser supports overrideMimeType
        if (typeof xmlhttp.overrideMimeType != 'undefined') { xmlhttp.overrideMimeType('text/xml'); }
    } else if (window.ActiveXObject) {
        xmlhttp = new ActiveXObject("Microsoft.XMLHTTP");
    } else {
        alert('Perhaps your browser does not support xmlhttprequests?');
    }

    // Create an HTTP GET request
    xmlhttp.open('GET', url, true);

    // Set the callback function
    xmlhttp.onreadystatechange = function () {
        if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
            var myObj = JSON.parse(xmlhttp.responseText);

            // $("#sourceTable").append("<thead><tr><th>List of News Sources To Use: </th></tr></thead>");
            for (i = 0; i < myObj.sources.length; i++) {
                $("#ddl").append("<option>" + myObj.sources[i].name + "</option>");               
            }
        } else {
            // waiting for the call to complete
        }
    };

    // Make the actual request
    xmlhttp.send(null);
