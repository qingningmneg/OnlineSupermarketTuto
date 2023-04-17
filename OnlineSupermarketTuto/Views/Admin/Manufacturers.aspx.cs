using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineSupermarketTuto.Views.Admin
{
    public partial class Suppliers : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
            ShowManufactors();
        }

        private void ShowManufactors()
        {
            string Query = "select Manufactid as 序号,ManufactName as 生产商名称,ManufactPermNum as 生产许可证号,ManufactPlace as 生产产地 from ManufactorTb1";
            ManufactList.DataSource = Con.GetData(Query);
            ManufactList.DataBind();
        }

        public static int key = 0;

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MNameTb.Value == "" || PermNumTb.Value == "" || PlaceCb.SelectedIndex == -1)
                {
                    ErrMsg.Text = "信息缺失";
                }
                else
                {
                    string MName = MNameTb.Value;
                    string PermNum = PermNumTb.Value;
                    string Place = PlaceCb.SelectedItem.ToString();

                    string Query = "insert into ManufactorTb1 values('{0}','{1}','{2}')";
                    Query = string.Format(Query, MName, PermNum, Place);
                    Con.SetData(Query);
                    ShowManufactors();
                    ErrMsg.Text = "供应商信息已添加！";
                }
            }
            catch (Exception Ex)
            {
                ErrMsg.Text = Ex.Message;
            }
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (key == 0)
                {
                    ErrMsg.Text = "请选择要删除的信息";
                    return;
                }
                if (MNameTb.Value == "" || PermNumTb.Value == "" || PlaceCb.SelectedIndex == -1)
                {
                    ErrMsg.Text = "信息缺失";
                }
                else
                {
                    string MName = MNameTb.Value;
                    string PermNum = PermNumTb.Value;
                    string Place = PlaceCb.SelectedItem.ToString();

                    string Query = "delete from ManufactorTb1 where ManufactId = '{0}'";
                    Query = string.Format(Query,  ManufactList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowManufactors();
                    ErrMsg.Text = "供应商信息已删除！";
                    MNameTb.Value = "";
                    PermNumTb.Value = "";
                    key = 0;
                }
            }
            catch
            {
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
                if (key == 0)
                {
                    ErrMsg.Text = "请选择要编辑的信息";
                    return;
                }
                if (MNameTb.Value == "" || PermNumTb.Value == "" || PlaceCb.SelectedIndex == -1)
                {
                    ErrMsg.Text = "信息缺失";
                }
                else
                {
                    string MName = MNameTb.Value;
                    string PermNum = PermNumTb.Value;
                    string Place = PlaceCb.SelectedItem.ToString();

                    string Query = "update ManufactorTb1 set ManufactName ='{0}',ManufactPermNum = '{1}',ManufactPlace = '{2}'where ManufactId = '{3}'";
                    Query = string.Format(Query, MName, PermNum, Place, ManufactList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowManufactors();
                    ErrMsg.Text = "供应商信息已更新！";
                    MNameTb.Value = "";
                    PermNumTb.Value = "";
                    key = 0;
                }
            }
            catch
            {
            }
        }

        
        protected void ManufactList_SelectedIndexChanged(object sender, EventArgs e)
        {
            MNameTb.Value = ManufactList.SelectedRow.Cells[2].Text;
            PermNumTb.Value = ManufactList.SelectedRow.Cells[3].Text;
            PlaceCb.SelectedValue = ManufactList.SelectedRow.Cells[4].Text;
            if (MNameTb.Value == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(ManufactList.SelectedRow.Cells[1].Text);
            }
        }
    }
}