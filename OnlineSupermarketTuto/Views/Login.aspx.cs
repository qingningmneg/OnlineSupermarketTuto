using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineSupermarketTuto.Assets
{
    public partial class Login : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            var user_no = txtUserName.Value.ToString();
            var user_pwd = txtUserPwd.Value.ToString();
            if (user_no == "" || user_pwd == "")
            {
                ErrMsg.Text = "用户名或密码不能为空";
                return;
            }

            var dt = Con.GetData($@"select * from CustomerTb1 where user_no='{user_no}' and user_pwd='{user_pwd}'");
            if (dt != null && dt.Rows.Count > 0)
            {
                Response.Redirect("Admin/Categories.aspx");
            }
            else
            {
                ErrMsg.Text = "用户名或者密码错误";
            }
        }
    }
}