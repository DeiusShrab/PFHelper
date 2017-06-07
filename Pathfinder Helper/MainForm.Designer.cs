namespace Pathfinder_Helper
{
    partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			this.lbxRoll = new System.Windows.Forms.ListBox();
			this.txtDay = new System.Windows.Forms.TextBox();
			this.btnRoll20 = new System.Windows.Forms.Button();
			this.lblDate = new System.Windows.Forms.Label();
			this.btnNextDay = new System.Windows.Forms.Button();
			this.btnAddDays = new System.Windows.Forms.Button();
			this.btnChangeWeather = new System.Windows.Forms.Button();
			this.lbxContinent = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblWeather = new System.Windows.Forms.Label();
			this.tbColEncounter = new System.Windows.Forms.TabControl();
			this.tabEasy = new System.Windows.Forms.TabPage();
			this.lbxEasy = new System.Windows.Forms.ListBox();
			this.tabMed = new System.Windows.Forms.TabPage();
			this.lbxMed = new System.Windows.Forms.ListBox();
			this.tabHard = new System.Windows.Forms.TabPage();
			this.lbxHard = new System.Windows.Forms.ListBox();
			this.btnEncounter = new System.Windows.Forms.Button();
			this.txtApl = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.lbxMon = new System.Windows.Forms.ListBox();
			this.btnClearMon = new System.Windows.Forms.Button();
			this.cbxMonZone = new System.Windows.Forms.CheckBox();
			this.cbxMonGroup = new System.Windows.Forms.CheckBox();
			this.btnSpawnNpcs = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.lblPercEnc = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblEncNpc = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.lblMysterious = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.lblMoon = new System.Windows.Forms.Label();
			this.lblRations = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.btnAddToCombat = new System.Windows.Forms.Button();
			this.btnCombatTracker = new System.Windows.Forms.Button();
			this.txtRationAdd = new System.Windows.Forms.TextBox();
			this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
			this.MenuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.creaturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.continentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.weatherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ttMon = new System.Windows.Forms.ToolTip(this.components);
			this.tbColEncounter.SuspendLayout();
			this.tabEasy.SuspendLayout();
			this.tabMed.SuspendLayout();
			this.tabHard.SuspendLayout();
			this.MenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbxRoll
			// 
			this.lbxRoll.FormattingEnabled = true;
			this.lbxRoll.Location = new System.Drawing.Point(811, 36);
			this.lbxRoll.Name = "lbxRoll";
			this.lbxRoll.Size = new System.Drawing.Size(101, 303);
			this.lbxRoll.TabIndex = 0;
			// 
			// txtDay
			// 
			this.txtDay.Location = new System.Drawing.Point(637, 74);
			this.txtDay.Name = "txtDay";
			this.txtDay.Size = new System.Drawing.Size(62, 20);
			this.txtDay.TabIndex = 1;
			// 
			// btnRoll20
			// 
			this.btnRoll20.Location = new System.Drawing.Point(811, 345);
			this.btnRoll20.Name = "btnRoll20";
			this.btnRoll20.Size = new System.Drawing.Size(101, 23);
			this.btnRoll20.TabIndex = 3;
			this.btnRoll20.Text = "Generate d20s";
			this.btnRoll20.UseVisualStyleBackColor = true;
			this.btnRoll20.Click += new System.EventHandler(this.btnRoll20_Click);
			// 
			// lblDate
			// 
			this.lblDate.AutoSize = true;
			this.lblDate.Font = new System.Drawing.Font("Old English Text MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDate.Location = new System.Drawing.Point(9, 33);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(796, 38);
			this.lblDate.TabIndex = 4;
			this.lblDate.Text = "Year: 0000 AA; Season of Fire, Month of Embers, Day 00";
			// 
			// btnNextDay
			// 
			this.btnNextDay.Location = new System.Drawing.Point(705, 74);
			this.btnNextDay.Name = "btnNextDay";
			this.btnNextDay.Size = new System.Drawing.Size(100, 49);
			this.btnNextDay.TabIndex = 5;
			this.btnNextDay.Text = "NEXT DAY";
			this.btnNextDay.UseVisualStyleBackColor = true;
			this.btnNextDay.Click += new System.EventHandler(this.btnNextDay_Click);
			// 
			// btnAddDays
			// 
			this.btnAddDays.Location = new System.Drawing.Point(637, 100);
			this.btnAddDays.Name = "btnAddDays";
			this.btnAddDays.Size = new System.Drawing.Size(62, 23);
			this.btnAddDays.TabIndex = 6;
			this.btnAddDays.Text = "Add Days";
			this.btnAddDays.UseVisualStyleBackColor = true;
			this.btnAddDays.Click += new System.EventHandler(this.btnAddDays_Click);
			// 
			// btnChangeWeather
			// 
			this.btnChangeWeather.Location = new System.Drawing.Point(9, 93);
			this.btnChangeWeather.Name = "btnChangeWeather";
			this.btnChangeWeather.Size = new System.Drawing.Size(104, 23);
			this.btnChangeWeather.TabIndex = 7;
			this.btnChangeWeather.Text = "Change Weather";
			this.btnChangeWeather.UseVisualStyleBackColor = true;
			this.btnChangeWeather.Click += new System.EventHandler(this.btnChangeWeather_Click);
			// 
			// lbxContinent
			// 
			this.lbxContinent.FormattingEnabled = true;
			this.lbxContinent.Location = new System.Drawing.Point(698, 153);
			this.lbxContinent.Name = "lbxContinent";
			this.lbxContinent.Size = new System.Drawing.Size(107, 186);
			this.lbxContinent.TabIndex = 8;
			this.lbxContinent.SelectedIndexChanged += new System.EventHandler(this.lbxContinent_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(695, 137);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "Current Continent:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 77);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "Current Weather:";
			// 
			// lblWeather
			// 
			this.lblWeather.AutoSize = true;
			this.lblWeather.Location = new System.Drawing.Point(103, 77);
			this.lblWeather.Name = "lblWeather";
			this.lblWeather.Size = new System.Drawing.Size(62, 13);
			this.lblWeather.TabIndex = 10;
			this.lblWeather.Text = "WEATHER";
			// 
			// tbColEncounter
			// 
			this.tbColEncounter.Controls.Add(this.tabEasy);
			this.tbColEncounter.Controls.Add(this.tabMed);
			this.tbColEncounter.Controls.Add(this.tabHard);
			this.tbColEncounter.Location = new System.Drawing.Point(8, 161);
			this.tbColEncounter.Name = "tbColEncounter";
			this.tbColEncounter.SelectedIndex = 0;
			this.tbColEncounter.Size = new System.Drawing.Size(305, 400);
			this.tbColEncounter.TabIndex = 12;
			// 
			// tabEasy
			// 
			this.tabEasy.Controls.Add(this.lbxEasy);
			this.tabEasy.Location = new System.Drawing.Point(4, 22);
			this.tabEasy.Name = "tabEasy";
			this.tabEasy.Padding = new System.Windows.Forms.Padding(3);
			this.tabEasy.Size = new System.Drawing.Size(297, 374);
			this.tabEasy.TabIndex = 0;
			this.tabEasy.Text = "Easy";
			this.tabEasy.UseVisualStyleBackColor = true;
			// 
			// lbxEasy
			// 
			this.lbxEasy.FormattingEnabled = true;
			this.lbxEasy.Location = new System.Drawing.Point(4, 4);
			this.lbxEasy.Name = "lbxEasy";
			this.lbxEasy.Size = new System.Drawing.Size(290, 368);
			this.lbxEasy.TabIndex = 0;
			this.lbxEasy.DoubleClick += new System.EventHandler(this.lbxEasy_DoubleClick);
			// 
			// tabMed
			// 
			this.tabMed.Controls.Add(this.lbxMed);
			this.tabMed.Location = new System.Drawing.Point(4, 22);
			this.tabMed.Name = "tabMed";
			this.tabMed.Padding = new System.Windows.Forms.Padding(3);
			this.tabMed.Size = new System.Drawing.Size(297, 374);
			this.tabMed.TabIndex = 1;
			this.tabMed.Text = "Medium";
			this.tabMed.UseVisualStyleBackColor = true;
			// 
			// lbxMed
			// 
			this.lbxMed.FormattingEnabled = true;
			this.lbxMed.Location = new System.Drawing.Point(4, 4);
			this.lbxMed.Name = "lbxMed";
			this.lbxMed.Size = new System.Drawing.Size(290, 368);
			this.lbxMed.TabIndex = 0;
			this.lbxMed.DoubleClick += new System.EventHandler(this.lbxMed_DoubleClick);
			// 
			// tabHard
			// 
			this.tabHard.Controls.Add(this.lbxHard);
			this.tabHard.Location = new System.Drawing.Point(4, 22);
			this.tabHard.Name = "tabHard";
			this.tabHard.Padding = new System.Windows.Forms.Padding(3);
			this.tabHard.Size = new System.Drawing.Size(297, 374);
			this.tabHard.TabIndex = 2;
			this.tabHard.Text = "Hard";
			this.tabHard.UseVisualStyleBackColor = true;
			// 
			// lbxHard
			// 
			this.lbxHard.FormattingEnabled = true;
			this.lbxHard.Location = new System.Drawing.Point(4, 4);
			this.lbxHard.Name = "lbxHard";
			this.lbxHard.Size = new System.Drawing.Size(290, 368);
			this.lbxHard.TabIndex = 0;
			this.lbxHard.DoubleClick += new System.EventHandler(this.lbxHard_DoubleClick);
			// 
			// btnEncounter
			// 
			this.btnEncounter.Location = new System.Drawing.Point(85, 132);
			this.btnEncounter.Name = "btnEncounter";
			this.btnEncounter.Size = new System.Drawing.Size(124, 23);
			this.btnEncounter.TabIndex = 13;
			this.btnEncounter.Text = "Generate Encounters";
			this.btnEncounter.UseVisualStyleBackColor = true;
			this.btnEncounter.Click += new System.EventHandler(this.btnEncounter_Click);
			// 
			// txtApl
			// 
			this.txtApl.Location = new System.Drawing.Point(44, 134);
			this.txtApl.Name = "txtApl";
			this.txtApl.Size = new System.Drawing.Size(35, 20);
			this.txtApl.TabIndex = 14;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 137);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(30, 13);
			this.label3.TabIndex = 15;
			this.label3.Text = "APL:";
			// 
			// lbxMon
			// 
			this.lbxMon.FormattingEnabled = true;
			this.lbxMon.Location = new System.Drawing.Point(319, 179);
			this.lbxMon.Name = "lbxMon";
			this.lbxMon.Size = new System.Drawing.Size(373, 381);
			this.lbxMon.TabIndex = 16;
			this.lbxMon.DoubleClick += new System.EventHandler(this.lbxMon_DoubleClick);
			this.lbxMon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbxMon_MouseMove);
			// 
			// btnClearMon
			// 
			this.btnClearMon.Location = new System.Drawing.Point(698, 508);
			this.btnClearMon.Name = "btnClearMon";
			this.btnClearMon.Size = new System.Drawing.Size(75, 23);
			this.btnClearMon.TabIndex = 17;
			this.btnClearMon.Text = "<-- Clear";
			this.btnClearMon.UseVisualStyleBackColor = true;
			this.btnClearMon.Click += new System.EventHandler(this.btnClearMon_Click);
			// 
			// cbxMonZone
			// 
			this.cbxMonZone.AutoSize = true;
			this.cbxMonZone.Location = new System.Drawing.Point(215, 136);
			this.cbxMonZone.Name = "cbxMonZone";
			this.cbxMonZone.Size = new System.Drawing.Size(80, 17);
			this.cbxMonZone.TabIndex = 18;
			this.cbxMonZone.Text = "Zone Mobs";
			this.cbxMonZone.UseVisualStyleBackColor = true;
			// 
			// cbxMonGroup
			// 
			this.cbxMonGroup.AutoSize = true;
			this.cbxMonGroup.Location = new System.Drawing.Point(215, 113);
			this.cbxMonGroup.Name = "cbxMonGroup";
			this.cbxMonGroup.Size = new System.Drawing.Size(84, 17);
			this.cbxMonGroup.TabIndex = 19;
			this.cbxMonGroup.Text = "Group Mobs";
			this.cbxMonGroup.UseVisualStyleBackColor = true;
			// 
			// btnSpawnNpcs
			// 
			this.btnSpawnNpcs.Location = new System.Drawing.Point(319, 150);
			this.btnSpawnNpcs.Name = "btnSpawnNpcs";
			this.btnSpawnNpcs.Size = new System.Drawing.Size(148, 23);
			this.btnSpawnNpcs.TabIndex = 20;
			this.btnSpawnNpcs.Text = "Generate NPC Encounter";
			this.btnSpawnNpcs.UseVisualStyleBackColor = true;
			this.btnSpawnNpcs.Click += new System.EventHandler(this.btnSpawnNpcs_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(702, 345);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 13);
			this.label4.TabIndex = 21;
			this.label4.Text = "Encounter %";
			// 
			// lblPercEnc
			// 
			this.lblPercEnc.AutoSize = true;
			this.lblPercEnc.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPercEnc.Location = new System.Drawing.Point(707, 358);
			this.lblPercEnc.Name = "lblPercEnc";
			this.lblPercEnc.Size = new System.Drawing.Size(53, 37);
			this.lblPercEnc.TabIndex = 22;
			this.lblPercEnc.Text = "99";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(698, 395);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(76, 13);
			this.label5.TabIndex = 21;
			this.label5.Text = "NPC Spawn %";
			// 
			// lblEncNpc
			// 
			this.lblEncNpc.AutoSize = true;
			this.lblEncNpc.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEncNpc.Location = new System.Drawing.Point(707, 408);
			this.lblEncNpc.Name = "lblEncNpc";
			this.lblEncNpc.Size = new System.Drawing.Size(53, 37);
			this.lblEncNpc.TabIndex = 22;
			this.lblEncNpc.Text = "99";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(698, 445);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(79, 13);
			this.label6.TabIndex = 21;
			this.label6.Text = "Mysterious Enc";
			// 
			// lblMysterious
			// 
			this.lblMysterious.AutoSize = true;
			this.lblMysterious.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMysterious.Location = new System.Drawing.Point(698, 458);
			this.lblMysterious.Name = "lblMysterious";
			this.lblMysterious.Size = new System.Drawing.Size(72, 37);
			this.lblMysterious.TabIndex = 22;
			this.lblMysterious.Text = "N/A";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(316, 77);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(70, 13);
			this.label7.TabIndex = 23;
			this.label7.Text = "Lunar Phase:";
			// 
			// lblMoon
			// 
			this.lblMoon.AutoSize = true;
			this.lblMoon.Location = new System.Drawing.Point(392, 77);
			this.lblMoon.Name = "lblMoon";
			this.lblMoon.Size = new System.Drawing.Size(40, 13);
			this.lblMoon.TabIndex = 23;
			this.lblMoon.Text = "MOON";
			// 
			// lblRations
			// 
			this.lblRations.AutoSize = true;
			this.lblRations.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRations.Location = new System.Drawing.Point(639, 137);
			this.lblRations.Name = "lblRations";
			this.lblRations.Size = new System.Drawing.Size(53, 37);
			this.lblRations.TabIndex = 25;
			this.lblRations.Text = "99";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(568, 138);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(46, 13);
			this.label8.TabIndex = 26;
			this.label8.Text = "Rations:";
			// 
			// btnAddToCombat
			// 
			this.btnAddToCombat.Location = new System.Drawing.Point(698, 537);
			this.btnAddToCombat.Name = "btnAddToCombat";
			this.btnAddToCombat.Size = new System.Drawing.Size(75, 23);
			this.btnAddToCombat.TabIndex = 29;
			this.btnAddToCombat.Text = "Add -->";
			this.btnAddToCombat.UseVisualStyleBackColor = true;
			this.btnAddToCombat.Click += new System.EventHandler(this.btnAddToCombat_Click);
			// 
			// btnCombatTracker
			// 
			this.btnCombatTracker.Location = new System.Drawing.Point(805, 537);
			this.btnCombatTracker.Name = "btnCombatTracker";
			this.btnCombatTracker.Size = new System.Drawing.Size(107, 23);
			this.btnCombatTracker.TabIndex = 28;
			this.btnCombatTracker.Text = "Combat Tracker";
			this.btnCombatTracker.UseVisualStyleBackColor = true;
			this.btnCombatTracker.Click += new System.EventHandler(this.btnCombatTracker_Click);
			// 
			// txtRationAdd
			// 
			this.txtRationAdd.Location = new System.Drawing.Point(571, 154);
			this.txtRationAdd.Name = "txtRationAdd";
			this.txtRationAdd.Size = new System.Drawing.Size(43, 20);
			this.txtRationAdd.TabIndex = 24;
			// 
			// vScrollBar1
			// 
			this.vScrollBar1.Location = new System.Drawing.Point(617, 138);
			this.vScrollBar1.Name = "vScrollBar1";
			this.vScrollBar1.Size = new System.Drawing.Size(19, 34);
			this.vScrollBar1.TabIndex = 27;
			this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
			// 
			// MenuStrip
			// 
			this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.manageToolStripMenuItem});
			this.MenuStrip.Location = new System.Drawing.Point(0, 0);
			this.MenuStrip.Name = "MenuStrip";
			this.MenuStrip.Size = new System.Drawing.Size(924, 24);
			this.MenuStrip.TabIndex = 30;
			this.MenuStrip.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem1
			// 
			this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem1,
            this.exitToolStripMenuItem1});
			this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
			this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem1.Text = "File";
			// 
			// saveToolStripMenuItem1
			// 
			this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
			this.saveToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.saveToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
			this.saveToolStripMenuItem1.Text = "Save";
			// 
			// exitToolStripMenuItem1
			// 
			this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
			this.exitToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
			this.exitToolStripMenuItem1.Text = "Exit";
			// 
			// manageToolStripMenuItem
			// 
			this.manageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creaturesToolStripMenuItem,
            this.continentsToolStripMenuItem,
            this.weatherToolStripMenuItem});
			this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
			this.manageToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
			this.manageToolStripMenuItem.Text = "Manage";
			// 
			// creaturesToolStripMenuItem
			// 
			this.creaturesToolStripMenuItem.Name = "creaturesToolStripMenuItem";
			this.creaturesToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.creaturesToolStripMenuItem.Text = "Creatures";
			this.creaturesToolStripMenuItem.Click += new System.EventHandler(this.creaturesToolStripMenuItem_Click);
			// 
			// continentsToolStripMenuItem
			// 
			this.continentsToolStripMenuItem.Name = "continentsToolStripMenuItem";
			this.continentsToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.continentsToolStripMenuItem.Text = "Continents";
			// 
			// weatherToolStripMenuItem
			// 
			this.weatherToolStripMenuItem.Name = "weatherToolStripMenuItem";
			this.weatherToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.weatherToolStripMenuItem.Text = "Weather";
			this.weatherToolStripMenuItem.Click += new System.EventHandler(this.weatherToolStripMenuItem_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(924, 572);
			this.Controls.Add(this.MenuStrip);
			this.Controls.Add(this.btnAddToCombat);
			this.Controls.Add(this.btnCombatTracker);
			this.Controls.Add(this.vScrollBar1);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.lblRations);
			this.Controls.Add(this.txtRationAdd);
			this.Controls.Add(this.lblMoon);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.lblMysterious);
			this.Controls.Add(this.lblEncNpc);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lblPercEnc);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnSpawnNpcs);
			this.Controls.Add(this.cbxMonGroup);
			this.Controls.Add(this.cbxMonZone);
			this.Controls.Add(this.btnClearMon);
			this.Controls.Add(this.lbxMon);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtApl);
			this.Controls.Add(this.btnEncounter);
			this.Controls.Add(this.tbColEncounter);
			this.Controls.Add(this.lblWeather);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lbxContinent);
			this.Controls.Add(this.btnChangeWeather);
			this.Controls.Add(this.btnAddDays);
			this.Controls.Add(this.btnNextDay);
			this.Controls.Add(this.lblDate);
			this.Controls.Add(this.btnRoll20);
			this.Controls.Add(this.txtDay);
			this.Controls.Add(this.lbxRoll);
			this.MainMenuStrip = this.MenuStrip;
			this.Name = "MainForm";
			this.Text = "Pathfinder Helper (Reign of Shadows)";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnClose);
			this.tbColEncounter.ResumeLayout(false);
			this.tabEasy.ResumeLayout(false);
			this.tabMed.ResumeLayout(false);
			this.tabHard.ResumeLayout(false);
			this.MenuStrip.ResumeLayout(false);
			this.MenuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxRoll;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.Button btnRoll20;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnNextDay;
        private System.Windows.Forms.Button btnAddDays;
        private System.Windows.Forms.Button btnChangeWeather;
        private System.Windows.Forms.ListBox lbxContinent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWeather;
        private System.Windows.Forms.TabControl tbColEncounter;
        private System.Windows.Forms.TabPage tabEasy;
        private System.Windows.Forms.TabPage tabMed;
        private System.Windows.Forms.ListBox lbxMed;
        private System.Windows.Forms.TabPage tabHard;
        private System.Windows.Forms.ListBox lbxHard;
        private System.Windows.Forms.Button btnEncounter;
        private System.Windows.Forms.TextBox txtApl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbxEasy;
        private System.Windows.Forms.ListBox lbxMon;
        private System.Windows.Forms.Button btnClearMon;
		private System.Windows.Forms.CheckBox cbxMonZone;
		private System.Windows.Forms.CheckBox cbxMonGroup;
        private System.Windows.Forms.Button btnSpawnNpcs;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblPercEnc;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblEncNpc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMysterious;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMoon;
		private System.Windows.Forms.Label lblRations;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnAddToCombat;
		private System.Windows.Forms.Button btnCombatTracker;
		private System.Windows.Forms.TextBox txtRationAdd;
		private System.Windows.Forms.VScrollBar vScrollBar1;
		private System.Windows.Forms.MenuStrip MenuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem creaturesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem continentsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem weatherToolStripMenuItem;
		private System.Windows.Forms.ToolTip ttMon;
	}
}

