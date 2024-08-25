
namespace KTANE_Diffuser_Winforms.Forms;

partial class frmWireSequences
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
        cbWire1Colour = new ComboBox();
        cbWire2Colour = new ComboBox();
        cbWire3Colour = new ComboBox();
        cbWire3End = new ComboBox();
        cbWire1End = new ComboBox();
        cbWire2End = new ComboBox();
        label3 = new Label();
        label4 = new Label();
        SuspendLayout();
        // 
        // btnBack
        // 
        btnBack.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnBack.Location = new Point(19, 547);
        btnBack.Margin = new Padding(6, 7, 6, 7);
        btnBack.Name = "btnBack";
        btnBack.Size = new Size(201, 85);
        btnBack.TabIndex = 81;
        btnBack.Text = "Back";
        btnBack.UseVisualStyleBackColor = true;
        btnBack.Click += btnBack_Click;
        // 
        // btnStrike
        // 
        btnStrike.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnStrike.Location = new Point(246, 547);
        btnStrike.Margin = new Padding(6, 7, 6, 7);
        btnStrike.Name = "btnStrike";
        btnStrike.Size = new Size(201, 85);
        btnStrike.TabIndex = 80;
        btnStrike.Text = "Strike";
        btnStrike.UseVisualStyleBackColor = true;
        btnStrike.Click += btnStrike_Click;
        // 
        // btnSolve
        // 
        btnSolve.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnSolve.Location = new Point(459, 547);
        btnSolve.Margin = new Padding(6, 7, 6, 7);
        btnSolve.Name = "btnSolve";
        btnSolve.Size = new Size(201, 85);
        btnSolve.TabIndex = 79;
        btnSolve.Text = "Solve";
        btnSolve.UseVisualStyleBackColor = true;
        btnSolve.Click += btnSolve_Click;
        // 
        // cbWire1Colour
        // 
        cbWire1Colour.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cbWire1Colour.FormattingEnabled = true;
        cbWire1Colour.Items.AddRange(new object[] { "", "Red", "Blue", "Black" });
        cbWire1Colour.Location = new Point(145, 137);
        cbWire1Colour.Margin = new Padding(4, 5, 4, 5);
        cbWire1Colour.Name = "cbWire1Colour";
        cbWire1Colour.Size = new Size(188, 53);
        cbWire1Colour.TabIndex = 85;
        // 
        // cbWire2Colour
        // 
        cbWire2Colour.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cbWire2Colour.FormattingEnabled = true;
        cbWire2Colour.Items.AddRange(new object[] { "", "Red", "Blue", "Black" });
        cbWire2Colour.Location = new Point(145, 238);
        cbWire2Colour.Margin = new Padding(4, 5, 4, 5);
        cbWire2Colour.Name = "cbWire2Colour";
        cbWire2Colour.Size = new Size(188, 53);
        cbWire2Colour.TabIndex = 86;
        // 
        // cbWire3Colour
        // 
        cbWire3Colour.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cbWire3Colour.FormattingEnabled = true;
        cbWire3Colour.Items.AddRange(new object[] { "", "Red", "Blue", "Black" });
        cbWire3Colour.Location = new Point(145, 338);
        cbWire3Colour.Margin = new Padding(4, 5, 4, 5);
        cbWire3Colour.Name = "cbWire3Colour";
        cbWire3Colour.Size = new Size(188, 53);
        cbWire3Colour.TabIndex = 87;
        // 
        // cbWire3End
        // 
        cbWire3End.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cbWire3End.FormattingEnabled = true;
        cbWire3End.Items.AddRange(new object[] { "", "A", "B", "C" });
        cbWire3End.Location = new Point(358, 338);
        cbWire3End.Margin = new Padding(4, 5, 4, 5);
        cbWire3End.Name = "cbWire3End";
        cbWire3End.Size = new Size(188, 53);
        cbWire3End.TabIndex = 88;
        // 
        // cbWire1End
        // 
        cbWire1End.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cbWire1End.FormattingEnabled = true;
        cbWire1End.Items.AddRange(new object[] { "", "A", "B", "C" });
        cbWire1End.Location = new Point(358, 137);
        cbWire1End.Margin = new Padding(4, 5, 4, 5);
        cbWire1End.Name = "cbWire1End";
        cbWire1End.Size = new Size(188, 53);
        cbWire1End.TabIndex = 88;
        // 
        // cbWire2End
        // 
        cbWire2End.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cbWire2End.FormattingEnabled = true;
        cbWire2End.Items.AddRange(new object[] { "", "A", "B", "C" });
        cbWire2End.Location = new Point(358, 238);
        cbWire2End.Margin = new Padding(4, 5, 4, 5);
        cbWire2End.Name = "cbWire2End";
        cbWire2End.Size = new Size(188, 53);
        cbWire2End.TabIndex = 89;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label3.Location = new Point(179, 58);
        label3.Margin = new Padding(4, 0, 4, 0);
        label3.Name = "label3";
        label3.Size = new Size(115, 45);
        label3.TabIndex = 91;
        label3.Text = "Colour";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label4.Location = new Point(419, 58);
        label4.Margin = new Padding(4, 0, 4, 0);
        label4.Name = "label4";
        label4.Size = new Size(73, 45);
        label4.TabIndex = 92;
        label4.Text = "End";
        // 
        // frmWireSequences
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(684, 648);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(cbWire2End);
        Controls.Add(cbWire1End);
        Controls.Add(cbWire3End);
        Controls.Add(cbWire3Colour);
        Controls.Add(cbWire2Colour);
        Controls.Add(cbWire1Colour);
        Controls.Add(btnBack);
        Controls.Add(btnStrike);
        Controls.Add(btnSolve);
        Margin = new Padding(4, 5, 4, 5);
        Name = "frmWireSequences";
        Text = "Wire Sequences";
        ResumeLayout(false);
        PerformLayout();
    }
    #endregion

    private Button btnBack;
    private Button btnStrike;
    private Button btnSolve;
    private ComboBox cbWire1Colour;
    private ComboBox cbWire2Colour;
    private ComboBox cbWire3Colour;
    private ComboBox cbWire3End;
    private ComboBox cbWire1End;
    private ComboBox cbWire2End;
    private Label label3;
    private Label label4;
}