namespace Sensor
{
    partial class TemperaturaSensor
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
            this.txtescribir = new System.Windows.Forms.TextBox();
            this.btnconectar = new System.Windows.Forms.Button();
            this.btndesconectar = new System.Windows.Forms.Button();
            this.lbltemperatura = new System.Windows.Forms.Label();
            this.lblcon = new System.Windows.Forms.Label();
            this.lbltem = new System.Windows.Forms.Label();
            this.lbllimtem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtescribir
            // 
            this.txtescribir.Location = new System.Drawing.Point(82, 161);
            this.txtescribir.Margin = new System.Windows.Forms.Padding(4);
            this.txtescribir.Name = "txtescribir";
            this.txtescribir.Size = new System.Drawing.Size(164, 22);
            this.txtescribir.TabIndex = 13;
            // 
            // btnconectar
            // 
            this.btnconectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnconectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconectar.Location = new System.Drawing.Point(72, 294);
            this.btnconectar.Margin = new System.Windows.Forms.Padding(4);
            this.btnconectar.Name = "btnconectar";
            this.btnconectar.Size = new System.Drawing.Size(205, 64);
            this.btnconectar.TabIndex = 12;
            this.btnconectar.Text = "Conectar";
            this.btnconectar.UseVisualStyleBackColor = false;
            // 
            // btndesconectar
            // 
            this.btndesconectar.BackColor = System.Drawing.Color.Red;
            this.btndesconectar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btndesconectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndesconectar.Location = new System.Drawing.Point(568, 294);
            this.btndesconectar.Margin = new System.Windows.Forms.Padding(4);
            this.btndesconectar.Name = "btndesconectar";
            this.btndesconectar.Size = new System.Drawing.Size(205, 64);
            this.btndesconectar.TabIndex = 11;
            this.btndesconectar.Text = "desconectar";
            this.btndesconectar.UseVisualStyleBackColor = false;
            // 
            // lbltemperatura
            // 
            this.lbltemperatura.AutoSize = true;
            this.lbltemperatura.Font = new System.Drawing.Font("Microsoft YaHei UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltemperatura.Location = new System.Drawing.Point(581, 161);
            this.lbltemperatura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltemperatura.Name = "lbltemperatura";
            this.lbltemperatura.Size = new System.Drawing.Size(166, 106);
            this.lbltemperatura.TabIndex = 10;
            this.lbltemperatura.Text = "0.0";
            // 
            // lblcon
            // 
            this.lblcon.AutoSize = true;
            this.lblcon.Font = new System.Drawing.Font("MS PGothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcon.Location = new System.Drawing.Point(76, 233);
            this.lblcon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcon.Name = "lblcon";
            this.lblcon.Size = new System.Drawing.Size(166, 28);
            this.lblcon.TabIndex = 9;
            this.lblcon.Text = "Sin Conectar";
            // 
            // lbltem
            // 
            this.lbltem.AutoSize = true;
            this.lbltem.Font = new System.Drawing.Font("MS PGothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltem.Location = new System.Drawing.Point(573, 94);
            this.lbltem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltem.Name = "lbltem";
            this.lbltem.Size = new System.Drawing.Size(162, 28);
            this.lbltem.TabIndex = 8;
            this.lbltem.Text = "Temperatura";
            // 
            // lbllimtem
            // 
            this.lbllimtem.AutoSize = true;
            this.lbllimtem.Font = new System.Drawing.Font("MS PGothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllimtem.Location = new System.Drawing.Point(28, 92);
            this.lbllimtem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbllimtem.Name = "lbllimtem";
            this.lbllimtem.Size = new System.Drawing.Size(241, 23);
            this.lbllimtem.TabIndex = 7;
            this.lbllimtem.Text = "Limete De Temperatura";
            // 
            // TemperaturaSensor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtescribir);
            this.Controls.Add(this.btnconectar);
            this.Controls.Add(this.btndesconectar);
            this.Controls.Add(this.lbltemperatura);
            this.Controls.Add(this.lblcon);
            this.Controls.Add(this.lbltem);
            this.Controls.Add(this.lbllimtem);
            this.Name = "TemperaturaSensor";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TemperaturaSensor_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtescribir;
        private System.Windows.Forms.Button btnconectar;
        private System.Windows.Forms.Button btndesconectar;
        private System.Windows.Forms.Label lbltemperatura;
        private System.Windows.Forms.Label lblcon;
        private System.Windows.Forms.Label lbltem;
        private System.Windows.Forms.Label lbllimtem;
    }
}

