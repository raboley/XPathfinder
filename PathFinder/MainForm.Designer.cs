// ***********************************************************************
// Assembly         : PathFinder
// Author           : xenonsmurf
// Created          : 03-16-2020
//
// Last Modified By : xenonsmurf
// Last Modified On : 07-13-2020
// ***********************************************************************
// <copyright file="MainForm.Designer.cs" company="Xenonsmurf">
//     Copyright ©  2020
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace PathFinder
{
    /// <summary>
    /// Class MainForm.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    partial class MainForm
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
            this.CheckedItemsRTB = new System.Windows.Forms.RichTextBox();
            this.NextBtn = new System.Windows.Forms.Button();
            this.ToonPanel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transparentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CheckedItemsRTB
            // 
            this.CheckedItemsRTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.CheckedItemsRTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckedItemsRTB.Location = new System.Drawing.Point(0, 24);
            this.CheckedItemsRTB.Margin = new System.Windows.Forms.Padding(0);
            this.CheckedItemsRTB.Name = "CheckedItemsRTB";
            this.CheckedItemsRTB.Size = new System.Drawing.Size(778, 526);
            this.CheckedItemsRTB.TabIndex = 18;
            this.CheckedItemsRTB.Text = "";
            // 
            // NextBtn
            // 
            this.NextBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NextBtn.Location = new System.Drawing.Point(0, 550);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(778, 23);
            this.NextBtn.TabIndex = 19;
            this.NextBtn.Text = "Next";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // ToonPanel
            // 
            this.ToonPanel.Location = new System.Drawing.Point(316, 145);
            this.ToonPanel.Name = "ToonPanel";
            this.ToonPanel.Size = new System.Drawing.Size(200, 100);
            this.ToonPanel.TabIndex = 20;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(778, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onTopToolStripMenuItem,
            this.transparentToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "&Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // onTopToolStripMenuItem
            // 
            this.onTopToolStripMenuItem.CheckOnClick = true;
            this.onTopToolStripMenuItem.Name = "onTopToolStripMenuItem";
            this.onTopToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.onTopToolStripMenuItem.Text = "On Top";
            this.onTopToolStripMenuItem.Click += new System.EventHandler(this.onTopToolStripMenuItem_Click);
            // 
            // transparentToolStripMenuItem
            // 
            this.transparentToolStripMenuItem.CheckOnClick = true;
            this.transparentToolStripMenuItem.Name = "transparentToolStripMenuItem";
            this.transparentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.transparentToolStripMenuItem.Text = "Transparent";
            this.transparentToolStripMenuItem.Click += new System.EventHandler(this.transparentToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 573);
            this.Controls.Add(this.CheckedItemsRTB);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.ToonPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "PathFinder";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        /// <summary>
        /// The checked items RTB
        /// </summary>
        public System.Windows.Forms.RichTextBox CheckedItemsRTB;
        /// <summary>
        /// The toon panel
        /// </summary>
        public System.Windows.Forms.Panel ToonPanel;
        /// <summary>
        /// The next BTN
        /// </summary>
        public System.Windows.Forms.Button NextBtn;
        /// <summary>
        /// The menu strip1
        /// </summary>
        private System.Windows.Forms.MenuStrip menuStrip1;
        /// <summary>
        /// The settings tool strip menu item
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        /// <summary>
        /// The on top tool strip menu item
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem onTopToolStripMenuItem;
        /// <summary>
        /// The transparent tool strip menu item
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem transparentToolStripMenuItem;
    }
}

