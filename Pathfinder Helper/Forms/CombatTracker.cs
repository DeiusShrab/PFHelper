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
	public partial class CombatTracker : Form
	{
		private CombatData _data;
		private readonly FormData _fdata;
		private BindingList<InitTrackItem> _initList;
		private BindingList<EffectTurnItem> _effectList;
		private MainForm _parent;
		private Random _rand;

		#region Interface Properties

		public int TurnNumber
		{
			get { return _data.TurnNum; }
			set
			{
				_data.TurnNum = value;
				lblTurnNum.Text = _data.TurnNum.ToString("D2");
			}
		}

		#endregion

		public CombatTracker(MainForm form)
		{
			InitializeComponent();
			_parent = form;
			_fdata = form._data;
			_rand = new Random();

			_data = _fdata.Combat ?? new CombatData();
			_initList = new BindingList<InitTrackItem>(_data.InitTrack ?? new List<InitTrackItem>());
			_effectList = new BindingList<EffectTurnItem>(_data.EffectTurn ?? new List<EffectTurnItem>());


			TurnNumber = _data.TurnNum;

			dgInitTracker.DataSource = _initList;
			dgTurnEffects.DataSource = _effectList;
		}

		#region Events

		private void btnAddEffect_Click(object sender, EventArgs e)
		{
			var eff = new EffectTurnItem();

			eff.EffectName = txtAddEffect.Text;
			eff.RoundsRemaining = Convert.ToInt32(numEffect.Value);

			_effectList.Add(eff);
		}

		private void btnAddInit_Click(object sender, EventArgs e)
		{
			var itm = new InitTrackItem();
			int temp = 0;

			itm.Init = Convert.ToInt32(numInit.Value);
			itm.InitName = txtInitName.Text;
			itm.PC = cbxInitPC.Checked;
			itm.HP = int.TryParse(txtInitHP.Text, out temp) ? temp : 0;
			itm.AC = int.TryParse(txtInitAC.Text, out temp) ? temp : 0;
			itm.ACFlat = int.TryParse(txtInitFlat.Text, out temp) ? temp : 0;
			itm.ACTouch = int.TryParse(txtInitTouch.Text, out temp) ? temp : 0;
			itm.Fort = int.TryParse(txtInitFort.Text, out temp) ? temp : 0;
			itm.Ref = int.TryParse(txtInitRef.Text, out temp) ? temp : 0;
			itm.Will = int.TryParse(txtInitWill.Text, out temp) ? temp : 0;
			itm.Subdual = int.TryParse(txtInitSubd.Text, out temp) ? temp : 0;
			itm.BestiaryId = -1;
			itm.IsBeast = false;

			_initList.Add(itm);
		}

		private void dgTurnEffects_DoubleClick(object sender, EventArgs e)
		{
			// Insert selected row into the New Effect bar
		}

		private void dgInitTracker_DoubleClick(object sender, EventArgs e)
		{
			// Attempt to display creature stats page
			// If BestiaryId < 0, do something else (or nothing)
			// If IsBeast, load from Bestiary
			// If !IsBeast, load from NPCs
			// Wait shit there is no more NPC table
			// Maybe just check IsBeast and load from Bestiary if it is
		}

		private void dgInitTracker_MouseHover(object sender, EventArgs e)
		{
			// If hovering over AC cell, tooltip for Flat/Touch AC
		}

		private void CombatTracker_FormClosing(object sender, FormClosingEventArgs e)
		{
			_data.EffectTurn = _effectList.ToList();
			_data.InitTrack = _initList.ToList();
		}

		private void btnNextTurn_Click(object sender, EventArgs e)
		{
			TurnNumber++;

			var removeList = new List<EffectTurnItem>();

			foreach (var item in _effectList)
			{
				item.RoundsRemaining--;
				if (item.RoundsRemaining < 0)
					removeList.Add(item);
				else if (item.RoundsRemaining < 1)
					item.EffectName += " ENDED";
			}

			foreach (var item in removeList)
			{
				_effectList.Remove(item);
			}

			_effectList.ResetBindings();
		}

		#endregion

		#region Helper Methods

		public void AddBestiary(int bId)
		{
			int i = 0;
			var b = _parent.pfdb.Bestiaries.Find(bId);
			if (b != null && b.BestiaryId > 0)
			{
				var initItem = new InitTrackItem();
				var ac = b.AC.Split(',');
				if (ac.Length == 3)
				{
					initItem.AC = int.TryParse(Regex.Match(ac[0], @"\d+").Value, out i) ? i : 0;
					initItem.ACFlat = int.TryParse(Regex.Match(ac[1], @"\d+").Value, out i) ? i : 0;
					initItem.ACTouch = int.TryParse(Regex.Match(ac[2], @"\d+").Value, out i) ? i : 0;
				}
				else if (ac.Length > 0)
				{
					initItem.AC = int.TryParse(Regex.Match(ac[0], @"\d+").Value, out i) ? i : 0;
					initItem.ACFlat = initItem.AC;
					initItem.ACTouch = initItem.AC;
				}
				else
				{
					initItem.AC = initItem.ACFlat = initItem.ACTouch = 0;
				}
				initItem.BestiaryId = bId;
				initItem.Fort = b.Fort ?? 0;
				initItem.HP = b.HP ?? 0;
				initItem.Init = _rand.Next(1, 21) + (b.Init ?? 0);
				initItem.InitName = b.Name;
				initItem.IsBeast = true;
				initItem.PC = false;
				initItem.Ref = b.Ref_ ?? 0;
				initItem.Subdual = 0;
				initItem.Will = b.Will ?? 0;

				_initList.Add(initItem);
				txtBestiaryId.Clear();
			}
		}

		#endregion

		private void BtnClearNpcs_Click(object sender, EventArgs e)
		{
			var removeList = new List<InitTrackItem>();

			foreach (var item in _initList)
			{
				if (!item.PC)
					removeList.Add(item);
			}

			foreach (var item in removeList)
			{
				_initList.Remove(item);
			}

			_effectList.Clear();

			TurnNumber = 0;
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			_initList.Clear();
			_effectList.Clear();
			TurnNumber = 0;
		}

		private void btnSort_Click(object sender, EventArgs e)
		{
			var newList = new BindingList<InitTrackItem>(_initList.OrderByDescending(x => x.Init).ToList());
			_initList.Clear();
			foreach (var item in newList)
			{
				_initList.Add(item);
			}
		}

		private void btnDuplicate_Click(object sender, EventArgs e)
		{
			var newRows = new List<InitTrackItem>();

			foreach (DataGridViewRow row in dgInitTracker.SelectedRows)
				newRows.Add(_initList.ElementAt(row.Index).Clone());

			foreach (var item in newRows)
				_initList.Add(item);

			_initList.ResetBindings();
		}

		private void btnAddBestiary_Click(object sender, EventArgs e)
		{
			int i = 0;
			if (int.TryParse(txtBestiaryId.Text, out i))
			{
				AddBestiary(i);
			}
		}

		private void txtBestiaryId_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Return)
			{
				btnAddBestiary_Click(null, null);
			}
		}
	}
}
