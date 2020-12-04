using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace karaoke
{
    public partial class actionForm : Form
    {
        int actionID = -1;
        string serviceID = "";

        QuanLyKaraokeDB db = new QuanLyKaraokeDB();

        public actionForm(string serviceName, string serviceID, string unit, string action, int ID)
        {
            InitializeComponent();
            serviceNameLabel.Text = serviceName;
            serviceIDLabel.Text = serviceID;
            unitLabel.Text = unit;
            actionBtn.Text = action;
            actionID = ID;
            this.serviceID = serviceID;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void actionBtn_Click(object sender, EventArgs e)
        {
            int remainQuantity = Convert.ToInt32(db.GetData($"select soLuongDV from DICHVU where maDV='{serviceID}'").Rows[0].ItemArray[0]);

            if (actionID == 1)
                remainQuantity += Convert.ToInt32(quantityTxt.Text.ToString());
            else if (actionID == 2)
                remainQuantity -= Convert.ToInt32(quantityTxt.Text.ToString());

            db.Execute($"update DICHVU set soLuongDV={remainQuantity} where maDV='{serviceID}'");
            this.Close();
        }
    }
}
