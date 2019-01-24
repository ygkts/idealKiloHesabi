namespace u7_idealKiloHesabi
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
            this.lblDyıl = new System.Windows.Forms.Label();
            this.lblBoy = new System.Windows.Forms.Label();
            this.lblCins = new System.Windows.Forms.Label();
            this.lblGKilo = new System.Windows.Forms.Label();
            this.txtDYil = new System.Windows.Forms.TextBox();
            this.txtBoy = new System.Windows.Forms.TextBox();
            this.txtCins = new System.Windows.Forms.TextBox();
            this.txtGKilo = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDyıl
            // 
            this.lblDyıl.AutoSize = true;
            this.lblDyıl.Location = new System.Drawing.Point(79, 154);
            this.lblDyıl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDyıl.Name = "lblDyıl";
            this.lblDyıl.Size = new System.Drawing.Size(85, 17);
            this.lblDyıl.TabIndex = 0;
            this.lblDyıl.Text = "Doğum yılı : ";
            // 
            // lblBoy
            // 
            this.lblBoy.AutoSize = true;
            this.lblBoy.Location = new System.Drawing.Point(412, 154);
            this.lblBoy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBoy.Name = "lblBoy";
            this.lblBoy.Size = new System.Drawing.Size(44, 17);
            this.lblBoy.TabIndex = 1;
            this.lblBoy.Text = "Boy : ";
            // 
            // lblCins
            // 
            this.lblCins.AutoSize = true;
            this.lblCins.Location = new System.Drawing.Point(95, 214);
            this.lblCins.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCins.Name = "lblCins";
            this.lblCins.Size = new System.Drawing.Size(69, 17);
            this.lblCins.TabIndex = 2;
            this.lblCins.Text = "Cinsiyet : ";
            // 
            // lblGKilo
            // 
            this.lblGKilo.AutoSize = true;
            this.lblGKilo.Location = new System.Drawing.Point(363, 214);
            this.lblGKilo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGKilo.Name = "lblGKilo";
            this.lblGKilo.Size = new System.Drawing.Size(93, 17);
            this.lblGKilo.TabIndex = 3;
            this.lblGKilo.Text = "Gerçek Kilo : ";
            // 
            // txtDYil
            // 
            this.txtDYil.Location = new System.Drawing.Point(188, 150);
            this.txtDYil.Margin = new System.Windows.Forms.Padding(4);
            this.txtDYil.Name = "txtDYil";
            this.txtDYil.Size = new System.Drawing.Size(132, 22);
            this.txtDYil.TabIndex = 4;
            // 
            // txtBoy
            // 
            this.txtBoy.Location = new System.Drawing.Point(479, 150);
            this.txtBoy.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoy.Name = "txtBoy";
            this.txtBoy.Size = new System.Drawing.Size(132, 22);
            this.txtBoy.TabIndex = 5;
            // 
            // txtCins
            // 
            this.txtCins.Location = new System.Drawing.Point(188, 210);
            this.txtCins.Margin = new System.Windows.Forms.Padding(4);
            this.txtCins.Name = "txtCins";
            this.txtCins.Size = new System.Drawing.Size(132, 22);
            this.txtCins.TabIndex = 6;
            // 
            // txtGKilo
            // 
            this.txtGKilo.Location = new System.Drawing.Point(479, 210);
            this.txtGKilo.Margin = new System.Windows.Forms.Padding(4);
            this.txtGKilo.Name = "txtGKilo";
            this.txtGKilo.Size = new System.Drawing.Size(132, 22);
            this.txtGKilo.TabIndex = 7;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Location = new System.Drawing.Point(111, 318);
            this.btnHesapla.Margin = new System.Windows.Forms.Padding(4);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(440, 28);
            this.btnHesapla.TabIndex = 8;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Jokerman", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(538, 43);
            this.label1.TabIndex = 10;
            this.label1.Text = "İdeal Kilo Hesabı İçin Bilgileri Giriniz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(671, 398);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtGKilo);
            this.Controls.Add(this.txtCins);
            this.Controls.Add(this.txtBoy);
            this.Controls.Add(this.txtDYil);
            this.Controls.Add(this.lblGKilo);
            this.Controls.Add(this.lblCins);
            this.Controls.Add(this.lblBoy);
            this.Controls.Add(this.lblDyıl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "İdeal Kilo Hesabi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDyıl;
        private System.Windows.Forms.Label lblBoy;
        private System.Windows.Forms.Label lblCins;
        private System.Windows.Forms.Label lblGKilo;
        private System.Windows.Forms.TextBox txtDYil;
        private System.Windows.Forms.TextBox txtBoy;
        private System.Windows.Forms.TextBox txtCins;
        private System.Windows.Forms.TextBox txtGKilo;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label label1;
    }
}

