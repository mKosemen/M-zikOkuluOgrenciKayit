using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MüzikOkuluOgrenciKayit
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            DataSetTableAdapters.ÖğrencilerTableAdapter dt = new DataSetTableAdapters.ÖğrencilerTableAdapter();
            dt.StudentAdd(TextBox1.Text, TextBox3.Text, TextBox4.Text, DropDownList1.SelectedItem.ToString(), DropDownList2.SelectedItem.ToString());

        }
    }
}