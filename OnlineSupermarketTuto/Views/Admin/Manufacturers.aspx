<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Manufacturers.aspx.cs" Inherits="OnlineSupermarketTuto.Views.Admin.Suppliers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <div class="container-fluid">
        <div class="row">
            <div class="col">
                <h3 class="text-center">生产商管理</h3>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <div class="mb-3">
                <label for="" class="form-label text-success">生产商名称</label>
                <input type="text" placeholder="" autocomplete="off" class="form-control" />
            </div>
            <div class="mb-3">
                <label for="" class="form-label text-success">生产许可证号</label>
                <input type="text" placeholder="" autocomplete="off" class="form-control" />
            </div>
            <div class="mb-3">
                <label for="" class="form-label text-success">产地</label>
                <asp:DropDownList ID="DropDownList1" runat="server" class="form-control">
                    <asp:ListItem Text="地球" />
                    <asp:ListItem Text="月球" />
                    <asp:ListItem Text="冥王星" />
                </asp:DropDownList>
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
