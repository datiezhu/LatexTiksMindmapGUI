﻿namespace LatexTiksMindMapTool
{
    partial class MindmapForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        //private Node root;
        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MindmapForm));
            this.childrenListBox = new System.Windows.Forms.ListBox();
            this.addChildButton = new System.Windows.Forms.Button();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.contentTextBox = new System.Windows.Forms.TextBox();
            this.backToParentButton = new System.Windows.Forms.Button();
            this.createLatexCodeButton = new System.Windows.Forms.Button();
            this.clockWiseCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.startAngleNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.levelDistanceTrackBar = new System.Windows.Forms.TrackBar();
            this.enableLevelDistanceCeckBox = new System.Windows.Forms.CheckBox();
            this.levelDistanceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.siblingAngleChildrenNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteNodeButton = new System.Windows.Forms.Button();
            this.startAngleTrackBar = new System.Windows.Forms.TrackBar();
            this.siblingAngleChildrenTrackBar = new System.Windows.Forms.TrackBar();
            this.filesListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.startAngleNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelDistanceTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelDistanceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siblingAngleChildrenNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startAngleTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siblingAngleChildrenTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // childrenListBox
            // 
            this.childrenListBox.FormattingEnabled = true;
            this.childrenListBox.Location = new System.Drawing.Point(12, 187);
            this.childrenListBox.Name = "childrenListBox";
            this.childrenListBox.Size = new System.Drawing.Size(148, 69);
            this.childrenListBox.TabIndex = 0;
            this.childrenListBox.SelectedIndexChanged += new System.EventHandler(this.childrenListBox_SelectedIndexChanged);
            // 
            // addChildButton
            // 
            this.addChildButton.Location = new System.Drawing.Point(174, 187);
            this.addChildButton.Name = "addChildButton";
            this.addChildButton.Size = new System.Drawing.Size(83, 34);
            this.addChildButton.TabIndex = 1;
            this.addChildButton.Text = "Add Child";
            this.addChildButton.UseVisualStyleBackColor = true;
            this.addChildButton.Click += new System.EventHandler(this.addChildButton_Click);
            // 
            // colorTextBox
            // 
            this.colorTextBox.Location = new System.Drawing.Point(12, 144);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(148, 20);
            this.colorTextBox.TabIndex = 3;
            this.colorTextBox.TextChanged += new System.EventHandler(this.colorTextBox_TextChanged);
            // 
            // contentTextBox
            // 
            this.contentTextBox.Location = new System.Drawing.Point(12, 51);
            this.contentTextBox.Multiline = true;
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.Size = new System.Drawing.Size(144, 74);
            this.contentTextBox.TabIndex = 4;
            this.contentTextBox.TextChanged += new System.EventHandler(this.contentTextBox_TextChanged);
            // 
            // backToParentButton
            // 
            this.backToParentButton.Location = new System.Drawing.Point(16, 12);
            this.backToParentButton.Name = "backToParentButton";
            this.backToParentButton.Size = new System.Drawing.Size(80, 23);
            this.backToParentButton.TabIndex = 5;
            this.backToParentButton.Text = "<<";
            this.backToParentButton.UseVisualStyleBackColor = true;
            this.backToParentButton.Click += new System.EventHandler(this.backToParentButton_Click);
            // 
            // createLatexCodeButton
            // 
            this.createLatexCodeButton.Location = new System.Drawing.Point(174, 269);
            this.createLatexCodeButton.Name = "createLatexCodeButton";
            this.createLatexCodeButton.Size = new System.Drawing.Size(83, 34);
            this.createLatexCodeButton.TabIndex = 8;
            this.createLatexCodeButton.Text = "Create Latex Code";
            this.createLatexCodeButton.UseVisualStyleBackColor = true;
            this.createLatexCodeButton.Click += new System.EventHandler(this.createLatexCodeButton_Click);
            // 
            // clockWiseCheckBox
            // 
            this.clockWiseCheckBox.AutoSize = true;
            this.clockWiseCheckBox.Location = new System.Drawing.Point(174, 98);
            this.clockWiseCheckBox.Name = "clockWiseCheckBox";
            this.clockWiseCheckBox.Size = new System.Drawing.Size(115, 17);
            this.clockWiseCheckBox.TabIndex = 10;
            this.clockWiseCheckBox.Text = "Children Clockwise";
            this.clockWiseCheckBox.UseVisualStyleBackColor = true;
            this.clockWiseCheckBox.CheckedChanged += new System.EventHandler(this.clockWiseCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(588, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "startAngle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Content";
            // 
            // startAngleNumericUpDown
            // 
            this.startAngleNumericUpDown.Location = new System.Drawing.Point(591, 52);
            this.startAngleNumericUpDown.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.startAngleNumericUpDown.Name = "startAngleNumericUpDown";
            this.startAngleNumericUpDown.Size = new System.Drawing.Size(77, 20);
            this.startAngleNumericUpDown.TabIndex = 15;
            this.startAngleNumericUpDown.ValueChanged += new System.EventHandler(this.startAngleNumericUpDown_ValueChanged);
            // 
            // levelDistanceTrackBar
            // 
            this.levelDistanceTrackBar.Enabled = false;
            this.levelDistanceTrackBar.Location = new System.Drawing.Point(710, 51);
            this.levelDistanceTrackBar.Maximum = 10000;
            this.levelDistanceTrackBar.Name = "levelDistanceTrackBar";
            this.levelDistanceTrackBar.Size = new System.Drawing.Size(148, 45);
            this.levelDistanceTrackBar.TabIndex = 16;
            this.levelDistanceTrackBar.Scroll += new System.EventHandler(this.levelDistanceTrackBar_Scroll);
            // 
            // enableLevelDistanceCeckBox
            // 
            this.enableLevelDistanceCeckBox.AutoSize = true;
            this.enableLevelDistanceCeckBox.Location = new System.Drawing.Point(729, 26);
            this.enableLevelDistanceCeckBox.Name = "enableLevelDistanceCeckBox";
            this.enableLevelDistanceCeckBox.Size = new System.Drawing.Size(145, 17);
            this.enableLevelDistanceCeckBox.TabIndex = 17;
            this.enableLevelDistanceCeckBox.Text = "enable Level Distance fix";
            this.enableLevelDistanceCeckBox.UseVisualStyleBackColor = true;
            this.enableLevelDistanceCeckBox.CheckedChanged += new System.EventHandler(this.enableLevelDistanceCheckBox_CheckedChanged);
            // 
            // levelDistanceNumericUpDown
            // 
            this.levelDistanceNumericUpDown.DecimalPlaces = 2;
            this.levelDistanceNumericUpDown.Enabled = false;
            this.levelDistanceNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.levelDistanceNumericUpDown.Location = new System.Drawing.Point(854, 51);
            this.levelDistanceNumericUpDown.Name = "levelDistanceNumericUpDown";
            this.levelDistanceNumericUpDown.Size = new System.Drawing.Size(77, 20);
            this.levelDistanceNumericUpDown.TabIndex = 18;
            this.levelDistanceNumericUpDown.ValueChanged += new System.EventHandler(this.levelDistanceNumericUpDown_ValueChanged);
            // 
            // siblingAngleChildrenNumericUpDown
            // 
            this.siblingAngleChildrenNumericUpDown.Location = new System.Drawing.Point(591, 98);
            this.siblingAngleChildrenNumericUpDown.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.siblingAngleChildrenNumericUpDown.Name = "siblingAngleChildrenNumericUpDown";
            this.siblingAngleChildrenNumericUpDown.Size = new System.Drawing.Size(77, 20);
            this.siblingAngleChildrenNumericUpDown.TabIndex = 19;
            this.siblingAngleChildrenNumericUpDown.ValueChanged += new System.EventHandler(this.siblingAngleChildrenNumericUpDown_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(588, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Sibling Angle Children";
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(277, 170);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(932, 404);
            this.webBrowser.TabIndex = 21;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 269);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(83, 34);
            this.saveButton.TabIndex = 22;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deleteNodeButton
            // 
            this.deleteNodeButton.Location = new System.Drawing.Point(174, 51);
            this.deleteNodeButton.Name = "deleteNodeButton";
            this.deleteNodeButton.Size = new System.Drawing.Size(83, 34);
            this.deleteNodeButton.TabIndex = 23;
            this.deleteNodeButton.Text = "Delete Node";
            this.deleteNodeButton.UseVisualStyleBackColor = true;
            this.deleteNodeButton.Click += new System.EventHandler(this.deleteChildButton_Click);
            // 
            // startAngleTrackBar
            // 
            this.startAngleTrackBar.Location = new System.Drawing.Point(434, 40);
            this.startAngleTrackBar.Maximum = 360;
            this.startAngleTrackBar.Name = "startAngleTrackBar";
            this.startAngleTrackBar.Size = new System.Drawing.Size(148, 45);
            this.startAngleTrackBar.TabIndex = 24;
            this.startAngleTrackBar.Scroll += new System.EventHandler(this.startAngleTrackBar_Scroll);
            // 
            // siblingAngleChildrenTrackBar
            // 
            this.siblingAngleChildrenTrackBar.Location = new System.Drawing.Point(437, 82);
            this.siblingAngleChildrenTrackBar.Maximum = 360;
            this.siblingAngleChildrenTrackBar.Name = "siblingAngleChildrenTrackBar";
            this.siblingAngleChildrenTrackBar.Size = new System.Drawing.Size(148, 45);
            this.siblingAngleChildrenTrackBar.TabIndex = 25;
            this.siblingAngleChildrenTrackBar.Scroll += new System.EventHandler(this.siblingAngleChildrenTrackBar_Scroll);
            // 
            // filesListBox
            // 
            this.filesListBox.FormattingEnabled = true;
            this.filesListBox.Location = new System.Drawing.Point(283, 56);
            this.filesListBox.Name = "filesListBox";
            this.filesListBox.Size = new System.Drawing.Size(148, 69);
            this.filesListBox.TabIndex = 26;
            this.filesListBox.SelectedIndexChanged += new System.EventHandler(this.filesListBox_SelectedIndexChanged);
            // 
            // MindmapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 598);
            this.Controls.Add(this.filesListBox);
            this.Controls.Add(this.siblingAngleChildrenTrackBar);
            this.Controls.Add(this.startAngleTrackBar);
            this.Controls.Add(this.deleteNodeButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.siblingAngleChildrenNumericUpDown);
            this.Controls.Add(this.levelDistanceNumericUpDown);
            this.Controls.Add(this.enableLevelDistanceCeckBox);
            this.Controls.Add(this.levelDistanceTrackBar);
            this.Controls.Add(this.startAngleNumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clockWiseCheckBox);
            this.Controls.Add(this.createLatexCodeButton);
            this.Controls.Add(this.backToParentButton);
            this.Controls.Add(this.contentTextBox);
            this.Controls.Add(this.colorTextBox);
            this.Controls.Add(this.addChildButton);
            this.Controls.Add(this.childrenListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MindmapForm";
            this.Text = "Mindmap-Designer";
            ((System.ComponentModel.ISupportInitialize)(this.startAngleNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelDistanceTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelDistanceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siblingAngleChildrenNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startAngleTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siblingAngleChildrenTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox childrenListBox;
        private System.Windows.Forms.Button addChildButton;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.TextBox contentTextBox;
        private System.Windows.Forms.Button backToParentButton;
        private System.Windows.Forms.Button createLatexCodeButton;
        private System.Windows.Forms.CheckBox clockWiseCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown startAngleNumericUpDown;
        private System.Windows.Forms.TrackBar levelDistanceTrackBar;
        private System.Windows.Forms.CheckBox enableLevelDistanceCeckBox;
        private System.Windows.Forms.NumericUpDown levelDistanceNumericUpDown;
        private System.Windows.Forms.NumericUpDown siblingAngleChildrenNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteNodeButton;
        private System.Windows.Forms.TrackBar startAngleTrackBar;
        private System.Windows.Forms.TrackBar siblingAngleChildrenTrackBar;
        private System.Windows.Forms.ListBox filesListBox;
    }
}

