namespace Pathfinder_Helper.Forms
{
	partial class CombatTracker
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
			this.label1 = new System.Windows.Forms.Label();
			this.lblTurnNum = new System.Windows.Forms.Label();
			this.txtInitName = new System.Windows.Forms.TextBox();
			this.btnAddInit = new System.Windows.Forms.Button();
			this.btnAddEffect = new System.Windows.Forms.Button();
			this.txtAddEffect = new System.Windows.Forms.TextBox();
			this.numInit = new System.Windows.Forms.NumericUpDown();
			this.numEffect = new System.Windows.Forms.NumericUpDown();
			this.btnReset = new System.Windows.Forms.Button();
			this.BtnEndCombat = new System.Windows.Forms.Button();
			this.txtInitAC = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtInitHP = new System.Windows.Forms.TextBox();
			this.dgInitTracker = new System.Windows.Forms.DataGridView();
			this.Init = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.InitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PC = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.HP = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AC = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ACFlat = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ACTouch = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Fort = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ref = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Will = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Subdual = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BestiaryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IsBeast = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.dgTurnEffects = new System.Windows.Forms.DataGridView();
			this.RoundsRemaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EffectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Target = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label6 = new System.Windows.Forms.Label();
			this.cbxInitPC = new System.Windows.Forms.CheckBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtInitFlat = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtInitTouch = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txtInitSubd = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtInitWill = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txtInitFort = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.txtInitRef = new System.Windows.Forms.TextBox();
			this.btnNextRound = new System.Windows.Forms.Button();
			this.btnSort = new System.Windows.Forms.Button();
			this.btnDuplicate = new System.Windows.Forms.Button();
			this.btnAddBestiary = new System.Windows.Forms.Button();
			this.txtBestiaryId = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.numInit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numEffect)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgInitTracker)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgTurnEffects)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label1.Location = new System.Drawing.Point(12, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Round #";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblTurnNum
			// 
			this.lblTurnNum.AutoSize = true;
			this.lblTurnNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
			this.lblTurnNum.Location = new System.Drawing.Point(88, 6);
			this.lblTurnNum.Name = "lblTurnNum";
			this.lblTurnNum.Size = new System.Drawing.Size(53, 37);
			this.lblTurnNum.TabIndex = 3;
			this.lblTurnNum.Text = "00";
			// 
			// txtInitName
			// 
			this.txtInitName.Location = new System.Drawing.Point(59, 69);
			this.txtInitName.Name = "txtInitName";
			this.txtInitName.Size = new System.Drawing.Size(136, 20);
			this.txtInitName.TabIndex = 4;
			// 
			// btnAddInit
			// 
			this.btnAddInit.Location = new System.Drawing.Point(574, 67);
			this.btnAddInit.Name = "btnAddInit";
			this.btnAddInit.Size = new System.Drawing.Size(41, 23);
			this.btnAddInit.TabIndex = 5;
			this.btnAddInit.Text = "Add";
			this.btnAddInit.UseVisualStyleBackColor = true;
			this.btnAddInit.Click += new System.EventHandler(this.btnAddInit_Click);
			// 
			// btnAddEffect
			// 
			this.btnAddEffect.Location = new System.Drawing.Point(663, 44);
			this.btnAddEffect.Name = "btnAddEffect";
			this.btnAddEffect.Size = new System.Drawing.Size(75, 23);
			this.btnAddEffect.TabIndex = 6;
			this.btnAddEffect.Text = "Add Effect";
			this.btnAddEffect.UseVisualStyleBackColor = true;
			this.btnAddEffect.Click += new System.EventHandler(this.btnAddEffect_Click);
			// 
			// txtAddEffect
			// 
			this.txtAddEffect.Location = new System.Drawing.Point(662, 73);
			this.txtAddEffect.Name = "txtAddEffect";
			this.txtAddEffect.Size = new System.Drawing.Size(209, 20);
			this.txtAddEffect.TabIndex = 7;
			// 
			// numInit
			// 
			this.numInit.Location = new System.Drawing.Point(15, 69);
			this.numInit.Name = "numInit";
			this.numInit.Size = new System.Drawing.Size(38, 20);
			this.numInit.TabIndex = 8;
			// 
			// numEffect
			// 
			this.numEffect.Location = new System.Drawing.Point(833, 47);
			this.numEffect.Name = "numEffect";
			this.numEffect.Size = new System.Drawing.Size(38, 20);
			this.numEffect.TabIndex = 9;
			this.numEffect.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(797, 9);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(75, 23);
			this.btnReset.TabIndex = 10;
			this.btnReset.Text = "RESET ALL";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// BtnEndCombat
			// 
			this.BtnEndCombat.Location = new System.Drawing.Point(663, 9);
			this.BtnEndCombat.Name = "BtnEndCombat";
			this.BtnEndCombat.Size = new System.Drawing.Size(75, 23);
			this.BtnEndCombat.TabIndex = 11;
			this.BtnEndCombat.Text = "End Combat";
			this.BtnEndCombat.UseVisualStyleBackColor = true;
			this.BtnEndCombat.Click += new System.EventHandler(this.BtnClearNpcs_Click);
			// 
			// txtInitAC
			// 
			this.txtInitAC.Location = new System.Drawing.Point(266, 69);
			this.txtInitAC.Name = "txtInitAC";
			this.txtInitAC.Size = new System.Drawing.Size(38, 20);
			this.txtInitAC.TabIndex = 12;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(56, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 13;
			this.label2.Text = "Name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(783, 49);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 13);
			this.label3.TabIndex = 14;
			this.label3.Text = "Rounds";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(263, 49);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(21, 13);
			this.label4.TabIndex = 15;
			this.label4.Text = "AC";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(225, 49);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(22, 13);
			this.label5.TabIndex = 17;
			this.label5.Text = "HP";
			// 
			// txtInitHP
			// 
			this.txtInitHP.Location = new System.Drawing.Point(222, 69);
			this.txtInitHP.Name = "txtInitHP";
			this.txtInitHP.Size = new System.Drawing.Size(38, 20);
			this.txtInitHP.TabIndex = 16;
			// 
			// dgInitTracker
			// 
			this.dgInitTracker.AllowUserToAddRows = false;
			this.dgInitTracker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgInitTracker.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Init,
            this.InitName,
            this.PC,
            this.HP,
            this.AC,
            this.ACFlat,
            this.ACTouch,
            this.Fort,
            this.Ref,
            this.Will,
            this.Subdual,
            this.BestiaryId,
            this.IsBeast});
			this.dgInitTracker.Location = new System.Drawing.Point(15, 95);
			this.dgInitTracker.Name = "dgInitTracker";
			this.dgInitTracker.RowHeadersWidth = 25;
			this.dgInitTracker.Size = new System.Drawing.Size(599, 330);
			this.dgInitTracker.TabIndex = 18;
			this.dgInitTracker.DoubleClick += new System.EventHandler(this.dgInitTracker_DoubleClick);
			this.dgInitTracker.MouseHover += new System.EventHandler(this.dgInitTracker_MouseHover);
			// 
			// Init
			// 
			this.Init.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Init.DataPropertyName = "Init";
			this.Init.HeaderText = "Init";
			this.Init.Name = "Init";
			this.Init.Width = 46;
			// 
			// InitName
			// 
			this.InitName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.InitName.DataPropertyName = "InitName";
			this.InitName.HeaderText = "Name";
			this.InitName.Name = "InitName";
			// 
			// PC
			// 
			this.PC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.PC.DataPropertyName = "PC";
			this.PC.HeaderText = "PC?";
			this.PC.Name = "PC";
			this.PC.Width = 33;
			// 
			// HP
			// 
			this.HP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.HP.DataPropertyName = "HP";
			this.HP.HeaderText = "HP";
			this.HP.Name = "HP";
			this.HP.Width = 47;
			// 
			// AC
			// 
			this.AC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.AC.DataPropertyName = "AC";
			this.AC.HeaderText = "AC";
			this.AC.Name = "AC";
			this.AC.Width = 46;
			// 
			// ACFlat
			// 
			this.ACFlat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.ACFlat.DataPropertyName = "ACFlat";
			this.ACFlat.HeaderText = "ACFlat";
			this.ACFlat.Name = "ACFlat";
			this.ACFlat.Visible = false;
			// 
			// ACTouch
			// 
			this.ACTouch.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.ACTouch.DataPropertyName = "ACTouch";
			this.ACTouch.HeaderText = "ACTouch";
			this.ACTouch.Name = "ACTouch";
			this.ACTouch.Visible = false;
			// 
			// Fort
			// 
			this.Fort.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Fort.DataPropertyName = "Fort";
			this.Fort.HeaderText = "Fort";
			this.Fort.Name = "Fort";
			this.Fort.Width = 50;
			// 
			// Ref
			// 
			this.Ref.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Ref.DataPropertyName = "Ref";
			this.Ref.HeaderText = "Ref";
			this.Ref.Name = "Ref";
			this.Ref.Width = 49;
			// 
			// Will
			// 
			this.Will.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Will.DataPropertyName = "Will";
			this.Will.HeaderText = "Will";
			this.Will.Name = "Will";
			this.Will.Width = 49;
			// 
			// Subdual
			// 
			this.Subdual.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Subdual.DataPropertyName = "Subdual";
			this.Subdual.HeaderText = "Subd";
			this.Subdual.Name = "Subdual";
			this.Subdual.Width = 57;
			// 
			// BestiaryId
			// 
			this.BestiaryId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.BestiaryId.DataPropertyName = "BestiaryId";
			this.BestiaryId.HeaderText = "BestiaryId";
			this.BestiaryId.Name = "BestiaryId";
			this.BestiaryId.Visible = false;
			// 
			// IsBeast
			// 
			this.IsBeast.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.IsBeast.DataPropertyName = "IsBeast";
			this.IsBeast.HeaderText = "IsBeast";
			this.IsBeast.Name = "IsBeast";
			this.IsBeast.Visible = false;
			// 
			// dgTurnEffects
			// 
			this.dgTurnEffects.AllowUserToAddRows = false;
			this.dgTurnEffects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgTurnEffects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoundsRemaining,
            this.EffectName,
            this.Target});
			this.dgTurnEffects.Location = new System.Drawing.Point(664, 95);
			this.dgTurnEffects.Name = "dgTurnEffects";
			this.dgTurnEffects.RowHeadersVisible = false;
			this.dgTurnEffects.Size = new System.Drawing.Size(208, 330);
			this.dgTurnEffects.TabIndex = 19;
			this.dgTurnEffects.DoubleClick += new System.EventHandler(this.dgTurnEffects_DoubleClick);
			// 
			// RoundsRemaining
			// 
			this.RoundsRemaining.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.RoundsRemaining.DataPropertyName = "RoundsRemaining";
			this.RoundsRemaining.HeaderText = "Rounds";
			this.RoundsRemaining.Name = "RoundsRemaining";
			this.RoundsRemaining.Width = 69;
			// 
			// EffectName
			// 
			this.EffectName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.EffectName.DataPropertyName = "EffectName";
			this.EffectName.HeaderText = "Effect";
			this.EffectName.Name = "EffectName";
			// 
			// Target
			// 
			this.Target.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Target.DataPropertyName = "Target";
			this.Target.HeaderText = "Target";
			this.Target.Name = "Target";
			this.Target.Width = 63;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 49);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(21, 13);
			this.label6.TabIndex = 20;
			this.label6.Text = "Init";
			// 
			// cbxInitPC
			// 
			this.cbxInitPC.AutoSize = true;
			this.cbxInitPC.Location = new System.Drawing.Point(201, 72);
			this.cbxInitPC.Name = "cbxInitPC";
			this.cbxInitPC.Size = new System.Drawing.Size(15, 14);
			this.cbxInitPC.TabIndex = 21;
			this.cbxInitPC.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(198, 49);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(21, 13);
			this.label7.TabIndex = 22;
			this.label7.Text = "PC";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(307, 49);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(24, 13);
			this.label8.TabIndex = 24;
			this.label8.Text = "Flat";
			// 
			// txtInitFlat
			// 
			this.txtInitFlat.Location = new System.Drawing.Point(310, 69);
			this.txtInitFlat.Name = "txtInitFlat";
			this.txtInitFlat.Size = new System.Drawing.Size(38, 20);
			this.txtInitFlat.TabIndex = 23;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(351, 49);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(38, 13);
			this.label9.TabIndex = 26;
			this.label9.Text = "Touch";
			// 
			// txtInitTouch
			// 
			this.txtInitTouch.Location = new System.Drawing.Point(354, 69);
			this.txtInitTouch.Name = "txtInitTouch";
			this.txtInitTouch.Size = new System.Drawing.Size(38, 20);
			this.txtInitTouch.TabIndex = 25;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(527, 49);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(32, 13);
			this.label10.TabIndex = 34;
			this.label10.Text = "Subd";
			// 
			// txtInitSubd
			// 
			this.txtInitSubd.Location = new System.Drawing.Point(530, 69);
			this.txtInitSubd.Name = "txtInitSubd";
			this.txtInitSubd.Size = new System.Drawing.Size(38, 20);
			this.txtInitSubd.TabIndex = 33;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(483, 49);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(24, 13);
			this.label11.TabIndex = 32;
			this.label11.Text = "Will";
			// 
			// txtInitWill
			// 
			this.txtInitWill.Location = new System.Drawing.Point(486, 69);
			this.txtInitWill.Name = "txtInitWill";
			this.txtInitWill.Size = new System.Drawing.Size(38, 20);
			this.txtInitWill.TabIndex = 31;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(401, 49);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(25, 13);
			this.label12.TabIndex = 30;
			this.label12.Text = "Fort";
			// 
			// txtInitFort
			// 
			this.txtInitFort.Location = new System.Drawing.Point(398, 69);
			this.txtInitFort.Name = "txtInitFort";
			this.txtInitFort.Size = new System.Drawing.Size(38, 20);
			this.txtInitFort.TabIndex = 29;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(439, 49);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(24, 13);
			this.label13.TabIndex = 28;
			this.label13.Text = "Ref";
			// 
			// txtInitRef
			// 
			this.txtInitRef.Location = new System.Drawing.Point(442, 69);
			this.txtInitRef.Name = "txtInitRef";
			this.txtInitRef.Size = new System.Drawing.Size(38, 20);
			this.txtInitRef.TabIndex = 27;
			// 
			// btnNextRound
			// 
			this.btnNextRound.Location = new System.Drawing.Point(147, 6);
			this.btnNextRound.Name = "btnNextRound";
			this.btnNextRound.Size = new System.Drawing.Size(98, 37);
			this.btnNextRound.TabIndex = 35;
			this.btnNextRound.Text = "NEXT ROUND";
			this.btnNextRound.UseVisualStyleBackColor = true;
			this.btnNextRound.Click += new System.EventHandler(this.btnNextTurn_Click);
			// 
			// btnSort
			// 
			this.btnSort.Location = new System.Drawing.Point(15, 432);
			this.btnSort.Name = "btnSort";
			this.btnSort.Size = new System.Drawing.Size(75, 23);
			this.btnSort.TabIndex = 36;
			this.btnSort.Text = "Sort";
			this.btnSort.UseVisualStyleBackColor = true;
			this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
			// 
			// btnDuplicate
			// 
			this.btnDuplicate.Location = new System.Drawing.Point(96, 432);
			this.btnDuplicate.Name = "btnDuplicate";
			this.btnDuplicate.Size = new System.Drawing.Size(75, 23);
			this.btnDuplicate.TabIndex = 37;
			this.btnDuplicate.Text = "Duplicate";
			this.btnDuplicate.UseVisualStyleBackColor = true;
			this.btnDuplicate.Click += new System.EventHandler(this.btnDuplicate_Click);
			// 
			// btnAddBestiary
			// 
			this.btnAddBestiary.Location = new System.Drawing.Point(540, 432);
			this.btnAddBestiary.Name = "btnAddBestiary";
			this.btnAddBestiary.Size = new System.Drawing.Size(75, 23);
			this.btnAddBestiary.TabIndex = 38;
			this.btnAddBestiary.Text = "Add Bestiary";
			this.btnAddBestiary.UseVisualStyleBackColor = true;
			this.btnAddBestiary.Click += new System.EventHandler(this.btnAddBestiary_Click);
			// 
			// txtBestiaryId
			// 
			this.txtBestiaryId.Location = new System.Drawing.Point(459, 435);
			this.txtBestiaryId.Name = "txtBestiaryId";
			this.txtBestiaryId.Size = new System.Drawing.Size(75, 20);
			this.txtBestiaryId.TabIndex = 39;
			this.txtBestiaryId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBestiaryId_KeyPress);
			// 
			// CombatTracker
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 462);
			this.Controls.Add(this.txtBestiaryId);
			this.Controls.Add(this.btnAddBestiary);
			this.Controls.Add(this.btnDuplicate);
			this.Controls.Add(this.btnSort);
			this.Controls.Add(this.btnNextRound);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.txtInitSubd);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.txtInitWill);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.txtInitFort);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.txtInitRef);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.txtInitTouch);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtInitFlat);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.cbxInitPC);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtInitHP);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtInitAC);
			this.Controls.Add(this.BtnEndCombat);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.numEffect);
			this.Controls.Add(this.numInit);
			this.Controls.Add(this.txtAddEffect);
			this.Controls.Add(this.btnAddEffect);
			this.Controls.Add(this.btnAddInit);
			this.Controls.Add(this.txtInitName);
			this.Controls.Add(this.lblTurnNum);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgInitTracker);
			this.Controls.Add(this.dgTurnEffects);
			this.Name = "CombatTracker";
			this.Text = "CombatTracker";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CombatTracker_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.numInit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numEffect)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgInitTracker)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgTurnEffects)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblTurnNum;
		private System.Windows.Forms.TextBox txtInitName;
		private System.Windows.Forms.Button btnAddInit;
		private System.Windows.Forms.Button btnAddEffect;
		private System.Windows.Forms.TextBox txtAddEffect;
		private System.Windows.Forms.NumericUpDown numInit;
		private System.Windows.Forms.NumericUpDown numEffect;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Button BtnEndCombat;
		private System.Windows.Forms.TextBox txtInitAC;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtInitHP;
		private System.Windows.Forms.DataGridView dgInitTracker;
		private System.Windows.Forms.DataGridView dgTurnEffects;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.CheckBox cbxInitPC;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtInitFlat;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtInitTouch;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtInitSubd;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtInitWill;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtInitFort;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txtInitRef;
		private System.Windows.Forms.Button btnNextRound;
		private System.Windows.Forms.DataGridViewTextBoxColumn Init;
		private System.Windows.Forms.DataGridViewTextBoxColumn InitName;
		private System.Windows.Forms.DataGridViewCheckBoxColumn PC;
		private System.Windows.Forms.DataGridViewTextBoxColumn HP;
		private System.Windows.Forms.DataGridViewTextBoxColumn AC;
		private System.Windows.Forms.DataGridViewTextBoxColumn ACFlat;
		private System.Windows.Forms.DataGridViewTextBoxColumn ACTouch;
		private System.Windows.Forms.DataGridViewTextBoxColumn Fort;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ref;
		private System.Windows.Forms.DataGridViewTextBoxColumn Will;
		private System.Windows.Forms.DataGridViewTextBoxColumn Subdual;
		private System.Windows.Forms.DataGridViewTextBoxColumn BestiaryId;
		private System.Windows.Forms.DataGridViewCheckBoxColumn IsBeast;
		private System.Windows.Forms.DataGridViewTextBoxColumn RoundsRemaining;
		private System.Windows.Forms.DataGridViewTextBoxColumn EffectName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Target;
		private System.Windows.Forms.Button btnSort;
		private System.Windows.Forms.Button btnDuplicate;
		private System.Windows.Forms.Button btnAddBestiary;
		private System.Windows.Forms.TextBox txtBestiaryId;
	}
}