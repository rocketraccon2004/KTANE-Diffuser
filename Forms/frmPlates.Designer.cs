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
        parellelCheckBox = new CheckBox();
        DviCheckBox = new CheckBox();
        serialCheckBox = new CheckBox();
        RcaCheckBox = new CheckBox();
        psCheckBox = new CheckBox();
        rjCheckBox = new CheckBox();
        submitButton = new Button();
        backButton = new Button();
        label1 = new Label();
        SuspendLayout();
        // 
        // parellelCheckBox
        // 
        parellelCheckBox.AutoSize = true;
        parellelCheckBox.Location = new Point(290, 128);
        parellelCheckBox.Margin = new Padding(4, 5, 4, 5);
        parellelCheckBox.Name = "parellelCheckBox";
        parellelCheckBox.Size = new Size(92, 29);
        parellelCheckBox.TabIndex = 6;
        parellelCheckBox.Text = "Parallel";
        parellelCheckBox.UseVisualStyleBackColor = true;
        // 
        // DviCheckBox
        // 
        DviCheckBox.AutoSize = true;
        DviCheckBox.Location = new Point(290, 256);
        DviCheckBox.Margin = new Padding(4, 5, 4, 5);
        DviCheckBox.Name = "DviCheckBox";
        DviCheckBox.Size = new Size(67, 29);
        DviCheckBox.TabIndex = 7;
        DviCheckBox.Text = "DVI";
        DviCheckBox.UseVisualStyleBackColor = true;
        // 
        // serialCheckBox
        // 
        serialCheckBox.AutoSize = true;
        serialCheckBox.Location = new Point(290, 189);
        serialCheckBox.Margin = new Padding(4, 5, 4, 5);
        serialCheckBox.Name = "serialCheckBox";
        serialCheckBox.Size = new Size(80, 29);
        serialCheckBox.TabIndex = 8;
        serialCheckBox.Text = "Serial";
        serialCheckBox.UseVisualStyleBackColor = true;
        // 
        // RcaCheckBox
        // 
        RcaCheckBox.AutoSize = true;
        RcaCheckBox.Location = new Point(290, 323);
        RcaCheckBox.Margin = new Padding(4, 5, 4, 5);
        RcaCheckBox.Name = "RcaCheckBox";
        RcaCheckBox.Size = new Size(72, 29);
        RcaCheckBox.TabIndex = 9;
        RcaCheckBox.Text = "RCA";
        RcaCheckBox.UseVisualStyleBackColor = true;
        // 
        // psCheckBox
        // 
        psCheckBox.AutoSize = true;
        psCheckBox.Location = new Point(290, 395);
        psCheckBox.Margin = new Padding(4, 5, 4, 5);
        psCheckBox.Name = "psCheckBox";
        psCheckBox.Size = new Size(75, 29);
        psCheckBox.TabIndex = 10;
        psCheckBox.Text = "PS/2";
        psCheckBox.UseVisualStyleBackColor = true;
        // 
        // rjCheckBox
        // 
        rjCheckBox.AutoSize = true;
        rjCheckBox.Location = new Point(290, 459);
        rjCheckBox.Margin = new Padding(4, 5, 4, 5);
        rjCheckBox.Name = "rjCheckBox";
        rjCheckBox.Size = new Size(76, 29);
        rjCheckBox.TabIndex = 11;
        rjCheckBox.Text = "RJ45";
        rjCheckBox.UseVisualStyleBackColor = true;
        // 
        // submitButton
        // 
        submitButton.Location = new Point(388, 511);
        submitButton.Margin = new Padding(4, 5, 4, 5);
        submitButton.Name = "submitButton";
        submitButton.Size = new Size(108, 48);
        submitButton.TabIndex = 12;
        submitButton.Text = "Submit";
        submitButton.UseVisualStyleBackColor = true;
        submitButton.Click += submitButton_Click;
        // 
        // backButton
        // 
        backButton.Location = new Point(142, 511);
        backButton.Margin = new Padding(4, 5, 4, 5);
        backButton.Name = "backButton";
        backButton.Size = new Size(108, 48);
        backButton.TabIndex = 13;
        backButton.Text = "Back";
        backButton.UseVisualStyleBackColor = true;
        backButton.Click += backButton_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(290, 39);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(104, 25);
        label1.TabIndex = 14;
        label1.Text = "Plate # of #";
        // 
        // frmPlates
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(678, 580);
        Controls.Add(label1);
        Controls.Add(backButton);
        Controls.Add(submitButton);
        Controls.Add(rjCheckBox);
        Controls.Add(psCheckBox);
        Controls.Add(RcaCheckBox);
        Controls.Add(serialCheckBox);
        Controls.Add(DviCheckBox);
        Controls.Add(parellelCheckBox);
        Margin = new Padding(4, 5, 4, 5);
        Name = "frmPlates";
        Text = "Port Plates";
        ResumeLayout(false);
        PerformLayout();
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