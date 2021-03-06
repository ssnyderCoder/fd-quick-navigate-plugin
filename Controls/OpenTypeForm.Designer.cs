﻿namespace QuickNavigatePlugin
{
    partial class OpenTypeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search string: (UPPERCASE for search by abbreviation)";
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox.Location = new System.Drawing.Point(12, 26);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(355, 22);
            this.textBox.TabIndex = 1;
            this.textBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // listBox
            // 
            this.listBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox.BackColor = System.Drawing.Color.FloralWhite;
            this.listBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(12, 53);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(355, 194);
            this.listBox.TabIndex = 2;
            this.listBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ListBox_DrawItem);
            this.listBox.Resize += new System.EventHandler(this.ListBox_Resize);
            this.listBox.DoubleClick += new System.EventHandler(this.ListBox_DoubleClick);
            // 
            // OpenTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 255);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(320, 200);
            this.Name = "OpenTypeForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Open Type";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OpenTypeForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OpenTypeForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ListBox listBox;
    }
}