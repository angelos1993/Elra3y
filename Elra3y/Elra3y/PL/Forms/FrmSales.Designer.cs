namespace Elra3y.PL.Forms
{
    partial class FrmSales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.dgvSales = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dtSaleDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.lblTotalSales = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSaleDate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Image = global::Elra3y.Properties.Resources.Exit;
            this.btnClose.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btnClose.Location = new System.Drawing.Point(242, 391);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 40);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "خروج";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvSales
            // 
            this.dgvSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSales.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSales.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvSales.Location = new System.Drawing.Point(12, 44);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.ReadOnly = true;
            this.dgvSales.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvSales.Size = new System.Drawing.Size(590, 341);
            this.dgvSales.TabIndex = 5;
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
            this.dtSaleDate.Location = new System.Drawing.Point(290, 12);
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
            this.dtSaleDate.Size = new System.Drawing.Size(217, 26);
            this.dtSaleDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtSaleDate.TabIndex = 32;
            this.dtSaleDate.ValueChanged += new System.EventHandler(this.dtSaleDate_ValueChanged);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(513, 12);
            this.labelX3.Name = "labelX3";
            this.labelX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX3.Size = new System.Drawing.Size(89, 23);
            this.labelX3.TabIndex = 31;
            this.labelX3.Text = "تاريخ البيع";
            // 
            // lblTotalSales
            // 
            // 
            // 
            // 
            this.lblTotalSales.BackgroundStyle.Class = "";
            this.lblTotalSales.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTotalSales.Location = new System.Drawing.Point(97, 15);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotalSales.Size = new System.Drawing.Size(163, 23);
            this.lblTotalSales.TabIndex = 33;
            this.lblTotalSales.Text = "إجمالي المبيعات: 0";
            // 
            // FrmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 443);
            this.Controls.Add(this.lblTotalSales);
            this.Controls.Add(this.dtSaleDate);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvSales);
            this.DoubleBuffered = true;
            this.Name = "FrmSales";
            this.Text = "المبيعات";
            this.Load += new System.EventHandler(this.FrmSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSaleDate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvSales;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtSaleDate;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX lblTotalSales;
    }
}