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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSolve = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.dropDownColour.Location = new System.Drawing.Point(285, 42);
            this.dropDownColour.Name = "dropDownColour";
            this.dropDownColour.Size = new System.Drawing.Size(263, 33);
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
            this.dropDownText.Location = new System.Drawing.Point(285, 118);
            this.dropDownText.Name = "dropDownText";
            this.dropDownText.Size = new System.Drawing.Size(263, 33);
            this.dropDownText.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Colour";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Label";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(13, 197);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 54);
            this.button2.TabIndex = 75;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(191, 197);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 54);
            this.button1.TabIndex = 74;
            this.button1.Text = "Strike";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnStrike_Click);
            // 
            // btnSolve
            // 
            this.btnSolve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolve.Location = new System.Drawing.Point(371, 197);
            this.btnSolve.Margin = new System.Windows.Forms.Padding(4);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(161, 54);
            this.btnSolve.TabIndex = 73;
            this.btnSolve.Text = "Solve";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // frmButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 292);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dropDownText);
            this.Controls.Add(this.dropDownColour);
            this.Name = "frmButton";
            this.Text = "Button";
            this.ResumeLayout(false);

    }

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.ComboBox dropDownText;
    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.ComboBox dropDownColour;

    #endregion

    private Button button2;
    private Button button1;
    private Button btnSolve;
}