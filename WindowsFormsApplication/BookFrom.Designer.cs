
namespace WindowsFormsApplication
{
    partial class BookFrom
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.txtBookPrice = new System.Windows.Forms.TextBox();
            this.txtBookAuthor = new System.Windows.Forms.TextBox();
            this.txtBookEdition = new System.Windows.Forms.TextBox();
            this.txtBookPublication = new System.Windows.Forms.TextBox();
            this.btnBinaryWrite = new System.Windows.Forms.Button();
            this.btnBinaryRead = new System.Windows.Forms.Button();
            this.btnXMLWrite = new System.Windows.Forms.Button();
            this.btnXMLRead = new System.Windows.Forms.Button();
            this.btnSOAPWrite = new System.Windows.Forms.Button();
            this.btnJSONWrite = new System.Windows.Forms.Button();
            this.btnSOAPRead = new System.Windows.Forms.Button();
            this.btnJSONRead = new System.Windows.Forms.Button();
            this.btnClearData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Book Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Book Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Book Author";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Book Edition";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Book Publication";
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(275, 113);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(100, 20);
            this.txtBookName.TabIndex = 9;
            // 
            // txtBookId
            // 
            this.txtBookId.Location = new System.Drawing.Point(275, 60);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.Size = new System.Drawing.Size(102, 20);
            this.txtBookId.TabIndex = 10;
            // 
            // txtBookPrice
            // 
            this.txtBookPrice.Location = new System.Drawing.Point(275, 159);
            this.txtBookPrice.Name = "txtBookPrice";
            this.txtBookPrice.Size = new System.Drawing.Size(100, 20);
            this.txtBookPrice.TabIndex = 12;
            // 
            // txtBookAuthor
            // 
            this.txtBookAuthor.Location = new System.Drawing.Point(275, 207);
            this.txtBookAuthor.Name = "txtBookAuthor";
            this.txtBookAuthor.Size = new System.Drawing.Size(100, 20);
            this.txtBookAuthor.TabIndex = 14;
            // 
            // txtBookEdition
            // 
            this.txtBookEdition.Location = new System.Drawing.Point(275, 256);
            this.txtBookEdition.Name = "txtBookEdition";
            this.txtBookEdition.Size = new System.Drawing.Size(100, 20);
            this.txtBookEdition.TabIndex = 16;
            // 
            // txtBookPublication
            // 
            this.txtBookPublication.Location = new System.Drawing.Point(275, 319);
            this.txtBookPublication.Name = "txtBookPublication";
            this.txtBookPublication.Size = new System.Drawing.Size(100, 20);
            this.txtBookPublication.TabIndex = 18;
            // 
            // btnBinaryWrite
            // 
            this.btnBinaryWrite.Location = new System.Drawing.Point(42, 384);
            this.btnBinaryWrite.Name = "btnBinaryWrite";
            this.btnBinaryWrite.Size = new System.Drawing.Size(75, 23);
            this.btnBinaryWrite.TabIndex = 19;
            this.btnBinaryWrite.Text = "Binary Write";
            this.btnBinaryWrite.UseVisualStyleBackColor = true;
            this.btnBinaryWrite.Click += new System.EventHandler(this.btnBinaryWrite_Click);
            // 
            // btnBinaryRead
            // 
            this.btnBinaryRead.Location = new System.Drawing.Point(170, 384);
            this.btnBinaryRead.Name = "btnBinaryRead";
            this.btnBinaryRead.Size = new System.Drawing.Size(75, 23);
            this.btnBinaryRead.TabIndex = 20;
            this.btnBinaryRead.Text = "Binary Read";
            this.btnBinaryRead.UseVisualStyleBackColor = true;
            this.btnBinaryRead.Click += new System.EventHandler(this.btnBinaryRead_Click);
            // 
            // btnXMLWrite
            // 
            this.btnXMLWrite.Location = new System.Drawing.Point(302, 384);
            this.btnXMLWrite.Name = "btnXMLWrite";
            this.btnXMLWrite.Size = new System.Drawing.Size(75, 23);
            this.btnXMLWrite.TabIndex = 21;
            this.btnXMLWrite.Text = "XML Write";
            this.btnXMLWrite.UseVisualStyleBackColor = true;
            this.btnXMLWrite.Click += new System.EventHandler(this.btnXMLWrite_Click);
            // 
            // btnXMLRead
            // 
            this.btnXMLRead.Location = new System.Drawing.Point(431, 384);
            this.btnXMLRead.Name = "btnXMLRead";
            this.btnXMLRead.Size = new System.Drawing.Size(75, 23);
            this.btnXMLRead.TabIndex = 22;
            this.btnXMLRead.Text = "XML Read";
            this.btnXMLRead.UseVisualStyleBackColor = true;
            this.btnXMLRead.Click += new System.EventHandler(this.btnXMLRead_Click);
            // 
            // btnSOAPWrite
            // 
            this.btnSOAPWrite.Location = new System.Drawing.Point(517, 60);
            this.btnSOAPWrite.Name = "btnSOAPWrite";
            this.btnSOAPWrite.Size = new System.Drawing.Size(75, 23);
            this.btnSOAPWrite.TabIndex = 23;
            this.btnSOAPWrite.Text = "SOAP Write";
            this.btnSOAPWrite.UseVisualStyleBackColor = true;
            this.btnSOAPWrite.Click += new System.EventHandler(this.btnSOAPWrite_Click);
            // 
            // btnJSONWrite
            // 
            this.btnJSONWrite.Location = new System.Drawing.Point(517, 130);
            this.btnJSONWrite.Name = "btnJSONWrite";
            this.btnJSONWrite.Size = new System.Drawing.Size(75, 23);
            this.btnJSONWrite.TabIndex = 24;
            this.btnJSONWrite.Text = "JSON Write";
            this.btnJSONWrite.UseVisualStyleBackColor = true;
            this.btnJSONWrite.Click += new System.EventHandler(this.btnJSONWrite_Click);
            // 
            // btnSOAPRead
            // 
            this.btnSOAPRead.Location = new System.Drawing.Point(645, 60);
            this.btnSOAPRead.Name = "btnSOAPRead";
            this.btnSOAPRead.Size = new System.Drawing.Size(75, 23);
            this.btnSOAPRead.TabIndex = 25;
            this.btnSOAPRead.Text = "SOAP Read";
            this.btnSOAPRead.UseVisualStyleBackColor = true;
            this.btnSOAPRead.Click += new System.EventHandler(this.btnSOAPRead_Click);
            // 
            // btnJSONRead
            // 
            this.btnJSONRead.Location = new System.Drawing.Point(645, 130);
            this.btnJSONRead.Name = "btnJSONRead";
            this.btnJSONRead.Size = new System.Drawing.Size(75, 23);
            this.btnJSONRead.TabIndex = 26;
            this.btnJSONRead.Text = "JSON Read";
            this.btnJSONRead.UseVisualStyleBackColor = true;
            this.btnJSONRead.Click += new System.EventHandler(this.btnJSONRead_Click);
            // 
            // btnClearData
            // 
            this.btnClearData.Location = new System.Drawing.Point(447, 222);
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.Size = new System.Drawing.Size(75, 23);
            this.btnClearData.TabIndex = 27;
            this.btnClearData.Text = "Clear Data";
            this.btnClearData.UseVisualStyleBackColor = true;
            // 
            // BookFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClearData);
            this.Controls.Add(this.btnJSONRead);
            this.Controls.Add(this.btnSOAPRead);
            this.Controls.Add(this.btnJSONWrite);
            this.Controls.Add(this.btnSOAPWrite);
            this.Controls.Add(this.btnXMLRead);
            this.Controls.Add(this.btnXMLWrite);
            this.Controls.Add(this.btnBinaryRead);
            this.Controls.Add(this.btnBinaryWrite);
            this.Controls.Add(this.txtBookPublication);
            this.Controls.Add(this.txtBookEdition);
            this.Controls.Add(this.txtBookAuthor);
            this.Controls.Add(this.txtBookPrice);
            this.Controls.Add(this.txtBookId);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BookFrom";
            this.Text = "Form7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.TextBox txtBookPrice;
        private System.Windows.Forms.TextBox txtBookAuthor;
        private System.Windows.Forms.TextBox txtBookEdition;
        private System.Windows.Forms.TextBox txtBookPublication;
        private System.Windows.Forms.Button btnBinaryWrite;
        private System.Windows.Forms.Button btnBinaryRead;
        private System.Windows.Forms.Button btnXMLWrite;
        private System.Windows.Forms.Button btnXMLRead;
        private System.Windows.Forms.Button btnSOAPWrite;
        private System.Windows.Forms.Button btnJSONWrite;
        private System.Windows.Forms.Button btnSOAPRead;
        private System.Windows.Forms.Button btnJSONRead;
        private System.Windows.Forms.Button btnClearData;
    }
}