namespace KTANE_Diffuser_Winforms.Forms;


partial class frmMain
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
            this.dropDownModules = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChangeEdgework = new System.Windows.Forms.Button();
            this.btnSaveEdgework = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(76, 108);
            // 
            // btnStrike
            // 
            this.btnStrike.Location = new System.Drawing.Point(14, 262);
            this.btnStrike.Size = new System.Drawing.Size(248, 46);
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(76, 108);
            // 
            // dropDownModules
            // 
            this.dropDownModules.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropDownModules.FormattingEnabled = true;
            this.dropDownModules.Items.AddRange(new object[] {
            "3d Maze (DO NOT SELECT)",
            "Adjacent Letters",
            "Adventure Game",
            "Button",
            "Colour Flash",
            "Complicated Wires",
            "Keypads",
            "Knob",
            "Maze",
            "Memory",
            "Password",
            "Simon Says",
            "Wire Sequences",
            "Wires",
            "Who\'s On First"});
            this.dropDownModules.Location = new System.Drawing.Point(204, 68);
            this.dropDownModules.Margin = new System.Windows.Forms.Padding(4);
            this.dropDownModules.Name = "dropDownModules";
            this.dropDownModules.Size = new System.Drawing.Size(324, 37);
            this.dropDownModules.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select a module:";
            // 
            // btnChangeEdgework
            // 
            this.btnChangeEdgework.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeEdgework.Location = new System.Drawing.Point(14, 202);
            this.btnChangeEdgework.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangeEdgework.Name = "btnChangeEdgework";
            this.btnChangeEdgework.Size = new System.Drawing.Size(248, 46);
            this.btnChangeEdgework.TabIndex = 2;
            this.btnChangeEdgework.Text = "Change Edgework";
            this.btnChangeEdgework.UseVisualStyleBackColor = true;
            this.btnChangeEdgework.Click += new System.EventHandler(this.btnChangeEdgework_Click);
            // 
            // btnSaveEdgework
            // 
            this.btnSaveEdgework.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveEdgework.Location = new System.Drawing.Point(281, 202);
            this.btnSaveEdgework.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveEdgework.Name = "btnSaveEdgework";
            this.btnSaveEdgework.Size = new System.Drawing.Size(248, 46);
            this.btnSaveEdgework.TabIndex = 4;
            this.btnSaveEdgework.Text = "Save Edgework";
            this.btnSaveEdgework.UseVisualStyleBackColor = true;
            this.btnSaveEdgework.Click += new System.EventHandler(this.saveEdgeworkButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(281, 262);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "Select Module";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 317);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSaveEdgework);
            this.Controls.Add(this.btnChangeEdgework);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dropDownModules);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "KTANE Assistant";
            this.Controls.SetChildIndex(this.dropDownModules, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnChangeEdgework, 0);
            this.Controls.SetChildIndex(this.btnSaveEdgework, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.btnSolve, 0);
            this.Controls.SetChildIndex(this.btnStrike, 0);
            this.Controls.SetChildIndex(this.btnBack, 0);
            this.ResumeLayout(false);

    }

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button btnSaveEdgework;

    private System.Windows.Forms.Button btnChangeEdgework;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.ComboBox dropDownModules;

    #endregion
}