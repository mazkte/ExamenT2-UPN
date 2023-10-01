using System.CodeDom;
using System.Drawing;

namespace ExamenT2
{
    partial class FormMedicamentos
    {
        
        // <summary>
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
            this.components = new System.ComponentModel.Container();
            this.v_txt_buscar = new System.Windows.Forms.TextBox();
            this.v_btn_buscar = new System.Windows.Forms.Button();
            this.layout_container = new System.Windows.Forms.TableLayoutPanel();
            this.v_panel_menubar = new System.Windows.Forms.Panel();
            this.v_btn_menu_salir = new System.Windows.Forms.Button();
            this.v_btn_menu_registrar = new System.Windows.Forms.Button();
            this.v_btn_menu_buscar = new System.Windows.Forms.Button();
            this.v_btn_menu_eliminar = new System.Windows.Forms.Button();
            this.v_panel_header = new System.Windows.Forms.Panel();
            this.v_lbl_titulo = new System.Windows.Forms.Label();
            this.v_panel_container = new System.Windows.Forms.Panel();
            this.v_panel_registrar = new System.Windows.Forms.Panel();
            this.v_txt_codigo = new System.Windows.Forms.TextBox();
            this.v_lbl_codigo = new System.Windows.Forms.Label();
            this.v_lbl_nombre = new System.Windows.Forms.Label();
            this.v_lbl_cantidad = new System.Windows.Forms.Label();
            this.v_lbl_precio = new System.Windows.Forms.Label();
            this.v_txt_nombre = new System.Windows.Forms.TextBox();
            this.v_txt_cantidad = new System.Windows.Forms.TextBox();
            this.v_txt_precio = new System.Windows.Forms.TextBox();
            this.v_btn_registrar = new System.Windows.Forms.Button();
            this.v_btn_cancelar = new System.Windows.Forms.Button();
            this.medicamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_panel_busqueda = new System.Windows.Forms.Panel();
            this.layout_container.SuspendLayout();
            this.v_panel_menubar.SuspendLayout();
            this.v_panel_header.SuspendLayout();
            this.v_panel_container.SuspendLayout();
            this.v_panel_registrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // v_txt_buscar
            // 
            this.v_txt_buscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.v_txt_buscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.v_txt_buscar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_txt_buscar.Location = new System.Drawing.Point(3, 3);
            this.v_txt_buscar.MaxLength = 200;
            this.v_txt_buscar.Name = "v_txt_buscar";
            this.v_txt_buscar.Size = new System.Drawing.Size(455, 30);
            this.v_txt_buscar.TabIndex = 5;
            this.v_txt_buscar.Text = "Ingrese un nombre para buscar...";
            // 
            // v_btn_buscar
            // 
            this.v_btn_buscar.BackColor = System.Drawing.Color.Crimson;
            this.v_btn_buscar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.v_btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.v_btn_buscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_btn_buscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.v_btn_buscar.Location = new System.Drawing.Point(464, 3);
            this.v_btn_buscar.Name = "v_btn_buscar";
            this.v_btn_buscar.Size = new System.Drawing.Size(153, 34);
            this.v_btn_buscar.TabIndex = 11;
            this.v_btn_buscar.Text = "Buscar por nombre";
            this.v_btn_buscar.UseVisualStyleBackColor = false;
            // 
            // layout_container
            // 
            this.layout_container.ColumnCount = 2;
            this.layout_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.50424F));
            this.layout_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.49576F));
            this.layout_container.Controls.Add(this.v_panel_menubar, 0, 0);
            this.layout_container.Controls.Add(this.v_panel_header, 1, 0);
            this.layout_container.Controls.Add(this.v_panel_container, 1, 1);
            this.layout_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_container.Location = new System.Drawing.Point(0, 0);
            this.layout_container.Name = "layout_container";
            this.layout_container.RowCount = 2;
            this.layout_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.layout_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.layout_container.Size = new System.Drawing.Size(1262, 703);
            this.layout_container.TabIndex = 0;
            // 
            // v_panel_menubar
            // 
            this.v_panel_menubar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.v_panel_menubar.Controls.Add(this.v_btn_menu_salir);
            this.v_panel_menubar.Controls.Add(this.v_btn_menu_registrar);
            this.v_panel_menubar.Controls.Add(this.v_btn_menu_buscar);
            this.v_panel_menubar.Controls.Add(this.v_btn_menu_eliminar);
            this.v_panel_menubar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.v_panel_menubar.Location = new System.Drawing.Point(3, 3);
            this.v_panel_menubar.Name = "v_panel_menubar";
            this.layout_container.SetRowSpan(this.v_panel_menubar, 2);
            this.v_panel_menubar.Size = new System.Drawing.Size(139, 697);
            this.v_panel_menubar.TabIndex = 0;
            // 
            // v_btn_menu_salir
            // 
            this.v_btn_menu_salir.BackColor = System.Drawing.Color.SteelBlue;
            this.v_btn_menu_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.v_btn_menu_salir.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_btn_menu_salir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.v_btn_menu_salir.Location = new System.Drawing.Point(19, 408);
            this.v_btn_menu_salir.Name = "v_btn_menu_salir";
            this.v_btn_menu_salir.Size = new System.Drawing.Size(98, 104);
            this.v_btn_menu_salir.TabIndex = 11;
            this.v_btn_menu_salir.Text = "Salir";
            this.v_btn_menu_salir.UseVisualStyleBackColor = false;
            this.v_btn_menu_salir.Click += new System.EventHandler(this.v_btn_menu_salir_Click);
            // 
            // v_btn_menu_registrar
            // 
            this.v_btn_menu_registrar.BackColor = System.Drawing.Color.SteelBlue;
            this.v_btn_menu_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.v_btn_menu_registrar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_btn_menu_registrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.v_btn_menu_registrar.Location = new System.Drawing.Point(19, 78);
            this.v_btn_menu_registrar.Name = "v_btn_menu_registrar";
            this.v_btn_menu_registrar.Size = new System.Drawing.Size(98, 104);
            this.v_btn_menu_registrar.TabIndex = 8;
            this.v_btn_menu_registrar.Text = "Nuevo";
            this.v_btn_menu_registrar.UseVisualStyleBackColor = false;
            this.v_btn_menu_registrar.Click += new System.EventHandler(this.v_btn_menu_registrar_Click);
            // 
            // v_btn_menu_buscar
            // 
            this.v_btn_menu_buscar.BackColor = System.Drawing.Color.SteelBlue;
            this.v_btn_menu_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.v_btn_menu_buscar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_btn_menu_buscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.v_btn_menu_buscar.Location = new System.Drawing.Point(20, 188);
            this.v_btn_menu_buscar.Name = "v_btn_menu_buscar";
            this.v_btn_menu_buscar.Size = new System.Drawing.Size(98, 104);
            this.v_btn_menu_buscar.TabIndex = 9;
            this.v_btn_menu_buscar.Text = "Buscar";
            this.v_btn_menu_buscar.UseVisualStyleBackColor = false;
            this.v_btn_menu_buscar.Click += new System.EventHandler(this.v_btn_menu_buscar_Click);
            // 
            // v_btn_menu_eliminar
            // 
            this.v_btn_menu_eliminar.BackColor = System.Drawing.Color.SteelBlue;
            this.v_btn_menu_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.v_btn_menu_eliminar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_btn_menu_eliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.v_btn_menu_eliminar.Location = new System.Drawing.Point(19, 298);
            this.v_btn_menu_eliminar.Name = "v_btn_menu_eliminar";
            this.v_btn_menu_eliminar.Size = new System.Drawing.Size(98, 104);
            this.v_btn_menu_eliminar.TabIndex = 10;
            this.v_btn_menu_eliminar.Text = "Eliminar";
            this.v_btn_menu_eliminar.UseVisualStyleBackColor = false;
            this.v_btn_menu_eliminar.Click += new System.EventHandler(this.v_btn_menu_eliminar_Click);
            // 
            // v_panel_header
            // 
            this.v_panel_header.BackColor = System.Drawing.Color.Gainsboro;
            this.v_panel_header.Controls.Add(this.v_lbl_titulo);
            this.v_panel_header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.v_panel_header.Location = new System.Drawing.Point(148, 3);
            this.v_panel_header.Name = "v_panel_header";
            this.v_panel_header.Size = new System.Drawing.Size(1111, 99);
            this.v_panel_header.TabIndex = 1;
            // 
            // v_lbl_titulo
            // 
            this.v_lbl_titulo.AutoSize = true;
            this.v_lbl_titulo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_lbl_titulo.Location = new System.Drawing.Point(44, 20);
            this.v_lbl_titulo.Name = "v_lbl_titulo";
            this.v_lbl_titulo.Size = new System.Drawing.Size(79, 31);
            this.v_lbl_titulo.TabIndex = 0;
            this.v_lbl_titulo.Text = "label1";
            // 
            // v_panel_container
            // 
            this.v_panel_container.BackColor = System.Drawing.Color.White;
            this.v_panel_container.Controls.Add(this.v_panel_registrar);
            this.v_panel_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.v_panel_container.Location = new System.Drawing.Point(148, 108);
            this.v_panel_container.Name = "v_panel_container";
            this.v_panel_container.Size = new System.Drawing.Size(1111, 592);
            this.v_panel_container.TabIndex = 2;
            // 
            // v_panel_registrar
            // 
            this.v_panel_registrar.Controls.Add(this.v_panel_busqueda);
            this.v_panel_registrar.Controls.Add(this.v_txt_codigo);
            this.v_panel_registrar.Controls.Add(this.v_lbl_codigo);
            this.v_panel_registrar.Controls.Add(this.v_lbl_nombre);
            this.v_panel_registrar.Controls.Add(this.v_lbl_cantidad);
            this.v_panel_registrar.Controls.Add(this.v_lbl_precio);
            this.v_panel_registrar.Controls.Add(this.v_txt_nombre);
            this.v_panel_registrar.Controls.Add(this.v_txt_cantidad);
            this.v_panel_registrar.Controls.Add(this.v_txt_precio);
            this.v_panel_registrar.Controls.Add(this.v_btn_registrar);
            this.v_panel_registrar.Controls.Add(this.v_btn_cancelar);
            this.v_panel_registrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.v_panel_registrar.Location = new System.Drawing.Point(0, 0);
            this.v_panel_registrar.Name = "v_panel_registrar";
            this.v_panel_registrar.Size = new System.Drawing.Size(1111, 592);
            this.v_panel_registrar.TabIndex = 0;
            // 
            // v_txt_codigo
            // 
            this.v_txt_codigo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.v_txt_codigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.v_txt_codigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.v_txt_codigo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_txt_codigo.Location = new System.Drawing.Point(241, 62);
            this.v_txt_codigo.Name = "v_txt_codigo";
            this.v_txt_codigo.Size = new System.Drawing.Size(324, 30);
            this.v_txt_codigo.TabIndex = 33;
            this.v_txt_codigo.Enter += new System.EventHandler(this.FocusEnter);
            this.v_txt_codigo.Leave += new System.EventHandler(this.FocusLeave);
            // 
            // v_lbl_codigo
            // 
            this.v_lbl_codigo.AutoSize = true;
            this.v_lbl_codigo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_lbl_codigo.Location = new System.Drawing.Point(34, 62);
            this.v_lbl_codigo.Name = "v_lbl_codigo";
            this.v_lbl_codigo.Size = new System.Drawing.Size(74, 23);
            this.v_lbl_codigo.TabIndex = 23;
            this.v_lbl_codigo.Text = "Código :";
            // 
            // v_lbl_nombre
            // 
            this.v_lbl_nombre.AutoSize = true;
            this.v_lbl_nombre.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_lbl_nombre.Location = new System.Drawing.Point(34, 155);
            this.v_lbl_nombre.Name = "v_lbl_nombre";
            this.v_lbl_nombre.Size = new System.Drawing.Size(82, 23);
            this.v_lbl_nombre.TabIndex = 24;
            this.v_lbl_nombre.Text = "Nombre :";
            this.v_lbl_nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // v_lbl_cantidad
            // 
            this.v_lbl_cantidad.AutoSize = true;
            this.v_lbl_cantidad.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_lbl_cantidad.Location = new System.Drawing.Point(34, 265);
            this.v_lbl_cantidad.Name = "v_lbl_cantidad";
            this.v_lbl_cantidad.Size = new System.Drawing.Size(88, 23);
            this.v_lbl_cantidad.TabIndex = 25;
            this.v_lbl_cantidad.Text = "Cantidad :";
            this.v_lbl_cantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // v_lbl_precio
            // 
            this.v_lbl_precio.AutoSize = true;
            this.v_lbl_precio.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_lbl_precio.Location = new System.Drawing.Point(34, 375);
            this.v_lbl_precio.Name = "v_lbl_precio";
            this.v_lbl_precio.Size = new System.Drawing.Size(130, 23);
            this.v_lbl_precio.TabIndex = 26;
            this.v_lbl_precio.Text = "Precio unitario :";
            this.v_lbl_precio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // v_txt_nombre
            // 
            this.v_txt_nombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.v_txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.v_txt_nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.v_txt_nombre.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_txt_nombre.Location = new System.Drawing.Point(241, 155);
            this.v_txt_nombre.Name = "v_txt_nombre";
            this.v_txt_nombre.Size = new System.Drawing.Size(324, 30);
            this.v_txt_nombre.TabIndex = 28;
            this.v_txt_nombre.Enter += new System.EventHandler(this.FocusEnter);
            this.v_txt_nombre.Leave += new System.EventHandler(this.FocusLeave);
            // 
            // v_txt_cantidad
            // 
            this.v_txt_cantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.v_txt_cantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.v_txt_cantidad.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_txt_cantidad.Location = new System.Drawing.Point(241, 265);
            this.v_txt_cantidad.Name = "v_txt_cantidad";
            this.v_txt_cantidad.Size = new System.Drawing.Size(324, 30);
            this.v_txt_cantidad.TabIndex = 29;
            // 
            // v_txt_precio
            // 
            this.v_txt_precio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.v_txt_precio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.v_txt_precio.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_txt_precio.Location = new System.Drawing.Point(241, 375);
            this.v_txt_precio.Name = "v_txt_precio";
            this.v_txt_precio.Size = new System.Drawing.Size(324, 30);
            this.v_txt_precio.TabIndex = 30;
            // 
            // v_btn_registrar
            // 
            this.v_btn_registrar.BackColor = System.Drawing.Color.SteelBlue;
            this.v_btn_registrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.v_btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.v_btn_registrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_btn_registrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.v_btn_registrar.Location = new System.Drawing.Point(592, 470);
            this.v_btn_registrar.Name = "v_btn_registrar";
            this.v_btn_registrar.Size = new System.Drawing.Size(153, 34);
            this.v_btn_registrar.TabIndex = 31;
            this.v_btn_registrar.Text = "Registrar";
            this.v_btn_registrar.UseVisualStyleBackColor = false;
            this.v_btn_registrar.Click += new System.EventHandler(this.v_btn_registrar_Click);
            // 
            // v_btn_cancelar
            // 
            this.v_btn_cancelar.BackColor = System.Drawing.Color.SteelBlue;
            this.v_btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.v_btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.v_btn_cancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_btn_cancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.v_btn_cancelar.Location = new System.Drawing.Point(773, 470);
            this.v_btn_cancelar.Name = "v_btn_cancelar";
            this.v_btn_cancelar.Size = new System.Drawing.Size(153, 34);
            this.v_btn_cancelar.TabIndex = 32;
            this.v_btn_cancelar.Text = "Cancelar";
            this.v_btn_cancelar.UseVisualStyleBackColor = false;
            this.v_btn_cancelar.Click += new System.EventHandler(this.v_btn_cancelar_Click);
            // 
            // medicamentoBindingSource
            // 
            this.medicamentoBindingSource.DataSource = typeof(ExamenT2.Medicamento);
            // 
            // v_panel_busqueda
            // 
            this.v_panel_busqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.v_panel_busqueda.Location = new System.Drawing.Point(0, 0);
            this.v_panel_busqueda.Name = "v_panel_busqueda";
            this.v_panel_busqueda.Size = new System.Drawing.Size(1389, 740);
            this.v_panel_busqueda.TabIndex = 34;
            // 
            // FormMedicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 703);
            this.Controls.Add(this.layout_container);
            this.MaximizeBox = false;
            this.Name = "FormMedicamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de Medicamentos";
            this.layout_container.ResumeLayout(false);
            this.v_panel_menubar.ResumeLayout(false);
            this.v_panel_header.ResumeLayout(false);
            this.v_panel_header.PerformLayout();
            this.v_panel_container.ResumeLayout(false);
            this.v_panel_registrar.ResumeLayout(false);
            this.v_panel_registrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

   

        #endregion
        private System.Windows.Forms.BindingSource medicamentoBindingSource;
        private System.Windows.Forms.Button v_btn_buscar;
        private System.Windows.Forms.TextBox v_txt_buscar;
        private System.Windows.Forms.TableLayoutPanel layout_container;
        private System.Windows.Forms.Panel v_panel_menubar;
        private System.Windows.Forms.Button v_btn_menu_salir;
        private System.Windows.Forms.Button v_btn_menu_registrar;
        private System.Windows.Forms.Button v_btn_menu_buscar;
        private System.Windows.Forms.Button v_btn_menu_eliminar;
        private System.Windows.Forms.Panel v_panel_container;
        private System.Windows.Forms.Panel v_panel_header;
        private System.Windows.Forms.Label v_lbl_titulo;
        private System.Windows.Forms.TextBox v_txtNombre;
        private System.Windows.Forms.Panel v_panel_registrar;
        private System.Windows.Forms.Label v_lbl_codigo;
        private System.Windows.Forms.Label v_lbl_nombre;
        private System.Windows.Forms.Label v_lbl_cantidad;
        private System.Windows.Forms.Label v_lbl_precio;
        private System.Windows.Forms.TextBox v_txt_nombre;
        private System.Windows.Forms.TextBox v_txt_cantidad;
        private System.Windows.Forms.TextBox v_txt_precio;
        private System.Windows.Forms.Button v_btn_registrar;
        private System.Windows.Forms.Button v_btn_cancelar;
        private System.Windows.Forms.TextBox v_txt_codigo;
        private System.Windows.Forms.Panel v_panel_busqueda;
    }
}

