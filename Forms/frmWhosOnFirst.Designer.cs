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
            this.btnSubmit1 = new System.Windows.Forms.Button();
            this.lblPosition = new System.Windows.Forms.Label();
            this.btnSubmit2 = new System.Windows.Forms.Button();
            this.txtWord1 = new System.Windows.Forms.TextBox();
            this.txtWord2 = new System.Windows.Forms.TextBox();
            this.txtSolution = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(14, 741);
            // 
            // btnStrike
            // 
            this.btnStrike.Location = new System.Drawing.Point(281, 741);
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(175, 361);
            // 
            // btnSubmit1
            // 
            this.btnSubmit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit1.Location = new System.Drawing.Point(353, 60);
            this.btnSubmit1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubmit1.Name = "btnSubmit1";
            this.btnSubmit1.Size = new System.Drawing.Size(176, 62);
            this.btnSubmit1.TabIndex = 77;
            this.btnSubmit1.Text = "Submit";
            this.btnSubmit1.UseVisualStyleBackColor = true;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(32, 267);
            this.lblPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(0, 29);
            this.lblPosition.TabIndex = 78;
            // 
            // btnSubmit2
            // 
            this.btnSubmit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit2.Location = new System.Drawing.Point(353, 305);
            this.btnSubmit2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubmit2.Name = "btnSubmit2";
            this.btnSubmit2.Size = new System.Drawing.Size(176, 62);
            this.btnSubmit2.TabIndex = 79;
            this.btnSubmit2.Text = "  ";
            this.btnSubmit2.UseVisualStyleBackColor = true;
            // 
            // txtWord1
            // 
            this.txtWord1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWord1.Location = new System.Drawing.Point(140, 80);
            this.txtWord1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtWord1.Name = "txtWord1";
            this.txtWord1.Size = new System.Drawing.Size(206, 35);
            this.txtWord1.TabIndex = 80;
            // 
            // txtWord2
            // 
            this.txtWord2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWord2.Location = new System.Drawing.Point(140, 316);
            this.txtWord2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtWord2.Name = "txtWord2";
            this.txtWord2.Size = new System.Drawing.Size(206, 35);
            this.txtWord2.TabIndex = 81;
            // 
            // txtSolution
            // 
            this.txtSolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSolution.Location = new System.Drawing.Point(10, 442);
            this.txtSolution.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSolution.Multiline = true;
            this.txtSolution.Name = "txtSolution";
            this.txtSolution.ReadOnly = true;
            this.txtSolution.Size = new System.Drawing.Size(517, 298);
            this.txtSolution.TabIndex = 82;
            // 
            // frmWhosOnFirst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(550, 840);
            this.Controls.Add(this.txtSolution);
            this.Controls.Add(this.txtWord2);
            this.Controls.Add(this.txtWord1);
            this.Controls.Add(this.btnSubmit2);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.btnSubmit1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmWhosOnFirst";
            this.Text = "Who\'s on first";
            this.Controls.SetChildIndex(this.btnSubmit1, 0);
            this.Controls.SetChildIndex(this.lblPosition, 0);
            this.Controls.SetChildIndex(this.btnSubmit2, 0);
            this.Controls.SetChildIndex(this.txtWord1, 0);
            this.Controls.SetChildIndex(this.txtWord2, 0);
            this.Controls.SetChildIndex(this.txtSolution, 0);
            this.Controls.SetChildIndex(this.btnSolve, 0);
            this.Controls.SetChildIndex(this.btnStrike, 0);
            this.Controls.SetChildIndex(this.btnBack, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private Button btnSubmit1;
    private Label lblPosition;
    private Button btnSubmit2;
    private TextBox txtWord1;
    private TextBox txtWord2;
    private TextBox txtSolution;
}