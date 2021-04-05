namespace PracticaBlocs
{
    partial class Frmain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btNouBloc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btNouBloc
            // 
            this.btNouBloc.BackColor = System.Drawing.Color.DarkOrange;
            this.btNouBloc.FlatAppearance.BorderColor = System.Drawing.Color.Moccasin;
            this.btNouBloc.FlatAppearance.BorderSize = 5;
            this.btNouBloc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNouBloc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btNouBloc.Location = new System.Drawing.Point(12, 12);
            this.btNouBloc.Name = "btNouBloc";
            this.btNouBloc.Size = new System.Drawing.Size(105, 40);
            this.btNouBloc.TabIndex = 0;
            this.btNouBloc.Text = "Nou Bloc";
            this.btNouBloc.UseVisualStyleBackColor = false;
            this.btNouBloc.Click += new System.EventHandler(this.btNouBloc_Click);
            // 
            // Frmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 591);
            this.Controls.Add(this.btNouBloc);
            this.Name = "Frmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frmain_FormClosing);
            this.Load += new System.EventHandler(this.Frmain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btNouBloc;
    }
}

