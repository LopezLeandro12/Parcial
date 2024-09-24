namespace Parcial
{
    partial class Frm_juegoA
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
            this.Barra_A = new System.Windows.Forms.ProgressBar();
            this.Personaje = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_start_agu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_evos_agu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Personaje)).BeginInit();
            this.SuspendLayout();
            // 
            // Barra_A
            // 
            this.Barra_A.Location = new System.Drawing.Point(-3, -1);
            this.Barra_A.Name = "Barra_A";
            this.Barra_A.Size = new System.Drawing.Size(804, 35);
            this.Barra_A.TabIndex = 0;
            this.Barra_A.Click += new System.EventHandler(this.Barra_A_Click);
            // 
            // Personaje
            // 
            this.Personaje.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Personaje.Image = global::Parcial.Properties.Resources.descarga__1_;
            this.Personaje.Location = new System.Drawing.Point(306, 171);
            this.Personaje.Name = "Personaje";
            this.Personaje.Size = new System.Drawing.Size(136, 131);
            this.Personaje.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Personaje.TabIndex = 1;
            this.Personaje.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digivolution!!!";
            // 
            // Btn_start_agu
            // 
            this.Btn_start_agu.Location = new System.Drawing.Point(432, 106);
            this.Btn_start_agu.Name = "Btn_start_agu";
            this.Btn_start_agu.Size = new System.Drawing.Size(91, 41);
            this.Btn_start_agu.TabIndex = 3;
            this.Btn_start_agu.Text = "Start";
            this.Btn_start_agu.UseVisualStyleBackColor = true;
            this.Btn_start_agu.Click += new System.EventHandler(this.Btn_start_agu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(328, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 37);
            this.label2.TabIndex = 4;
            // 
            // lbl_evos_agu
            // 
            this.lbl_evos_agu.AutoSize = true;
            this.lbl_evos_agu.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_evos_agu.Location = new System.Drawing.Point(299, 305);
            this.lbl_evos_agu.Name = "lbl_evos_agu";
            this.lbl_evos_agu.Size = new System.Drawing.Size(0, 37);
            this.lbl_evos_agu.TabIndex = 5;
            this.lbl_evos_agu.Click += new System.EventHandler(this.lbl_evos_agu_Click);
            // 
            // Frm_juegoA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_evos_agu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_start_agu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Personaje);
            this.Controls.Add(this.Barra_A);
            this.Name = "Frm_juegoA";
            this.Text = "Agumon";
            ((System.ComponentModel.ISupportInitialize)(this.Personaje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar Barra_A;
        private System.Windows.Forms.PictureBox Personaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_start_agu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_evos_agu;
    }
}