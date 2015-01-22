using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MathApp;


namespace Math_Quiz_Game
{


    public partial class Form1 : Form
    {
        MathProblem mp = new MathProblem();
        public Form1()
        {
            InitializeComponent();
            Leftlabel.Text = mp.CreateRandomMathProblem();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(mp.ChecksUserInput(Answer.Text).ToString());
            Leftlabel.Text = mp.CreateRandomMathProblem();
            Answer.Clear();
        }

    }
}
