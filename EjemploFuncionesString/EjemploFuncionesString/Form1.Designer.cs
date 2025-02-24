namespace EjemploFuncionesString
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSubcadena = new Button();
            btnMayuscula = new Button();
            btnMinuscula = new Button();
            txtOrigen = new TextBox();
            txtResultado = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnSubcadena
            // 
            btnSubcadena.Location = new Point(205, 306);
            btnSubcadena.Name = "btnSubcadena";
            btnSubcadena.Size = new Size(94, 29);
            btnSubcadena.TabIndex = 0;
            btnSubcadena.Text = "Subcadena";
            btnSubcadena.UseVisualStyleBackColor = true;
            btnSubcadena.Click += btnSubcadena_Click;
            // 
            // btnMayuscula
            // 
            btnMayuscula.Location = new Point(362, 306);
            btnMayuscula.Name = "btnMayuscula";
            btnMayuscula.Size = new Size(94, 29);
            btnMayuscula.TabIndex = 1;
            btnMayuscula.Text = "Mayuscula";
            btnMayuscula.UseVisualStyleBackColor = true;
            btnMayuscula.Click += btnMayuscula_Click;
            // 
            // btnMinuscula
            // 
            btnMinuscula.Location = new Point(521, 306);
            btnMinuscula.Name = "btnMinuscula";
            btnMinuscula.Size = new Size(94, 29);
            btnMinuscula.TabIndex = 2;
            btnMinuscula.Text = "Minúscula";
            btnMinuscula.UseVisualStyleBackColor = true;
            btnMinuscula.Click += btnMinuscula_Click;
            // 
            // txtOrigen
            // 
            txtOrigen.Location = new Point(239, 112);
            txtOrigen.Name = "txtOrigen";
            txtOrigen.Size = new Size(346, 27);
            txtOrigen.TabIndex = 3;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(243, 203);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(342, 27);
            txtResultado.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(238, 81);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 5;
            label1.Text = "Cadena Origen";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(244, 173);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 6;
            label2.Text = "Cadena Resultado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtResultado);
            Controls.Add(txtOrigen);
            Controls.Add(btnMinuscula);
            Controls.Add(btnMayuscula);
            Controls.Add(btnSubcadena);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubcadena;
        private Button btnMayuscula;
        private Button btnMinuscula;
        private TextBox txtOrigen;
        private TextBox txtResultado;
        private Label label1;
        private Label label2;
    }
}
