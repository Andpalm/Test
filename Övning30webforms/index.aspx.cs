using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySQLLibrary;

namespace Övning30webforms
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                foreach (var p in SQL.ImportData())
                {
                    ListBoxContacts.Items.Add($"{p.FirstName} {p.LastName}");
                }
            }
        }

        protected void ListBoxContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxContacts.SelectedIndex >= 0)
            {
                Contact c = SQL.ImportData()[ListBoxContacts.SelectedIndex];
                TextBoxFirstname.Text = c.FirstName;
                TextBoxLastname.Text = c.LastName;
                TextBoxSSN.Text = c.SSN;
            }
        }

        protected void ButtonAddContact_Click(object sender, EventArgs e)
        {
            string firstname = TextBoxFirstname.Text;
            string lastname = TextBoxLastname.Text;
            string ssn = TextBoxSSN.Text;

            SQL.AddContact(firstname, lastname, ssn);
            ListBoxContacts.Items.Clear();

            foreach (var p in SQL.ImportData())
            {
                ListBoxContacts.Items.Add($"{p.FirstName} {p.LastName}");
            }

        }

        protected void ButtonUpdate_Click(object sender, EventArgs e)
        {
            string firstname = TextBoxFirstname.Text;
            string lastname = TextBoxLastname.Text;
            int id = int.Parse(SQL.ImportData()[ListBoxContacts.SelectedIndex].ID);

            SQL.UpdateContact(id, firstname, lastname);

            ListBoxContacts.Items.Clear();
            foreach (var p in SQL.ImportData())
            {
                ListBoxContacts.Items.Add($"{p.FirstName} {p.LastName}");
            }
        }

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            SQL.RemoveContact(int.Parse(SQL.ImportData()[ListBoxContacts.SelectedIndex].ID));

            TextBoxFirstname.Text = "";
            TextBoxLastname.Text = "";
            TextBoxSSN.Text = "";

            ListBoxContacts.Items.Clear();
            foreach (var p in SQL.ImportData())
            {
                ListBoxContacts.Items.Add($"{p.FirstName} {p.LastName}");
            }
        }

        protected void ButtonAdresses_Click(object sender, EventArgs e)
        {
            if (ListBoxContacts.SelectedIndex >= 0)
            {
                Contact c = SQL.ImportData()[ListBoxContacts.SelectedIndex];
                Server.Transfer("/index2.aspx?id=" + c.ID);
            }
        }
    }
}