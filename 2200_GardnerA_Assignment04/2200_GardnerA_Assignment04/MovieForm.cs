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
    /// Displays movie information and allows the user to search,
    /// sort, and view movie category counts.
    /// </summary>
    public partial class MovieForm : Form
    {
        /// <summary>
        /// Initializes the Movie form.
        /// </summary>
        public MovieForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Saves any changes made to the movie data.
        /// </summary>
        private void movieBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.movieBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iNFO2200CrandallDataSet);

        }

        /// <summary>
        /// Loads all movie records when the form opens.
        /// </summary>
        private void MovieForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iNFO2200CrandallDataSet.Movie' table. You can move, or remove it, as needed.
            this.movieTableAdapter.Fill(this.iNFO2200CrandallDataSet.Movie);

        }

        /// <summary>
        /// Sorts movie titles from A to Z.
        /// </summary>
        private void BtnSortAZ_Click(object sender, EventArgs e)
        {
            this.movieTableAdapter.SortByAZ
                (this.iNFO2200CrandallDataSet.Movie);
        }

        /// <summary>
        /// Sorts movie titles from Z to A.
        /// </summary>
        private void BtnSortZA_Click(object sender, EventArgs e)
        {
            this.movieTableAdapter.SortByZA
                (this.iNFO2200CrandallDataSet.Movie);
        }

        /// <summary>
        /// Searches movie titles within the first 20 movie IDs.
        /// </summary>
        private void BtnSortF20_Click(object sender, EventArgs e)
        {
            this.movieTableAdapter.FillByFirst20
                (this.iNFO2200CrandallDataSet.Movie, textBoxSearch.Text);
        }

        /// <summary>
        /// Opens the Movie Categories form.
        /// </summary>
        private void BtnCountCategories_Click(object sender, EventArgs e)
        {
            // Display category counts in a separate window.
            MovieCategoriesForm frm = new MovieCategoriesForm();
            frm.ShowDialog();
        }
    }
}
