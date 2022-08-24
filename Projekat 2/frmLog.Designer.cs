
namespace Projekat_2
{
    partial class frmLog
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
            this.btnAdministracija = new System.Windows.Forms.Button();
            this.btnProdaja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdministracija
            // 
            this.btnAdministracija.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdministracija.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministracija.Location = new System.Drawing.Point(229, 12);
            this.btnAdministracija.Name = "btnAdministracija";
            this.btnAdministracija.Size = new System.Drawing.Size(202, 145);
            this.btnAdministracija.TabIndex = 3;
            this.btnAdministracija.Text = "ADMINISTRACIJA";
            this.btnAdministracija.UseVisualStyleBackColor = false;
            this.btnAdministracija.Click += new System.EventHandler(this.Administracija);
            // 
            // btnProdaja
            // 
            this.btnProdaja.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnProdaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdaja.Location = new System.Drawing.Point(12, 12);
            this.btnProdaja.Name = "btnProdaja";
            this.btnProdaja.Size = new System.Drawing.Size(202, 145);
            this.btnProdaja.TabIndex = 2;
            this.btnProdaja.Text = "PRODAJA";
            this.btnProdaja.UseVisualStyleBackColor = false;
            this.btnProdaja.Click += new System.EventHandler(this.Prodaja);
            // 
            // frmLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(443, 169);
            this.Controls.Add(this.btnAdministracija);
            this.Controls.Add(this.btnProdaja);
            this.Name = "frmLog";
            this.Text = "frmLog";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdministracija;
        private System.Windows.Forms.Button btnProdaja;
    }
}