namespace p.hotel1
{
    partial class Mealmanager
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.breakfastDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lunchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dinnerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mEAL1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelDataSet2 = new p.hotel1.modelDataSet2();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.modelDataSet1 = new p.hotel1.modelDataSet1();
            this.mEALBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mEALTableAdapter = new p.hotel1.modelDataSet1TableAdapters.MEALTableAdapter();
            this.mEAL1TableAdapter = new p.hotel1.modelDataSet2TableAdapters.MEAL1TableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEAL1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEALBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dayDataGridViewTextBoxColumn,
            this.breakfastDataGridViewTextBoxColumn,
            this.lunchDataGridViewTextBoxColumn,
            this.dinnerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mEAL1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(799, 325);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dayDataGridViewTextBoxColumn
            // 
            this.dayDataGridViewTextBoxColumn.DataPropertyName = "Day";
            this.dayDataGridViewTextBoxColumn.HeaderText = "Day";
            this.dayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dayDataGridViewTextBoxColumn.Name = "dayDataGridViewTextBoxColumn";
            this.dayDataGridViewTextBoxColumn.Width = 125;
            // 
            // breakfastDataGridViewTextBoxColumn
            // 
            this.breakfastDataGridViewTextBoxColumn.DataPropertyName = "Breakfast";
            this.breakfastDataGridViewTextBoxColumn.HeaderText = "Breakfast";
            this.breakfastDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.breakfastDataGridViewTextBoxColumn.Name = "breakfastDataGridViewTextBoxColumn";
            this.breakfastDataGridViewTextBoxColumn.Width = 125;
            // 
            // lunchDataGridViewTextBoxColumn
            // 
            this.lunchDataGridViewTextBoxColumn.DataPropertyName = "Lunch";
            this.lunchDataGridViewTextBoxColumn.HeaderText = "Lunch";
            this.lunchDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lunchDataGridViewTextBoxColumn.Name = "lunchDataGridViewTextBoxColumn";
            this.lunchDataGridViewTextBoxColumn.Width = 125;
            // 
            // dinnerDataGridViewTextBoxColumn
            // 
            this.dinnerDataGridViewTextBoxColumn.DataPropertyName = "Dinner";
            this.dinnerDataGridViewTextBoxColumn.HeaderText = "Dinner";
            this.dinnerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dinnerDataGridViewTextBoxColumn.Name = "dinnerDataGridViewTextBoxColumn";
            this.dinnerDataGridViewTextBoxColumn.Width = 125;
            // 
            // mEAL1BindingSource
            // 
            this.mEAL1BindingSource.DataMember = "MEAL1";
            this.mEAL1BindingSource.DataSource = this.modelDataSet2;
            // 
            // modelDataSet2
            // 
            this.modelDataSet2.DataSetName = "modelDataSet2";
            this.modelDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(412, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Change Menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(39, 354);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(275, 359);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(615, 359);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(443, 359);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 5;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(39, 398);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 6;
            // 
            // modelDataSet1
            // 
            this.modelDataSet1.DataSetName = "modelDataSet1";
            this.modelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mEALBindingSource
            // 
            this.mEALBindingSource.DataMember = "MEAL";
            this.mEALBindingSource.DataSource = this.modelDataSet1;
            // 
            // mEALTableAdapter
            // 
            this.mEALTableAdapter.ClearBeforeFill = true;
            // 
            // mEAL1TableAdapter
            // 
            this.mEAL1TableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightBlue;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.LightCyan;
            this.button4.Location = new System.Drawing.Point(653, 399);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 42);
            this.button4.TabIndex = 7;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Mealmanager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Mealmanager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mealmanager";
            this.Load += new System.EventHandler(this.Mealmanager_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEAL1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEALBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private modelDataSet1 modelDataSet1;
        private System.Windows.Forms.BindingSource mEALBindingSource;
        private modelDataSet1TableAdapters.MEALTableAdapter mEALTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn breakfastDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lunchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dinnerDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private modelDataSet2 modelDataSet2;
        private System.Windows.Forms.BindingSource mEAL1BindingSource;
        private modelDataSet2TableAdapters.MEAL1TableAdapter mEAL1TableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button4;
    }
}