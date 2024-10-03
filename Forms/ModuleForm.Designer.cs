using System.ComponentModel;

namespace KTANE_Diffuser_Winforms.Forms;

partial class ModuleForm
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
		btnBack = new Button();
		btnStrike = new Button();
		btnSolve = new Button();
		SuspendLayout();
		// 
		// btnBack
		// 
		btnBack.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		btnBack.Location = new Point(66, 426);
		btnBack.Margin = new Padding(6, 8, 6, 8);
		btnBack.Name = "btnBack";
		btnBack.Size = new Size(223, 105);
		btnBack.TabIndex = 81;
		btnBack.Text = "Back";
		btnBack.UseVisualStyleBackColor = true;
		btnBack.Click += btnBack_Click;
		// 
		// btnStrike
		// 
		btnStrike.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		btnStrike.Location = new Point(322, 426);
		btnStrike.Margin = new Padding(6, 8, 6, 8);
		btnStrike.Name = "btnStrike";
		btnStrike.Size = new Size(223, 105);
		btnStrike.TabIndex = 80;
		btnStrike.Text = "Strike";
		btnStrike.UseVisualStyleBackColor = true;
		btnStrike.Click += btnStrike_Click;
		// 
		// btnSolve
		// 
		btnSolve.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		btnSolve.Location = new Point(577, 426);
		btnSolve.Margin = new Padding(6, 8, 6, 8);
		btnSolve.Name = "btnSolve";
		btnSolve.Size = new Size(223, 105);
		btnSolve.TabIndex = 79;
		btnSolve.Text = "Solve";
		btnSolve.UseVisualStyleBackColor = true;
		// 
		// ModuleForm
		// 
		AutoScaleDimensions = new SizeF(10F, 25F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(889, 562);
		Controls.Add(btnBack);
		Controls.Add(btnStrike);
		Controls.Add(btnSolve);
		Margin = new Padding(3, 4, 3, 4);
		Name = "ModuleForm";
		Text = "ModuleForm";
		FormClosing += ModuleForm_FormClosing;
		ResumeLayout(false);
	}

	public System.Windows.Forms.Button btnBack;
    public System.Windows.Forms.Button btnStrike;
    public System.Windows.Forms.Button btnSolve;

    #endregion
}