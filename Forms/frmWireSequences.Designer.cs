
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
            this.cbWire1Colour = new System.Windows.Forms.ComboBox();
            this.cbWire2Colour = new System.Windows.Forms.ComboBox();
            this.cbWire3Colour = new System.Windows.Forms.ComboBox();
            this.cbWire3End = new System.Windows.Forms.ComboBox();
            this.cbWire1End = new System.Windows.Forms.ComboBox();
            this.cbWire2End = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSolve
            // 
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // cbWire1Colour
            // 
            this.cbWire1Colour.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWire1Colour.FormattingEnabled = true;
            this.cbWire1Colour.Items.AddRange(new object[] {
            "",
            "Red",
            "Blue",
            "Black"});
            this.cbWire1Colour.Location = new System.Drawing.Point(210, 95);
            this.cbWire1Colour.Margin = new System.Windows.Forms.Padding(4);
            this.cbWire1Colour.Name = "cbWire1Colour";
            this.cbWire1Colour.Size = new System.Drawing.Size(170, 53);
            this.cbWire1Colour.TabIndex = 85;
            // 
            // cbWire2Colour
            // 
            this.cbWire2Colour.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWire2Colour.FormattingEnabled = true;
            this.cbWire2Colour.Items.AddRange(new object[] {
            "",
            "Red",
            "Blue",
            "Black"});
            this.cbWire2Colour.Location = new System.Drawing.Point(210, 175);
            this.cbWire2Colour.Margin = new System.Windows.Forms.Padding(4);
            this.cbWire2Colour.Name = "cbWire2Colour";
            this.cbWire2Colour.Size = new System.Drawing.Size(170, 53);
            this.cbWire2Colour.TabIndex = 86;
            // 
            // cbWire3Colour
            // 
            this.cbWire3Colour.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWire3Colour.FormattingEnabled = true;
            this.cbWire3Colour.Items.AddRange(new object[] {
            "",
            "Red",
            "Blue",
            "Black"});
            this.cbWire3Colour.Location = new System.Drawing.Point(210, 255);
            this.cbWire3Colour.Margin = new System.Windows.Forms.Padding(4);
            this.cbWire3Colour.Name = "cbWire3Colour";
            this.cbWire3Colour.Size = new System.Drawing.Size(170, 53);
            this.cbWire3Colour.TabIndex = 87;
            // 
            // cbWire3End
            // 
            this.cbWire3End.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWire3End.FormattingEnabled = true;
            this.cbWire3End.Items.AddRange(new object[] {
            "",
            "A",
            "B",
            "C"});
            this.cbWire3End.Location = new System.Drawing.Point(402, 255);
            this.cbWire3End.Margin = new System.Windows.Forms.Padding(4);
            this.cbWire3End.Name = "cbWire3End";
            this.cbWire3End.Size = new System.Drawing.Size(170, 53);
            this.cbWire3End.TabIndex = 88;
            // 
            // cbWire1End
            // 
            this.cbWire1End.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWire1End.FormattingEnabled = true;
            this.cbWire1End.Items.AddRange(new object[] {
            "",
            "A",
            "B",
            "C"});
            this.cbWire1End.Location = new System.Drawing.Point(402, 95);
            this.cbWire1End.Margin = new System.Windows.Forms.Padding(4);
            this.cbWire1End.Name = "cbWire1End";
            this.cbWire1End.Size = new System.Drawing.Size(170, 53);
            this.cbWire1End.TabIndex = 88;
            // 
            // cbWire2End
            // 
            this.cbWire2End.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWire2End.FormattingEnabled = true;
            this.cbWire2End.Items.AddRange(new object[] {
            "",
            "A",
            "B",
            "C"});
            this.cbWire2End.Location = new System.Drawing.Point(402, 175);
            this.cbWire2End.Margin = new System.Windows.Forms.Padding(4);
            this.cbWire2End.Name = "cbWire2End";
            this.cbWire2End.Size = new System.Drawing.Size(170, 53);
            this.cbWire2End.TabIndex = 89;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(241, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 45);
            this.label3.TabIndex = 91;
            this.label3.Text = "Colour";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(457, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 45);
            this.label4.TabIndex = 92;
            this.label4.Text = "End";
            // 
            // frmWireSequences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbWire2End);
            this.Controls.Add(this.cbWire1End);
            this.Controls.Add(this.cbWire3End);
            this.Controls.Add(this.cbWire3Colour);
            this.Controls.Add(this.cbWire2Colour);
            this.Controls.Add(this.cbWire1Colour);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmWireSequences";
            this.Text = "Wire Sequences";
            this.Controls.SetChildIndex(this.cbWire1Colour, 0);
            this.Controls.SetChildIndex(this.cbWire2Colour, 0);
            this.Controls.SetChildIndex(this.cbWire3Colour, 0);
            this.Controls.SetChildIndex(this.cbWire3End, 0);
            this.Controls.SetChildIndex(this.cbWire1End, 0);
            this.Controls.SetChildIndex(this.cbWire2End, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.btnSolve, 0);
            this.Controls.SetChildIndex(this.btnStrike, 0);
            this.Controls.SetChildIndex(this.btnBack, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

    }
    #endregion
    private ComboBox cbWire1Colour;
    private ComboBox cbWire2Colour;
    private ComboBox cbWire3Colour;
    private ComboBox cbWire3End;
    private ComboBox cbWire1End;
    private ComboBox cbWire2End;
    private Label label3;
    private Label label4;
}