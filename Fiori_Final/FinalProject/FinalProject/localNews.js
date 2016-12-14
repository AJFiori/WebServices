
btnSubmit = function () {
        var source = document.getElementById("newsSource");
        var news = source.value;
        var url = 'https://webhose.io/search?token=36999783-d2a3-416c-b0bd-558759a15af7&format=json&q=' + news + '&sort=relevancy';


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

                $("#newsTable").append("<thead><tr><th>Todays News For: " + news + "</th></tr></thead>");
                for (i = 0; i < myObj.posts.length; i++) {

                    $("#newsTable").append("<tbody><tr><td>"
                                   + "<img src='" + myObj.posts[i].thread.main_image + "' style='width:304px;height:228px;' />" + "<br/>"
                                   + "<strong>" + myObj.posts[i].thread.title_full + "</strong></br>"
                                   + "<strong>Author:</strong> " + myObj.posts[i].author + "<br/>"
                                   + "<strong>Facebook Likes:</strong> " + myObj.posts[i].thread.social.facebook.likes + " "
                                   + "<strong>Comments:</strong> " + myObj.posts[i].thread.social.facebook.comments + " "
                                   + "<strong>Shares:</strong> " + myObj.posts[i].thread.social.facebook.shares + "<br/>"
                                   + "<a href=" + myObj.posts[i].thread.url
                                   + " target=_blank> Click For More Info  </a></td></tr>");
                }
            } else {
                // waiting for the call to complete

            }
        };

        $("#newsTable").empty();

        // Make the actual request
        xmlhttp.send(null);
    }