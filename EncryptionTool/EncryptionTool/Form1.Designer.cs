namespace EncryptionTool;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.tabEncryption = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.encryptionMode = new System.Windows.Forms.ComboBox();
            this.cleanBTN = new System.Windows.Forms.Button();
            this.encryptionBTN = new System.Windows.Forms.Button();
            this.textBoxMD5Souce = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxMD5Target = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabEncryption.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabEncryption
            // 
            this.tabEncryption.Controls.Add(this.tabPage1);
            this.tabEncryption.Controls.Add(this.tabPage2);
            this.tabEncryption.Location = new System.Drawing.Point(12, 12);
            this.tabEncryption.Name = "tabEncryption";
            this.tabEncryption.SelectedIndex = 0;
            this.tabEncryption.Size = new System.Drawing.Size(1168, 524);
            this.tabEncryption.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.encryptionMode);
            this.tabPage1.Controls.Add(this.cleanBTN);
            this.tabPage1.Controls.Add(this.encryptionBTN);
            this.tabPage1.Controls.Add(this.textBoxMD5Target);
            this.tabPage1.Controls.Add(this.textBoxMD5Souce);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1160, 488);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // encryptionMode
            // 
            this.encryptionMode.FormattingEnabled = true;
            this.encryptionMode.Items.AddRange(new object[] {
            "32位(大)",
            "32位(小)",
            "16位(大)",
            "16位(小)"});
            this.encryptionMode.Location = new System.Drawing.Point(427, 255);
            this.encryptionMode.Name = "encryptionMode";
            this.encryptionMode.Size = new System.Drawing.Size(182, 31);
            this.encryptionMode.TabIndex = 3;
            // 
            // cleanBTN
            // 
            this.cleanBTN.Location = new System.Drawing.Point(526, 303);
            this.cleanBTN.Name = "cleanBTN";
            this.cleanBTN.Size = new System.Drawing.Size(112, 34);
            this.cleanBTN.TabIndex = 1;
            this.cleanBTN.Text = "清空";
            this.cleanBTN.UseVisualStyleBackColor = true;
            // 
            // encryptionBTN
            // 
            this.encryptionBTN.Location = new System.Drawing.Point(396, 303);
            this.encryptionBTN.Name = "encryptionBTN";
            this.encryptionBTN.Size = new System.Drawing.Size(112, 34);
            this.encryptionBTN.TabIndex = 1;
            this.encryptionBTN.Text = "加密";
            this.encryptionBTN.UseVisualStyleBackColor = true;
            this.encryptionBTN.Click += new System.EventHandler(this.EncryptionBTN_Click);
            // 
            // textBoxMD5Souce
            // 
            this.textBoxMD5Souce.Location = new System.Drawing.Point(33, 98);
            this.textBoxMD5Souce.Multiline = true;
            this.textBoxMD5Souce.Name = "textBoxMD5Souce";
            this.textBoxMD5Souce.Size = new System.Drawing.Size(344, 292);
            this.textBoxMD5Souce.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(917, 488);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxMD5Target
            // 
            this.textBoxMD5Target.Location = new System.Drawing.Point(679, 98);
            this.textBoxMD5Target.Multiline = true;
            this.textBoxMD5Target.Name = "textBoxMD5Target";
            this.textBoxMD5Target.Size = new System.Drawing.Size(344, 292);
            this.textBoxMD5Target.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "未加密";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(679, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "加密";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 562);
            this.Controls.Add(this.tabEncryption);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabEncryption.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private TabControl tabEncryption;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private TextBox textBoxMD5Souce;
    private ComboBox encryptionMode;
    private Button cleanBTN;
    private Button encryptionBTN;
    private Label label2;
    private Label label1;
    private TextBox textBoxMD5Target;
}