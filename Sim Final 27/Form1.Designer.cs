namespace Sim_Final_27
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.dgvTablaSimulacion = new System.Windows.Forms.DataGridView();
            this.dgvTablaObjTemporales = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTiempoMedioCola = new System.Windows.Forms.TextBox();
            this.txtPorcentajeUsoOp1 = new System.Windows.Forms.TextBox();
            this.txtTiempoMedioControl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPorcentajeUsoOp3 = new System.Windows.Forms.TextBox();
            this.txtPorcentajeUsoOp2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMediaLlegada = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMediaNormal = new System.Windows.Forms.TextBox();
            this.txtDesvEstNormal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaSimulacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaObjTemporales)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1281, 825);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Simular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1036, 824);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tiempo a simular:";
            // 
            // txtTiempo
            // 
            this.txtTiempo.Location = new System.Drawing.Point(1174, 826);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(100, 20);
            this.txtTiempo.TabIndex = 2;
            // 
            // dgvTablaSimulacion
            // 
            this.dgvTablaSimulacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaSimulacion.Location = new System.Drawing.Point(12, 62);
            this.dgvTablaSimulacion.Name = "dgvTablaSimulacion";
            this.dgvTablaSimulacion.Size = new System.Drawing.Size(1002, 616);
            this.dgvTablaSimulacion.TabIndex = 3;
            // 
            // dgvTablaObjTemporales
            // 
            this.dgvTablaObjTemporales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaObjTemporales.Location = new System.Drawing.Point(1040, 62);
            this.dgvTablaObjTemporales.Name = "dgvTablaObjTemporales";
            this.dgvTablaObjTemporales.Size = new System.Drawing.Size(520, 616);
            this.dgvTablaObjTemporales.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1281, 769);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Reiniciar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 694);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(528, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "El tiempo medio que debe esperar un reloj antes de ser controlado es de: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 770);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(597, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "El porcentaje de utilización de cada uno de los operarios que controlan a los rel" +
    "ojes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 731);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(358, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "El tiempo total promedio de un reloj en el sistema:";
            // 
            // txtTiempoMedioCola
            // 
            this.txtTiempoMedioCola.Enabled = false;
            this.txtTiempoMedioCola.Location = new System.Drawing.Point(546, 696);
            this.txtTiempoMedioCola.Name = "txtTiempoMedioCola";
            this.txtTiempoMedioCola.Size = new System.Drawing.Size(100, 20);
            this.txtTiempoMedioCola.TabIndex = 9;
            // 
            // txtPorcentajeUsoOp1
            // 
            this.txtPorcentajeUsoOp1.Enabled = false;
            this.txtPorcentajeUsoOp1.Location = new System.Drawing.Point(700, 772);
            this.txtPorcentajeUsoOp1.Name = "txtPorcentajeUsoOp1";
            this.txtPorcentajeUsoOp1.Size = new System.Drawing.Size(100, 20);
            this.txtPorcentajeUsoOp1.TabIndex = 10;
            // 
            // txtTiempoMedioControl
            // 
            this.txtTiempoMedioControl.Enabled = false;
            this.txtTiempoMedioControl.Location = new System.Drawing.Point(376, 733);
            this.txtTiempoMedioControl.Name = "txtTiempoMedioControl";
            this.txtTiempoMedioControl.Size = new System.Drawing.Size(100, 20);
            this.txtTiempoMedioControl.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(638, 775);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Operario 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(638, 831);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Operario 3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(638, 804);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Operario 2";
            // 
            // txtPorcentajeUsoOp3
            // 
            this.txtPorcentajeUsoOp3.Enabled = false;
            this.txtPorcentajeUsoOp3.Location = new System.Drawing.Point(700, 828);
            this.txtPorcentajeUsoOp3.Name = "txtPorcentajeUsoOp3";
            this.txtPorcentajeUsoOp3.Size = new System.Drawing.Size(100, 20);
            this.txtPorcentajeUsoOp3.TabIndex = 15;
            // 
            // txtPorcentajeUsoOp2
            // 
            this.txtPorcentajeUsoOp2.Enabled = false;
            this.txtPorcentajeUsoOp2.Location = new System.Drawing.Point(700, 801);
            this.txtPorcentajeUsoOp2.Name = "txtPorcentajeUsoOp2";
            this.txtPorcentajeUsoOp2.Size = new System.Drawing.Size(100, 20);
            this.txtPorcentajeUsoOp2.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(354, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Media llegada de relojes (horas, dist exponencial)";
            // 
            // txtMediaLlegada
            // 
            this.txtMediaLlegada.Location = new System.Drawing.Point(376, 11);
            this.txtMediaLlegada.Name = "txtMediaLlegada";
            this.txtMediaLlegada.Size = new System.Drawing.Size(100, 20);
            this.txtMediaLlegada.TabIndex = 18;
            this.txtMediaLlegada.Text = "0.01";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(598, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(307, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Tiempo control de reloj (horas, dist normal)";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(911, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Desviación estandar";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(911, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "Media";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtMediaNormal
            // 
            this.txtMediaNormal.Location = new System.Drawing.Point(1074, 9);
            this.txtMediaNormal.Name = "txtMediaNormal";
            this.txtMediaNormal.Size = new System.Drawing.Size(100, 20);
            this.txtMediaNormal.TabIndex = 22;
            this.txtMediaNormal.Text = "0.08";
            // 
            // txtDesvEstNormal
            // 
            this.txtDesvEstNormal.Location = new System.Drawing.Point(1074, 36);
            this.txtDesvEstNormal.Name = "txtDesvEstNormal";
            this.txtDesvEstNormal.Size = new System.Drawing.Size(100, 20);
            this.txtDesvEstNormal.TabIndex = 23;
            this.txtDesvEstNormal.Text = "0.01";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1594, 853);
            this.Controls.Add(this.txtDesvEstNormal);
            this.Controls.Add(this.txtMediaNormal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMediaLlegada);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPorcentajeUsoOp2);
            this.Controls.Add(this.txtPorcentajeUsoOp3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTiempoMedioControl);
            this.Controls.Add(this.txtPorcentajeUsoOp1);
            this.Controls.Add(this.txtTiempoMedioCola);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvTablaObjTemporales);
            this.Controls.Add(this.dgvTablaSimulacion);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaSimulacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaObjTemporales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.DataGridView dgvTablaSimulacion;
        private System.Windows.Forms.DataGridView dgvTablaObjTemporales;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTiempoMedioCola;
        private System.Windows.Forms.TextBox txtPorcentajeUsoOp1;
        private System.Windows.Forms.TextBox txtTiempoMedioControl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPorcentajeUsoOp3;
        private System.Windows.Forms.TextBox txtPorcentajeUsoOp2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMediaLlegada;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMediaNormal;
        private System.Windows.Forms.TextBox txtDesvEstNormal;
    }
}

