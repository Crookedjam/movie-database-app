using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2200_GardnerA_Participation04
{
    public partial class LocalPhoneForm : Form
    {
        /// <summary>
        /// Initializes the LocalPhoneForm and its components.
        /// </summary>
        public LocalPhoneForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Saves changes made to the PhoneNumber table in the database.
        /// </summary>
        private void phoneNumberBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.phoneNumberBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.phoneDbDataSet);

        }

        /// <summary>
        /// Loads phone number data into the dataset when the form opens.
        /// </summary>
        private void LocalPhoneForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phoneDbDataSet.PhoneNumber' table. You can move, or remove it, as needed.
            this.phoneNumberTableAdapter.Fill(this.phoneDbDataSet.PhoneNumber);

        }

        /// <summary>
        /// Didnt use but the program kept breaking when i removed it
        /// </summary>
        private void LblFN_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Searches for phone records that match the entered first name.
        /// </summary>
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            this.phoneNumberTableAdapter.FillByFNAME
                (this.phoneDbDataSet.PhoneNumber, TxtBoxSearchFN.Text);
        }

        /// <summary>
        /// Sorts phone records alphabetically by last name.
        /// </summary>
        private void BtnSortLN_Click(object sender, EventArgs e)
        {
            this.phoneNumberTableAdapter.SortByLastName
                (this.phoneDbDataSet.PhoneNumber);
        }

        /// <summary>
        /// Displays phone records for individuals older than 30 years of age.
        /// </summary>
        private void BtnAge30_Click(object sender, EventArgs e)
        {
            this.phoneNumberTableAdapter.FillByAgeGreater30
                (this.phoneDbDataSet.PhoneNumber);
        }

        /// <summary>
        /// Calculates and displays the average age of all records.
        /// </summary>
        private void BtnAverageAge_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"The average age is: {this.phoneNumberTableAdapter.AverageAge().Value.ToString("N2")}");
        }

        /// <summary>
        /// Reloads all phone records and clears any filters or search results.
        /// </summary>
        private void BtnClear_Click(object sender, EventArgs e)
        {
            LocalPhoneForm_Load(sender, e);
        }

        /// <summary>
        /// Didnt use but the program kept breaking when i removed it
        /// </summary>
        private void GbSearch_Enter(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Didnt use but the program kept breaking when i removed it
        /// </summary>
        private void TxtBoxSearchFN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
