using FortuneTigerGame.Models;
using FortuneTigerGame.Services;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FortuneTigerGame.Forms
{
    public partial class MenuForm : Form
    {
        
        public MenuForm()
        {
            InitializeComponent();
            MusicPlayer.Instance.PlayBackgroundMusic("mainTheme");

            usernameLabel.Text = User.CurrentUser?.Name;
        }

        private void quitButton_Click(object sender, System.EventArgs e)
        {
            this.Close();

        }

        private void farmButton_Click(object sender, System.EventArgs e)
        {
            FarmForm farmForm = new FarmForm();
            this.Hide();
            farmForm.ShowDialog();
            this.Close();

        }

        private void minigamesButton_Click(object sender, System.EventArgs e)
        {
            MusicPlayer.Instance.StopBackgroundMusic();
            MinigameForm minigameForm = new MinigameForm();
            this.Hide();
            minigameForm.ShowDialog();
            this.Close();
        }

        private void storeButton_Click(object sender, System.EventArgs e)
        {
            StoreForm storeForm = new StoreForm();
            this.Hide();
            storeForm.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            User user = new User
            {
                Name = "Anônimo",
                Password = "senha",
                Email = "email",
                CPF = "123.456.789-10",
            };
            User.SetCurrentUser(user);

            user.SetBalance(5000000);
        }
    }
}
