using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlsA
{
    public partial class Form1 : Form
    {
        public HomeUserControl HomeUC { get; set; }
        public AboutUserControl AboutUC { get; set; }
        public Form1()
        {
            InitializeComponent();
            LoadHomeUC();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(HomeUC);

            AboutUC = new AboutUserControl();
            AboutUC.Location = new Point(0, 100);
            this.Controls.Add(AboutUC);


        }
        private void LoadHomeUC()
        {
            HomeUC = new HomeUserControl();
            HomeUC.Location = new Point(0, 100);

            this.Controls.Add(HomeUC);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(AboutUC);
            LoadHomeUC();
        }
    }
}
