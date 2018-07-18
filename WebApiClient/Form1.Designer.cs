namespace WebApiClient
{
    partial class Form1
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
            this.bShow = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.dGAlumno = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // bShow
            // 
            this.bShow.Location = new System.Drawing.Point(109, 329);
            this.bShow.Name = "bShow";
            this.bShow.Size = new System.Drawing.Size(122, 45);
            this.bShow.TabIndex = 0;
            this.bShow.Text = "Mostrar";
            this.bShow.UseVisualStyleBackColor = true;
            this.bShow.Click += new System.EventHandler(this.Mostrar);
            // 
            // BAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(428, 329);
            this.bAdd.Name = "BAdd";
            this.bAdd.Size = new System.Drawing.Size(119, 45);
            this.bAdd.TabIndex = 1;
            this.bAdd.Text = "Añadir";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.NewFormAdd);
            // 
            // dGAlumno
            // 
            this.dGAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGAlumno.Location = new System.Drawing.Point(109, 51);
            this.dGAlumno.Name = "dGAlumno";
            this.dGAlumno.RowTemplate.Height = 28;
            this.dGAlumno.Size = new System.Drawing.Size(698, 236);
            this.dGAlumno.TabIndex = 2;
            this.dGAlumno.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridShowAlumno);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 450);
            this.Controls.Add(this.dGAlumno);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.bShow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGAlumno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bShow;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.DataGridView dGAlumno;
    }
}

