namespace CheckBoxEEventos
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxMaca = new System.Windows.Forms.CheckBox();
            this.checkBoxPera = new System.Windows.Forms.CheckBox();
            this.checkBoxUva = new System.Windows.Forms.CheckBox();
            this.checkBoxAbacaxi = new System.Windows.Forms.CheckBox();
            this.checkBoxMorango = new System.Windows.Forms.CheckBox();
            this.checkBoxBanana = new System.Windows.Forms.CheckBox();
            this.checkBoxMamao = new System.Windows.Forms.CheckBox();
            this.buttonfruta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(32, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escolha a Fruta :";
            // 
            // checkBoxMaca
            // 
            this.checkBoxMaca.AutoSize = true;
            this.checkBoxMaca.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxMaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMaca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxMaca.Location = new System.Drawing.Point(36, 82);
            this.checkBoxMaca.Name = "checkBoxMaca";
            this.checkBoxMaca.Size = new System.Drawing.Size(64, 20);
            this.checkBoxMaca.TabIndex = 1;
            this.checkBoxMaca.Text = "Maça";
            this.checkBoxMaca.UseVisualStyleBackColor = false;
            this.checkBoxMaca.CheckedChanged += new System.EventHandler(this.checkBoxMaca_CheckedChanged);
            // 
            // checkBoxPera
            // 
            this.checkBoxPera.AutoSize = true;
            this.checkBoxPera.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxPera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPera.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxPera.Location = new System.Drawing.Point(36, 105);
            this.checkBoxPera.Name = "checkBoxPera";
            this.checkBoxPera.Size = new System.Drawing.Size(59, 20);
            this.checkBoxPera.TabIndex = 1;
            this.checkBoxPera.Text = "Pêra";
            this.checkBoxPera.UseVisualStyleBackColor = false;
            this.checkBoxPera.CheckedChanged += new System.EventHandler(this.checkBoxPera_CheckedChanged);
            // 
            // checkBoxUva
            // 
            this.checkBoxUva.AutoSize = true;
            this.checkBoxUva.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxUva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxUva.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxUva.Location = new System.Drawing.Point(36, 128);
            this.checkBoxUva.Name = "checkBoxUva";
            this.checkBoxUva.Size = new System.Drawing.Size(54, 20);
            this.checkBoxUva.TabIndex = 1;
            this.checkBoxUva.Text = "Uva";
            this.checkBoxUva.UseVisualStyleBackColor = false;
            this.checkBoxUva.CheckedChanged += new System.EventHandler(this.checkBoxUva_CheckedChanged);
            // 
            // checkBoxAbacaxi
            // 
            this.checkBoxAbacaxi.AutoSize = true;
            this.checkBoxAbacaxi.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxAbacaxi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAbacaxi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxAbacaxi.Location = new System.Drawing.Point(36, 151);
            this.checkBoxAbacaxi.Name = "checkBoxAbacaxi";
            this.checkBoxAbacaxi.Size = new System.Drawing.Size(82, 20);
            this.checkBoxAbacaxi.TabIndex = 1;
            this.checkBoxAbacaxi.Text = "Abacaxi";
            this.checkBoxAbacaxi.UseVisualStyleBackColor = false;
            this.checkBoxAbacaxi.CheckedChanged += new System.EventHandler(this.checkBoxAbacaxi_CheckedChanged);
            // 
            // checkBoxMorango
            // 
            this.checkBoxMorango.AutoSize = true;
            this.checkBoxMorango.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxMorango.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMorango.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxMorango.Location = new System.Drawing.Point(36, 174);
            this.checkBoxMorango.Name = "checkBoxMorango";
            this.checkBoxMorango.Size = new System.Drawing.Size(87, 20);
            this.checkBoxMorango.TabIndex = 1;
            this.checkBoxMorango.Text = "Morango";
            this.checkBoxMorango.UseVisualStyleBackColor = false;
            this.checkBoxMorango.CheckedChanged += new System.EventHandler(this.checkBoxMorango_CheckedChanged);
            // 
            // checkBoxBanana
            // 
            this.checkBoxBanana.AutoSize = true;
            this.checkBoxBanana.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxBanana.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBanana.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxBanana.Location = new System.Drawing.Point(36, 197);
            this.checkBoxBanana.Name = "checkBoxBanana";
            this.checkBoxBanana.Size = new System.Drawing.Size(79, 20);
            this.checkBoxBanana.TabIndex = 1;
            this.checkBoxBanana.Text = "Banana";
            this.checkBoxBanana.UseVisualStyleBackColor = false;
            this.checkBoxBanana.CheckedChanged += new System.EventHandler(this.checkBoxBanana_CheckedChanged);
            // 
            // checkBoxMamao
            // 
            this.checkBoxMamao.AutoSize = true;
            this.checkBoxMamao.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxMamao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMamao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxMamao.Location = new System.Drawing.Point(36, 220);
            this.checkBoxMamao.Name = "checkBoxMamao";
            this.checkBoxMamao.Size = new System.Drawing.Size(77, 20);
            this.checkBoxMamao.TabIndex = 1;
            this.checkBoxMamao.Text = "Mamão";
            this.checkBoxMamao.UseVisualStyleBackColor = false;
            this.checkBoxMamao.CheckedChanged += new System.EventHandler(this.checkBoxMamao_CheckedChanged);
            // 
            // buttonfruta
            // 
            this.buttonfruta.BackColor = System.Drawing.Color.LightGray;
            this.buttonfruta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonfruta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonfruta.ForeColor = System.Drawing.Color.Black;
            this.buttonfruta.Location = new System.Drawing.Point(329, 115);
            this.buttonfruta.Name = "buttonfruta";
            this.buttonfruta.Size = new System.Drawing.Size(137, 40);
            this.buttonfruta.TabIndex = 2;
            this.buttonfruta.Text = "Escolha a Fruta ao lado e clique aqui!!";
            this.buttonfruta.UseVisualStyleBackColor = false;
            this.buttonfruta.Click += new System.EventHandler(this.buttonfruta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(567, 280);
            this.Controls.Add(this.buttonfruta);
            this.Controls.Add(this.checkBoxMamao);
            this.Controls.Add(this.checkBoxBanana);
            this.Controls.Add(this.checkBoxMorango);
            this.Controls.Add(this.checkBoxAbacaxi);
            this.Controls.Add(this.checkBoxUva);
            this.Controls.Add(this.checkBoxPera);
            this.Controls.Add(this.checkBoxMaca);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxMaca;
        private System.Windows.Forms.CheckBox checkBoxPera;
        private System.Windows.Forms.CheckBox checkBoxUva;
        private System.Windows.Forms.CheckBox checkBoxAbacaxi;
        private System.Windows.Forms.CheckBox checkBoxMorango;
        private System.Windows.Forms.CheckBox checkBoxBanana;
        private System.Windows.Forms.CheckBox checkBoxMamao;
        private System.Windows.Forms.Button buttonfruta;
    }
}

