
namespace Generador_X
{
    partial class FieldsTypeSelect
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
            this.FlowPanelFieldSelect = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TBSearchFieldType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FlowPanelFieldSelect
            // 
            this.FlowPanelFieldSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowPanelFieldSelect.Location = new System.Drawing.Point(0, 85);
            this.FlowPanelFieldSelect.Name = "FlowPanelFieldSelect";
            this.FlowPanelFieldSelect.Size = new System.Drawing.Size(634, 490);
            this.FlowPanelFieldSelect.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TBSearchFieldType);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 85);
            this.panel1.TabIndex = 1;
            // 
            // TBSearchFieldType
            // 
            this.TBSearchFieldType.Location = new System.Drawing.Point(441, 16);
            this.TBSearchFieldType.Name = "TBSearchFieldType";
            this.TBSearchFieldType.Size = new System.Drawing.Size(184, 23);
            this.TBSearchFieldType.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elige un tipo";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 0;
            // 
            // FieldsTypeSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 575);
            this.Controls.Add(this.FlowPanelFieldSelect);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(650, 39);
            this.Name = "FieldsTypeSelect";
            this.Text = "FieldsTypeSelect";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlowPanelFieldSelect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TBSearchFieldType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
    }
}