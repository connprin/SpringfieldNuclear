namespace SpringfieldNuclear
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reactor1StateLabel = new System.Windows.Forms.Label();
            this.reactor2StateLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("NewsGoth BdXCn BT", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(237, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(358, 65);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Springfield Reactor";
            this.titleLabel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quorum Blk BT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Header 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Quorum Blk BT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(506, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Header 2";
            // 
            // reactor1StateLabel
            // 
            this.reactor1StateLabel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.reactor1StateLabel.Location = new System.Drawing.Point(147, 171);
            this.reactor1StateLabel.Name = "reactor1StateLabel";
            this.reactor1StateLabel.Size = new System.Drawing.Size(172, 139);
            this.reactor1StateLabel.TabIndex = 3;
            // 
            // reactor2StateLabel
            // 
            this.reactor2StateLabel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.reactor2StateLabel.Location = new System.Drawing.Point(478, 171);
            this.reactor2StateLabel.Name = "reactor2StateLabel";
            this.reactor2StateLabel.Size = new System.Drawing.Size(172, 139);
            this.reactor2StateLabel.TabIndex = 4;
            this.reactor2StateLabel.Click += new System.EventHandler(this.Reactor2StateLabel_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Wheat;
            this.startButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.startButton.FlatAppearance.BorderSize = 2;
            this.startButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.startButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(325, 171);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(147, 139);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.Azure;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(289, 360);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(222, 51);
            this.outputLabel.TabIndex = 6;
            this.outputLabel.Text = "Reactors Stable";
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.outputLabel.Click += new System.EventHandler(this.OutputLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.reactor2StateLabel);
            this.Controls.Add(this.reactor1StateLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Control Panel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label reactor1StateLabel;
        private System.Windows.Forms.Label reactor2StateLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label outputLabel;
    }
}

