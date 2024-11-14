using FortuneTigerGame.Components;
using FortuneTigerGame.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FortuneTigerGame.Forms
{
    public partial class FarmForm : Form
    {
        private static int _growthFactor = 10;
        private int _relativeDislocation = _growthFactor / 2;

        private User currentUser;
        private long userBalance;
        private int clickMultiplier = 1;
        public static int SavedClickMultiplier = 1;

        // -- big COin -- 
        private int sizeH = 233;
        private int sizeW = 233;
        private int posX = 539;
        private int posY = 266;

        public FarmForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // Fix glitching blanks

            currentUser = User.CurrentUser;
            userBalance = User.CurrentUser.Balance;
            clickMultiplier = SavedClickMultiplier;

            UpdateClickMultiplierLabel();
            UpdateCoinLabel();
            SetupUpgrades();
            ChangeUpgradeMultiplier();
        }

        private void UpgradeOnClick(object sender, EventArgs e)
        {
            var clickedUpgrade = sender as Upgrade;

            if (clickedUpgrade != null && currentUser.Balance >= clickedUpgrade.UpgradeCost && clickedUpgrade.IsBuyable)
            {
                userBalance -= clickedUpgrade.UpgradeCost;
                currentUser.SetBalance(userBalance);
                UpdateCoinLabel();

                clickMultiplier *= clickedUpgrade.UpgradeMultiplier;
                SavedClickMultiplier = clickMultiplier;
                UpdateClickMultiplierLabel();

                clickedUpgrade.SetIsBuyable(false);
                clickedUpgrade.Enabled = false;
                clickedUpgrade.BackColor = Color.FromArgb(120, 0, 0, 0);
                clickedUpgrade.Cursor = Cursors.No;

                clickedUpgrade.SaveState(); // Save the state
            }
        }

        private void ClickCoin()
        {
            userBalance += clickMultiplier;
            currentUser.SetBalance(userBalance);
            UpdateCoinLabel();
        }

        //update coin label in UI
        private void UpdateCoinLabel()
        {
            moneyLabel.Text = $"¢ {userBalance.ToString("N0")}";
        }

        // update click multiplier label in UI
        private void UpdateClickMultiplierLabel()
        {
            clickMultiplierLabel.Text = $"x{clickMultiplier}";
            if (userBalance >= 0)
            {
                moneyLabel.ForeColor = Color.LimeGreen;
            }
            else
            {
                moneyLabel.ForeColor = Color.Red;
            }
        }

        private void SetupUpgrades()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Upgrade upgrade)
                {
                    upgrade.OnUpgradeClicked += UpgradeOnClick;
                }
            }
        }

        private void ChangeUpgradeMultiplier()
        {
            upgrade1.UpgradeMultiplier = 2;
            upgrade2.UpgradeMultiplier = 4;
            upgrade3.UpgradeMultiplier = 8;
            upgrade4.UpgradeMultiplier = 8;
            upgrade5.UpgradeMultiplier = 16;
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            this.Hide();
            menuForm.ShowDialog();
            this.Close();
        }

        private void coin_MouseUp(object sender, MouseEventArgs e)
        {
            coin.Size = new Size(sizeH, sizeW);
            coin.Location = new Point(posX, posY);
        }

        private void coin_MouseDown(object sender, MouseEventArgs e)
        {
            coin.Size = new Size(sizeH + _growthFactor, sizeW + _growthFactor);
            coin.Location = new Point(posX - _relativeDislocation, posY - _relativeDislocation);

            ClickCoin();
            UpdateCoinLabel();
        }

        // Hide money on button click (bonus)
        private void hideMoney_Click(object sender, EventArgs e)
        {
            userBalance += clickMultiplier * 2000;
            currentUser.SetBalance(userBalance);
            UpdateCoinLabel();
        }
    }
}
