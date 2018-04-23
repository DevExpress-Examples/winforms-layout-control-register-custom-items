namespace DXExample {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.myLayoutControl1 = new DXExample.MyLayoutControl();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.myLayoutControlGroup1 = new DXExample.MyLayoutControlGroup();
            this.myLayoutControlGroup3 = new DXExample.MyLayoutControlGroup();
            this.myLayoutControlItem1 = new DXExample.MyLayoutControlItem();
            this.myLayoutControlGroup2 = new DXExample.MyLayoutControlGroup();
            this.myLayoutControlItem2 = new DXExample.MyLayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.myLayoutControl1)).BeginInit();
            this.myLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myLayoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myLayoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myLayoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myLayoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myLayoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // myLayoutControl1
            // 
            this.myLayoutControl1.Controls.Add(this.textEdit2);
            this.myLayoutControl1.Controls.Add(this.textEdit1);
            this.myLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.myLayoutControl1.Name = "myLayoutControl1";
            this.myLayoutControl1.Root = this.layoutControlGroup1;
            this.myLayoutControl1.Size = new System.Drawing.Size(488, 306);
            this.myLayoutControl1.TabIndex = 0;
            this.myLayoutControl1.Text = "myLayoutControl1";
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(317, 76);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(135, 20);
            this.textEdit2.StyleController = this.myLayoutControl1;
            this.textEdit2.TabIndex = 5;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(96, 76);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(133, 20);
            this.textEdit1.StyleController = this.myLayoutControl1;
            this.textEdit1.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.myLayoutControlGroup1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(488, 306);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // myLayoutControlGroup1
            // 
            this.myLayoutControlGroup1.CustomizationFormText = "MyLayoutControlGroup";
            this.myLayoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.myLayoutControlGroup3,
            this.myLayoutControlGroup2});
            this.myLayoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.myLayoutControlGroup1.Name = "myLayoutControlGroup1";
            this.myLayoutControlGroup1.Size = new System.Drawing.Size(468, 286);
            this.myLayoutControlGroup1.Text = "3:03:39 AM";
            // 
            // myLayoutControlGroup3
            // 
            this.myLayoutControlGroup3.CustomizationFormText = "2:04 AM";
            this.myLayoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.myLayoutControlItem1});
            this.myLayoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.myLayoutControlGroup3.Name = "myLayoutControlGroup3";
            this.myLayoutControlGroup3.Size = new System.Drawing.Size(221, 242);
            this.myLayoutControlGroup3.Text = "3:03:39 AM";
            // 
            // myLayoutControlItem1
            // 
            this.myLayoutControlItem1.Control = this.textEdit1;
            this.myLayoutControlItem1.CustomizationFormText = "3:02:21 AM";
            this.myLayoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.myLayoutControlItem1.Name = "myLayoutControlItem1";
            this.myLayoutControlItem1.Size = new System.Drawing.Size(197, 198);
            this.myLayoutControlItem1.Text = "3:03:39 AM";
            this.myLayoutControlItem1.TextSize = new System.Drawing.Size(56, 13);
            // 
            // myLayoutControlGroup2
            // 
            this.myLayoutControlGroup2.CustomizationFormText = "2:04 AM";
            this.myLayoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.myLayoutControlItem2});
            this.myLayoutControlGroup2.Location = new System.Drawing.Point(221, 0);
            this.myLayoutControlGroup2.Name = "myLayoutControlGroup2";
            this.myLayoutControlGroup2.Size = new System.Drawing.Size(223, 242);
            this.myLayoutControlGroup2.Text = "3:03:39 AM";
            // 
            // myLayoutControlItem2
            // 
            this.myLayoutControlItem2.Control = this.textEdit2;
            this.myLayoutControlItem2.CustomizationFormText = "3:02:21 AM";
            this.myLayoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.myLayoutControlItem2.Name = "myLayoutControlItem2";
            this.myLayoutControlItem2.Size = new System.Drawing.Size(199, 198);
            this.myLayoutControlItem2.Text = "3:03:39 AM";
            this.myLayoutControlItem2.TextSize = new System.Drawing.Size(56, 13);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 306);
            this.Controls.Add(this.myLayoutControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.myLayoutControl1)).EndInit();
            this.myLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myLayoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myLayoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myLayoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myLayoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myLayoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyLayoutControl myLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private MyLayoutControlGroup myLayoutControlGroup1;
        private MyLayoutControlGroup myLayoutControlGroup3;
        private MyLayoutControlGroup myLayoutControlGroup2;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private MyLayoutControlItem myLayoutControlItem1;
        private MyLayoutControlItem myLayoutControlItem2;


    }
}

