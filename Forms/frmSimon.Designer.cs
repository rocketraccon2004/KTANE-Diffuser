namespace KTANE_Diffuser_Winforms.Forms;

partial class frmSimon
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
        strikeButton = new Button();
        backButton = new Button();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        txtRound1 = new TextBox();
        txtRound5 = new TextBox();
        txtRound4 = new TextBox();
        txtRound3 = new TextBox();
        txtRound2 = new TextBox();
        lblRound1 = new Label();
        lblRound2 = new Label();
        lblRound3 = new Label();
        lblRound4 = new Label();
        lblRound5 = new Label();
        SuspendLayout();
        // 
        // strikeButton
        // 
        strikeButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        strikeButton.Location = new Point(278, 348);
        strikeButton.Margin = new Padding(4);
        strikeButton.Name = "strikeButton";
        strikeButton.Size = new Size(141, 51);
        strikeButton.TabIndex = 74;
        strikeButton.Text = "Strike";
        strikeButton.UseVisualStyleBackColor = true;
        strikeButton.Click += strikeButton_Click;
        // 
        // backButton
        // 
        backButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        backButton.Location = new Point(25, 348);
        backButton.Margin = new Padding(4);
        backButton.Name = "backButton";
        backButton.Size = new Size(141, 51);
        backButton.TabIndex = 72;
        backButton.Text = "Back";
        backButton.UseVisualStyleBackColor = true;
        backButton.Click += backButton_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label1.Location = new Point(45, 21);
        label1.Name = "label1";
        label1.Size = new Size(64, 20);
        label1.TabIndex = 75;
        label1.Text = "R - Red";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label2.Location = new Point(45, 91);
        label2.Name = "label2";
        label2.Size = new Size(79, 20);
        label2.TabIndex = 76;
        label2.Text = "Y - Yellow";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label3.Location = new Point(45, 68);
        label3.Name = "label3";
        label3.Size = new Size(80, 20);
        label3.TabIndex = 77;
        label3.Text = "G - Green";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label4.Location = new Point(45, 44);
        label4.Name = "label4";
        label4.Size = new Size(65, 20);
        label4.TabIndex = 78;
        label4.Text = "B - Blue";
        // 
        // txtRound1
        // 
        txtRound1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtRound1.Location = new Point(278, 18);
        txtRound1.Name = "txtRound1";
        txtRound1.Size = new Size(58, 26);
        txtRound1.TabIndex = 79;
        txtRound1.TextChanged += solveRound1;
        // 
        // txtRound5
        // 
        txtRound5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtRound5.Location = new Point(278, 158);
        txtRound5.Name = "txtRound5";
        txtRound5.Size = new Size(58, 26);
        txtRound5.TabIndex = 81;
        txtRound5.TextChanged += solveRound5;
        // 
        // txtRound4
        // 
        txtRound4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtRound4.Location = new Point(278, 125);
        txtRound4.Name = "txtRound4";
        txtRound4.Size = new Size(58, 26);
        txtRound4.TabIndex = 82;
        txtRound4.TextChanged += solveRound4;
        // 
        // txtRound3
        // 
        txtRound3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtRound3.Location = new Point(278, 91);
        txtRound3.Name = "txtRound3";
        txtRound3.Size = new Size(58, 26);
        txtRound3.TabIndex = 83;
        txtRound3.TextChanged += solveRound3;
        // 
        // txtRound2
        // 
        txtRound2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtRound2.Location = new Point(278, 52);
        txtRound2.Name = "txtRound2";
        txtRound2.Size = new Size(58, 26);
        txtRound2.TabIndex = 84;
        txtRound2.TextChanged += solveRound2;
        // 
        // lblRound1
        // 
        lblRound1.AutoSize = true;
        lblRound1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblRound1.Location = new Point(349, 21);
        lblRound1.Name = "lblRound1";
        lblRound1.Size = new Size(0, 20);
        lblRound1.TabIndex = 85;
        // 
        // lblRound2
        // 
        lblRound2.AutoSize = true;
        lblRound2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblRound2.Location = new Point(351, 52);
        lblRound2.Name = "lblRound2";
        lblRound2.Size = new Size(0, 20);
        lblRound2.TabIndex = 86;
        // 
        // lblRound3
        // 
        lblRound3.AutoSize = true;
        lblRound3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblRound3.Location = new Point(349, 98);
        lblRound3.Name = "lblRound3";
        lblRound3.Size = new Size(0, 20);
        lblRound3.TabIndex = 87;
        // 
        // lblRound4
        // 
        lblRound4.AutoSize = true;
        lblRound4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblRound4.Location = new Point(349, 134);
        lblRound4.Name = "lblRound4";
        lblRound4.Size = new Size(0, 20);
        lblRound4.TabIndex = 88;
        // 
        // lblRound5
        // 
        lblRound5.AutoSize = true;
        lblRound5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblRound5.Location = new Point(341, 168);
        lblRound5.Name = "lblRound5";
        lblRound5.Size = new Size(0, 20);
        lblRound5.TabIndex = 89;
        // 
        // frmSimon
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(449, 422);
        Controls.Add(lblRound5);
        Controls.Add(lblRound4);
        Controls.Add(lblRound3);
        Controls.Add(lblRound2);
        Controls.Add(lblRound1);
        Controls.Add(txtRound2);
        Controls.Add(txtRound3);
        Controls.Add(txtRound4);
        Controls.Add(txtRound5);
        Controls.Add(txtRound1);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(strikeButton);
        Controls.Add(backButton);
        Name = "frmSimon";
        Text = "Simon Says";
        FormClosed += frmSimon_FormClosed;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button strikeButton;
    private Button backButton;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private TextBox txtRound1;
    private TextBox txtRound5;
    private TextBox txtRound4;
    private TextBox txtRound3;
    private TextBox txtRound2;
    private Label lblRound1;
    private Label lblRound2;
    private Label lblRound3;
    private Label lblRound4;
    private Label lblRound5;
}