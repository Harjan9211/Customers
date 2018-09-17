namespace Customers
{
    partial class Form4
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
            System.Windows.Forms.Label rMIDLabel;
            System.Windows.Forms.Label movielDFKLabel;
            System.Windows.Forms.Label custlDFKLabel;
            System.Windows.Forms.Label dateRentedLabel;
            System.Windows.Forms.Label dateReturnedLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.customersDataSet = new Customers.CustomersDataSet();
            this.rentedMoviesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentedMoviesTableAdapter = new Customers.CustomersDataSetTableAdapters.RentedMoviesTableAdapter();
            this.tableAdapterManager = new Customers.CustomersDataSetTableAdapters.TableAdapterManager();
            this.rentedMoviesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.rentedMoviesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.rMIDTextBox = new System.Windows.Forms.TextBox();
            this.movielDFKTextBox = new System.Windows.Forms.TextBox();
            this.custlDFKTextBox = new System.Windows.Forms.TextBox();
            this.dateRentedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateReturnedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.rentedMoviesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2_home = new System.Windows.Forms.Button();
            rMIDLabel = new System.Windows.Forms.Label();
            movielDFKLabel = new System.Windows.Forms.Label();
            custlDFKLabel = new System.Windows.Forms.Label();
            dateRentedLabel = new System.Windows.Forms.Label();
            dateReturnedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentedMoviesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentedMoviesBindingNavigator)).BeginInit();
            this.rentedMoviesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentedMoviesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // rMIDLabel
            // 
            rMIDLabel.AutoSize = true;
            rMIDLabel.Location = new System.Drawing.Point(35, 102);
            rMIDLabel.Name = "rMIDLabel";
            rMIDLabel.Size = new System.Drawing.Size(38, 13);
            rMIDLabel.TabIndex = 1;
            rMIDLabel.Text = "RMID:";
            // 
            // movielDFKLabel
            // 
            movielDFKLabel.AutoSize = true;
            movielDFKLabel.Location = new System.Drawing.Point(35, 128);
            movielDFKLabel.Name = "movielDFKLabel";
            movielDFKLabel.Size = new System.Drawing.Size(65, 13);
            movielDFKLabel.TabIndex = 3;
            movielDFKLabel.Text = "Moviel DFK:";
            // 
            // custlDFKLabel
            // 
            custlDFKLabel.AutoSize = true;
            custlDFKLabel.Location = new System.Drawing.Point(35, 154);
            custlDFKLabel.Name = "custlDFKLabel";
            custlDFKLabel.Size = new System.Drawing.Size(57, 13);
            custlDFKLabel.TabIndex = 5;
            custlDFKLabel.Text = "Custl DFK:";
            // 
            // dateRentedLabel
            // 
            dateRentedLabel.AutoSize = true;
            dateRentedLabel.Location = new System.Drawing.Point(35, 181);
            dateRentedLabel.Name = "dateRentedLabel";
            dateRentedLabel.Size = new System.Drawing.Size(71, 13);
            dateRentedLabel.TabIndex = 7;
            dateRentedLabel.Text = "Date Rented:";
            // 
            // dateReturnedLabel
            // 
            dateReturnedLabel.AutoSize = true;
            dateReturnedLabel.Location = new System.Drawing.Point(35, 207);
            dateReturnedLabel.Name = "dateReturnedLabel";
            dateReturnedLabel.Size = new System.Drawing.Size(80, 13);
            dateReturnedLabel.TabIndex = 9;
            dateReturnedLabel.Text = "Date Returned:";
            // 
            // customersDataSet
            // 
            this.customersDataSet.DataSetName = "CustomersDataSet";
            this.customersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rentedMoviesBindingSource
            // 
            this.rentedMoviesBindingSource.DataMember = "RentedMovies";
            this.rentedMoviesBindingSource.DataSource = this.customersDataSet;
            // 
            // rentedMoviesTableAdapter
            // 
            this.rentedMoviesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.MoviesTableAdapter = null;
            this.tableAdapterManager.RentedMoviesTableAdapter = this.rentedMoviesTableAdapter;
            this.tableAdapterManager.UpdateOrder = Customers.CustomersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // rentedMoviesBindingNavigator
            // 
            this.rentedMoviesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.rentedMoviesBindingNavigator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rentedMoviesBindingNavigator.BindingSource = this.rentedMoviesBindingSource;
            this.rentedMoviesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.rentedMoviesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.rentedMoviesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem,
            this.rentedMoviesBindingNavigatorSaveItem});
            this.rentedMoviesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.rentedMoviesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.rentedMoviesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.rentedMoviesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.rentedMoviesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.rentedMoviesBindingNavigator.Name = "rentedMoviesBindingNavigator";
            this.rentedMoviesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.rentedMoviesBindingNavigator.Size = new System.Drawing.Size(935, 25);
            this.rentedMoviesBindingNavigator.TabIndex = 0;
            this.rentedMoviesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.bindingNavigatorMoveLastItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // rentedMoviesBindingNavigatorSaveItem
            // 
            this.rentedMoviesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rentedMoviesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("rentedMoviesBindingNavigatorSaveItem.Image")));
            this.rentedMoviesBindingNavigatorSaveItem.Name = "rentedMoviesBindingNavigatorSaveItem";
            this.rentedMoviesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.rentedMoviesBindingNavigatorSaveItem.Text = "Save Data";
            this.rentedMoviesBindingNavigatorSaveItem.Click += new System.EventHandler(this.rentedMoviesBindingNavigatorSaveItem_Click);
            // 
            // rMIDTextBox
            // 
            this.rMIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rentedMoviesBindingSource, "RMID", true));
            this.rMIDTextBox.Location = new System.Drawing.Point(121, 99);
            this.rMIDTextBox.Name = "rMIDTextBox";
            this.rMIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.rMIDTextBox.TabIndex = 2;
            // 
            // movielDFKTextBox
            // 
            this.movielDFKTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rentedMoviesBindingSource, "MovielDFK", true));
            this.movielDFKTextBox.Location = new System.Drawing.Point(121, 125);
            this.movielDFKTextBox.Name = "movielDFKTextBox";
            this.movielDFKTextBox.Size = new System.Drawing.Size(200, 20);
            this.movielDFKTextBox.TabIndex = 4;
            // 
            // custlDFKTextBox
            // 
            this.custlDFKTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rentedMoviesBindingSource, "CustlDFK", true));
            this.custlDFKTextBox.Location = new System.Drawing.Point(121, 151);
            this.custlDFKTextBox.Name = "custlDFKTextBox";
            this.custlDFKTextBox.Size = new System.Drawing.Size(200, 20);
            this.custlDFKTextBox.TabIndex = 6;
            // 
            // dateRentedDateTimePicker
            // 
            this.dateRentedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.rentedMoviesBindingSource, "DateRented", true));
            this.dateRentedDateTimePicker.Location = new System.Drawing.Point(121, 177);
            this.dateRentedDateTimePicker.Name = "dateRentedDateTimePicker";
            this.dateRentedDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateRentedDateTimePicker.TabIndex = 8;
            // 
            // dateReturnedDateTimePicker
            // 
            this.dateReturnedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.rentedMoviesBindingSource, "DateReturned", true));
            this.dateReturnedDateTimePicker.Location = new System.Drawing.Point(121, 203);
            this.dateReturnedDateTimePicker.Name = "dateReturnedDateTimePicker";
            this.dateReturnedDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateReturnedDateTimePicker.TabIndex = 10;
            // 
            // rentedMoviesDataGridView
            // 
            this.rentedMoviesDataGridView.AutoGenerateColumns = false;
            this.rentedMoviesDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.rentedMoviesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentedMoviesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.rentedMoviesDataGridView.DataSource = this.rentedMoviesBindingSource;
            this.rentedMoviesDataGridView.Location = new System.Drawing.Point(349, 28);
            this.rentedMoviesDataGridView.Name = "rentedMoviesDataGridView";
            this.rentedMoviesDataGridView.Size = new System.Drawing.Size(557, 220);
            this.rentedMoviesDataGridView.TabIndex = 11;
            this.rentedMoviesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rentedMoviesDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "RMID";
            this.dataGridViewTextBoxColumn1.HeaderText = "RMID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MovielDFK";
            this.dataGridViewTextBoxColumn2.HeaderText = "MovielDFK";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CustlDFK";
            this.dataGridViewTextBoxColumn3.HeaderText = "CustlDFK";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DateRented";
            this.dataGridViewTextBoxColumn4.HeaderText = "DateRented";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DateReturned";
            this.dataGridViewTextBoxColumn5.HeaderText = "DateReturned";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(40, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 39);
            this.label1.TabIndex = 12;
            this.label1.Text = "Rented Movie Detail";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 260);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 20);
            this.textBox1.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(221, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 14;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2_home
            // 
            this.button2_home.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2_home.ForeColor = System.Drawing.Color.Blue;
            this.button2_home.Location = new System.Drawing.Point(831, 294);
            this.button2_home.Name = "button2_home";
            this.button2_home.Size = new System.Drawing.Size(75, 35);
            this.button2_home.TabIndex = 14;
            this.button2_home.Text = "Home";
            this.button2_home.UseVisualStyleBackColor = true;
            this.button2_home.Click += new System.EventHandler(this.button2_home_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(935, 347);
            this.Controls.Add(this.button2_home);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rentedMoviesDataGridView);
            this.Controls.Add(rMIDLabel);
            this.Controls.Add(this.rMIDTextBox);
            this.Controls.Add(movielDFKLabel);
            this.Controls.Add(this.movielDFKTextBox);
            this.Controls.Add(custlDFKLabel);
            this.Controls.Add(this.custlDFKTextBox);
            this.Controls.Add(dateRentedLabel);
            this.Controls.Add(this.dateRentedDateTimePicker);
            this.Controls.Add(dateReturnedLabel);
            this.Controls.Add(this.dateReturnedDateTimePicker);
            this.Controls.Add(this.rentedMoviesBindingNavigator);
            this.Name = "Form4";
            this.Text = "RentedMovieDetails";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentedMoviesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentedMoviesBindingNavigator)).EndInit();
            this.rentedMoviesBindingNavigator.ResumeLayout(false);
            this.rentedMoviesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentedMoviesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomersDataSet customersDataSet;
        private System.Windows.Forms.BindingSource rentedMoviesBindingSource;
        private CustomersDataSetTableAdapters.RentedMoviesTableAdapter rentedMoviesTableAdapter;
        private CustomersDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator rentedMoviesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton rentedMoviesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox rMIDTextBox;
        private System.Windows.Forms.TextBox movielDFKTextBox;
        private System.Windows.Forms.TextBox custlDFKTextBox;
        private System.Windows.Forms.DateTimePicker dateRentedDateTimePicker;
        private System.Windows.Forms.DateTimePicker dateReturnedDateTimePicker;
        private System.Windows.Forms.DataGridView rentedMoviesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2_home;
    }
}