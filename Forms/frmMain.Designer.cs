namespace KTANE_Diffuser_Winforms.Forms;


partial class frmMain
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        dropDownModules = new ComboBox();
        label1 = new Label();
        btnChangeEdgework = new Button();
        btnSaveEdgework = new Button();
        btnStrike = new Button();
        button1 = new Button();
        SuspendLayout();
        // 
        // dropDownModules
        // 
        dropDownModules.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        dropDownModules.FormattingEnabled = true;
        dropDownModules.Location = new Point(227, 85);
        dropDownModules.Margin = new Padding(4, 5, 4, 5);
        dropDownModules.Name = "dropDownModules";
        dropDownModules.Size = new Size(360, 37);
        dropDownModules.TabIndex = 0;
        // 
        // label1
        // 
        label1.BackColor = Color.Transparent;
        label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label1.Location = new Point(15, 85);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(204, 44);
        label1.TabIndex = 1;
        label1.Text = "Select a module:";
        // 
        // btnChangeEdgework
        // 
        btnChangeEdgework.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnChangeEdgework.Location = new Point(15, 252);
        btnChangeEdgework.Margin = new Padding(4, 5, 4, 5);
        btnChangeEdgework.Name = "btnChangeEdgework";
        btnChangeEdgework.Size = new Size(275, 58);
        btnChangeEdgework.TabIndex = 2;
        btnChangeEdgework.Text = "Change Edgework";
        btnChangeEdgework.UseVisualStyleBackColor = true;
        btnChangeEdgework.Click += btnChangeEdgework_Click;
        // 
        // btnSaveEdgework
        // 
        btnSaveEdgework.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnSaveEdgework.Location = new Point(312, 252);
        btnSaveEdgework.Margin = new Padding(4, 5, 4, 5);
        btnSaveEdgework.Name = "btnSaveEdgework";
        btnSaveEdgework.Size = new Size(275, 58);
        btnSaveEdgework.TabIndex = 4;
        btnSaveEdgework.Text = "Save Edgework";
        btnSaveEdgework.UseVisualStyleBackColor = true;
        btnSaveEdgework.Click += saveEdgeworkButton_Click;
        // 
        // btnStrike
        // 
        btnStrike.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnStrike.Location = new Point(15, 328);
        btnStrike.Margin = new Padding(4, 5, 4, 5);
        btnStrike.Name = "btnStrike";
        btnStrike.Size = new Size(275, 58);
        btnStrike.TabIndex = 5;
        btnStrike.Text = "Strike";
        btnStrike.UseVisualStyleBackColor = true;
        btnStrike.Click += btnStrike_click;
        // 
        // button1
        // 
        button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        button1.Location = new Point(312, 328);
        button1.Margin = new Padding(4, 5, 4, 5);
        button1.Name = "button1";
        button1.Size = new Size(275, 58);
        button1.TabIndex = 6;
        button1.Text = "Select Module";
        button1.UseVisualStyleBackColor = true;
        button1.Click += btnSelect_Click;
        // 
        // frmMain
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(603, 400);
        Controls.Add(button1);
        Controls.Add(btnStrike);
        Controls.Add(btnSaveEdgework);
        Controls.Add(btnChangeEdgework);
        Controls.Add(label1);
        Controls.Add(dropDownModules);
        Margin = new Padding(4, 5, 4, 5);
        Name = "frmMain";
        Text = "KTANE Assistant";
        Load += frmMain_Load;
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.Button btnStrike;
    private System.Windows.Forms.Button btnSaveEdgework;

    private System.Windows.Forms.Button btnChangeEdgework;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.ComboBox dropDownModules;

    #endregion
}