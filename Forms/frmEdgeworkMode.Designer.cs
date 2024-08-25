namespace KTANE_Diffuser_Winforms.Forms;

partial class frmEdgeworkMode
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
        manualButton = new Button();
        automaticButton = new Button();
        promptLabel = new Label();
        SuspendLayout();
        // 
        // manualButton
        // 
        manualButton.Location = new Point(221, 76);
        manualButton.Name = "manualButton";
        manualButton.Size = new Size(91, 38);
        manualButton.TabIndex = 5;
        manualButton.Text = "Manual";
        manualButton.UseVisualStyleBackColor = true;
        manualButton.Click += manualButton_Click;
        // 
        // automaticButton
        // 
        automaticButton.Location = new Point(221, 32);
        automaticButton.Name = "automaticButton";
        automaticButton.Size = new Size(91, 38);
        automaticButton.TabIndex = 4;
        automaticButton.Text = "Automatic";
        automaticButton.UseVisualStyleBackColor = true;
        automaticButton.Click += automaticButton_Click;
        // 
        // promptLabel
        // 
        promptLabel.AutoSize = true;
        promptLabel.Location = new Point(15, 6);
        promptLabel.Name = "promptLabel";
        promptLabel.Size = new Size(469, 15);
        promptLabel.TabIndex = 3;
        promptLabel.Text = "Would you like to manually input the edgework or use the information in Edgework.txt?";
        // 
        // frmEdgeworkMode
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(542, 124);
        Controls.Add(manualButton);
        Controls.Add(automaticButton);
        Controls.Add(promptLabel);
        Margin = new Padding(3, 2, 3, 2);
        Name = "frmEdgeworkMode";
        Text = "Edgework Mode";
        Load += frmEdgeworkSelection_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Button manualButton;
    private System.Windows.Forms.Button automaticButton;
    private Label promptLabel;
}