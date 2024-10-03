using System.ComponentModel;

namespace KTANE_Diffuser_Winforms.Forms;

partial class frmAdventureGame
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
		ddMonster = new ComboBox();
		label1 = new Label();
		label2 = new Label();
		label3 = new Label();
		label4 = new Label();
		label5 = new Label();
		label6 = new Label();
		label7 = new Label();
		label8 = new Label();
		txtSTR = new TextBox();
		txtPressure = new TextBox();
		txtGravity = new TextBox();
		txtTemperature = new TextBox();
		txtHeight = new TextBox();
		txtINT = new TextBox();
		txtDEX = new TextBox();
		label9 = new Label();
		label10 = new Label();
		cbBroadsword = new CheckBox();
		cbGrimoire = new CheckBox();
		cbMagicOrb = new CheckBox();
		cbLongbow = new CheckBox();
		cbNastyKnife = new CheckBox();
		cbCaber = new CheckBox();
		cbCrystalBall = new CheckBox();
		cbTrophy = new CheckBox();
		cbTicket = new CheckBox();
		cbSymbol = new CheckBox();
		cbSunstone = new CheckBox();
		cbStepladder = new CheckBox();
		cbSmallDog = new CheckBox();
		cbMoonstone = new CheckBox();
		cbLamp = new CheckBox();
		cbHardDrive = new CheckBox();
		cbFeather = new CheckBox();
		cbBattery = new CheckBox();
		cbBalloon = new CheckBox();
		cbBellows = new CheckBox();
		txtHeightInches = new TextBox();
		label11 = new Label();
		label12 = new Label();
		SuspendLayout();
		// 
		// btnBack
		// 
		btnBack.Location = new Point(469, 708);
		btnBack.Margin = new Padding(7, 10, 7, 10);
		// 
		// btnStrike
		// 
		btnStrike.Location = new Point(727, 708);
		btnStrike.Margin = new Padding(7, 10, 7, 10);
		// 
		// btnSolve
		// 
		btnSolve.Location = new Point(989, 708);
		btnSolve.Margin = new Padding(7, 10, 7, 10);
		btnSolve.Click += btnSolve_Click;
		// 
		// ddMonster
		// 
		ddMonster.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
		ddMonster.FormattingEnabled = true;
		ddMonster.Items.AddRange(new object[] { "Demon", "Dragon", "Eagle", "Goblin", "Golem", "Troll", "Lizard", "Wizard" });
		ddMonster.Location = new Point(346, 58);
		ddMonster.Margin = new Padding(3, 4, 3, 4);
		ddMonster.Name = "ddMonster";
		ddMonster.Size = new Size(193, 45);
		ddMonster.TabIndex = 82;
		// 
		// label1
		// 
		label1.AutoSize = true;
		label1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
		label1.Location = new Point(177, 61);
		label1.Name = "label1";
		label1.Size = new Size(141, 37);
		label1.TabIndex = 83;
		label1.Text = "Monster:";
		// 
		// label2
		// 
		label2.AutoSize = true;
		label2.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
		label2.Location = new Point(238, 146);
		label2.Name = "label2";
		label2.Size = new Size(89, 37);
		label2.TabIndex = 84;
		label2.Text = "STR:";
		// 
		// label3
		// 
		label3.AutoSize = true;
		label3.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
		label3.Location = new Point(236, 209);
		label3.Name = "label3";
		label3.Size = new Size(91, 37);
		label3.TabIndex = 85;
		label3.Text = "DEX:";
		// 
		// label4
		// 
		label4.AutoSize = true;
		label4.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
		label4.Location = new Point(250, 271);
		label4.Name = "label4";
		label4.Size = new Size(78, 37);
		label4.TabIndex = 86;
		label4.Text = "INT:";
		// 
		// label5
		// 
		label5.AutoSize = true;
		label5.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
		label5.Location = new Point(177, 335);
		label5.Name = "label5";
		label5.Size = new Size(146, 37);
		label5.TabIndex = 87;
		label5.Text = "HEIGHT:";
		// 
		// label6
		// 
		label6.AutoSize = true;
		label6.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
		label6.Location = new Point(44, 396);
		label6.Name = "label6";
		label6.Size = new Size(265, 37);
		label6.TabIndex = 88;
		label6.Text = "TEMPERATURE:";
		// 
		// label7
		// 
		label7.AutoSize = true;
		label7.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
		label7.Location = new Point(153, 459);
		label7.Name = "label7";
		label7.Size = new Size(167, 37);
		label7.TabIndex = 89;
		label7.Text = "GRAVITY:";
		// 
		// label8
		// 
		label8.AutoSize = true;
		label8.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
		label8.Location = new Point(119, 521);
		label8.Name = "label8";
		label8.Size = new Size(198, 37);
		label8.TabIndex = 90;
		label8.Text = "PRESSURE:";
		// 
		// txtSTR
		// 
		txtSTR.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
		txtSTR.Location = new Point(346, 142);
		txtSTR.Margin = new Padding(3, 4, 3, 4);
		txtSTR.Name = "txtSTR";
		txtSTR.Size = new Size(140, 44);
		txtSTR.TabIndex = 91;
		// 
		// txtPressure
		// 
		txtPressure.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
		txtPressure.Location = new Point(346, 518);
		txtPressure.Margin = new Padding(3, 4, 3, 4);
		txtPressure.Name = "txtPressure";
		txtPressure.Size = new Size(140, 44);
		txtPressure.TabIndex = 92;
		// 
		// txtGravity
		// 
		txtGravity.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
		txtGravity.Location = new Point(346, 455);
		txtGravity.Margin = new Padding(3, 4, 3, 4);
		txtGravity.Name = "txtGravity";
		txtGravity.Size = new Size(140, 44);
		txtGravity.TabIndex = 93;
		// 
		// txtTemperature
		// 
		txtTemperature.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
		txtTemperature.Location = new Point(346, 392);
		txtTemperature.Margin = new Padding(3, 4, 3, 4);
		txtTemperature.Name = "txtTemperature";
		txtTemperature.Size = new Size(140, 44);
		txtTemperature.TabIndex = 94;
		// 
		// txtHeight
		// 
		txtHeight.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
		txtHeight.Location = new Point(346, 331);
		txtHeight.Margin = new Padding(3, 4, 3, 4);
		txtHeight.Name = "txtHeight";
		txtHeight.Size = new Size(49, 44);
		txtHeight.TabIndex = 95;
		// 
		// txtINT
		// 
		txtINT.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
		txtINT.Location = new Point(346, 268);
		txtINT.Margin = new Padding(3, 4, 3, 4);
		txtINT.Name = "txtINT";
		txtINT.Size = new Size(140, 44);
		txtINT.TabIndex = 96;
		// 
		// txtDEX
		// 
		txtDEX.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
		txtDEX.Location = new Point(346, 205);
		txtDEX.Margin = new Padding(3, 4, 3, 4);
		txtDEX.Name = "txtDEX";
		txtDEX.Size = new Size(140, 44);
		txtDEX.TabIndex = 97;
		// 
		// label9
		// 
		label9.AutoSize = true;
		label9.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
		label9.Location = new Point(731, 68);
		label9.Name = "label9";
		label9.Size = new Size(153, 37);
		label9.TabIndex = 98;
		label9.Text = "Weapons";
		// 
		// label10
		// 
		label10.AutoSize = true;
		label10.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
		label10.Location = new Point(1137, 68);
		label10.Name = "label10";
		label10.Size = new Size(94, 37);
		label10.TabIndex = 99;
		label10.Text = "Items";
		// 
		// cbBroadsword
		// 
		cbBroadsword.AutoSize = true;
		cbBroadsword.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
		cbBroadsword.Location = new Point(739, 142);
		cbBroadsword.Margin = new Padding(3, 4, 3, 4);
		cbBroadsword.Name = "cbBroadsword";
		cbBroadsword.Size = new Size(215, 41);
		cbBroadsword.TabIndex = 100;
		cbBroadsword.Text = "Broadsword";
		cbBroadsword.UseVisualStyleBackColor = true;
		// 
		// cbGrimoire
		// 
		cbGrimoire.AutoSize = true;
		cbGrimoire.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
		cbGrimoire.Location = new Point(739, 436);
		cbGrimoire.Margin = new Padding(3, 4, 3, 4);
		cbGrimoire.Name = "cbGrimoire";
		cbGrimoire.Size = new Size(166, 41);
		cbGrimoire.TabIndex = 101;
		cbGrimoire.Text = "Grimoire";
		cbGrimoire.UseVisualStyleBackColor = true;
		// 
		// cbMagicOrb
		// 
		cbMagicOrb.AutoSize = true;
		cbMagicOrb.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
		cbMagicOrb.Location = new Point(739, 378);
		cbMagicOrb.Margin = new Padding(3, 4, 3, 4);
		cbMagicOrb.Name = "cbMagicOrb";
		cbMagicOrb.Size = new Size(191, 41);
		cbMagicOrb.TabIndex = 102;
		cbMagicOrb.Text = "Magic Orb";
		cbMagicOrb.UseVisualStyleBackColor = true;
		// 
		// cbLongbow
		// 
		cbLongbow.AutoSize = true;
		cbLongbow.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
		cbLongbow.Location = new Point(739, 319);
		cbLongbow.Margin = new Padding(3, 4, 3, 4);
		cbLongbow.Name = "cbLongbow";
		cbLongbow.Size = new Size(174, 41);
		cbLongbow.TabIndex = 103;
		cbLongbow.Text = "Longbow";
		cbLongbow.UseVisualStyleBackColor = true;
		// 
		// cbNastyKnife
		// 
		cbNastyKnife.AutoSize = true;
		cbNastyKnife.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
		cbNastyKnife.Location = new Point(739, 260);
		cbNastyKnife.Margin = new Padding(3, 4, 3, 4);
		cbNastyKnife.Name = "cbNastyKnife";
		cbNastyKnife.Size = new Size(206, 41);
		cbNastyKnife.TabIndex = 104;
		cbNastyKnife.Text = "Nasty Knife";
		cbNastyKnife.UseVisualStyleBackColor = true;
		// 
		// cbCaber
		// 
		cbCaber.AutoSize = true;
		cbCaber.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
		cbCaber.Location = new Point(739, 201);
		cbCaber.Margin = new Padding(3, 4, 3, 4);
		cbCaber.Name = "cbCaber";
		cbCaber.Size = new Size(130, 41);
		cbCaber.TabIndex = 105;
		cbCaber.Text = "Caber";
		cbCaber.UseVisualStyleBackColor = true;
		// 
		// cbCrystalBall
		// 
		cbCrystalBall.AutoSize = true;
		cbCrystalBall.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
		cbCrystalBall.Location = new Point(1068, 318);
		cbCrystalBall.Margin = new Padding(3, 4, 3, 4);
		cbCrystalBall.Name = "cbCrystalBall";
		cbCrystalBall.Size = new Size(204, 41);
		cbCrystalBall.TabIndex = 106;
		cbCrystalBall.Text = "Crystal Ball";
		cbCrystalBall.UseVisualStyleBackColor = true;
		// 
		// cbTrophy
		// 
		cbTrophy.AutoSize = true;
		cbTrophy.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
		cbTrophy.Location = new Point(1312, 485);
		cbTrophy.Margin = new Padding(3, 4, 3, 4);
		cbTrophy.Name = "cbTrophy";
		cbTrophy.Size = new Size(143, 41);
		cbTrophy.TabIndex = 107;
		cbTrophy.Text = "Trophy";
		cbTrophy.UseVisualStyleBackColor = true;
		// 
		// cbTicket
		// 
		cbTicket.AutoSize = true;
		cbTicket.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
		cbTicket.Location = new Point(1312, 426);
		cbTicket.Margin = new Padding(3, 4, 3, 4);
		cbTicket.Name = "cbTicket";
		cbTicket.Size = new Size(128, 41);
		cbTicket.TabIndex = 108;
		cbTicket.Text = "Ticket";
		cbTicket.UseVisualStyleBackColor = true;
		// 
		// cbSymbol
		// 
		cbSymbol.AutoSize = true;
		cbSymbol.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
		cbSymbol.Location = new Point(1312, 376);
		cbSymbol.Margin = new Padding(3, 4, 3, 4);
		cbSymbol.Name = "cbSymbol";
		cbSymbol.Size = new Size(149, 41);
		cbSymbol.TabIndex = 109;
		cbSymbol.Text = "Symbol";
		cbSymbol.UseVisualStyleBackColor = true;
		// 
		// cbSunstone
		// 
		cbSunstone.AutoSize = true;
		cbSunstone.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
		cbSunstone.Location = new Point(1312, 318);
		cbSunstone.Margin = new Padding(3, 4, 3, 4);
		cbSunstone.Name = "cbSunstone";
		cbSunstone.Size = new Size(178, 41);
		cbSunstone.TabIndex = 110;
		cbSunstone.Text = "Sunstone";
		cbSunstone.UseVisualStyleBackColor = true;
		// 
		// cbStepladder
		// 
		cbStepladder.AutoSize = true;
		cbStepladder.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
		cbStepladder.Location = new Point(1312, 259);
		cbStepladder.Margin = new Padding(3, 4, 3, 4);
		cbStepladder.Name = "cbStepladder";
		cbStepladder.Size = new Size(197, 41);
		cbStepladder.TabIndex = 111;
		cbStepladder.Text = "Stepladder";
		cbStepladder.UseVisualStyleBackColor = true;
		// 
		// cbSmallDog
		// 
		cbSmallDog.AutoSize = true;
		cbSmallDog.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
		cbSmallDog.Location = new Point(1312, 201);
		cbSmallDog.Margin = new Padding(3, 4, 3, 4);
		cbSmallDog.Name = "cbSmallDog";
		cbSmallDog.Size = new Size(191, 41);
		cbSmallDog.TabIndex = 112;
		cbSmallDog.Text = "Small Dog";
		cbSmallDog.UseVisualStyleBackColor = true;
		// 
		// cbMoonstone
		// 
		cbMoonstone.AutoSize = true;
		cbMoonstone.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
		cbMoonstone.Location = new Point(1312, 146);
		cbMoonstone.Margin = new Padding(3, 4, 3, 4);
		cbMoonstone.Name = "cbMoonstone";
		cbMoonstone.Size = new Size(201, 41);
		cbMoonstone.TabIndex = 113;
		cbMoonstone.Text = "Moonstone";
		cbMoonstone.UseVisualStyleBackColor = true;
		// 
		// cbLamp
		// 
		cbLamp.AutoSize = true;
		cbLamp.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
		cbLamp.Location = new Point(1070, 494);
		cbLamp.Margin = new Padding(3, 4, 3, 4);
		cbLamp.Name = "cbLamp";
		cbLamp.Size = new Size(124, 41);
		cbLamp.TabIndex = 115;
		cbLamp.Text = "Lamp";
		cbLamp.UseVisualStyleBackColor = true;
		// 
		// cbHardDrive
		// 
		cbHardDrive.AutoSize = true;
		cbHardDrive.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
		cbHardDrive.Location = new Point(1068, 435);
		cbHardDrive.Margin = new Padding(3, 4, 3, 4);
		cbHardDrive.Name = "cbHardDrive";
		cbHardDrive.Size = new Size(195, 41);
		cbHardDrive.TabIndex = 116;
		cbHardDrive.Text = "Hard Drive";
		cbHardDrive.UseVisualStyleBackColor = true;
		// 
		// cbFeather
		// 
		cbFeather.AutoSize = true;
		cbFeather.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
		cbFeather.Location = new Point(1068, 376);
		cbFeather.Margin = new Padding(3, 4, 3, 4);
		cbFeather.Name = "cbFeather";
		cbFeather.Size = new Size(153, 41);
		cbFeather.TabIndex = 117;
		cbFeather.Text = "Feather";
		cbFeather.UseVisualStyleBackColor = true;
		// 
		// cbBattery
		// 
		cbBattery.AutoSize = true;
		cbBattery.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
		cbBattery.Location = new Point(1068, 200);
		cbBattery.Margin = new Padding(3, 4, 3, 4);
		cbBattery.Name = "cbBattery";
		cbBattery.Size = new Size(143, 41);
		cbBattery.TabIndex = 118;
		cbBattery.Text = "Battery";
		cbBattery.UseVisualStyleBackColor = true;
		// 
		// cbBalloon
		// 
		cbBalloon.AutoSize = true;
		cbBalloon.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
		cbBalloon.Location = new Point(1068, 141);
		cbBalloon.Margin = new Padding(3, 4, 3, 4);
		cbBalloon.Name = "cbBalloon";
		cbBalloon.Size = new Size(150, 41);
		cbBalloon.TabIndex = 120;
		cbBalloon.Text = "Balloon";
		cbBalloon.UseVisualStyleBackColor = true;
		// 
		// cbBellows
		// 
		cbBellows.AutoSize = true;
		cbBellows.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
		cbBellows.Location = new Point(1068, 259);
		cbBellows.Margin = new Padding(3, 4, 3, 4);
		cbBellows.Name = "cbBellows";
		cbBellows.Size = new Size(152, 41);
		cbBellows.TabIndex = 121;
		cbBellows.Text = "Bellows";
		cbBellows.UseVisualStyleBackColor = true;
		// 
		// txtHeightInches
		// 
		txtHeightInches.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
		txtHeightInches.Location = new Point(437, 331);
		txtHeightInches.Margin = new Padding(3, 4, 3, 4);
		txtHeightInches.Name = "txtHeightInches";
		txtHeightInches.Size = new Size(49, 44);
		txtHeightInches.TabIndex = 122;
		// 
		// label11
		// 
		label11.AutoSize = true;
		label11.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
		label11.Location = new Point(492, 331);
		label11.Name = "label11";
		label11.Size = new Size(28, 37);
		label11.TabIndex = 123;
		label11.Text = "\"";
		// 
		// label12
		// 
		label12.AutoSize = true;
		label12.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
		label12.Location = new Point(401, 331);
		label12.Name = "label12";
		label12.Size = new Size(24, 37);
		label12.TabIndex = 124;
		label12.Text = "'";
		// 
		// frmAdventureGame
		// 
		AutoScaleDimensions = new SizeF(10F, 25F);
		AutoScaleMode = AutoScaleMode.Font;
		AutoSize = true;
		AutoSizeMode = AutoSizeMode.GrowAndShrink;
		ClientSize = new Size(1559, 882);
		Controls.Add(label12);
		Controls.Add(label11);
		Controls.Add(txtHeightInches);
		Controls.Add(cbBellows);
		Controls.Add(cbBalloon);
		Controls.Add(cbBattery);
		Controls.Add(cbFeather);
		Controls.Add(cbHardDrive);
		Controls.Add(cbLamp);
		Controls.Add(cbMoonstone);
		Controls.Add(cbSmallDog);
		Controls.Add(cbStepladder);
		Controls.Add(cbSunstone);
		Controls.Add(cbSymbol);
		Controls.Add(cbTicket);
		Controls.Add(cbTrophy);
		Controls.Add(cbCrystalBall);
		Controls.Add(cbCaber);
		Controls.Add(cbNastyKnife);
		Controls.Add(cbLongbow);
		Controls.Add(cbMagicOrb);
		Controls.Add(cbGrimoire);
		Controls.Add(cbBroadsword);
		Controls.Add(label10);
		Controls.Add(label9);
		Controls.Add(txtDEX);
		Controls.Add(txtINT);
		Controls.Add(txtHeight);
		Controls.Add(txtTemperature);
		Controls.Add(txtGravity);
		Controls.Add(txtPressure);
		Controls.Add(txtSTR);
		Controls.Add(label8);
		Controls.Add(label7);
		Controls.Add(label6);
		Controls.Add(label5);
		Controls.Add(label4);
		Controls.Add(label3);
		Controls.Add(label2);
		Controls.Add(label1);
		Controls.Add(ddMonster);
		Margin = new Padding(3, 5, 3, 5);
		Name = "frmAdventureGame";
		Text = "Adventure Game";
		Load += frmAdventureGame_Load;
		Controls.SetChildIndex(btnSolve, 0);
		Controls.SetChildIndex(btnStrike, 0);
		Controls.SetChildIndex(btnBack, 0);
		Controls.SetChildIndex(ddMonster, 0);
		Controls.SetChildIndex(label1, 0);
		Controls.SetChildIndex(label2, 0);
		Controls.SetChildIndex(label3, 0);
		Controls.SetChildIndex(label4, 0);
		Controls.SetChildIndex(label5, 0);
		Controls.SetChildIndex(label6, 0);
		Controls.SetChildIndex(label7, 0);
		Controls.SetChildIndex(label8, 0);
		Controls.SetChildIndex(txtSTR, 0);
		Controls.SetChildIndex(txtPressure, 0);
		Controls.SetChildIndex(txtGravity, 0);
		Controls.SetChildIndex(txtTemperature, 0);
		Controls.SetChildIndex(txtHeight, 0);
		Controls.SetChildIndex(txtINT, 0);
		Controls.SetChildIndex(txtDEX, 0);
		Controls.SetChildIndex(label9, 0);
		Controls.SetChildIndex(label10, 0);
		Controls.SetChildIndex(cbBroadsword, 0);
		Controls.SetChildIndex(cbGrimoire, 0);
		Controls.SetChildIndex(cbMagicOrb, 0);
		Controls.SetChildIndex(cbLongbow, 0);
		Controls.SetChildIndex(cbNastyKnife, 0);
		Controls.SetChildIndex(cbCaber, 0);
		Controls.SetChildIndex(cbCrystalBall, 0);
		Controls.SetChildIndex(cbTrophy, 0);
		Controls.SetChildIndex(cbTicket, 0);
		Controls.SetChildIndex(cbSymbol, 0);
		Controls.SetChildIndex(cbSunstone, 0);
		Controls.SetChildIndex(cbStepladder, 0);
		Controls.SetChildIndex(cbSmallDog, 0);
		Controls.SetChildIndex(cbMoonstone, 0);
		Controls.SetChildIndex(cbLamp, 0);
		Controls.SetChildIndex(cbHardDrive, 0);
		Controls.SetChildIndex(cbFeather, 0);
		Controls.SetChildIndex(cbBattery, 0);
		Controls.SetChildIndex(cbBalloon, 0);
		Controls.SetChildIndex(cbBellows, 0);
		Controls.SetChildIndex(txtHeightInches, 0);
		Controls.SetChildIndex(label11, 0);
		Controls.SetChildIndex(label12, 0);
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion

	private ComboBox ddMonster;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label label6;
    private Label label7;
    private Label label8;
    private TextBox txtSTR;
    private TextBox txtPressure;
    private TextBox txtGravity;
    private TextBox txtTemperature;
    private TextBox txtHeight;
    private TextBox txtINT;
    private TextBox txtDEX;
    private Label label9;
    private Label label10;
    private CheckBox cbBroadsword;
    private CheckBox cbGrimoire;
    private CheckBox cbMagicOrb;
    private CheckBox cbLongbow;
    private CheckBox cbNastyKnife;
    private CheckBox cbCaber;
    private CheckBox cbCrystalBall;
    private CheckBox cbTrophy;
    private CheckBox cbTicket;
    private CheckBox cbSymbol;
    private CheckBox cbSunstone;
    private CheckBox cbStepladder;
    private CheckBox cbSmallDog;
    private CheckBox cbMoonstone;
    private CheckBox cbLamp;
    private CheckBox cbHardDrive;
    private CheckBox cbFeather;
    private CheckBox cbBattery;
    private CheckBox cbBalloon;
    private CheckBox cbBellows;
	private TextBox txtHeightInches;
	private Label label11;
	private Label label12;
}