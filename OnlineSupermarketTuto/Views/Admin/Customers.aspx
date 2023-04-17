﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Customers.aspx.cs" Inherits="OnlineSupermarketTuto.Views.Admin.Customers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col">
                <h3 class="text-center">用户管理</h3>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <div class="mb-3">
                <label for="" class="form-label text-success">用户名</label>
                <input type="text" placeholder="" autocomplete="off" class="form-control" />
            </div>
            <div class="mb-3">
                <label for="" class="form-label text-success">电子邮箱</label>
                <input type="email" placeholder="" autocomplete="off" class="form-control" />
            </div>
            <div class="mb-3">
                <label for="" class="form-label text-success">电话号码</label>
                <input type="text" placeholder="" autocomplete="off" class="form-control" />
            </div>
            <div class="mb-3">
                <label for="" class="form-label text-success">地址</label>
                <input type="text" placeholder="" autocomplete="off" class="form-control" />
            </div>
            <div class="row">
                <div class="col-md-4">
                    <asp:Button Text="保存" runat="server" class="btn-success btn-block btn" Width="100px" />
                </div>
                <div class="col-md-4">
                    <asp:Button Text="删除" runat="server" class="btn-danger btn-block btn" Width="100px" />
                </div>
                <div class="col-md-4">
                    <asp:Button Text="编辑" runat="server" class="btn-warning btn-block btn" Width="100px" />
                </div>
            </div>

        </div>
        <div class="col-md-8">
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </div>
    </div>
</asp:Content>