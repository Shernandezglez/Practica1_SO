namespace CalculadorDeProcesos
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
            this.btnGuardarProcesos = new System.Windows.Forms.Button();
            this.txtNumProcesos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardarTiempoMaximo = new System.Windows.Forms.Button();
            this.btnCalcularFCFS = new System.Windows.Forms.Button();
            this.btnCalcularLJF = new System.Windows.Forms.Button();
            this.btnCalcularSJF = new System.Windows.Forms.Button();
            this.txtResultados = new System.Windows.Forms.TextBox();
            this.txtTiempoMaximo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalcularRR = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuantum = new System.Windows.Forms.TextBox();
            this.btnGuardarQuantums = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGuardarProcesos
            // 
            this.btnGuardarProcesos.Location = new System.Drawing.Point(213, 32);
            this.btnGuardarProcesos.Name = "btnGuardarProcesos";
            this.btnGuardarProcesos.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarProcesos.TabIndex = 0;
            this.btnGuardarProcesos.Text = "Guardar";
            this.btnGuardarProcesos.UseVisualStyleBackColor = true;
            // 
            // txtNumProcesos
            // 
            this.txtNumProcesos.Location = new System.Drawing.Point(12, 32);
            this.txtNumProcesos.Name = "txtNumProcesos";
            this.txtNumProcesos.Size = new System.Drawing.Size(100, 20);
            this.txtNumProcesos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero de procesos";
            // 
            // btnGuardarTiempoMaximo
            // 
            this.btnGuardarTiempoMaximo.Location = new System.Drawing.Point(213, 79);
            this.btnGuardarTiempoMaximo.Name = "btnGuardarTiempoMaximo";
            this.btnGuardarTiempoMaximo.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarTiempoMaximo.TabIndex = 3;
            this.btnGuardarTiempoMaximo.Text = "guardar";
            this.btnGuardarTiempoMaximo.UseVisualStyleBackColor = true;
            // 
            // btnCalcularFCFS
            // 
            this.btnCalcularFCFS.Location = new System.Drawing.Point(213, 201);
            this.btnCalcularFCFS.Name = "btnCalcularFCFS";
            this.btnCalcularFCFS.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularFCFS.TabIndex = 4;
            this.btnCalcularFCFS.Text = "FCFS";
            this.btnCalcularFCFS.UseVisualStyleBackColor = true;
            // 
            // btnCalcularLJF
            // 
            this.btnCalcularLJF.Location = new System.Drawing.Point(213, 264);
            this.btnCalcularLJF.Name = "btnCalcularLJF";
            this.btnCalcularLJF.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularLJF.TabIndex = 5;
            this.btnCalcularLJF.Text = "LJF";
            this.btnCalcularLJF.UseVisualStyleBackColor = true;
            // 
            // btnCalcularSJF
            // 
            this.btnCalcularSJF.Location = new System.Drawing.Point(213, 327);
            this.btnCalcularSJF.Name = "btnCalcularSJF";
            this.btnCalcularSJF.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularSJF.TabIndex = 6;
            this.btnCalcularSJF.Text = "SJF";
            this.btnCalcularSJF.UseVisualStyleBackColor = true;
            // 
            // txtResultados
            // 
            this.txtResultados.Location = new System.Drawing.Point(12, 201);
            this.txtResultados.Multiline = true;
            this.txtResultados.Name = "txtResultados";
            this.txtResultados.Size = new System.Drawing.Size(146, 224);
            this.txtResultados.TabIndex = 7;
            // 
            // txtTiempoMaximo
            // 
            this.txtTiempoMaximo.Location = new System.Drawing.Point(12, 79);
            this.txtTiempoMaximo.Name = "txtTiempoMaximo";
            this.txtTiempoMaximo.Size = new System.Drawing.Size(100, 20);
            this.txtTiempoMaximo.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tiempo maximo";
            // 
            // btnCalcularRR
            // 
            this.btnCalcularRR.Location = new System.Drawing.Point(213, 384);
            this.btnCalcularRR.Name = "btnCalcularRR";
            this.btnCalcularRR.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularRR.TabIndex = 10;
            this.btnCalcularRR.Text = "RR";
            this.btnCalcularRR.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Quantum:";
            // 
            // txtQuantum
            // 
            this.txtQuantum.Location = new System.Drawing.Point(12, 134);
            this.txtQuantum.Name = "txtQuantum";
            this.txtQuantum.Size = new System.Drawing.Size(100, 20);
            this.txtQuantum.TabIndex = 12;
            // 
            // btnGuardarQuantums
            // 
            this.btnGuardarQuantums.Location = new System.Drawing.Point(213, 134);
            this.btnGuardarQuantums.Name = "btnGuardarQuantums";
            this.btnGuardarQuantums.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarQuantums.TabIndex = 11;
            this.btnGuardarQuantums.Text = "Guardar";
            this.btnGuardarQuantums.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 437);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQuantum);
            this.Controls.Add(this.btnGuardarQuantums);
            this.Controls.Add(this.btnCalcularRR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTiempoMaximo);
            this.Controls.Add(this.txtResultados);
            this.Controls.Add(this.btnCalcularSJF);
            this.Controls.Add(this.btnCalcularLJF);
            this.Controls.Add(this.btnCalcularFCFS);
            this.Controls.Add(this.btnGuardarTiempoMaximo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumProcesos);
            this.Controls.Add(this.btnGuardarProcesos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarProcesos;
        private System.Windows.Forms.TextBox txtNumProcesos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardarTiempoMaximo;
        private System.Windows.Forms.Button btnCalcularFCFS;
        private System.Windows.Forms.Button btnCalcularLJF;
        private System.Windows.Forms.Button btnCalcularSJF;
        private System.Windows.Forms.TextBox txtResultados;
        private System.Windows.Forms.TextBox txtTiempoMaximo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalcularRR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuantum;
        private System.Windows.Forms.Button btnGuardarQuantums;
    }
}

