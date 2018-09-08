namespace Elra3y.PL.Forms
{
    partial class FrmAddSale
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
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.intInCount = new DevComponents.Editors.IntegerInput();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.cmbItems = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cmbCaterories = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.dtSaleDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.dblInPrice = new DevComponents.Editors.DoubleInput();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intInCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSaleDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblInPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Image = global::Elra3y.Properties.Resources.Exit;
            this.btnClose.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btnClose.Location = new System.Drawing.Point(80, 173);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 40);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 28;
            this.btnClose.Text = "خروج";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = global::Elra3y.Properties.Resources.Save;
            this.btnSave.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btnSave.Location = new System.Drawing.Point(216, 173);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 40);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "حفظ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // intInCount
            // 
            // 
            // 
            // 
            this.intInCount.BackgroundStyle.Class = "DateTimeInputBackground";
            this.intInCount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.intInCount.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.intInCount.Location = new System.Drawing.Point(19, 108);
            this.intInCount.MinValue = 0;
            this.intInCount.Name = "intInCount";
            this.intInCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.intInCount.ShowUpDown = true;
            this.intInCount.Size = new System.Drawing.Size(293, 26);
            this.intInCount.TabIndex = 25;
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.Class = "";
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(318, 108);
            this.labelX7.Name = "labelX7";
            this.labelX7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX7.Size = new System.Drawing.Size(89, 23);
            this.labelX7.TabIndex = 26;
            this.labelX7.Text = "الكمية المُباعة";
            // 
            // cmbItems
            // 
            this.cmbItems.DisplayMember = "Text";
            this.cmbItems.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItems.FormattingEnabled = true;
            this.cmbItems.ItemHeight = 20;
            this.cmbItems.Location = new System.Drawing.Point(19, 76);
            this.cmbItems.Name = "cmbItems";
            this.cmbItems.Size = new System.Drawing.Size(293, 26);
            this.cmbItems.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbItems.TabIndex = 23;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(318, 76);
            this.labelX2.Name = "labelX2";
            this.labelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX2.Size = new System.Drawing.Size(89, 23);
            this.labelX2.TabIndex = 24;
            this.labelX2.Text = "الصنف";
            // 
            // cmbCaterories
            // 
            this.cmbCaterories.DisplayMember = "Text";
            this.cmbCaterories.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCaterories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCaterories.FormattingEnabled = true;
            this.cmbCaterories.ItemHeight = 20;
            this.cmbCaterories.Location = new System.Drawing.Point(19, 44);
            this.cmbCaterories.Name = "cmbCaterories";
            this.cmbCaterories.Size = new System.Drawing.Size(293, 26);
            this.cmbCaterories.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbCaterories.TabIndex = 21;
            this.cmbCaterories.SelectedIndexChanged += new System.EventHandler(this.cmbCaterories_SelectedIndexChanged);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(318, 44);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(89, 23);
            this.labelX1.TabIndex = 22;
            this.labelX1.Text = "الفئة";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(325, 12);
            this.labelX3.Name = "labelX3";
            this.labelX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX3.Size = new System.Drawing.Size(89, 23);
            this.labelX3.TabIndex = 29;
            this.labelX3.Text = "تاريخ البيع";
            // 
            // dtSaleDate
            // 
            // 
            // 
            // 
            this.dtSaleDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtSaleDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtSaleDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtSaleDate.ButtonDropDown.Visible = true;
            this.dtSaleDate.CustomFormat = "dd/M/yyyy";
            this.dtSaleDate.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dtSaleDate.Location = new System.Drawing.Point(19, 12);
            // 
            // 
            // 
            this.dtSaleDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtSaleDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtSaleDate.MonthCalendar.BackgroundStyle.Class = "";
            this.dtSaleDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtSaleDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtSaleDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtSaleDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtSaleDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtSaleDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtSaleDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtSaleDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtSaleDate.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dtSaleDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtSaleDate.MonthCalendar.DisplayMonth = new System.DateTime(2018, 9, 1, 0, 0, 0, 0);
            this.dtSaleDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtSaleDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtSaleDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtSaleDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtSaleDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtSaleDate.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dtSaleDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtSaleDate.MonthCalendar.TodayButtonVisible = true;
            this.dtSaleDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtSaleDate.Name = "dtSaleDate";
            this.dtSaleDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtSaleDate.Size = new System.Drawing.Size(293, 26);
            this.dtSaleDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtSaleDate.TabIndex = 30;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(318, 137);
            this.labelX4.Name = "labelX4";
            this.labelX4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX4.Size = new System.Drawing.Size(89, 23);
            this.labelX4.TabIndex = 31;
            this.labelX4.Text = "السعر";
            // 
            // dblInPrice
            // 
            // 
            // 
            // 
            this.dblInPrice.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dblInPrice.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dblInPrice.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.dblInPrice.Increment = 1D;
            this.dblInPrice.Location = new System.Drawing.Point(19, 140);
            this.dblInPrice.MinValue = 0D;
            this.dblInPrice.Name = "dblInPrice";
            this.dblInPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dblInPrice.ShowUpDown = true;
            this.dblInPrice.Size = new System.Drawing.Size(293, 26);
            this.dblInPrice.TabIndex = 32;
            // 
            // FrmAddSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 225);
            this.Controls.Add(this.dblInPrice);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.dtSaleDate);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.intInCount);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.cmbItems);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.cmbCaterories);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Name = "FrmAddSale";
            this.Text = "بيع جديد";
            this.Load += new System.EventHandler(this.FrmAddSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intInCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSaleDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblInPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.Editors.IntegerInput intInCount;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbItems;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbCaterories;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtSaleDate;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.Editors.DoubleInput dblInPrice;
    }
}