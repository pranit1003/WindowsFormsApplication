
namespace WindowsFormsApplication
{
    partial class Form3
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblBA = new System.Windows.Forms.Label();
            this.lblHRA = new System.Windows.Forms.Label();
            this.lblDA = new System.Windows.Forms.Label();
            this.lblTotalSalary = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDA = new System.Windows.Forms.TextBox();
            this.txtHRA = new System.Windows.Forms.TextBox();
            this.txtBasicSalary = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtTotalSalary = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(136, 48);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Enter Name";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(136, 88);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(72, 13);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Text = "Enter Number";
            // 
            // lblBA
            // 
            this.lblBA.AutoSize = true;
            this.lblBA.Location = new System.Drawing.Point(136, 132);
            this.lblBA.Name = "lblBA";
            this.lblBA.Size = new System.Drawing.Size(93, 13);
            this.lblBA.TabIndex = 2;
            this.lblBA.Text = "Enter Basic Salary";
            // 
            // lblHRA
            // 
            this.lblHRA.AutoSize = true;
            this.lblHRA.Location = new System.Drawing.Point(136, 173);
            this.lblHRA.Name = "lblHRA";
            this.lblHRA.Size = new System.Drawing.Size(30, 13);
            this.lblHRA.TabIndex = 3;
            this.lblHRA.Text = "HRA";
            // 
            // lblDA
            // 
            this.lblDA.AutoSize = true;
            this.lblDA.Location = new System.Drawing.Point(136, 205);
            this.lblDA.Name = "lblDA";
            this.lblDA.Size = new System.Drawing.Size(22, 13);
            this.lblDA.TabIndex = 4;
            this.lblDA.Text = "DA";
            // 
            // lblTotalSalary
            // 
            this.lblTotalSalary.AutoSize = true;
            this.lblTotalSalary.Location = new System.Drawing.Point(131, 241);
            this.lblTotalSalary.Name = "lblTotalSalary";
            this.lblTotalSalary.Size = new System.Drawing.Size(63, 13);
            this.lblTotalSalary.TabIndex = 6;
            this.lblTotalSalary.Text = "Total Salary";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(310, 48);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 7;
            // 
            // txtDA
            // 
            this.txtDA.Enabled = false;
            this.txtDA.Location = new System.Drawing.Point(310, 205);
            this.txtDA.Name = "txtDA";
            this.txtDA.Size = new System.Drawing.Size(100, 20);
            this.txtDA.TabIndex = 8;
            // 
            // txtHRA
            // 
            this.txtHRA.Enabled = false;
            this.txtHRA.Location = new System.Drawing.Point(310, 170);
            this.txtHRA.Name = "txtHRA";
            this.txtHRA.Size = new System.Drawing.Size(100, 20);
            this.txtHRA.TabIndex = 9;
            // 
            // txtBasicSalary
            // 
            this.txtBasicSalary.Location = new System.Drawing.Point(310, 132);
            this.txtBasicSalary.Name = "txtBasicSalary";
            this.txtBasicSalary.Size = new System.Drawing.Size(100, 20);
            this.txtBasicSalary.TabIndex = 10;
            this.txtBasicSalary.TextChanged += new System.EventHandler(this.txtBasicSalary_TextChanged);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(310, 88);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 11;
            // 
            // txtTotalSalary
            // 
            this.txtTotalSalary.Enabled = false;
            this.txtTotalSalary.Location = new System.Drawing.Point(310, 241);
            this.txtTotalSalary.Name = "txtTotalSalary";
            this.txtTotalSalary.Size = new System.Drawing.Size(100, 20);
            this.txtTotalSalary.TabIndex = 12;
            this.txtTotalSalary.TextChanged += new System.EventHandler(this.txtTotalSalary_TextChanged);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(154, 334);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 13;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(419, 334);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(285, 334);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 15;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.txtTotalSalary);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtBasicSalary);
            this.Controls.Add(this.txtHRA);
            this.Controls.Add(this.txtDA);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblTotalSalary);
            this.Controls.Add(this.lblDA);
            this.Controls.Add(this.lblHRA);
            this.Controls.Add(this.lblBA);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblName);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblBA;
        private System.Windows.Forms.Label lblHRA;
        private System.Windows.Forms.Label lblDA;
        private System.Windows.Forms.Label lblTotalSalary;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDA;
        private System.Windows.Forms.TextBox txtHRA;
        private System.Windows.Forms.TextBox txtBasicSalary;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtTotalSalary;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalc;
    }
}