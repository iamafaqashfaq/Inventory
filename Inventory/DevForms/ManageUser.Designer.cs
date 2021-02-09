
namespace Inventory.DevForms
{
    partial class ManageUser
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.cbo_type = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.dtg_listUser = new System.Windows.Forms.DataGridView();
            this.btn_New = new DevExpress.XtraEditors.SimpleButton();
            this.closeBtn = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_saveuser = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_listUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.txt_name);
            this.panel1.Controls.Add(this.lbl_id);
            this.panel1.Controls.Add(this.cbo_type);
            this.panel1.Controls.Add(this.Label1);
            this.panel1.Controls.Add(this.txt_pass);
            this.panel1.Controls.Add(this.Label2);
            this.panel1.Controls.Add(this.Label4);
            this.panel1.Controls.Add(this.txt_username);
            this.panel1.Controls.Add(this.Label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 165);
            this.panel1.TabIndex = 1;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(303, 24);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(280, 22);
            this.txt_name.TabIndex = 10;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(317, 27);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(18, 16);
            this.lbl_id.TabIndex = 18;
            this.lbl_id.Text = "id";
            this.lbl_id.Visible = false;
            // 
            // cbo_type
            // 
            this.cbo_type.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_type.FormattingEnabled = true;
            this.cbo_type.Items.AddRange(new object[] {
            "Administrator",
            "Staff"});
            this.cbo_type.Location = new System.Drawing.Point(303, 117);
            this.cbo_type.Name = "cbo_type";
            this.cbo_type.Size = new System.Drawing.Size(280, 24);
            this.cbo_type.TabIndex = 14;
            this.cbo_type.Text = "Administrator";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Label1.Location = new System.Drawing.Point(246, 30);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(44, 16);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "Name :";
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(303, 87);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(280, 22);
            this.txt_pass.TabIndex = 13;
            this.txt_pass.UseSystemPasswordChar = true;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Label2.Location = new System.Drawing.Point(220, 60);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(67, 16);
            this.Label2.TabIndex = 15;
            this.Label2.Text = "Username :";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Label4.Location = new System.Drawing.Point(246, 120);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(40, 16);
            this.Label4.TabIndex = 17;
            this.Label4.Text = "Type :";
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(303, 57);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(280, 22);
            this.txt_username.TabIndex = 11;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Label3.Location = new System.Drawing.Point(223, 90);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(66, 16);
            this.Label3.TabIndex = 16;
            this.Label3.Text = "Password :";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.GroupBox1.Controls.Add(this.dtg_listUser);
            this.GroupBox1.Location = new System.Drawing.Point(0, 200);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(873, 288);
            this.GroupBox1.TabIndex = 40;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "List Of User";
            // 
            // dtg_listUser
            // 
            this.dtg_listUser.AllowUserToAddRows = false;
            this.dtg_listUser.AllowUserToDeleteRows = false;
            this.dtg_listUser.AllowUserToResizeColumns = false;
            this.dtg_listUser.AllowUserToResizeRows = false;
            this.dtg_listUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_listUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_listUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_listUser.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtg_listUser.Location = new System.Drawing.Point(3, 17);
            this.dtg_listUser.Name = "dtg_listUser";
            this.dtg_listUser.RowHeadersVisible = false;
            this.dtg_listUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_listUser.Size = new System.Drawing.Size(867, 268);
            this.dtg_listUser.TabIndex = 0;
            this.dtg_listUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_listUser_CellClick);
            // 
            // btn_New
            // 
            this.btn_New.ImageOptions.Image = global::Inventory.Properties.Resources.pencolor_16x16;
            this.btn_New.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_New.Location = new System.Drawing.Point(497, 171);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(112, 23);
            this.btn_New.TabIndex = 48;
            this.btn_New.Text = "New";
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.ImageOptions.Image = global::Inventory.Properties.Resources.close_16x16;
            this.closeBtn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.closeBtn.Location = new System.Drawing.Point(615, 171);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(112, 23);
            this.closeBtn.TabIndex = 47;
            this.closeBtn.Text = "Close";
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.ImageOptions.Image = global::Inventory.Properties.Resources.trash_16x16;
            this.btn_delete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_delete.Location = new System.Drawing.Point(379, 171);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(112, 23);
            this.btn_delete.TabIndex = 46;
            this.btn_delete.Text = "Delete";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.ImageOptions.Image = global::Inventory.Properties.Resources.recurrence_16x16;
            this.btn_update.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_update.Location = new System.Drawing.Point(261, 171);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(112, 23);
            this.btn_update.TabIndex = 45;
            this.btn_update.Text = "Update";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_saveuser
            // 
            this.btn_saveuser.ImageOptions.Image = global::Inventory.Properties.Resources.saveall_16x16;
            this.btn_saveuser.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_saveuser.Location = new System.Drawing.Point(143, 171);
            this.btn_saveuser.Name = "btn_saveuser";
            this.btn_saveuser.Size = new System.Drawing.Size(112, 23);
            this.btn_saveuser.TabIndex = 39;
            this.btn_saveuser.Text = "Save";
            this.btn_saveuser.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // ManageUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 488);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.btn_saveuser);
            this.Controls.Add(this.panel1);
            this.Name = "ManageUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageUser";
            this.Load += new System.EventHandler(this.ManageUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_listUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.TextBox txt_name;
        internal System.Windows.Forms.Label lbl_id;
        internal System.Windows.Forms.ComboBox cbo_type;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txt_pass;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txt_username;
        internal System.Windows.Forms.Label Label3;
        private DevExpress.XtraEditors.SimpleButton btn_saveuser;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.DataGridView dtg_listUser;
        private DevExpress.XtraEditors.SimpleButton btn_New;
        private DevExpress.XtraEditors.SimpleButton closeBtn;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private DevExpress.XtraEditors.SimpleButton btn_update;
    }
}