using System;
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
            //ProductList.HeaderRow.Cells[2].Text = "用户名";
            //ProductList.HeaderRow.Cells[3].Text = "邮箱";
            //ProductList.HeaderRow.Cells[4].Text = "电话号码";
            //ProductList.HeaderRow.Cells[5].Text = "地址";
        }

        private void GetCategories() {
            string Query = "select * from CategoryTb1";
            PCatCb.DataSource = Con.GetData(Query).Columns["CatName"].ToString();
            PCatCb.DataSource = Con.GetData(Query).Columns["CatId"].ToString();
            PCatCb.DataSource = Con.GetData(Query);
            PCatCb.DataBind();
        }

        private void GetManufacts()
        {
            string Query = "select * from ManufactsTb1";
            PManufactCb.DataSource = Con.GetData(Query).Columns["ManufactName"].ToString();
            PManufactCb.DataSource = Con.GetData(Query).Columns["ManufactId"].ToString();
            PManufactCb.DataSource = Con.GetData(Query);
            PManufactCb.DataBind();
        }

        protected void SaveBtn_Click(object sender, EventArgs e)
        {

        }
    }
}