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
    /// <summary>
    /// Initializes the LandingForm and its components.
    /// </summary>
    public partial class LandingForm : Form
    {
        public LandingForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Executes when the LandingForm is loaded.
        /// </summary>
        private void LandingForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Opens the Local Phone Numbers form as a dialog window.
        /// </summary>
        private void BtnLocalPhoneNums_Click(object sender, EventArgs e)
        {
            LocalPhoneForm localPhoneForm = new LocalPhoneForm();
            localPhoneForm.ShowDialog();
        }

        /// <summary>
        /// Opens the Imported Phone Numbers form as a dialog window.
        /// </summary>
        private void BtnImportedPhoneNums_Click(object sender, EventArgs e)
        {
            UVUPhoneListForm uVUPhoneListForm = new UVUPhoneListForm();
            uVUPhoneListForm.ShowDialog();
        }

        /// <summary>
        /// Opens the Online Phone Numbers form as a dialog window.
        /// </summary>
        private void BtnOnlinePhoneNums_Click(object sender, EventArgs e)
        {
            OnlineUVUPhoneNumsForm onlineUVUPhoneNumsForm = new OnlineUVUPhoneNumsForm();
            onlineUVUPhoneNumsForm.ShowDialog();
        }

        /// <summary>
        /// Closes the LandingForm.
        /// </summary>
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
