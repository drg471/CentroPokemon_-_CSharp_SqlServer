namespace Tarea3RodriguezGarciaDavid
{
    partial class CombateForm
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
            this.lstEquipoJugador = new System.Windows.Forms.ListBox();
            this.lstEquipoIA = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstCombate = new System.Windows.Forms.ListBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnIniciarCombate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstEquipoJugador
            // 
            this.lstEquipoJugador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(83)))), ((int)(((byte)(102)))));
            this.lstEquipoJugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstEquipoJugador.ForeColor = System.Drawing.Color.White;
            this.lstEquipoJugador.FormattingEnabled = true;
            this.lstEquipoJugador.ItemHeight = 25;
            this.lstEquipoJugador.Location = new System.Drawing.Point(209, 64);
            this.lstEquipoJugador.Name = "lstEquipoJugador";
            this.lstEquipoJugador.Size = new System.Drawing.Size(297, 179);
            this.lstEquipoJugador.TabIndex = 0;
            // 
            // lstEquipoIA
            // 
            this.lstEquipoIA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(83)))), ((int)(((byte)(102)))));
            this.lstEquipoIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstEquipoIA.ForeColor = System.Drawing.Color.White;
            this.lstEquipoIA.FormattingEnabled = true;
            this.lstEquipoIA.ItemHeight = 25;
            this.lstEquipoIA.Location = new System.Drawing.Point(855, 64);
            this.lstEquipoIA.Name = "lstEquipoIA";
            this.lstEquipoIA.Size = new System.Drawing.Size(290, 179);
            this.lstEquipoIA.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(231)))), ((int)(((byte)(245)))));
            this.label1.Location = new System.Drawing.Point(236, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "EQUIPO JUGADOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(231)))), ((int)(((byte)(245)))));
            this.label2.Location = new System.Drawing.Point(924, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "EQUIPO IA";
            // 
            // lstCombate
            // 
            this.lstCombate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(83)))), ((int)(((byte)(102)))));
            this.lstCombate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCombate.ForeColor = System.Drawing.Color.White;
            this.lstCombate.FormattingEnabled = true;
            this.lstCombate.ItemHeight = 25;
            this.lstCombate.Location = new System.Drawing.Point(309, 417);
            this.lstCombate.Name = "lstCombate";
            this.lstCombate.Size = new System.Drawing.Size(754, 254);
            this.lstCombate.TabIndex = 4;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(231)))), ((int)(((byte)(245)))));
            this.lblInfo.Location = new System.Drawing.Point(640, 88);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(85, 54);
            this.lblInfo.TabIndex = 5;
            this.lblInfo.Text = "VS";
            // 
            // btnIniciarCombate
            // 
            this.btnIniciarCombate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(83)))), ((int)(((byte)(102)))));
            this.btnIniciarCombate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(231)))), ((int)(((byte)(245)))));
            this.btnIniciarCombate.FlatAppearance.BorderSize = 4;
            this.btnIniciarCombate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarCombate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarCombate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(231)))), ((int)(((byte)(245)))));
            this.btnIniciarCombate.Location = new System.Drawing.Point(533, 278);
            this.btnIniciarCombate.Name = "btnIniciarCombate";
            this.btnIniciarCombate.Size = new System.Drawing.Size(299, 73);
            this.btnIniciarCombate.TabIndex = 6;
            this.btnIniciarCombate.Text = "INICIAR  COMBATE";
            this.btnIniciarCombate.UseVisualStyleBackColor = false;
            this.btnIniciarCombate.Click += new System.EventHandler(this.btnIniciarCombate_Click);
            // 
            // CombateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tarea3RodriguezGarciaDavid.Properties.Resources.stadium1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1362, 829);
            this.Controls.Add(this.btnIniciarCombate);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lstCombate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstEquipoIA);
            this.Controls.Add(this.lstEquipoJugador);
            this.Name = "CombateForm";
            this.Text = "Estadio Combate Pokemon";
            this.Load += new System.EventHandler(this.CombateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstEquipoJugador;
        private System.Windows.Forms.ListBox lstEquipoIA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstCombate;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnIniciarCombate;
    }
}