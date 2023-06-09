﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineSupermarketTuto.Views.Admin
{
    public partial class Products : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
            if (!IsPostBack)
            {
                ShowCustomer();
                GetCategories();
                GetManufacts();
            }
        }


        private void ShowCustomer()
        {
            string Query = "select * from ProductTb1";
            ProductList.DataSource = Con.GetData(Query);
            ProductList.DataBind();
            //ProductList.HeaderRow.Cells[1].Text = "序号";
            //ProductList.HeaderRow.Cells[2].Text = "商品名称";
            //ProductList.HeaderRow.Cells[3].Text = "生产商";
            //ProductList.HeaderRow.Cells[4].Text = "商品类目";
            //ProductList.HeaderRow.Cells[5].Text = "库存总量";
            //ProductList.HeaderRow.Cells[5].Text = "商品单价";
        }

        private void GetCategories()
        {
            string Query = "select * from CategoryTb1";
            var dt = Con.GetData(Query);

            PCatCb.DataTextField = Con.GetData(Query).Columns["CatName"].ToString();
            PCatCb.DataTextField = Con.GetData(Query).Columns["CatId"].ToString();
            PCatCb.DataSource = Con.GetData(Query);
            PCatCb.DataBind();
        }

        private void GetManufacts()
        {
            string Query = "select * from ManufactorTb1";
            PManufactCb.DataTextField = Con.GetData(Query).Columns["ManufactName"].ToString();
            PManufactCb.DataTextField = Con.GetData(Query).Columns["ManufactId"].ToString();
            PManufactCb.DataSource = Con.GetData(Query);
            PManufactCb.DataBind();
        }

        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (PNameTb.Value == "" || PManufactCb.SelectedIndex == -1 || PCatCb.SelectedIndex == -1 || PriceTb.Value == "" || QtyTb.Value == "")
                {
                    ErrMsg.Text = "信息缺失";
                }
                else
                {
                    string PName = PNameTb.Value;
                    string PManufact = PManufactCb.SelectedValue.ToString();
                    string PCat = PCatCb.SelectedValue.ToString();
                    int Price = Convert.ToInt32(PriceTb.Value);
                    int Qty = Convert.ToInt32(QtyTb.Value);

                    string Query = "insert into ProductTb1 values('{0}','{1}','{2}','{3}','{4}')";
                    Query = string.Format(Query, PName, PManufact, PCat, Price, Qty);
                    Con.SetData(Query);
                    ShowCustomer();
                    ErrMsg.Text = "用户信息已添加！";
                    PNameTb.Value = "";
                    PManufactCb.SelectedIndex = -1;
                    PCatCb.SelectedIndex = -1;
                    PriceTb.Value = "";
                    QtyTb.Value = "";
                }
            }
            catch (Exception Ex)
            {
                ErrMsg.Text = Ex.Message;
            }
        }

        int key = 0;
        protected void ProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            PNameTb.Value = ProductList.SelectedRow.Cells[2].Text;
            PManufactCb.SelectedValue= ProductList.SelectedRow.Cells[3].Text;
            PCatCb.SelectedValue= ProductList.SelectedRow.Cells[4].Text;
            QtyTb.Value = ProductList.SelectedRow.Cells[5].Text;
            PriceTb.Value = ProductList.SelectedRow.Cells[6].Text;
            if (PNameTb.Value == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(ProductList.SelectedRow.Cells[1].Text);
            }
        }

        protected void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (PNameTb.Value == "" || PManufactCb.SelectedIndex == -1 || PCatCb.SelectedIndex == -1 || PriceTb.Value == "" || QtyTb.Value == "")
                {
                    ErrMsg.Text = "信息缺失";
                }
                else
                {
                    string PName = PNameTb.Value;
                    string PManufact = PManufactCb.SelectedValue.ToString();
                    string PCat = PCatCb.SelectedValue.ToString();
                    int Price = Convert.ToInt32(PriceTb.Value);
                    int Quantity = Convert.ToInt32(QtyTb.Value);

                    string Query = "update ProductTb1 set PName='{0}',PManufact = '{1}', PCategory = '{2}', PQty = '{3}',pprice = '{4}' where Pid = '{5}'";
                    Query = string.Format(Query, PName, PManufact, PCat, Quantity, Price, ProductList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowCustomer();
                    ErrMsg.Text = "用户信息已添加！";
                    PNameTb.Value = "";
                    PManufactCb.SelectedIndex = -1;
                    PCatCb.SelectedIndex = -1;
                    PriceTb.Value = "";
                    QtyTb.Value = "";
                }
            }
            catch (Exception Ex)
            {
                ErrMsg.Text = Ex.Message;
            }
        }

        protected void DeleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (PNameTb.Value == "" || PManufactCb.SelectedIndex == -1 || PCatCb.SelectedIndex == -1 || PriceTb.Value == "" || QtyTb.Value == "")
                {
                    ErrMsg.Text = "信息缺失";
                }
                else
                {
                    string PName = PNameTb.Value;
                    string PManufact = PManufactCb.SelectedValue.ToString();
                    string PCat = PCatCb.SelectedValue.ToString();
                    int Price = Convert.ToInt32(PriceTb.Value);
                    int Quantity = Convert.ToInt32(QtyTb.Value);

                    string Query = "Delete from ProductTb1 where Pid = '{0}'";
                    Query = string.Format(Query, ProductList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowCustomer();
                    ErrMsg.Text = "用户信息已删除！";
                    PNameTb.Value = "";
                    PManufactCb.SelectedIndex = -1;
                    PCatCb.SelectedIndex = -1;
                    PriceTb.Value = "";
                    QtyTb.Value = "";
                }
            }
            catch (Exception Ex)
            {
                ErrMsg.Text = Ex.Message;
            }
        }
    }
}