namespace FortuneTigerGame.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.formPanel = new System.Windows.Forms.Panel();
            this.cpf_txt = new System.Windows.Forms.MaskedTextBox();
            this.anonymous_account = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pass_txt = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.enterButton = new FortuneTigerGame.Components.Button1();
            this.formPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // formPanel
            // 
            this.formPanel.BackColor = System.Drawing.Color.Transparent;
            this.formPanel.Controls.Add(this.name_txt);
            this.formPanel.Controls.Add(this.pass_txt);
            this.formPanel.Controls.Add(this.email_txt);
            this.formPanel.Controls.Add(this.cpf_txt);
            this.formPanel.Controls.Add(this.anonymous_account);
            this.formPanel.Controls.Add(this.enterButton);
            this.formPanel.Controls.Add(this.label3);
            this.formPanel.Controls.Add(this.label2);
            this.formPanel.Controls.Add(this.label1);
            this.formPanel.Controls.Add(this.label);
            this.formPanel.Font = new System.Drawing.Font("Asia Tiger", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formPanel.Location = new System.Drawing.Point(99, 119);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(416, 534);
            this.formPanel.TabIndex = 0;
            // 
            // cpf_txt
            // 
            this.cpf_txt.Location = new System.Drawing.Point(25, 338);
            this.cpf_txt.Mask = "000.000.000-00";
            this.cpf_txt.Name = "cpf_txt";
            this.cpf_txt.Size = new System.Drawing.Size(369, 48);
            this.cpf_txt.TabIndex = 3;
            // 
            // anonymous_account
            // 
            this.anonymous_account.BackColor = System.Drawing.Color.Transparent;
            this.anonymous_account.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anonymous_account.Font = new System.Drawing.Font("Asia Tiger", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anonymous_account.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.anonymous_account.Location = new System.Drawing.Point(112, 473);
            this.anonymous_account.Name = "anonymous_account";
            this.anonymous_account.Size = new System.Drawing.Size(188, 29);
            this.anonymous_account.TabIndex = 5;
            this.anonymous_account.Text = "Entrar sem conta!";
            this.anonymous_account.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.anonymous_account.Click += new System.EventHandler(this.Anonymous_account_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(41, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 42);
            this.label3.TabIndex = 6;
            this.label3.Text = "CPF:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(43, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 42);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // email_txt
            // 
            this.email_txt.AccessibleDescription = "";
            this.email_txt.AccessibleName = "";
            this.email_txt.Location = new System.Drawing.Point(25, 243);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(369, 48);
            this.email_txt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(40, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Senha:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pass_txt
            // 
            this.pass_txt.AccessibleDescription = "";
            this.pass_txt.AccessibleName = "";
            this.pass_txt.Location = new System.Drawing.Point(25, 148);
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.Size = new System.Drawing.Size(369, 48);
            this.pass_txt.TabIndex = 1;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.ForeColor = System.Drawing.Color.Gold;
            this.label.Location = new System.Drawing.Point(43, 20);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(84, 42);
            this.label.TabIndex = 0;
            this.label.Text = "Nome:";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // name_txt
            // 
            this.name_txt.AccessibleDescription = "";
            this.name_txt.AccessibleName = "";
            this.name_txt.Location = new System.Drawing.Point(25, 53);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(369, 48);
            this.name_txt.TabIndex = 0;
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(187)))), ((int)(((byte)(8)))));
            this.enterButton.BorderRadius = 28;
            this.enterButton.ButtonText = "Entrar!";
            this.enterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enterButton.Font = new System.Drawing.Font("Asia Tiger", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterButton.ForeColor = System.Drawing.Color.White;
            this.enterButton.Location = new System.Drawing.Point(33, 401);
            this.enterButton.Margin = new System.Windows.Forms.Padding(8, 11, 8, 11);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(352, 66);
            this.enterButton.TabIndex = 4;
            this.enterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1060, 717);
            this.Controls.Add(this.formPanel);
            this.Font = new System.Drawing.Font("Asia Tiger", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fortune Tiger Game";
            this.formPanel.ResumeLayout(false);
            this.formPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel formPanel;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pass_txt;
        private System.Windows.Forms.Label anonymous_account;
        private Components.Button1 enterButton;
        private System.Windows.Forms.MaskedTextBox cpf_txt;
    }
}

