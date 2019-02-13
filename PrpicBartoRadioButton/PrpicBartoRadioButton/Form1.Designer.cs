namespace PrpicBartoRadioButton
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gBox = new System.Windows.Forms.GroupBox();
            this.rbtnSluzb = new System.Windows.Forms.RadioButton();
            this.rbtnAvion = new System.Windows.Forms.RadioButton();
            this.rbtnAuto = new System.Windows.Forms.RadioButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.oProgramu = new System.Windows.Forms.ToolStripButton();
            this.btnIzbor = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gBox.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBox
            // 
            this.gBox.Controls.Add(this.rbtnSluzb);
            this.gBox.Controls.Add(this.rbtnAvion);
            this.gBox.Controls.Add(this.rbtnAuto);
            this.gBox.Location = new System.Drawing.Point(58, 51);
            this.gBox.Name = "gBox";
            this.gBox.Size = new System.Drawing.Size(200, 93);
            this.gBox.TabIndex = 0;
            this.gBox.TabStop = false;
            this.gBox.Text = "ODABIR PRIJEVOZA";
            // 
            // rbtnSluzb
            // 
            this.rbtnSluzb.AutoSize = true;
            this.rbtnSluzb.Location = new System.Drawing.Point(7, 68);
            this.rbtnSluzb.Name = "rbtnSluzb";
            this.rbtnSluzb.Size = new System.Drawing.Size(94, 17);
            this.rbtnSluzb.TabIndex = 2;
            this.rbtnSluzb.TabStop = true;
            this.rbtnSluzb.Text = "Vlastiti prijevoz";
            this.rbtnSluzb.UseVisualStyleBackColor = true;
            // 
            // rbtnAvion
            // 
            this.rbtnAvion.AutoSize = true;
            this.rbtnAvion.Location = new System.Drawing.Point(7, 45);
            this.rbtnAvion.Name = "rbtnAvion";
            this.rbtnAvion.Size = new System.Drawing.Size(52, 17);
            this.rbtnAvion.TabIndex = 1;
            this.rbtnAvion.TabStop = true;
            this.rbtnAvion.Text = "Avion";
            this.rbtnAvion.UseVisualStyleBackColor = true;
            // 
            // rbtnAuto
            // 
            this.rbtnAuto.AutoSize = true;
            this.rbtnAuto.Location = new System.Drawing.Point(7, 20);
            this.rbtnAuto.Name = "rbtnAuto";
            this.rbtnAuto.Size = new System.Drawing.Size(64, 17);
            this.rbtnAuto.TabIndex = 0;
            this.rbtnAuto.TabStop = true;
            this.rbtnAuto.Text = "Autobus";
            this.rbtnAuto.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramu});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(607, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // oProgramu
            // 
            this.oProgramu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.oProgramu.Image = ((System.Drawing.Image)(resources.GetObject("oProgramu.Image")));
            this.oProgramu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.oProgramu.Name = "oProgramu";
            this.oProgramu.Size = new System.Drawing.Size(76, 22);
            this.oProgramu.Text = "O Programu";
            this.oProgramu.Click += new System.EventHandler(this.oProgramu_Click);
            // 
            // btnIzbor
            // 
            this.btnIzbor.Location = new System.Drawing.Point(58, 194);
            this.btnIzbor.Name = "btnIzbor";
            this.btnIzbor.Size = new System.Drawing.Size(200, 23);
            this.btnIzbor.TabIndex = 2;
            this.btnIzbor.Text = "Rezerviraj";
            this.btnIzbor.UseVisualStyleBackColor = true;
            this.btnIzbor.Click += new System.EventHandler(this.btnIzbor_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(341, 58);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(247, 158);
            this.textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 233);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnIzbor);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gBox.ResumeLayout(false);
            this.gBox.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBox;
        private System.Windows.Forms.RadioButton rbtnSluzb;
        private System.Windows.Forms.RadioButton rbtnAvion;
        private System.Windows.Forms.RadioButton rbtnAuto;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton oProgramu;
        private System.Windows.Forms.Button btnIzbor;
        private System.Windows.Forms.TextBox textBox1;
    }
}

