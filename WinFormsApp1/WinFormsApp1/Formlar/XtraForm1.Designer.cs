namespace WinFormsApp1.Formlar
{
    partial class XtraForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraForm1));
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            SuspendLayout();
            // 
            // gridControl1
            // 
            gridControl1.EmbeddedNavigator.Margin = new Padding(4, 3, 4, 3);
            gridControl1.Location = new Point(14, 7);
            gridControl1.MainView = gridView1;
            gridControl1.Margin = new Padding(4, 3, 4, 3);
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(507, 408);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            gridControl1.Click += gridControl1_Click;
            // 
            // gridView1
            // 
            gridView1.DetailHeight = 404;
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsEditForm.PopupEditFormWidth = 933;
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(textBox2);
            groupControl1.Controls.Add(textBox1);
            groupControl1.Controls.Add(labelControl2);
            groupControl1.Controls.Add(labelControl1);
            groupControl1.Controls.Add(simpleButton4);
            groupControl1.Controls.Add(simpleButton3);
            groupControl1.Controls.Add(simpleButton2);
            groupControl1.Controls.Add(simpleButton1);
            groupControl1.Location = new Point(529, 7);
            groupControl1.Margin = new Padding(4, 3, 4, 3);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(385, 408);
            groupControl1.TabIndex = 1;
            groupControl1.Text = "groupControl1";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(167, 78);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(164, 21);
            textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(167, 42);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 21);
            textBox1.TabIndex = 6;
            // 
            // labelControl2
            // 
            labelControl2.Location = new Point(38, 82);
            labelControl2.Margin = new Padding(4, 3, 4, 3);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(75, 13);
            labelControl2.TabIndex = 5;
            labelControl2.Text = "Departman Adı:";
            // 
            // labelControl1
            // 
            labelControl1.Location = new Point(38, 45);
            labelControl1.Margin = new Padding(4, 3, 4, 3);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(71, 13);
            labelControl1.TabIndex = 4;
            labelControl1.Text = "Departman ID:";
            // 
            // simpleButton4
            // 
            simpleButton4.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("simpleButton4.ImageOptions.SvgImage");
            simpleButton4.Location = new Point(166, 310);
            simpleButton4.Margin = new Padding(4, 3, 4, 3);
            simpleButton4.Name = "simpleButton4";
            simpleButton4.Size = new Size(166, 51);
            simpleButton4.TabIndex = 3;
            simpleButton4.Text = "Güncelle";
            simpleButton4.Click += simpleButton4_Click;
            // 
            // simpleButton3
            // 
            simpleButton3.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("simpleButton3.ImageOptions.SvgImage");
            simpleButton3.Location = new Point(166, 253);
            simpleButton3.Margin = new Padding(4, 3, 4, 3);
            simpleButton3.Name = "simpleButton3";
            simpleButton3.Size = new Size(166, 51);
            simpleButton3.TabIndex = 2;
            simpleButton3.Text = "Sil";
            simpleButton3.Click += simpleButton3_Click;
            // 
            // simpleButton2
            // 
            simpleButton2.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("simpleButton2.ImageOptions.SvgImage");
            simpleButton2.Location = new Point(166, 195);
            simpleButton2.Margin = new Padding(4, 3, 4, 3);
            simpleButton2.Name = "simpleButton2";
            simpleButton2.Size = new Size(166, 51);
            simpleButton2.TabIndex = 1;
            simpleButton2.Text = "Ekle";
            simpleButton2.Click += simpleButton2_Click;
            // 
            // simpleButton1
            // 
            simpleButton1.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("simpleButton1.ImageOptions.SvgImage");
            simpleButton1.Location = new Point(166, 134);
            simpleButton1.Margin = new Padding(4, 3, 4, 3);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new Size(166, 54);
            simpleButton1.TabIndex = 0;
            simpleButton1.Text = "Listele";
            simpleButton1.Click += simpleButton1_Click;
            // 
            // XtraForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 419);
            Controls.Add(groupControl1);
            Controls.Add(gridControl1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "XtraForm1";
            Text = "Departmanlar";
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private TextBox textBox2;
        private TextBox textBox1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}