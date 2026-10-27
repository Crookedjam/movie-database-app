namespace _2200_GardnerA_Participation04
{
    partial class LocalPhoneForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalPhoneForm));
            this.phoneNumberBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.phoneNumberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phoneDbDataSet = new _2200_GardnerA_Participation04.PhoneDbDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.phoneNumberBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.phoneNumberDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GbSearch = new System.Windows.Forms.GroupBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.LblFN = new System.Windows.Forms.Label();
            this.TxtBoxSearchFN = new System.Windows.Forms.TextBox();
            this.BtnSearchFN = new System.Windows.Forms.Button();
            this.TxtBoxFN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSortLN = new System.Windows.Forms.Button();
            this.phoneNumberTableAdapter = new _2200_GardnerA_Participation04.PhoneDbDataSetTableAdapters.PhoneNumberTableAdapter();
            this.tableAdapterManager = new _2200_GardnerA_Participation04.PhoneDbDataSetTableAdapters.TableAdapterManager();
            this.BtnAverageAge = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnAge30 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.phoneNumberBindingNavigator)).BeginInit();
            this.phoneNumberBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phoneNumberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneNumberDataGridView)).BeginInit();
            this.GbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // phoneNumberBindingNavigator
            // 
            this.phoneNumberBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.phoneNumberBindingNavigator.BindingSource = this.phoneNumberBindingSource;
            this.phoneNumberBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.phoneNumberBindingNavigator.DeleteItem = null;
            this.phoneNumberBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.phoneNumberBindingNavigatorSaveItem});
            this.phoneNumberBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.phoneNumberBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.phoneNumberBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.phoneNumberBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.phoneNumberBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.phoneNumberBindingNavigator.Name = "phoneNumberBindingNavigator";
            this.phoneNumberBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.phoneNumberBindingNavigator.Size = new System.Drawing.Size(710, 25);
            this.phoneNumberBindingNavigator.TabIndex = 0;
            this.phoneNumberBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // phoneNumberBindingSource
            // 
            this.phoneNumberBindingSource.DataMember = "PhoneNumber";
            this.phoneNumberBindingSource.DataSource = this.phoneDbDataSet;
            // 
            // phoneDbDataSet
            // 
            this.phoneDbDataSet.DataSetName = "PhoneDbDataSet";
            this.phoneDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // phoneNumberBindingNavigatorSaveItem
            // 
            this.phoneNumberBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.phoneNumberBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("phoneNumberBindingNavigatorSaveItem.Image")));
            this.phoneNumberBindingNavigatorSaveItem.Name = "phoneNumberBindingNavigatorSaveItem";
            this.phoneNumberBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.phoneNumberBindingNavigatorSaveItem.Text = "Save Data";
            this.phoneNumberBindingNavigatorSaveItem.Click += new System.EventHandler(this.phoneNumberBindingNavigatorSaveItem_Click);
            // 
            // phoneNumberDataGridView
            // 
            this.phoneNumberDataGridView.AllowUserToDeleteRows = false;
            this.phoneNumberDataGridView.AutoGenerateColumns = false;
            this.phoneNumberDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phoneNumberDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.phoneNumberDataGridView.DataSource = this.phoneNumberBindingSource;
            this.phoneNumberDataGridView.Location = new System.Drawing.Point(34, 39);
            this.phoneNumberDataGridView.Name = "phoneNumberDataGridView";
            this.phoneNumberDataGridView.Size = new System.Drawing.Size(601, 267);
            this.phoneNumberDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PID";
            this.dataGridViewTextBoxColumn1.HeaderText = "PID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 54;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FName";
            this.dataGridViewTextBoxColumn2.HeaderText = "FName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LName";
            this.dataGridViewTextBoxColumn3.HeaderText = "LName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn4.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Age";
            this.dataGridViewTextBoxColumn5.HeaderText = "Age";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // GbSearch
            // 
            this.GbSearch.Controls.Add(this.BtnSearch);
            this.GbSearch.Controls.Add(this.LblFN);
            this.GbSearch.Controls.Add(this.TxtBoxSearchFN);
            this.GbSearch.Location = new System.Drawing.Point(34, 323);
            this.GbSearch.Name = "GbSearch";
            this.GbSearch.Size = new System.Drawing.Size(307, 100);
            this.GbSearch.TabIndex = 4;
            this.GbSearch.TabStop = false;
            this.GbSearch.Text = "Search";
            this.GbSearch.Enter += new System.EventHandler(this.GbSearch_Enter);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(224, 46);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(68, 24);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // LblFN
            // 
            this.LblFN.AutoSize = true;
            this.LblFN.Location = new System.Drawing.Point(19, 27);
            this.LblFN.Name = "LblFN";
            this.LblFN.Size = new System.Drawing.Size(72, 16);
            this.LblFN.TabIndex = 1;
            this.LblFN.Text = "First Name";
            this.LblFN.Click += new System.EventHandler(this.LblFN_Click);
            // 
            // TxtBoxSearchFN
            // 
            this.TxtBoxSearchFN.Location = new System.Drawing.Point(22, 46);
            this.TxtBoxSearchFN.Name = "TxtBoxSearchFN";
            this.TxtBoxSearchFN.Size = new System.Drawing.Size(183, 22);
            this.TxtBoxSearchFN.TabIndex = 0;
            this.TxtBoxSearchFN.TextChanged += new System.EventHandler(this.TxtBoxSearchFN_TextChanged);
            // 
            // BtnSearchFN
            // 
            this.BtnSearchFN.Location = new System.Drawing.Point(0, 0);
            this.BtnSearchFN.Name = "BtnSearchFN";
            this.BtnSearchFN.Size = new System.Drawing.Size(75, 23);
            this.BtnSearchFN.TabIndex = 0;
            // 
            // TxtBoxFN
            // 
            this.TxtBoxFN.Location = new System.Drawing.Point(0, 0);
            this.TxtBoxFN.Name = "TxtBoxFN";
            this.TxtBoxFN.Size = new System.Drawing.Size(100, 22);
            this.TxtBoxFN.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // BtnSortLN
            // 
            this.BtnSortLN.Location = new System.Drawing.Point(379, 320);
            this.BtnSortLN.Name = "BtnSortLN";
            this.BtnSortLN.Size = new System.Drawing.Size(125, 54);
            this.BtnSortLN.TabIndex = 2;
            this.BtnSortLN.Text = "Sort by Last Name";
            this.BtnSortLN.Click += new System.EventHandler(this.BtnSortLN_Click);
            // 
            // phoneNumberTableAdapter
            // 
            this.phoneNumberTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PhoneNumberTableAdapter = this.phoneNumberTableAdapter;
            this.tableAdapterManager.UpdateOrder = _2200_GardnerA_Participation04.PhoneDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // BtnAverageAge
            // 
            this.BtnAverageAge.Location = new System.Drawing.Point(379, 380);
            this.BtnAverageAge.Name = "BtnAverageAge";
            this.BtnAverageAge.Size = new System.Drawing.Size(125, 54);
            this.BtnAverageAge.TabIndex = 2;
            this.BtnAverageAge.Text = "Average Age";
            this.BtnAverageAge.Click += new System.EventHandler(this.BtnAverageAge_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(510, 380);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(125, 54);
            this.BtnClear.TabIndex = 2;
            this.BtnClear.Text = "Clear";
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnAge30
            // 
            this.BtnAge30.Location = new System.Drawing.Point(510, 320);
            this.BtnAge30.Name = "BtnAge30";
            this.BtnAge30.Size = new System.Drawing.Size(125, 54);
            this.BtnAge30.TabIndex = 2;
            this.BtnAge30.Text = "Age > 30";
            this.BtnAge30.Click += new System.EventHandler(this.BtnAge30_Click);
            // 
            // LocalPhoneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 446);
            this.Controls.Add(this.BtnAge30);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnAverageAge);
            this.Controls.Add(this.BtnSortLN);
            this.Controls.Add(this.GbSearch);
            this.Controls.Add(this.phoneNumberDataGridView);
            this.Controls.Add(this.phoneNumberBindingNavigator);
            this.Name = "LocalPhoneForm";
            this.Text = "LocalPhoneForm";
            this.Load += new System.EventHandler(this.LocalPhoneForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.phoneNumberBindingNavigator)).EndInit();
            this.phoneNumberBindingNavigator.ResumeLayout(false);
            this.phoneNumberBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phoneNumberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneNumberDataGridView)).EndInit();
            this.GbSearch.ResumeLayout(false);
            this.GbSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PhoneDbDataSet phoneDbDataSet;
        private System.Windows.Forms.BindingSource phoneNumberBindingSource;
        private PhoneDbDataSetTableAdapters.PhoneNumberTableAdapter phoneNumberTableAdapter;
        private PhoneDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator phoneNumberBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton phoneNumberBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView phoneNumberDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.GroupBox GbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBoxFN;
        private System.Windows.Forms.Button BtnSearchFN;
        private System.Windows.Forms.Button BtnSortLN;
        private System.Windows.Forms.Label LblFN;
        private System.Windows.Forms.TextBox TxtBoxSearchFN;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnAverageAge;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnAge30;
    }
}