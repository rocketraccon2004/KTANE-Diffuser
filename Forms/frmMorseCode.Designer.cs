namespace KTANE_Diffuser_Winforms.Forms;

partial class frmMorseCode
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
        btnStrike = new Button();
        label1 = new Label();
        lblAnswer = new Label();
        btnSolve = new Button();
        comboBox1 = new ComboBox();
        linkLabel1 = new LinkLabel();
        SuspendLayout();
        // 
        // btnBack
        // 
        btnBack.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnBack.Location = new Point(16, 323);
        btnBack.Margin = new Padding(6, 7, 6, 7);
        btnBack.Name = "btnBack";
        btnBack.Size = new Size(201, 85);
        btnBack.TabIndex = 78;
        btnBack.Text = "Back";
        btnBack.UseVisualStyleBackColor = true;
        btnBack.Click += btnBack_Click;
        // 
        // btnStrike
        // 
        btnStrike.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnStrike.Location = new Point(457, 323);
        btnStrike.Margin = new Padding(6, 7, 6, 7);
        btnStrike.Name = "btnStrike";
        btnStrike.Size = new Size(201, 85);
        btnStrike.TabIndex = 77;
        btnStrike.Text = "Strike";
        btnStrike.UseVisualStyleBackColor = true;
        btnStrike.Click += btnStrike_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label1.Location = new Point(244, 117);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(192, 45);
        label1.TabIndex = 80;
        label1.Text = "Select Word";
        // 
        // lblAnswer
        // 
        lblAnswer.AutoSize = true;
        lblAnswer.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblAnswer.Location = new Point(69, 309);
        lblAnswer.Margin = new Padding(4, 0, 4, 0);
        lblAnswer.Name = "lblAnswer";
        lblAnswer.Size = new Size(0, 45);
        lblAnswer.TabIndex = 82;
        // 
        // btnSolve
        // 
        btnSolve.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnSolve.Location = new Point(244, 323);
        btnSolve.Margin = new Padding(6, 7, 6, 7);
        btnSolve.Name = "btnSolve";
        btnSolve.Size = new Size(201, 85);
        btnSolve.TabIndex = 85;
        btnSolve.Text = "Solve";
        btnSolve.UseVisualStyleBackColor = true;
        btnSolve.Click += btnSolve_Click;
        // 
        // comboBox1
        // 
        comboBox1.FormattingEnabled = true;
        comboBox1.Location = new Point(226, 197);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new Size(219, 33);
        comboBox1.TabIndex = 86;
        // 
        // linkLabel1
        // 
        linkLabel1.AutoSize = true;
        linkLabel1.Location = new Point(256, 40);
        linkLabel1.Name = "linkLabel1";
        linkLabel1.Size = new Size(155, 25);
        linkLabel1.TabIndex = 87;
        linkLabel1.TabStop = true;
        linkLabel1.Text = "Click here to solve";
        linkLabel1.LinkClicked += linkLabel1_LinkClicked;
        // 
        // frmMorseCode
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(699, 422);
        Controls.Add(linkLabel1);
        Controls.Add(comboBox1);
        Controls.Add(btnSolve);
        Controls.Add(lblAnswer);
        Controls.Add(label1);
        Controls.Add(btnBack);
        Controls.Add(btnStrike);
        Margin = new Padding(4, 5, 4, 5);
        Name = "frmMorseCode";
        Text = "Morse Code";
        Load += frmMorseCode_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnBack;
    private Button btnStrike;
    private Label label1;
    private ListBox lbAnswers;
    private Label lblAnswer;
    private Button btnSolve;
    private ComboBox comboBox1;
    private LinkLabel linkLabel1;
}