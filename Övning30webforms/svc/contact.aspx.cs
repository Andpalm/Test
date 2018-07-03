using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySQLLibrary;
using Newtonsoft.Json;

namespace Övning30webforms.svc
{
    public partial class contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Contact> contacts = SQL.ImportData();

            JSONLiteral.Text = JsonConvert.SerializeObject(contacts);

            if (Request["action"] != null)
            {
                string action = Request["action"].ToString();
                if (action == "addcontact")
                {
                    string firstName = Request["firstname"];
                    string lastName = Request["lastname"];
                    string ssn = Request["ssn"];

                    SQL.AddContact(firstName, lastName, ssn);

                    JSONLiteral.Text = JsonConvert.SerializeObject("ok");
                }
            }
        }
    }
}