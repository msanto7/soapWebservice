<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BikesOnSOAP.aspx.cs" Inherits="mikesWebService.asmx.WebForm1" %>

<!DOCTYPE html>
  
<html xmlns="http://www.w3.org/1999/xhtml">  
<head runat="server">  
    <title>Bike Sizing in C#</title>  
</head>  
<body>  
    <form id="submit" runat="server">  
        <div>  
            <asp:Button ID="Submit1" runat="server" Text="Enter Height in Inches" OnClick="Submit_Click" style="height: 50px"/>  
        </div>  
        <div>
            <asp:TextBox ID ="heightInput" runat="server" Width="100"/>
        </div>

         <div> 
        <asp:TextBox ID="webServiceOutput" runat="server" Width="300"/>
        </div>

    </form>  


</body>  
</html>  
