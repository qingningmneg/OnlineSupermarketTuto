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
            string Query = "select * from CategoryTb1";
            CategoryList.DataSource = Con.GetData(Query);
            CategoryList.DataBind();
        }

        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatNameTb.Value == "" || DescriptionTb.Value == "")
                {
                    ErrMsg.Text = "信息缺失";
                }
                else
                {
                    //string MName = MNameTb.Value;
                    //string PermNum = PermNumTb.Value;
                    //string Place = PlaceCb.SelectedItem.ToString();

                    //string Query = "insert into ManufactorTb1 values('{0}','{1}','{2}')";
                    //Query = string.Format(Query, MName, PermNum, Place);
                    //Con.SetData(Query);
                    //ShowManufactors();
                    ErrMsg.Text = "供应商信息已添加！";
                }
            }
            catch (Exception Ex)
            {
                ErrMsg.Text = Ex.Message;
            }
        }
    }
}