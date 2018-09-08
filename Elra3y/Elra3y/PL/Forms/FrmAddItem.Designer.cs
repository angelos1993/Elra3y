namespace Elra3y.PL.Forms
{
    partial class FrmAddItem
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cmbCaterories = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtShortName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.dblInWholesalePrice = new DevComponents.Editors.DoubleInput();
            this.dblInSellingPrice = new DevComponents.Editors.DoubleInput();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.intInCount = new DevComponents.Editors.IntegerInput();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblInWholesalePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblInSellingPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intInCount)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(339, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "الفئة";
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.Border.Class = "TextBoxBorder";
            this.txtName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtName.Location = new System.Drawing.Point(26, 44);
            this.txtName.Name = "txtName";
            this.txtName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtName.Size = new System.Drawing.Size(307, 26);
            this.txtName.TabIndex = 1;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(339, 44);
            this.labelX2.Name = "labelX2";
            this.labelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 4;
            this.labelX2.Text = "الاسم";
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
            this.cmbCaterories.Size = new System.Drawing.Size(307, 26);
            this.cmbCaterories.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbCaterories.TabIndex = 0;
            // 
            // txtShortName
            // 
            // 
            // 
            // 
            this.txtShortName.Border.Class = "TextBoxBorder";
            this.txtShortName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtShortName.Location = new System.Drawing.Point(26, 76);
            this.txtShortName.Name = "txtShortName";
            this.txtShortName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtShortName.Size = new System.Drawing.Size(307, 26);
            this.txtShortName.TabIndex = 2;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(339, 76);
            this.labelX3.Name = "labelX3";
            this.labelX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 7;
            this.labelX3.Text = "الإختصار";
            // 
            // txtCode
            // 
            // 
            // 
            // 
            this.txtCode.Border.Class = "TextBoxBorder";
            this.txtCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCode.Location = new System.Drawing.Point(26, 108);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(307, 26);
            this.txtCode.TabIndex = 3;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(339, 108);
            this.labelX4.Name = "labelX4";
            this.labelX4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 9;
            this.labelX4.Text = "الكود";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(339, 140);
            this.labelX5.Name = "labelX5";
            this.labelX5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 11;
            this.labelX5.Text = "السعر جملة";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(339, 172);
            this.labelX6.Name = "labelX6";
            this.labelX6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX6.Size = new System.Drawing.Size(75, 23);
            this.labelX6.TabIndex = 13;
            this.labelX6.Text = "السعر بيع";
            // 
            // dblInWholesalePrice
            // 
            // 
            // 
            // 
            this.dblInWholesalePrice.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dblInWholesalePrice.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dblInWholesalePrice.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.dblInWholesalePrice.Increment = 1D;
            this.dblInWholesalePrice.Location = new System.Drawing.Point(26, 140);
            this.dblInWholesalePrice.MinValue = 0D;
            this.dblInWholesalePrice.Name = "dblInWholesalePrice";
            this.dblInWholesalePrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dblInWholesalePrice.ShowUpDown = true;
            this.dblInWholesalePrice.Size = new System.Drawing.Size(307, 26);
            this.dblInWholesalePrice.TabIndex = 4;
            // 
            // dblInSellingPrice
            // 
            // 
            // 
            // 
            this.dblInSellingPrice.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dblInSellingPrice.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dblInSellingPrice.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.dblInSellingPrice.Increment = 1D;
            this.dblInSellingPrice.Location = new System.Drawing.Point(26, 172);
            this.dblInSellingPrice.MinValue = 0D;
            this.dblInSellingPrice.Name = "dblInSellingPrice";
            this.dblInSellingPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dblInSellingPrice.ShowUpDown = true;
            this.dblInSellingPrice.Size = new System.Drawing.Size(307, 26);
            this.dblInSellingPrice.TabIndex = 5;
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.Class = "";
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(339, 204);
            this.labelX7.Name = "labelX7";
            this.labelX7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX7.Size = new System.Drawing.Size(75, 23);
            this.labelX7.TabIndex = 16;
            this.labelX7.Text = "الكمية";
            // 
            // intInCount
            // 
            // 
            // 
            // 
            this.intInCount.BackgroundStyle.Class = "DateTimeInputBackground";
            this.intInCount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.intInCount.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.intInCount.Location = new System.Drawing.Point(26, 204);
            this.intInCount.MinValue = 0;
            this.intInCount.Name = "intInCount";
            this.intInCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.intInCount.ShowUpDown = true;
            this.intInCount.Size = new System.Drawing.Size(307, 26);
            this.intInCount.TabIndex = 6;
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Image = global::Elra3y.Properties.Resources.Exit;
            this.btnClose.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btnClose.Location = new System.Drawing.Point(80, 236);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 40);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "خروج";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = global::Elra3y.Properties.Resources.Save;
            this.btnSave.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btnSave.Location = new System.Drawing.Point(216, 236);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 40);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "حفظ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmAddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 282);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.intInCount);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.dblInSellingPrice);
            this.Controls.Add(this.dblInWholesalePrice);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.txtShortName);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.cmbCaterories);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Name = "FrmAddItem";
            this.Text = "إضافة صنف";
            this.Load += new System.EventHandler(this.FrmAddItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblInWholesalePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblInSellingPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intInCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtName;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbCaterories;
        private DevComponents.DotNetBar.Controls.TextBoxX txtShortName;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCode;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.Editors.DoubleInput dblInWholesalePrice;
        private DevComponents.Editors.DoubleInput dblInSellingPrice;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.Editors.IntegerInput intInCount;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.ButtonX btnSave;
    }
}