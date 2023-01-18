namespace PresentaciónVehiculos
{
    partial class frmVehiculos
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
            this.btnCamion = new System.Windows.Forms.Button();
            this.btnAutoElectrico = new System.Windows.Forms.Button();
            this.btnQuitarRemolque = new System.Windows.Forms.Button();
            this.btn_acelerarCamion = new System.Windows.Forms.Button();
            this.btnFrenarElectrico = new System.Windows.Forms.Button();
            this.btnAcelerarElectrico = new System.Windows.Forms.Button();
            this.btnFrenarCamion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCamion
            // 
            this.btnCamion.Location = new System.Drawing.Point(159, 72);
            this.btnCamion.Name = "btnCamion";
            this.btnCamion.Size = new System.Drawing.Size(159, 49);
            this.btnCamion.TabIndex = 0;
            this.btnCamion.Text = "Mostrar Camión";
            this.btnCamion.UseVisualStyleBackColor = true;
            this.btnCamion.Click += new System.EventHandler(this.btnCamion_Click);
            // 
            // btnAutoElectrico
            // 
            this.btnAutoElectrico.Location = new System.Drawing.Point(159, 236);
            this.btnAutoElectrico.Name = "btnAutoElectrico";
            this.btnAutoElectrico.Size = new System.Drawing.Size(159, 49);
            this.btnAutoElectrico.TabIndex = 1;
            this.btnAutoElectrico.Text = "Mostrar Auto Eléctrico";
            this.btnAutoElectrico.UseVisualStyleBackColor = true;
            this.btnAutoElectrico.Click += new System.EventHandler(this.btnAutoElectrico_Click);
            // 
            // btnQuitarRemolque
            // 
            this.btnQuitarRemolque.Location = new System.Drawing.Point(428, 72);
            this.btnQuitarRemolque.Name = "btnQuitarRemolque";
            this.btnQuitarRemolque.Size = new System.Drawing.Size(148, 49);
            this.btnQuitarRemolque.TabIndex = 2;
            this.btnQuitarRemolque.Text = "Quitar remolque";
            this.btnQuitarRemolque.UseVisualStyleBackColor = true;
            this.btnQuitarRemolque.Click += new System.EventHandler(this.btnQuitarRemolque_Click);
            // 
            // btn_acelerarCamion
            // 
            this.btn_acelerarCamion.Location = new System.Drawing.Point(90, 139);
            this.btn_acelerarCamion.Name = "btn_acelerarCamion";
            this.btn_acelerarCamion.Size = new System.Drawing.Size(130, 28);
            this.btn_acelerarCamion.TabIndex = 3;
            this.btn_acelerarCamion.Text = "Acelerar Camión";
            this.btn_acelerarCamion.UseVisualStyleBackColor = true;
            this.btn_acelerarCamion.Click += new System.EventHandler(this.btn_acelerarCamion_Click);
            // 
            // btnFrenarElectrico
            // 
            this.btnFrenarElectrico.Location = new System.Drawing.Point(260, 301);
            this.btnFrenarElectrico.Name = "btnFrenarElectrico";
            this.btnFrenarElectrico.Size = new System.Drawing.Size(130, 48);
            this.btnFrenarElectrico.TabIndex = 5;
            this.btnFrenarElectrico.Text = "Frenar Auto Eléctrico";
            this.btnFrenarElectrico.UseVisualStyleBackColor = true;
            this.btnFrenarElectrico.Click += new System.EventHandler(this.btnFrenarElectrico_Click);
            // 
            // btnAcelerarElectrico
            // 
            this.btnAcelerarElectrico.Location = new System.Drawing.Point(90, 301);
            this.btnAcelerarElectrico.Name = "btnAcelerarElectrico";
            this.btnAcelerarElectrico.Size = new System.Drawing.Size(130, 48);
            this.btnAcelerarElectrico.TabIndex = 6;
            this.btnAcelerarElectrico.Text = "Acelerar Auto Eléctrico";
            this.btnAcelerarElectrico.UseVisualStyleBackColor = true;
            this.btnAcelerarElectrico.Click += new System.EventHandler(this.btnAcelerarElectrico_Click);
            // 
            // btnFrenarCamion
            // 
            this.btnFrenarCamion.Location = new System.Drawing.Point(260, 139);
            this.btnFrenarCamion.Name = "btnFrenarCamion";
            this.btnFrenarCamion.Size = new System.Drawing.Size(130, 28);
            this.btnFrenarCamion.TabIndex = 7;
            this.btnFrenarCamion.Text = "Frenar Camión";
            this.btnFrenarCamion.UseVisualStyleBackColor = true;
            this.btnFrenarCamion.Click += new System.EventHandler(this.btnFrenarCamion_Click);
            // 
            // frmVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFrenarCamion);
            this.Controls.Add(this.btnAcelerarElectrico);
            this.Controls.Add(this.btnFrenarElectrico);
            this.Controls.Add(this.btn_acelerarCamion);
            this.Controls.Add(this.btnQuitarRemolque);
            this.Controls.Add(this.btnAutoElectrico);
            this.Controls.Add(this.btnCamion);
            this.Name = "frmVehiculos";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCamion;
        private System.Windows.Forms.Button btnAutoElectrico;
        private System.Windows.Forms.Button btnQuitarRemolque;
        private System.Windows.Forms.Button btn_acelerarCamion;
        private System.Windows.Forms.Button btnFrenarElectrico;
        private System.Windows.Forms.Button btnAcelerarElectrico;
        private System.Windows.Forms.Button btnFrenarCamion;
    }
}

