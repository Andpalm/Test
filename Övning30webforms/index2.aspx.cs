using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySQLLibrary;

namespace Övning30webforms
{
    public partial class index2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["id"] != null)
            {
                List<Adress> adresses = SQL.GetContactsAdresses(Request["id"]);
                foreach (Adress a in adresses)
                {
                    ListBoxAdresses.Items.Add($"{a.Street}, {a.City}");
                }
            }
            
        }
    }
}