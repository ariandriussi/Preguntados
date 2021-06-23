
namespace IEFI
{
    partial class inicio
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmdhistoria = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Elige una categoria";
            // 
            // cmdhistoria
            // 
            this.cmdhistoria.Location = new System.Drawing.Point(167, 88);
            this.cmdhistoria.Name = "cmdhistoria";
            this.cmdhistoria.Size = new System.Drawing.Size(194, 60);
            this.cmdhistoria.TabIndex = 2;
            this.cmdhistoria.Text = "Historia";
            this.cmdhistoria.UseVisualStyleBackColor = true;
            this.cmdhistoria.Click += new System.EventHandler(this.cmdhistoria_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(167, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 60);
            this.button1.TabIndex = 3;
            this.button1.Text = "Geografia";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(167, 286);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 60);
            this.button2.TabIndex = 4;
            this.button2.Text = "Arte";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 444);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdhistoria);
            this.Controls.Add(this.label1);
            this.Name = "inicio";
            this.Text = "Preguntados";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdhistoria;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

