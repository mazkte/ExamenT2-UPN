namespace ExamenT2
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
            this.layout_principal = new System.Windows.Forms.TableLayoutPanel();
            this.panel_izquierdo = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_contenedor = new System.Windows.Forms.Panel();
            this.panel_uno = new System.Windows.Forms.Panel();
            this.panel_dos = new System.Windows.Forms.Panel();
            this.layout_principal.SuspendLayout();
            this.panel_izquierdo.SuspendLayout();
            this.panel_contenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // layout_principal
            // 
            this.layout_principal.BackColor = System.Drawing.Color.LightGray;
            this.layout_principal.ColumnCount = 2;
            this.layout_principal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.58678F));
            this.layout_principal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.41322F));
            this.layout_principal.Controls.Add(this.panel_izquierdo, 0, 0);
            this.layout_principal.Controls.Add(this.panel_contenedor, 1, 0);
            this.layout_principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_principal.Location = new System.Drawing.Point(0, 0);
            this.layout_principal.Name = "layout_principal";
            this.layout_principal.RowCount = 1;
            this.layout_principal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_principal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layout_principal.Size = new System.Drawing.Size(800, 450);
            this.layout_principal.TabIndex = 0;
            // 
            // panel_izquierdo
            // 
            this.panel_izquierdo.BackColor = System.Drawing.Color.SkyBlue;
            this.panel_izquierdo.Controls.Add(this.button2);
            this.panel_izquierdo.Controls.Add(this.button1);
            this.panel_izquierdo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_izquierdo.Location = new System.Drawing.Point(3, 3);
            this.panel_izquierdo.Name = "panel_izquierdo";
            this.panel_izquierdo.Size = new System.Drawing.Size(190, 444);
            this.panel_izquierdo.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 107);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 35);
            this.button1.Margin = new System.Windows.Forms.Padding(8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 107);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel_contenedor
            // 
            this.panel_contenedor.BackColor = System.Drawing.Color.LightBlue;
            this.panel_contenedor.Controls.Add(this.panel_uno);
            this.panel_contenedor.Controls.Add(this.panel_dos);
            this.panel_contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_contenedor.Location = new System.Drawing.Point(199, 3);
            this.panel_contenedor.Name = "panel_contenedor";
            this.panel_contenedor.Size = new System.Drawing.Size(598, 444);
            this.panel_contenedor.TabIndex = 1;
            // 
            // panel_uno
            // 
            this.panel_uno.BackColor = System.Drawing.Color.Fuchsia;
            this.panel_uno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_uno.Location = new System.Drawing.Point(0, 0);
            this.panel_uno.Name = "panel_uno";
            this.panel_uno.Size = new System.Drawing.Size(598, 444);
            this.panel_uno.TabIndex = 0;
            // 
            // panel_dos
            // 
            this.panel_dos.BackColor = System.Drawing.Color.LightPink;
            this.panel_dos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_dos.Location = new System.Drawing.Point(0, 0);
            this.panel_dos.Name = "panel_dos";
            this.panel_dos.Size = new System.Drawing.Size(598, 444);
            this.panel_dos.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.layout_principal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.layout_principal.ResumeLayout(false);
            this.panel_izquierdo.ResumeLayout(false);
            this.panel_contenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

      
        private System.Windows.Forms.TableLayoutPanel layout_principal;
        private System.Windows.Forms.Panel panel_izquierdo;
        private System.Windows.Forms.Panel panel_contenedor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel_uno;
        private System.Windows.Forms.Panel panel_dos;
    }
}