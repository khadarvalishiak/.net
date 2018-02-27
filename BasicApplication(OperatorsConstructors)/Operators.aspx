<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Operators.aspx.cs" Inherits="BasicApplication_Operators" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

</head>
   
<body>
    <form id="form1" runat="server">
       
        <div id="Validate" runat="server">

            <asp:Label runat="server" Text="Enter UserName" />

            <asp:TextBox runat="server" ID="TextBox1"  ></asp:TextBox><br />
           <asp:Button runat="server" ID="GetUserName"  Text="click Me" OnClick="GetUserName_Click"/>
        </div>
        <div>
     <h2 id="bindUser" runat="server">

     </h2>

           
            <asp:Label runat="server" Text="Enter A value" />
            <asp:TextBox runat="server" ID="AValue" ></asp:TextBox><br />
                <asp:Label runat="server" Text="Enter B value" />
            <asp:TextBox runat="server" ID="BValue"  ></asp:TextBox><br />
            <asp:Button runat="server" ID="Caluculate"  Text="Add" OnClick="Caluculate_Click"/>
           
            <asp:Button runat="server" ID="sub"  Text="sub" OnClick="sub_Click"/>
            <asp:Button runat="server" ID="mul"  Text="mul" OnClick="mul_Click"/>
            <asp:Button runat="server" ID="div"  Text="div" OnClick="div_Click"/>
            <asp:Button runat="server" ID="modules"  Text="modules" OnClick="modules_Click"/>
            <h4 id="result" runat="server">

            </h4>
        </div>
    </form>
</body>
</html>
