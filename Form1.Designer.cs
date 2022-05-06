
namespace UAMotivationApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnChernobaivka = new System.Windows.Forms.Button();
            this.btnHuylo = new System.Windows.Forms.Button();
            this.btnArestovich = new System.Windows.Forms.Button();
            this.btnDon = new System.Windows.Forms.Button();
            this.btnBulbo = new System.Windows.Forms.Button();
            this.btnMertvetchuk = new System.Windows.Forms.Button();
            this.btnGeneral = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnWarship = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(40, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1080, 531);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnChernobaivka
            // 
            this.btnChernobaivka.Location = new System.Drawing.Point(291, 24);
            this.btnChernobaivka.Margin = new System.Windows.Forms.Padding(2);
            this.btnChernobaivka.Name = "btnChernobaivka";
            this.btnChernobaivka.Size = new System.Drawing.Size(92, 46);
            this.btnChernobaivka.TabIndex = 1;
            this.btnChernobaivka.Tag = "btnChernobaivka";
            this.btnChernobaivka.Text = "Чорнобаївка";
            this.btnChernobaivka.UseVisualStyleBackColor = true;
            this.btnChernobaivka.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnHuylo
            // 
            this.btnHuylo.Location = new System.Drawing.Point(157, 24);
            this.btnHuylo.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuylo.Name = "btnHuylo";
            this.btnHuylo.Size = new System.Drawing.Size(95, 46);
            this.btnHuylo.TabIndex = 2;
            this.btnHuylo.Tag = "btnHuylo";
            this.btnHuylo.Text = "Хуйло";
            this.btnHuylo.UseVisualStyleBackColor = true;
            this.btnHuylo.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnArestovich
            // 
            this.btnArestovich.Location = new System.Drawing.Point(28, 24);
            this.btnArestovich.Margin = new System.Windows.Forms.Padding(2);
            this.btnArestovich.Name = "btnArestovich";
            this.btnArestovich.Size = new System.Drawing.Size(101, 46);
            this.btnArestovich.TabIndex = 3;
            this.btnArestovich.Tag = "btnArestovich";
            this.btnArestovich.Text = "Арестовіч";
            this.btnArestovich.UseVisualStyleBackColor = true;
            this.btnArestovich.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnDon
            // 
            this.btnDon.Location = new System.Drawing.Point(791, 24);
            this.btnDon.Margin = new System.Windows.Forms.Padding(2);
            this.btnDon.Name = "btnDon";
            this.btnDon.Size = new System.Drawing.Size(100, 46);
            this.btnDon.TabIndex = 4;
            this.btnDon.Tag = "btnDon";
            this.btnDon.Text = "Тік-токдиров";
            this.btnDon.UseVisualStyleBackColor = true;
            this.btnDon.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnBulbo
            // 
            this.btnBulbo.Location = new System.Drawing.Point(420, 24);
            this.btnBulbo.Margin = new System.Windows.Forms.Padding(2);
            this.btnBulbo.Name = "btnBulbo";
            this.btnBulbo.Size = new System.Drawing.Size(86, 46);
            this.btnBulbo.TabIndex = 5;
            this.btnBulbo.Tag = "btnBulbo";
            this.btnBulbo.Text = "Бульбофюрер";
            this.btnBulbo.UseVisualStyleBackColor = true;
            this.btnBulbo.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnMertvetchuk
            // 
            this.btnMertvetchuk.Location = new System.Drawing.Point(535, 24);
            this.btnMertvetchuk.Margin = new System.Windows.Forms.Padding(2);
            this.btnMertvetchuk.Name = "btnMertvetchuk";
            this.btnMertvetchuk.Size = new System.Drawing.Size(97, 46);
            this.btnMertvetchuk.TabIndex = 6;
            this.btnMertvetchuk.Tag = "btnMertvetchuk";
            this.btnMertvetchuk.Text = "Мертветчук";
            this.btnMertvetchuk.UseVisualStyleBackColor = true;
            this.btnMertvetchuk.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnGeneral
            // 
            this.btnGeneral.Location = new System.Drawing.Point(668, 24);
            this.btnGeneral.Margin = new System.Windows.Forms.Padding(2);
            this.btnGeneral.Name = "btnGeneral";
            this.btnGeneral.Size = new System.Drawing.Size(92, 46);
            this.btnGeneral.TabIndex = 7;
            this.btnGeneral.Tag = "btnGeneral";
            this.btnGeneral.Text = "Усіляке різне";
            this.btnGeneral.UseVisualStyleBackColor = true;
            this.btnGeneral.Click += new System.EventHandler(this.BtnClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnWarship);
            this.panel1.Controls.Add(this.btnGeneral);
            this.panel1.Controls.Add(this.btnArestovich);
            this.panel1.Controls.Add(this.btnDon);
            this.panel1.Controls.Add(this.btnHuylo);
            this.panel1.Controls.Add(this.btnBulbo);
            this.panel1.Controls.Add(this.btnChernobaivka);
            this.panel1.Controls.Add(this.btnMertvetchuk);
            this.panel1.Location = new System.Drawing.Point(40, 545);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 84);
            this.panel1.TabIndex = 8;
            // 
            // btnWarship
            // 
            this.btnWarship.Location = new System.Drawing.Point(926, 24);
            this.btnWarship.Margin = new System.Windows.Forms.Padding(2);
            this.btnWarship.Name = "btnWarship";
            this.btnWarship.Size = new System.Drawing.Size(118, 46);
            this.btnWarship.TabIndex = 9;
            this.btnWarship.Tag = "btnWarship";
            this.btnWarship.Text = "Рускій ваєний карабль";
            this.btnWarship.UseVisualStyleBackColor = true;
            this.btnWarship.Click += new System.EventHandler(this.BtnClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 631);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "UA Motivation";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnChernobaivka;
        private System.Windows.Forms.Button btnHuylo;
        private System.Windows.Forms.Button btnArestovich;
        private System.Windows.Forms.Button btnDon;
        private System.Windows.Forms.Button btnBulbo;
        private System.Windows.Forms.Button btnMertvetchuk;
        private System.Windows.Forms.Button btnGeneral;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnWarship;
    }
}

