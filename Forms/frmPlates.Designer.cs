namespace KTANE_Diffuser_Winforms.Forms;

partial class frmPlates
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
        this.parellelCheckBox = new System.Windows.Forms.CheckBox();
        this.DviCheckBox = new System.Windows.Forms.CheckBox();
        this.serialCheckBox = new System.Windows.Forms.CheckBox();
        this.RcaCheckBox = new System.Windows.Forms.CheckBox();
        this.psCheckBox = new System.Windows.Forms.CheckBox();
        this.rjCheckBox = new System.Windows.Forms.CheckBox();
        this.submitButton = new System.Windows.Forms.Button();
        this.backButton = new System.Windows.Forms.Button();
        this.label1 = new System.Windows.Forms.Label();
        this.SuspendLayout();
        // 
        // parellelCheckBox
        // 
        this.parellelCheckBox.AutoSize = true;
        this.parellelCheckBox.Location = new System.Drawing.Point(232, 82);
        this.parellelCheckBox.Name = "parellelCheckBox";
        this.parellelCheckBox.Size = new System.Drawing.Size(77, 21);
        this.parellelCheckBox.TabIndex = 6;
        this.parellelCheckBox.Text = "Parallel";
        this.parellelCheckBox.UseVisualStyleBackColor = true;
        // 
        // DviCheckBox
        // 
        this.DviCheckBox.AutoSize = true;
        this.DviCheckBox.Location = new System.Drawing.Point(232, 164);
        this.DviCheckBox.Name = "DviCheckBox";
        this.DviCheckBox.Size = new System.Drawing.Size(52, 21);
        this.DviCheckBox.TabIndex = 7;
        this.DviCheckBox.Text = "DVI";
        this.DviCheckBox.UseVisualStyleBackColor = true;
        // 
        // serialCheckBox
        // 
        this.serialCheckBox.AutoSize = true;
        this.serialCheckBox.Location = new System.Drawing.Point(232, 121);
        this.serialCheckBox.Name = "serialCheckBox";
        this.serialCheckBox.Size = new System.Drawing.Size(66, 21);
        this.serialCheckBox.TabIndex = 8;
        this.serialCheckBox.Text = "Serial";
        this.serialCheckBox.UseVisualStyleBackColor = true;
        // 
        // RcaCheckBox
        // 
        this.RcaCheckBox.AutoSize = true;
        this.RcaCheckBox.Location = new System.Drawing.Point(232, 207);
        this.RcaCheckBox.Name = "RcaCheckBox";
        this.RcaCheckBox.Size = new System.Drawing.Size(58, 21);
        this.RcaCheckBox.TabIndex = 9;
        this.RcaCheckBox.Text = "RCA";
        this.RcaCheckBox.UseVisualStyleBackColor = true;
        // 
        // psCheckBox
        // 
        this.psCheckBox.AutoSize = true;
        this.psCheckBox.Location = new System.Drawing.Point(232, 253);
        this.psCheckBox.Name = "psCheckBox";
        this.psCheckBox.Size = new System.Drawing.Size(60, 21);
        this.psCheckBox.TabIndex = 10;
        this.psCheckBox.Text = "PS/2";
        this.psCheckBox.UseVisualStyleBackColor = true;
        // 
        // rjCheckBox
        // 
        this.rjCheckBox.AutoSize = true;
        this.rjCheckBox.Location = new System.Drawing.Point(232, 294);
        this.rjCheckBox.Name = "rjCheckBox";
        this.rjCheckBox.Size = new System.Drawing.Size(63, 21);
        this.rjCheckBox.TabIndex = 11;
        this.rjCheckBox.Text = "RJ45";
        this.rjCheckBox.UseVisualStyleBackColor = true;
        // 
        // submitButton
        // 
        this.submitButton.Location = new System.Drawing.Point(310, 327);
        this.submitButton.Name = "submitButton";
        this.submitButton.Size = new System.Drawing.Size(86, 31);
        this.submitButton.TabIndex = 12;
        this.submitButton.Text = "Submit";
        this.submitButton.UseVisualStyleBackColor = true;
        this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
        // 
        // backButton
        // 
        this.backButton.Location = new System.Drawing.Point(114, 327);
        this.backButton.Name = "backButton";
        this.backButton.Size = new System.Drawing.Size(86, 31);
        this.backButton.TabIndex = 13;
        this.backButton.Text = "Back";
        this.backButton.UseVisualStyleBackColor = true;
        this.backButton.Click += new System.EventHandler(this.backButton_Click);
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(232, 25);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(80, 17);
        this.label1.TabIndex = 14;
        this.label1.Text = "Plate # of #";
        // 
        // frmPlates
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(542, 371);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.backButton);
        this.Controls.Add(this.submitButton);
        this.Controls.Add(this.rjCheckBox);
        this.Controls.Add(this.psCheckBox);
        this.Controls.Add(this.RcaCheckBox);
        this.Controls.Add(this.serialCheckBox);
        this.Controls.Add(this.DviCheckBox);
        this.Controls.Add(this.parellelCheckBox);
        this.Name = "frmPlates";
        this.Text = "PlateForm";
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlateForm_FormClosing);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private CheckBox parellelCheckBox;
    private CheckBox DviCheckBox;
    private CheckBox serialCheckBox;
    private CheckBox RcaCheckBox;
    private System.Windows.Forms.CheckBox psCheckBox;
    private System.Windows.Forms.CheckBox rjCheckBox;
    private System.Windows.Forms.Button submitButton;
    private System.Windows.Forms.Button backButton;
    private System.Windows.Forms.Label label1;
}