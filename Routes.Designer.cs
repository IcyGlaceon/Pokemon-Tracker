namespace PokeTracker
{
    partial class Routes
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.R101 = new System.Windows.Forms.Label();
            this.R102 = new System.Windows.Forms.Label();
            this.Route101 = new System.Windows.Forms.ComboBox();
            this.ActivePK101 = new System.Windows.Forms.Button();
            this.KilledPK101 = new System.Windows.Forms.Button();
            this.FailedPK101 = new System.Windows.Forms.Button();
            this.FailedPK102 = new System.Windows.Forms.Button();
            this.KilledPK102 = new System.Windows.Forms.Button();
            this.ActivePK102 = new System.Windows.Forms.Button();
            this.Route102 = new System.Windows.Forms.ComboBox();
            this.FailedPK104 = new System.Windows.Forms.Button();
            this.KilledPK104 = new System.Windows.Forms.Button();
            this.ActivePK104 = new System.Windows.Forms.Button();
            this.Route104 = new System.Windows.Forms.ComboBox();
            this.FailedPK103 = new System.Windows.Forms.Button();
            this.KilledPK103 = new System.Windows.Forms.Button();
            this.ActivePK103 = new System.Windows.Forms.Button();
            this.Route103 = new System.Windows.Forms.ComboBox();
            this.R104 = new System.Windows.Forms.Label();
            this.R103 = new System.Windows.Forms.Label();
            this.FailedPKPetal = new System.Windows.Forms.Button();
            this.KilledPKPetal = new System.Windows.Forms.Button();
            this.ActivePKPetal = new System.Windows.Forms.Button();
            this.Petalburg = new System.Windows.Forms.ComboBox();
            this.PetalburgCity = new System.Windows.Forms.Label();
            this.Gym1 = new System.Windows.Forms.Label();
            this.FailedPKStart = new System.Windows.Forms.Button();
            this.KilledPKStart = new System.Windows.Forms.Button();
            this.ActivePKStart = new System.Windows.Forms.Button();
            this.Starter = new System.Windows.Forms.ComboBox();
            this.RStarter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // R101
            // 
            this.R101.AutoSize = true;
            this.R101.Location = new System.Drawing.Point(12, 53);
            this.R101.Name = "R101";
            this.R101.Size = new System.Drawing.Size(59, 15);
            this.R101.TabIndex = 2;
            this.R101.Text = "Route 101";
            this.R101.Click += new System.EventHandler(this.R101_Click);
            // 
            // R102
            // 
            this.R102.AutoSize = true;
            this.R102.Location = new System.Drawing.Point(12, 141);
            this.R102.Name = "R102";
            this.R102.Size = new System.Drawing.Size(59, 15);
            this.R102.TabIndex = 6;
            this.R102.Text = "Route 102";
            this.R102.Click += new System.EventHandler(this.R102_Click);
            // 
            // Route101
            // 
            this.Route101.Enabled = false;
            this.Route101.FormattingEnabled = true;
            this.Route101.Location = new System.Drawing.Point(12, 71);
            this.Route101.Name = "Route101";
            this.Route101.Size = new System.Drawing.Size(121, 23);
            this.Route101.TabIndex = 7;
            this.Route101.Tag = "";
            this.Route101.Visible = false;
            // 
            // ActivePK101
            // 
            this.ActivePK101.BackColor = System.Drawing.Color.Green;
            this.ActivePK101.Enabled = false;
            this.ActivePK101.Location = new System.Drawing.Point(139, 71);
            this.ActivePK101.Name = "ActivePK101";
            this.ActivePK101.Size = new System.Drawing.Size(75, 23);
            this.ActivePK101.TabIndex = 8;
            this.ActivePK101.Tag = "Route101";
            this.ActivePK101.Text = "Active";
            this.ActivePK101.UseVisualStyleBackColor = false;
            this.ActivePK101.Visible = false;
            this.ActivePK101.Click += new System.EventHandler(this.ActivePK_Click);
            // 
            // KilledPK101
            // 
            this.KilledPK101.BackColor = System.Drawing.Color.Red;
            this.KilledPK101.Enabled = false;
            this.KilledPK101.Location = new System.Drawing.Point(220, 71);
            this.KilledPK101.Name = "KilledPK101";
            this.KilledPK101.Size = new System.Drawing.Size(75, 23);
            this.KilledPK101.TabIndex = 9;
            this.KilledPK101.Tag = "Route101";
            this.KilledPK101.Text = "Killed";
            this.KilledPK101.UseVisualStyleBackColor = false;
            this.KilledPK101.Visible = false;
            this.KilledPK101.Click += new System.EventHandler(this.KilledPK_Click);
            // 
            // FailedPK101
            // 
            this.FailedPK101.BackColor = System.Drawing.Color.White;
            this.FailedPK101.Enabled = false;
            this.FailedPK101.Location = new System.Drawing.Point(301, 71);
            this.FailedPK101.Name = "FailedPK101";
            this.FailedPK101.Size = new System.Drawing.Size(75, 23);
            this.FailedPK101.TabIndex = 10;
            this.FailedPK101.Tag = "Route101";
            this.FailedPK101.Text = "Failed";
            this.FailedPK101.UseVisualStyleBackColor = false;
            this.FailedPK101.Visible = false;
            this.FailedPK101.Click += new System.EventHandler(this.KilledPK_Click);
            // 
            // FailedPK102
            // 
            this.FailedPK102.BackColor = System.Drawing.Color.White;
            this.FailedPK102.Enabled = false;
            this.FailedPK102.Location = new System.Drawing.Point(301, 159);
            this.FailedPK102.Name = "FailedPK102";
            this.FailedPK102.Size = new System.Drawing.Size(75, 23);
            this.FailedPK102.TabIndex = 14;
            this.FailedPK102.Tag = "Route102";
            this.FailedPK102.Text = "Failed";
            this.FailedPK102.UseVisualStyleBackColor = false;
            this.FailedPK102.Visible = false;
            this.FailedPK102.Click += new System.EventHandler(this.KilledPK_Click);
            // 
            // KilledPK102
            // 
            this.KilledPK102.BackColor = System.Drawing.Color.Red;
            this.KilledPK102.Enabled = false;
            this.KilledPK102.Location = new System.Drawing.Point(220, 159);
            this.KilledPK102.Name = "KilledPK102";
            this.KilledPK102.Size = new System.Drawing.Size(75, 23);
            this.KilledPK102.TabIndex = 13;
            this.KilledPK102.Tag = "Route102";
            this.KilledPK102.Text = "Killed";
            this.KilledPK102.UseVisualStyleBackColor = false;
            this.KilledPK102.Visible = false;
            this.KilledPK102.Click += new System.EventHandler(this.KilledPK_Click);
            // 
            // ActivePK102
            // 
            this.ActivePK102.BackColor = System.Drawing.Color.Green;
            this.ActivePK102.Enabled = false;
            this.ActivePK102.Location = new System.Drawing.Point(139, 159);
            this.ActivePK102.Name = "ActivePK102";
            this.ActivePK102.Size = new System.Drawing.Size(75, 23);
            this.ActivePK102.TabIndex = 12;
            this.ActivePK102.Tag = "Route102";
            this.ActivePK102.Text = "Active";
            this.ActivePK102.UseVisualStyleBackColor = false;
            this.ActivePK102.Visible = false;
            this.ActivePK102.Click += new System.EventHandler(this.ActivePK_Click);
            // 
            // Route102
            // 
            this.Route102.Enabled = false;
            this.Route102.FormattingEnabled = true;
            this.Route102.Location = new System.Drawing.Point(12, 159);
            this.Route102.Name = "Route102";
            this.Route102.Size = new System.Drawing.Size(121, 23);
            this.Route102.TabIndex = 11;
            this.Route102.Tag = "";
            this.Route102.Visible = false;
            // 
            // FailedPK104
            // 
            this.FailedPK104.BackColor = System.Drawing.Color.White;
            this.FailedPK104.Enabled = false;
            this.FailedPK104.Location = new System.Drawing.Point(301, 247);
            this.FailedPK104.Name = "FailedPK104";
            this.FailedPK104.Size = new System.Drawing.Size(75, 23);
            this.FailedPK104.TabIndex = 24;
            this.FailedPK104.Tag = "Route104";
            this.FailedPK104.Text = "Failed";
            this.FailedPK104.UseVisualStyleBackColor = false;
            this.FailedPK104.Visible = false;
            // 
            // KilledPK104
            // 
            this.KilledPK104.BackColor = System.Drawing.Color.Red;
            this.KilledPK104.Enabled = false;
            this.KilledPK104.Location = new System.Drawing.Point(220, 247);
            this.KilledPK104.Name = "KilledPK104";
            this.KilledPK104.Size = new System.Drawing.Size(75, 23);
            this.KilledPK104.TabIndex = 23;
            this.KilledPK104.Tag = "Route104";
            this.KilledPK104.Text = "Killed";
            this.KilledPK104.UseVisualStyleBackColor = false;
            this.KilledPK104.Visible = false;
            // 
            // ActivePK104
            // 
            this.ActivePK104.BackColor = System.Drawing.Color.Green;
            this.ActivePK104.Enabled = false;
            this.ActivePK104.Location = new System.Drawing.Point(139, 247);
            this.ActivePK104.Name = "ActivePK104";
            this.ActivePK104.Size = new System.Drawing.Size(75, 23);
            this.ActivePK104.TabIndex = 22;
            this.ActivePK104.Tag = "Route104";
            this.ActivePK104.Text = "Active";
            this.ActivePK104.UseVisualStyleBackColor = false;
            this.ActivePK104.Visible = false;
            this.ActivePK104.Click += new System.EventHandler(this.ActivePK_Click);
            // 
            // Route104
            // 
            this.Route104.Enabled = false;
            this.Route104.FormattingEnabled = true;
            this.Route104.Location = new System.Drawing.Point(12, 247);
            this.Route104.Name = "Route104";
            this.Route104.Size = new System.Drawing.Size(121, 23);
            this.Route104.TabIndex = 21;
            this.Route104.Tag = "";
            this.Route104.Visible = false;
            // 
            // FailedPK103
            // 
            this.FailedPK103.BackColor = System.Drawing.Color.White;
            this.FailedPK103.Enabled = false;
            this.FailedPK103.Location = new System.Drawing.Point(301, 115);
            this.FailedPK103.Name = "FailedPK103";
            this.FailedPK103.Size = new System.Drawing.Size(75, 23);
            this.FailedPK103.TabIndex = 20;
            this.FailedPK103.Tag = "Route103";
            this.FailedPK103.Text = "Failed";
            this.FailedPK103.UseVisualStyleBackColor = false;
            this.FailedPK103.Visible = false;
            // 
            // KilledPK103
            // 
            this.KilledPK103.BackColor = System.Drawing.Color.Red;
            this.KilledPK103.Enabled = false;
            this.KilledPK103.Location = new System.Drawing.Point(220, 115);
            this.KilledPK103.Name = "KilledPK103";
            this.KilledPK103.Size = new System.Drawing.Size(75, 23);
            this.KilledPK103.TabIndex = 19;
            this.KilledPK103.Tag = "Route103";
            this.KilledPK103.Text = "Killed";
            this.KilledPK103.UseVisualStyleBackColor = false;
            this.KilledPK103.Visible = false;
            // 
            // ActivePK103
            // 
            this.ActivePK103.BackColor = System.Drawing.Color.Green;
            this.ActivePK103.Enabled = false;
            this.ActivePK103.Location = new System.Drawing.Point(139, 115);
            this.ActivePK103.Name = "ActivePK103";
            this.ActivePK103.Size = new System.Drawing.Size(75, 23);
            this.ActivePK103.TabIndex = 18;
            this.ActivePK103.Tag = "Route103";
            this.ActivePK103.Text = "Active";
            this.ActivePK103.UseVisualStyleBackColor = false;
            this.ActivePK103.Visible = false;
            this.ActivePK103.Click += new System.EventHandler(this.ActivePK_Click);
            // 
            // Route103
            // 
            this.Route103.Enabled = false;
            this.Route103.FormattingEnabled = true;
            this.Route103.Location = new System.Drawing.Point(12, 115);
            this.Route103.Name = "Route103";
            this.Route103.Size = new System.Drawing.Size(121, 23);
            this.Route103.TabIndex = 17;
            this.Route103.Tag = "";
            this.Route103.Visible = false;
            // 
            // R104
            // 
            this.R104.AutoSize = true;
            this.R104.Location = new System.Drawing.Point(12, 229);
            this.R104.Name = "R104";
            this.R104.Size = new System.Drawing.Size(59, 15);
            this.R104.TabIndex = 16;
            this.R104.Text = "Route 104";
            this.R104.Click += new System.EventHandler(this.R104_Click);
            // 
            // R103
            // 
            this.R103.AutoSize = true;
            this.R103.Location = new System.Drawing.Point(12, 97);
            this.R103.Name = "R103";
            this.R103.Size = new System.Drawing.Size(59, 15);
            this.R103.TabIndex = 15;
            this.R103.Text = "Route 103";
            this.R103.Click += new System.EventHandler(this.R103_Click);
            // 
            // FailedPKPetal
            // 
            this.FailedPKPetal.BackColor = System.Drawing.Color.White;
            this.FailedPKPetal.Enabled = false;
            this.FailedPKPetal.Location = new System.Drawing.Point(301, 203);
            this.FailedPKPetal.Name = "FailedPKPetal";
            this.FailedPKPetal.Size = new System.Drawing.Size(75, 23);
            this.FailedPKPetal.TabIndex = 29;
            this.FailedPKPetal.Tag = "Petalburg";
            this.FailedPKPetal.Text = "Failed";
            this.FailedPKPetal.UseVisualStyleBackColor = false;
            this.FailedPKPetal.Visible = false;
            this.FailedPKPetal.Click += new System.EventHandler(this.KilledPK_Click);
            // 
            // KilledPKPetal
            // 
            this.KilledPKPetal.BackColor = System.Drawing.Color.Red;
            this.KilledPKPetal.Enabled = false;
            this.KilledPKPetal.Location = new System.Drawing.Point(220, 203);
            this.KilledPKPetal.Name = "KilledPKPetal";
            this.KilledPKPetal.Size = new System.Drawing.Size(75, 23);
            this.KilledPKPetal.TabIndex = 28;
            this.KilledPKPetal.Tag = "Petalburg";
            this.KilledPKPetal.Text = "Killed";
            this.KilledPKPetal.UseVisualStyleBackColor = false;
            this.KilledPKPetal.Visible = false;
            this.KilledPKPetal.Click += new System.EventHandler(this.KilledPK_Click);
            // 
            // ActivePKPetal
            // 
            this.ActivePKPetal.BackColor = System.Drawing.Color.Green;
            this.ActivePKPetal.Enabled = false;
            this.ActivePKPetal.Location = new System.Drawing.Point(139, 203);
            this.ActivePKPetal.Name = "ActivePKPetal";
            this.ActivePKPetal.Size = new System.Drawing.Size(75, 23);
            this.ActivePKPetal.TabIndex = 27;
            this.ActivePKPetal.Tag = "Petalburg";
            this.ActivePKPetal.Text = "Active";
            this.ActivePKPetal.UseVisualStyleBackColor = false;
            this.ActivePKPetal.Visible = false;
            this.ActivePKPetal.Click += new System.EventHandler(this.ActivePK_Click);
            // 
            // Petalburg
            // 
            this.Petalburg.Enabled = false;
            this.Petalburg.FormattingEnabled = true;
            this.Petalburg.Location = new System.Drawing.Point(12, 203);
            this.Petalburg.Name = "Petalburg";
            this.Petalburg.Size = new System.Drawing.Size(121, 23);
            this.Petalburg.TabIndex = 26;
            this.Petalburg.Tag = "";
            this.Petalburg.Visible = false;
            // 
            // PetalburgCity
            // 
            this.PetalburgCity.AutoSize = true;
            this.PetalburgCity.Location = new System.Drawing.Point(12, 185);
            this.PetalburgCity.Name = "PetalburgCity";
            this.PetalburgCity.Size = new System.Drawing.Size(82, 15);
            this.PetalburgCity.TabIndex = 25;
            this.PetalburgCity.Text = "Petalburg City";
            this.PetalburgCity.Click += new System.EventHandler(this.PetalburgCity_Click);
            // 
            // Gym1
            // 
            this.Gym1.AutoSize = true;
            this.Gym1.Location = new System.Drawing.Point(12, 273);
            this.Gym1.Name = "Gym1";
            this.Gym1.Size = new System.Drawing.Size(53, 15);
            this.Gym1.TabIndex = 30;
            this.Gym1.Text = "Roxanne";
            this.Gym1.Click += new System.EventHandler(this.Gym1_Click);
            // 
            // FailedPKStart
            // 
            this.FailedPKStart.BackColor = System.Drawing.Color.White;
            this.FailedPKStart.Enabled = false;
            this.FailedPKStart.Location = new System.Drawing.Point(301, 27);
            this.FailedPKStart.Name = "FailedPKStart";
            this.FailedPKStart.Size = new System.Drawing.Size(75, 23);
            this.FailedPKStart.TabIndex = 35;
            this.FailedPKStart.Tag = "Starter";
            this.FailedPKStart.Text = "Failed";
            this.FailedPKStart.UseVisualStyleBackColor = false;
            this.FailedPKStart.Visible = false;
            this.FailedPKStart.Click += new System.EventHandler(this.KilledPK_Click);
            // 
            // KilledPKStart
            // 
            this.KilledPKStart.BackColor = System.Drawing.Color.Red;
            this.KilledPKStart.Enabled = false;
            this.KilledPKStart.Location = new System.Drawing.Point(220, 27);
            this.KilledPKStart.Name = "KilledPKStart";
            this.KilledPKStart.Size = new System.Drawing.Size(75, 23);
            this.KilledPKStart.TabIndex = 34;
            this.KilledPKStart.Tag = "Starter";
            this.KilledPKStart.Text = "Killed";
            this.KilledPKStart.UseVisualStyleBackColor = false;
            this.KilledPKStart.Visible = false;
            this.KilledPKStart.Click += new System.EventHandler(this.KilledPK_Click);
            // 
            // ActivePKStart
            // 
            this.ActivePKStart.BackColor = System.Drawing.Color.Green;
            this.ActivePKStart.Enabled = false;
            this.ActivePKStart.Location = new System.Drawing.Point(139, 27);
            this.ActivePKStart.Name = "ActivePKStart";
            this.ActivePKStart.Size = new System.Drawing.Size(75, 23);
            this.ActivePKStart.TabIndex = 33;
            this.ActivePKStart.Tag = "Starter";
            this.ActivePKStart.Text = "Active";
            this.ActivePKStart.UseVisualStyleBackColor = false;
            this.ActivePKStart.Visible = false;
            this.ActivePKStart.Click += new System.EventHandler(this.ActivePK_Click);
            // 
            // Starter
            // 
            this.Starter.Enabled = false;
            this.Starter.FormattingEnabled = true;
            this.Starter.Location = new System.Drawing.Point(12, 27);
            this.Starter.Name = "Starter";
            this.Starter.Size = new System.Drawing.Size(121, 23);
            this.Starter.TabIndex = 32;
            this.Starter.Tag = "";
            this.Starter.Visible = false;
            // 
            // RStarter
            // 
            this.RStarter.AutoSize = true;
            this.RStarter.Location = new System.Drawing.Point(12, 9);
            this.RStarter.Name = "RStarter";
            this.RStarter.Size = new System.Drawing.Size(41, 15);
            this.RStarter.TabIndex = 31;
            this.RStarter.Text = "Starter";
            this.RStarter.Click += new System.EventHandler(this.Starter_Click);
            // 
            // Routes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FailedPKStart);
            this.Controls.Add(this.KilledPKStart);
            this.Controls.Add(this.ActivePKStart);
            this.Controls.Add(this.Starter);
            this.Controls.Add(this.RStarter);
            this.Controls.Add(this.Gym1);
            this.Controls.Add(this.FailedPKPetal);
            this.Controls.Add(this.KilledPKPetal);
            this.Controls.Add(this.ActivePKPetal);
            this.Controls.Add(this.Petalburg);
            this.Controls.Add(this.PetalburgCity);
            this.Controls.Add(this.FailedPK104);
            this.Controls.Add(this.KilledPK104);
            this.Controls.Add(this.ActivePK104);
            this.Controls.Add(this.Route104);
            this.Controls.Add(this.FailedPK103);
            this.Controls.Add(this.KilledPK103);
            this.Controls.Add(this.ActivePK103);
            this.Controls.Add(this.Route103);
            this.Controls.Add(this.R104);
            this.Controls.Add(this.R103);
            this.Controls.Add(this.FailedPK102);
            this.Controls.Add(this.KilledPK102);
            this.Controls.Add(this.ActivePK102);
            this.Controls.Add(this.Route102);
            this.Controls.Add(this.FailedPK101);
            this.Controls.Add(this.KilledPK101);
            this.Controls.Add(this.ActivePK101);
            this.Controls.Add(this.Route101);
            this.Controls.Add(this.R102);
            this.Controls.Add(this.R101);
            this.Name = "Routes";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label R101;
        private Label R102;
        private ComboBox Route101;
        private Button ActivePK101;
        private Button KilledPK101;
        private Button FailedPK101;
        private Button FailedPK102;
        private Button KilledPK102;
        private Button ActivePK102;
        private ComboBox Route102;
        private Button FailedPK104;
        private Button KilledPK104;
        private Button ActivePK104;
        private ComboBox Route104;
        private Button FailedPK103;
        private Button KilledPK103;
        private Button ActivePK103;
        private ComboBox Route103;
        private Label R104;
        private Label R103;
        private Button FailedPKPetal;
        private Button KilledPKPetal;
        private Button ActivePKPetal;
        private ComboBox Petalburg;
        private Label PetalburgCity;
        private Label Gym1;
        private Button FailedPKStart;
        private Button KilledPKStart;
        private Button ActivePKStart;
        private ComboBox Starter;
        private Label RStarter;
    }
}