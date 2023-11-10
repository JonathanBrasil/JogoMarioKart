namespace MarioKart
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.p2 = new System.Windows.Forms.PictureBox();
            this.p1 = new System.Windows.Forms.PictureBox();
            this.p3 = new System.Windows.Forms.PictureBox();
            this.p4 = new System.Windows.Forms.PictureBox();
            this.Selecao = new System.Windows.Forms.GroupBox();
            this.btstart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btreiniciar = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblpersonagem1 = new System.Windows.Forms.Label();
            this.lblpersonagem3 = new System.Windows.Forms.Label();
            this.lblpersonagem2 = new System.Windows.Forms.Label();
            this.lblpersonagem4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4)).BeginInit();
            this.Selecao.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1254, 327);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(285, 70);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(0, 0);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // p2
            // 
            this.p2.Location = new System.Drawing.Point(40, 111);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(56, 56);
            this.p2.TabIndex = 2;
            this.p2.TabStop = false;
            this.p2.Visible = false;
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.Color.Transparent;
            this.p1.Location = new System.Drawing.Point(40, 35);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(56, 56);
            this.p1.TabIndex = 3;
            this.p1.TabStop = false;
            this.p1.Visible = false;
            // 
            // p3
            // 
            this.p3.Location = new System.Drawing.Point(40, 187);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(56, 56);
            this.p3.TabIndex = 4;
            this.p3.TabStop = false;
            this.p3.Visible = false;
            // 
            // p4
            // 
            this.p4.Location = new System.Drawing.Point(40, 263);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(56, 56);
            this.p4.TabIndex = 5;
            this.p4.TabStop = false;
            this.p4.Visible = false;
            // 
            // Selecao
            // 
            this.Selecao.BackColor = System.Drawing.Color.Transparent;
            this.Selecao.Controls.Add(this.groupBox2);
            this.Selecao.Controls.Add(this.comboBox4);
            this.Selecao.Controls.Add(this.comboBox3);
            this.Selecao.Controls.Add(this.comboBox2);
            this.Selecao.Controls.Add(this.comboBox1);
            this.Selecao.Controls.Add(this.lblpersonagem4);
            this.Selecao.Controls.Add(this.lblpersonagem2);
            this.Selecao.Controls.Add(this.lblpersonagem3);
            this.Selecao.Controls.Add(this.lblpersonagem1);
            this.Selecao.Controls.Add(this.pictureBox3);
            this.Selecao.Controls.Add(this.btstart);
            this.Selecao.Location = new System.Drawing.Point(12, 357);
            this.Selecao.Name = "Selecao";
            this.Selecao.Size = new System.Drawing.Size(747, 263);
            this.Selecao.TabIndex = 6;
            this.Selecao.TabStop = false;
            this.Selecao.Text = "Seleção de Personagem";
            this.Selecao.Enter += new System.EventHandler(this.Selecao_Enter);
            // 
            // btstart
            // 
            this.btstart.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btstart.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btstart.Location = new System.Drawing.Point(28, 232);
            this.btstart.Name = "btstart";
            this.btstart.Size = new System.Drawing.Size(101, 25);
            this.btstart.TabIndex = 0;
            this.btstart.Text = "START";
            this.btstart.UseVisualStyleBackColor = false;
            this.btstart.Click += new System.EventHandler(this.btstart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btreiniciar);
            this.groupBox1.Location = new System.Drawing.Point(779, 357);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 263);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vencedor";
            this.groupBox1.Visible = false;
            // 
            // btreiniciar
            // 
            this.btreiniciar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btreiniciar.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btreiniciar.Location = new System.Drawing.Point(6, 232);
            this.btreiniciar.Name = "btreiniciar";
            this.btreiniciar.Size = new System.Drawing.Size(111, 25);
            this.btreiniciar.TabIndex = 0;
            this.btreiniciar.Text = "REINICIAR";
            this.btreiniciar.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(321, 13);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(424, 244);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // lblpersonagem1
            // 
            this.lblpersonagem1.AutoSize = true;
            this.lblpersonagem1.Location = new System.Drawing.Point(25, 46);
            this.lblpersonagem1.Name = "lblpersonagem1";
            this.lblpersonagem1.Size = new System.Drawing.Size(78, 13);
            this.lblpersonagem1.TabIndex = 2;
            this.lblpersonagem1.Text = "Personagem 1:";
            this.lblpersonagem1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblpersonagem3
            // 
            this.lblpersonagem3.AutoSize = true;
            this.lblpersonagem3.Location = new System.Drawing.Point(25, 134);
            this.lblpersonagem3.Name = "lblpersonagem3";
            this.lblpersonagem3.Size = new System.Drawing.Size(78, 13);
            this.lblpersonagem3.TabIndex = 3;
            this.lblpersonagem3.Text = "Personagem 3:";
            this.lblpersonagem3.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblpersonagem2
            // 
            this.lblpersonagem2.AutoSize = true;
            this.lblpersonagem2.Location = new System.Drawing.Point(25, 90);
            this.lblpersonagem2.Name = "lblpersonagem2";
            this.lblpersonagem2.Size = new System.Drawing.Size(78, 13);
            this.lblpersonagem2.TabIndex = 4;
            this.lblpersonagem2.Text = "Personagem 2:";
            this.lblpersonagem2.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblpersonagem4
            // 
            this.lblpersonagem4.AutoSize = true;
            this.lblpersonagem4.Location = new System.Drawing.Point(25, 178);
            this.lblpersonagem4.Name = "lblpersonagem4";
            this.lblpersonagem4.Size = new System.Drawing.Size(78, 13);
            this.lblpersonagem4.TabIndex = 5;
            this.lblpersonagem4.Text = "Personagem 4:";
            this.lblpersonagem4.Click += new System.EventHandler(this.label4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Yoshi",
            "Mario",
            "Luigi",
            "Peach",
            "Bowser",
            "Koopa",
            "Toad",
            "DK"});
            this.comboBox1.Location = new System.Drawing.Point(121, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(134, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Yoshi",
            "Mario",
            "Luigi",
            "Peach",
            "Bowser",
            "Koopa",
            "Toad",
            "DK"});
            this.comboBox2.Location = new System.Drawing.Point(121, 87);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(134, 21);
            this.comboBox2.TabIndex = 7;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Yoshi",
            "Mario",
            "Luigi",
            "Peach",
            "Bowser",
            "Koopa",
            "Toad",
            "DK"});
            this.comboBox3.Location = new System.Drawing.Point(121, 131);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(134, 21);
            this.comboBox3.TabIndex = 8;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Yoshi",
            "Mario",
            "Luigi",
            "Peach",
            "Bowser",
            "Koopa",
            "Toad",
            "DK"});
            this.comboBox4.Location = new System.Drawing.Point(121, 175);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(134, 21);
            this.comboBox4.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Khaki;
            this.groupBox2.Location = new System.Drawing.Point(376, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(78, 66);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "P1";
            this.groupBox2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 632);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Selecao);
            this.Controls.Add(this.p4);
            this.Controls.Add(this.p3);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4)).EndInit();
            this.Selecao.ResumeLayout(false);
            this.Selecao.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox p2;
        private System.Windows.Forms.PictureBox p1;
        private System.Windows.Forms.PictureBox p3;
        private System.Windows.Forms.PictureBox p4;
        private System.Windows.Forms.GroupBox Selecao;
        private System.Windows.Forms.Button btstart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btreiniciar;
        private System.Windows.Forms.Label lblpersonagem1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblpersonagem4;
        private System.Windows.Forms.Label lblpersonagem2;
        private System.Windows.Forms.Label lblpersonagem3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

