namespace WinFormsApp1.Formlar
{
    partial class XtraForm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraForm2));
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            Id = new DevExpress.XtraGrid.Columns.GridColumn();
            FirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            LastName = new DevExpress.XtraGrid.Columns.GridColumn();
            Mail = new DevExpress.XtraGrid.Columns.GridColumn();
            Phone = new DevExpress.XtraGrid.Columns.GridColumn();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            comboBoxEdit2 = new DevExpress.XtraEditors.ComboBoxEdit();
            comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)comboBoxEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comboBoxEdit1.Properties).BeginInit();
            SuspendLayout();
            // 
            // gridControl1
            // 
            gridControl1.Location = new Point(233, 1);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(938, 425);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            gridControl1.Click += gridControl1_Click;
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { Id, FirstName, LastName, Mail, Phone });
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            // 
            // Id
            // 
            Id.Caption = "Id";
            Id.Name = "Id";
            Id.Visible = true;
            Id.VisibleIndex = 0;
            // 
            // FirstName
            // 
            FirstName.Caption = "Personel Adı";
            FirstName.Name = "FirstName";
            FirstName.Visible = true;
            FirstName.VisibleIndex = 1;
            // 
            // LastName
            // 
            LastName.Caption = "Personel SoyAdı";
            LastName.Name = "LastName";
            LastName.Visible = true;
            LastName.VisibleIndex = 2;
            // 
            // Mail
            // 
            Mail.Caption = "Email";
            Mail.Name = "Mail";
            Mail.Visible = true;
            Mail.VisibleIndex = 3;
            // 
            // Phone
            // 
            Phone.Caption = "Telefon";
            Phone.Name = "Phone";
            Phone.Visible = true;
            Phone.VisibleIndex = 4;
            // 
            // simpleButton1
            // 
            simpleButton1.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("simpleButton1.ImageOptions.SvgImage");
            simpleButton1.Location = new Point(18, 353);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new Size(143, 35);
            simpleButton1.TabIndex = 1;
            simpleButton1.Text = "Listele";
            simpleButton1.Click += simpleButton1_Click;
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(comboBoxEdit2);
            groupControl1.Controls.Add(comboBoxEdit1);
            groupControl1.Controls.Add(textBox4);
            groupControl1.Controls.Add(textBox3);
            groupControl1.Controls.Add(textBox2);
            groupControl1.Controls.Add(textBox1);
            groupControl1.Controls.Add(simpleButton2);
            groupControl1.Controls.Add(simpleButton1);
            groupControl1.Location = new Point(22, 2);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(205, 424);
            groupControl1.TabIndex = 2;
            groupControl1.Text = "groupControl1";
            // 
            // comboBoxEdit2
            // 
            comboBoxEdit2.Location = new Point(18, 225);
            comboBoxEdit2.Name = "comboBoxEdit2";
            comboBoxEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboBoxEdit2.Properties.DropDownRows = 20;
            comboBoxEdit2.Size = new Size(143, 20);
            comboBoxEdit2.TabIndex = 9;
            // 
            // comboBoxEdit1
            // 
            comboBoxEdit1.Location = new Point(18, 188);
            comboBoxEdit1.Name = "comboBoxEdit1";
            comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboBoxEdit1.Properties.DropDownRows = 20;
            comboBoxEdit1.Size = new Size(143, 20);
            comboBoxEdit1.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(18, 149);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Telefon";
            textBox4.Size = new Size(144, 21);
            textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(18, 111);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Email";
            textBox3.Size = new Size(144, 21);
            textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(18, 73);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Personel Soyadı";
            textBox2.Size = new Size(144, 21);
            textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(18, 37);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Personel Adı";
            textBox1.Size = new Size(144, 21);
            textBox1.TabIndex = 4;
            // 
            // simpleButton2
            // 
            simpleButton2.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("simpleButton2.ImageOptions.SvgImage");
            simpleButton2.Location = new Point(18, 298);
            simpleButton2.Name = "simpleButton2";
            simpleButton2.Size = new Size(143, 36);
            simpleButton2.TabIndex = 2;
            simpleButton2.Text = "Ekle";
            simpleButton2.Click += simpleButton2_Click;
            // 
            // XtraForm2
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1195, 438);
            Controls.Add(groupControl1);
            Controls.Add(gridControl1);
            Name = "XtraForm2";
            Text = "Personel Listesi";
            Load += XtraForm2_Load;
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)comboBoxEdit2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)comboBoxEdit1.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn FirstName;
        private DevExpress.XtraGrid.Columns.GridColumn LastName;
        private DevExpress.XtraGrid.Columns.GridColumn Mail;
        private DevExpress.XtraGrid.Columns.GridColumn Phone;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit2;
    }
}