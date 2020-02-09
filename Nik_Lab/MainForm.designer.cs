using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace NikiforovLab
{
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
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.item1ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.subItem1ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.subItem2ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.disabledItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.item2ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.item3ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.materialContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Location = new System.Drawing.Point(399, 385);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(76, 36);
            this.materialFlatButton2.TabIndex = 13;
            this.materialFlatButton2.Text = "Compute";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(523, 385);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = true;
            this.materialFlatButton1.Size = new System.Drawing.Size(39, 36);
            this.materialFlatButton1.TabIndex = 1;
            this.materialFlatButton1.Text = "Add";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(0, 378);
            this.materialDivider1.Margin = new System.Windows.Forms.Padding(0);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(625, 1);
            this.materialDivider1.TabIndex = 16;
            this.materialDivider1.Text = "materialDivider1";
            this.materialDivider1.Click += new System.EventHandler(this.materialDivider1_Click);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 64);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(625, 48);
            this.materialTabSelector1.TabIndex = 17;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(14, 118);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(591, 256);
            this.materialTabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.materialRaisedButton1);
            this.tabPage1.Controls.Add(this.materialButton1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(583, 230);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(423, 174);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(143, 46);
            this.materialRaisedButton1.TabIndex = 21;
            this.materialRaisedButton1.Text = "Change color scheme";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Depth = 0;
            this.materialButton1.Location = new System.Drawing.Point(276, 174);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Primary = true;
            this.materialButton1.Size = new System.Drawing.Size(108, 46);
            this.materialButton1.TabIndex = 0;
            this.materialButton1.Text = "Change Theme";
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(583, 230);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.White;
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.materialContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item1ToolStripMenuItem,
            this.disabledItemToolStripMenuItem,
            this.item2ToolStripMenuItem,
            this.toolStripSeparator1,
            this.item3ToolStripMenuItem});
            this.materialContextMenuStrip1.Margin = new System.Windows.Forms.Padding(16, 8, 16, 8);
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(166, 130);
            // 
            // item1ToolStripMenuItem
            // 
            this.item1ToolStripMenuItem.AutoSize = false;
            this.item1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subItem1ToolStripMenuItem,
            this.subItem2ToolStripMenuItem});
            this.item1ToolStripMenuItem.Name = "item1ToolStripMenuItem";
            this.item1ToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.item1ToolStripMenuItem.Text = "Item 1";
            // 
            // subItem1ToolStripMenuItem
            // 
            this.subItem1ToolStripMenuItem.AutoSize = false;
            this.subItem1ToolStripMenuItem.Name = "subItem1ToolStripMenuItem";
            this.subItem1ToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.subItem1ToolStripMenuItem.Text = "SubItem 1";
            // 
            // subItem2ToolStripMenuItem
            // 
            this.subItem2ToolStripMenuItem.AutoSize = false;
            this.subItem2ToolStripMenuItem.Name = "subItem2ToolStripMenuItem";
            this.subItem2ToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.subItem2ToolStripMenuItem.Text = "SubItem 2";
            // 
            // disabledItemToolStripMenuItem
            // 
            this.disabledItemToolStripMenuItem.AutoSize = false;
            this.disabledItemToolStripMenuItem.Enabled = false;
            this.disabledItemToolStripMenuItem.Name = "disabledItemToolStripMenuItem";
            this.disabledItemToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.disabledItemToolStripMenuItem.Text = "Disabled item";
            // 
            // item2ToolStripMenuItem
            // 
            this.item2ToolStripMenuItem.AutoSize = false;
            this.item2ToolStripMenuItem.Name = "item2ToolStripMenuItem";
            this.item2ToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.item2ToolStripMenuItem.Text = "Item 2";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // item3ToolStripMenuItem
            // 
            this.item3ToolStripMenuItem.AutoSize = false;
            this.item3ToolStripMenuItem.Name = "item3ToolStripMenuItem";
            this.item3ToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.item3ToolStripMenuItem.Text = "Item 3";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(617, 429);
            this.ContextMenuStrip = this.materialContextMenuStrip1;
            this.Controls.Add(this.materialFlatButton2);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.materialFlatButton1);
            this.Name = "MainForm";
            this.Text = "Work Shop";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.materialContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialFlatButton materialFlatButton2;
        private MaterialDivider materialDivider1;
        private MaterialTabSelector materialTabSelector1;
        private MaterialTabControl materialTabControl1;
        private MaterialContextMenuStrip materialContextMenuStrip1;
        private MaterialSkin.Controls.MaterialToolStripMenuItem item1ToolStripMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem subItem1ToolStripMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem subItem2ToolStripMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem item2ToolStripMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem item3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem disabledItemToolStripMenuItem;
        private TabPage tabPage1;
        private MaterialRaisedButton materialRaisedButton1;
        private MaterialRaisedButton materialButton1;
        private TabPage tabPage2;
    }
}