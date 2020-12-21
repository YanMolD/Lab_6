using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_6
{
    public partial class Form2 : Form
    {
        public int usersButton;
        private Form1 form;

        public Form2(Form1 form1)
        {
            form = form1;
            InitializeComponent();
        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {
            usersButton = 1;
            Visible = false;
            form.ShowCircle();
        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            usersButton = 2;
            Visible = false;
            form.ShowSquare();
        }

        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            usersButton = 3;
            Visible = false;
            form.ShowRectangle();
        }

        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            usersButton = 4;
            Visible = false;
            form.ShowTriangle();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            usersButton = 5;
            Visible = false;
            form.ShowNothing();
        }
    }
}