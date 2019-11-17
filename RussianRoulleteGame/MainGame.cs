using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussianRoulleteGame
{
    public partial class MainGame : Form
    {
        Random Rnd = new Random();
        GameService bullets = new GameService();
        int totalShoot = 6;//sets the value for totalshots
        int gunTry = 2;//sets the value for gun
        public MainGame()
        {
            InitializeComponent();
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            war.Image = RussianRoulleteGame.Properties.Resources.loa;//Here i add the image on the picturebox
            System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(RussianRoulleteGame.Properties.Resources.Loadings);//Add sound here
            soundPlayer.Play();//play sound
            loadBtn.Enabled = false;
            bullets.GameLoad = 1;
        }

        private void spinBtn_Click(object sender, EventArgs e)
        {
            war.Image = RussianRoulleteGame.Properties.Resources.spinchaaaam;//Here i add the image on the picturebox
            System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(RussianRoulleteGame.Properties.Resources.Loadings);//Add sound here
            soundPlayer.Play();//play sound
            spinBtn.Enabled = false;
            bullets.GameSpin = Rnd.Next(1, 6);//Random class variable
        }

        private void shootBtn_Click(object sender, EventArgs e)
        {
            war.Image = RussianRoulleteGame.Properties.Resources.shoooot;//Here i add the image on the picturebox
            System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(RussianRoulleteGame.Properties.Resources.Shot);//Add sound here
            soundPlayer.Play();//play sound

            if (totalShoot > 0 && bullets.GameSpin == 1)
            {
                MessageBox.Show("You loose the Shoot");
                shootBtn.Enabled = false;
            }
            else if (totalShoot > 0 && bullets.GameSpin != 1)
            {
                MessageBox.Show("This is Blank Fire");
                totalShoot = totalShoot - 1;//minus one from total
                bullets.GameSpin = bullets.GameShootLoop(bullets.GameSpin);

            }
        }

        private void shootAwayBtn_Click(object sender, EventArgs e)
        {
            war.Image = RussianRoulleteGame.Properties.Resources.shootaw;//Here i add the image on the picturebox
            System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(RussianRoulleteGame.Properties.Resources.Shot);//Add sound here
            soundPlayer.Play();//play sound

            if (totalShoot > 0 && bullets.GameSpin == 1 && gunTry == 2)
            {

                MessageBox.Show("you win you score is 200");
                shootAwayBtn.Enabled = false;
                shootBtn.Enabled = false;


            }
            if (totalShoot > 0 && bullets.GameSpin == 1 && gunTry == 1)
            {

                MessageBox.Show("you win and your score is 100");//display the meesage
                shootAwayBtn.Enabled = false;
                shootBtn.Enabled = false;

            }

            else if (totalShoot > 0 && bullets.GameSpin != 1)
            {
                MessageBox.Show("Blank Fire");
                totalShoot = totalShoot - 1;
                bullets.GameSpin = bullets.GameShootLoop(bullets.GameSpin);

            }
        }

        private void playAgainBtn_Click(object sender, EventArgs e)
        {
            MainGame mainGame = new MainGame();
            mainGame.Show();
            this.Hide();
        }
    }
}
