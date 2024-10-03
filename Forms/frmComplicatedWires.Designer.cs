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
            this.cbRedWire = new System.Windows.Forms.CheckBox();
            this.cbBlueWire = new System.Windows.Forms.CheckBox();
            this.cbLED = new System.Windows.Forms.CheckBox();
            this.cbStar = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnSolve
            // 
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // cbRedWire
            // 
            this.cbRedWire.AutoSize = true;
            this.cbRedWire.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRedWire.Location = new System.Drawing.Point(337, 65);
            this.cbRedWire.Name = "cbRedWire";
            this.cbRedWire.Size = new System.Drawing.Size(175, 49);
            this.cbRedWire.TabIndex = 79;
            this.cbRedWire.Text = "Red Wire";
            this.cbRedWire.UseVisualStyleBackColor = true;
            // 
            // cbBlueWire
            // 
            this.cbBlueWire.AutoSize = true;
            this.cbBlueWire.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBlueWire.Location = new System.Drawing.Point(337, 135);
            this.cbBlueWire.Name = "cbBlueWire";
            this.cbBlueWire.Size = new System.Drawing.Size(182, 49);
            this.cbBlueWire.TabIndex = 80;
            this.cbBlueWire.Text = "Blue Wire";
            this.cbBlueWire.UseVisualStyleBackColor = true;
            // 
            // cbLED
            // 
            this.cbLED.AutoSize = true;
            this.cbLED.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLED.Location = new System.Drawing.Point(337, 204);
            this.cbLED.Name = "cbLED";
            this.cbLED.Size = new System.Drawing.Size(150, 49);
            this.cbLED.TabIndex = 81;
            this.cbLED.Text = "LED On";
            this.cbLED.UseVisualStyleBackColor = true;
            // 
            // cbStar
            // 
            this.cbStar.AutoSize = true;
            this.cbStar.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStar.Location = new System.Drawing.Point(337, 280);
            this.cbStar.Name = "cbStar";
            this.cbStar.Size = new System.Drawing.Size(215, 49);
            this.cbStar.TabIndex = 82;
            this.cbStar.Text = "Star Present";
            this.cbStar.UseVisualStyleBackColor = true;
            // 
            // frmComplicatedWires
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 582);
            this.Controls.Add(this.cbStar);
            this.Controls.Add(this.cbLED);
            this.Controls.Add(this.cbBlueWire);
            this.Controls.Add(this.cbRedWire);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmComplicatedWires";
            this.Text = "Complicated Wires";
            this.Controls.SetChildIndex(this.cbRedWire, 0);
            this.Controls.SetChildIndex(this.cbBlueWire, 0);
            this.Controls.SetChildIndex(this.cbLED, 0);
            this.Controls.SetChildIndex(this.cbStar, 0);
            this.Controls.SetChildIndex(this.btnSolve, 0);
            this.Controls.SetChildIndex(this.btnStrike, 0);
            this.Controls.SetChildIndex(this.btnBack, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.CheckBox cbRedWire;
    private System.Windows.Forms.CheckBox cbBlueWire;
    private System.Windows.Forms.CheckBox cbLED;
    private System.Windows.Forms.CheckBox cbStar;
}