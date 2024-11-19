namespace FortuneTigerGame.Forms
{
    partial class StoreForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoreForm));
            this.menuButton = new System.Windows.Forms.Panel();
            this.buy4 = new System.Windows.Forms.PictureBox();
            this.buy1 = new System.Windows.Forms.PictureBox();
            this.buy2 = new System.Windows.Forms.PictureBox();
            this.buy3 = new System.Windows.Forms.PictureBox();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.buy1Price = new System.Windows.Forms.Label();
            this.buy3Price = new System.Windows.Forms.Label();
            this.buy4Price = new System.Windows.Forms.Label();
            this.buy2Price = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.buy4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buy3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.Transparent;
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.Location = new System.Drawing.Point(981, 27);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(46, 46);
            this.menuButton.TabIndex = 2;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // buy4
            // 
            this.buy4.BackColor = System.Drawing.Color.Transparent;
            this.buy4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buy4.Image = ((System.Drawing.Image)(resources.GetObject("buy4.Image")));
            this.buy4.Location = new System.Drawing.Point(659, 238);
            this.buy4.Name = "buy4";
            this.buy4.Size = new System.Drawing.Size(167, 255);
            this.buy4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buy4.TabIndex = 3;
            this.buy4.TabStop = false;
            this.buy4.Click += new System.EventHandler(this.HandleItemClick);
            // 
            // buy1
            // 
            this.buy1.BackColor = System.Drawing.Color.Transparent;
            this.buy1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buy1.Image = ((System.Drawing.Image)(resources.GetObject("buy1.Image")));
            this.buy1.Location = new System.Drawing.Point(247, 238);
            this.buy1.Name = "buy1";
            this.buy1.Size = new System.Drawing.Size(155, 123);
            this.buy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buy1.TabIndex = 4;
            this.buy1.TabStop = false;
            this.buy1.Click += new System.EventHandler(this.HandleItemClick);
            // 
            // buy2
            // 
            this.buy2.BackColor = System.Drawing.Color.Transparent;
            this.buy2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buy2.Image = ((System.Drawing.Image)(resources.GetObject("buy2.Image")));
            this.buy2.Location = new System.Drawing.Point(247, 425);
            this.buy2.Name = "buy2";
            this.buy2.Size = new System.Drawing.Size(155, 123);
            this.buy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buy2.TabIndex = 5;
            this.buy2.TabStop = false;
            this.buy2.Click += new System.EventHandler(this.HandleItemClick);
            // 
            // buy3
            // 
            this.buy3.BackColor = System.Drawing.Color.Transparent;
            this.buy3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buy3.Image = ((System.Drawing.Image)(resources.GetObject("buy3.Image")));
            this.buy3.Location = new System.Drawing.Point(437, 335);
            this.buy3.Name = "buy3";
            this.buy3.Size = new System.Drawing.Size(155, 123);
            this.buy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buy3.TabIndex = 6;
            this.buy3.TabStop = false;
            this.buy3.Click += new System.EventHandler(this.HandleItemClick);
            // 
            // moneyLabel
            // 
            this.moneyLabel.BackColor = System.Drawing.Color.Transparent;
            this.moneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F);
            this.moneyLabel.ForeColor = System.Drawing.Color.LimeGreen;
            this.moneyLabel.Location = new System.Drawing.Point(247, 18);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(579, 64);
            this.moneyLabel.TabIndex = 7;
            this.moneyLabel.Text = "000";
            this.moneyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buy1Price
            // 
            this.buy1Price.BackColor = System.Drawing.Color.Transparent;
            this.buy1Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buy1Price.ForeColor = System.Drawing.Color.Yellow;
            this.buy1Price.Location = new System.Drawing.Point(249, 354);
            this.buy1Price.Name = "buy1Price";
            this.buy1Price.Size = new System.Drawing.Size(153, 42);
            this.buy1Price.TabIndex = 20;
            this.buy1Price.Text = "000";
            this.buy1Price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buy3Price
            // 
            this.buy3Price.BackColor = System.Drawing.Color.Transparent;
            this.buy3Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buy3Price.ForeColor = System.Drawing.Color.Yellow;
            this.buy3Price.Location = new System.Drawing.Point(408, 451);
            this.buy3Price.Name = "buy3Price";
            this.buy3Price.Size = new System.Drawing.Size(214, 42);
            this.buy3Price.TabIndex = 22;
            this.buy3Price.Text = "000";
            this.buy3Price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buy4Price
            // 
            this.buy4Price.BackColor = System.Drawing.Color.Transparent;
            this.buy4Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buy4Price.ForeColor = System.Drawing.Color.Magenta;
            this.buy4Price.Location = new System.Drawing.Point(628, 488);
            this.buy4Price.Name = "buy4Price";
            this.buy4Price.Size = new System.Drawing.Size(232, 42);
            this.buy4Price.TabIndex = 23;
            this.buy4Price.Text = "000";
            this.buy4Price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buy2Price
            // 
            this.buy2Price.BackColor = System.Drawing.Color.Transparent;
            this.buy2Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buy2Price.ForeColor = System.Drawing.Color.Yellow;
            this.buy2Price.Location = new System.Drawing.Point(198, 540);
            this.buy2Price.Name = "buy2Price";
            this.buy2Price.Size = new System.Drawing.Size(254, 42);
            this.buy2Price.TabIndex = 21;
            this.buy2Price.Text = "000";
            this.buy2Price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1060, 717);
            this.Controls.Add(this.buy4);
            this.Controls.Add(this.buy2);
            this.Controls.Add(this.buy2Price);
            this.Controls.Add(this.buy4Price);
            this.Controls.Add(this.buy3);
            this.Controls.Add(this.buy3Price);
            this.Controls.Add(this.buy1);
            this.Controls.Add(this.buy1Price);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.menuButton);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fortune Tiger Game";
            ((System.ComponentModel.ISupportInitialize)(this.buy4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buy3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuButton;
        private System.Windows.Forms.PictureBox buy4;
        private System.Windows.Forms.PictureBox buy1;
        private System.Windows.Forms.PictureBox buy2;
        private System.Windows.Forms.PictureBox buy3;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.Label buy1Price;
        private System.Windows.Forms.Label buy3Price;
        private System.Windows.Forms.Label buy4Price;
        private System.Windows.Forms.Label buy2Price;
    }
}

