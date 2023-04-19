<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="OnlineSupermarketTuto.Assets.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link rel="stylesheet" href="../Assets/Lib/css/bootstrap.min.css" />
</head>
<body>
    <div class="coutainer-fluid">
        <!--空行-->
        <div class="row mt-5 mb-5">

        </div>

        <div class="row">
            <div class="col-md-4">

            </div>

            <div class="col-md-4">
                <form id="form1" runat="server">
                    <div>
                        <p class="text-center">
                            <img class="img-responsive center-block" src="../Assets/Images/supermarkets.png" style="height:215px; width:230px;"/>
                        </p>
                    </div>
                    <div class="mt-3">
                        <label for="" class="form-label">用户名</label>
                        <input type="text" placeholder="" autocomplete="off" class="form-control" runat="server" id="txtUserName" />
                    </div>
                    <div class="mt-3">
                        <label for="" class="form-label">密码</label>
                        <input type="password" placeholder="" autocomplete="off" class="form-control" runat="server" id="txtUserPwd" />
                    </div>
                    <asp:Label runat="server" ID="ErrMsg" class="text-danger"></asp:Label>
                    <div class="mt-3 d-grid">
                        <asp:Button Text="登录" runat="server" Class="btn-success btn" ID="btnLogin" OnClick="btnLogin_Click" />
                    </div>
                </form>
            </div>
            <div class="col-md-4">

            </div>
        </div>
    </div>

</body>
</html>
