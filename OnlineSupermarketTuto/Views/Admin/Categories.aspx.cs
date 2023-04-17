using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineSupermarketTuto.Views.Admin
{
    public partial class Categories : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
            ShowCategories();
        }

        /// <summary>
        /// 刷新
        /// </summary>
        private void ShowCategories()
        {
            string Query = "select Manufactid as 序号,ManufactName as 生产商名称,ManufactPermNum as 生产许可证号,ManufactPlace as 生产产地 from ManufactorTb1";
            CategoryList.DataSource = Con.GetData(Query);
            CategoryList.DataBind();
        }

        protected void SaveBtn_Click(object sender, EventArgs e)
        {

        }
    }
}