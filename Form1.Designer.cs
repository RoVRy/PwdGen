namespace PwdGen
{
    partial class MainWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWin));
            this.CapLetters = new System.Windows.Forms.CheckBox();
            this.SmLetters = new System.Windows.Forms.CheckBox();
            this.Numbers = new System.Windows.Forms.CheckBox();
            this.SpecSigns = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PwdLenght = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.PwdButton = new System.Windows.Forms.Button();
            this.CopyClipboard = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PwdLenght)).BeginInit();
            this.SuspendLayout();
            // 
            // CapLetters
            // 
            resources.ApplyResources(this.CapLetters, "CapLetters");
            this.CapLetters.Checked = true;
            this.CapLetters.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CapLetters.Name = "CapLetters";
            this.toolTip1.SetToolTip(this.CapLetters, resources.GetString("CapLetters.ToolTip"));
            this.CapLetters.UseVisualStyleBackColor = true;
            this.CapLetters.CheckedChanged += new System.EventHandler(this.CheckBox_Clicked);
            // 
            // SmLetters
            // 
            resources.ApplyResources(this.SmLetters, "SmLetters");
            this.SmLetters.Checked = true;
            this.SmLetters.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SmLetters.Name = "SmLetters";
            this.toolTip1.SetToolTip(this.SmLetters, resources.GetString("SmLetters.ToolTip"));
            this.SmLetters.UseVisualStyleBackColor = true;
            this.SmLetters.CheckedChanged += new System.EventHandler(this.CheckBox_Clicked);
            // 
            // Numbers
            // 
            resources.ApplyResources(this.Numbers, "Numbers");
            this.Numbers.Checked = true;
            this.Numbers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Numbers.Name = "Numbers";
            this.toolTip1.SetToolTip(this.Numbers, resources.GetString("Numbers.ToolTip"));
            this.Numbers.UseVisualStyleBackColor = true;
            this.Numbers.CheckedChanged += new System.EventHandler(this.CheckBox_Clicked);
            // 
            // SpecSigns
            // 
            resources.ApplyResources(this.SpecSigns, "SpecSigns");
            this.SpecSigns.Checked = true;
            this.SpecSigns.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SpecSigns.Name = "SpecSigns";
            this.toolTip1.SetToolTip(this.SpecSigns, resources.GetString("SpecSigns.ToolTip"));
            this.SpecSigns.UseVisualStyleBackColor = true;
            this.SpecSigns.CheckedChanged += new System.EventHandler(this.CheckBox_Clicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CapLetters);
            this.groupBox1.Controls.Add(this.SmLetters);
            this.groupBox1.Controls.Add(this.SpecSigns);
            this.groupBox1.Controls.Add(this.Numbers);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // PwdLenght
            // 
            resources.ApplyResources(this.PwdLenght, "PwdLenght");
            this.PwdLenght.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.PwdLenght.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PwdLenght.Name = "PwdLenght";
            this.PwdLenght.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.PwdLenght.ValueChanged += new System.EventHandler(this.Lenght_Changed);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // PwdButton
            // 
            resources.ApplyResources(this.PwdButton, "PwdButton");
            this.PwdButton.Image = global::PwdGen.Properties.Resources.Refresh_16x16;
            this.PwdButton.Name = "PwdButton";
            this.toolTip1.SetToolTip(this.PwdButton, resources.GetString("PwdButton.ToolTip"));
            this.PwdButton.UseVisualStyleBackColor = true;
            this.PwdButton.Click += new System.EventHandler(this.PwdButton_Click);
            // 
            // CopyClipboard
            // 
            this.CopyClipboard.Image = global::PwdGen.Properties.Resources.Copy_16x16;
            resources.ApplyResources(this.CopyClipboard, "CopyClipboard");
            this.CopyClipboard.Name = "CopyClipboard";
            this.toolTip1.SetToolTip(this.CopyClipboard, resources.GetString("CopyClipboard.ToolTip"));
            this.CopyClipboard.UseVisualStyleBackColor = true;
            this.CopyClipboard.Click += new System.EventHandler(this.CopyClipboard_Click);
            // 
            // MainWin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PwdButton);
            this.Controls.Add(this.CopyClipboard);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PwdLenght);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainWin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PwdLenght)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CapLetters;
        private System.Windows.Forms.CheckBox SmLetters;
        private System.Windows.Forms.CheckBox Numbers;
        private System.Windows.Forms.CheckBox SpecSigns;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown PwdLenght;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CopyClipboard;
        private System.Windows.Forms.Button PwdButton;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

