namespace TShockGUI
{
    partial class TShockGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TShockGUI));
            this.StartButton = new System.Windows.Forms.Button();
            this.portText = new System.Windows.Forms.TextBox();
            this.portLabel = new System.Windows.Forms.Label();
            this.worldpathTextBox = new System.Windows.Forms.TextBox();
            this.worldpathLabel = new System.Windows.Forms.Label();
            this.argsTextbox = new System.Windows.Forms.TextBox();
            this.worldLabel = new System.Windows.Forms.Label();
            this.worldTextBox = new System.Windows.Forms.TextBox();
            this.ignoreversionCheckBox = new System.Windows.Forms.CheckBox();
            this.createBatchButton = new System.Windows.Forms.Button();
            this.commandLineParamLabel = new System.Windows.Forms.Label();
            this.updateParamsButton = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(244, 215);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // portText
            // 
            this.portText.Location = new System.Drawing.Point(44, 12);
            this.portText.Name = "portText";
            this.portText.Size = new System.Drawing.Size(100, 20);
            this.portText.TabIndex = 1;
            this.portText.Text = "7777";
            this.portText.TextChanged += new System.EventHandler(this.portText_TextChanged);
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(12, 9);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(26, 13);
            this.portLabel.TabIndex = 2;
            this.portLabel.Text = "Port";
            // 
            // worldpathTextBox
            // 
            this.worldpathTextBox.Location = new System.Drawing.Point(237, 12);
            this.worldpathTextBox.Name = "worldpathTextBox";
            this.worldpathTextBox.Size = new System.Drawing.Size(100, 20);
            this.worldpathTextBox.TabIndex = 3;
            this.worldpathTextBox.Text = "Worlds/";
            this.worldpathTextBox.TextChanged += new System.EventHandler(this.worldpathTextBox_TextChanged);
            // 
            // worldpathLabel
            // 
            this.worldpathLabel.AutoSize = true;
            this.worldpathLabel.Location = new System.Drawing.Point(175, 12);
            this.worldpathLabel.Name = "worldpathLabel";
            this.worldpathLabel.Size = new System.Drawing.Size(56, 13);
            this.worldpathLabel.TabIndex = 4;
            this.worldpathLabel.Text = "Worldpath";
            // 
            // argsTextbox
            // 
            this.argsTextbox.Location = new System.Drawing.Point(12, 351);
            this.argsTextbox.Name = "argsTextbox";
            this.argsTextbox.Size = new System.Drawing.Size(369, 20);
            this.argsTextbox.TabIndex = 5;
            // 
            // worldLabel
            // 
            this.worldLabel.AutoSize = true;
            this.worldLabel.Location = new System.Drawing.Point(196, 42);
            this.worldLabel.Name = "worldLabel";
            this.worldLabel.Size = new System.Drawing.Size(35, 13);
            this.worldLabel.TabIndex = 7;
            this.worldLabel.Text = "World";
            // 
            // worldTextBox
            // 
            this.worldTextBox.Location = new System.Drawing.Point(237, 39);
            this.worldTextBox.Name = "worldTextBox";
            this.worldTextBox.Size = new System.Drawing.Size(100, 20);
            this.worldTextBox.TabIndex = 8;
            // 
            // ignoreversionCheckBox
            // 
            this.ignoreversionCheckBox.AutoSize = true;
            this.ignoreversionCheckBox.Location = new System.Drawing.Point(15, 59);
            this.ignoreversionCheckBox.Name = "ignoreversionCheckBox";
            this.ignoreversionCheckBox.Size = new System.Drawing.Size(131, 17);
            this.ignoreversionCheckBox.TabIndex = 9;
            this.ignoreversionCheckBox.Text = "Ignore Plugin Versions";
            this.ignoreversionCheckBox.UseVisualStyleBackColor = true;
            this.ignoreversionCheckBox.CheckedChanged += new System.EventHandler(this.ignoreversionCheckBox_CheckedChanged);
            // 
            // createBatchButton
            // 
            this.createBatchButton.Location = new System.Drawing.Point(15, 377);
            this.createBatchButton.Name = "createBatchButton";
            this.createBatchButton.Size = new System.Drawing.Size(142, 23);
            this.createBatchButton.TabIndex = 10;
            this.createBatchButton.Text = "Create \"startServer.bat\"";
            this.createBatchButton.UseVisualStyleBackColor = true;
            this.createBatchButton.Click += new System.EventHandler(this.createBatchButton_Click);
            // 
            // commandLineParamLabel
            // 
            this.commandLineParamLabel.AutoSize = true;
            this.commandLineParamLabel.Location = new System.Drawing.Point(12, 335);
            this.commandLineParamLabel.Name = "commandLineParamLabel";
            this.commandLineParamLabel.Size = new System.Drawing.Size(136, 13);
            this.commandLineParamLabel.TabIndex = 11;
            this.commandLineParamLabel.Text = "Command Line Parameters:";
            // 
            // updateParamsButton
            // 
            this.updateParamsButton.Location = new System.Drawing.Point(154, 325);
            this.updateParamsButton.Name = "updateParamsButton";
            this.updateParamsButton.Size = new System.Drawing.Size(142, 23);
            this.updateParamsButton.TabIndex = 12;
            this.updateParamsButton.Text = "Update Parameters";
            this.updateParamsButton.UseVisualStyleBackColor = true;
            this.updateParamsButton.Click += new System.EventHandler(this.updateParamsButton_Click);
            // 
            // logo
            // 
            this.logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(381, 6);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(246, 70);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 6;
            this.logo.TabStop = false;
            this.logo.WaitOnLoad = true;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // TShockGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 455);
            this.Controls.Add(this.updateParamsButton);
            this.Controls.Add(this.commandLineParamLabel);
            this.Controls.Add(this.createBatchButton);
            this.Controls.Add(this.ignoreversionCheckBox);
            this.Controls.Add(this.worldTextBox);
            this.Controls.Add(this.worldLabel);
            this.Controls.Add(this.argsTextbox);
            this.Controls.Add(this.worldpathLabel);
            this.Controls.Add(this.worldpathTextBox);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.portText);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.logo);
            this.Name = "TShockGUI";
            this.Text = "TShockGUI";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox portText;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.TextBox worldpathTextBox;
        private System.Windows.Forms.Label worldpathLabel;
        private System.Windows.Forms.TextBox argsTextbox;
        private System.Windows.Forms.Label worldLabel;
        private System.Windows.Forms.TextBox worldTextBox;
        private System.Windows.Forms.CheckBox ignoreversionCheckBox;
        private System.Windows.Forms.Button createBatchButton;
        private System.Windows.Forms.Label commandLineParamLabel;
        private System.Windows.Forms.Button updateParamsButton;
        private System.Windows.Forms.PictureBox logo;
    }
}

