﻿namespace Elra3y.PL.Forms
{
    partial class FrmRequiredItems
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvRequiredItems = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.radAll = new System.Windows.Forms.RadioButton();
            this.rad0 = new System.Windows.Forms.RadioButton();
            this.rad1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequiredItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRequiredItems
            // 
            this.dgvRequiredItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRequiredItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRequiredItems.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRequiredItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvRequiredItems.Location = new System.Drawing.Point(12, 42);
            this.dgvRequiredItems.Name = "dgvRequiredItems";
            this.dgvRequiredItems.ReadOnly = true;
            this.dgvRequiredItems.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvRequiredItems.Size = new System.Drawing.Size(402, 299);
            this.dgvRequiredItems.TabIndex = 6;
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Image = global::Elra3y.Properties.Resources.Exit;
            this.btnClose.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btnClose.Location = new System.Drawing.Point(148, 347);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 40);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "خروج";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // radAll
            // 
            this.radAll.AutoSize = true;
            this.radAll.Checked = true;
            this.radAll.Location = new System.Drawing.Point(366, 12);
            this.radAll.Name = "radAll";
            this.radAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radAll.Size = new System.Drawing.Size(48, 24);
            this.radAll.TabIndex = 8;
            this.radAll.TabStop = true;
            this.radAll.Text = "الكل";
            this.radAll.UseVisualStyleBackColor = true;
            this.radAll.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // rad0
            // 
            this.rad0.AutoSize = true;
            this.rad0.Location = new System.Drawing.Point(312, 12);
            this.rad0.Name = "rad0";
            this.rad0.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rad0.Size = new System.Drawing.Size(36, 24);
            this.rad0.TabIndex = 9;
            this.rad0.TabStop = true;
            this.rad0.Text = "0";
            this.rad0.UseVisualStyleBackColor = true;
            this.rad0.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // rad1
            // 
            this.rad1.AutoSize = true;
            this.rad1.Location = new System.Drawing.Point(270, 12);
            this.rad1.Name = "rad1";
            this.rad1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rad1.Size = new System.Drawing.Size(36, 24);
            this.rad1.TabIndex = 10;
            this.rad1.TabStop = true;
            this.rad1.Text = "1";
            this.rad1.UseVisualStyleBackColor = true;
            this.rad1.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // FrmRequiredItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 399);
            this.Controls.Add(this.rad1);
            this.Controls.Add(this.rad0);
            this.Controls.Add(this.radAll);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvRequiredItems);
            this.DoubleBuffered = true;
            this.Name = "FrmRequiredItems";
            this.Text = "المطلوب";
            this.Load += new System.EventHandler(this.FrmRequiredItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequiredItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvRequiredItems;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private System.Windows.Forms.RadioButton radAll;
        private System.Windows.Forms.RadioButton rad0;
        private System.Windows.Forms.RadioButton rad1;
    }
}