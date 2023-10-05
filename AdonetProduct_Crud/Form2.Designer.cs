namespace AdonetProduct_Crud
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
            this.btnshowall = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnserach = new System.Windows.Forms.Button();
            this.cmbcategory = new System.Windows.Forms.ComboBox();
            this.lblcid = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.lblprice = new System.Windows.Forms.Label();
            this.txtpname = new System.Windows.Forms.TextBox();
            this.lblpname = new System.Windows.Forms.Label();
            this.txtpid = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnshowall
            // 
            this.btnshowall.Location = new System.Drawing.Point(645, 327);
            this.btnshowall.Name = "btnshowall";
            this.btnshowall.Size = new System.Drawing.Size(75, 23);
            this.btnshowall.TabIndex = 27;
            this.btnshowall.Text = "Show All";
            this.btnshowall.UseVisualStyleBackColor = true;
            this.btnshowall.Click += new System.EventHandler(this.btnshowall_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(505, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(361, 150);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(831, 103);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 25;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(714, 103);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 24;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(587, 101);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 23;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnserach
            // 
            this.btnserach.Location = new System.Drawing.Point(464, 103);
            this.btnserach.Name = "btnserach";
            this.btnserach.Size = new System.Drawing.Size(75, 23);
            this.btnserach.TabIndex = 22;
            this.btnserach.Text = "Search";
            this.btnserach.UseVisualStyleBackColor = true;
            this.btnserach.Click += new System.EventHandler(this.btnserach_Click);
            // 
            // cmbcategory
            // 
            this.cmbcategory.FormattingEnabled = true;
            this.cmbcategory.Location = new System.Drawing.Point(279, 327);
            this.cmbcategory.Name = "cmbcategory";
            this.cmbcategory.Size = new System.Drawing.Size(133, 21);
            this.cmbcategory.TabIndex = 21;
            // 
            // lblcid
            // 
            this.lblcid.AutoSize = true;
            this.lblcid.Location = new System.Drawing.Point(187, 335);
            this.lblcid.Name = "lblcid";
            this.lblcid.Size = new System.Drawing.Size(22, 13);
            this.lblcid.TabIndex = 20;
            this.lblcid.Text = "Cid";
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(279, 254);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(133, 20);
            this.txtprice.TabIndex = 19;
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Location = new System.Drawing.Point(187, 257);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(31, 13);
            this.lblprice.TabIndex = 18;
            this.lblprice.Text = "Price";
            // 
            // txtpname
            // 
            this.txtpname.Location = new System.Drawing.Point(279, 173);
            this.txtpname.Name = "txtpname";
            this.txtpname.Size = new System.Drawing.Size(133, 20);
            this.txtpname.TabIndex = 17;
            // 
            // lblpname
            // 
            this.lblpname.AutoSize = true;
            this.lblpname.Location = new System.Drawing.Point(187, 176);
            this.lblpname.Name = "lblpname";
            this.lblpname.Size = new System.Drawing.Size(40, 13);
            this.lblpname.TabIndex = 16;
            this.lblpname.Text = "Pname";
            // 
            // txtpid
            // 
            this.txtpid.Location = new System.Drawing.Point(279, 103);
            this.txtpid.Name = "txtpid";
            this.txtpid.Size = new System.Drawing.Size(133, 20);
            this.txtpid.TabIndex = 15;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(187, 106);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(22, 13);
            this.lblid.TabIndex = 14;
            this.lblid.Text = "Pid";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 450);
            this.Controls.Add(this.btnshowall);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnserach);
            this.Controls.Add(this.cmbcategory);
            this.Controls.Add(this.lblcid);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.txtpname);
            this.Controls.Add(this.lblpname);
            this.Controls.Add(this.txtpid);
            this.Controls.Add(this.lblid);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnshowall;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnserach;
        private System.Windows.Forms.ComboBox cmbcategory;
        private System.Windows.Forms.Label lblcid;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.TextBox txtpname;
        private System.Windows.Forms.Label lblpname;
        private System.Windows.Forms.TextBox txtpid;
        private System.Windows.Forms.Label lblid;
    }
}