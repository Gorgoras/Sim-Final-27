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
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaSimulacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaObjTemporales)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(383, 17);
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
            this.label1.Location = new System.Drawing.Point(94, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tiempo a simular:";
            // 
            // txtTiempo
            // 
            this.txtTiempo.Location = new System.Drawing.Point(232, 19);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(100, 20);
            this.txtTiempo.TabIndex = 2;
            // 
            // dgvTablaSimulacion
            // 
            this.dgvTablaSimulacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaSimulacion.Location = new System.Drawing.Point(12, 62);
            this.dgvTablaSimulacion.Name = "dgvTablaSimulacion";
            this.dgvTablaSimulacion.Size = new System.Drawing.Size(745, 448);
            this.dgvTablaSimulacion.TabIndex = 3;
            // 
            // dgvTablaObjTemporales
            // 
            this.dgvTablaObjTemporales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaObjTemporales.Location = new System.Drawing.Point(779, 62);
            this.dgvTablaObjTemporales.Name = "dgvTablaObjTemporales";
            this.dgvTablaObjTemporales.Size = new System.Drawing.Size(520, 448);
            this.dgvTablaObjTemporales.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(474, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Reiniciar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1311, 538);
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
    }
}

