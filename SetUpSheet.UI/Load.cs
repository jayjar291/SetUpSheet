using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SetUpSheet.DataFunctions;

namespace SetUpSheet.UI
{
    public partial class Load : Form
    {
        public Load(Roster roster)
        {
            InitializeComponent();
            foreach (var item in roster.Employees)
            {
                RosterControl temp = new RosterControl();
                temp.DataSource(item);
                Controls.Add(temp);
            }
        }
    }
}
