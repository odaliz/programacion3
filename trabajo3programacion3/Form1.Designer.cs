namespace cargo
{
    partial class Form1
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
            this.Btnactualizacargo = new System.Windows.Forms.Button();
            this.btnborrarcargo = new System.Windows.Forms.Button();
            this.btbguardarcargo = new System.Windows.Forms.Button();
            this.txtnombredeparta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdepartamento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btnactualizacargo
            // 
            this.Btnactualizacargo.Location = new System.Drawing.Point(250, 235);
            this.Btnactualizacargo.Name = "Btnactualizacargo";
            this.Btnactualizacargo.Size = new System.Drawing.Size(75, 23);
            this.Btnactualizacargo.TabIndex = 17;
            this.Btnactualizacargo.Text = "Actualizar";
            this.Btnactualizacargo.UseVisualStyleBackColor = true;
            // 
            // btnborrarcargo
            // 
            this.btnborrarcargo.Location = new System.Drawing.Point(134, 235);
            this.btnborrarcargo.Name = "btnborrarcargo";
            this.btnborrarcargo.Size = new System.Drawing.Size(75, 23);
            this.btnborrarcargo.TabIndex = 16;
            this.btnborrarcargo.Text = "Borrar";
            this.btnborrarcargo.UseVisualStyleBackColor = true;
            // 
            // btbguardarcargo
            // 
            this.btbguardarcargo.Location = new System.Drawing.Point(15, 235);
            this.btbguardarcargo.Name = "btbguardarcargo";
            this.btbguardarcargo.Size = new System.Drawing.Size(75, 23);
            this.btbguardarcargo.TabIndex = 15;
            this.btbguardarcargo.Text = "Guardar";
            this.btbguardarcargo.UseVisualStyleBackColor = true;
            // 
            // txtnombredeparta
            // 
            this.txtnombredeparta.Location = new System.Drawing.Point(113, 136);
            this.txtnombredeparta.Name = "txtnombredeparta";
            this.txtnombredeparta.Size = new System.Drawing.Size(100, 20);
            this.txtnombredeparta.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre";
            // 
            // txtdepartamento
            // 
            this.txtdepartamento.Location = new System.Drawing.Point(113, 98);
            this.txtdepartamento.Name = "txtdepartamento";
            this.txtdepartamento.Size = new System.Drawing.Size(100, 20);
            this.txtdepartamento.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Id  cargo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(366, 340);
            this.Controls.Add(this.Btnactualizacargo);
            this.Controls.Add(this.btnborrarcargo);
            this.Controls.Add(this.btbguardarcargo);
            this.Controls.Add(this.txtnombredeparta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtdepartamento);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btnactualizacargo;
        private System.Windows.Forms.Button btnborrarcargo;
        private System.Windows.Forms.Button btbguardarcargo;
        private System.Windows.Forms.TextBox txtnombredeparta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdepartamento;
        private System.Windows.Forms.Label label1;
    }
}

