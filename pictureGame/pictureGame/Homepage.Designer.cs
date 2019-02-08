namespace pictureGame
{
    partial class Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.helpBttn = new System.Windows.Forms.Button();
            this.optionsBttn = new System.Windows.Forms.Button();
            this.newGameBttn = new System.Windows.Forms.Button();
            this.highscoreBttn = new System.Windows.Forms.Button();
            this.soundBttn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.helpBttn, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.optionsBttn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.newGameBttn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.highscoreBttn, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(213, 211);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(416, 355);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // helpBttn
            // 
            this.helpBttn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.helpBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpBttn.Location = new System.Drawing.Point(4, 269);
            this.helpBttn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.helpBttn.Name = "helpBttn";
            this.helpBttn.Size = new System.Drawing.Size(411, 78);
            this.helpBttn.TabIndex = 4;
            this.helpBttn.Text = "Help";
            this.helpBttn.UseVisualStyleBackColor = false;
            this.helpBttn.Click += new System.EventHandler(this.helpBttn_Click);
            // 
            // optionsBttn
            // 
            this.optionsBttn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.optionsBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsBttn.Location = new System.Drawing.Point(4, 181);
            this.optionsBttn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.optionsBttn.Name = "optionsBttn";
            this.optionsBttn.Size = new System.Drawing.Size(411, 78);
            this.optionsBttn.TabIndex = 3;
            this.optionsBttn.Text = "Options";
            this.optionsBttn.UseVisualStyleBackColor = false;
            this.optionsBttn.Click += new System.EventHandler(this.optionsBttn_Click);
            // 
            // newGameBttn
            // 
            this.newGameBttn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.newGameBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGameBttn.Location = new System.Drawing.Point(4, 5);
            this.newGameBttn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newGameBttn.Name = "newGameBttn";
            this.newGameBttn.Size = new System.Drawing.Size(411, 78);
            this.newGameBttn.TabIndex = 1;
            this.newGameBttn.Text = "New Game";
            this.newGameBttn.UseVisualStyleBackColor = false;
            this.newGameBttn.Click += new System.EventHandler(this.newGameBttn_Click);
            // 
            // highscoreBttn
            // 
            this.highscoreBttn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.highscoreBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highscoreBttn.Location = new System.Drawing.Point(4, 93);
            this.highscoreBttn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.highscoreBttn.Name = "highscoreBttn";
            this.highscoreBttn.Size = new System.Drawing.Size(411, 78);
            this.highscoreBttn.TabIndex = 2;
            this.highscoreBttn.Text = "Highscore";
            this.highscoreBttn.UseVisualStyleBackColor = false;
            this.highscoreBttn.Click += new System.EventHandler(this.highscoreBttn_Click);
            // 
            // soundBttn
            // 
            this.soundBttn.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.soundBttn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.soundBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soundBttn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.soundBttn.Location = new System.Drawing.Point(815, 5);
            this.soundBttn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.soundBttn.Name = "soundBttn";
            this.soundBttn.Size = new System.Drawing.Size(48, 48);
            this.soundBttn.TabIndex = 1;
            this.soundBttn.Text = "On";
            this.soundBttn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.soundBttn.UseCompatibleTextRendering = true;
            this.soundBttn.UseVisualStyleBackColor = false;
            this.soundBttn.Click += new System.EventHandler(this.soundBttn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(851, 152);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(876, 606);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.soundBttn);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Homepage";
            this.Text = "Homepage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Homepage_FormClosing);
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button helpBttn;
        private System.Windows.Forms.Button optionsBttn;
        private System.Windows.Forms.Button highscoreBttn;
        private System.Windows.Forms.Button newGameBttn;
        private System.Windows.Forms.Button soundBttn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

