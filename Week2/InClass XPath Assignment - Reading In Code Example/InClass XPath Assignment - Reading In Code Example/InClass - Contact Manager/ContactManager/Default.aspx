<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ContactManager._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblVersionDate" runat="server" Text="Label"></asp:Label>
        <asp:Label ID="lblVersionNumber" runat="server" Text="Label"></asp:Label>
        <table class="style1">
            <tr>
                <td>
                    <asp:Button ID="btnGetInformation" runat="server" 
                        onclick="btnGetInformation_Click" Text="Get Information" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txtResults1" runat="server" Height="135px" 
                        ontextchanged="txtResults1_TextChanged" TextMode="MultiLine" Width="374px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnGetInformationAnotherWay" runat="server" 
                        onclick="btnGetInformationAnotherWay_Click" Text="Get Info Another Way" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txtResults2" runat="server" Height="89px" TextMode="MultiLine" 
                        Width="366px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnReturnOnlyMales" runat="server" 
                        onclick="btnReturnOnlyMales_Click" Text="Return Only Males" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txtResults3" runat="server" Height="92px" TextMode="MultiLine" 
                        Width="354px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnFindLastName" runat="server" onclick="btnFindLastName_Click" 
                        Text="Find Last Name" />
                    <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txtResults4" runat="server" Height="74px" TextMode="MultiLine" 
                        Width="359px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnBetterFindLastName" runat="server" 
                        onclick="btnBetterFindLastName_Click" Text="Better Last Name Search" />
                    <asp:TextBox ID="txtBetterLastNameSearch" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txtResults5" runat="server" Height="103px" 
                        TextMode="MultiLine" Width="363px"></asp:TextBox>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
