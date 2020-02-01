namespace Master_Mind
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.picBoard = new System.Windows.Forms.PictureBox();
            this.picPegs = new System.Windows.Forms.PictureBox();
            this.picAnswer = new System.Windows.Forms.PictureBox();
            this.txtRules = new System.Windows.Forms.RichTextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.btnPink = new System.Windows.Forms.Button();
            this.btnOrange = new System.Windows.Forms.Button();
            this.btnValidate = new System.Windows.Forms.Button();
            this.btnErase = new System.Windows.Forms.Button();
            this.picColor = new System.Windows.Forms.PictureBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.chkDuplicates = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPegs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picColor)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoard
            // 
            this.picBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.picBoard, "picBoard");
            this.picBoard.Name = "picBoard";
            this.picBoard.TabStop = false;
            this.picBoard.Click += new System.EventHandler(this.PicBoard_Click);
            this.picBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.PicBoard_Paint);
            // 
            // picPegs
            // 
            this.picPegs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.picPegs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.picPegs, "picPegs");
            this.picPegs.Name = "picPegs";
            this.picPegs.TabStop = false;
            this.picPegs.Paint += new System.Windows.Forms.PaintEventHandler(this.PicPegs_Paint);
            // 
            // picAnswer
            // 
            this.picAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.picAnswer, "picAnswer");
            this.picAnswer.Name = "picAnswer";
            this.picAnswer.TabStop = false;
            this.picAnswer.Paint += new System.Windows.Forms.PaintEventHandler(this.PicAnswer_Paint);
            // 
            // txtRules
            // 
            this.txtRules.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtRules, "txtRules");
            this.txtRules.Name = "txtRules";
            this.txtRules.ReadOnly = true;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LightBlue;
            resources.ApplyResources(this.btnStart, "btnStart");
            this.btnStart.Name = "btnStart";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnRed
            // 
            resources.ApplyResources(this.btnRed, "btnRed");
            this.btnRed.BackColor = System.Drawing.Color.Red;
            this.btnRed.Name = "btnRed";
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // btnBlue
            // 
            resources.ApplyResources(this.btnBlue, "btnBlue");
            this.btnBlue.BackColor = System.Drawing.Color.Blue;
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // btnGreen
            // 
            resources.ApplyResources(this.btnGreen, "btnGreen");
            this.btnGreen.BackColor = System.Drawing.Color.Green;
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.UseVisualStyleBackColor = false;
            this.btnGreen.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // btnYellow
            // 
            resources.ApplyResources(this.btnYellow, "btnYellow");
            this.btnYellow.BackColor = System.Drawing.Color.Yellow;
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.UseVisualStyleBackColor = false;
            this.btnYellow.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // btnPink
            // 
            resources.ApplyResources(this.btnPink, "btnPink");
            this.btnPink.BackColor = System.Drawing.Color.HotPink;
            this.btnPink.Name = "btnPink";
            this.btnPink.UseVisualStyleBackColor = false;
            this.btnPink.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // btnOrange
            // 
            resources.ApplyResources(this.btnOrange, "btnOrange");
            this.btnOrange.BackColor = System.Drawing.Color.Orange;
            this.btnOrange.Name = "btnOrange";
            this.btnOrange.UseVisualStyleBackColor = false;
            this.btnOrange.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // btnValidate
            // 
            this.btnValidate.BackColor = System.Drawing.Color.Lime;
            resources.ApplyResources(this.btnValidate, "btnValidate");
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.UseVisualStyleBackColor = false;
            this.btnValidate.Click += new System.EventHandler(this.BtnValidate_Click);
            // 
            // btnErase
            // 
            this.btnErase.BackColor = System.Drawing.Color.LightCoral;
            resources.ApplyResources(this.btnErase, "btnErase");
            this.btnErase.Name = "btnErase";
            this.btnErase.UseVisualStyleBackColor = false;
            this.btnErase.Click += new System.EventHandler(this.BtnErase_Click);
            // 
            // picColor
            // 
            this.picColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.picColor, "picColor");
            this.picColor.Name = "picColor";
            this.picColor.TabStop = false;
            this.picColor.Paint += new System.Windows.Forms.PaintEventHandler(this.PicColor_Paint);
            // 
            // lblColor
            // 
            resources.ApplyResources(this.lblColor, "lblColor");
            this.lblColor.Name = "lblColor";
            // 
            // chkDuplicates
            // 
            resources.ApplyResources(this.chkDuplicates, "chkDuplicates");
            this.chkDuplicates.Name = "chkDuplicates";
            this.chkDuplicates.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkDuplicates);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.picColor);
            this.Controls.Add(this.btnErase);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.btnOrange);
            this.Controls.Add(this.btnPink);
            this.Controls.Add(this.btnYellow);
            this.Controls.Add(this.btnGreen);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtRules);
            this.Controls.Add(this.picAnswer);
            this.Controls.Add(this.picPegs);
            this.Controls.Add(this.picBoard);
            this.KeyPreview = true;
            this.Name = "frmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmMain_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.picBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPegs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoard;
        private System.Windows.Forms.PictureBox picPegs;
        private System.Windows.Forms.PictureBox picAnswer;
        private System.Windows.Forms.RichTextBox txtRules;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button btnPink;
        private System.Windows.Forms.Button btnOrange;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.PictureBox picColor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.CheckBox chkDuplicates;
    }
}

