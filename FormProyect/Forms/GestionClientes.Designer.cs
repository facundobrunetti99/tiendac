namespace FormProyect
{
    partial class GestionClientes
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionClientes));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            colorDialog1 = new ColorDialog();
            imageList1 = new ImageList(components);
            label1 = new Label();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LightPink;
            button1.Font = new Font("Segoe UI", 11F);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(50, 238);
            button1.Name = "button1";
            button1.Size = new Size(192, 81);
            button1.TabIndex = 0;
            button1.Text = "Modificar producto";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.LightPink;
            button2.Font = new Font("Segoe UI", 11F);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(50, 34);
            button2.Name = "button2";
            button2.Size = new Size(192, 81);
            button2.TabIndex = 1;
            button2.Text = "Cargar producto";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightPink;
            button3.Font = new Font("Segoe UI", 11F);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(50, 133);
            button3.Name = "button3";
            button3.Size = new Size(192, 81);
            button3.TabIndex = 2;
            button3.Text = "Eliminar producto";
            button3.UseVisualStyleBackColor = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "analu.jpg");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(454, 134);
            label1.Name = "label1";
            label1.Size = new Size(222, 120);
            label1.TabIndex = 3;
            label1.Text = "Analu \r\nPasteleria\r\n";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // button4
            // 
            button4.BackColor = Color.LightPink;
            button4.Font = new Font("Segoe UI", 11F);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(50, 343);
            button4.Name = "button4";
            button4.Size = new Size(192, 81);
            button4.TabIndex = 4;
            button4.Text = "Mostrar producto";
            button4.UseVisualStyleBackColor = false;
            // 
            // GestionClientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GestionClientes";
            Text = "GestionDeClientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private ColorDialog colorDialog1;
        private ImageList imageList1;
        private Label label1;
        private Button button4;
    }
}