
namespace Generador_X
{
    partial class PreviewForm
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
            this.TBExampleText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TBExampleText
            // 
            this.TBExampleText.BackColor = System.Drawing.Color.White;
            this.TBExampleText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBExampleText.Location = new System.Drawing.Point(0, 0);
            this.TBExampleText.Multiline = true;
            this.TBExampleText.Name = "TBExampleText";
            this.TBExampleText.ReadOnly = true;
            this.TBExampleText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TBExampleText.Size = new System.Drawing.Size(784, 461);
            this.TBExampleText.TabIndex = 2;
            this.TBExampleText.WordWrap = false;
            // 
            // PreviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.TBExampleText);
            this.Name = "PreviewForm";
            this.Text = "Vista Previa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBExampleText;
    }
}