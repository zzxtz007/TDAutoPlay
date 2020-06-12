namespace PythonAutoPlay
{
    partial class Form1
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.label1 = new System.Windows.Forms.Label();
            this.handleList = new System.Windows.Forms.ListView();
            this.searchTxt = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.mainText = new DevExpress.XtraEditors.MemoEdit();
            this.handleLock = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.handleListaa = new DevExpress.XtraLayout.LayoutControlItem();
            this.sou = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.playSpeed = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.handleLock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.handleListaa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sou)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playSpeed.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.label1);
            this.layoutControl1.Controls.Add(this.handleList);
            this.layoutControl1.Controls.Add(this.searchTxt);
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Controls.Add(this.mainText);
            this.layoutControl1.Controls.Add(this.handleLock);
            this.layoutControl1.Controls.Add(this.simpleButton2);
            this.layoutControl1.Controls.Add(this.simpleButton3);
            this.layoutControl1.Controls.Add(this.playSpeed);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(890, 598);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Sitka Display", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(12, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(521, 55);
            this.label1.TabIndex = 8;
            this.label1.Text = "录入谱子";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // handleList
            // 
            this.handleList.HideSelection = false;
            this.handleList.Location = new System.Drawing.Point(12, 12);
            this.handleList.Name = "handleList";
            this.handleList.Size = new System.Drawing.Size(401, 134);
            this.handleList.TabIndex = 4;
            this.handleList.UseCompatibleStateImageBehavior = false;
            this.handleList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.handleList_ItemCheck);
            this.handleList.DoubleClick += new System.EventHandler(this.handleList_DoubleClick);
            // 
            // searchTxt
            // 
            this.searchTxt.Location = new System.Drawing.Point(497, 12);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(225, 20);
            this.searchTxt.StyleController = this.layoutControl1;
            this.searchTxt.TabIndex = 5;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(726, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(152, 22);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "搜索";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // mainText
            // 
            this.mainText.Location = new System.Drawing.Point(12, 209);
            this.mainText.Name = "mainText";
            this.mainText.Size = new System.Drawing.Size(866, 293);
            this.mainText.StyleController = this.layoutControl1;
            this.mainText.TabIndex = 7;
            // 
            // handleLock
            // 
            this.handleLock.Enabled = false;
            this.handleLock.Location = new System.Drawing.Point(497, 38);
            this.handleLock.Name = "handleLock";
            this.handleLock.Size = new System.Drawing.Size(136, 20);
            this.handleLock.StyleController = this.layoutControl1;
            this.handleLock.TabIndex = 9;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(726, 38);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(152, 22);
            this.simpleButton2.StyleController = this.layoutControl1;
            this.simpleButton2.TabIndex = 10;
            this.simpleButton2.Text = "锁定";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.handleListaa,
            this.sou,
            this.emptySpaceItem2,
            this.emptySpaceItem4,
            this.layoutControlItem2,
            this.emptySpaceItem5,
            this.emptySpaceItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem1,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.emptySpaceItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(890, 598);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // handleListaa
            // 
            this.handleListaa.Control = this.handleList;
            this.handleListaa.Location = new System.Drawing.Point(0, 0);
            this.handleListaa.Name = "handleListaa";
            this.handleListaa.Size = new System.Drawing.Size(405, 138);
            this.handleListaa.TextSize = new System.Drawing.Size(0, 0);
            this.handleListaa.TextVisible = false;
            // 
            // sou
            // 
            this.sou.Control = this.searchTxt;
            this.sou.Location = new System.Drawing.Point(405, 0);
            this.sou.Name = "sou";
            this.sou.Size = new System.Drawing.Size(309, 26);
            this.sou.Text = "搜索条件";
            this.sou.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.sou.TextSize = new System.Drawing.Size(75, 20);
            this.sou.TextToControlDistance = 5;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(405, 52);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(465, 86);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(625, 26);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(89, 26);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.mainText;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 197);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(870, 297);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(158, 494);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(712, 24);
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(525, 138);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(345, 59);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.label1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 138);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(525, 59);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.handleLock;
            this.layoutControlItem4.Location = new System.Drawing.Point(405, 26);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(220, 26);
            this.layoutControlItem4.Text = "锁定进程";
            this.layoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(75, 20);
            this.layoutControlItem4.TextToControlDistance = 5;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.simpleButton1;
            this.layoutControlItem1.Location = new System.Drawing.Point(714, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(156, 26);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.simpleButton2;
            this.layoutControlItem5.Location = new System.Drawing.Point(714, 26);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(156, 26);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(156, 26);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(156, 26);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(120, 564);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(758, 22);
            this.simpleButton3.StyleController = this.layoutControl1;
            this.simpleButton3.TabIndex = 11;
            this.simpleButton3.Text = "simpleButton3";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.simpleButton3;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 552);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(870, 26);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(105, 14);
            // 
            // playSpeed
            // 
            this.playSpeed.EditValue = "4";
            this.playSpeed.Location = new System.Drawing.Point(67, 506);
            this.playSpeed.Name = "playSpeed";
            this.playSpeed.Size = new System.Drawing.Size(99, 20);
            this.playSpeed.StyleController = this.layoutControl1;
            this.playSpeed.TabIndex = 12;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.playSpeed;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 494);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(158, 24);
            this.layoutControlItem7.Text = "播放速度";
            this.layoutControlItem7.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(50, 20);
            this.layoutControlItem7.TextToControlDistance = 5;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 518);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(870, 34);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 598);
            this.Controls.Add(this.layoutControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.handleLock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.handleListaa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sou)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playSpeed.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.ListView handleList;
        private DevExpress.XtraLayout.LayoutControlItem handleListaa;
        private DevExpress.XtraEditors.TextEdit searchTxt;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.LayoutControlItem sou;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.MemoEdit mainText;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.TextEdit handleLock;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.TextEdit playSpeed;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
    }
}

