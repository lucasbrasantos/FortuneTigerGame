using FortuneTigerGame.Models;
using FortuneTigerGame.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FortuneTigerGame.Forms
{
    public partial class LoginForm : Form
    {
        public class UserDTO
        {
            public string Name { get; set; }
            public string Password { get; set; }
            public string Email { get; set; }
            public string CPF { get; set; }

            public void Deconstruct(out string name, out string password, out string email, out string cpf)
            {
                name = this.Name;
                password = this.Password;
                email = this.Email;
                cpf = this.CPF;
            }
        }
        private Timer _timer;

        public LoginForm()
        {
            InitializeComponent();

            MusicPlayer.Instance.PlayBackgroundMusic("loginTheme");

            enterButton.ButtonClicked += EnterButton_Click;

            _timer = new Timer();
            _timer.Interval = 2500;
            _timer.Tick += TimerTickHandler;
        }        

        private void EnterButton_Click(object sender, EventArgs e)
        {
            UserDTO userDTO = new UserDTO
            {
                Name = name_txt.Text.Trim(),
                Password = pass_txt.Text.Trim(),
                Email = email_txt.Text.Trim(),
                CPF = cpf_txt.Text.Replace(",", "."),
            };            

            if (ValidateData(userDTO)) // if the validation is ok
            {
                CreateUser(userDTO);
            }
        }

        private Boolean ValidateData(UserDTO data)
        {
            var (name,  password, email, cpf) = data; // desconstruct

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a valid name.", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(password) || password.Length < 6)
            {
                MessageBox.Show("Please enter a valid password (minimum 6 characters).", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!IsValidCPF(cpf))
            {
                MessageBox.Show("Please enter a valid CPF.", "Invalid CPF", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void CreateUser(UserDTO data)
        {
            User user = new User
            {
                Name = data.Name,
                Password = data.Password,
                Email = data.Email,
                CPF = data.CPF,
            };

            User.SetCurrentUser(user);

            //MessageBox.Show(user.ToString());

            DialogResult result = MessageBox.Show("Os dados estão corretos?", "Confirmar dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                OpenLoreForm();
            }
        }

        private void Anonymous_account_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                Name = "Anônimo",
                Password = "senha",
                Email = "email",
                CPF = "123.456.789-10",
            };

            User.SetCurrentUser(user);

            DialogResult result = MessageBox.Show("Desejar logar como anônimo?", "Confirmar dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                OpenLoreForm();
            }

        }

        private void OpenLoreForm()
        {
            MusicPlayer.Instance.FadeOut(1.4);

            _timer.Start();            
        }

        private void TimerTickHandler(object sender, EventArgs e)
        {
            _timer.Stop();

            LoreForm loreForm = new LoreForm();
            this.Hide();
            loreForm.ShowDialog();
            this.Close();
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidCPF(string cpf)
        {
            return cpf.Length == 14;
        }
        
    }
}
