<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="OnlineSupermarketTuto.Views.Admin.Products" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col">
                <h3 class="text-center">商品管理</h3>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <div class="mb-3">
                <label for="" class="form-label text-success">商品名称</label>
                <input type="text" placeholder="" autocomplete="off" runat="server" id="PNameTb" class="form-control" />
            </div>
            <div class="mb-3">
                <label for="" class="form-label text-success">生产商名称</label>
                <asp:DropDownList ID="PManufactCb" runat="server" class="form-control"></asp:DropDownList>
            </div>
            <div class="mb-3">
                <label for="" class="form-label text-success">商品类目</label>
                <asp:DropDownList ID="PCatCb" runat="server" class="form-control"></asp:DropDownList>
            </div>
            <div class="mb-3">
                <label for="" class="form-label text-success">价格</label>
                <input type="text" placeholder="" autocomplete="off" runat="server" id="PriceTb" class="form-control" />
            </div>
            <div class="mb-3">
                <label for="" class="form-label text-success">数量</label>
                <input type="text" placeholder="" autocomplete="off" runat="server" id="QtyTb" class="form-control" />
            </div>
            <div class="row">
                <asp:Label runat="server" ID="ErrMsg" class="text-danger"></asp:Label>
                <div class="col-md-4">
                    <asp:Button Text="保存" runat="server" ID="SaveBtn" class="btn-success btn-block btn" Width="100px" OnClick="SaveBtn_Click" />
                </div>
                <div class="col-md-4">
                    <asp:Button Text="删除" runat="server" ID="DeleBtn" class="btn-danger btn-block btn" Width="100px" OnClick="DeleBtn_Click" />
                </div>
                <div class="col-md-4">
                    <asp:Button Text="编辑" runat="server" ID="EditBtn" class="btn-warning btn-block btn" Width="100px" OnClick="EditBtn_Click" />
                </div>
            </div>

        </div>
        <div class="col-md-8">
            <asp:GridView ID="ProductList" runat="server" class="table" AutoGenerateSelectButton="True" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" OnSelectedIndexChanged="ProductList_SelectedIndexChanged">
                <AlternatingRowStyle BackColor="White" />
                <FooterStyle BackColor="#CCCC99" />
                <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                <RowStyle BackColor="#F7F7DE" />
                <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#FBFBF2" />
                <SortedAscendingHeaderStyle BackColor="#848384" />
                <SortedDescendingCellStyle BackColor="#EAEAD3" />
                <SortedDescendingHeaderStyle BackColor="#575357" />
            </asp:GridView>
        </div>
    </div>
</asp:Content>
