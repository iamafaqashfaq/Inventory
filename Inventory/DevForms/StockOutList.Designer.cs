
namespace Inventory.DevForms
{
    partial class StockOutList
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
            this.Label1 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.dtglist = new System.Windows.Forms.DataGridView();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.button1 = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpto = new System.Windows.Forms.DateTimePicker();
            this.dptfrom = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dtglist)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(655, 20);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(47, 13);
            this.Label1.TabIndex = 24;
            this.Label1.Text = "Search: ";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(708, 17);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(270, 21);
            this.txtsearch.TabIndex = 23;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // dtglist
            // 
            this.dtglist.AllowUserToAddRows = false;
            this.dtglist.AllowUserToDeleteRows = false;
            this.dtglist.AllowUserToResizeColumns = false;
            this.dtglist.AllowUserToResizeRows = false;
            this.dtglist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtglist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtglist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtglist.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtglist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtglist.Location = new System.Drawing.Point(0, 54);
            this.dtglist.Name = "dtglist";
            this.dtglist.Size = new System.Drawing.Size(990, 546);
            this.dtglist.TabIndex = 22;
            this.dtglist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtglist_CellClick);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.SvgImage = global::Inventory.Properties.Resources.print;
            this.simpleButton1.Location = new System.Drawing.Point(12, 6);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(115, 42);
            this.simpleButton1.TabIndex = 25;
            this.simpleButton1.Text = "Print Receipt";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(543, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Preview";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(381, 20);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(19, 13);
            this.Label2.TabIndex = 29;
            this.Label2.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "From";
            // 
            // dtpto
            // 
            this.dtpto.CustomFormat = "yyyy-MM-dd";
            this.dtpto.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpto.Location = new System.Drawing.Point(406, 17);
            this.dtpto.Name = "dtpto";
            this.dtpto.Size = new System.Drawing.Size(131, 21);
            this.dtpto.TabIndex = 27;
            // 
            // dptfrom
            // 
            this.dptfrom.CustomFormat = "yyyy-MM-dd";
            this.dptfrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dptfrom.Location = new System.Drawing.Point(244, 17);
            this.dptfrom.Name = "dptfrom";
            this.dptfrom.Size = new System.Drawing.Size(131, 21);
            this.dptfrom.TabIndex = 28;
            // 
            // StockOutList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 600);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpto);
            this.Controls.Add(this.dptfrom);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.dtglist);
            this.Name = "StockOutList";
            this.Text = "Stock Out List";
            this.Load += new System.EventHandler(this.StockOutList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtglist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtsearch;
        internal System.Windows.Forms.DataGridView dtglist;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.DateTimePicker dtpto;
        internal System.Windows.Forms.DateTimePicker dptfrom;
    }
}