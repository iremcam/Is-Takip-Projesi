namespace WinFormsApp1.Formlar
{
    partial class XtraForm8
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
            groupBox1 = new GroupBox();
            dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            richTextBox1 = new RichTextBox();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            label1 = new Label();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comboBoxEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(192, 192, 255);
            groupBox1.Controls.Add(labelControl2);
            groupBox1.Controls.Add(dateEdit1);
            groupBox1.Controls.Add(comboBoxEdit1);
            groupBox1.Controls.Add(simpleButton1);
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(labelControl1);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.Navy;
            groupBox1.Location = new Point(0, -14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(442, 465);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // dateEdit1
            // 
            dateEdit1.EditValue = null;
            dateEdit1.Location = new Point(151, 265);
            dateEdit1.Name = "dateEdit1";
            dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEdit1.Size = new Size(250, 20);
            dateEdit1.TabIndex = 8;
            // 
            // comboBoxEdit1
            // 
            comboBoxEdit1.Location = new Point(151, 40);
            comboBoxEdit1.Name = "comboBoxEdit1";
            comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboBoxEdit1.Size = new Size(250, 20);
            comboBoxEdit1.TabIndex = 7;
            // 
            // simpleButton1
            // 
            simpleButton1.Appearance.ForeColor = Color.FromArgb(128, 128, 255);
            simpleButton1.Appearance.Options.UseForeColor = true;
            simpleButton1.Location = new Point(161, 311);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new Size(104, 29);
            simpleButton1.TabIndex = 6;
            simpleButton1.Text = "Kaydet";
            simpleButton1.Click += simpleButton1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(151, 95);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(250, 135);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // labelControl1
            // 
            labelControl1.Location = new Point(38, 94);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(78, 13);
            labelControl1.TabIndex = 4;
            labelControl1.Text = "Görv Açıklaması:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 47);
            label1.Name = "label1";
            label1.Size = new Size(61, 13);
            label1.TabIndex = 3;
            label1.Text = "Görev Alıcı:";
            // 
            // gridControl1
            // 
            gridControl1.Location = new Point(448, -1);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(694, 436);
            gridControl1.TabIndex = 1;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            // 
            // labelControl2
            // 
            labelControl2.Location = new Point(55, 319);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(80, 13);
            labelControl2.TabIndex = 9;
            labelControl2.Text = "Görev Bitiş Tarihi";
            // 
            // XtraForm8
            // 
            Appearance.BackColor = Color.White;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 447);
            Controls.Add(gridControl1);
            Controls.Add(groupBox1);
            Name = "XtraForm8";
            Text = "Görev Ata";
            Load += XtraForm8_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)comboBoxEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private RichTextBox richTextBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}