﻿namespace ARKViewer
{
    partial class frmTribeLog
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
            this.lblPlayerLevelLabel = new System.Windows.Forms.Label();
            this.lblPlayerLevel = new System.Windows.Forms.Label();
            this.lblTribeName = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.picPlayerGender = new System.Windows.Forms.PictureBox();
            this.pnlPlayerInventory = new System.Windows.Forms.Panel();
            this.lvwLog = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnClose = new System.Windows.Forms.Button();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerGender)).BeginInit();
            this.pnlPlayerInventory.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPlayerLevelLabel
            // 
            this.lblPlayerLevelLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPlayerLevelLabel.AutoSize = true;
            this.lblPlayerLevelLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPlayerLevelLabel.Location = new System.Drawing.Point(766, 14);
            this.lblPlayerLevelLabel.Name = "lblPlayerLevelLabel";
            this.lblPlayerLevelLabel.Size = new System.Drawing.Size(65, 13);
            this.lblPlayerLevelLabel.TabIndex = 8;
            this.lblPlayerLevelLabel.Text = "Player Level";
            // 
            // lblPlayerLevel
            // 
            this.lblPlayerLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPlayerLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerLevel.ForeColor = System.Drawing.Color.Black;
            this.lblPlayerLevel.Location = new System.Drawing.Point(767, 27);
            this.lblPlayerLevel.Name = "lblPlayerLevel";
            this.lblPlayerLevel.Size = new System.Drawing.Size(62, 31);
            this.lblPlayerLevel.TabIndex = 9;
            this.lblPlayerLevel.Text = "135";
            this.lblPlayerLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTribeName
            // 
            this.lblTribeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTribeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTribeName.ForeColor = System.Drawing.Color.DimGray;
            this.lblTribeName.Location = new System.Drawing.Point(74, 41);
            this.lblTribeName.Name = "lblTribeName";
            this.lblTribeName.Size = new System.Drawing.Size(614, 17);
            this.lblTribeName.TabIndex = 7;
            this.lblTribeName.Text = "Tribe Name";
            this.lblTribeName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.ForeColor = System.Drawing.Color.Black;
            this.lblPlayerName.Location = new System.Drawing.Point(72, 8);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(475, 31);
            this.lblPlayerName.TabIndex = 6;
            this.lblPlayerName.Text = "Player Name";
            this.lblPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picPlayerGender
            // 
            this.picPlayerGender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPlayerGender.Image = global::ARKViewer.Properties.Resources.marker_28;
            this.picPlayerGender.Location = new System.Drawing.Point(17, 8);
            this.picPlayerGender.Name = "picPlayerGender";
            this.picPlayerGender.Size = new System.Drawing.Size(50, 50);
            this.picPlayerGender.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayerGender.TabIndex = 11;
            this.picPlayerGender.TabStop = false;
            // 
            // pnlPlayerInventory
            // 
            this.pnlPlayerInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPlayerInventory.BackColor = System.Drawing.Color.PowderBlue;
            this.pnlPlayerInventory.Controls.Add(this.lvwLog);
            this.pnlPlayerInventory.Location = new System.Drawing.Point(12, 73);
            this.pnlPlayerInventory.Name = "pnlPlayerInventory";
            this.pnlPlayerInventory.Size = new System.Drawing.Size(819, 362);
            this.pnlPlayerInventory.TabIndex = 10;
            // 
            // lvwLog
            // 
            this.lvwLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lvwLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3});
            this.lvwLog.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lvwLog.FullRowSelect = true;
            this.lvwLog.HideSelection = false;
            this.lvwLog.Location = new System.Drawing.Point(22, 20);
            this.lvwLog.Name = "lvwLog";
            this.lvwLog.Size = new System.Drawing.Size(767, 320);
            this.lvwLog.TabIndex = 0;
            this.lvwLog.UseCompatibleStateImageBehavior = false;
            this.lvwLog.View = System.Windows.Forms.View.Details;
            this.lvwLog.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwLog_ColumnClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Date";
            this.columnHeader1.Width = 110;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(756, 443);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Information";
            this.columnHeader3.Width = 630;
            // 
            // frmPlayerTribeLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 478);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblPlayerLevelLabel);
            this.Controls.Add(this.lblPlayerLevel);
            this.Controls.Add(this.lblTribeName);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.picPlayerGender);
            this.Controls.Add(this.pnlPlayerInventory);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPlayerTribeLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tribe Log Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerGender)).EndInit();
            this.pnlPlayerInventory.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayerLevelLabel;
        private System.Windows.Forms.Label lblPlayerLevel;
        private System.Windows.Forms.Label lblTribeName;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.PictureBox picPlayerGender;
        private System.Windows.Forms.Panel pnlPlayerInventory;
        private System.Windows.Forms.ListView lvwLog;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}