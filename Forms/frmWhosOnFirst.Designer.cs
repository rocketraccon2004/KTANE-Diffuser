namespace KTANE_Diffuser_Winforms.Forms;

partial class frmWhosOnFirst
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
        btnSubmit1 = new Button();
        lblPosition = new Label();
        btnSubmit2 = new Button();
        txtWord1 = new TextBox();
        txtWord2 = new TextBox();
        txtSolution = new TextBox();
        SuspendLayout();
        // 
        // strikeButton
        // 
        strikeButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        strikeButton.Location = new Point(375, 975);
        strikeButton.Margin = new Padding(5, 6, 5, 6);
        strikeButton.Name = "strikeButton";
        strikeButton.Size = new Size(201, 84);
        strikeButton.TabIndex = 76;
        strikeButton.Text = "Strike";
        strikeButton.UseVisualStyleBackColor = true;
        strikeButton.Click += strikeButton_Click;
        // 
        // backButton
        // 
        backButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        backButton.Location = new Point(16, 975);
        backButton.Margin = new Padding(5, 6, 5, 6);
        backButton.Name = "backButton";
        backButton.Size = new Size(201, 84);
        backButton.TabIndex = 75;
        backButton.Text = "Back";
        backButton.UseVisualStyleBackColor = true;
        backButton.Click += backButton_Click;
        // 
        // btnSubmit1
        // 
        btnSubmit1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnSubmit1.Location = new Point(392, 75);
        btnSubmit1.Margin = new Padding(4, 5, 4, 5);
        btnSubmit1.Name = "btnSubmit1";
        btnSubmit1.Size = new Size(195, 77);
        btnSubmit1.TabIndex = 77;
        btnSubmit1.Text = "Submit";
        btnSubmit1.UseVisualStyleBackColor = true;
        btnSubmit1.Click += btnSubmit1_Click;
        // 
        // lblPosition
        // 
        lblPosition.AutoSize = true;
        lblPosition.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblPosition.Location = new Point(35, 334);
        lblPosition.Margin = new Padding(4, 0, 4, 0);
        lblPosition.Name = "lblPosition";
        lblPosition.Size = new Size(0, 29);
        lblPosition.TabIndex = 78;
        // 
        // btnSubmit2
        // 
        btnSubmit2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnSubmit2.Location = new Point(392, 381);
        btnSubmit2.Margin = new Padding(4, 5, 4, 5);
        btnSubmit2.Name = "btnSubmit2";
        btnSubmit2.Size = new Size(195, 77);
        btnSubmit2.TabIndex = 79;
        btnSubmit2.Text = "  ";
        btnSubmit2.UseVisualStyleBackColor = true;
        btnSubmit2.Click += btnSubmit2_Click;
        // 
        // txtWord1
        // 
        txtWord1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtWord1.Location = new Point(155, 100);
        txtWord1.Margin = new Padding(4, 5, 4, 5);
        txtWord1.Name = "txtWord1";
        txtWord1.Size = new Size(229, 35);
        txtWord1.TabIndex = 80;
        // 
        // txtWord2
        // 
        txtWord2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtWord2.Location = new Point(155, 395);
        txtWord2.Margin = new Padding(4, 5, 4, 5);
        txtWord2.Name = "txtWord2";
        txtWord2.Size = new Size(229, 35);
        txtWord2.TabIndex = 81;
        // 
        // txtSolution
        // 
        txtSolution.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtSolution.Location = new Point(11, 552);
        txtSolution.Margin = new Padding(4, 5, 4, 5);
        txtSolution.Multiline = true;
        txtSolution.Name = "txtSolution";
        txtSolution.ReadOnly = true;
        txtSolution.Size = new Size(574, 371);
        txtSolution.TabIndex = 82;
        // 
        // frmWhosOnFirst
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(625, 1100);
        Controls.Add(txtSolution);
        Controls.Add(txtWord2);
        Controls.Add(txtWord1);
        Controls.Add(btnSubmit2);
        Controls.Add(lblPosition);
        Controls.Add(btnSubmit1);
        Controls.Add(strikeButton);
        Controls.Add(backButton);
        Margin = new Padding(4, 5, 4, 5);
        Name = "frmWhosOnFirst";
        Text = "Who's on first";
        Load += frmWhosOnFirst_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button strikeButton;
    private Button backButton;
    private Button btnSubmit1;
    private Label lblPosition;
    private Button btnSubmit2;
    private TextBox txtWord1;
    private TextBox txtWord2;
    private TextBox txtSolution;
}