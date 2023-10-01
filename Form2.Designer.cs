namespace ExamenT2
{
    partial class Form2
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
            this.v_panel_buscar = new System.Windows.Forms.TableLayoutPanel();
            this.v_panel_buscar_controles = new System.Windows.Forms.TableLayoutPanel();
            this.v_txt_nombre = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.v_dg_medicamentos = new System.Windows.Forms.DataGridView();
            this.v_lbl_buscar_titulo = new System.Windows.Forms.Label();
            this.v_panel_buscar.SuspendLayout();
            this.v_panel_buscar_controles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_dg_medicamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // v_panel_buscar
            // 
            this.v_panel_buscar.BackColor = System.Drawing.Color.LightGray;
            this.v_panel_buscar.ColumnCount = 1;
            this.v_panel_buscar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.v_panel_buscar.Controls.Add(this.v_panel_buscar_controles, 0, 1);
            this.v_panel_buscar.Controls.Add(this.v_lbl_buscar_titulo, 0, 0);
            this.v_panel_buscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.v_panel_buscar.Location = new System.Drawing.Point(0, 0);
            this.v_panel_buscar.Name = "v_panel_buscar";
            this.v_panel_buscar.RowCount = 2;
            this.v_panel_buscar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.15346F));
            this.v_panel_buscar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.84654F));
            this.v_panel_buscar.Size = new System.Drawing.Size(800, 450);
            this.v_panel_buscar.TabIndex = 1;
            this.v_panel_buscar.Visible = false;
            // 
            // v_panel_buscar_controles
            // 
            this.v_panel_buscar_controles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.v_panel_buscar_controles.BackColor = System.Drawing.Color.White;
            this.v_panel_buscar_controles.ColumnCount = 3;
            this.v_panel_buscar_controles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.v_panel_buscar_controles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 183F));
            this.v_panel_buscar_controles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 333F));
            this.v_panel_buscar_controles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.v_panel_buscar_controles.Controls.Add(this.v_txt_nombre, 0, 0);
            this.v_panel_buscar_controles.Controls.Add(this.btnBuscar, 2, 0);
            this.v_panel_buscar_controles.Controls.Add(this.v_dg_medicamentos, 0, 1);
            this.v_panel_buscar_controles.Location = new System.Drawing.Point(3, 62);
            this.v_panel_buscar_controles.Name = "v_panel_buscar_controles";
            this.v_panel_buscar_controles.RowCount = 6;
            this.v_panel_buscar_controles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.v_panel_buscar_controles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.v_panel_buscar_controles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.v_panel_buscar_controles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.v_panel_buscar_controles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.v_panel_buscar_controles.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.v_panel_buscar_controles.Size = new System.Drawing.Size(794, 385);
            this.v_panel_buscar_controles.TabIndex = 0;
            this.v_panel_buscar_controles.Visible = false;
            // 
            // v_txt_nombre
            // 
            this.v_txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.v_panel_buscar_controles.SetColumnSpan(this.v_txt_nombre, 2);
            this.v_txt_nombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.v_txt_nombre.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_txt_nombre.Location = new System.Drawing.Point(3, 3);
            this.v_txt_nombre.MaxLength = 200;
            this.v_txt_nombre.Name = "v_txt_nombre";
            this.v_txt_nombre.Size = new System.Drawing.Size(455, 30);
            this.v_txt_nombre.TabIndex = 5;
            this.v_txt_nombre.Text = "Ingrese un nombre para buscar...";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Crimson;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Location = new System.Drawing.Point(464, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(153, 34);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar por nombre";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // v_dg_medicamentos
            // 
            this.v_dg_medicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.v_panel_buscar_controles.SetColumnSpan(this.v_dg_medicamentos, 3);
            this.v_dg_medicamentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.v_dg_medicamentos.Location = new System.Drawing.Point(3, 80);
            this.v_dg_medicamentos.Name = "v_dg_medicamentos";
            this.v_dg_medicamentos.RowHeadersWidth = 51;
            this.v_panel_buscar_controles.SetRowSpan(this.v_dg_medicamentos, 4);
            this.v_dg_medicamentos.RowTemplate.Height = 24;
            this.v_dg_medicamentos.Size = new System.Drawing.Size(788, 302);
            this.v_dg_medicamentos.TabIndex = 12;
            // 
            // v_lbl_buscar_titulo
            // 
            this.v_lbl_buscar_titulo.AutoSize = true;
            this.v_lbl_buscar_titulo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_lbl_buscar_titulo.Location = new System.Drawing.Point(3, 0);
            this.v_lbl_buscar_titulo.Name = "v_lbl_buscar_titulo";
            this.v_lbl_buscar_titulo.Size = new System.Drawing.Size(248, 31);
            this.v_lbl_buscar_titulo.TabIndex = 1;
            this.v_lbl_buscar_titulo.Text = "Buscar medicamentos";
            this.v_lbl_buscar_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.v_panel_buscar);
            this.Name = "Form2";
            this.Text = "Form2";
            this.v_panel_buscar.ResumeLayout(false);
            this.v_panel_buscar.PerformLayout();
            this.v_panel_buscar_controles.ResumeLayout(false);
            this.v_panel_buscar_controles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_dg_medicamentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel v_panel_buscar;
        private System.Windows.Forms.TableLayoutPanel v_panel_buscar_controles;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox v_txt_nombre;
        private System.Windows.Forms.Label v_lbl_buscar_titulo;
        private System.Windows.Forms.DataGridView v_dg_medicamentos;
    }
}