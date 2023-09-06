
namespace StayAwakeApp
{
    partial class UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI));
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelbylsv = new System.Windows.Forms.Label();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.radioButtonMinutos = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEmpezar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.radioButtonHoras = new System.Windows.Forms.RadioButton();
            this.numericUpDownCantidad = new System.Windows.Forms.NumericUpDown();
            this.labelTiempo = new System.Windows.Forms.Label();
            this.labelEspañol = new System.Windows.Forms.Label();
            this.labelEnglish = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(146, 221);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(28, 13);
            this.labelVersion.TabIndex = 19;
            this.labelVersion.Text = "v1.4";
            // 
            // labelbylsv
            // 
            this.labelbylsv.AutoSize = true;
            this.labelbylsv.Location = new System.Drawing.Point(118, 12);
            this.labelbylsv.Name = "labelbylsv";
            this.labelbylsv.Size = new System.Drawing.Size(41, 13);
            this.labelbylsv.TabIndex = 18;
            this.labelbylsv.Text = "by LSV";
            // 
            // buttonInfo
            // 
            this.buttonInfo.Location = new System.Drawing.Point(5, 6);
            this.buttonInfo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(35, 24);
            this.buttonInfo.TabIndex = 14;
            this.buttonInfo.Text = "info.";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // radioButtonMinutos
            // 
            this.radioButtonMinutos.AutoSize = true;
            this.radioButtonMinutos.Location = new System.Drawing.Point(86, 72);
            this.radioButtonMinutos.Name = "radioButtonMinutos";
            this.radioButtonMinutos.Size = new System.Drawing.Size(62, 17);
            this.radioButtonMinutos.TabIndex = 17;
            this.radioButtonMinutos.TabStop = true;
            this.radioButtonMinutos.Text = "Minutos";
            this.radioButtonMinutos.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Location = new System.Drawing.Point(33, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cantidad de Tiempo:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonEmpezar
            // 
            this.buttonEmpezar.Location = new System.Drawing.Point(40, 142);
            this.buttonEmpezar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEmpezar.Name = "buttonEmpezar";
            this.buttonEmpezar.Size = new System.Drawing.Size(90, 42);
            this.buttonEmpezar.TabIndex = 11;
            this.buttonEmpezar.Text = "Empezar";
            this.buttonEmpezar.UseVisualStyleBackColor = true;
            this.buttonEmpezar.Click += new System.EventHandler(this.buttonEmpezar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(40, 189);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(89, 23);
            this.buttonCancelar.TabIndex = 15;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // radioButtonHoras
            // 
            this.radioButtonHoras.AutoSize = true;
            this.radioButtonHoras.Location = new System.Drawing.Point(27, 72);
            this.radioButtonHoras.Name = "radioButtonHoras";
            this.radioButtonHoras.Size = new System.Drawing.Size(53, 17);
            this.radioButtonHoras.TabIndex = 16;
            this.radioButtonHoras.TabStop = true;
            this.radioButtonHoras.Text = "Horas";
            this.radioButtonHoras.UseVisualStyleBackColor = true;
            // 
            // numericUpDownCantidad
            // 
            this.numericUpDownCantidad.Location = new System.Drawing.Point(40, 94);
            this.numericUpDownCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownCantidad.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCantidad.Name = "numericUpDownCantidad";
            this.numericUpDownCantidad.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownCantidad.TabIndex = 12;
            this.numericUpDownCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelTiempo
            // 
            this.labelTiempo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTiempo.Location = new System.Drawing.Point(40, 116);
            this.labelTiempo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTiempo.Name = "labelTiempo";
            this.labelTiempo.Size = new System.Drawing.Size(89, 24);
            this.labelTiempo.TabIndex = 21;
            this.labelTiempo.Text = "00:00:00";
            this.labelTiempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEspañol
            // 
            this.labelEspañol.AutoSize = true;
            this.labelEspañol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelEspañol.Enabled = false;
            this.labelEspañol.Location = new System.Drawing.Point(24, 221);
            this.labelEspañol.Name = "labelEspañol";
            this.labelEspañol.Size = new System.Drawing.Size(21, 13);
            this.labelEspañol.TabIndex = 22;
            this.labelEspañol.Text = "ES";
            this.labelEspañol.Click += new System.EventHandler(this.labelEspañol_Click);
            // 
            // labelEnglish
            // 
            this.labelEnglish.AutoSize = true;
            this.labelEnglish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelEnglish.Location = new System.Drawing.Point(2, 221);
            this.labelEnglish.Name = "labelEnglish";
            this.labelEnglish.Size = new System.Drawing.Size(22, 13);
            this.labelEnglish.TabIndex = 23;
            this.labelEnglish.Text = "EN";
            this.labelEnglish.Click += new System.EventHandler(this.labelEnglish_Click);
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(171, 237);
            this.Controls.Add(this.labelEnglish);
            this.Controls.Add(this.labelEspañol);
            this.Controls.Add(this.labelTiempo);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelbylsv);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.radioButtonMinutos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEmpezar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.radioButtonHoras);
            this.Controls.Add(this.numericUpDownCantidad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UI";
            this.Text = "Stay Awake App";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelbylsv;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.RadioButton radioButtonMinutos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEmpezar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.RadioButton radioButtonHoras;
        private System.Windows.Forms.NumericUpDown numericUpDownCantidad;
        private System.Windows.Forms.Label labelTiempo;
        private System.Windows.Forms.Label labelEspañol;
        private System.Windows.Forms.Label labelEnglish;
    }
}

