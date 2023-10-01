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
            this.v_btn_menu_registrar = new System.Windows.Forms.Button();
            this.v_btn_menu_buscar = new System.Windows.Forms.Button();
            this.v_btn_menu_eliminar = new System.Windows.Forms.Button();
            this.v_btn_menu_salir = new System.Windows.Forms.Button();
            this.v_pnl_inicio = new System.Windows.Forms.Panel();
            this.v_panel_registro = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.v_panel_registro_controles = new System.Windows.Forms.TableLayoutPanel();
            this.v_lbl_codigo = new System.Windows.Forms.Label();
            this.v_lbl_nombre = new System.Windows.Forms.Label();
            this.v_lbl_cantidad = new System.Windows.Forms.Label();
            this.v_lbl_precio = new System.Windows.Forms.Label();
            this.v_txt_codigo = new System.Windows.Forms.TextBox();
            this.v_txtNombre = new System.Windows.Forms.TextBox();
            this.v_txt_cantidad = new System.Windows.Forms.TextBox();
            this.v_txt_precio = new System.Windows.Forms.TextBox();
            this.v_btn_registrar = new System.Windows.Forms.Button();
            this.v_btn_cancelar = new System.Windows.Forms.Button();
            this.v_lbl_titulo = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.v_txt_buscar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.v_pnl_menu = new System.Windows.Forms.Panel();
            this.v_panel_buscar = new System.Windows.Forms.TableLayoutPanel();
            this.v_panel_buscar_controles = new System.Windows.Forms.TableLayoutPanel();
            this.v_txt_nombre = new System.Windows.Forms.TextBox();
            this.v_dg_medicamentos = new System.Windows.Forms.DataGridView();
            this.v_lbl_buscar_titulo = new System.Windows.Forms.Label();
            this.v_btn_buscar = new System.Windows.Forms.Button();
            this.medicamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_pnl_inicio.SuspendLayout();
            this.v_panel_registro.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.v_panel_registro_controles.SuspendLayout();
            this.v_pnl_menu.SuspendLayout();
            this.v_panel_buscar.SuspendLayout();
            this.v_panel_buscar_controles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_dg_medicamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // v_btn_menu_registrar
            // 
            this.v_btn_menu_registrar.BackColor = System.Drawing.Color.SteelBlue;
            this.v_btn_menu_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.v_btn_menu_registrar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_btn_menu_registrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.v_btn_menu_registrar.Location = new System.Drawing.Point(17, 21);
            this.v_btn_menu_registrar.Name = "v_btn_menu_registrar";
            this.v_btn_menu_registrar.Size = new System.Drawing.Size(98, 104);
            this.v_btn_menu_registrar.TabIndex = 0;
            this.v_btn_menu_registrar.Text = "Nuevo";
            this.v_btn_menu_registrar.UseVisualStyleBackColor = false;
            this.v_btn_menu_registrar.Click += new System.EventHandler(this.NuevoRegistro);
            // 
            // v_btn_menu_buscar
            // 
            this.v_btn_menu_buscar.BackColor = System.Drawing.Color.SteelBlue;
            this.v_btn_menu_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.v_btn_menu_buscar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_btn_menu_buscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.v_btn_menu_buscar.Location = new System.Drawing.Point(18, 131);
            this.v_btn_menu_buscar.Name = "v_btn_menu_buscar";
            this.v_btn_menu_buscar.Size = new System.Drawing.Size(98, 104);
            this.v_btn_menu_buscar.TabIndex = 1;
            this.v_btn_menu_buscar.Text = "Buscar";
            this.v_btn_menu_buscar.UseVisualStyleBackColor = false;
            this.v_btn_menu_buscar.Click += new System.EventHandler(this.button2_Click);
            // 
            // v_btn_menu_eliminar
            // 
            this.v_btn_menu_eliminar.BackColor = System.Drawing.Color.SteelBlue;
            this.v_btn_menu_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.v_btn_menu_eliminar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_btn_menu_eliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.v_btn_menu_eliminar.Location = new System.Drawing.Point(17, 241);
            this.v_btn_menu_eliminar.Name = "v_btn_menu_eliminar";
            this.v_btn_menu_eliminar.Size = new System.Drawing.Size(98, 104);
            this.v_btn_menu_eliminar.TabIndex = 2;
            this.v_btn_menu_eliminar.Text = "Eliminar";
            this.v_btn_menu_eliminar.UseVisualStyleBackColor = false;
            // 
            // v_btn_menu_salir
            // 
            this.v_btn_menu_salir.BackColor = System.Drawing.Color.SteelBlue;
            this.v_btn_menu_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.v_btn_menu_salir.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_btn_menu_salir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.v_btn_menu_salir.Location = new System.Drawing.Point(17, 351);
            this.v_btn_menu_salir.Name = "v_btn_menu_salir";
            this.v_btn_menu_salir.Size = new System.Drawing.Size(98, 104);
            this.v_btn_menu_salir.TabIndex = 3;
            this.v_btn_menu_salir.Text = "Salir";
            this.v_btn_menu_salir.UseVisualStyleBackColor = false;
            this.v_btn_menu_salir.Click += new System.EventHandler(this.v_btn_menu_salir_Click);
            // 
            // v_pnl_inicio
            // 
            this.v_pnl_inicio.BackColor = System.Drawing.Color.White;
            this.v_pnl_inicio.Controls.Add(this.v_panel_registro);
            this.v_pnl_inicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.v_pnl_inicio.Location = new System.Drawing.Point(134, 0);
            this.v_pnl_inicio.Name = "v_pnl_inicio";
            this.v_pnl_inicio.Size = new System.Drawing.Size(1066, 600);
            this.v_pnl_inicio.TabIndex = 1;
            // 
            // v_panel_registro
            // 
            this.v_panel_registro.BackColor = System.Drawing.Color.LightGray;
            this.v_panel_registro.ColumnCount = 1;
            this.v_panel_registro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.v_panel_registro.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.v_panel_registro.Controls.Add(this.v_panel_registro_controles, 0, 1);
            this.v_panel_registro.Controls.Add(this.v_lbl_titulo, 0, 0);
            this.v_panel_registro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.v_panel_registro.Location = new System.Drawing.Point(0, 0);
            this.v_panel_registro.Name = "v_panel_registro";
            this.v_panel_registro.RowCount = 3;
            this.v_panel_registro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.15346F));
            this.v_panel_registro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.84654F));
            this.v_panel_registro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.v_panel_registro.Size = new System.Drawing.Size(1066, 600);
            this.v_panel_registro.TabIndex = 0;
            this.v_panel_registro.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.LightGray;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 582);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.15346F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.84654F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1060, 15);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 183F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1054, 8);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.Visible = false;
            // 
            // v_panel_registro_controles
            // 
            this.v_panel_registro_controles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.v_panel_registro_controles.BackColor = System.Drawing.Color.White;
            this.v_panel_registro_controles.ColumnCount = 4;
            this.v_panel_registro_controles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.98473F));
            this.v_panel_registro_controles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.01527F));
            this.v_panel_registro_controles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 183F));
            this.v_panel_registro_controles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 356F));
            this.v_panel_registro_controles.Controls.Add(this.v_lbl_codigo, 0, 0);
            this.v_panel_registro_controles.Controls.Add(this.v_lbl_nombre, 0, 1);
            this.v_panel_registro_controles.Controls.Add(this.v_lbl_cantidad, 0, 2);
            this.v_panel_registro_controles.Controls.Add(this.v_lbl_precio, 0, 3);
            this.v_panel_registro_controles.Controls.Add(this.v_txt_codigo, 1, 0);
            this.v_panel_registro_controles.Controls.Add(this.v_txtNombre, 1, 1);
            this.v_panel_registro_controles.Controls.Add(this.v_txt_cantidad, 1, 2);
            this.v_panel_registro_controles.Controls.Add(this.v_txt_precio, 1, 3);
            this.v_panel_registro_controles.Controls.Add(this.v_btn_registrar, 2, 4);
            this.v_panel_registro_controles.Controls.Add(this.v_btn_cancelar, 3, 4);
            this.v_panel_registro_controles.Location = new System.Drawing.Point(3, 79);
            this.v_panel_registro_controles.Name = "v_panel_registro_controles";
            this.v_panel_registro_controles.RowCount = 6;
            this.v_panel_registro_controles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.v_panel_registro_controles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.v_panel_registro_controles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.v_panel_registro_controles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.v_panel_registro_controles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.v_panel_registro_controles.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.v_panel_registro_controles.Size = new System.Drawing.Size(1060, 497);
            this.v_panel_registro_controles.TabIndex = 0;
            this.v_panel_registro_controles.Visible = false;
            // 
            // v_lbl_codigo
            // 
            this.v_lbl_codigo.AutoSize = true;
            this.v_lbl_codigo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_lbl_codigo.Location = new System.Drawing.Point(3, 0);
            this.v_lbl_codigo.Name = "v_lbl_codigo";
            this.v_lbl_codigo.Size = new System.Drawing.Size(74, 23);
            this.v_lbl_codigo.TabIndex = 0;
            this.v_lbl_codigo.Text = "Código :";
            // 
            // v_lbl_nombre
            // 
            this.v_lbl_nombre.AutoSize = true;
            this.v_lbl_nombre.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_lbl_nombre.Location = new System.Drawing.Point(3, 99);
            this.v_lbl_nombre.Name = "v_lbl_nombre";
            this.v_lbl_nombre.Size = new System.Drawing.Size(82, 23);
            this.v_lbl_nombre.TabIndex = 1;
            this.v_lbl_nombre.Text = "Nombre :";
            this.v_lbl_nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // v_lbl_cantidad
            // 
            this.v_lbl_cantidad.AutoSize = true;
            this.v_lbl_cantidad.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_lbl_cantidad.Location = new System.Drawing.Point(3, 198);
            this.v_lbl_cantidad.Name = "v_lbl_cantidad";
            this.v_lbl_cantidad.Size = new System.Drawing.Size(88, 23);
            this.v_lbl_cantidad.TabIndex = 2;
            this.v_lbl_cantidad.Text = "Cantidad :";
            this.v_lbl_cantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // v_lbl_precio
            // 
            this.v_lbl_precio.AutoSize = true;
            this.v_lbl_precio.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_lbl_precio.Location = new System.Drawing.Point(3, 297);
            this.v_lbl_precio.Name = "v_lbl_precio";
            this.v_lbl_precio.Size = new System.Drawing.Size(130, 23);
            this.v_lbl_precio.TabIndex = 3;
            this.v_lbl_precio.Text = "Precio unitario :";
            this.v_lbl_precio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // v_txt_codigo
            // 
            this.v_txt_codigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.v_txt_codigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.v_txt_codigo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_txt_codigo.Location = new System.Drawing.Point(221, 3);
            this.v_txt_codigo.Name = "v_txt_codigo";
            this.v_txt_codigo.Size = new System.Drawing.Size(296, 30);
            this.v_txt_codigo.TabIndex = 5;
            this.v_txt_codigo.Enter += new System.EventHandler(this.v_txt_codigo_Enter);
            this.v_txt_codigo.Leave += new System.EventHandler(this.v_txt_codigo_Leave);
            this.v_txt_codigo.MouseEnter += new System.EventHandler(this.v_txt_codigo_MouseEnter);
            // 
            // v_txtNombre
            // 
            this.v_txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.v_txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.v_txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.v_txtNombre.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_txtNombre.Location = new System.Drawing.Point(221, 102);
            this.v_txtNombre.Name = "v_txtNombre";
            this.v_txtNombre.Size = new System.Drawing.Size(296, 30);
            this.v_txtNombre.TabIndex = 6;
            // 
            // v_txt_cantidad
            // 
            this.v_txt_cantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.v_txt_cantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.v_txt_cantidad.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_txt_cantidad.Location = new System.Drawing.Point(221, 201);
            this.v_txt_cantidad.Name = "v_txt_cantidad";
            this.v_txt_cantidad.Size = new System.Drawing.Size(296, 30);
            this.v_txt_cantidad.TabIndex = 7;
            // 
            // v_txt_precio
            // 
            this.v_txt_precio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.v_txt_precio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.v_txt_precio.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_txt_precio.Location = new System.Drawing.Point(221, 300);
            this.v_txt_precio.Name = "v_txt_precio";
            this.v_txt_precio.Size = new System.Drawing.Size(296, 30);
            this.v_txt_precio.TabIndex = 8;
            // 
            // v_btn_registrar
            // 
            this.v_btn_registrar.BackColor = System.Drawing.Color.SteelBlue;
            this.v_btn_registrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.v_btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.v_btn_registrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_btn_registrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.v_btn_registrar.Location = new System.Drawing.Point(523, 399);
            this.v_btn_registrar.Name = "v_btn_registrar";
            this.v_btn_registrar.Size = new System.Drawing.Size(153, 34);
            this.v_btn_registrar.TabIndex = 11;
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
            this.v_btn_cancelar.Location = new System.Drawing.Point(706, 399);
            this.v_btn_cancelar.Name = "v_btn_cancelar";
            this.v_btn_cancelar.Size = new System.Drawing.Size(153, 34);
            this.v_btn_cancelar.TabIndex = 12;
            this.v_btn_cancelar.Text = "Cancelar";
            this.v_btn_cancelar.UseVisualStyleBackColor = false;
            this.v_btn_cancelar.Click += new System.EventHandler(this.v_btn_cancelar_Click);
            // 
            // v_lbl_titulo
            // 
            this.v_lbl_titulo.AutoSize = true;
            this.v_lbl_titulo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_lbl_titulo.Location = new System.Drawing.Point(3, 0);
            this.v_lbl_titulo.Name = "v_lbl_titulo";
            this.v_lbl_titulo.Size = new System.Drawing.Size(263, 31);
            this.v_lbl_titulo.TabIndex = 1;
            this.v_lbl_titulo.Text = "Registrar medicamento";
            this.v_lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(864, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 1);
            this.btnBuscar.TabIndex = 0;
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
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // v_pnl_menu
            // 
            this.v_pnl_menu.BackColor = System.Drawing.Color.SkyBlue;
            this.v_pnl_menu.Controls.Add(this.v_btn_menu_salir);
            this.v_pnl_menu.Controls.Add(this.v_btn_menu_registrar);
            this.v_pnl_menu.Controls.Add(this.v_btn_menu_buscar);
            this.v_pnl_menu.Controls.Add(this.v_btn_menu_eliminar);
            this.v_pnl_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.v_pnl_menu.Location = new System.Drawing.Point(0, 0);
            this.v_pnl_menu.Name = "v_pnl_menu";
            this.v_pnl_menu.Size = new System.Drawing.Size(134, 600);
            this.v_pnl_menu.TabIndex = 0;
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
            this.v_panel_buscar.Size = new System.Drawing.Size(1200, 600);
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
            this.v_panel_buscar_controles.Location = new System.Drawing.Point(3, 81);
            this.v_panel_buscar_controles.Name = "v_panel_buscar_controles";
            this.v_panel_buscar_controles.RowCount = 6;
            this.v_panel_buscar_controles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.v_panel_buscar_controles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.v_panel_buscar_controles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.v_panel_buscar_controles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.v_panel_buscar_controles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.v_panel_buscar_controles.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.v_panel_buscar_controles.Size = new System.Drawing.Size(1194, 516);
            this.v_panel_buscar_controles.TabIndex = 0;
            this.v_panel_buscar_controles.Visible = false;
            // 
            // v_txt_nombre
            // 
            this.v_txt_nombre.Location = new System.Drawing.Point(3, 3);
            this.v_txt_nombre.Name = "v_txt_nombre";
            this.v_txt_nombre.Size = new System.Drawing.Size(100, 22);
            this.v_txt_nombre.TabIndex = 0;
            // 
            // v_dg_medicamentos
            // 
            this.v_dg_medicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.v_panel_buscar_controles.SetColumnSpan(this.v_dg_medicamentos, 3);
            this.v_dg_medicamentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.v_dg_medicamentos.Location = new System.Drawing.Point(3, 106);
            this.v_dg_medicamentos.Name = "v_dg_medicamentos";
            this.v_dg_medicamentos.RowHeadersWidth = 51;
            this.v_panel_buscar_controles.SetRowSpan(this.v_dg_medicamentos, 4);
            this.v_dg_medicamentos.RowTemplate.Height = 24;
            this.v_dg_medicamentos.Size = new System.Drawing.Size(1188, 406);
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
            // medicamentoBindingSource
            // 
            this.medicamentoBindingSource.DataSource = typeof(ExamenT2.Medicamento);
            // 
            // FormMedicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.v_pnl_inicio);
            this.Controls.Add(this.v_pnl_menu);
            this.Controls.Add(this.v_panel_buscar);
            this.MaximizeBox = false;
            this.Name = "FormMedicamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de Medicamentos";
            this.v_pnl_inicio.ResumeLayout(false);
            this.v_panel_registro.ResumeLayout(false);
            this.v_panel_registro.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.v_panel_registro_controles.ResumeLayout(false);
            this.v_panel_registro_controles.PerformLayout();
            this.v_pnl_menu.ResumeLayout(false);
            this.v_panel_buscar.ResumeLayout(false);
            this.v_panel_buscar.PerformLayout();
            this.v_panel_buscar_controles.ResumeLayout(false);
            this.v_panel_buscar_controles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_dg_medicamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

       

        private void InitializePanelBusqueda()
        {
            
            

        }

        #endregion
        private System.Windows.Forms.BindingSource medicamentoBindingSource;
        private System.Windows.Forms.Button v_btn_menu_registrar;
        private System.Windows.Forms.Button v_btn_menu_buscar;
        private System.Windows.Forms.Button v_btn_menu_eliminar;
        private System.Windows.Forms.Button v_btn_menu_salir;
        private System.Windows.Forms.Panel v_pnl_inicio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel v_pnl_menu;
        private System.Windows.Forms.TableLayoutPanel v_panel_registro;
        private System.Windows.Forms.TableLayoutPanel v_panel_registro_controles;
        private System.Windows.Forms.Label v_lbl_codigo;
        private System.Windows.Forms.Label v_lbl_nombre;
        private System.Windows.Forms.Label v_lbl_cantidad;
        private System.Windows.Forms.Label v_lbl_precio;
        private System.Windows.Forms.TextBox v_txt_codigo;
        private System.Windows.Forms.TextBox v_txtNombre;
        private System.Windows.Forms.TextBox v_txt_cantidad;
        private System.Windows.Forms.TextBox v_txt_precio;
        private System.Windows.Forms.Label v_lbl_titulo;
        private System.Windows.Forms.Button v_btn_registrar;
        private System.Windows.Forms.Button v_btn_cancelar;
        private System.Windows.Forms.TextBox v_txt_nombre;
        private System.Windows.Forms.Button btnBuscar;

        private System.Windows.Forms.TableLayoutPanel v_panel_buscar;
        private System.Windows.Forms.TableLayoutPanel v_panel_buscar_controles;
        private System.Windows.Forms.Button v_btn_buscar;
        private System.Windows.Forms.TextBox v_txt_buscar;
        private System.Windows.Forms.Label v_lbl_buscar_titulo;
        private System.Windows.Forms.DataGridView v_dg_medicamentos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

