namespace KTANE_Diffuser_Winforms.Forms;

partial class frmComplicatedWires
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
        btnSolve = new Button();
        cbRedWire = new CheckBox();
        cbBlueWire = new CheckBox();
        cbLED = new CheckBox();
        cbStar = new CheckBox();
        SuspendLayout();
        // 
        // btnBack
        // 
        btnBack.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnBack.Location = new Point(13, 210);
        btnBack.Margin = new Padding(4);
        btnBack.Name = "btnBack";
        btnBack.Size = new Size(141, 51);
        btnBack.TabIndex = 78;
        btnBack.Text = "Back";
        btnBack.UseVisualStyleBackColor = true;
        btnBack.Click += btnBack_Click;
        // 
        // btnStrike
        // 
        btnStrike.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnStrike.Location = new Point(172, 210);
        btnStrike.Margin = new Padding(4);
        btnStrike.Name = "btnStrike";
        btnStrike.Size = new Size(141, 51);
        btnStrike.TabIndex = 77;
        btnStrike.Text = "Strike";
        btnStrike.UseVisualStyleBackColor = true;
        btnStrike.Click += btnStrike_Click;
        // 
        // btnSolve
        // 
        btnSolve.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnSolve.Location = new Point(321, 210);
        btnSolve.Margin = new Padding(4);
        btnSolve.Name = "btnSolve";
        btnSolve.Size = new Size(141, 51);
        btnSolve.TabIndex = 76;
        btnSolve.Text = "Solve";
        btnSolve.UseVisualStyleBackColor = true;
        btnSolve.Click += btnSolve_Click;
        // 
        // cbRedWire
        // 
        cbRedWire.AutoSize = true;
        cbRedWire.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cbRedWire.Location = new Point(154, 23);
        cbRedWire.Name = "cbRedWire";
        cbRedWire.Size = new Size(121, 34);
        cbRedWire.TabIndex = 79;
        cbRedWire.Text = "Red Wire";
        cbRedWire.UseVisualStyleBackColor = true;
        // 
        // cbBlueWire
        // 
        cbBlueWire.AutoSize = true;
        cbBlueWire.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cbBlueWire.Location = new Point(154, 63);
        cbBlueWire.Name = "cbBlueWire";
        cbBlueWire.Size = new Size(126, 34);
        cbBlueWire.TabIndex = 80;
        cbBlueWire.Text = "Blue Wire";
        cbBlueWire.UseVisualStyleBackColor = true;
        // 
        // cbLED
        // 
        cbLED.AutoSize = true;
        cbLED.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cbLED.Location = new Point(154, 103);
        cbLED.Name = "cbLED";
        cbLED.Size = new Size(103, 34);
        cbLED.TabIndex = 81;
        cbLED.Text = "LED On";
        cbLED.UseVisualStyleBackColor = true;
        // 
        // cbStar
        // 
        cbStar.AutoSize = true;
        cbStar.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cbStar.Location = new Point(154, 143);
        cbStar.Name = "cbStar";
        cbStar.Size = new Size(147, 34);
        cbStar.TabIndex = 82;
        cbStar.Text = "Star Present";
        cbStar.UseVisualStyleBackColor = true;
        // 
        // frmComplicatedWires
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(493, 273);
        Controls.Add(cbStar);
        Controls.Add(cbLED);
        Controls.Add(cbBlueWire);
        Controls.Add(cbRedWire);
        Controls.Add(btnBack);
        Controls.Add(btnStrike);
        Controls.Add(btnSolve);
        Name = "frmComplicatedWires";
        Text = "Complicated Wires";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnBack;
    private Button btnStrike;
    private Button btnSolve;
    private CheckBox cbRedWire;
    private CheckBox cbBlueWire;
    private CheckBox cbLED;
    private CheckBox cbStar;
}