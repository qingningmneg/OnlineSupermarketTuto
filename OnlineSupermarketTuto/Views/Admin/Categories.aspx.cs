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
            CategoryList.HeaderRow.Cells[1].Text = "类目号";
            CategoryList.HeaderRow.Cells[2].Text = "商品类目名称";
            CategoryList.HeaderRow.Cells[3].Text = "详细信息";
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    string CName = CatNameTb.Value;
                    string CDesc = DescriptionTb.Value;

                    string Query = "insert into CategoryTb1 values('{0}','{1}')";
                    Query = string.Format(Query, CName, CDesc);
                    Con.SetData(Query);
                    ShowCategories();
                    ErrMsg.Text = "商品类目信息已添加！";
                    CatNameTb.Value = "";
                    DescriptionTb.Value = "";
                }
            }
            catch (Exception Ex)
            {
                ErrMsg.Text = Ex.Message;
            }
        }

        int key = 0;//是否被选中
        /// <summary>
        /// 选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ManufactList_SelectedIndexChanged(object sender, EventArgs e)
        {
            CatNameTb.Value = CategoryList.SelectedRow.Cells[2].Text;
            DescriptionTb.Value = CategoryList.SelectedRow.Cells[3].Text;
            if (CatNameTb.Value == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(CategoryList.SelectedRow.Cells[1].Text);
            }
        }

        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatNameTb.Value == "" || DescriptionTb.Value == "")
                {
                    ErrMsg.Text = "信息缺失";
                }
                else
                {
                    string CName = CatNameTb.Value;
                    string CDesc = DescriptionTb.Value;

                    string Query = "update CategoryTb1 set CatName = '{0}',CatDescription = '{1}' where CatId='{2}'";
                    Query = string.Format(Query, CName, CDesc, CategoryList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowCategories();
                    ErrMsg.Text = "商品类目信息已更新！";
                    CatNameTb.Value = "";
                    DescriptionTb.Value = "";
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
                if (CatNameTb.Value == "" || DescriptionTb.Value == "")
                {
                    ErrMsg.Text = "信息缺失";
                }
                else
                {
                    string CName = CatNameTb.Value;
                    string CDesc = DescriptionTb.Value;

                    string Query = "delete from CategoryTb1 where CatId='{0}'";
                    Query = string.Format(Query, CategoryList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowCategories();
                    ErrMsg.Text = "商品类目信息删除成功！";
                    CatNameTb.Value = "";
                    DescriptionTb.Value = "";
                }
            }
            catch (Exception Ex)
            {
                ErrMsg.Text = Ex.Message;
            }
        }
    }
}