namespace dotnet_tamagotchi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxPokemon = new System.Windows.Forms.ComboBox();
            this.buttonSelectPokemon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxPokemon
            // 
            this.comboBoxPokemon.FormattingEnabled = true;
            this.comboBoxPokemon.Location = new System.Drawing.Point(12, 12);
            this.comboBoxPokemon.Name = "comboBoxPokemon";
            this.comboBoxPokemon.Size = new System.Drawing.Size(260, 21);
            this.comboBoxPokemon.TabIndex = 0;
            this.comboBoxPokemon.SelectedIndexChanged += new System.EventHandler(this.comboBoxPokemon_SelectedIndexChanged);
            // 
            // buttonSelectPokemon
            // 
            this.buttonSelectPokemon.Location = new System.Drawing.Point(12, 39);
            this.buttonSelectPokemon.Name = "buttonSelectPokemon";
            this.buttonSelectPokemon.Size = new System.Drawing.Size(260, 23);
            this.buttonSelectPokemon.TabIndex = 1;
            this.buttonSelectPokemon.Text = "Selecionar Pokémon";
            this.buttonSelectPokemon.UseVisualStyleBackColor = true;
            this.buttonSelectPokemon.Click += new System.EventHandler(this.buttonSelectPokemon_Click);
            // 
            // Form1
            // 
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonSelectPokemon);
            this.Controls.Add(this.comboBoxPokemon);
            this.Name = "Form1";
            this.Text = "PokeTamagotchi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPokemon;
        private System.Windows.Forms.Button buttonSelectPokemon;
    }
}
