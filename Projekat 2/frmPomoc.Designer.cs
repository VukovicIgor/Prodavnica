
namespace Projekat_2
{
    partial class frmPomoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPomoc));
            this.txtPomoc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtPomoc
            // 
            this.txtPomoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPomoc.Location = new System.Drawing.Point(-2, -1);
            this.txtPomoc.Multiline = true;
            this.txtPomoc.Name = "txtPomoc";
            this.txtPomoc.Size = new System.Drawing.Size(402, 283);
            this.txtPomoc.TabIndex = 1;
            this.txtPomoc.Text = resources.GetString("txtPomoc.Text");
            // 
            // frmPomoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 279);
            this.Controls.Add(this.txtPomoc);
            this.Name = "frmPomoc";
            this.Text = "frmPomoc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPomoc;
    }
}