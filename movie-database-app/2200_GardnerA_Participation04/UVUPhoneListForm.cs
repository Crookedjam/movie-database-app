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
    public partial class UVUPhoneListForm : Form
    {
        /// <summary>
        /// Initializes the UVUPhonelistForm and its components.
        /// </summary>
        public UVUPhoneListForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Saves changes made to the UVU phone list data sources.
        /// </summary>
        private void uvuPhoneDirectoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uvuPhoneDirectoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._UVUPhoneNums__1_DataSet);

        }

        /// <summary>
        /// Loads the UVU phone directory data when the form opens.
        /// </summary>
        private void UVUPhoneListForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_UVUPhoneNums__1_DataSet.UvuPhoneDirectory' table. You can move, or remove it, as needed.
            this.uvuPhoneDirectoryTableAdapter.Fill(this._UVUPhoneNums__1_DataSet.UvuPhoneDirectory);

        }

    }
}
