
namespace Inventory.Forms
{
    partial class StockMaster
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
            this.pnl_stockmaster = new System.Windows.Forms.Panel();
            this.cbounit = new System.Windows.Forms.ComboBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.txtdescription = new System.Windows.Forms.RichTextBox();
            this.cbotype = new System.Windows.Forms.ComboBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnnew = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.dtglist = new System.Windows.Forms.DataGridView();
            this.pnl_stockmaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtglist)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_stockmaster
            // 
            this.pnl_stockmaster.BackColor = System.Drawing.Color.White;
            this.pnl_stockmaster.Controls.Add(this.Label6);
            this.pnl_stockmaster.Controls.Add(this.Button1);
            this.pnl_stockmaster.Controls.Add(this.cbounit);
            this.pnl_stockmaster.Controls.Add(this.btnnew);
            this.pnl_stockmaster.Controls.Add(this.btndelete);
            this.pnl_stockmaster.Controls.Add(this.txtsearch);
            this.pnl_stockmaster.Controls.Add(this.btnupdate);
            this.pnl_stockmaster.Controls.Add(this.Label7);
            this.pnl_stockmaster.Controls.Add(this.btnsave);
            this.pnl_stockmaster.Controls.Add(this.txtqty);
            this.pnl_stockmaster.Controls.Add(this.txtdescription);
            this.pnl_stockmaster.Controls.Add(this.cbotype);
            this.pnl_stockmaster.Controls.Add(this.txtname);
            this.pnl_stockmaster.Controls.Add(this.Label4);
            this.pnl_stockmaster.Controls.Add(this.Label3);
            this.pnl_stockmaster.Controls.Add(this.txtprice);
            this.pnl_stockmaster.Controls.Add(this.Label2);
            this.pnl_stockmaster.Controls.Add(this.Label1);
            this.pnl_stockmaster.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_stockmaster.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_stockmaster.Location = new System.Drawing.Point(0, 0);
            this.pnl_stockmaster.Name = "pnl_stockmaster";
            this.pnl_stockmaster.Size = new System.Drawing.Size(800, 182);
            this.pnl_stockmaster.TabIndex = 31;
            // 
            // cbounit
            // 
            this.cbounit.FormattingEnabled = true;
            this.cbounit.Location = new System.Drawing.Point(607, 92);
            this.cbounit.Name = "cbounit";
            this.cbounit.Size = new System.Drawing.Size(87, 23);
            this.cbounit.TabIndex = 6;
            this.cbounit.Text = "Metre";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(374, 96);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(64, 16);
            this.Label7.TabIndex = 5;
            this.Label7.Text = "Quantity ::";
            // 
            // txtqty
            // 
            this.txtqty.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqty.Location = new System.Drawing.Point(444, 93);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(153, 22);
            this.txtqty.TabIndex = 4;
            // 
            // txtdescription
            // 
            this.txtdescription.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescription.Location = new System.Drawing.Point(110, 57);
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(253, 62);
            this.txtdescription.TabIndex = 3;
            this.txtdescription.Text = "";
            // 
            // cbotype
            // 
            this.cbotype.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbotype.FormattingEnabled = true;
            this.cbotype.Location = new System.Drawing.Point(442, 21);
            this.cbotype.Name = "cbotype";
            this.cbotype.Size = new System.Drawing.Size(252, 24);
            this.cbotype.TabIndex = 2;
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(111, 21);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(252, 22);
            this.txtname.TabIndex = 0;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(393, 61);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(45, 16);
            this.Label4.TabIndex = 1;
            this.Label4.Text = "Price ::";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(369, 24);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(67, 16);
            this.Label3.TabIndex = 1;
            this.Label3.Text = "Category ::";
            // 
            // txtprice
            // 
            this.txtprice.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.Location = new System.Drawing.Point(444, 58);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(250, 22);
            this.txtprice.TabIndex = 0;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(24, 60);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(80, 16);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Description ::";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(31, 21);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(74, 16);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Item Name ::";
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.Transparent;
            this.Button1.ForeColor = System.Drawing.Color.Black;
            this.Button1.Location = new System.Drawing.Point(474, 136);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(92, 30);
            this.Button1.TabIndex = 58;
            this.Button1.Text = "Close";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(577, 144);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(44, 15);
            this.Label6.TabIndex = 46;
            this.Label6.Text = "Search :";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(630, 141);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(158, 20);
            this.txtsearch.TabIndex = 45;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.Transparent;
            this.btnnew.ForeColor = System.Drawing.Color.Black;
            this.btnnew.Location = new System.Drawing.Point(362, 136);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(106, 30);
            this.btnnew.TabIndex = 47;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Transparent;
            this.btndelete.ForeColor = System.Drawing.Color.Black;
            this.btndelete.Location = new System.Drawing.Point(252, 136);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(106, 30);
            this.btndelete.TabIndex = 48;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Transparent;
            this.btnupdate.ForeColor = System.Drawing.Color.Black;
            this.btnupdate.Location = new System.Drawing.Point(143, 136);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(103, 30);
            this.btnupdate.TabIndex = 49;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Transparent;
            this.btnsave.ForeColor = System.Drawing.Color.Black;
            this.btnsave.Location = new System.Drawing.Point(31, 136);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(106, 30);
            this.btnsave.TabIndex = 50;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // dtglist
            // 
            this.dtglist.AllowUserToAddRows = false;
            this.dtglist.AllowUserToDeleteRows = false;
            this.dtglist.AllowUserToResizeColumns = false;
            this.dtglist.AllowUserToResizeRows = false;
            this.dtglist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtglist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtglist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtglist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtglist.Location = new System.Drawing.Point(0, 182);
            this.dtglist.Name = "dtglist";
            this.dtglist.Size = new System.Drawing.Size(800, 268);
            this.dtglist.TabIndex = 59;
            this.dtglist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtglist_CellClick);
            // 
            // StockMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtglist);
            this.Controls.Add(this.pnl_stockmaster);
            this.Name = "StockMaster";
            this.Text = "Stock Master";
            this.Load += new System.EventHandler(this.StockMaster_Load);
            this.pnl_stockmaster.ResumeLayout(false);
            this.pnl_stockmaster.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtglist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel pnl_stockmaster;
        internal System.Windows.Forms.ComboBox cbounit;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtqty;
        internal System.Windows.Forms.RichTextBox txtdescription;
        internal System.Windows.Forms.ComboBox cbotype;
        internal System.Windows.Forms.TextBox txtname;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtprice;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtsearch;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Button btnnew;
        internal System.Windows.Forms.Button btndelete;
        internal System.Windows.Forms.Button btnupdate;
        internal System.Windows.Forms.Button btnsave;
        internal System.Windows.Forms.DataGridView dtglist;
    }
}