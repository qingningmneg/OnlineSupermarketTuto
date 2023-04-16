﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="OnlineSupermarketTuto.Assets.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link rel="stylesheet" href="Lib/css/bootstrap.min.css" />
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
                            <img class="img-responsive center-block" src="Images/supermarkets.png" style="height:215px; width:230px;"/>
                        </p>
                    </div>
                    <div class="mt-3">
                        <label for="" class="form-label">用户名</label>
                        <input type="text" placeholder="" autocomplete="off" class="form-control" />
                    </div>
                    <div class="mt-3">
                        <label for="" class="form-label">密码</label>
                        <input type="password" placeholder="" autocomplete="off" class="form-control" />
                    </div>

                    <div class="mt-3 d-grid">
                        <asp:Button Text="登录" runat="server" Class="btn-success btn" />
                    </div>
                </form>
            </div>
            <div class="col-md-4">

            </div>
        </div>
    </div>

</body>
</html>