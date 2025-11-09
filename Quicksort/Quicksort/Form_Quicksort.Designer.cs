namespace Quicksort
{
    partial class Form_Quicksort
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.txt_arreglo = new System.Windows.Forms.TextBox();
            this.lbl_arreglo = new System.Windows.Forms.Label();
            this.lbl_instrucciones = new System.Windows.Forms.Label();
            this.btn_ordenar = new System.Windows.Forms.Button();
            this.lbl_colores = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(29, 23);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(162, 38);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Quicksort";
            // 
            // txt_arreglo
            // 
            this.txt_arreglo.Location = new System.Drawing.Point(15, 90);
            this.txt_arreglo.Name = "txt_arreglo";
            this.txt_arreglo.Size = new System.Drawing.Size(293, 20);
            this.txt_arreglo.TabIndex = 1;
            this.txt_arreglo.TextChanged += new System.EventHandler(this.txt_arreglo_TextChanged);
            // 
            // lbl_arreglo
            // 
            this.lbl_arreglo.AutoSize = true;
            this.lbl_arreglo.Location = new System.Drawing.Point(12, 74);
            this.lbl_arreglo.Name = "lbl_arreglo";
            this.lbl_arreglo.Size = new System.Drawing.Size(43, 13);
            this.lbl_arreglo.TabIndex = 2;
            this.lbl_arreglo.Text = "Arreglo:";
            // 
            // lbl_instrucciones
            // 
            this.lbl_instrucciones.AutoSize = true;
            this.lbl_instrucciones.Location = new System.Drawing.Point(12, 113);
            this.lbl_instrucciones.Name = "lbl_instrucciones";
            this.lbl_instrucciones.Size = new System.Drawing.Size(296, 13);
            this.lbl_instrucciones.TabIndex = 3;
            this.lbl_instrucciones.Text = "Debes colocar cada valor del arreglo separado por una coma";
            // 
            // btn_ordenar
            // 
            this.btn_ordenar.Location = new System.Drawing.Point(333, 12);
            this.btn_ordenar.Name = "btn_ordenar";
            this.btn_ordenar.Size = new System.Drawing.Size(148, 97);
            this.btn_ordenar.TabIndex = 4;
            this.btn_ordenar.Text = "Ordenar";
            this.btn_ordenar.UseVisualStyleBackColor = true;
            this.btn_ordenar.Click += new System.EventHandler(this.btn_ordenar_Click);
            // 
            // lbl_colores
            // 
            this.lbl_colores.AutoSize = true;
            this.lbl_colores.Location = new System.Drawing.Point(499, 42);
            this.lbl_colores.Name = "lbl_colores";
            this.lbl_colores.Size = new System.Drawing.Size(94, 65);
            this.lbl_colores.TabIndex = 5;
            this.lbl_colores.Text = "Colores:\r\nVerde: pivote\r\nAzul: menores\r\nRojo: mayores\r\nBeige: intercambio";
            // 
            // Form_Quicksort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.lbl_colores);
            this.Controls.Add(this.btn_ordenar);
            this.Controls.Add(this.lbl_instrucciones);
            this.Controls.Add(this.lbl_arreglo);
            this.Controls.Add(this.txt_arreglo);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "Form_Quicksort";
            this.Text = "Quicksort";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_Quicksort_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.TextBox txt_arreglo;
        private System.Windows.Forms.Label lbl_arreglo;
        private System.Windows.Forms.Label lbl_instrucciones;
        private System.Windows.Forms.Button btn_ordenar;
        private System.Windows.Forms.Label lbl_colores;
    }
}

