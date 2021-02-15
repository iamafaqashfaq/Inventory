
namespace Inventory.DevForms
{
    partial class StockOut
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
            this.Button2 = new System.Windows.Forms.Button();
            this.btnviewStockout = new System.Windows.Forms.Button();
            this.btnCus_clear = new System.Windows.Forms.Button();
            this.btnCus_save = new System.Windows.Forms.Button();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCus_Remove = new System.Windows.Forms.Button();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.txtCus_lname = new System.Windows.Forms.TextBox();
            this.txtCus_fname = new System.Windows.Forms.TextBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Panel2.SuspendLayout();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.Transparent;
            this.Button2.ForeColor = System.Drawing.Color.Black;
            this.Button2.Location = new System.Drawing.Point(427, 14);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(88, 26);
            this.Button2.TabIndex = 4;
            this.Button2.Text = "Close";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnviewStockout
            // 
            this.btnviewStockout.BackColor = System.Drawing.Color.Transparent;
            this.btnviewStockout.ForeColor = System.Drawing.Color.Black;
            this.btnviewStockout.Location = new System.Drawing.Point(333, 14);
            this.btnviewStockout.Name = "btnviewStockout";
            this.btnviewStockout.Size = new System.Drawing.Size(88, 26);
            this.btnviewStockout.TabIndex = 3;
            this.btnviewStockout.Text = "View List";
            this.btnviewStockout.UseVisualStyleBackColor = false;
            this.btnviewStockout.Click += new System.EventHandler(this.btnviewStockout_Click_1);
            // 
            // btnCus_clear
            // 
            this.btnCus_clear.BackColor = System.Drawing.Color.Transparent;
            this.btnCus_clear.ForeColor = System.Drawing.Color.Black;
            this.btnCus_clear.Location = new System.Drawing.Point(237, 14);
            this.btnCus_clear.Name = "btnCus_clear";
            this.btnCus_clear.Size = new System.Drawing.Size(88, 26);
            this.btnCus_clear.TabIndex = 2;
            this.btnCus_clear.Text = "Clear";
            this.btnCus_clear.UseVisualStyleBackColor = false;
            this.btnCus_clear.Click += new System.EventHandler(this.btnCus_clear_Click);
            // 
            // btnCus_save
            // 
            this.btnCus_save.BackColor = System.Drawing.Color.Transparent;
            this.btnCus_save.ForeColor = System.Drawing.Color.Black;
            this.btnCus_save.Location = new System.Drawing.Point(49, 14);
            this.btnCus_save.Name = "btnCus_save";
            this.btnCus_save.Size = new System.Drawing.Size(88, 26);
            this.btnCus_save.TabIndex = 0;
            this.btnCus_save.Text = "Save";
            this.btnCus_save.UseVisualStyleBackColor = false;
            this.btnCus_save.Click += new System.EventHandler(this.btnCus_save_Click);
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Total Price";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Quantity";
            this.Column5.Name = "Column5";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Description";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Item Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Item Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(4, -1);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(136, 24);
            this.Label7.TabIndex = 3;
            this.Label7.Text = "List of Products";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(335, 6);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(47, 13);
            this.Label6.TabIndex = 4;
            this.Label6.Text = "Search :";
            // 
            // Label8
            // 
            this.Label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(2, 258);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(168, 24);
            this.Label8.TabIndex = 39;
            this.Label8.Text = "List of Added Items";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(0, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(819, 131);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnCus_Remove
            // 
            this.btnCus_Remove.BackColor = System.Drawing.Color.Transparent;
            this.btnCus_Remove.ForeColor = System.Drawing.Color.Black;
            this.btnCus_Remove.Location = new System.Drawing.Point(143, 14);
            this.btnCus_Remove.Name = "btnCus_Remove";
            this.btnCus_Remove.Size = new System.Drawing.Size(88, 26);
            this.btnCus_Remove.TabIndex = 1;
            this.btnCus_Remove.Text = "Remove";
            this.btnCus_Remove.UseVisualStyleBackColor = false;
            this.btnCus_Remove.Click += new System.EventHandler(this.btnCus_Remove_Click);
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.Label7);
            this.Panel2.Controls.Add(this.Label6);
            this.Panel2.Controls.Add(this.dataGridView1);
            this.Panel2.Controls.Add(this.txtsearch);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Panel2.Location = new System.Drawing.Point(0, 88);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(821, 168);
            this.Panel2.TabIndex = 38;
            // 
            // txtsearch
            // 
            this.txtsearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtsearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtsearch.Location = new System.Drawing.Point(388, 3);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(220, 20);
            this.txtsearch.TabIndex = 3;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contact Number:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 21);
            this.textBox1.TabIndex = 2;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(3, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(91, 24);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Customer";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(316, 33);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(64, 13);
            this.Label5.TabIndex = 1;
            this.Label5.Text = "Last Name :";
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Location = new System.Drawing.Point(10, 33);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(65, 13);
            this.Label15.TabIndex = 1;
            this.Label15.Text = "First Name :";
            // 
            // txtCus_lname
            // 
            this.txtCus_lname.Location = new System.Drawing.Point(386, 30);
            this.txtCus_lname.Name = "txtCus_lname";
            this.txtCus_lname.Size = new System.Drawing.Size(220, 21);
            this.txtCus_lname.TabIndex = 1;
            // 
            // txtCus_fname
            // 
            this.txtCus_fname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCus_fname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCus_fname.Location = new System.Drawing.Point(96, 30);
            this.txtCus_fname.Name = "txtCus_fname";
            this.txtCus_fname.Size = new System.Drawing.Size(205, 21);
            this.txtCus_fname.TabIndex = 0;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.textBox2);
            this.Panel1.Controls.Add(this.label3);
            this.Panel1.Controls.Add(this.label2);
            this.Panel1.Controls.Add(this.textBox1);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.Label5);
            this.Panel1.Controls.Add(this.Label15);
            this.Panel1.Controls.Add(this.txtCus_lname);
            this.Panel1.Controls.Add(this.txtCus_fname);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(821, 88);
            this.Panel1.TabIndex = 37;
            this.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Discount:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView2.Location = new System.Drawing.Point(0, 295);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(821, 155);
            this.dataGridView2.TabIndex = 40;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellEndEdit);
            this.dataGridView2.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellValueChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.button1);
            this.groupControl1.Controls.Add(this.btnCus_save);
            this.groupControl1.Controls.Add(this.Button2);
            this.groupControl1.Controls.Add(this.btnCus_Remove);
            this.groupControl1.Controls.Add(this.btnviewStockout);
            this.groupControl1.Controls.Add(this.btnCus_clear);
            this.groupControl1.Location = new System.Drawing.Point(109, 456);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(642, 45);
            this.groupControl1.TabIndex = 46;
            this.groupControl1.Text = "Actions";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(519, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 26);
            this.button1.TabIndex = 5;
            this.button1.Text = "Calculator";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(430, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 24);
            this.label4.TabIndex = 47;
            this.label4.Text = "Total:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(505, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 24);
            this.label9.TabIndex = 48;
            this.label9.Text = "0.00";
            this.label9.TextChanged += new System.EventHandler(this.label9_TextChanged);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(367, 259);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 24);
            this.label10.TabIndex = 50;
            this.label10.Text = "0.00";
            this.label10.TextChanged += new System.EventHandler(this.label10_TextChanged);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(262, 259);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 24);
            this.label11.TabIndex = 49;
            this.label11.Text = "Discount:";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(754, 258);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 24);
            this.label12.TabIndex = 52;
            this.label12.Text = "0.00";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(573, 258);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(153, 24);
            this.label13.TabIndex = 51;
            this.label13.Text = "Payable Amount:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(388, 57);
            this.textBox2.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.textBox2.Name = "textBox2";
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox2.Size = new System.Drawing.Size(120, 21);
            this.textBox2.TabIndex = 8;
            this.textBox2.ValueChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // StockOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 531);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "StockOut";
            this.Text = "StockOut";
            this.Load += new System.EventHandler(this.StockOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button btnviewStockout;
        internal System.Windows.Forms.Button btnCus_clear;
        internal System.Windows.Forms.Button btnCus_save;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.Button btnCus_Remove;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.TextBox txtsearch;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox textBox1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.TextBox txtCus_lname;
        internal System.Windows.Forms.TextBox txtCus_fname;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.DataGridView dataGridView2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown textBox2;
    }
}