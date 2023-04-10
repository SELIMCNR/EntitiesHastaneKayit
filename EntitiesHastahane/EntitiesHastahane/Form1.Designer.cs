namespace EntitiesHastahane
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
            this.Text_Doktor = new System.Windows.Forms.TextBox();
            this.Text_Hasta = new System.Windows.Forms.TextBox();
            this.Text_Tarıh = new System.Windows.Forms.TextBox();
            this.Text_Ucret = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Text_Bul_Doktor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Text_Bul_Hasta = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doktor adı ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasta Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "M.TARIHI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "M.Ucreti";
            // 
            // Text_Doktor
            // 
            this.Text_Doktor.Location = new System.Drawing.Point(132, 38);
            this.Text_Doktor.Name = "Text_Doktor";
            this.Text_Doktor.Size = new System.Drawing.Size(170, 22);
            this.Text_Doktor.TabIndex = 4;
            // 
            // Text_Hasta
            // 
            this.Text_Hasta.Location = new System.Drawing.Point(132, 75);
            this.Text_Hasta.Name = "Text_Hasta";
            this.Text_Hasta.Size = new System.Drawing.Size(170, 22);
            this.Text_Hasta.TabIndex = 4;
            // 
            // Text_Tarıh
            // 
            this.Text_Tarıh.Location = new System.Drawing.Point(132, 115);
            this.Text_Tarıh.Name = "Text_Tarıh";
            this.Text_Tarıh.Size = new System.Drawing.Size(170, 22);
            this.Text_Tarıh.TabIndex = 4;
            // 
            // Text_Ucret
            // 
            this.Text_Ucret.Location = new System.Drawing.Point(132, 155);
            this.Text_Ucret.Name = "Text_Ucret";
            this.Text_Ucret.Size = new System.Drawing.Size(170, 22);
            this.Text_Ucret.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Kaydet);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 246);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(795, 296);
            this.dataGridView1.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(309, 113);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(115, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Sorgu 1 ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.sorgu);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(174, 216);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Listele";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.listele);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(255, 216);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Sil";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.sil);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(336, 216);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "LinqSilme";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(435, 215);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(138, 24);
            this.button6.TabIndex = 12;
            this.button6.Text = "Değiştir-Güncelle";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(706, 34);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(121, 23);
            this.button7.TabIndex = 13;
            this.button7.Text = "Doktor Bulma İşlemi";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(394, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Bulunacak Doktor İsimi ";
            // 
            // Text_Bul_Doktor
            // 
            this.Text_Bul_Doktor.Location = new System.Drawing.Point(558, 34);
            this.Text_Bul_Doktor.Name = "Text_Bul_Doktor";
            this.Text_Bul_Doktor.Size = new System.Drawing.Size(142, 22);
            this.Text_Bul_Doktor.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(394, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Bulunacak Hasta İsimi ";
            // 
            // Text_Bul_Hasta
            // 
            this.Text_Bul_Hasta.Location = new System.Drawing.Point(558, 66);
            this.Text_Bul_Hasta.Name = "Text_Bul_Hasta";
            this.Text_Bul_Hasta.Size = new System.Drawing.Size(142, 22);
            this.Text_Bul_Hasta.TabIndex = 17;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(706, 66);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(121, 23);
            this.button8.TabIndex = 18;
            this.button8.Text = "Hasta Bulma İşlemi";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(579, 215);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(133, 23);
            this.button10.TabIndex = 20;
            this.button10.Text = "ÖdemeToplamı";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(718, 216);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 21;
            this.button11.Text = "Order";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 554);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.Text_Bul_Hasta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Text_Bul_Doktor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Text_Ucret);
            this.Controls.Add(this.Text_Tarıh);
            this.Controls.Add(this.Text_Hasta);
            this.Controls.Add(this.Text_Doktor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
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
        private System.Windows.Forms.TextBox Text_Doktor;
        private System.Windows.Forms.TextBox Text_Hasta;
        private System.Windows.Forms.TextBox Text_Tarıh;
        private System.Windows.Forms.TextBox Text_Ucret;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Text_Bul_Doktor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Text_Bul_Hasta;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
    }
}

