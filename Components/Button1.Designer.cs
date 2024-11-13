namespace FortuneTigerGame.Components
{
    partial class Button1
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonText
            // 
            this.buttonText.BackColor = System.Drawing.Color.Transparent;
            this.buttonText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonText.Font = new System.Drawing.Font("Asia Tiger", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonText.Location = new System.Drawing.Point(0, 0);
            this.buttonText.Name = "buttonText";
            this.buttonText.Size = new System.Drawing.Size(450, 90);
            this.buttonText.TabIndex = 0;
            this.buttonText.Text = "label1";
            this.buttonText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Button1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 44F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonText);
            this.Font = new System.Drawing.Font("Asia Tiger", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 11, 8, 11);
            this.Name = "Button1";
            this.Size = new System.Drawing.Size(450, 90);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label buttonText;
    }
}
