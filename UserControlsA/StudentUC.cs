using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlsA
{
    public partial class StudentUC : UserControl
    {
        public int Id
        {
            get { return int.Parse(idLbl.Text); }
            set { idLbl.Text = value.ToString(); }
        }

        public string Name
        {
            get { return nameLbl.Text; }
            set { nameLbl.Text = value; }
        }

        public int Age
        {
            get { return int.Parse(ageLbl.Text); }
            set { ageLbl.Text = value.ToString(); }
        }

        public string Speciality
        {
            get { return specialityLbl.Text; }
            set { specialityLbl.Text = value; }
        }

        public string ImagePath
        {
            get =>pictureBox1.ImageLocation;
            set => pictureBox1.ImageLocation = value;
        }
        public StudentUC()
        {
            InitializeComponent();
        }
    }
}
