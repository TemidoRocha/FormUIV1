using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FormUIV1
{
    public partial class Dashboard : Form
    {
        List<Person> people = new List<Person>();
        public Dashboard()
        {
            InitializeComponent();

            UpdateBinding();
        }

        private void UpdateBinding()
        {
            peopleFoundListBox.DataSource = people;
            peopleFoundListBox.DisplayMember = "FullInfo";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            people = db.GetPeople(lastNameText.Text);

            UpdateBinding();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void InsertRecorButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.InsertPerson(firstNameInsText.Text, lastNameInsText.Text, emailInsText.Text, phoneNumberInsText.Text);

            firstNameInsText.Text = "";
            lastNameInsText.Text = "";
            emailInsText.Text = "";
            phoneNumberInsText.Text = "";

        }
    }
}
