namespace pictureGame
{
    partial class NewGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewGame));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.extremeGameBttn = new System.Windows.Forms.Button();
            this.hardGameBttn = new System.Windows.Forms.Button();
            this.mediumGameBttn = new System.Windows.Forms.Button();
            this.easyGameBttn = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.extremeGameBttn, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.hardGameBttn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.mediumGameBttn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.easyGameBttn, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(215, 104);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(277, 231);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // extremeGameBttn
            // 
            this.extremeGameBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extremeGameBttn.Location = new System.Drawing.Point(3, 174);
            this.extremeGameBttn.Name = "extremeGameBttn";
            this.extremeGameBttn.Size = new System.Drawing.Size(274, 51);
            this.extremeGameBttn.TabIndex = 4;
            this.extremeGameBttn.Text = "Extreme";
            this.extremeGameBttn.UseVisualStyleBackColor = true;
            this.extremeGameBttn.Click += new System.EventHandler(this.extremeGameBttn_Click);
            // 
            // hardGameBttn
            // 
            this.hardGameBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardGameBttn.Location = new System.Drawing.Point(3, 117);
            this.hardGameBttn.Name = "hardGameBttn";
            this.hardGameBttn.Size = new System.Drawing.Size(274, 51);
            this.hardGameBttn.TabIndex = 3;
            this.hardGameBttn.Text = "Hard";
            this.hardGameBttn.UseVisualStyleBackColor = true;
            this.hardGameBttn.Click += new System.EventHandler(this.hardGameBttn_Click);
            // 
            // mediumGameBttn
            // 
            this.mediumGameBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediumGameBttn.Location = new System.Drawing.Point(3, 60);
            this.mediumGameBttn.Name = "mediumGameBttn";
            this.mediumGameBttn.Size = new System.Drawing.Size(274, 51);
            this.mediumGameBttn.TabIndex = 2;
            this.mediumGameBttn.Text = "Medium";
            this.mediumGameBttn.UseVisualStyleBackColor = true;
            this.mediumGameBttn.Click += new System.EventHandler(this.mediumGameBttn_Click);
            // 
            // easyGameBttn
            // 
            this.easyGameBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easyGameBttn.Location = new System.Drawing.Point(3, 3);
            this.easyGameBttn.Name = "easyGameBttn";
            this.easyGameBttn.Size = new System.Drawing.Size(274, 51);
            this.easyGameBttn.TabIndex = 1;
            this.easyGameBttn.Text = "Easy";
            this.easyGameBttn.UseVisualStyleBackColor = true;
            this.easyGameBttn.Click += new System.EventHandler(this.easyGameBttn_Click);
            // 
            // backButton
            // 
            this.backButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.backButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.Location = new System.Drawing.Point(692, 8);
            this.backButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(32, 31);
            this.backButton.TabIndex = 13;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click_1);
            // 
            // NewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 487);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "NewGame";
            this.Text = "NewGame";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewGame_FormClosing);
            this.Load += new System.EventHandler(this.NewGame_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button extremeGameBttn;
        private System.Windows.Forms.Button hardGameBttn;
        private System.Windows.Forms.Button mediumGameBttn;
        private System.Windows.Forms.Button easyGameBttn;
        private System.Windows.Forms.Button backButton;
    }
}