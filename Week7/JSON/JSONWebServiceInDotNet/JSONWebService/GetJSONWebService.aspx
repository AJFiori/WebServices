<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GetJSONWebService.aspx.cs" Inherits="JSONWebService.GetJSONWebService" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>

    <script src="jquery-1.6.4.min.js" type="text/javascript"></script>
<script type="text/javascript" >
<!--
    $(document).ready(function() {
        $('#myButton').click(function(event) {
            $.ajax({
                type: "POST",
                url: "Service1.asmx/OutputEmployeeJSON",
                data: "{}",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function(msg) {
                    var items = [];
                    var data = eval(msg.d)
                    var data1 = data[0].Name + '--' + data[0].Company;
                    var data2 = '';
                    // Now var is an object with properties just like your object
                    $.each(data, function(key, val) {
                        //items.push('<li id="' + key + '">' + val.Address + '</li>');
                        //items.push('<p>' + val.Address + "," + val.Phone + '</p>');
                        data2 += '<p>' + val.Address + "," + val.Phone + '</p>';
                    });
                    //                    $("#results").html(items);
                    //                    $('<ul/>', {
                    //                        'class': 'my-new-list',
                    //                        html: items.join('')
                    //                    }).appendTo('body');

                    //                    $("#results").html(data2);
                    document.getElementById("TextBox1").value = data1;
                    //alert(items);
                    document.getElementById("results").innerHTML = data2;



                }

            });
            // stop the screen refresh
            return false;
        });

    });
//-->    
 </script>
 
</head>
<body>
    <form id="form1" runat="server">
    <asp:Button ID="myButton" runat="server" Text="Button" />
    <div id="results" ></div>
    <input id="TextBox1" type="text" />
    </form>
</body>
</html>
