namespace WinFormsApp1.Formlar
{
    partial class Firma
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
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            SuspendLayout();
            // 
            // groupControl1
            // 
            groupControl1.Appearance.BackColor = Color.FromArgb(192, 255, 255);
            groupControl1.Appearance.Options.UseBackColor = true;
            groupControl1.Controls.Add(button1);
            groupControl1.Controls.Add(textBox2);
            groupControl1.Controls.Add(textBox1);
            groupControl1.Controls.Add(labelControl2);
            groupControl1.Controls.Add(labelControl1);
            groupControl1.Location = new Point(12, 1);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(260, 291);
            groupControl1.TabIndex = 1;
            groupControl1.Text = "Firma Ekle";
            // 
            // button1
            // 
            button1.Location = new Point(157, 139);
            button1.Name = "button1";
            button1.Size = new Size(69, 33);
            button1.TabIndex = 4;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(118, 84);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(109, 21);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(118, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(109, 21);
            textBox1.TabIndex = 2;
            // 
            // labelControl2
            // 
            labelControl2.Location = new Point(25, 87);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(48, 13);
            labelControl2.TabIndex = 1;
            labelControl2.Text = "Firma Adı:";
            // 
            // labelControl1
            // 
            labelControl1.Location = new Point(25, 53);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(43, 13);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Firma Id:";
            // 
            // Firma
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 304);
            Controls.Add(groupControl1);
            Name = "Firma";
            Text = "XtraForm5";
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}