using FortuneTigerGame.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FortuneTigerGame.Forms
{
    public partial class StoreForm : Form
    {

        private User currentUser;
        private long userBalance;

        private Dictionary<string, int> shopItems;

        public StoreForm()
        {
            InitializeComponent();

            shopItems = new Dictionary<string, int>()
            {
                { buy1.Name, 5_000 },    // Chest I - Moderate rewards
                { buy2.Name, 20_000 },   // Chest II - Rare rewards
                { buy3.Name, 50_000 },   // Chest III - Epic rewards
                { buy4.Name, 250_000 }   // Fortune Tiger Card - Legendary reward
            };

            currentUser = User.CurrentUser;
            userBalance = User.CurrentUser.Balance;

            UpdateCoinLabel();
            UpdatePriceLabels();
        }

        private void HandleItemClick(object sender, EventArgs e)
        {
            var itemShop = sender as PictureBox;
            //MessageBox.Show($"{itemShop.Name}");
            BuyItem(itemShop.Name);
        }

        private void BuyItem(string itemName)
        {
            if (shopItems.ContainsKey(itemName) && userBalance >= shopItems[itemName])
            {
                currentUser.SetBalance(userBalance);
                UpdateCoinLabel();

                HandleChestRewards(itemName);
            }
            else
            {
                MessageBox.Show("Você não tem moedas suficientes!", "Compra Falhou");
            }
        }

        private void HandleChestRewards(string itemName)
        {
            Random random = new Random();
            long reward;
            string resultMessage = "";
            string oddsMessage = "";
            string confirmationMessage = "";
            int specialReward = random.Next(0, 3);

            switch (itemName)
            {
                case "buy1": // Chest I (Moderate rewards)
                             // 50% chance for a reward
                    if (random.Next(0, 2) == 0)
                    {
                        reward = random.Next(2000, 5000);
                        resultMessage = $"Você ganhou uma recompensa moderada de ¢ {reward:N0}!";
                    }
                    else
                    {
                        reward = -random.Next(1000, 2000);
                        resultMessage = $"Você perdeu ¢ {-reward:N0}.";
                    }
                    oddsMessage = "50% chance de obter uma recompensa!";
                    break;

                case "buy2": // Chest II (Rare rewards)
                             // 60% chance for a reward
                    if (random.Next(0, 10) < 6)
                    {
                        reward = random.Next(10000, 25000);
                        resultMessage = $"Você ganhou uma recompensa rara de ¢ {reward:N0}!";
                    }
                    else
                    {
                        reward = -random.Next(5000, 10000);
                        resultMessage = $"Você perdeu ¢ {-reward:N0}.";
                    }
                    oddsMessage = "60% chance de obter uma recompensa rara!";
                    break;

                case "buy3": // Chest III (Epic rewards)
                             // 70% chance for a reward
                    if (random.Next(0, 10) < 7)
                    {
                        reward = random.Next(30000, 100000);
                        resultMessage = $"Você ganhou uma recompensa épica de ¢ {reward:N0}!";
                    }
                    else
                    {
                        reward = -random.Next(10000, 30000);
                        resultMessage = $"Você perdeu ¢ {-reward:N0}.";
                    }
                    oddsMessage = "70% chance de obter uma recompensa épica!";
                    break;

                case "buy4": // Fortune Tiger Card (Legendary rewards)
                             // 30% chance de obter uma grande recompensa (muito rara)
                    if (random.Next(0, 10) < 3)
                    {
                        if (specialReward == 0)
                        {
                            reward = currentUser.Balance * 2; // Dobrar o saldo atual
                            resultMessage = $"Você dobrou seu saldo atual! ¢ {reward:N0}";
                        }
                        else if (specialReward == 1)
                        {
                            FarmForm.SavedClickMultiplier += 1000;  // Aumenta o multiplicador em 1000
                            reward = 0;
                            resultMessage = "Você aumentou seu multiplicador de cliques em 1000!";
                        }
                        else
                        {
                            reward = random.Next(500_000, 10_000_000);
                            resultMessage = $"Você ganhou uma recompensa épica de ¢ {reward:N0}!";
                        }
                    }
                    else
                    {
                        // Perde uma quantidade considerável de dinheiro
                        reward = -random.Next(100_000, 2_000_000);
                        resultMessage = "Você perdeu ¢ " + reward.ToString("N0") + "!";
                    }
                    oddsMessage = "30% chance de obter uma recompensa lendária!";
                    confirmationMessage = "A recompensa lendária pode ser incrível... Você está pronto para descobrir?";
                    break;

                default:
                    reward = 0;
                    resultMessage = "Nada aconteceu!";
                    break;
            }

            if (itemName == "buy4")
            {
                DialogResult confirmationResult = MessageBox.Show(
                    confirmationMessage,
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmationResult == DialogResult.Yes)
                {
                    userBalance -= shopItems[itemName];
                    userBalance += reward;
                    currentUser.SetBalance(userBalance);
                    UpdateCoinLabel();

                    string finalMessage = $"{oddsMessage}\n\n{resultMessage}\nSaldo Atual: ¢ {userBalance:N0}";
                    MessageBox.Show(finalMessage, "Resultado da Compra");
                }
                else
                {
                    MessageBox.Show("Você cancelou a abertura do item lendário.", "Ação Cancelada");
                }

            }
            else
            {
                userBalance -= shopItems[itemName];
                userBalance += reward;
                currentUser.SetBalance(userBalance);
                UpdateCoinLabel();

                string finalMessage = $"{oddsMessage}\n\n{resultMessage}\nSaldo Atual: ¢ {userBalance:N0}";
                MessageBox.Show(finalMessage, "Resultado da Compra");
            }
            
        }



        private void UpdateCoinLabel()
        {
            moneyLabel.Text = $"¢ {userBalance.ToString("N0")}";
            if (userBalance >= 0)
            {
                moneyLabel.ForeColor = Color.LimeGreen;
            }
            else
            {
                moneyLabel.ForeColor = Color.Red;
            }
        }

        private void UpdatePriceLabels()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Label priceLabel && priceLabel.Name.EndsWith("Price")){

                    string itemName = priceLabel.Name.Replace("Price", "");
                    Console.WriteLine($"Found price label: {priceLabel.Name} for item {itemName}");

                    if (shopItems.ContainsKey(itemName))
                    {
                        priceLabel.Text = $"¢ {shopItems[itemName]:N0}";
                    }
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            this.Hide();
            menuForm.ShowDialog();
            this.Close();
        }        
    }
}
