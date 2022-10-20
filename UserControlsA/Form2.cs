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
    public partial class Form2 : Form
    {
        public List<Student> Students { get; set; }
        public Form2()
        {
            InitializeComponent();

            Students = new List<Student>
            {
                 new Student
                 {
                      Id=1,
                      Name="Tural",
                      Age=25,
                      Speciality="Programmer",
                      ImageURL="https://assets.stickpng.com/images/584df3ad6a5ae41a83ddee08.png"

                 },
                 new Student
                 {
                      Id=2,
                      Name="Leyla",
                      Age=30,
                      Speciality="Programmer",
                      ImageURL="https://assets.stickpng.com/images/584df3ad6a5ae41a83ddee08.png"
                 },
                 new Student
                 {
                      Id=3,
                      Name="Ali",
                      Age=35,
                      Speciality="Designer",
                      ImageURL="https://assets.stickpng.com/images/584df3ad6a5ae41a83ddee08.png"
                 },
            };

            LoadStudents();
          //  pictureBox1.ImageLocation = @"https://assets.stickpng.com/images/584df3ad6a5ae41a83ddee08.png";
        }
        public int Y { get; set; }
        public void LoadStudents()
        {
            foreach (var s in Students)
            {
                var uc = new StudentUC();
                uc.Id = s.Id;
                uc.Name = s.Name;
                uc.Age = s.Age;
                uc.Speciality = s.Speciality;
                uc.ImagePath = s.ImageURL;

                uc.Location = new Point(0, Y);
                Y += 125;

                this.Controls.Add(uc);
            }
        }
    }
}
