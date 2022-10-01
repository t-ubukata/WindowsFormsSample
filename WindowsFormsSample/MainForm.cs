using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsSample
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            DataSet ds = Dao.GetStadiums();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                this.stadiums.Rows.Add(row["ID"], row["StadiumName"], row["Prefecture"]);
            }
        }
    }
}
