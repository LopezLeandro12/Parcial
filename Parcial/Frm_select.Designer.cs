namespace Parcial
{
    partial class Frm_select
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_select));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Vmon = new System.Windows.Forms.Button();
            this.Btn_Agumon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Parcial.Properties.Resources.WhatsApp_Image_2024_09_23_at_10_29_32_PM;
            this.pictureBox2.Location = new System.Drawing.Point(434, 96);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(91, 119);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Parcial.Properties.Resources.descarga__1_;
            this.pictureBox1.Location = new System.Drawing.Point(191, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 53);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecciona el Digimon...";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Btn_Vmon
            // 
            this.Btn_Vmon.Location = new System.Drawing.Point(424, 239);
            this.Btn_Vmon.Name = "Btn_Vmon";
            this.Btn_Vmon.Size = new System.Drawing.Size(123, 50);
            this.Btn_Vmon.TabIndex = 3;
            this.Btn_Vmon.Text = "Veemon";
            this.Btn_Vmon.UseVisualStyleBackColor = true;
            this.Btn_Vmon.Click += new System.EventHandler(this.Btn_Vmon_Click);
            // 
            // Btn_Agumon
            // 
            this.Btn_Agumon.Location = new System.Drawing.Point(191, 239);
            this.Btn_Agumon.Name = "Btn_Agumon";
            this.Btn_Agumon.Size = new System.Drawing.Size(118, 50);
            this.Btn_Agumon.TabIndex = 4;
            this.Btn_Agumon.Text = "Agumon";
            this.Btn_Agumon.UseVisualStyleBackColor = true;
            this.Btn_Agumon.Click += new System.EventHandler(this.Btn_Agumon_Click);
            // 
            // Frm_select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Agumon);
            this.Controls.Add(this.Btn_Vmon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_select";
            this.Text = "Seleccion de personaje";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Vmon;
        private System.Windows.Forms.Button Btn_Agumon;
    }
}