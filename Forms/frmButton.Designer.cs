using System.ComponentModel;

namespace KTANE_Diffuser_Winforms.Forms;

partial class frmButton
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
            this.dropDownColour = new System.Windows.Forms.ComboBox();
            this.dropDownText = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSolve
            // 
            this.btnSolve.Click += new System.EventHandler(this.solve);
            // 
            // dropDownColour
            // 
            this.dropDownColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropDownColour.FormattingEnabled = true;
            this.dropDownColour.Items.AddRange(new object[] {
            "Blue",
            "White",
            "Yellow",
            "Red"});
            this.dropDownColour.Location = new System.Drawing.Point(391, 43);
            this.dropDownColour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dropDownColour.Name = "dropDownColour";
            this.dropDownColour.Size = new System.Drawing.Size(295, 37);
            this.dropDownColour.TabIndex = 2;
            // 
            // dropDownText
            // 
            this.dropDownText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropDownText.FormattingEnabled = true;
            this.dropDownText.Items.AddRange(new object[] {
            "Abort",
            "Detonate",
            "Hold",
            "Press"});
            this.dropDownText.Location = new System.Drawing.Point(391, 139);
            this.dropDownText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dropDownText.Name = "dropDownText";
            this.dropDownText.Size = new System.Drawing.Size(295, 37);
            this.dropDownText.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Colour";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(279, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "Label";
            // 
            // frmButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 483);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dropDownText);
            this.Controls.Add(this.dropDownColour);
            this.Name = "frmButton";
            this.Text = "Button";
            this.Controls.SetChildIndex(this.dropDownColour, 0);
            this.Controls.SetChildIndex(this.dropDownText, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.btnSolve, 0);
            this.Controls.SetChildIndex(this.btnStrike, 0);
            this.Controls.SetChildIndex(this.btnBack, 0);
            this.ResumeLayout(false);

    }

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.ComboBox dropDownText;
    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.ComboBox dropDownColour;

    #endregion
}