namespace pictureGame
{
    partial class Options
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
            this.backButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.fontSizeCmboBox = new System.Windows.Forms.ComboBox();
            this.musicCmboBox = new System.Windows.Forms.ComboBox();
            this.soundEffectsCmboBox = new System.Windows.Forms.ComboBox();
            this.fontColourCmboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.backButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backButton.Location = new System.Drawing.Point(706, 556);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(158, 48);
            this.backButton.TabIndex = 11;
            this.backButton.Text = "Save Settings";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.fontSizeCmboBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.musicCmboBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.soundEffectsCmboBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.fontColourCmboBox, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(852, 538);
            this.tableLayoutPanel1.TabIndex = 12;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // fontSizeCmboBox
            // 
            this.fontSizeCmboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fontSizeCmboBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.fontSizeCmboBox.FormattingEnabled = true;
            this.fontSizeCmboBox.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.fontSizeCmboBox.Location = new System.Drawing.Point(479, 53);
            this.fontSizeCmboBox.Name = "fontSizeCmboBox";
            this.fontSizeCmboBox.Size = new System.Drawing.Size(320, 28);
            this.fontSizeCmboBox.TabIndex = 0;
            this.fontSizeCmboBox.Text = "Font Size";
            this.fontSizeCmboBox.SelectedIndexChanged += new System.EventHandler(this.fontSizeCmboBox_SelectedIndexChanged);
            // 
            // musicCmboBox
            // 
            this.musicCmboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.musicCmboBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.musicCmboBox.FormattingEnabled = true;
            this.musicCmboBox.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.musicCmboBox.Location = new System.Drawing.Point(478, 187);
            this.musicCmboBox.Name = "musicCmboBox";
            this.musicCmboBox.Size = new System.Drawing.Size(321, 28);
            this.musicCmboBox.TabIndex = 4;
            this.musicCmboBox.Text = "Music";
            this.musicCmboBox.SelectedIndexChanged += new System.EventHandler(this.musicCmboBox_SelectedIndexChanged);
            // 
            // soundEffectsCmboBox
            // 
            this.soundEffectsCmboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.soundEffectsCmboBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.soundEffectsCmboBox.FormattingEnabled = true;
            this.soundEffectsCmboBox.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.soundEffectsCmboBox.Location = new System.Drawing.Point(474, 321);
            this.soundEffectsCmboBox.Name = "soundEffectsCmboBox";
            this.soundEffectsCmboBox.Size = new System.Drawing.Size(329, 28);
            this.soundEffectsCmboBox.TabIndex = 5;
            this.soundEffectsCmboBox.Text = "Sound Effects";
            // 
            // fontColourCmboBox
            // 
            this.fontColourCmboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fontColourCmboBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.fontColourCmboBox.FormattingEnabled = true;
            this.fontColourCmboBox.Items.AddRange(new object[] {
            "Blue",
            "Red",
            "White"});
            this.fontColourCmboBox.Location = new System.Drawing.Point(477, 456);
            this.fontColourCmboBox.Name = "fontColourCmboBox";
            this.fontColourCmboBox.Size = new System.Drawing.Size(323, 28);
            this.fontColourCmboBox.TabIndex = 6;
            this.fontColourCmboBox.Text = "Colour";
            this.fontColourCmboBox.SelectedIndexChanged += new System.EventHandler(this.fontColourCmboBox_SelectedIndexChanged);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(876, 606);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.backButton);
            this.MaximumSize = new System.Drawing.Size(898, 662);
            this.Name = "Options";
            this.Text = "Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Options_FormClosing);
            this.Load += new System.EventHandler(this.Options_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox fontSizeCmboBox;
        private System.Windows.Forms.ComboBox musicCmboBox;
        private System.Windows.Forms.ComboBox soundEffectsCmboBox;
        private System.Windows.Forms.ComboBox fontColourCmboBox;
    }
}