<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GetJSONViaScriptManager.aspx.cs" Inherits="JSONWebService.GetJSONViaScriptManager" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        <Services>
        <asp:ServiceReference Path="~/Service1.asmx" />
        </Services>
        </asp:ScriptManager>
        
        <script>
            function ajaxTest() {
                var myProxy = new JSONWebService.Service1;
                var Employee = myProxy.OutputEmployeeJSON(success,failure,myProxy);
              
            
            }
            
            function success(result){
                alert(result);
                //var result1 = eval('(' + result + ')'); 
                var result1 = JSON.parse(result);
                var data = "";
                for (var i =0;i < result1.length;i++){
                    data += " " + "Name-" + result1[i].Name + " " + "Company-" + result1[i].Company + "<BR/>";
                }
                // shorthand for getElementByID
                $get("outputData").innerHTML += data;
            }
            
            function failure(result){
                alert(result);
            }
        </script>

        <input type="button" value="Button" onclick="ajaxTest();" />
        <div id="outputData">
        
        </div>
    </div>
    </form>
</body>
</html>
