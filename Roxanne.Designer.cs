namespace PokeTracker
{
    partial class Roxanne
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Roxanne));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GymPK1 = new System.Windows.Forms.Button();
            this.GymPK2 = new System.Windows.Forms.Button();
            this.GymPK3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.HP = new System.Windows.Forms.TextBox();
            this.SPE = new System.Windows.Forms.TextBox();
            this.SPD = new System.Windows.Forms.TextBox();
            this.SPA = new System.Windows.Forms.TextBox();
            this.DEF = new System.Windows.Forms.TextBox();
            this.ATK = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PPK1 = new System.Windows.Forms.Button();
            this.PPK2 = new System.Windows.Forms.Button();
            this.PPK3 = new System.Windows.Forms.Button();
            this.PPK4 = new System.Windows.Forms.Button();
            this.PPK5 = new System.Windows.Forms.Button();
            this.PPK6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PokeTracker.Properties.Resources.Roxanne;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // GymPK1
            // 
            this.GymPK1.Location = new System.Drawing.Point(101, 32);
            this.GymPK1.Name = "GymPK1";
            this.GymPK1.Size = new System.Drawing.Size(95, 30);
            this.GymPK1.TabIndex = 39;
            this.GymPK1.Text = "Geodude";
            this.GymPK1.UseVisualStyleBackColor = true;
            this.GymPK1.Click += new System.EventHandler(this.GymPK1_Click);
            // 
            // GymPK2
            // 
            this.GymPK2.Location = new System.Drawing.Point(202, 32);
            this.GymPK2.Name = "GymPK2";
            this.GymPK2.Size = new System.Drawing.Size(95, 30);
            this.GymPK2.TabIndex = 40;
            this.GymPK2.Text = "Geodude";
            this.GymPK2.UseVisualStyleBackColor = true;
            this.GymPK2.Click += new System.EventHandler(this.GymPK2_Click);
            // 
            // GymPK3
            // 
            this.GymPK3.Location = new System.Drawing.Point(101, 69);
            this.GymPK3.Name = "GymPK3";
            this.GymPK3.Size = new System.Drawing.Size(95, 30);
            this.GymPK3.TabIndex = 41;
            this.GymPK3.Text = "Nosepass";
            this.GymPK3.UseVisualStyleBackColor = true;
            this.GymPK3.Click += new System.EventHandler(this.GymPK3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 143);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(776, 23);
            this.textBox1.TabIndex = 42;
            // 
            // HP
            // 
            this.HP.Location = new System.Drawing.Point(12, 172);
            this.HP.Name = "HP";
            this.HP.ReadOnly = true;
            this.HP.Size = new System.Drawing.Size(100, 23);
            this.HP.TabIndex = 50;
            // 
            // SPE
            // 
            this.SPE.Location = new System.Drawing.Point(12, 317);
            this.SPE.Name = "SPE";
            this.SPE.ReadOnly = true;
            this.SPE.Size = new System.Drawing.Size(100, 23);
            this.SPE.TabIndex = 51;
            // 
            // SPD
            // 
            this.SPD.Location = new System.Drawing.Point(12, 288);
            this.SPD.Name = "SPD";
            this.SPD.ReadOnly = true;
            this.SPD.Size = new System.Drawing.Size(100, 23);
            this.SPD.TabIndex = 52;
            // 
            // SPA
            // 
            this.SPA.Location = new System.Drawing.Point(12, 259);
            this.SPA.Name = "SPA";
            this.SPA.ReadOnly = true;
            this.SPA.Size = new System.Drawing.Size(100, 23);
            this.SPA.TabIndex = 53;
            // 
            // DEF
            // 
            this.DEF.Location = new System.Drawing.Point(12, 230);
            this.DEF.Name = "DEF";
            this.DEF.ReadOnly = true;
            this.DEF.Size = new System.Drawing.Size(100, 23);
            this.DEF.TabIndex = 54;
            // 
            // ATK
            // 
            this.ATK.Location = new System.Drawing.Point(12, 201);
            this.ATK.Name = "ATK";
            this.ATK.ReadOnly = true;
            this.ATK.Size = new System.Drawing.Size(100, 23);
            this.ATK.TabIndex = 55;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Bug.png");
            this.imageList1.Images.SetKeyName(1, "Dark.png");
            this.imageList1.Images.SetKeyName(2, "Dragon.png");
            this.imageList1.Images.SetKeyName(3, "Electric.png");
            this.imageList1.Images.SetKeyName(4, "Fairy.png");
            this.imageList1.Images.SetKeyName(5, "Fighting.png");
            this.imageList1.Images.SetKeyName(6, "Fire.png");
            this.imageList1.Images.SetKeyName(7, "Flying.png");
            this.imageList1.Images.SetKeyName(8, "Ghost.png");
            this.imageList1.Images.SetKeyName(9, "Grass.png");
            this.imageList1.Images.SetKeyName(10, "Ground.png");
            this.imageList1.Images.SetKeyName(11, "Ice.png");
            this.imageList1.Images.SetKeyName(12, "Normal.png");
            this.imageList1.Images.SetKeyName(13, "Poison.png");
            this.imageList1.Images.SetKeyName(14, "Psychic.png");
            this.imageList1.Images.SetKeyName(15, "Rock.png");
            this.imageList1.Images.SetKeyName(16, "Steel.png");
            this.imageList1.Images.SetKeyName(17, "Water.png");
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PokeTracker.Properties.Resources.EmeraldMale;
            this.pictureBox2.Location = new System.Drawing.Point(708, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(83, 125);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 56;
            this.pictureBox2.TabStop = false;
            // 
            // PPK1
            // 
            this.PPK1.Location = new System.Drawing.Point(508, 32);
            this.PPK1.Name = "PPK1";
            this.PPK1.Size = new System.Drawing.Size(95, 30);
            this.PPK1.TabIndex = 57;
            this.PPK1.UseVisualStyleBackColor = true;
            this.PPK1.Click += new System.EventHandler(this.PPK1_Click);
            // 
            // PPK2
            // 
            this.PPK2.Location = new System.Drawing.Point(608, 32);
            this.PPK2.Name = "PPK2";
            this.PPK2.Size = new System.Drawing.Size(95, 30);
            this.PPK2.TabIndex = 58;
            this.PPK2.UseVisualStyleBackColor = true;
            // 
            // PPK3
            // 
            this.PPK3.Location = new System.Drawing.Point(508, 69);
            this.PPK3.Name = "PPK3";
            this.PPK3.Size = new System.Drawing.Size(95, 30);
            this.PPK3.TabIndex = 59;
            this.PPK3.UseVisualStyleBackColor = true;
            // 
            // PPK4
            // 
            this.PPK4.Location = new System.Drawing.Point(608, 69);
            this.PPK4.Name = "PPK4";
            this.PPK4.Size = new System.Drawing.Size(95, 30);
            this.PPK4.TabIndex = 60;
            this.PPK4.UseVisualStyleBackColor = true;
            // 
            // PPK5
            // 
            this.PPK5.Location = new System.Drawing.Point(508, 106);
            this.PPK5.Name = "PPK5";
            this.PPK5.Size = new System.Drawing.Size(95, 30);
            this.PPK5.TabIndex = 61;
            this.PPK5.UseVisualStyleBackColor = true;
            // 
            // PPK6
            // 
            this.PPK6.Location = new System.Drawing.Point(608, 106);
            this.PPK6.Name = "PPK6";
            this.PPK6.Size = new System.Drawing.Size(95, 30);
            this.PPK6.TabIndex = 62;
            this.PPK6.UseVisualStyleBackColor = true;
            // 
            // Roxanne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PPK6);
            this.Controls.Add(this.PPK5);
            this.Controls.Add(this.PPK4);
            this.Controls.Add(this.PPK3);
            this.Controls.Add(this.PPK2);
            this.Controls.Add(this.PPK1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ATK);
            this.Controls.Add(this.DEF);
            this.Controls.Add(this.SPA);
            this.Controls.Add(this.SPD);
            this.Controls.Add(this.SPE);
            this.Controls.Add(this.HP);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.GymPK3);
            this.Controls.Add(this.GymPK2);
            this.Controls.Add(this.GymPK1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Roxanne";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Roxanne_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox pictureBox1;
        private Button GymPK1;
        private Button GymPK2;
        private Button GymPK3;
        private TextBox textBox1;
        private TextBox HP;
        private TextBox SPE;
        private TextBox SPD;
        private TextBox SPA;
        private TextBox DEF;
        private TextBox ATK;
        private ImageList imageList1;
        private PictureBox pictureBox2;
        private Button PPK1;
        private Button PPK2;
        private Button PPK3;
        private Button PPK4;
        private Button PPK5;
        private Button PPK6;
    }
}