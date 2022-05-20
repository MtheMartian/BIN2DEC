namespace MyOwn
{
    partial class Bin2Dec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bin2Dec));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitProgram = new System.Windows.Forms.Button();
            this.MinimizeProgram = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.usrInput = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Textusr = new System.Windows.Forms.TextBox();
            this.btnGetInfo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.ExitProgram);
            this.panel1.Controls.Add(this.MinimizeProgram);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(68, 796);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ExitProgram
            // 
            this.ExitProgram.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitProgram.BackgroundImage")));
            this.ExitProgram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExitProgram.FlatAppearance.BorderSize = 0;
            this.ExitProgram.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ExitProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitProgram.Location = new System.Drawing.Point(3, 12);
            this.ExitProgram.Name = "ExitProgram";
            this.ExitProgram.Size = new System.Drawing.Size(65, 37);
            this.ExitProgram.TabIndex = 4;
            this.ExitProgram.UseVisualStyleBackColor = true;
            this.ExitProgram.Click += new System.EventHandler(this.button5_Click);
            // 
            // MinimizeProgram
            // 
            this.MinimizeProgram.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MinimizeProgram.BackgroundImage")));
            this.MinimizeProgram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MinimizeProgram.FlatAppearance.BorderSize = 0;
            this.MinimizeProgram.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MinimizeProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeProgram.Location = new System.Drawing.Point(3, 111);
            this.MinimizeProgram.Name = "MinimizeProgram";
            this.MinimizeProgram.Size = new System.Drawing.Size(65, 37);
            this.MinimizeProgram.TabIndex = 3;
            this.MinimizeProgram.UseVisualStyleBackColor = true;
            this.MinimizeProgram.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.btnGetInfo);
            this.panel2.Controls.Add(this.usrInput);
            this.panel2.Location = new System.Drawing.Point(-2, 740);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1416, 56);
            this.panel2.TabIndex = 1;
            // 
            // usrInput
            // 
            this.usrInput.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("usrInput.BackgroundImage")));
            this.usrInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.usrInput.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveBorder;
            this.usrInput.FlatAppearance.BorderSize = 0;
            this.usrInput.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.usrInput.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.usrInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usrInput.Location = new System.Drawing.Point(675, 9);
            this.usrInput.Name = "usrInput";
            this.usrInput.Size = new System.Drawing.Size(65, 37);
            this.usrInput.TabIndex = 0;
            this.usrInput.UseVisualStyleBackColor = true;
            this.usrInput.Click += new System.EventHandler(this.usrInput_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.Textusr);
            this.panel3.Location = new System.Drawing.Point(66, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1348, 740);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Bin2Dec_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Bin2Dec_MouseMove);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Bin2Dec_MouseUp);
            // 
            // Textusr
            // 
            this.Textusr.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textusr.Location = new System.Drawing.Point(540, 691);
            this.Textusr.Name = "Textusr";
            this.Textusr.Size = new System.Drawing.Size(200, 27);
            this.Textusr.TabIndex = 0;
            this.Textusr.TextChanged += new System.EventHandler(this.Textusr_TextChanged_1);
            // 
            // btnGetInfo
            // 
            this.btnGetInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGetInfo.BackgroundImage")));
            this.btnGetInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGetInfo.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnGetInfo.FlatAppearance.BorderSize = 0;
            this.btnGetInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnGetInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGetInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetInfo.Location = new System.Drawing.Point(798, 9);
            this.btnGetInfo.Name = "btnGetInfo";
            this.btnGetInfo.Size = new System.Drawing.Size(65, 37);
            this.btnGetInfo.TabIndex = 1;
            this.btnGetInfo.UseVisualStyleBackColor = true;
            this.btnGetInfo.Click += new System.EventHandler(this.btnGetInfo_Click);
            // 
            // Bin2Dec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1414, 796);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bin2Dec";
            this.Text = "BIN2DEC";
            this.Load += new System.EventHandler(this.Bin2Dec_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Bin2Dec_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Bin2Dec_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Bin2Dec_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button usrInput;
        private System.Windows.Forms.Button ExitProgram;
        private System.Windows.Forms.Button MinimizeProgram;
        private System.Windows.Forms.TextBox Textusr;
        private System.Windows.Forms.Button btnGetInfo;
    }
}

