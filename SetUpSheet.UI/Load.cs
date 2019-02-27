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
            /*Initialize RosterControls*/
            int y = 12;
            foreach (var item in roster.Employees)
            {
                RosterControl temp = new RosterControl();
                temp.Location = new Point(12,y);
                temp.DataSource(item);
                Controls.Add(temp);
                y += 33;
            }

            /*Initialize Buttons*/
            Button btnOK = new Button();
            btnOK.Text = "OK";
            btnOK.Location = new Point(261, y);
            Button btnQuit = new Button();
            btnQuit.Text = "Cancel";
            btnQuit.Location = new Point(180, y);

            /*Add to form controls*/
            Controls.Add(btnOK);
            Controls.Add(btnQuit);
            AcceptButton = btnOK;
            CancelButton = btnQuit;

            /*Event Handlers*/
            btnOK.Click += new System.EventHandler(this.btnOK_Click);

        }
        
        /*
         * <summary>
         * Give a summary
         * </summary
         * */ 
        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
        
    }
}
