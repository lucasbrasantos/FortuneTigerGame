namespace FortuneTigerGame.Forms
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.usernameLabel = new System.Windows.Forms.Label();
            this.quitButton = new System.Windows.Forms.Panel();
            this.farmButton = new System.Windows.Forms.Panel();
            this.minigamesButton = new System.Windows.Forms.Panel();
            this.storeButton = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Font = new System.Drawing.Font("Asia Tiger", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.LimeGreen;
            this.usernameLabel.Location = new System.Drawing.Point(63, 22);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(175, 50);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "username";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.Color.Transparent;
            this.quitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quitButton.Location = new System.Drawing.Point(946, 203);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(53, 63);
            this.quitButton.TabIndex = 2;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // farmButton
            // 
            this.farmButton.BackColor = System.Drawing.Color.Transparent;
            this.farmButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.farmButton.Location = new System.Drawing.Point(424, 325);
            this.farmButton.Name = "farmButton";
            this.farmButton.Size = new System.Drawing.Size(211, 52);
            this.farmButton.TabIndex = 3;
            this.farmButton.Click += new System.EventHandler(this.farmButton_Click);
            // 
            // minigamesButton
            // 
            this.minigamesButton.BackColor = System.Drawing.Color.Transparent;
            this.minigamesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minigamesButton.Location = new System.Drawing.Point(424, 420);
            this.minigamesButton.Name = "minigamesButton";
            this.minigamesButton.Size = new System.Drawing.Size(211, 52);
            this.minigamesButton.TabIndex = 4;
            this.minigamesButton.Click += new System.EventHandler(this.minigamesButton_Click);
            // 
            // storeButton
            // 
            this.storeButton.BackColor = System.Drawing.Color.Transparent;
            this.storeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.storeButton.Location = new System.Drawing.Point(424, 512);
            this.storeButton.Name = "storeButton";
            this.storeButton.Size = new System.Drawing.Size(211, 52);
            this.storeButton.TabIndex = 5;
            this.storeButton.Click += new System.EventHandler(this.storeButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Audiowide", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 62);
            this.button1.TabIndex = 6;
            this.button1.Text = "Test, Create user";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1060, 717);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.storeButton);
            this.Controls.Add(this.minigamesButton);
            this.Controls.Add(this.farmButton);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.usernameLabel);
            this.Font = new System.Drawing.Font("Asia Tiger", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fortune Tiger Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Panel quitButton;
        private System.Windows.Forms.Panel farmButton;
        private System.Windows.Forms.Panel minigamesButton;
        private System.Windows.Forms.Panel storeButton;
        private System.Windows.Forms.Button button1;
    }
}

