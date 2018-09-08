namespace Elra3y.PL.Forms
{
    partial class FrmIncreaseItemCount
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
            this.cmbCaterories = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cmbItems = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.intInCount = new DevComponents.Editors.IntegerInput();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intInCount)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCaterories
            // 
            this.cmbCaterories.DisplayMember = "Text";
            this.cmbCaterories.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCaterories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCaterories.FormattingEnabled = true;
            this.cmbCaterories.ItemHeight = 20;
            this.cmbCaterories.Location = new System.Drawing.Point(26, 12);
            this.cmbCaterories.Name = "cmbCaterories";
            this.cmbCaterories.Size = new System.Drawing.Size(293, 26);
            this.cmbCaterories.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbCaterories.TabIndex = 3;
            this.cmbCaterories.SelectedIndexChanged += new System.EventHandler(this.cmbCaterories_SelectedIndexChanged);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(325, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(89, 23);
            this.labelX1.TabIndex = 4;
            this.labelX1.Text = "الفئة";
            // 
            // cmbItems
            // 
            this.cmbItems.DisplayMember = "Text";
            this.cmbItems.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItems.FormattingEnabled = true;
            this.cmbItems.ItemHeight = 20;
            this.cmbItems.Location = new System.Drawing.Point(26, 44);
            this.cmbItems.Name = "cmbItems";
            this.cmbItems.Size = new System.Drawing.Size(293, 26);
            this.cmbItems.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbItems.TabIndex = 5;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(325, 44);
            this.labelX2.Name = "labelX2";
            this.labelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX2.Size = new System.Drawing.Size(89, 23);
            this.labelX2.TabIndex = 6;
            this.labelX2.Text = "الصنف";
            // 
            // intInCount
            // 
            // 
            // 
            // 
            this.intInCount.BackgroundStyle.Class = "DateTimeInputBackground";
            this.intInCount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.intInCount.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.intInCount.Location = new System.Drawing.Point(26, 76);
            this.intInCount.MinValue = 0;
            this.intInCount.Name = "intInCount";
            this.intInCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.intInCount.ShowUpDown = true;
            this.intInCount.Size = new System.Drawing.Size(293, 26);
            this.intInCount.TabIndex = 17;
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.Class = "";
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(325, 76);
            this.labelX7.Name = "labelX7";
            this.labelX7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX7.Size = new System.Drawing.Size(89, 23);
            this.labelX7.TabIndex = 18;
            this.labelX7.Text = "الكمية المضافة";
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Image = global::Elra3y.Properties.Resources.Exit;
            this.btnClose.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btnClose.Location = new System.Drawing.Point(80, 108);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 40);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "خروج";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = global::Elra3y.Properties.Resources.Save;
            this.btnSave.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btnSave.Location = new System.Drawing.Point(216, 108);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 40);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "حفظ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmIncreaseItemCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 157);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.intInCount);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.cmbItems);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.cmbCaterories);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Name = "FrmIncreaseItemCount";
            this.Text = "إضافة كمية لصنف";
            this.Load += new System.EventHandler(this.FrmIncreaseItemCount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intInCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbCaterories;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbItems;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.Editors.IntegerInput intInCount;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.ButtonX btnSave;
    }
}