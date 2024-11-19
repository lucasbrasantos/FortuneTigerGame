using FortuneTigerGame.Services;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FortuneTigerGame.Components
{
    public partial class Upgrade : UserControl
    {
        private string _upgradeName;
        private int _upgradeLevel;
        private int _upgradeCost;
        private int _upgradeMultiplier;
        public bool IsBuyable { get; set; }

        private ToolTip _toolTip;

        public event EventHandler OnUpgradeClicked;

        public Upgrade()
        {
            InitializeComponent();
            this.BackColor = Color.Transparent;
            this.DoubleBuffered = true;

            _toolTip = new ToolTip
            {
                BackColor = Color.Black,
                ForeColor = Color.White,
                OwnerDraw = true,
                InitialDelay = 200,
                ReshowDelay = 100,
                AutoPopDelay = 5000,
                IsBalloon = true,
            };

            IsBuyable = true;

            _toolTip.Draw += ToolTip_Draw;

            this.MouseEnter += Upgrade_MouseEnter;
            this.MouseLeave += Upgrade_MouseLeave;

        }

        public string UpgradeName
        {
            get { return _upgradeName; }
            set
            {
                _upgradeName = value;
                this.Invalidate();
            }
        }

        public int UpgradeLevel
        {
            get { return _upgradeLevel; }
            set
            {
                _upgradeLevel = value;
                this.Invalidate();
            }
        }

        public int UpgradeCost
        {
            get { return _upgradeCost; }
            set
            {
                _upgradeCost = value;
                this.Invalidate();
            }
        }

        public int UpgradeMultiplier
        {
            get { return _upgradeMultiplier; }
            set
            {
                _upgradeMultiplier = value;
                this.Invalidate();
            }
        }

        public void SaveState()
        {
            var upgradeData = new UpgradeData
            {
                UpgradeLevel = UpgradeLevel,
                UpgradeCost = UpgradeCost,
                UpgradeMultiplier = UpgradeMultiplier,
                IsBuyable = IsBuyable
            };
            UpgradeManager.SaveUpgradeState(UpgradeName, upgradeData);
        }

        private void LoadState()
        {
            var upgradeData = UpgradeManager.GetUpgradeState(UpgradeName);

            if (upgradeData == null)
            {
                upgradeData = new UpgradeData
                {
                    UpgradeLevel = this.UpgradeLevel,
                    UpgradeCost = this.UpgradeCost,
                    UpgradeMultiplier = this.UpgradeMultiplier,
                    IsBuyable = this.IsBuyable
                };

                UpgradeManager.SaveUpgradeState(UpgradeName, upgradeData);
            }
            else
            {
                this.UpgradeLevel = upgradeData.UpgradeLevel;
                this.UpgradeCost = upgradeData.UpgradeCost;
                this.UpgradeMultiplier = upgradeData.UpgradeMultiplier;
                this.IsBuyable = upgradeData.IsBuyable;
            }
            UpdateUpgradeUI();
        }


        private void UpdateUpgradeUI()
        {
            if (!IsBuyable)
            {
                this.Enabled = false;
                this.BackColor = Color.FromArgb(120, 0, 0, 0);
            }
            else
            {
                this.Enabled = true;
                this.BackColor = Color.Transparent;
            }
        }


        //-- UPGRADE CLICK
        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);

            OnUpgradeClicked?.Invoke(this, EventArgs.Empty);
        }

        private void Upgrade_MouseEnter(object sender, EventArgs e)
        {
            string tooltipText = $"Nome: {UpgradeName}\n" +
                                 $"Level: {UpgradeLevel}\n" +
                                 $"Preço: {UpgradeCost}\n" +
                                 $"Multiplicador: x{UpgradeMultiplier}";

            if (IsBuyable)
            {
                _toolTip.Show(tooltipText, this, 100, -50);
            }
        }

        private void Upgrade_MouseLeave(object sender, EventArgs e)
        {
            _toolTip.Hide(this);
        }
    
        public void SetIsBuyable(Boolean value)
        {
            IsBuyable = value;
        }

        public Boolean GetIsBuyable()
        {
            return IsBuyable;
        }

        private void ToolTip_Draw(object sender, DrawToolTipEventArgs e)
        {
            // Draw background with rounded corners
            e.Graphics.FillRectangle(new SolidBrush(Color.Black), e.Bounds);

            // Draw a border
            using (Pen borderPen = new Pen(Color.Gold, 2))
            {
                e.Graphics.DrawRectangle(borderPen, new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width - 1, e.Bounds.Height - 1));
            }

            // Draw the text with custom font
            Font tooltipFont = new Font("Segoe UI", 10, FontStyle.Bold);
            e.Graphics.DrawString(e.ToolTipText, tooltipFont, Brushes.White, new PointF(6, 6));
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (string.IsNullOrEmpty(UpgradeName))
            {
                Console.WriteLine("Error: UpgradeName is not set.");
                return;
            }
            LoadState();

        }
    }
}
