using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Matthew Prindle Lab5 Student Form
namespace Student
{
    public partial class Form1 : Form
    {
        StudentC myStudent = new StudentC();
        public Form1()
        {
            InitializeComponent();
        }

        private void FillBtn_Click(object sender, EventArgs e)
        {
            myStudent = new StudentC(NameTxtB.Text, AddressTxtB.Text, PhoneTxtB.Text, EmailTxtB.Text, MajorTxtB.Text, GPATxtB.Text);
        }

        private void DisplayBtn_Click(object sender, EventArgs e)
        {
            NameTxtB.Text = myStudent.Name;
            AddressTxtB.Text = myStudent.Address;
            PhoneTxtB.Text = myStudent.Phone;
            EmailTxtB.Text = myStudent.Email;
            MajorTxtB.Text = myStudent.Major;
            GPATxtB.Text = myStudent.GPA;
        }
    }
}
