namespace ReconocedorVoz
{
    partial class Index
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.btn_Vocales = new System.Windows.Forms.Button();
            this.btn_Abc = new System.Windows.Forms.Button();
            this.btn_Lec = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Consonantes = new System.Windows.Forms.Button();
            this.PB_IMFORMAR = new System.Windows.Forms.PictureBox();
            this.Btn_CLOSEP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PB_IMFORMAR)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Vocales
            // 
            this.btn_Vocales.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Vocales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Vocales.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Vocales.Location = new System.Drawing.Point(93, 59);
            this.btn_Vocales.Name = "btn_Vocales";
            this.btn_Vocales.Size = new System.Drawing.Size(109, 34);
            this.btn_Vocales.TabIndex = 0;
            this.btn_Vocales.Text = "Vocales";
            this.btn_Vocales.UseVisualStyleBackColor = false;
            this.btn_Vocales.Click += new System.EventHandler(this.btn_Vocales_Click);
            this.btn_Vocales.MouseEnter += new System.EventHandler(this.btn_Vocales_MouseEnter);
            // 
            // btn_Abc
            // 
            this.btn_Abc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Abc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Abc.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Abc.Location = new System.Drawing.Point(93, 158);
            this.btn_Abc.Name = "btn_Abc";
            this.btn_Abc.Size = new System.Drawing.Size(109, 34);
            this.btn_Abc.TabIndex = 1;
            this.btn_Abc.Text = "Abecedario";
            this.btn_Abc.UseVisualStyleBackColor = false;
            this.btn_Abc.Click += new System.EventHandler(this.btn_Abc_Click);
            this.btn_Abc.MouseEnter += new System.EventHandler(this.btn_Abc_MouseEnter_1);
            // 
            // btn_Lec
            // 
            this.btn_Lec.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Lec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Lec.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Lec.Location = new System.Drawing.Point(93, 216);
            this.btn_Lec.Name = "btn_Lec";
            this.btn_Lec.Size = new System.Drawing.Size(109, 34);
            this.btn_Lec.TabIndex = 2;
            this.btn_Lec.Text = "Lecciones";
            this.btn_Lec.UseVisualStyleBackColor = false;
            this.btn_Lec.Click += new System.EventHandler(this.btn_Lec_Click);
            this.btn_Lec.MouseEnter += new System.EventHandler(this.btn_Lec_MouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Loki Cola", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(116, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Índice";
            // 
            // Btn_Consonantes
            // 
            this.Btn_Consonantes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Consonantes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Consonantes.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Consonantes.Location = new System.Drawing.Point(93, 108);
            this.Btn_Consonantes.Name = "Btn_Consonantes";
            this.Btn_Consonantes.Size = new System.Drawing.Size(109, 34);
            this.Btn_Consonantes.TabIndex = 10;
            this.Btn_Consonantes.Text = "Consonantes";
            this.Btn_Consonantes.UseVisualStyleBackColor = false;
            this.Btn_Consonantes.Click += new System.EventHandler(this.Btn_Consonantes_Click);
            this.Btn_Consonantes.MouseEnter += new System.EventHandler(this.Btn_Consonantes_MouseEnter);
            // 
            // PB_IMFORMAR
            // 
            this.PB_IMFORMAR.Cursor = System.Windows.Forms.Cursors.Help;
            this.PB_IMFORMAR.Image = ((System.Drawing.Image)(resources.GetObject("PB_IMFORMAR.Image")));
            this.PB_IMFORMAR.Location = new System.Drawing.Point(241, 12);
            this.PB_IMFORMAR.Name = "PB_IMFORMAR";
            this.PB_IMFORMAR.Size = new System.Drawing.Size(37, 38);
            this.PB_IMFORMAR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_IMFORMAR.TabIndex = 9;
            this.PB_IMFORMAR.TabStop = false;
            this.PB_IMFORMAR.Click += new System.EventHandler(this.PB_IMFORMAR_Click);
            // 
            // Btn_CLOSEP
            // 
            this.Btn_CLOSEP.BackColor = System.Drawing.Color.Black;
            this.Btn_CLOSEP.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Btn_CLOSEP.Font = new System.Drawing.Font("Jokerman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CLOSEP.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_CLOSEP.Location = new System.Drawing.Point(3, 12);
            this.Btn_CLOSEP.Name = "Btn_CLOSEP";
            this.Btn_CLOSEP.Size = new System.Drawing.Size(90, 30);
            this.Btn_CLOSEP.TabIndex = 11;
            this.Btn_CLOSEP.Text = "CERRAR";
            this.Btn_CLOSEP.UseVisualStyleBackColor = false;
            this.Btn_CLOSEP.Click += new System.EventHandler(this.Btn_CLOSEP_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(290, 267);
            this.ControlBox = false;
            this.Controls.Add(this.Btn_CLOSEP);
            this.Controls.Add(this.Btn_Consonantes);
            this.Controls.Add(this.PB_IMFORMAR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Lec);
            this.Controls.Add(this.btn_Abc);
            this.Controls.Add(this.btn_Vocales);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Index";
            this.Text = "INICIO";
            ((System.ComponentModel.ISupportInitialize)(this.PB_IMFORMAR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Vocales;
        private System.Windows.Forms.Button btn_Abc;
        private System.Windows.Forms.Button btn_Lec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PB_IMFORMAR;
        private System.Windows.Forms.Button Btn_Consonantes;
        private System.Windows.Forms.Button Btn_CLOSEP;
    }
}

