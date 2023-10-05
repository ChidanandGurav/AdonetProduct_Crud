namespace AdonetProduct_Crud
{
    partial class Form1
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
            this.lblid = new System.Windows.Forms.Label();
            this.txtpid = new System.Windows.Forms.TextBox();
            this.txtpname = new System.Windows.Forms.TextBox();
            this.lblpname = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.lblprice = new System.Windows.Forms.Label();
            this.lblcid = new System.Windows.Forms.Label();
            this.cmbcategory = new System.Windows.Forms.ComboBox();
            this.btnserach = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnshowall = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(55, 56);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(22, 13);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "Pid";
            // 
            // txtpid
            // 
            this.txtpid.Location = new System.Drawing.Point(147, 53);
            this.txtpid.Name = "txtpid";
            this.txtpid.Size = new System.Drawing.Size(133, 20);
            this.txtpid.TabIndex = 1;
            // 
            // txtpname
            // 
            this.txtpname.Location = new System.Drawing.Point(147, 123);
            this.txtpname.Name = "txtpname";
            this.txtpname.Size = new System.Drawing.Size(133, 20);
            this.txtpname.TabIndex = 3;
            // 
            // lblpname
            // 
            this.lblpname.AutoSize = true;
            this.lblpname.Location = new System.Drawing.Point(55, 126);
            this.lblpname.Name = "lblpname";
            this.lblpname.Size = new System.Drawing.Size(40, 13);
            this.lblpname.TabIndex = 2;
            this.lblpname.Text = "Pname";
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(147, 204);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(133, 20);
            this.txtprice.TabIndex = 5;
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Location = new System.Drawing.Point(55, 207);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(31, 13);
            this.lblprice.TabIndex = 4;
            this.lblprice.Text = "Price";
            // 
            // lblcid
            // 
            this.lblcid.AutoSize = true;
            this.lblcid.Location = new System.Drawing.Point(55, 285);
            this.lblcid.Name = "lblcid";
            this.lblcid.Size = new System.Drawing.Size(22, 13);
            this.lblcid.TabIndex = 6;
            this.lblcid.Text = "Cid";
            // 
            // cmbcategory
            // 
            this.cmbcategory.FormattingEnabled = true;
            this.cmbcategory.Location = new System.Drawing.Point(147, 277);
            this.cmbcategory.Name = "cmbcategory";
            this.cmbcategory.Size = new System.Drawing.Size(133, 21);
            this.cmbcategory.TabIndex = 7;
            // 
            // btnserach
            // 
            this.btnserach.Location = new System.Drawing.Point(332, 53);
            this.btnserach.Name = "btnserach";
            this.btnserach.Size = new System.Drawing.Size(75, 23);
            this.btnserach.TabIndex = 8;
            this.btnserach.Text = "Search";
            this.btnserach.UseVisualStyleBackColor = true;
            this.btnserach.Click += new System.EventHandler(this.btnserach_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(455, 51);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 9;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(582, 53);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 10;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(699, 53);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 11;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(373, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(361, 150);
            this.dataGridView1.TabIndex = 12;
            // 
            // btnshowall
            // 
            this.btnshowall.Location = new System.Drawing.Point(513, 277);
            this.btnshowall.Name = "btnshowall";
            this.btnshowall.Size = new System.Drawing.Size(75, 23);
            this.btnshowall.TabIndex = 13;
            this.btnshowall.Text = "Show All";
            this.btnshowall.UseVisualStyleBackColor = true;
            this.btnshowall.Click += new System.EventHandler(this.btnshowall_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "Form1";
            this.Text = "ProductCrud";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txtpid;
        private System.Windows.Forms.TextBox txtpname;
        private System.Windows.Forms.Label lblpname;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label lblcid;
        private System.Windows.Forms.ComboBox cmbcategory;
        private System.Windows.Forms.Button btnserach;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnshowall;
    }
}

