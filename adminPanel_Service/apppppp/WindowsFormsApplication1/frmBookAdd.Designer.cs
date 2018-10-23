namespace WindowsFormsApplication1
{
    partial class frmBookAdd
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtFormat = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLangu = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPageNumber = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTranslator = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEdition = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPublicationDate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEditor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(175, 250);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(221, 23);
            this.btnAdd.TabIndex = 56;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(361, 188);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(100, 20);
            this.txtISBN.TabIndex = 55;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(279, 195);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 54;
            this.label13.Text = "ISBN:";
            // 
            // txtFormat
            // 
            this.txtFormat.Location = new System.Drawing.Point(140, 189);
            this.txtFormat.Name = "txtFormat";
            this.txtFormat.Size = new System.Drawing.Size(100, 20);
            this.txtFormat.TabIndex = 53;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(66, 192);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 52;
            this.label14.Text = "Formatı:";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(361, 161);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(100, 20);
            this.txtSize.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(279, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 50;
            this.label9.Text = "Boyut:";
            // 
            // txtLangu
            // 
            this.txtLangu.Location = new System.Drawing.Point(361, 135);
            this.txtLangu.Name = "txtLangu";
            this.txtLangu.Size = new System.Drawing.Size(100, 20);
            this.txtLangu.TabIndex = 49;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(278, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 13);
            this.label10.TabIndex = 48;
            this.label10.Text = "Dil:";
            // 
            // txtPageNumber
            // 
            this.txtPageNumber.Location = new System.Drawing.Point(140, 163);
            this.txtPageNumber.Name = "txtPageNumber";
            this.txtPageNumber.Size = new System.Drawing.Size(100, 20);
            this.txtPageNumber.TabIndex = 47;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(67, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 46;
            this.label11.Text = "Sayfa Sayısı:";
            // 
            // txtTranslator
            // 
            this.txtTranslator.Location = new System.Drawing.Point(140, 137);
            this.txtTranslator.Name = "txtTranslator";
            this.txtTranslator.Size = new System.Drawing.Size(100, 20);
            this.txtTranslator.TabIndex = 45;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(67, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 44;
            this.label12.Text = "Çevirmen:";
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(361, 109);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(100, 20);
            this.txtBalance.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Fiyat:";
            // 
            // txtEdition
            // 
            this.txtEdition.Location = new System.Drawing.Point(361, 83);
            this.txtEdition.Name = "txtEdition";
            this.txtEdition.Size = new System.Drawing.Size(100, 20);
            this.txtEdition.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(279, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Baskı:";
            // 
            // txtPublicationDate
            // 
            this.txtPublicationDate.Location = new System.Drawing.Point(361, 56);
            this.txtPublicationDate.Name = "txtPublicationDate";
            this.txtPublicationDate.Size = new System.Drawing.Size(100, 20);
            this.txtPublicationDate.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(278, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Yayın Tarihi:";
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(361, 30);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(100, 20);
            this.txtPublisher.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(278, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Yayın Evi:";
            // 
            // txtEditor
            // 
            this.txtEditor.Location = new System.Drawing.Point(140, 111);
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.Size = new System.Drawing.Size(100, 20);
            this.txtEditor.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Editör:";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(140, 85);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(100, 20);
            this.txtType.TabIndex = 33;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(140, 59);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(100, 20);
            this.txtAuthor.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Yazar Adı:";
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(140, 33);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(100, 20);
            this.txtBookName.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Kitap Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Türü:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(223, 294);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(132, 13);
            this.label15.TabIndex = 58;
            this.label15.Text = "Bütün Verileri Doldurunuz !";
            // 
            // frmBookAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 333);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtFormat);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtLangu);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPageNumber);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTranslator);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEdition);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPublicationDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPublisher);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEditor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.label1);
            this.Name = "frmBookAdd";
            this.Text = "frmBookAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtFormat;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLangu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPageNumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTranslator;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEdition;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPublicationDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEditor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label15;
    }
}