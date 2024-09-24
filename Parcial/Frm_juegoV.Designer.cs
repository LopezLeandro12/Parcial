namespace Parcial
{
    partial class Frm_juegoV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_juegoV));
            this.Barra_V = new System.Windows.Forms.ProgressBar();
            this.Personaje = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_start_v = new System.Windows.Forms.Button();
            this.lbl_nombre_evo = new System.Windows.Forms.Label();
            this.lbl_evo_v = new System.Windows.Forms.Label();
            this.lbl_v = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Personaje)).BeginInit();
            this.SuspendLayout();
            // 
            // Barra_V
            // 
            this.Barra_V.Location = new System.Drawing.Point(1, 2);
            this.Barra_V.Name = "Barra_V";
            this.Barra_V.Size = new System.Drawing.Size(799, 30);
            this.Barra_V.TabIndex = 0;
            this.Barra_V.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // Personaje
            // 
            this.Personaje.Image = global::Parcial.Properties.Resources.WhatsApp_Image_2024_09_23_at_10_29_32_PM;
            this.Personaje.Location = new System.Drawing.Point(319, 139);
            this.Personaje.Name = "Personaje";
            this.Personaje.Size = new System.Drawing.Size(138, 130);
            this.Personaje.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Personaje.TabIndex = 1;
            this.Personaje.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(224, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digivolution!!";
            // 
            // btn_start_v
            // 
            this.btn_start_v.Location = new System.Drawing.Point(455, 87);
            this.btn_start_v.Name = "btn_start_v";
            this.btn_start_v.Size = new System.Drawing.Size(96, 41);
            this.btn_start_v.TabIndex = 3;
            this.btn_start_v.Text = "Start";
            this.btn_start_v.UseVisualStyleBackColor = true;
            this.btn_start_v.Click += new System.EventHandler(this.btn_start_v_Click);
            // 
            // lbl_nombre_evo
            // 
            this.lbl_nombre_evo.AutoSize = true;
            this.lbl_nombre_evo.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_evo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_nombre_evo.Location = new System.Drawing.Point(349, 300);
            this.lbl_nombre_evo.Name = "lbl_nombre_evo";
            this.lbl_nombre_evo.Size = new System.Drawing.Size(0, 37);
            this.lbl_nombre_evo.TabIndex = 4;
            // 
            // lbl_evo_v
            // 
            this.lbl_evo_v.AutoSize = true;
            this.lbl_evo_v.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_evo_v.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_evo_v.Location = new System.Drawing.Point(326, 289);
            this.lbl_evo_v.Name = "lbl_evo_v";
            this.lbl_evo_v.Size = new System.Drawing.Size(0, 37);
            this.lbl_evo_v.TabIndex = 5;
            // 
            // lbl_v
            // 
            this.lbl_v.AutoSize = true;
            this.lbl_v.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_v.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_v.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_v.Location = new System.Drawing.Point(344, 289);
            this.lbl_v.Name = "lbl_v";
            this.lbl_v.Size = new System.Drawing.Size(0, 35);
            this.lbl_v.TabIndex = 6;
            // 
            // Frm_juegoV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_v);
            this.Controls.Add(this.lbl_evo_v);
            this.Controls.Add(this.lbl_nombre_evo);
            this.Controls.Add(this.btn_start_v);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Personaje);
            this.Controls.Add(this.Barra_V);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_juegoV";
            this.Text = "Veemon";
            this.Load += new System.EventHandler(this.Frm_juegoV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Personaje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar Barra_V;
        private System.Windows.Forms.PictureBox Personaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_start_v;
        private System.Windows.Forms.Label lbl_nombre_evo;
        private System.Windows.Forms.Label lbl_evo_v;
        private System.Windows.Forms.Label lbl_v;
    }
}