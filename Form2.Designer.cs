namespace Customers
{
    partial class Form2
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
            System.Windows.Forms.Label movieIDLabel;
            System.Windows.Forms.Label ratingLabel;
            System.Windows.Forms.Label tittleLabel;
            System.Windows.Forms.Label yearLabel;
            System.Windows.Forms.Label rental_CostLabel;
            System.Windows.Forms.Label copiesLabel;
            System.Windows.Forms.Label plotLabel;
            System.Windows.Forms.Label genreLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.customersDataSet = new Customers.CustomersDataSet();
            this.moviesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moviesTableAdapter = new Customers.CustomersDataSetTableAdapters.MoviesTableAdapter();
            this.tableAdapterManager = new Customers.CustomersDataSetTableAdapters.TableAdapterManager();
            this.moviesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.moviesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.moviesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieIDTextBox = new System.Windows.Forms.TextBox();
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.tittleTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.rental_CostTextBox = new System.Windows.Forms.TextBox();
            this.copiesTextBox = new System.Windows.Forms.TextBox();
            this.plotTextBox = new System.Windows.Forms.TextBox();
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2_home = new System.Windows.Forms.Button();
            movieIDLabel = new System.Windows.Forms.Label();
            ratingLabel = new System.Windows.Forms.Label();
            tittleLabel = new System.Windows.Forms.Label();
            yearLabel = new System.Windows.Forms.Label();
            rental_CostLabel = new System.Windows.Forms.Label();
            copiesLabel = new System.Windows.Forms.Label();
            plotLabel = new System.Windows.Forms.Label();
            genreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingNavigator)).BeginInit();
            this.moviesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // movieIDLabel
            // 
            movieIDLabel.AutoSize = true;
            movieIDLabel.Location = new System.Drawing.Point(27, 111);
            movieIDLabel.Name = "movieIDLabel";
            movieIDLabel.Size = new System.Drawing.Size(53, 13);
            movieIDLabel.TabIndex = 2;
            movieIDLabel.Text = "Movie ID:";
            // 
            // ratingLabel
            // 
            ratingLabel.AutoSize = true;
            ratingLabel.Location = new System.Drawing.Point(27, 137);
            ratingLabel.Name = "ratingLabel";
            ratingLabel.Size = new System.Drawing.Size(41, 13);
            ratingLabel.TabIndex = 4;
            ratingLabel.Text = "Rating:";
            // 
            // tittleLabel
            // 
            tittleLabel.AutoSize = true;
            tittleLabel.Location = new System.Drawing.Point(27, 163);
            tittleLabel.Name = "tittleLabel";
            tittleLabel.Size = new System.Drawing.Size(33, 13);
            tittleLabel.TabIndex = 6;
            tittleLabel.Text = "Tittle:";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new System.Drawing.Point(27, 189);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new System.Drawing.Size(32, 13);
            yearLabel.TabIndex = 8;
            yearLabel.Text = "Year:";
            // 
            // rental_CostLabel
            // 
            rental_CostLabel.AutoSize = true;
            rental_CostLabel.Location = new System.Drawing.Point(27, 215);
            rental_CostLabel.Name = "rental_CostLabel";
            rental_CostLabel.Size = new System.Drawing.Size(65, 13);
            rental_CostLabel.TabIndex = 10;
            rental_CostLabel.Text = "Rental Cost:";
            // 
            // copiesLabel
            // 
            copiesLabel.AutoSize = true;
            copiesLabel.Location = new System.Drawing.Point(27, 241);
            copiesLabel.Name = "copiesLabel";
            copiesLabel.Size = new System.Drawing.Size(42, 13);
            copiesLabel.TabIndex = 12;
            copiesLabel.Text = "Copies:";
            // 
            // plotLabel
            // 
            plotLabel.AutoSize = true;
            plotLabel.Location = new System.Drawing.Point(27, 267);
            plotLabel.Name = "plotLabel";
            plotLabel.Size = new System.Drawing.Size(28, 13);
            plotLabel.TabIndex = 14;
            plotLabel.Text = "Plot:";
            // 
            // genreLabel
            // 
            genreLabel.AutoSize = true;
            genreLabel.Location = new System.Drawing.Point(27, 293);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new System.Drawing.Size(39, 13);
            genreLabel.TabIndex = 16;
            genreLabel.Text = "Genre:";
            // 
            // customersDataSet
            // 
            this.customersDataSet.DataSetName = "CustomersDataSet";
            this.customersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // moviesBindingSource
            // 
            this.moviesBindingSource.DataMember = "Movies";
            this.moviesBindingSource.DataSource = this.customersDataSet;
            // 
            // moviesTableAdapter
            // 
            this.moviesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.MoviesTableAdapter = this.moviesTableAdapter;
            this.tableAdapterManager.RentedMoviesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Customers.CustomersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // moviesBindingNavigator
            // 
            this.moviesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.moviesBindingNavigator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.moviesBindingNavigator.BindingSource = this.moviesBindingSource;
            this.moviesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.moviesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.moviesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.moviesBindingNavigatorSaveItem});
            this.moviesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.moviesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.moviesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.moviesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.moviesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.moviesBindingNavigator.Name = "moviesBindingNavigator";
            this.moviesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.moviesBindingNavigator.Size = new System.Drawing.Size(1030, 25);
            this.moviesBindingNavigator.TabIndex = 0;
            this.moviesBindingNavigator.Text = "bindingNavigator1";
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
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // moviesBindingNavigatorSaveItem
            // 
            this.moviesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.moviesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("moviesBindingNavigatorSaveItem.Image")));
            this.moviesBindingNavigatorSaveItem.Name = "moviesBindingNavigatorSaveItem";
            this.moviesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.moviesBindingNavigatorSaveItem.Text = "Save Data";
            this.moviesBindingNavigatorSaveItem.Click += new System.EventHandler(this.moviesBindingNavigatorSaveItem_Click);
            // 
            // moviesDataGridView
            // 
            this.moviesDataGridView.AutoGenerateColumns = false;
            this.moviesDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.moviesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.moviesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.moviesDataGridView.DataSource = this.moviesBindingSource;
            this.moviesDataGridView.Location = new System.Drawing.Point(228, 64);
            this.moviesDataGridView.Name = "moviesDataGridView";
            this.moviesDataGridView.Size = new System.Drawing.Size(791, 220);
            this.moviesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MovieID";
            this.dataGridViewTextBoxColumn1.HeaderText = "MovieID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Rating";
            this.dataGridViewTextBoxColumn2.HeaderText = "Rating";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Tittle";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tittle";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Year";
            this.dataGridViewTextBoxColumn4.HeaderText = "Year";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Rental_Cost";
            this.dataGridViewTextBoxColumn5.HeaderText = "Rental_Cost";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Copies";
            this.dataGridViewTextBoxColumn6.HeaderText = "Copies";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Plot";
            this.dataGridViewTextBoxColumn7.HeaderText = "Plot";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Genre";
            this.dataGridViewTextBoxColumn8.HeaderText = "Genre";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // movieIDTextBox
            // 
            this.movieIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.moviesBindingSource, "MovieID", true));
            this.movieIDTextBox.Location = new System.Drawing.Point(98, 108);
            this.movieIDTextBox.Name = "movieIDTextBox";
            this.movieIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.movieIDTextBox.TabIndex = 3;
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.moviesBindingSource, "Rating", true));
            this.ratingTextBox.Location = new System.Drawing.Point(98, 134);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.Size = new System.Drawing.Size(100, 20);
            this.ratingTextBox.TabIndex = 5;
            // 
            // tittleTextBox
            // 
            this.tittleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.moviesBindingSource, "Tittle", true));
            this.tittleTextBox.Location = new System.Drawing.Point(98, 160);
            this.tittleTextBox.Name = "tittleTextBox";
            this.tittleTextBox.Size = new System.Drawing.Size(100, 20);
            this.tittleTextBox.TabIndex = 7;
            // 
            // yearTextBox
            // 
            this.yearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.moviesBindingSource, "Year", true));
            this.yearTextBox.Location = new System.Drawing.Point(98, 186);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(100, 20);
            this.yearTextBox.TabIndex = 9;
            this.yearTextBox.TextChanged += new System.EventHandler(this.yearTextBox_TextChanged);
            // 
            // rental_CostTextBox
            // 
            this.rental_CostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.moviesBindingSource, "Rental_Cost", true));
            this.rental_CostTextBox.Location = new System.Drawing.Point(98, 212);
            this.rental_CostTextBox.Name = "rental_CostTextBox";
            this.rental_CostTextBox.Size = new System.Drawing.Size(100, 20);
            this.rental_CostTextBox.TabIndex = 11;
            // 
            // copiesTextBox
            // 
            this.copiesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.moviesBindingSource, "Copies", true));
            this.copiesTextBox.Location = new System.Drawing.Point(98, 238);
            this.copiesTextBox.Name = "copiesTextBox";
            this.copiesTextBox.Size = new System.Drawing.Size(100, 20);
            this.copiesTextBox.TabIndex = 13;
            // 
            // plotTextBox
            // 
            this.plotTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.moviesBindingSource, "Plot", true));
            this.plotTextBox.Location = new System.Drawing.Point(98, 264);
            this.plotTextBox.Name = "plotTextBox";
            this.plotTextBox.Size = new System.Drawing.Size(100, 20);
            this.plotTextBox.TabIndex = 15;
            // 
            // genreTextBox
            // 
            this.genreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.moviesBindingSource, "Genre", true));
            this.genreTextBox.Location = new System.Drawing.Point(98, 290);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(100, 20);
            this.genreTextBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(25, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 36);
            this.label1.TabIndex = 18;
            this.label1.Text = "Movie Detail";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 329);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 20);
            this.textBox1.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(192, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 36);
            this.button1.TabIndex = 20;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2_home
            // 
            this.button2_home.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2_home.ForeColor = System.Drawing.Color.Blue;
            this.button2_home.Location = new System.Drawing.Point(911, 326);
            this.button2_home.Name = "button2_home";
            this.button2_home.Size = new System.Drawing.Size(75, 39);
            this.button2_home.TabIndex = 20;
            this.button2_home.Text = "Home";
            this.button2_home.UseVisualStyleBackColor = true;
            this.button2_home.Click += new System.EventHandler(this.button2_home_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1030, 377);
            this.Controls.Add(this.button2_home);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(movieIDLabel);
            this.Controls.Add(this.movieIDTextBox);
            this.Controls.Add(ratingLabel);
            this.Controls.Add(this.ratingTextBox);
            this.Controls.Add(tittleLabel);
            this.Controls.Add(this.tittleTextBox);
            this.Controls.Add(yearLabel);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(rental_CostLabel);
            this.Controls.Add(this.rental_CostTextBox);
            this.Controls.Add(copiesLabel);
            this.Controls.Add(this.copiesTextBox);
            this.Controls.Add(plotLabel);
            this.Controls.Add(this.plotTextBox);
            this.Controls.Add(genreLabel);
            this.Controls.Add(this.genreTextBox);
            this.Controls.Add(this.moviesDataGridView);
            this.Controls.Add(this.moviesBindingNavigator);
            this.Name = "Form2";
            this.Text = "Moviedetails";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingNavigator)).EndInit();
            this.moviesBindingNavigator.ResumeLayout(false);
            this.moviesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomersDataSet customersDataSet;
        private System.Windows.Forms.BindingSource moviesBindingSource;
        private CustomersDataSetTableAdapters.MoviesTableAdapter moviesTableAdapter;
        private CustomersDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator moviesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton moviesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView moviesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox movieIDTextBox;
        private System.Windows.Forms.TextBox ratingTextBox;
        private System.Windows.Forms.TextBox tittleTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox rental_CostTextBox;
        private System.Windows.Forms.TextBox copiesTextBox;
        private System.Windows.Forms.TextBox plotTextBox;
        private System.Windows.Forms.TextBox genreTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2_home;
    }
}