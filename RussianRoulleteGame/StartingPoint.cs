using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussianRoulleteGame
{
    public partial class StartingPoint : Form
    {
        public StartingPoint()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainGame mainGame = new MainGame();
            mainGame.Show();
            this.Hide();
        }
    }
}
