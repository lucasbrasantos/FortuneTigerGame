using FortuneTigerGame.Models;
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

        }

        private void storeButton_Click(object sender, System.EventArgs e)
        {

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

            user.SetBalance(500);
        }
    }
}
