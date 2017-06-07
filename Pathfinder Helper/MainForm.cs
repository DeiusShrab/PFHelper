using Pathfinder_Helper.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Pathfinder_Helper
{
    public partial class MainForm : Form
    {
        #region Private Variables
        
        // Constants
        private readonly int MAX_BESTIARY;

        // Regular Variables
        private string filepath, path, filename = "pfhelper.dat";
        private XmlSerializer xs;
        private FileStream fs;
        private Random rand;
		public PFDBEntities pfdb;
		private List<int> validSpawns, lbxMonIds;
		private int ttX, ttY;

		// Preset Variables
		private int[] phasedWeather = { };
        private string[] continentList = { "Centria/Westria", "Dust", "Jade", "Verda", "Darklands", "Silver Peak", "Frozen Isles", "Iceridge", "Aquellarus", "Blacksand", "Deepstone", "Grand Blue", "Lune", "Inner", "Inner Blue" };

		// Forms
		private CombatTracker _FormTracker;
		private CreatureMaintenance _FormCreatures;
        private WeatherMaintenance _FormWeather;

        #endregion

        #region Interface Variables

        public string _date
        {
            get { return lblDate.Text; }
            set { lblDate.Text = value; }
        }

        public string _weather
        {
            get { return lblWeather.Text; }
            set { lblWeather.Text = value; }
        }

        public string _moon
        {
            get { return lblMoon.Text; }
            set { lblMoon.Text = value; }
        }


		public FormData _data { get; set; }

		#endregion

		#region Construction/Initialization

		public MainForm()
        {
            InitializeComponent();
            rand = new Random();
			path = Path.GetDirectoryName(Application.ExecutablePath);
			AppDomain.CurrentDomain.SetData("DataDirectory", path);
			var dd = AppDomain.CurrentDomain.GetData("DataDirectory");
			var cs = dd + @"\..\..\Model\PFDB.mdf";
			var b = File.Exists(cs);

			pfdb = new PFDBEntities();
			pfdb.Database.Initialize(false);
			pfdb.Database.Connection.Open();
			MAX_BESTIARY = pfdb.Bestiaries.Count();
            validSpawns = new List<int>();
            lbxMonIds = new List<int>();
            
            filepath = Path.Combine(path, filename);
            xs = new XmlSerializer(typeof(FormData));
            if (File.Exists(filepath))
            {
                LoadData();
            }
            else
                _data = new FormData();

            _date = _data.Date.ToString();
			LoadContinents();
			UpdateValidMobs();
			lblRations.Text = _data.Rations.ToString("D2");
		}
        #endregion

        #region Events

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
			OnClose(null, null);
        }

        private void OnClose(object sender, FormClosingEventArgs e)
        {
            SaveData();
			pfdb.Database.Connection.Close();
		}

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void lbxContinent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxContinent.SelectedIndex >= 0)
                SwitchContinent();
        }

        private void btnNextDay_Click(object sender, EventArgs e)
        {
            var year = _data.Date.Year;
			var month = _data.Date.Month;
            _data.Date.AddDays(1);
            _date = _data.Date.ToString();
            GenWeather();
			if (month < _data.Date.Month)
				UpdateValidMobs();

			GenEncounters();
			AddRations(-1);

            if (year < _data.Date.Year)
                MessageBox.Show("Demon's Day has come!");
        }

        private void btnAddDays_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (int.TryParse(txtDay.Text, out i) && i > 0)
            {
                var year = _data.Date.Year;
				var month = _data.Date.Month;
				_data.Date.AddDays(i);
                _date = _data.Date.ToString();
                GenWeather();
				AddRations(-1 * i);
				if (month < _data.Date.Month)
					UpdateValidMobs();
				if (year < _data.Date.Year)
                    MessageBox.Show("Demon's Day has come!");
            }
        }

        private void btnRoll20_Click(object sender, EventArgs e)
        {
            lbxRoll.Items.Clear();
            for (int i = 0; i < 20; i++)
            {
                lbxRoll.Items.Add(rand.Next(20) + 1);
            }
        }

        private void btnChangeWeather_Click(object sender, EventArgs e)
        {
            GenWeather();
        }

        private void btnEncounter_Click(object sender, EventArgs e)
        {
            GenEncounters();
        }

        private void lbxEasy_DoubleClick(object sender, EventArgs e)
        {
            if (lbxEasy.SelectedIndex >= 0)
            {
                LoadMonsters(lbxEasy.SelectedItem.ToString());
            }
        }

        private void lbxMed_DoubleClick(object sender, EventArgs e)
        {
            if (lbxMed.SelectedIndex >= 0)
            {
                LoadMonsters(lbxMed.SelectedItem.ToString());
            }
        }

        private void lbxHard_DoubleClick(object sender, EventArgs e)
        {
            if (lbxHard.SelectedIndex >= 0)
            {
                LoadMonsters(lbxHard.SelectedItem.ToString());
            }
        }

        #endregion

        #region Helper Methods

        private void SaveData()
        {
            try
            {
                using (fs = new FileStream(filepath, FileMode.Create))
                {
                    xs.Serialize(fs, _data);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR - UNABLE TO SAVE DATA\n" + ex.ToString());
            }
        }

        private void LoadData()
        {
            try
            {
                using (fs = new FileStream(filepath, FileMode.Open))
                {
                    _data = xs.Deserialize(fs) as FormData;
                }

                _date = _data.Date.ToString();
            }
            catch (Exception ex)
            {
				MessageBox.Show("FAILED TO LOAD DATA\n" + ex.ToString());
				filepath = Path.Combine(Path.GetDirectoryName(filepath), "pfhelper_NEW.dat");
                _data = new FormData();
            }
        }

        private void GenWeather()
        {
            if (_data.Date.Day <= 3 && _data.Date.Day > 0)
                _moon = "FULL MOON";
            else if (_data.Date.Day <= 7)
                _moon = "Waning Gibbous";
            else if (_data.Date.Day <= 10)
                _moon = "Last Quarter";
            else if (_data.Date.Day <= 14)
                _moon = "Waning Crescent";
            else if (_data.Date.Day <= 17)
                _moon = "NEW MOON";
            else if (_data.Date.Day <= 21)
                _moon = "Waxing Crescent";
            else if (_data.Date.Day <= 24)
                _moon = "First Quarter";
            else if (_data.Date.Day <= 28)
                _moon = "Waxing Gibbous";
            else
                _moon = "MOON MOON";
            // TEMP
            _weather = rand.Next(100).ToString();
            return;

            // Using previous weather conditions (if any), generate the next day's weather
            // Some weather has multiple phases, others are single-phase
            // Depending on selected continent, display different things

            if (_data.CurrentWeather.Phased && _data.CurrentWeather.PhaseLength > _data.CurrentWeather.CurrentPhase)
            {
                _data.CurrentWeather.CurrentPhase++;
            }
            else
            {
                _data.CurrentWeather = NextWeather();
                _data.CurrentWeather.CurrentPhase = 0;
            }

            _weather = _data.CurrentWeather.ToString();
        }

        private void GenEncounters()
        {
            GenMysterious();
            lblEncNpc.Text = rand.Next(100).ToString("D2");
			lblPercEnc.Text = rand.Next(100).ToString("D2");
			int apl = rand.Next(1, 21);
            if (string.IsNullOrWhiteSpace(txtApl.Text) || !int.TryParse(txtApl.Text, out apl))
                txtApl.Text = apl.ToString();

            apl--;
            var lbxs = new List<ListBox>() { lbxEasy, lbxMed, lbxHard };

            for (int t = 0; t < 3; t++)
            {
                lbxs[t].Items.Clear();
                var CRs = new List<int[]>();
                for (int i = 0; i < 5; i++)
                {
                    int r = rand.Next(6);
                    switch (r)
                    {
                        case 0:
                            CRs.Add(new int[] { apl });
                            break;
                        case 1:
                            CRs.Add(new int[] { apl - 2, apl - 2 });
                            break;
                        case 2:
                            CRs.Add(new int[] { apl - 4, apl - 4, apl - 4, apl - 4 });
                            break;
                        case 3:
                            CRs.Add(new int[] { apl - 2, apl - 3, apl - 3 });
                            break;
                        case 4:
                            CRs.Add(new int[] { apl - 2, apl - 4, apl - 4, apl - 4 });
                            break;
                        case 5:
                            CRs.Add(new int[] { apl - 5, apl - 5, apl - 5, apl - 5, apl - 5, apl - 5 });
                            break;
                    }
                }
                foreach (var cr in CRs)
                {
                    var sb = new StringBuilder();
                    foreach (var c in cr)
                    {
                        switch (c)
                        {
							case (-4):
                                sb.Append("1/8");
                                sb.Append(", ");
                                break;
                            case (-3):
                                sb.Append("1/6");
                                sb.Append(", ");
                                break;
                            case (-2):
                                sb.Append("1/4");
                                sb.Append(", ");
                                break;
                            case (-1):
                                sb.Append("1/3");
                                sb.Append(", ");
                                break;
                            case (0):
                                sb.Append("1/2");
                                sb.Append(", ");
                                break;
                            default:
                                sb.Append(c);
                                sb.Append(", ");
                                break;
                        }
                    }
                    sb.Remove(sb.Length - 2, 2);
                    lbxs[t].Items.Add(sb.ToString());
                }                
                apl++;
            }
            if (rand.Next(100) == 0)
            {
                var d = "UNIQUE ENCOUNTER";
                lbxs[0].Items.Add(d);
                lbxs[1].Items.Add(d);
                lbxs[2].Items.Add(d);
            }
        }

        private void SwitchContinent()
        {
            _data.Continent = lbxContinent.SelectedIndex + 1;
			UpdateValidMobs();

            if (_data.CurrentWeather.Phased)
                _data.CurrentWeather = NextWeather();
        }
        
        private WeatherData NextWeather()
        {
            // get weather from weather table
            return new WeatherData();


        }

        private void LoadMonsters(string crString)
        {
			var groupMon = new List<Bestiary>();
            var crSplit = crString.Split(',');
            var CRs = new List<int>();
            foreach (var item in crSplit)
            {
                if (item.Trim() == "UNIQUE ENCOUNTER")
                {
                    CRs.Add(999);
                    continue;
                }

                var c = ParseCRFraction(item.Trim());
                CRs.Add(c);
            }
            foreach (var cr in CRs)
            {
				if (cbxMonGroup.Checked && groupMon.Select(x => x.CR).Contains(cr))
				{
					lbxMon.Items.Add(groupMon.First(x => x.CR == cr).Name + " [" + ParseCR(cr) + "]");
                    lbxMonIds.Add(groupMon.First(x => x.CR == cr).BestiaryId);
					continue;
				}
                Bestiary mon = null;
                if (cr == 999)
                {
                    mon = pfdb.Bestiaries.ToList().ElementAt(rand.Next(MAX_BESTIARY));
					if (mon == null)
						mon = new Bestiary() { Name = "ERROR" };
                    mon.Name = "UNIQUE " + mon.Name;
                }
                else
                {
					var monList = pfdb.Bestiaries.Where(x => x.CR.HasValue && x.CR == cr).ToList();
					if (cbxMonZone.Checked)
						monList = monList.Where(x => validSpawns.Contains(x.BestiaryId)).ToList();
                    mon = monList.ElementAt(rand.Next(monList.Count()));
                }
                if (mon != null)
                {
					groupMon.Add(mon);
                    lbxMon.Items.Add(mon.Name + " [" + ParseCR(Convert.ToInt32(mon.CR)) + "]");
                    lbxMonIds.Add(mon.BestiaryId);
                }
            }
        }

        private void btnClearMon_Click(object sender, EventArgs e)
        {
            lbxMon.Items.Clear();
            lbxMonIds.Clear();
        }

        private string ParseCR(int cr)
        {
            switch(cr)
            {
                case 0:
                    return "1/2";
                case -1:
                    return "1/3";
                case -2:
                    return "1/4";
                case -3:
                    return "1/6";
                case -4:
                    return "1/8";
                default:
                    return cr.ToString();
            }
        }

        private int ParseCRFraction(string input)
        {
            if (input == "1/2")
                return 0;
            if (input == "1/3")
                return -1;
            if (input == "1/4")
                return -2;
            if (input == "1/6")
                return -3;
            if (input == "1/8")
                return -4;   

            int i = 0;
            int.TryParse(input, out i);
            return i;
        }

		private void btnSpawnNpcs_Click(object sender, EventArgs e)
        {
            using (var npc = new NPCTerritorySpawn(this))
            {
                npc.ShowDialog();
            }            
        }

        private void lbxMon_DoubleClick(object sender, EventArgs e)
        {
            if (lbxMon.SelectedIndex >= 0)
            {
                var mon = pfdb.Bestiaries.ToList().ElementAtOrDefault(lbxMonIds[lbxMon.SelectedIndex] - 1); // Offset zero-based index
                if (mon != null)
                {
					var monHtml = pfdb.BestiaryDetails.Find(mon.BestiaryId);
					var monDisplay = new CreatureDisplay(mon.Name);

					if (monHtml != null && !string.IsNullOrWhiteSpace(monHtml.FullText))
						monDisplay.LoadHtml(monHtml.FullText);
					else
					{
						var searchUrl = @"https://cse.google.com/cse?cx=006680642033474972217%3A6zo0hx_wle8&q={0}#gsc.tab=0&gsc.q={0}&gsc.page=1";
						var uri = string.Format(searchUrl, mon.Name);
						monDisplay.LoadUrl(uri);
					}
					monDisplay.Show();
                }
            }
        }

		private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
		{
			if (e.Type == ScrollEventType.EndScroll)
				return;

			int r = 1;
			if (!string.IsNullOrWhiteSpace(txtRationAdd.Text))
				int.TryParse(txtRationAdd.Text, out r);

			if (e.Type == ScrollEventType.SmallDecrement)
			{
				AddRations(Math.Abs(r));
			}
			else if (e.Type == ScrollEventType.SmallIncrement)
			{
				AddRations(-1 * Math.Abs(r));
			}

			txtRationAdd.Text = string.Empty;
		}

		private void LoadContinents()
		{
			foreach (var c in pfdb.Continents)
			{
				lbxContinent.Items.Add(c.Name);
			}
			lbxContinent.SelectedIndex = _data.Continent;
		}

		private void btnCombatTracker_Click(object sender, EventArgs e)
		{
			ShowCombatTracker();
		}

		private void combatTrackerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ShowCombatTracker();
		}

		private void ShowCombatTracker()
		{
			if (_FormTracker == null || _FormTracker.IsDisposed)
			{
				_FormTracker = new CombatTracker(this);
				_FormTracker.Show();
			}
			else
				_FormTracker.BringToFront();
		}

		private void creaturesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (_FormCreatures == null || _FormCreatures.IsDisposed)
			{
				_FormCreatures = new CreatureMaintenance(this);
				_FormCreatures.Show();
			}
			else
				_FormCreatures.BringToFront();
		}

        private void weatherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_FormWeather == null || _FormWeather.IsDisposed)
            {
                _FormWeather = new WeatherMaintenance(this);
                _FormWeather.Show();
            }
            else
                _FormWeather.BringToFront();
        }

		private void btnAddToCombat_Click(object sender, EventArgs e)
		{
			if (_FormTracker == null || _FormTracker.IsDisposed)
			{
				_FormTracker = new CombatTracker(this);
				_FormTracker.Show();
				_FormTracker.SendToBack();
			}

				if (lbxMon.SelectedIndex >= 0)
			{
				var mon = pfdb.Bestiaries.ToList().ElementAtOrDefault(lbxMonIds[lbxMon.SelectedIndex] - 1); // Offset zero-based index
				if (mon != null)
				{
					_FormTracker.AddBestiary(mon.BestiaryId);
				}
			}

		}

		private void lbxMon_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.X != ttX || e.Y != ttY)
			{
				var tip = string.Empty;

				int idx = lbxMon.IndexFromPoint(e.Location);
				if (idx >= 0 && idx < lbxMon.Items.Count)
					tip = "BID: " + lbxMonIds[idx].ToString();
				ttX = e.X;
				ttY = e.Y;

				ttMon.SetToolTip(lbxMon, tip);
			}
		}

		private void UpdateValidMobs()
		{
			var mList = pfdb.MonsterSpawns.Where(x => x.Continent.HasValue && x.Continent.Value == _data.Continent);
			mList = mList.Where(x => !x.Season.HasValue || x.Season.Value == _data.Date.Season);
			validSpawns = mList.Select(x => x.BestiaryId.Value).ToList();
		}

        private void GenMysterious()
        {
			if (rand.Next(100) == 0)
			{
				var m = rand.Next(100);

				if (m == 1)
				{
					lblMysterious.ForeColor = Color.Blue;
					lblMysterious.Text = "VGD";
				}
				else if (m == 0)
				{ 
					lblMysterious.ForeColor = Color.Red;
					lblMysterious.Text = "VBD";
				}
				else if (m <= 10)
				{ 
					lblMysterious.ForeColor = Color.Green;
					lblMysterious.Text = "GUD";
				}
				else if (m >= 90)
				{ 
					lblMysterious.ForeColor = Color.Orange;
					lblMysterious.Text = "BAD";
				}
				else
				{
					lblMysterious.ForeColor = Color.Black;
					lblMysterious.Text = "N/A";
				}

			}
			else
			{
				lblMysterious.ForeColor = Color.Black;
				lblMysterious.Text = "N/A";
			}
		}

		private void AddRations(int r)
		{
			_data.Rations += r;
			if (_data.Rations < 0)
			{
				_data.Rations = 0;
				MessageBox.Show("OUT OF RATIONS!");
			}

			lblRations.Text = _data.Rations < 100 ? _data.Rations.ToString("D2") : "AA";
		}

        #endregion
    }

	#region Helper Classes

	public class FormData
    {
        public WorldDate Date;
        public int Continent, Rations;
        public WeatherData CurrentWeather;
		public CombatData Combat;

        public FormData()
        {
            Date = new WorldDate();
            CurrentWeather = new WeatherData();
			Combat = new CombatData();
        }
        
        public FormData(WorldDate wd)
        {
            Date = wd;
        }        

        public FormData(int y, int m, int d)
        {
            Date = new WorldDate(y, m, d);
        }
    }

    public class WorldDate
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
		public int Season {
			get { return ((Month - 1) / 3) + 1; } }
		public WorldDate()
        {
            Year = Month = Day = 1;
        }

        public WorldDate(int y, int m, int d)
        {
            Year = y;
            Month = m;
            Day = d;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("Year: ");
            sb.Append(Year);
            sb.Append("AA; Season of ");
            sb.Append(SeasonName());
            sb.Append(", Month of ");
            sb.Append(MonthName());
            sb.Append(", Day ");
            sb.Append(Day);

            return sb.ToString();
        }

        public string MonthName()
        {
            switch (Month)
            {
                case 1:
                    return "Embers";
                case 2:
                    return "Blazes";
                case 3:
                    return "Ashes";
                case 4:
                    return "Soil";
                case 5:
                    return "Harvest";
                case 6:
                    return "Dust";
                case 7:
                    return "Frost";
                case 8:
                    return "Storms";
                case 9:
                    return "Wind";
                case 10:
                    return "Mist";
                case 11:
                    return "Rain";
                case 12:
                    return "Fog";

                default:
                    return "ERR";
            }
        }

        public string SeasonName()
        {
            switch (Season)
            {
                case 1:
                    return "Fire";
                case 2:
                    return "Earth";
                case 3:
                    return "Air";
                case 4:
                    return "Water";

                default:
                    return "ERR";
            }
        }

        public void AddDays(int d)
        {
            if (d > 0)
            {
                Day += d;
                while (Day > 28)
                {
                    Day -= 28;
                    Month++;
                }
                while (Month > 12)
                {
                    Month -= 12;
                    Year++;
                }
            }
            else
            {
                Day += d;
                while (Day <= 0)
                {
                    Day += 28;
                    Month--;
                }
                while (Month <= 0)
                {
                    Month += 12;
                    Year--;
                }
				if (Year <= 0)
					Year = Month = Day = 1;
            }              
        }
    }

    public class WeatherData
    {
        public bool Phased { get; set; }
		public int PhaseLength { get; set; }
        public int CurrentPhase { get; set; }
        public string[] Phases { get; set; }
        public string Description { get; set; }

        public WeatherData()
        {
            Phased = false;
            PhaseLength = CurrentPhase = 0;
            Description = "ERR";
        }

        public WeatherData(string d)
        {
            Phased = false;
            PhaseLength = CurrentPhase = 0;
            Description = d;
        }

        public WeatherData(int phasenum)
        {
            Phased = true;
            PhaseLength = phasenum;
            CurrentPhase = 0;
            Phases = new string[phasenum];
            Description = "ERR";
        }

        public WeatherData(int phasenum, string d)
        {
            Phased = true;
            PhaseLength = phasenum;
            CurrentPhase = 0;
            Phases = new string[phasenum];
            Description = d;
        }

        public override string ToString()
        {
            if (Phased)
                return Phases[CurrentPhase] + " [Phase " + CurrentPhase.ToString() + "/" + PhaseLength.ToString() + "]";
            else
                return Description;
        }
    }

	public class CombatData
	{
		public List<InitTrackItem> InitTrack { get; set; }
		public List<EffectTurnItem> EffectTurn { get; set; }

		public int TurnNum { get; set; }

	}

	public class InitTrackItem
	{
		public int BestiaryId { get; set; }
		public bool IsBeast { get; set; }
		public int Init { get; set; }
		public string InitName { get; set; }
		public bool PC { get; set; }
		public int HP { get; set; }
		public int AC { get; set; }
		public int ACFlat { get; set; }
		public int ACTouch { get; set; }
		public int Fort { get; set; }
		public int Ref { get; set; }
		public int Will { get; set; }
		public int Subdual { get; set; }

		public InitTrackItem Clone()
		{
			var newItm = new InitTrackItem()
			{
				AC = this.AC,
				ACFlat = this.ACFlat,
				ACTouch = this.ACTouch,
				BestiaryId = this.BestiaryId,
				Fort = this.Fort,
				HP = this.HP,
				Init = this.Init,
				InitName = this.InitName,
				IsBeast = this.IsBeast,
				PC = this.PC,
				Ref = this.Ref,
				Subdual = this.Subdual,
				Will = this.Will
			};

			return newItm;
		}
	}

	public class EffectTurnItem
	{
		public string EffectName { get; set; }
		public string Target { get; set; }
		public int RoundsRemaining { get; set; }
	}

	#endregion
}
