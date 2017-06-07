using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pathfinder_Helper.Forms
{
    public partial class WeatherMaintenance : Form
    {
		#region Private Variables

		private readonly MainForm _parent;
		private BindingList<Weather> _listWeather;
		private BindingList<Continent> _listContinent;
		private BindingList<Season> _listSeason;
		private BindingList<ContinentWeather> _listCSW;
		private Weather _weather;

		#endregion

		#region Interface Variables

		public int WeatherId;

		public string WeatherName
		{
			get { return txtName.Text; }
			set { txtName.Text = value; }
		}

		public int Duration
		{
			get { return (int)Math.Round(numDuration.Value, 0); }
			set { numDuration.Value = value; }
		}

		public int Weight
		{
			get { return (int)Math.Round(numWeight.Value, 0); }
			set { numWeight.Value = value; }
		}

		public int NextWeather
		{
			get { return (int)drpNextWeather.SelectedValue; }
			set { drpNextWeather.SelectedValue = value; }
		}

		public bool VisionObscured
		{
			get { return cbxVisionObscured.Checked; }
			set { cbxVisionObscured.Checked = value; }
		}

		public bool HighWind
		{
			get { return cbxHighWind.Checked; }
			set { cbxHighWind.Checked = value; }
		}

		public bool HeatDanger
		{
			get { return cbxHeatDanger.Checked; }
			set { cbxHeatDanger.Checked = value; }
		}

		public bool HeatLethal
		{
			get { return cbxHeatLethal.Checked; }
			set { cbxHeatLethal.Checked = value; }
		}

		public bool ColdDanger
		{
			get { return cbxColdDanger.Checked; }
			set { cbxColdDanger.Checked = value; }
		}

		public bool ColdLethal
		{
			get { return cbxColdLethal.Checked; }
			set { cbxColdLethal.Checked = value; }
		}

		public int CSWContinent
		{
			get { return (int)drpCSWContinent.SelectedValue; }
			set { drpCSWContinent.SelectedValue = value; }
		}

		public int CSWSeason
		{
			get { return (int)drpCSWSeason.SelectedValue; }
			set { drpCSWSeason.SelectedValue = value; }
		}

		public string Description
		{
			get { return txtDescription.Text; }
			set { txtDescription.Text = value; }
		}

		public string Effects
		{
			get { return txtEffects.Text; }
			set { txtEffects.Text = value; }
		}

		#endregion

		#region Construction/Initialization

		public WeatherMaintenance(MainForm parent)
        {
            _parent = parent;
            InitializeComponent();

			var tempWeather = _parent.pfdb.Weathers.ToList();
			tempWeather.Add(new Weather() { WeatherId = 0 });
			_listWeather = new BindingList<Weather>(tempWeather.OrderBy(x => x.WeatherId).ToList());

			var tempContinent = _parent.pfdb.Continents.ToList();
			tempContinent.Add(new Continent() { ContinentId = 0 });
			_listContinent = new BindingList<Continent>(tempContinent.OrderBy(x => x.ContinentId).ToList());

			var tempSeason = _parent.pfdb.Seasons.ToList();
			tempSeason.Add(new Season() { SeasonId = 0 });
			_listSeason = new BindingList<Season>(tempSeason.OrderBy(x => x.SeasonId).ToList());

			_listCSW = new BindingList<ContinentWeather>();	

			UpdateWeatherList();
			UpdateCSW();
        }

		#endregion

		#region Helper Methods

		private void UpdateWeatherList()
		{
			if (_listWeather == null)
			{
				_listWeather = new BindingList<Weather>();
				_listWeather.Add(new Weather() { WeatherId = 0 });
			}

			lbxWeather.DisplayMember = "Name";
			lbxWeather.ValueMember = "WeatherId";
			lbxWeather.DataSource = _listWeather;

			drpNextWeather.DisplayMember = "Name";
			drpNextWeather.ValueMember = "WeatherId";
			drpNextWeather.DataSource = _listWeather;
		}

		private void UpdateCSW()
		{
			if (_listContinent == null)
				_listContinent = new BindingList<Continent>();

			if (_listSeason == null)
				_listSeason = new BindingList<Season>();

			var listTemp = _parent.pfdb.ContinentWeathers.Where(x => x.WeatherId == WeatherId);
			if (listTemp == null)
				_listCSW = new BindingList<ContinentWeather>();
			else
				_listCSW = new BindingList<ContinentWeather>(listTemp.ToList());

			drpCSWContinent.DisplayMember = "Name";
			drpCSWContinent.ValueMember = "ContinentId";
			drpCSWContinent.DataSource = _listContinent;

			drpCSWSeason.DisplayMember = "Name";
			drpCSWSeason.ValueMember = "SeasonId";
			drpCSWSeason.DataSource = _listSeason;
		}

		private void DeleteWeather()
		{
			// Get current weatherId
			// Delete all references to said ID from Weather.NextWeather
			// Delete all references to said ID from ContinentSeasonWeather
			// Delete Weather
		}

		private void ClearWeather()
		{

		}

		#endregion

		#region Events

		#endregion

		private void btnNew_Click(object sender, EventArgs e)
		{
			ClearWeather();

			_weather = new Weather();
		}
	}
}
