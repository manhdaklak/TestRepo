
namespace GIT
{
    partial class MN
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
            this.txtNameBranch = new System.Windows.Forms.TextBox();
            this.btnCreateBranch = new System.Windows.Forms.Button();
            this.txtBranchCherry = new System.Windows.Forms.TextBox();
            this.btnBranchCherry = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtNameBranch
            // 
            this.txtNameBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameBranch.Location = new System.Drawing.Point(54, 43);
            this.txtNameBranch.Name = "txtNameBranch";
            this.txtNameBranch.Size = new System.Drawing.Size(435, 22);
            this.txtNameBranch.TabIndex = 0;
            // 
            // btnCreateBranch
            // 
            this.btnCreateBranch.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateBranch.ForeColor = System.Drawing.Color.Black;
            this.btnCreateBranch.Location = new System.Drawing.Point(208, 155);
            this.btnCreateBranch.Name = "btnCreateBranch";
            this.btnCreateBranch.Size = new System.Drawing.Size(131, 28);
            this.btnCreateBranch.TabIndex = 1;
            this.btnCreateBranch.Text = "Tạo nhánh";
            this.btnCreateBranch.UseVisualStyleBackColor = false;
            this.btnCreateBranch.Click += new System.EventHandler(this.btnCreateBranch_Click);
            // 
            // txtBranchCherry
            // 
            this.txtBranchCherry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBranchCherry.Location = new System.Drawing.Point(54, 98);
            this.txtBranchCherry.Name = "txtBranchCherry";
            this.txtBranchCherry.Size = new System.Drawing.Size(435, 21);
            this.txtBranchCherry.TabIndex = 2;
            // 
            // btnBranchCherry
            // 
            this.btnBranchCherry.Location = new System.Drawing.Point(208, 211);
            this.btnBranchCherry.Name = "btnBranchCherry";
            this.btnBranchCherry.Size = new System.Drawing.Size(131, 28);
            this.btnBranchCherry.TabIndex = 3;
            this.btnBranchCherry.Text = "Tạo nhánh cherry";
            this.btnBranchCherry.UseVisualStyleBackColor = true;
            this.btnBranchCherry.Click += new System.EventHandler(this.btnBranchCherry_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(420, 141);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // MN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 262);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnBranchCherry);
            this.Controls.Add(this.txtBranchCherry);
            this.Controls.Add(this.btnCreateBranch);
            this.Controls.Add(this.txtNameBranch);
            this.Name = "MN";
            this.Text = "MN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNameBranch;
        private System.Windows.Forms.Button btnCreateBranch;
        private System.Windows.Forms.TextBox txtBranchCherry;
        private System.Windows.Forms.Button btnBranchCherry;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

