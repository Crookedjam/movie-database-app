using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2200_GardnerA_Assignment04
{
    /// <summary>
    /// Displays movie category counts.
    /// </summary>
    public partial class MovieCategoriesForm : Form
    {
        /// <summary>
        /// Initializes the Movie Categories form.
        /// </summary>
        public MovieCategoriesForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads the movie category counts when the form opens.
        /// </summary>
        private void MovieCatagories_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iNFO2200CrandallDataSet1.CountMovieCategory' table. You can move, or remove it, as needed.
            this.countMovieCategoryTableAdapter.Fill(this.iNFO2200CrandallDataSet1.CountMovieCategory);

        }

        /// <summary>
        /// Searches for a movie title entered by the user.
        /// </summary>
        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Use the text entered in the search box to filter results.
                this.fillByMovieTitleTableAdapter.Fill(this.iNFO2200CrandallDataSet1.FillByMovieTitle, valueToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                // Display an error message if the search fails.
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// Closes the Movie Categories form.
        /// </summary>
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
