namespace WorkShop_Nikiforov
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.htmlToolTip1 = new MetroFramework.Drawing.Html.HtmlToolTip();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroContextMenu2 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.fdgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TabOrder = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.TileClearOrders = new MetroFramework.Controls.MetroTile();
            this.TileCompute = new MetroFramework.Controls.MetroTile();
            this.TextBoxQuantity = new MetroFramework.Controls.MetroTextBox();
            this.TileAddOrder = new MetroFramework.Controls.MetroTile();
            this.TrackBarQuantity = new MetroFramework.Controls.MetroTrackBar();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.LabelChooseCake = new MetroFramework.Controls.MetroLabel();
            this.ComboBoxCakes = new MetroFramework.Controls.MetroComboBox();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.msmMain = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.bakeryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.metroContextMenu2.SuspendLayout();
            this.TabOrder.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakeryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(61, 4);
            // 
            // htmlToolTip1
            // 
            this.htmlToolTip1.OwnerDraw = true;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // metroContextMenu2
            // 
            this.metroContextMenu2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fdgToolStripMenuItem});
            this.metroContextMenu2.Name = "metroContextMenu2";
            this.metroContextMenu2.Size = new System.Drawing.Size(93, 26);
            this.metroContextMenu2.Opening += new System.ComponentModel.CancelEventHandler(this.MetroContextMenu2_Opening);
            // 
            // fdgToolStripMenuItem
            // 
            this.fdgToolStripMenuItem.Name = "fdgToolStripMenuItem";
            this.fdgToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.fdgToolStripMenuItem.Text = "fdg";
            // 
            // TabOrder
            // 
            this.TabOrder.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.TabOrder.Controls.Add(this.metroTabPage1);
            this.TabOrder.Location = new System.Drawing.Point(0, 63);
            this.TabOrder.Multiline = true;
            this.TabOrder.Name = "TabOrder";
            this.TabOrder.SelectedIndex = 0;
            this.TabOrder.Size = new System.Drawing.Size(845, 474);
            this.TabOrder.TabIndex = 7;
            this.TabOrder.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.TileClearOrders);
            this.metroTabPage1.Controls.Add(this.TileCompute);
            this.metroTabPage1.Controls.Add(this.TextBoxQuantity);
            this.metroTabPage1.Controls.Add(this.TileAddOrder);
            this.metroTabPage1.Controls.Add(this.TrackBarQuantity);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.LabelChooseCake);
            this.metroTabPage1.Controls.Add(this.ComboBoxCakes);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 41);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(837, 429);
            this.metroTabPage1.Style = MetroFramework.MetroColorStyle.White;
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Order";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            this.metroTabPage1.Click += new System.EventHandler(this.metroTabPage1_Click);
            // 
            // TileClearOrders
            // 
            this.TileClearOrders.ActiveControl = null;
            this.TileClearOrders.Location = new System.Drawing.Point(45, 225);
            this.TileClearOrders.Name = "TileClearOrders";
            this.TileClearOrders.Size = new System.Drawing.Size(197, 46);
            this.TileClearOrders.TabIndex = 9;
            this.TileClearOrders.Text = "Clear orders";
            this.TileClearOrders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TileClearOrders.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TileClearOrders.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.TileClearOrders.UseSelectable = true;
            this.TileClearOrders.Click += new System.EventHandler(this.TileClearOrders_Click);
            // 
            // TileCompute
            // 
            this.TileCompute.ActiveControl = null;
            this.TileCompute.Location = new System.Drawing.Point(45, 130);
            this.TileCompute.Name = "TileCompute";
            this.TileCompute.Size = new System.Drawing.Size(197, 46);
            this.TileCompute.TabIndex = 8;
            this.TileCompute.Text = "Invoice";
            this.TileCompute.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TileCompute.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TileCompute.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.TileCompute.UseSelectable = true;
            this.TileCompute.Click += new System.EventHandler(this.TileCompute_Click);
            // 
            // TextBoxQuantity
            // 
            // 
            // 
            // 
            this.TextBoxQuantity.CustomButton.Image = null;
            this.TextBoxQuantity.CustomButton.Location = new System.Drawing.Point(5, 1);
            this.TextBoxQuantity.CustomButton.Name = "";
            this.TextBoxQuantity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBoxQuantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBoxQuantity.CustomButton.TabIndex = 1;
            this.TextBoxQuantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxQuantity.CustomButton.UseSelectable = true;
            this.TextBoxQuantity.CustomButton.Visible = false;
            this.TextBoxQuantity.Lines = new string[0];
            this.TextBoxQuantity.Location = new System.Drawing.Point(687, 199);
            this.TextBoxQuantity.MaxLength = 32767;
            this.TextBoxQuantity.Name = "TextBoxQuantity";
            this.TextBoxQuantity.PasswordChar = '\0';
            this.TextBoxQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxQuantity.SelectedText = "";
            this.TextBoxQuantity.SelectionLength = 0;
            this.TextBoxQuantity.SelectionStart = 0;
            this.TextBoxQuantity.ShortcutsEnabled = true;
            this.TextBoxQuantity.Size = new System.Drawing.Size(27, 23);
            this.TextBoxQuantity.TabIndex = 7;
            this.TextBoxQuantity.UseSelectable = true;
            this.TextBoxQuantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBoxQuantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TextBoxQuantity.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // TileAddOrder
            // 
            this.TileAddOrder.ActiveControl = null;
            this.TileAddOrder.Location = new System.Drawing.Point(45, 35);
            this.TileAddOrder.Name = "TileAddOrder";
            this.TileAddOrder.Size = new System.Drawing.Size(197, 46);
            this.TileAddOrder.TabIndex = 6;
            this.TileAddOrder.Text = "Add order";
            this.TileAddOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TileAddOrder.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TileAddOrder.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.TileAddOrder.UseSelectable = true;
            this.TileAddOrder.Click += new System.EventHandler(this.TileAddOrder_Click);
            // 
            // TrackBarQuantity
            // 
            this.TrackBarQuantity.BackColor = System.Drawing.Color.Transparent;
            this.TrackBarQuantity.LargeChange = 1;
            this.TrackBarQuantity.Location = new System.Drawing.Point(606, 199);
            this.TrackBarQuantity.Minimum = 1;
            this.TrackBarQuantity.Name = "TrackBarQuantity";
            this.TrackBarQuantity.Size = new System.Drawing.Size(75, 23);
            this.TrackBarQuantity.TabIndex = 5;
            this.TrackBarQuantity.Text = "TrackBarQuantity";
            this.TrackBarQuantity.Value = 1;
            this.TrackBarQuantity.Scroll += new System.Windows.Forms.ScrollEventHandler(this.TrackBarQuantity_Scroll_2);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(519, 199);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(81, 25);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Quantity:";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click_2);
            // 
            // LabelChooseCake
            // 
            this.LabelChooseCake.AutoSize = true;
            this.LabelChooseCake.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LabelChooseCake.Location = new System.Drawing.Point(388, 77);
            this.LabelChooseCake.Name = "LabelChooseCake";
            this.LabelChooseCake.Size = new System.Drawing.Size(78, 25);
            this.LabelChooseCake.TabIndex = 3;
            this.LabelChooseCake.Text = "Choose :";
            this.LabelChooseCake.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelChooseCake.Click += new System.EventHandler(this.metroLabel1_Click_1);
            // 
            // ComboBoxCakes
            // 
            this.ComboBoxCakes.FormattingEnabled = true;
            this.ComboBoxCakes.ItemHeight = 23;
            this.ComboBoxCakes.Location = new System.Drawing.Point(472, 77);
            this.ComboBoxCakes.Name = "ComboBoxCakes";
            this.ComboBoxCakes.Size = new System.Drawing.Size(242, 29);
            this.ComboBoxCakes.TabIndex = 2;
            this.ComboBoxCakes.UseSelectable = true;
            this.ComboBoxCakes.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged_1);
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroToolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.metroToolTip1_Popup);
            // 
            // msmMain
            // 
            this.msmMain.Owner = this;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(145, 19);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(75, 38);
            this.metroTile1.TabIndex = 8;
            this.metroTile1.Text = "Change";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // bakeryBindingSource
            // 
            this.bakeryBindingSource.DataSource = typeof(WorkShop_Nikiforov.Classes.WorkShop);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 466);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.TabOrder);
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "WorkShop";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.metroContextMenu2.ResumeLayout(false);
            this.TabOrder.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakeryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private MetroFramework.Drawing.Html.HtmlToolTip htmlToolTip1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu2;
        private System.Windows.Forms.ToolStripMenuItem fdgToolStripMenuItem;
        private MetroFramework.Controls.MetroTabControl TabOrder;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroLabel LabelChooseCake;
        private MetroFramework.Controls.MetroComboBox ComboBoxCakes;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTrackBar TrackBarQuantity;
        private MetroFramework.Controls.MetroTextBox TextBoxQuantity;
        private MetroFramework.Controls.MetroTile TileAddOrder;
        private System.Windows.Forms.BindingSource bakeryBindingSource;
        private MetroFramework.Controls.MetroTile TileCompute;
        private MetroFramework.Controls.MetroTile TileClearOrders;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MetroFramework.Components.MetroStyleManager msmMain;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}

