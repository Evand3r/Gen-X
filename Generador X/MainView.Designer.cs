
namespace Generador_X
{
    partial class MainView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTNPreview = new System.Windows.Forms.Button();
            this.BtnGenerar = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.TBNumFilas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CBFormatoSalida = new System.Windows.Forms.ComboBox();
            this.PanelFormatoOpciones = new System.Windows.Forms.FlowLayoutPanel();
            this.StackedPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BttnAddField = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BttnBajar = new System.Windows.Forms.Button();
            this.BttnSubir = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel5 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.StackedPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BttnAddField)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(219, 8);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(49, 25);
            label4.TabIndex = 0;
            label4.Text = "Tipo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(388, 8);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(91, 25);
            label5.TabIndex = 0;
            label5.Text = "Opciones";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(18, 8);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(177, 25);
            label2.TabIndex = 0;
            label2.Text = "Nombre del campo";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BTNPreview);
            this.panel1.Controls.Add(this.BtnGenerar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 611);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 50);
            this.panel1.TabIndex = 0;
            // 
            // BTNPreview
            // 
            this.BTNPreview.BackColor = System.Drawing.Color.White;
            this.BTNPreview.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BTNPreview.FlatAppearance.BorderSize = 2;
            this.BTNPreview.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.BTNPreview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.BTNPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNPreview.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTNPreview.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.BTNPreview.Location = new System.Drawing.Point(133, 10);
            this.BTNPreview.Name = "BTNPreview";
            this.BTNPreview.Size = new System.Drawing.Size(103, 29);
            this.BTNPreview.TabIndex = 2;
            this.BTNPreview.Text = "Vista previa";
            this.BTNPreview.UseVisualStyleBackColor = false;
            this.BTNPreview.Click += new System.EventHandler(this.BTNPreview_Click);
            // 
            // BtnGenerar
            // 
            this.BtnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(150)))), ((int)(((byte)(170)))));
            this.BtnGenerar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnGenerar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.BtnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGenerar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGenerar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnGenerar.Location = new System.Drawing.Point(13, 10);
            this.BtnGenerar.Name = "BtnGenerar";
            this.BtnGenerar.Size = new System.Drawing.Size(103, 29);
            this.BtnGenerar.TabIndex = 2;
            this.BtnGenerar.Text = "Generar";
            this.BtnGenerar.UseVisualStyleBackColor = false;
            this.BtnGenerar.Click += new System.EventHandler(this.BTNGenerar_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.TBNumFilas);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.CBFormatoSalida);
            this.flowLayoutPanel1.Controls.Add(this.PanelFormatoOpciones);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 571);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(884, 40);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "No. de Filas:";
            // 
            // TBNumFilas
            // 
            this.TBNumFilas.Location = new System.Drawing.Point(81, 7);
            this.TBNumFilas.Margin = new System.Windows.Forms.Padding(0, 7, 3, 3);
            this.TBNumFilas.Name = "TBNumFilas";
            this.TBNumFilas.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TBNumFilas.Size = new System.Drawing.Size(71, 23);
            this.TBNumFilas.TabIndex = 3;
            this.TBNumFilas.Text = "500";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 10, 0, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Formato:";
            // 
            // CBFormatoSalida
            // 
            this.CBFormatoSalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBFormatoSalida.FormattingEnabled = true;
            this.CBFormatoSalida.Location = new System.Drawing.Point(218, 7);
            this.CBFormatoSalida.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.CBFormatoSalida.Name = "CBFormatoSalida";
            this.CBFormatoSalida.Size = new System.Drawing.Size(103, 23);
            this.CBFormatoSalida.TabIndex = 5;
            this.CBFormatoSalida.SelectedIndexChanged += new System.EventHandler(this.CBFormatoSalida_SelectedIndexChanged);
            // 
            // PanelFormatoOpciones
            // 
            this.PanelFormatoOpciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelFormatoOpciones.Location = new System.Drawing.Point(327, 3);
            this.PanelFormatoOpciones.Name = "PanelFormatoOpciones";
            this.PanelFormatoOpciones.Size = new System.Drawing.Size(450, 29);
            this.PanelFormatoOpciones.TabIndex = 6;
            // 
            // StackedPanel
            // 
            this.StackedPanel.AutoScroll = true;
            this.StackedPanel.Controls.Add(this.panel3);
            this.StackedPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StackedPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.StackedPanel.Location = new System.Drawing.Point(0, 74);
            this.StackedPanel.Name = "StackedPanel";
            this.StackedPanel.Size = new System.Drawing.Size(884, 497);
            this.StackedPanel.TabIndex = 0;
            this.StackedPanel.WrapContents = false;
            this.StackedPanel.Resize += new System.EventHandler(this.StackedPanel_Resize);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.flowLayoutPanel2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.MinimumSize = new System.Drawing.Size(775, 2);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(4);
            this.panel3.Size = new System.Drawing.Size(775, 50);
            this.panel3.TabIndex = 0;
            this.panel3.Visible = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Controls.Add(this.textBox1);
            this.flowLayoutPanel2.Controls.Add(this.label6);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(354, 4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(375, 40);
            this.flowLayoutPanel2.TabIndex = 9;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(23, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "99";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 13);
            this.label6.Margin = new System.Windows.Forms.Padding(0, 7, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "%";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(729, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Añadir campo.");
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.textBox2);
            this.panel6.Controls.Add(this.button1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(4, 4);
            this.panel6.MaximumSize = new System.Drawing.Size(370, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(350, 40);
            this.panel6.TabIndex = 7;
            this.panel6.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(10, 9);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(170, 23);
            this.textBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(211, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BttnAddField);
            this.panel2.Controls.Add(label5);
            this.panel2.Controls.Add(label4);
            this.panel2.Controls.Add(label2);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(884, 50);
            this.panel2.TabIndex = 1;
            // 
            // BttnAddField
            // 
            this.BttnAddField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BttnAddField.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BttnAddField.BackgroundImage")));
            this.BttnAddField.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BttnAddField.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BttnAddField.Location = new System.Drawing.Point(835, 0);
            this.BttnAddField.Margin = new System.Windows.Forms.Padding(5);
            this.BttnAddField.Name = "BttnAddField";
            this.BttnAddField.Size = new System.Drawing.Size(49, 50);
            this.BttnAddField.TabIndex = 1;
            this.BttnAddField.TabStop = false;
            this.toolTip1.SetToolTip(this.BttnAddField, "Añadir campo.");
            this.BttnAddField.Click += new System.EventHandler(this.BttnAddField_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel4.Controls.Add(this.BttnBajar);
            this.panel4.Controls.Add(this.BttnSubir);
            this.panel4.Location = new System.Drawing.Point(746, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(81, 41);
            this.panel4.TabIndex = 4;
            // 
            // BttnBajar
            // 
            this.BttnBajar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BttnBajar.BackgroundImage")));
            this.BttnBajar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BttnBajar.Location = new System.Drawing.Point(46, 3);
            this.BttnBajar.Name = "BttnBajar";
            this.BttnBajar.Size = new System.Drawing.Size(35, 35);
            this.BttnBajar.TabIndex = 4;
            this.toolTip1.SetToolTip(this.BttnBajar, "Mover campo hacia abajo.");
            this.BttnBajar.UseVisualStyleBackColor = true;
            this.BttnBajar.Click += new System.EventHandler(this.BtnBajar_Click);
            // 
            // BttnSubir
            // 
            this.BttnSubir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BttnSubir.BackgroundImage")));
            this.BttnSubir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BttnSubir.Location = new System.Drawing.Point(0, 3);
            this.BttnSubir.Name = "BttnSubir";
            this.BttnSubir.Size = new System.Drawing.Size(35, 35);
            this.BttnSubir.TabIndex = 3;
            this.toolTip1.SetToolTip(this.BttnSubir, "Mover campo hacia arriba.");
            this.BttnSubir.UseVisualStyleBackColor = true;
            this.BttnSubir.Click += new System.EventHandler(this.BtnSubir_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkRed;
            this.panel5.Location = new System.Drawing.Point(3, 109);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(497, 100);
            this.panel5.TabIndex = 0;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.StackedPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MinimumSize = new System.Drawing.Size(900, 700);
            this.Name = "MainView";
            this.Text = "Gen X";
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.StackedPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BttnAddField)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel StackedPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBNumFilas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBFormatoSalida;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox BttnAddField;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BttnBajar;
        private System.Windows.Forms.Button BttnSubir;
        private System.Windows.Forms.FlowLayoutPanel PanelFormatoOpciones;
        private System.Windows.Forms.Button BtnGenerar;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BTNPreview;
    }
}

