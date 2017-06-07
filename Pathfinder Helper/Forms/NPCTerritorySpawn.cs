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
    public partial class NPCTerritorySpawn : Form
    {
        private readonly MainForm _main;

        public NPCTerritorySpawn(MainForm main)
        {
            _main = main;
            InitializeComponent();
        }
    }
}
