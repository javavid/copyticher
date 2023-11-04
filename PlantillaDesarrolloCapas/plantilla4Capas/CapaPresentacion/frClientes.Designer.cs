namespace CapaPresentacion
{
    partial class frClientes
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
            this.BtnEntrar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.LbUsuario = new System.Windows.Forms.Label();
            this.LbContrasena = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.BtnEntrar.Location = new System.Drawing.Point(54, 166);
            this.BtnEntrar.Name = "button1";
            this.BtnEntrar.Size = new System.Drawing.Size(75, 23);
            this.BtnEntrar.TabIndex = 0;
            this.BtnEntrar.Text = "button1";
            this.BtnEntrar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.BtnSalir.Location = new System.Drawing.Point(194, 166);
            this.BtnSalir.Name = "button2";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 1;
            this.BtnSalir.Text = "button2";
            this.BtnSalir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.LbUsuario.AutoSize = true;
            this.LbUsuario.Location = new System.Drawing.Point(37, 45);
            this.LbUsuario.Name = "label1";
            this.LbUsuario.Size = new System.Drawing.Size(38, 15);
            this.LbUsuario.TabIndex = 2;
            this.LbUsuario.Text = "label1";
            this.LbUsuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.LbContrasena.AutoSize = true;
            this.LbContrasena.Location = new System.Drawing.Point(157, 125);
            this.LbContrasena.Name = "label2";
            this.LbContrasena.Size = new System.Drawing.Size(38, 15);
            this.LbContrasena.TabIndex = 3;
            this.LbContrasena.Text = "label2";
            // 
            // frClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 264);
            this.Controls.Add(this.LbContrasena);
            this.Controls.Add(this.LbUsuario);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnEntrar);
            this.Name = "frClientes";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnEntrar;
        private Button BtnSalir;
        private Label LbUsuario;
        private Label LbContrasena;
        private TextBox TxbUsuario;
        private TextBox TxbContrasena;
        private EventHandler frClientes_Load;
    }
}