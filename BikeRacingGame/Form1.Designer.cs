namespace BikeRacingGame
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MinimumBet = new System.Windows.Forms.Label();
            this.labelAlsBet = new System.Windows.Forms.Label();
            this.labelBobsBet = new System.Windows.Forms.Label();
            this.labelJoesBet = new System.Windows.Forms.Label();
            this.numericUpDownCar = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBets = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonAI = new System.Windows.Forms.RadioButton();
            this.radioButtonBob = new System.Windows.Forms.RadioButton();
            this.radioButtonJoe = new System.Windows.Forms.RadioButton();
            this.buttonRace = new System.Windows.Forms.Button();
            this.buttonBets = new System.Windows.Forms.Button();
            this.Racer4 = new System.Windows.Forms.PictureBox();
            this.Racer3 = new System.Windows.Forms.PictureBox();
            this.Racer2 = new System.Windows.Forms.PictureBox();
            this.Racer1 = new System.Windows.Forms.PictureBox();
            this.RaceTrack = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Racer4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Racer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Racer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Racer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RaceTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MinimumBet);
            this.groupBox1.Controls.Add(this.labelAlsBet);
            this.groupBox1.Controls.Add(this.labelBobsBet);
            this.groupBox1.Controls.Add(this.labelJoesBet);
            this.groupBox1.Controls.Add(this.numericUpDownCar);
            this.groupBox1.Controls.Add(this.numericUpDownBets);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radioButtonAI);
            this.groupBox1.Controls.Add(this.radioButtonBob);
            this.groupBox1.Controls.Add(this.radioButtonJoe);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(786, 128);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betting System";
            // 
            // MinimumBet
            // 
            this.MinimumBet.AutoSize = true;
            this.MinimumBet.Location = new System.Drawing.Point(243, 38);
            this.MinimumBet.Name = "MinimumBet";
            this.MinimumBet.Size = new System.Drawing.Size(78, 13);
            this.MinimumBet.TabIndex = 26;
            this.MinimumBet.Text = "Minimum Bet";
            // 
            // labelAlsBet
            // 
            this.labelAlsBet.AutoSize = true;
            this.labelAlsBet.BackColor = System.Drawing.Color.White;
            this.labelAlsBet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAlsBet.Location = new System.Drawing.Point(529, 106);
            this.labelAlsBet.Name = "labelAlsBet";
            this.labelAlsBet.Size = new System.Drawing.Size(123, 15);
            this.labelAlsBet.TabIndex = 25;
            this.labelAlsBet.Text = "AI hasn\'t placed bet";
            // 
            // labelBobsBet
            // 
            this.labelBobsBet.AutoSize = true;
            this.labelBobsBet.BackColor = System.Drawing.Color.White;
            this.labelBobsBet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelBobsBet.Location = new System.Drawing.Point(529, 66);
            this.labelBobsBet.Name = "labelBobsBet";
            this.labelBobsBet.Size = new System.Drawing.Size(133, 15);
            this.labelBobsBet.TabIndex = 24;
            this.labelBobsBet.Text = "Bob hasn\'t placed bet";
            // 
            // labelJoesBet
            // 
            this.labelJoesBet.AutoSize = true;
            this.labelJoesBet.BackColor = System.Drawing.Color.White;
            this.labelJoesBet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelJoesBet.Location = new System.Drawing.Point(529, 28);
            this.labelJoesBet.Name = "labelJoesBet";
            this.labelJoesBet.Size = new System.Drawing.Size(131, 15);
            this.labelJoesBet.TabIndex = 23;
            this.labelJoesBet.Text = "Joe hasn\'t placed bet";
            // 
            // numericUpDownCar
            // 
            this.numericUpDownCar.Location = new System.Drawing.Point(412, 74);
            this.numericUpDownCar.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownCar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCar.Name = "numericUpDownCar";
            this.numericUpDownCar.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownCar.TabIndex = 22;
            this.numericUpDownCar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownBets
            // 
            this.numericUpDownBets.Location = new System.Drawing.Point(412, 36);
            this.numericUpDownBets.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownBets.Name = "numericUpDownBets";
            this.numericUpDownBets.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownBets.TabIndex = 21;
            this.numericUpDownBets.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = " #";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(392, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "$";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // radioButtonAI
            // 
            this.radioButtonAI.AutoSize = true;
            this.radioButtonAI.Location = new System.Drawing.Point(34, 106);
            this.radioButtonAI.Name = "radioButtonAI";
            this.radioButtonAI.Size = new System.Drawing.Size(37, 17);
            this.radioButtonAI.TabIndex = 2;
            this.radioButtonAI.TabStop = true;
            this.radioButtonAI.Text = "AI";
            this.radioButtonAI.UseVisualStyleBackColor = true;
            this.radioButtonAI.CheckedChanged += new System.EventHandler(this.radioButtonAI_CheckedChanged);
            // 
            // radioButtonBob
            // 
            this.radioButtonBob.AutoSize = true;
            this.radioButtonBob.Location = new System.Drawing.Point(34, 64);
            this.radioButtonBob.Name = "radioButtonBob";
            this.radioButtonBob.Size = new System.Drawing.Size(47, 17);
            this.radioButtonBob.TabIndex = 1;
            this.radioButtonBob.TabStop = true;
            this.radioButtonBob.Text = "Bob";
            this.radioButtonBob.UseVisualStyleBackColor = true;
            this.radioButtonBob.CheckedChanged += new System.EventHandler(this.radioButtonBob_CheckedChanged);
            // 
            // radioButtonJoe
            // 
            this.radioButtonJoe.AutoSize = true;
            this.radioButtonJoe.Location = new System.Drawing.Point(34, 28);
            this.radioButtonJoe.Name = "radioButtonJoe";
            this.radioButtonJoe.Size = new System.Drawing.Size(45, 17);
            this.radioButtonJoe.TabIndex = 0;
            this.radioButtonJoe.TabStop = true;
            this.radioButtonJoe.Text = "Joe";
            this.radioButtonJoe.UseVisualStyleBackColor = true;
            this.radioButtonJoe.CheckedChanged += new System.EventHandler(this.radioButtonJoe_CheckedChanged);
            // 
            // buttonRace
            // 
            this.buttonRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRace.Location = new System.Drawing.Point(604, 22);
            this.buttonRace.Name = "buttonRace";
            this.buttonRace.Size = new System.Drawing.Size(92, 32);
            this.buttonRace.TabIndex = 34;
            this.buttonRace.Text = "Race!";
            this.buttonRace.UseVisualStyleBackColor = true;
            this.buttonRace.Click += new System.EventHandler(this.buttonRace_Click);
            // 
            // buttonBets
            // 
            this.buttonBets.Location = new System.Drawing.Point(127, 12);
            this.buttonBets.Name = "buttonBets";
            this.buttonBets.Size = new System.Drawing.Size(112, 42);
            this.buttonBets.TabIndex = 33;
            this.buttonBets.Text = "Place Bet";
            this.buttonBets.UseVisualStyleBackColor = true;
            this.buttonBets.Click += new System.EventHandler(this.buttonBets_Click);
            // 
            // Racer4
            // 
            this.Racer4.BackColor = System.Drawing.Color.White;
            this.Racer4.Image = global::BikeRacingGame.Properties.Resources.bike44;
            this.Racer4.Location = new System.Drawing.Point(13, 484);
            this.Racer4.Name = "Racer4";
            this.Racer4.Size = new System.Drawing.Size(100, 50);
            this.Racer4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Racer4.TabIndex = 39;
            this.Racer4.TabStop = false;
            // 
            // Racer3
            // 
            this.Racer3.BackColor = System.Drawing.Color.White;
            this.Racer3.Image = global::BikeRacingGame.Properties.Resources.bike33;
            this.Racer3.Location = new System.Drawing.Point(13, 414);
            this.Racer3.Name = "Racer3";
            this.Racer3.Size = new System.Drawing.Size(100, 50);
            this.Racer3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Racer3.TabIndex = 38;
            this.Racer3.TabStop = false;
            // 
            // Racer2
            // 
            this.Racer2.BackColor = System.Drawing.Color.White;
            this.Racer2.Image = global::BikeRacingGame.Properties.Resources.bike22;
            this.Racer2.Location = new System.Drawing.Point(13, 338);
            this.Racer2.Name = "Racer2";
            this.Racer2.Size = new System.Drawing.Size(100, 50);
            this.Racer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Racer2.TabIndex = 37;
            this.Racer2.TabStop = false;
            // 
            // Racer1
            // 
            this.Racer1.BackColor = System.Drawing.Color.White;
            this.Racer1.Image = global::BikeRacingGame.Properties.Resources.bike11;
            this.Racer1.Location = new System.Drawing.Point(13, 261);
            this.Racer1.Name = "Racer1";
            this.Racer1.Size = new System.Drawing.Size(100, 50);
            this.Racer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Racer1.TabIndex = 36;
            this.Racer1.TabStop = false;
            // 
            // RaceTrack
            // 
            this.RaceTrack.Image = global::BikeRacingGame.Properties.Resources.track111;
            this.RaceTrack.Location = new System.Drawing.Point(-1, 197);
            this.RaceTrack.Name = "RaceTrack";
            this.RaceTrack.Size = new System.Drawing.Size(800, 400);
            this.RaceTrack.TabIndex = 27;
            this.RaceTrack.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 599);
            this.Controls.Add(this.Racer4);
            this.Controls.Add(this.Racer3);
            this.Controls.Add(this.Racer2);
            this.Controls.Add(this.Racer1);
            this.Controls.Add(this.RaceTrack);
            this.Controls.Add(this.buttonRace);
            this.Controls.Add(this.buttonBets);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Bike Race Developed By Sukhman";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Racer4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Racer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Racer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Racer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RaceTrack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label MinimumBet;
        private System.Windows.Forms.Label labelAlsBet;
        private System.Windows.Forms.Label labelBobsBet;
        private System.Windows.Forms.Label labelJoesBet;
        private System.Windows.Forms.NumericUpDown numericUpDownCar;
        private System.Windows.Forms.NumericUpDown numericUpDownBets;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonAI;
        private System.Windows.Forms.RadioButton radioButtonBob;
        private System.Windows.Forms.RadioButton radioButtonJoe;
        private System.Windows.Forms.Button buttonRace;
        private System.Windows.Forms.Button buttonBets;
        private System.Windows.Forms.PictureBox RaceTrack;
        private System.Windows.Forms.PictureBox Racer1;
        private System.Windows.Forms.PictureBox Racer2;
        private System.Windows.Forms.PictureBox Racer3;
        private System.Windows.Forms.PictureBox Racer4;
    }
}

