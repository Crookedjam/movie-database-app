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
    public partial class OnlineUVUPhoneNumsForm : Form
    {
        /// <summary>
        /// Initializes the OnlineUVUPhoneNumsForm and its components.
        /// </summary>
        public OnlineUVUPhoneNumsForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Saves changes made to the UVU phone number data sources.
        /// </summary>
        private void uVUPhoneNumsTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uVUPhoneNumsTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iNFO2200CrandallDataSet);

        }

        /// <summary>
        /// Loads UVU phone directory data into the datasets when the form opens.
        /// </summary>
        private void OnlineUVUPhoneNumsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_UVUPhoneNums__1_DataSet.UvuPhoneDirectory' table. You can move, or remove it, as needed.
            this.uvuPhoneDirectoryTableAdapter.Fill(this._UVUPhoneNums__1_DataSet.UvuPhoneDirectory);
            // TODO: This line of code loads data into the 'iNFO2200CrandallDataSet.UVUPhoneNumsTable' table. You can move, or remove it, as needed.
            this.uVUPhoneNumsTableTableAdapter.Fill(this.iNFO2200CrandallDataSet.UVUPhoneNumsTable);

        }

    }
}
