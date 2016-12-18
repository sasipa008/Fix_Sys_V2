<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Fix_Sys_V2.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style3 {
            height: 67px;
            font-size: x-large;
        }
        .auto-style4 {
            font-size: medium;
        }
        .auto-style5 {
            height: 25px;
            font-size: large;
        }
        .auto-style6 {
            color: rgb(254, 255, 255);
        }
        .auto-style8 {
            font-size: small;
            font-style: normal;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 640px" class="auto-style1">
        <h1 class="auto-style3">
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Content/image/rsz_logopsu.png" />
        </h1>
        <h1 class="auto-style5">ยินดีต้อนรับสู่ PSU Report</h1>
        <h1>&nbsp;<span class="auto-style4">ลงชื่อเข้าใช้ที่นี่</span></h1>
        <span class="auto-style4">Username</span>: <asp:TextBox ID="ID" runat="server" style="background-color: #FFFF99"></asp:TextBox>
        <br />
        <br />
        Password: <asp:TextBox ID="Pass" runat="server" TextMode="Password" style="background-color: #FFFF99"></asp:TextBox>
        <br />
        <br />

        <asp:Button ID="Button1" runat="server"  OnClick="Button1_Click" Text="Login" />
    
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <address class="auto-style8">
            มหาวิทยาลัยสงขลานครินทร์ วิทยาเขตภูเก็ต,
        </address>
        <address class="auto-style8">
            80 หมู่ 1 ถ.วิชิตสงคราม ต.กะทู้ อ.กะทู้ จ.ภูเก็ต 83120 โทรศัพท์ 0-7627-6012, 0-7627-6013 โทรสาร 0-7627-6002</address>
    
    </div>
    </form>
</body>
</html>
