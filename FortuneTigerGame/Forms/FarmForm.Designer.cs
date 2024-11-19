namespace FortuneTigerGame.Forms
{
    partial class FarmForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FarmForm));
            this.menuButton = new System.Windows.Forms.Panel();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.coin = new System.Windows.Forms.PictureBox();
            this.upgrade1 = new FortuneTigerGame.Components.Upgrade();
            this.upgrade2 = new FortuneTigerGame.Components.Upgrade();
            this.upgrade3 = new FortuneTigerGame.Components.Upgrade();
            this.upgrade4 = new FortuneTigerGame.Components.Upgrade();
            this.upgrade5 = new FortuneTigerGame.Components.Upgrade();
            this.hideMoney = new System.Windows.Forms.Panel();
            this.clickMultiplierLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.coin)).BeginInit();
            this.SuspendLayout();
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.Transparent;
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.Location = new System.Drawing.Point(961, 10);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(44, 45);
            this.menuButton.TabIndex = 1;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // moneyLabel
            // 
            this.moneyLabel.BackColor = System.Drawing.Color.Transparent;
            this.moneyLabel.Font = new System.Drawing.Font("Asia Tiger", 38F);
            this.moneyLabel.ForeColor = System.Drawing.Color.LimeGreen;
            this.moneyLabel.Location = new System.Drawing.Point(402, 576);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(506, 90);
            this.moneyLabel.TabIndex = 0;
            this.moneyLabel.Text = "000";
            this.moneyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // coin
            // 
            this.coin.BackColor = System.Drawing.Color.Transparent;
            this.coin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.coin.Image = ((System.Drawing.Image)(resources.GetObject("coin.Image")));
            this.coin.Location = new System.Drawing.Point(539, 266);
            this.coin.Name = "coin";
            this.coin.Size = new System.Drawing.Size(233, 233);
            this.coin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin.TabIndex = 3;
            this.coin.TabStop = false;
            this.coin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.coin_MouseDown);
            this.coin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.coin_MouseUp);
            // 
            // upgrade1
            // 
            this.upgrade1.BackColor = System.Drawing.Color.Transparent;
            this.upgrade1.IsBuyable = true;
            this.upgrade1.Location = new System.Drawing.Point(51, 97);
            this.upgrade1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.upgrade1.Name = "upgrade1";
            this.upgrade1.Size = new System.Drawing.Size(136, 94);
            this.upgrade1.TabIndex = 4;
            this.upgrade1.UpgradeCost = 250;
            this.upgrade1.UpgradeLevel = 1;
            this.upgrade1.UpgradeMultiplier = 2;
            this.upgrade1.UpgradeName = "Upgrade 1";
            // 
            // upgrade2
            // 
            this.upgrade2.BackColor = System.Drawing.Color.Transparent;
            this.upgrade2.IsBuyable = true;
            this.upgrade2.Location = new System.Drawing.Point(52, 222);
            this.upgrade2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.upgrade2.Name = "upgrade2";
            this.upgrade2.Size = new System.Drawing.Size(136, 94);
            this.upgrade2.TabIndex = 5;
            this.upgrade2.UpgradeCost = 1000;
            this.upgrade2.UpgradeLevel = 2;
            this.upgrade2.UpgradeMultiplier = 4;
            this.upgrade2.UpgradeName = "Upgrade 2";
            // 
            // upgrade3
            // 
            this.upgrade3.BackColor = System.Drawing.Color.Transparent;
            this.upgrade3.IsBuyable = true;
            this.upgrade3.Location = new System.Drawing.Point(52, 346);
            this.upgrade3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.upgrade3.Name = "upgrade3";
            this.upgrade3.Size = new System.Drawing.Size(136, 94);
            this.upgrade3.TabIndex = 6;
            this.upgrade3.UpgradeCost = 4000;
            this.upgrade3.UpgradeLevel = 3;
            this.upgrade3.UpgradeMultiplier = 6;
            this.upgrade3.UpgradeName = "Upgrade 3";
            // 
            // upgrade4
            // 
            this.upgrade4.BackColor = System.Drawing.Color.Transparent;
            this.upgrade4.IsBuyable = true;
            this.upgrade4.Location = new System.Drawing.Point(52, 471);
            this.upgrade4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.upgrade4.Name = "upgrade4";
            this.upgrade4.Size = new System.Drawing.Size(136, 94);
            this.upgrade4.TabIndex = 7;
            this.upgrade4.UpgradeCost = 10000;
            this.upgrade4.UpgradeLevel = 4;
            this.upgrade4.UpgradeMultiplier = 10;
            this.upgrade4.UpgradeName = "Upgrade 4";
            // 
            // upgrade5
            // 
            this.upgrade5.BackColor = System.Drawing.Color.Transparent;
            this.upgrade5.IsBuyable = true;
            this.upgrade5.Location = new System.Drawing.Point(52, 596);
            this.upgrade5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.upgrade5.Name = "upgrade5";
            this.upgrade5.Size = new System.Drawing.Size(136, 94);
            this.upgrade5.TabIndex = 8;
            this.upgrade5.UpgradeCost = 50000;
            this.upgrade5.UpgradeLevel = 5;
            this.upgrade5.UpgradeMultiplier = 20;
            this.upgrade5.UpgradeName = "Upgrade 5";
            // 
            // hideMoney
            // 
            this.hideMoney.BackColor = System.Drawing.Color.Transparent;
            this.hideMoney.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hideMoney.Location = new System.Drawing.Point(961, 619);
            this.hideMoney.Name = "hideMoney";
            this.hideMoney.Size = new System.Drawing.Size(75, 71);
            this.hideMoney.TabIndex = 9;
            this.hideMoney.Click += new System.EventHandler(this.hideMoney_Click);
            // 
            // clickMultiplierLabel
            // 
            this.clickMultiplierLabel.BackColor = System.Drawing.Color.Transparent;
            this.clickMultiplierLabel.Font = new System.Drawing.Font("Asia Tiger", 38F);
            this.clickMultiplierLabel.ForeColor = System.Drawing.Color.LimeGreen;
            this.clickMultiplierLabel.Location = new System.Drawing.Point(246, 10);
            this.clickMultiplierLabel.Name = "clickMultiplierLabel";
            this.clickMultiplierLabel.Size = new System.Drawing.Size(337, 68);
            this.clickMultiplierLabel.TabIndex = 10;
            this.clickMultiplierLabel.Text = "x000";
            this.clickMultiplierLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FarmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1060, 717);
            this.Controls.Add(this.clickMultiplierLabel);
            this.Controls.Add(this.hideMoney);
            this.Controls.Add(this.upgrade5);
            this.Controls.Add(this.upgrade4);
            this.Controls.Add(this.upgrade3);
            this.Controls.Add(this.upgrade2);
            this.Controls.Add(this.upgrade1);
            this.Controls.Add(this.coin);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.moneyLabel);
            this.Font = new System.Drawing.Font("Asia Tiger", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FarmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fortune Tiger Game";
            ((System.ComponentModel.ISupportInitialize)(this.coin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel menuButton;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.PictureBox coin;
        private Components.Upgrade upgrade1;
        private Components.Upgrade upgrade2;
        private Components.Upgrade upgrade3;
        private Components.Upgrade upgrade4;
        private Components.Upgrade upgrade5;
        private System.Windows.Forms.Panel hideMoney;
        private System.Windows.Forms.Label clickMultiplierLabel;
    }
}

