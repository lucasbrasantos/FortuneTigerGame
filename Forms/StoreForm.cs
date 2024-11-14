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
                userBalance -= shopItems[itemName];
                currentUser.SetBalance(userBalance);
                UpdateCoinLabel();

                HandleChestRewards(itemName); // Handle the rewards
            }
            else
            {
                MessageBox.Show("Not enough coins!", "Purchase Failed");
            }
        }

        private void HandleChestRewards(string itemName)
        {
            Random random = new Random();
            long reward;

            switch (itemName)
            {
                case "buy1": // Chest I
                    reward = random.Next(0, 2) == 0
                        ? random.Next(2000, 5000)
                        : -random.Next(1000, 2000);
                    break;

                case "buy2": // Chest II
                    reward = random.Next(0, 10) < 6
                        ? random.Next(10000, 25000)
                        : -random.Next(5000, 10000);
                    break;

                case "buy3": // Chest III
                    reward = random.Next(0, 10) < 7
                        ? random.Next(30000, 100000)
                        : -random.Next(10000, 30000);
                    break;
                case "buy4": // Fortune Tiger Card
                    if (random.Next(0, 10) < 8)
                    {
                        int specialReward = random.Next(0, 3);
                        if (specialReward == 0)
                            reward = random.Next(200000, 500000);
                        else if (specialReward == 1)
                            reward = currentUser.Balance; // Double current balance
                        else
                        {
                            FarmForm.SavedClickMultiplier += 10;
                            reward = 0; // No coin reward, but increases click multiplier
                        }
                    }
                    else
                    {
                        reward = -50000;
                    }
                    break;
                default:
                    reward = 0;
                    break;
            }
            
            userBalance += reward;
            currentUser.SetBalance(userBalance);
            UpdateCoinLabel();

            // Display result to user
            MessageBox.Show(reward >= 0
                ? $"You won ¢ {reward:N0}!"
                : $"You lost ¢ {-reward:N0}!",
                "Reward Outcome");
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
