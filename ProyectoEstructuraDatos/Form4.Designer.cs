namespace ProyectoEstructuraDatos
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.dgventas = new System.Windows.Forms.DataGridView();
            this._producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.btninsertarantesde = new System.Windows.Forms.Button();
            this.btnInsertardespuesde = new System.Windows.Forms.Button();
            this.btninsertarFinal = new System.Windows.Forms.Button();
            this.btnInsertraInicio = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtobservacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttotalventa = new System.Windows.Forms.TextBox();
            this.datetimeventa = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.txtprecioventa = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btneliminax = new System.Windows.Forms.Button();
            this.txtreferncia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnbusquedarecursiva = new System.Windows.Forms.Button();
            this.btnbusdesordenada = new System.Windows.Forms.Button();
            this.btneliminarNodoINformacion = new System.Windows.Forms.Button();
            this.brneliminarANteriror = new System.Windows.Forms.Button();
            this.btneliminarUltimoNodo = new System.Windows.Forms.Button();
            this.btneliminarprimernodo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnsalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgventas)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgventas
            // 
            this.dgventas.AllowUserToAddRows = false;
            this.dgventas.AllowUserToDeleteRows = false;
            this.dgventas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgventas.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgventas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._producto,
            this._precio,
            this._cantidad,
            this._descripcion,
            this._fecha,
            this._subtotal});
            this.dgventas.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgventas.Location = new System.Drawing.Point(84, 481);
            this.dgventas.Margin = new System.Windows.Forms.Padding(2);
            this.dgventas.Name = "dgventas";
            this.dgventas.ReadOnly = true;
            this.dgventas.RowHeadersWidth = 51;
            this.dgventas.RowTemplate.Height = 24;
            this.dgventas.Size = new System.Drawing.Size(920, 158);
            this.dgventas.TabIndex = 54;
            // 
            // _producto
            // 
            this._producto.HeaderText = "Nombre";
            this._producto.MinimumWidth = 6;
            this._producto.Name = "_producto";
            this._producto.ReadOnly = true;
            // 
            // _precio
            // 
            this._precio.HeaderText = "Precio Venta";
            this._precio.MinimumWidth = 6;
            this._precio.Name = "_precio";
            this._precio.ReadOnly = true;
            // 
            // _cantidad
            // 
            this._cantidad.HeaderText = "Cantidad ";
            this._cantidad.MinimumWidth = 6;
            this._cantidad.Name = "_cantidad";
            this._cantidad.ReadOnly = true;
            // 
            // _descripcion
            // 
            this._descripcion.HeaderText = "Observación";
            this._descripcion.Name = "_descripcion";
            this._descripcion.ReadOnly = true;
            // 
            // _fecha
            // 
            this._fecha.HeaderText = "Fecha";
            this._fecha.MinimumWidth = 6;
            this._fecha.Name = "_fecha";
            this._fecha.ReadOnly = true;
            // 
            // _subtotal
            // 
            this._subtotal.HeaderText = "Subtotal";
            this._subtotal.Name = "_subtotal";
            this._subtotal.ReadOnly = true;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtProducto);
            this.groupBox4.Controls.Add(this.btninsertarantesde);
            this.groupBox4.Controls.Add(this.btnInsertardespuesde);
            this.groupBox4.Controls.Add(this.btninsertarFinal);
            this.groupBox4.Controls.Add(this.btnInsertraInicio);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtobservacion);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txttotalventa);
            this.groupBox4.Controls.Add(this.datetimeventa);
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txtcantidad);
            this.groupBox4.Controls.Add(this.txtprecioventa);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox4.Location = new System.Drawing.Point(94, 71);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(910, 247);
            this.groupBox4.TabIndex = 53;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Venta";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(173, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 23);
            this.comboBox1.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 63;
            this.label1.Text = "Recorrido:";
            // 
            // txtProducto
            // 
            this.txtProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProducto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(173, 55);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(166, 23);
            this.txtProducto.TabIndex = 62;
            // 
            // btninsertarantesde
            // 
            this.btninsertarantesde.BackColor = System.Drawing.Color.DarkOrange;
            this.btninsertarantesde.Location = new System.Drawing.Point(301, 199);
            this.btninsertarantesde.Name = "btninsertarantesde";
            this.btninsertarantesde.Size = new System.Drawing.Size(131, 34);
            this.btninsertarantesde.TabIndex = 61;
            this.btninsertarantesde.Text = "Insertar Antes";
            this.btninsertarantesde.UseVisualStyleBackColor = false;
            this.btninsertarantesde.Click += new System.EventHandler(this.btninsertarantesde_Click);
            // 
            // btnInsertardespuesde
            // 
            this.btnInsertardespuesde.BackColor = System.Drawing.Color.DarkOrange;
            this.btnInsertardespuesde.Location = new System.Drawing.Point(437, 199);
            this.btnInsertardespuesde.Name = "btnInsertardespuesde";
            this.btnInsertardespuesde.Size = new System.Drawing.Size(137, 35);
            this.btnInsertardespuesde.TabIndex = 60;
            this.btnInsertardespuesde.Text = "Insertar Despues";
            this.btnInsertardespuesde.UseVisualStyleBackColor = false;
            this.btnInsertardespuesde.Click += new System.EventHandler(this.btnInsertardespuesde_Click);
            // 
            // btninsertarFinal
            // 
            this.btninsertarFinal.BackColor = System.Drawing.Color.DarkOrange;
            this.btninsertarFinal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsertarFinal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btninsertarFinal.Location = new System.Drawing.Point(20, 199);
            this.btninsertarFinal.Name = "btninsertarFinal";
            this.btninsertarFinal.Size = new System.Drawing.Size(131, 34);
            this.btninsertarFinal.TabIndex = 57;
            this.btninsertarFinal.Text = "Insertar al Final";
            this.btninsertarFinal.UseVisualStyleBackColor = false;
            this.btninsertarFinal.Click += new System.EventHandler(this.btninsertarFinal_Click);
            // 
            // btnInsertraInicio
            // 
            this.btnInsertraInicio.BackColor = System.Drawing.Color.DarkOrange;
            this.btnInsertraInicio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertraInicio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInsertraInicio.Location = new System.Drawing.Point(157, 199);
            this.btnInsertraInicio.Name = "btnInsertraInicio";
            this.btnInsertraInicio.Size = new System.Drawing.Size(138, 34);
            this.btnInsertraInicio.TabIndex = 56;
            this.btnInsertraInicio.Text = "Insertar al Inicio";
            this.btnInsertraInicio.UseVisualStyleBackColor = false;
            this.btnInsertraInicio.Click += new System.EventHandler(this.btnInsertraInicio_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(443, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Observación";
            // 
            // txtobservacion
            // 
            this.txtobservacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtobservacion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtobservacion.Location = new System.Drawing.Point(369, 90);
            this.txtobservacion.Multiline = true;
            this.txtobservacion.Name = "txtobservacion";
            this.txtobservacion.Size = new System.Drawing.Size(219, 75);
            this.txtobservacion.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(681, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Total:";
            // 
            // txttotalventa
            // 
            this.txttotalventa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttotalventa.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalventa.Location = new System.Drawing.Point(726, 158);
            this.txttotalventa.Name = "txttotalventa";
            this.txttotalventa.Size = new System.Drawing.Size(76, 23);
            this.txttotalventa.TabIndex = 18;
            // 
            // datetimeventa
            // 
            this.datetimeventa.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimeventa.Location = new System.Drawing.Point(632, 14);
            this.datetimeventa.Name = "datetimeventa";
            this.datetimeventa.Size = new System.Drawing.Size(257, 23);
            this.datetimeventa.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(685, 55);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(575, 23);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 15);
            this.label15.TabIndex = 9;
            this.label15.Text = "Fecha :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(14, 133);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(155, 15);
            this.label13.TabIndex = 5;
            this.label13.Text = "Cantidad de Producto :";
            // 
            // txtcantidad
            // 
            this.txtcantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcantidad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidad.Location = new System.Drawing.Point(174, 127);
            this.txtcantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(69, 23);
            this.txtcantidad.TabIndex = 4;
            // 
            // txtprecioventa
            // 
            this.txtprecioventa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtprecioventa.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprecioventa.Location = new System.Drawing.Point(173, 91);
            this.txtprecioventa.Margin = new System.Windows.Forms.Padding(2);
            this.txtprecioventa.Name = "txtprecioventa";
            this.txtprecioventa.Size = new System.Drawing.Size(70, 23);
            this.txtprecioventa.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(20, 61);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 15);
            this.label12.TabIndex = 1;
            this.label12.Text = "Nombre del Producto:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(54, 96);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Precio de venta :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btneliminax);
            this.groupBox1.Controls.Add(this.txtreferncia);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnbusquedarecursiva);
            this.groupBox1.Controls.Add(this.btnbusdesordenada);
            this.groupBox1.Controls.Add(this.btneliminarNodoINformacion);
            this.groupBox1.Controls.Add(this.brneliminarANteriror);
            this.groupBox1.Controls.Add(this.btneliminarUltimoNodo);
            this.groupBox1.Controls.Add(this.btneliminarprimernodo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtbusqueda);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(88, 323);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(916, 153);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btneliminax
            // 
            this.btneliminax.BackColor = System.Drawing.Color.DarkOrange;
            this.btneliminax.Location = new System.Drawing.Point(183, 112);
            this.btneliminax.Name = "btneliminax";
            this.btneliminax.Size = new System.Drawing.Size(134, 29);
            this.btneliminax.TabIndex = 19;
            this.btneliminax.Text = "Eliminar X";
            this.btneliminax.UseVisualStyleBackColor = false;
            this.btneliminax.Click += new System.EventHandler(this.btneliminax_Click);
            // 
            // txtreferncia
            // 
            this.txtreferncia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtreferncia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtreferncia.Location = new System.Drawing.Point(156, 21);
            this.txtreferncia.Name = "txtreferncia";
            this.txtreferncia.Size = new System.Drawing.Size(184, 23);
            this.txtreferncia.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Nodo de Referencia:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(800, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 29);
            this.button1.TabIndex = 16;
            this.button1.Text = "Ordenar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(595, 17);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(199, 23);
            this.comboBox2.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(504, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Cargar Grid";
            // 
            // btnbusquedarecursiva
            // 
            this.btnbusquedarecursiva.BackColor = System.Drawing.Color.DarkOrange;
            this.btnbusquedarecursiva.Location = new System.Drawing.Point(688, 54);
            this.btnbusquedarecursiva.Name = "btnbusquedarecursiva";
            this.btnbusquedarecursiva.Size = new System.Drawing.Size(131, 42);
            this.btnbusquedarecursiva.TabIndex = 13;
            this.btnbusquedarecursiva.Text = "Busqueda Recursiva";
            this.btnbusquedarecursiva.UseVisualStyleBackColor = false;
            this.btnbusquedarecursiva.Click += new System.EventHandler(this.btnbusquedarecursiva_Click_1);
            // 
            // btnbusdesordenada
            // 
            this.btnbusdesordenada.BackColor = System.Drawing.Color.DarkOrange;
            this.btnbusdesordenada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbusdesordenada.Location = new System.Drawing.Point(551, 54);
            this.btnbusdesordenada.Name = "btnbusdesordenada";
            this.btnbusdesordenada.Size = new System.Drawing.Size(131, 41);
            this.btnbusdesordenada.TabIndex = 12;
            this.btnbusdesordenada.Text = "Busqueda desordenada";
            this.btnbusdesordenada.UseVisualStyleBackColor = false;
            this.btnbusdesordenada.Click += new System.EventHandler(this.btnbusdesordenada_Click);
            // 
            // btneliminarNodoINformacion
            // 
            this.btneliminarNodoINformacion.BackColor = System.Drawing.Color.DarkOrange;
            this.btneliminarNodoINformacion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminarNodoINformacion.Location = new System.Drawing.Point(645, 112);
            this.btneliminarNodoINformacion.Name = "btneliminarNodoINformacion";
            this.btneliminarNodoINformacion.Size = new System.Drawing.Size(239, 29);
            this.btneliminarNodoINformacion.TabIndex = 8;
            this.btneliminarNodoINformacion.Text = "Elminar Nodo Con Informacion";
            this.btneliminarNodoINformacion.UseVisualStyleBackColor = false;
            // 
            // brneliminarANteriror
            // 
            this.brneliminarANteriror.BackColor = System.Drawing.Color.DarkOrange;
            this.brneliminarANteriror.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brneliminarANteriror.Location = new System.Drawing.Point(493, 112);
            this.brneliminarANteriror.Name = "brneliminarANteriror";
            this.brneliminarANteriror.Size = new System.Drawing.Size(150, 29);
            this.brneliminarANteriror.TabIndex = 7;
            this.brneliminarANteriror.Text = "Elminar Anterior";
            this.brneliminarANteriror.UseVisualStyleBackColor = false;
            // 
            // btneliminarUltimoNodo
            // 
            this.btneliminarUltimoNodo.BackColor = System.Drawing.Color.DarkOrange;
            this.btneliminarUltimoNodo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminarUltimoNodo.Location = new System.Drawing.Point(321, 112);
            this.btneliminarUltimoNodo.Name = "btneliminarUltimoNodo";
            this.btneliminarUltimoNodo.Size = new System.Drawing.Size(169, 29);
            this.btneliminarUltimoNodo.TabIndex = 6;
            this.btneliminarUltimoNodo.Text = "Eliminar Ultimo Nodo";
            this.btneliminarUltimoNodo.UseVisualStyleBackColor = false;
            this.btneliminarUltimoNodo.Click += new System.EventHandler(this.btneliminarUltimoNodo_Click);
            // 
            // btneliminarprimernodo
            // 
            this.btneliminarprimernodo.BackColor = System.Drawing.Color.DarkOrange;
            this.btneliminarprimernodo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminarprimernodo.Location = new System.Drawing.Point(11, 112);
            this.btneliminarprimernodo.Name = "btneliminarprimernodo";
            this.btneliminarprimernodo.Size = new System.Drawing.Size(169, 29);
            this.btneliminarprimernodo.TabIndex = 5;
            this.btneliminarprimernodo.Text = "Eliminar Primer Nodo";
            this.btneliminarprimernodo.UseVisualStyleBackColor = false;
            this.btneliminarprimernodo.Click += new System.EventHandler(this.btneliminarprimernodo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(79, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Busqueda:";
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbusqueda.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusqueda.Location = new System.Drawing.Point(156, 51);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(184, 23);
            this.txtbusqueda.TabIndex = 0;
            this.txtbusqueda.TextChanged += new System.EventHandler(this.txtbusqueda_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.DarkOrange;
            this.btnsalir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsalir.Location = new System.Drawing.Point(924, 36);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(80, 31);
            this.btnsalir.TabIndex = 59;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1068, 702);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgventas);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgventas)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtobservacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttotalventa;
        private System.Windows.Forms.DateTimePicker datetimeventa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.TextBox txtprecioventa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btninsertarFinal;
        private System.Windows.Forms.Button btnInsertraInicio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.Button btnInsertardespuesde;
        private System.Windows.Forms.Button btninsertarantesde;
        private System.Windows.Forms.Button btneliminarNodoINformacion;
        private System.Windows.Forms.Button brneliminarANteriror;
        private System.Windows.Forms.Button btneliminarUltimoNodo;
        private System.Windows.Forms.Button btneliminarprimernodo;
        private System.Windows.Forms.TextBox txtProducto;
        public System.Windows.Forms.DataGridView dgventas;
        private System.Windows.Forms.DataGridViewTextBoxColumn _producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn _precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn _cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn _descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn _fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn _subtotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnbusquedarecursiva;
        private System.Windows.Forms.Button btnbusdesordenada;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtreferncia;
        private System.Windows.Forms.Button btneliminax;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnsalir;
    }
}