﻿namespace JarrettVance.ChapterTools
{
    partial class QuickOpenDialog
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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.btnDir = new System.Windows.Forms.Button();
            this.flowDiscs = new System.Windows.Forms.FlowLayoutPanel();
            this.discItem1 = new JarrettVance.ChapterTools.DiscItem();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowDiscs.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.Controls.Add(this.btnOK);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(14, 322);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(611, 30);
            this.flowLayoutPanel2.TabIndex = 17;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOK.AutoSize = true;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOK.Image = global::JarrettVance.ChapterTools.Properties.Resources.cancel;
            this.btnOK.Location = new System.Drawing.Point(531, 0);
            this.btnOK.Margin = new System.Windows.Forms.Padding(0);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 30);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "Cancel";
            this.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // txtFolder
            // 
            this.txtFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFolder.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtFolder.Location = new System.Drawing.Point(10, 10);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.ReadOnly = true;
            this.txtFolder.Size = new System.Drawing.Size(576, 24);
            this.txtFolder.TabIndex = 14;
            // 
            // btnDir
            // 
            this.btnDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDir.Image = global::JarrettVance.ChapterTools.Properties.Resources.folder;
            this.btnDir.Location = new System.Drawing.Point(591, 9);
            this.btnDir.Name = "btnDir";
            this.btnDir.Size = new System.Drawing.Size(34, 26);
            this.btnDir.TabIndex = 15;
            this.btnDir.UseVisualStyleBackColor = true;
            this.btnDir.Click += new System.EventHandler(this.btnDir_Click);
            // 
            // flowDiscs
            // 
            this.flowDiscs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowDiscs.AutoScroll = true;
            this.flowDiscs.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowDiscs.BackColor = System.Drawing.Color.White;
            this.flowDiscs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowDiscs.Controls.Add(this.discItem1);
            this.flowDiscs.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.flowDiscs.Location = new System.Drawing.Point(10, 40);
            this.flowDiscs.Name = "flowDiscs";
            this.flowDiscs.Padding = new System.Windows.Forms.Padding(4);
            this.flowDiscs.Size = new System.Drawing.Size(614, 273);
            this.flowDiscs.TabIndex = 18;
            // 
            // discItem1
            // 
            this.discItem1.BackColor = System.Drawing.Color.White;
            this.discItem1.Location = new System.Drawing.Point(7, 7);
            this.discItem1.Name = "discItem1";
            this.discItem1.Size = new System.Drawing.Size(598, 54);
            this.discItem1.TabIndex = 0;
            // 
            // QuickOpenDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMargin = new System.Drawing.Size(100, 0);
            this.CancelButton = this.btnOK;
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.ControlBox = false;
            this.Controls.Add(this.flowDiscs);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.btnDir);
            this.Controls.Add(this.txtFolder);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuickOpenDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quick Open";
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowDiscs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    private System.Windows.Forms.Button btnOK;
    private System.Windows.Forms.Button btnDir;
    private System.Windows.Forms.TextBox txtFolder;
    private System.Windows.Forms.FlowLayoutPanel flowDiscs;
    private DiscItem discItem1;

  }
}