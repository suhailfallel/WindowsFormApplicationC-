
namespace WinFormsAppCSharp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.phoneno = new System.Windows.Forms.TextBox();
            this.dept = new System.Windows.Forms.TextBox();
            this.pos = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.TextBox();
            this.searchBTN = new System.Windows.Forms.Button();
            this.insertBTN = new System.Windows.Forms.Button();
            this.clearBTN = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listallBTN = new System.Windows.Forms.Button();
            this.editBTN = new System.Windows.Forms.Button();
            this.dltBTN = new System.Windows.Forms.Button();
            this.extBTN = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.empid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name           :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address        :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "PhoneNo      :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Department  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Position         :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(113, 60);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(205, 23);
            this.name.TabIndex = 5;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(113, 102);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(205, 42);
            this.address.TabIndex = 6;
            // 
            // phoneno
            // 
            this.phoneno.Location = new System.Drawing.Point(113, 162);
            this.phoneno.Name = "phoneno";
            this.phoneno.Size = new System.Drawing.Size(205, 23);
            this.phoneno.TabIndex = 7;
            this.phoneno.TextChanged += new System.EventHandler(this.phoneno_TextChanged);
            // 
            // dept
            // 
            this.dept.Location = new System.Drawing.Point(113, 207);
            this.dept.Name = "dept";
            this.dept.Size = new System.Drawing.Size(205, 23);
            this.dept.TabIndex = 8;
            // 
            // pos
            // 
            this.pos.Location = new System.Drawing.Point(113, 246);
            this.pos.Name = "pos";
            this.pos.Size = new System.Drawing.Size(205, 23);
            this.pos.TabIndex = 9;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(349, 30);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(339, 23);
            this.search.TabIndex = 10;
            // 
            // searchBTN
            // 
            this.searchBTN.Location = new System.Drawing.Point(732, 30);
            this.searchBTN.Name = "searchBTN";
            this.searchBTN.Size = new System.Drawing.Size(102, 23);
            this.searchBTN.TabIndex = 11;
            this.searchBTN.Text = "Search";
            this.searchBTN.UseVisualStyleBackColor = true;
            this.searchBTN.Click += new System.EventHandler(this.searchBTN_Click);
            // 
            // insertBTN
            // 
            this.insertBTN.Location = new System.Drawing.Point(113, 291);
            this.insertBTN.Name = "insertBTN";
            this.insertBTN.Size = new System.Drawing.Size(89, 23);
            this.insertBTN.TabIndex = 12;
            this.insertBTN.Text = "Submit";
            this.insertBTN.UseVisualStyleBackColor = true;
            this.insertBTN.Click += new System.EventHandler(this.insertBTN_Click);
            // 
            // clearBTN
            // 
            this.clearBTN.Location = new System.Drawing.Point(230, 291);
            this.clearBTN.Name = "clearBTN";
            this.clearBTN.Size = new System.Drawing.Size(87, 23);
            this.clearBTN.TabIndex = 13;
            this.clearBTN.Text = "Clear";
            this.clearBTN.UseVisualStyleBackColor = true;
            this.clearBTN.Click += new System.EventHandler(this.clearBTN_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(349, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(646, 221);
            this.dataGridView1.TabIndex = 14;
            // 
            // listallBTN
            // 
            this.listallBTN.Location = new System.Drawing.Point(876, 29);
            this.listallBTN.Name = "listallBTN";
            this.listallBTN.Size = new System.Drawing.Size(119, 23);
            this.listallBTN.TabIndex = 15;
            this.listallBTN.Text = "List All";
            this.listallBTN.UseVisualStyleBackColor = true;
            this.listallBTN.Click += new System.EventHandler(this.listallBTN_Click);
            // 
            // editBTN
            // 
            this.editBTN.Location = new System.Drawing.Point(113, 341);
            this.editBTN.Name = "editBTN";
            this.editBTN.Size = new System.Drawing.Size(60, 23);
            this.editBTN.TabIndex = 16;
            this.editBTN.Text = "Update";
            this.editBTN.UseVisualStyleBackColor = true;
            this.editBTN.Click += new System.EventHandler(this.editBTN_Click);
            // 
            // dltBTN
            // 
            this.dltBTN.Location = new System.Drawing.Point(179, 341);
            this.dltBTN.Name = "dltBTN";
            this.dltBTN.Size = new System.Drawing.Size(62, 23);
            this.dltBTN.TabIndex = 17;
            this.dltBTN.Text = "Remove";
            this.dltBTN.UseVisualStyleBackColor = true;
            this.dltBTN.Click += new System.EventHandler(this.dltBTN_Click);
            // 
            // extBTN
            // 
            this.extBTN.Location = new System.Drawing.Point(260, 340);
            this.extBTN.Name = "extBTN";
            this.extBTN.Size = new System.Drawing.Size(56, 23);
            this.extBTN.TabIndex = 18;
            this.extBTN.Text = "Exit";
            this.extBTN.UseVisualStyleBackColor = true;
            this.extBTN.Click += new System.EventHandler(this.extBTN_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "Emp Id          :";
            // 
            // empid
            // 
            this.empid.Location = new System.Drawing.Point(113, 30);
            this.empid.Name = "empid";
            this.empid.Size = new System.Drawing.Size(205, 23);
            this.empid.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 450);
            this.Controls.Add(this.empid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.extBTN);
            this.Controls.Add(this.dltBTN);
            this.Controls.Add(this.editBTN);
            this.Controls.Add(this.listallBTN);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.clearBTN);
            this.Controls.Add(this.insertBTN);
            this.Controls.Add(this.searchBTN);
            this.Controls.Add(this.search);
            this.Controls.Add(this.pos);
            this.Controls.Add(this.dept);
            this.Controls.Add(this.phoneno);
            this.Controls.Add(this.address);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox phoneno;
        private System.Windows.Forms.TextBox dept;
        private System.Windows.Forms.TextBox pos;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button searchBTN;
        private System.Windows.Forms.Button insertBTN;
        private System.Windows.Forms.Button clearBTN;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button listallBTN;
        private System.Windows.Forms.Button editBTN;
        private System.Windows.Forms.Button dltBTN;
        private System.Windows.Forms.Button extBTN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox empid;
    }
}