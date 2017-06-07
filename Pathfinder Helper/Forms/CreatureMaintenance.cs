using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pathfinder_Helper.Forms
{
	public partial class CreatureMaintenance : Form
	{
		#region Private Variables

		private Dictionary<int, string> _creatureList;
		private List<Bestiary> _allCreatures;
		private List<Continent> _contList;
		private List<Season> _seasonList;
		private bool _orderByCr = false, _isDirty, _suppress, _newCreature;
		private MainForm _parent;
		private int ttX, ttY;

		#endregion

		#region Field Values

		private int _bestiaryId = 0;

		#endregion

		#region Construction/Initialization

		public CreatureMaintenance(MainForm parentForm)
		{
			_suppress = _newCreature = true;
			InitializeComponent();
			_parent = parentForm;

			_contList = _parent.pfdb.Continents.OrderBy(x => x.Name).ToList();
			_seasonList = _parent.pfdb.Seasons.OrderBy(x => x.Name).ToList();
			_allCreatures = _parent.pfdb.Bestiaries.ToList();

			lbxCreatures.DisplayMember = "Value";
			lbxCreatures.ValueMember = "Key";

			drpCont.DisplayMember = "Name";
			drpCont.ValueMember = "ContinentId";
			drpCont.DataSource = _contList;

			LoadCreatureList();
			_isDirty = _suppress = false;
		}

		#endregion

		#region Helper Functions

		private void LoadCreatureList()
		{
			_creatureList = new Dictionary<int, string>();
			foreach (var c in _allCreatures)
			{
				var sb = new StringBuilder();
				var cr = c.CR.HasValue ? c.CR.Value : -999;

				sb.Append("[");
				switch (cr)
				{
					case (-999):
						sb.Append("ERR]\t");
						break;
					case (-4):
						sb.Append("1/8]\t");
						break;
					case (-3):
						sb.Append("1/6]\t");
						break;
					case (-2):
						sb.Append("1/4]\t");
						break;
					case (-1):
						sb.Append("1/3]\t");
						break;
					case (0):
						sb.Append("1/2]\t");
						break;
					default:
						sb.Append(c.CR.ToString());
						sb.Append("]\t");
						break;
				}

				sb.Append(c.Name);

				_creatureList.Add(c.BestiaryId, sb.ToString());
			}
			
			lbxCreatures.DataSource = new BindingSource(_creatureList, null);
		}

		private void SortByContinent(int contId)
		{
			_allCreatures = _parent.pfdb.Bestiaries.ToList();
			if (contId > 0)
			{
				var contList = _parent.pfdb.MonsterSpawns.Where(x => x.Continent == contId);
				if (contList != null)
				{
					_allCreatures = contList.Select(x => x.Bestiary).ToList();
				}
				else
				{
					_allCreatures = new List<Bestiary>();
				}
			}

			if (_orderByCr)
				btnSortCr_Click(null, null);
			else
				btnSortName_Click(null, null);
		}

		private void ClearForm()
		{
			if (!_isDirty || MessageBox.Show("Changes not saved! Proceed anyway?") == DialogResult.OK)
			{

			}
		}

		private void LoadCreature(int bestiaryId)
		{
			_bestiaryId = bestiaryId;
			var c = _allCreatures.FirstOrDefault(x => x.BestiaryId == bestiaryId);
			if (c != null)
			{
				_newCreature = false;
				lblBID.Text = _bestiaryId.ToString();

				// Spawns
				var spawns = _parent.pfdb.MonsterSpawns.Where(x => x.BestiaryId == bestiaryId);
				if (spawns != null)
				{
					clbContinent.Items.Clear();
					var cList = spawns.Select(x => x.Continent.HasValue ? x.Continent.Value : -1);
					foreach (var cont in _contList)
					{
						clbContinent.Items.Add(cont.Name, cList.Contains(cont.ContinentId));
					}
					clbSeason.Items.Clear();
					var sList = spawns.Select(x => x.Season.HasValue ? x.Season.Value : -1);
					foreach (var season in _seasonList)
					{
						clbSeason.Items.Add(season.Name, sList.Contains(season.SeasonId));
					}
				}

				// Basic Info
				txtName.Text = c.Name;

				// Abilities

				// Magic

				// Extra Info
				var extra = _parent.pfdb.BestiaryDetails.Where(x => x.BestiaryId == bestiaryId);
				if (extra != null)
				{

				}

				// Full Text
			}
		}

		private bool SaveCreature()
		{
			return false;
		}

		#endregion

		#region Events

		private void btnSortName_Click(object sender, EventArgs e)
		{
			_suppress = true;

			_orderByCr = false;
			_allCreatures = _allCreatures.OrderBy(x => x.Name).ToList();
			LoadCreatureList();

			_suppress = false;
		}

		private void btnSortCr_Click(object sender, EventArgs e)
		{
			_suppress = true;

			_orderByCr = true;
			_allCreatures = _allCreatures.OrderBy(x => x.CR).ToList();
			LoadCreatureList();

			_suppress = false;
		}

		#endregion

		private void drpCont_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Sort by continent, then by CR/Name
			// Change CR/Name buttons to radio buttons
			// 'ALL' option
		}

		private void btnSave_Click(object sender, EventArgs e)
		{

		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			var x = _bestiaryId;
			ClearForm();
			if (x > 0)
				LoadCreature(x);
		}

		private void lbxCreatures_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.X != ttX || e.Y != ttY)
			{ 
				var tip = string.Empty;

				int idx = lbxCreatures.IndexFromPoint(e.Location);
				if (idx >= 0 && idx < lbxCreatures.Items.Count)
					tip = "BID: " + Regex.Match(lbxCreatures.Items[idx].ToString(), @"\d+").Value;
				ttX = e.X;
				ttY = e.Y;

				ttCreatures.SetToolTip(lbxCreatures, tip);
			}
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			ClearForm();
			_newCreature = true;			
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			if (!_isDirty || MessageBox.Show("Changes not saved! Proceed anyway?") == DialogResult.OK)
				Close();
		}

		private void lbxCreatures_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!_suppress)
			{
				_suppress = true;
				if (lbxCreatures.SelectedIndex >= 0)
				{
					if (!_isDirty || MessageBox.Show("Changes not saved! Proceed anyway?") == DialogResult.OK)
						LoadCreature((int)lbxCreatures.SelectedValue);
					else
						lbxCreatures.SelectedValue = _bestiaryId;
				}

				_suppress = false;
			}
		}
	}
}
