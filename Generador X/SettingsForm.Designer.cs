
namespace Generador_X
{
    partial class SettingsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.CBLanguages = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBNullValue = new System.Windows.Forms.TextBox();
            this.BTNAplicar = new System.Windows.Forms.Button();
            this.BTNCancelar = new System.Windows.Forms.Button();
            this.BTNOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Idioma de salida";
            // 
            // CBLanguages
            // 
            this.CBLanguages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBLanguages.FormattingEnabled = true;
            this.CBLanguages.Location = new System.Drawing.Point(144, 20);
            this.CBLanguages.Name = "CBLanguages";
            this.CBLanguages.Size = new System.Drawing.Size(132, 23);
            this.CBLanguages.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Valor para datos nulos";
            // 
            // TBNullValue
            // 
            this.TBNullValue.Location = new System.Drawing.Point(144, 60);
            this.TBNullValue.MaxLength = 10;
            this.TBNullValue.Name = "TBNullValue";
            this.TBNullValue.Size = new System.Drawing.Size(132, 23);
            this.TBNullValue.TabIndex = 2;
            // 
            // BTNAplicar
            // 
            this.BTNAplicar.Enabled = false;
            this.BTNAplicar.Location = new System.Drawing.Point(201, 171);
            this.BTNAplicar.Name = "BTNAplicar";
            this.BTNAplicar.Size = new System.Drawing.Size(75, 23);
            this.BTNAplicar.TabIndex = 3;
            this.BTNAplicar.Text = "Aplicar";
            this.BTNAplicar.UseVisualStyleBackColor = true;
            this.BTNAplicar.Click += new System.EventHandler(this.BTNAplicar_Click);
            // 
            // BTNCancelar
            // 
            this.BTNCancelar.Location = new System.Drawing.Point(120, 171);
            this.BTNCancelar.Name = "BTNCancelar";
            this.BTNCancelar.Size = new System.Drawing.Size(75, 23);
            this.BTNCancelar.TabIndex = 3;
            this.BTNCancelar.Text = "Cancelar";
            this.BTNCancelar.UseVisualStyleBackColor = true;
            this.BTNCancelar.Click += new System.EventHandler(this.BTNCancelar_Click);
            // 
            // BTNOK
            // 
            this.BTNOK.Location = new System.Drawing.Point(39, 171);
            this.BTNOK.Name = "BTNOK";
            this.BTNOK.Size = new System.Drawing.Size(75, 23);
            this.BTNOK.TabIndex = 3;
            this.BTNOK.Text = "OK";
            this.BTNOK.UseVisualStyleBackColor = true;
            this.BTNOK.Click += new System.EventHandler(this.BTNOK_Click);
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 206);
            this.Controls.Add(this.BTNOK);
            this.Controls.Add(this.BTNCancelar);
            this.Controls.Add(this.BTNAplicar);
            this.Controls.Add(this.TBNullValue);
            this.Controls.Add(this.CBLanguages);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBLanguages;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBNullValue;
        private System.Windows.Forms.Button BTNAplicar;
        private System.Windows.Forms.Button BTNCancelar;
        private System.Windows.Forms.Button BTNOK;
    }
}