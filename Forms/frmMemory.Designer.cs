namespace KTANE_Diffuser_Winforms.Forms;

partial class frmMemory
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
        btnBack = new Button();
        button1 = new Button();
        btnSolve = new Button();
        txtNum1 = new TextBox();
        txtNum2 = new TextBox();
        txtNum3 = new TextBox();
        txtNum4 = new TextBox();
        txtDisplay = new TextBox();
        lblRound = new Label();
        SuspendLayout();
        // 
        // btnBack
        // 
        btnBack.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnBack.Location = new Point(28, 251);
        btnBack.Margin = new Padding(4);
        btnBack.Name = "btnBack";
        btnBack.Size = new Size(141, 51);
        btnBack.TabIndex = 75;
        btnBack.Text = "Back";
        btnBack.UseVisualStyleBackColor = true;
        btnBack.Click += btnBack_Click;
        // 
        // button1
        // 
        button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        button1.Location = new Point(184, 251);
        button1.Margin = new Padding(4);
        button1.Name = "button1";
        button1.Size = new Size(141, 51);
        button1.TabIndex = 74;
        button1.Text = "Strike";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // btnSolve
        // 
        btnSolve.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnSolve.Location = new Point(342, 251);
        btnSolve.Margin = new Padding(4);
        btnSolve.Name = "btnSolve";
        btnSolve.Size = new Size(141, 51);
        btnSolve.TabIndex = 73;
        btnSolve.Text = "Solve";
        btnSolve.UseVisualStyleBackColor = true;
        btnSolve.Click += btnSolve_Click;
        // 
        // txtNum1
        // 
        txtNum1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtNum1.Location = new Point(148, 153);
        txtNum1.Name = "txtNum1";
        txtNum1.Size = new Size(45, 29);
        txtNum1.TabIndex = 76;
        txtNum1.TextAlign = HorizontalAlignment.Center;
        // 
        // txtNum2
        // 
        txtNum2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtNum2.Location = new Point(199, 153);
        txtNum2.Name = "txtNum2";
        txtNum2.Size = new Size(45, 29);
        txtNum2.TabIndex = 77;
        txtNum2.TextAlign = HorizontalAlignment.Center;
        // 
        // txtNum3
        // 
        txtNum3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtNum3.Location = new Point(250, 153);
        txtNum3.Name = "txtNum3";
        txtNum3.Size = new Size(45, 29);
        txtNum3.TabIndex = 78;
        txtNum3.TextAlign = HorizontalAlignment.Center;
        // 
        // txtNum4
        // 
        txtNum4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtNum4.Location = new Point(301, 153);
        txtNum4.Name = "txtNum4";
        txtNum4.Size = new Size(45, 29);
        txtNum4.TabIndex = 79;
        txtNum4.TextAlign = HorizontalAlignment.Center;
        // 
        // txtDisplay
        // 
        txtDisplay.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtDisplay.Location = new Point(148, 79);
        txtDisplay.Name = "txtDisplay";
        txtDisplay.Size = new Size(198, 50);
        txtDisplay.TabIndex = 80;
        txtDisplay.TextAlign = HorizontalAlignment.Center;
        // 
        // lblRound
        // 
        lblRound.AutoSize = true;
        lblRound.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblRound.Location = new Point(148, 24);
        lblRound.Name = "lblRound";
        lblRound.Size = new Size(90, 37);
        lblRound.TabIndex = 81;
        lblRound.Text = "label1";
        // 
        // frmMemory
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(526, 315);
        Controls.Add(lblRound);
        Controls.Add(txtDisplay);
        Controls.Add(txtNum4);
        Controls.Add(txtNum3);
        Controls.Add(txtNum2);
        Controls.Add(txtNum1);
        Controls.Add(btnBack);
        Controls.Add(button1);
        Controls.Add(btnSolve);
        Name = "frmMemory";
        Text = "Memory";
        FormClosing += frmMemory_FormClosing;
        Load += frmMemory_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnBack;
    private Button button1;
    private Button btnSolve;
    private TextBox txtNum1;
    private TextBox txtNum2;
    private TextBox txtNum3;
    private TextBox txtNum4;
    private TextBox txtDisplay;
    private Label lblRound;
}