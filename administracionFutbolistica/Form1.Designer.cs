
namespace administracionFutbolistica
{
    partial class Form1
    {
        /// <summary>
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
            this.btnAddEquipo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEquipo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDorsalJug = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddJug = new System.Windows.Forms.Button();
            this.dataGridViewEquipos = new System.Windows.Forms.DataGridView();
            this.BorrarEquipo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewJugadores = new System.Windows.Forms.DataGridView();
            this.Borrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbPosJug = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPuntJug = new System.Windows.Forms.TextBox();
            this.cmbEquipoJug = new System.Windows.Forms.ComboBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.txtDorsalEditar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnEditarJug = new System.Windows.Forms.Button();
            this.cmbEquipoEditar = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbPosEditar = new System.Windows.Forms.ComboBox();
            this.txtEditarPuntuacion = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblED = new System.Windows.Forms.Label();
            this.lblDC = new System.Windows.Forms.Label();
            this.lblEI = new System.Windows.Forms.Label();
            this.lblMC3 = new System.Windows.Forms.Label();
            this.lblMC2 = new System.Windows.Forms.Label();
            this.lblMC1 = new System.Windows.Forms.Label();
            this.lblLD = new System.Windows.Forms.Label();
            this.lblLI = new System.Windows.Forms.Label();
            this.lblDFC2 = new System.Windows.Forms.Label();
            this.lblDFC1 = new System.Windows.Forms.Label();
            this.lblPortero = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNombreJug = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNombreJugEditar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJugadores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddEquipo
            // 
            this.btnAddEquipo.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddEquipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddEquipo.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEquipo.Location = new System.Drawing.Point(214, 29);
            this.btnAddEquipo.Name = "btnAddEquipo";
            this.btnAddEquipo.Size = new System.Drawing.Size(92, 92);
            this.btnAddEquipo.TabIndex = 1;
            this.btnAddEquipo.Text = "Añadir Equipo";
            this.btnAddEquipo.UseVisualStyleBackColor = false;
            this.btnAddEquipo.Click += new System.EventHandler(this.btnAddEquipo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "País";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre del Equipo";
            // 
            // txtEquipo
            // 
            this.txtEquipo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquipo.Location = new System.Drawing.Point(12, 92);
            this.txtEquipo.Name = "txtEquipo";
            this.txtEquipo.Size = new System.Drawing.Size(195, 29);
            this.txtEquipo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(796, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Dorsal del Jugador";
            // 
            // txtDorsalJug
            // 
            this.txtDorsalJug.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDorsalJug.Location = new System.Drawing.Point(796, 100);
            this.txtDorsalJug.MaxLength = 2;
            this.txtDorsalJug.Name = "txtDorsalJug";
            this.txtDorsalJug.Size = new System.Drawing.Size(195, 29);
            this.txtDorsalJug.TabIndex = 8;
            this.txtDorsalJug.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDorsalJug_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(796, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Equipo del Jugador";
            // 
            // btnAddJug
            // 
            this.btnAddJug.BackColor = System.Drawing.Color.Turquoise;
            this.btnAddJug.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddJug.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddJug.Location = new System.Drawing.Point(998, 12);
            this.btnAddJug.Name = "btnAddJug";
            this.btnAddJug.Size = new System.Drawing.Size(91, 305);
            this.btnAddJug.TabIndex = 6;
            this.btnAddJug.Text = "Añadir Jugador";
            this.btnAddJug.UseVisualStyleBackColor = false;
            this.btnAddJug.Click += new System.EventHandler(this.btnAddJug_Click);
            // 
            // dataGridViewEquipos
            // 
            this.dataGridViewEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEquipos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BorrarEquipo});
            this.dataGridViewEquipos.Location = new System.Drawing.Point(12, 420);
            this.dataGridViewEquipos.Name = "dataGridViewEquipos";
            this.dataGridViewEquipos.Size = new System.Drawing.Size(487, 374);
            this.dataGridViewEquipos.TabIndex = 10;
            this.dataGridViewEquipos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEquipos_CellContentClick);
            // 
            // BorrarEquipo
            // 
            this.BorrarEquipo.HeaderText = "Borrar";
            this.BorrarEquipo.Name = "BorrarEquipo";
            this.BorrarEquipo.Text = "Borrar";
            this.BorrarEquipo.ToolTipText = "Borrar";
            // 
            // dataGridViewJugadores
            // 
            this.dataGridViewJugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJugadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Borrar,
            this.Editar});
            this.dataGridViewJugadores.Location = new System.Drawing.Point(505, 420);
            this.dataGridViewJugadores.Name = "dataGridViewJugadores";
            this.dataGridViewJugadores.Size = new System.Drawing.Size(964, 374);
            this.dataGridViewJugadores.TabIndex = 11;
            this.dataGridViewJugadores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewJugadores_CellContentClick);
            // 
            // Borrar
            // 
            this.Borrar.HeaderText = "Borrar";
            this.Borrar.Name = "Borrar";
            this.Borrar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Borrar.Text = "Borrar";
            this.Borrar.ToolTipText = "Borrar";
            this.Borrar.UseColumnTextForButtonValue = true;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.Text = "Editar";
            this.Editar.ToolTipText = "Editar";
            this.Editar.UseColumnTextForButtonValue = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(114, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Equipos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(718, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Jugadores";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(796, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "Posición del Jugador:";
            // 
            // cmbPosJug
            // 
            this.cmbPosJug.FormattingEnabled = true;
            this.cmbPosJug.Items.AddRange(new object[] {
            "DC",
            "ED",
            "EI",
            "SD",
            "MC",
            "MCO",
            "MCD",
            "MD",
            "MI",
            "DEF",
            "DFI",
            "DFD",
            "LD",
            "LI",
            "CAR",
            "POR"});
            this.cmbPosJug.Location = new System.Drawing.Point(796, 172);
            this.cmbPosJug.Name = "cmbPosJug";
            this.cmbPosJug.Size = new System.Drawing.Size(195, 21);
            this.cmbPosJug.TabIndex = 16;
            this.cmbPosJug.SelectedIndexChanged += new System.EventHandler(this.cmbPosJug_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(796, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 21);
            this.label8.TabIndex = 18;
            this.label8.Text = "Puntuacion:";
            // 
            // txtPuntJug
            // 
            this.txtPuntJug.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuntJug.Location = new System.Drawing.Point(796, 228);
            this.txtPuntJug.MaxLength = 2;
            this.txtPuntJug.Name = "txtPuntJug";
            this.txtPuntJug.Size = new System.Drawing.Size(195, 29);
            this.txtPuntJug.TabIndex = 17;
            this.txtPuntJug.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPuntJug_KeyPress);
            // 
            // cmbEquipoJug
            // 
            this.cmbEquipoJug.FormattingEnabled = true;
            this.cmbEquipoJug.Location = new System.Drawing.Point(796, 37);
            this.cmbEquipoJug.Name = "cmbEquipoJug";
            this.cmbEquipoJug.Size = new System.Drawing.Size(195, 21);
            this.cmbEquipoJug.TabIndex = 19;
            this.cmbEquipoJug.SelectedIndexChanged += new System.EventHandler(this.cmbEquipoJug_SelectedIndexChanged);
            // 
            // txtPais
            // 
            this.txtPais.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPais.Location = new System.Drawing.Point(12, 30);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(195, 29);
            this.txtPais.TabIndex = 20;
            // 
            // txtDorsalEditar
            // 
            this.txtDorsalEditar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDorsalEditar.Location = new System.Drawing.Point(391, 37);
            this.txtDorsalEditar.Name = "txtDorsalEditar";
            this.txtDorsalEditar.Size = new System.Drawing.Size(195, 29);
            this.txtDorsalEditar.TabIndex = 25;
            this.txtDorsalEditar.Visible = false;
            this.txtDorsalEditar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDorsalEditar_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(391, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 21);
            this.label9.TabIndex = 24;
            this.label9.Text = "Equipo";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(391, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 21);
            this.label10.TabIndex = 22;
            this.label10.Text = "Dorsal";
            this.label10.Visible = false;
            // 
            // btnEditarJug
            // 
            this.btnEditarJug.BackColor = System.Drawing.Color.Yellow;
            this.btnEditarJug.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarJug.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarJug.Location = new System.Drawing.Point(593, 36);
            this.btnEditarJug.Name = "btnEditarJug";
            this.btnEditarJug.Size = new System.Drawing.Size(92, 281);
            this.btnEditarJug.TabIndex = 21;
            this.btnEditarJug.Text = "Editar Jugador";
            this.btnEditarJug.UseVisualStyleBackColor = false;
            this.btnEditarJug.Visible = false;
            this.btnEditarJug.Click += new System.EventHandler(this.btnEditarJug_Click);
            // 
            // cmbEquipoEditar
            // 
            this.cmbEquipoEditar.FormattingEnabled = true;
            this.cmbEquipoEditar.Location = new System.Drawing.Point(391, 107);
            this.cmbEquipoEditar.Name = "cmbEquipoEditar";
            this.cmbEquipoEditar.Size = new System.Drawing.Size(195, 21);
            this.cmbEquipoEditar.TabIndex = 26;
            this.cmbEquipoEditar.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(391, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 21);
            this.label11.TabIndex = 27;
            this.label11.Text = "Posición";
            this.label11.Visible = false;
            // 
            // cmbPosEditar
            // 
            this.cmbPosEditar.FormattingEnabled = true;
            this.cmbPosEditar.Items.AddRange(new object[] {
            "DC",
            "ED",
            "EI",
            "SD",
            "MC",
            "MCO",
            "MCD",
            "MD",
            "MI",
            "DEF",
            "DFI",
            "DFD",
            "LD",
            "LI",
            "CAR",
            "POR"});
            this.cmbPosEditar.Location = new System.Drawing.Point(391, 172);
            this.cmbPosEditar.Name = "cmbPosEditar";
            this.cmbPosEditar.Size = new System.Drawing.Size(195, 21);
            this.cmbPosEditar.TabIndex = 28;
            this.cmbPosEditar.Visible = false;
            // 
            // txtEditarPuntuacion
            // 
            this.txtEditarPuntuacion.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditarPuntuacion.Location = new System.Drawing.Point(391, 228);
            this.txtEditarPuntuacion.Name = "txtEditarPuntuacion";
            this.txtEditarPuntuacion.Size = new System.Drawing.Size(195, 29);
            this.txtEditarPuntuacion.TabIndex = 30;
            this.txtEditarPuntuacion.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(391, 203);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 21);
            this.label12.TabIndex = 29;
            this.label12.Text = "Puntuación";
            this.label12.Visible = false;
            // 
            // lblED
            // 
            this.lblED.AutoSize = true;
            this.lblED.Location = new System.Drawing.Point(1769, 69);
            this.lblED.Name = "lblED";
            this.lblED.Size = new System.Drawing.Size(22, 13);
            this.lblED.TabIndex = 52;
            this.lblED.Text = "ED";
            // 
            // lblDC
            // 
            this.lblDC.AutoSize = true;
            this.lblDC.Location = new System.Drawing.Point(1488, 40);
            this.lblDC.Name = "lblDC";
            this.lblDC.Size = new System.Drawing.Size(22, 13);
            this.lblDC.TabIndex = 51;
            this.lblDC.Text = "DC";
            // 
            // lblEI
            // 
            this.lblEI.AutoSize = true;
            this.lblEI.Location = new System.Drawing.Point(1259, 69);
            this.lblEI.Name = "lblEI";
            this.lblEI.Size = new System.Drawing.Size(17, 13);
            this.lblEI.TabIndex = 50;
            this.lblEI.Text = "EI";
            // 
            // lblMC3
            // 
            this.lblMC3.AutoSize = true;
            this.lblMC3.Location = new System.Drawing.Point(1605, 180);
            this.lblMC3.Name = "lblMC3";
            this.lblMC3.Size = new System.Drawing.Size(23, 13);
            this.lblMC3.TabIndex = 49;
            this.lblMC3.Text = "MC";
            // 
            // lblMC2
            // 
            this.lblMC2.AutoSize = true;
            this.lblMC2.Location = new System.Drawing.Point(1488, 180);
            this.lblMC2.Name = "lblMC2";
            this.lblMC2.Size = new System.Drawing.Size(23, 13);
            this.lblMC2.TabIndex = 48;
            this.lblMC2.Text = "MC";
            // 
            // lblMC1
            // 
            this.lblMC1.AutoSize = true;
            this.lblMC1.Location = new System.Drawing.Point(1359, 180);
            this.lblMC1.Name = "lblMC1";
            this.lblMC1.Size = new System.Drawing.Size(23, 13);
            this.lblMC1.TabIndex = 47;
            this.lblMC1.Text = "MC";
            // 
            // lblLD
            // 
            this.lblLD.AutoSize = true;
            this.lblLD.Location = new System.Drawing.Point(1799, 278);
            this.lblLD.Name = "lblLD";
            this.lblLD.Size = new System.Drawing.Size(21, 13);
            this.lblLD.TabIndex = 46;
            this.lblLD.Text = "LD";
            // 
            // lblLI
            // 
            this.lblLI.AutoSize = true;
            this.lblLI.Location = new System.Drawing.Point(1165, 278);
            this.lblLI.Name = "lblLI";
            this.lblLI.Size = new System.Drawing.Size(16, 13);
            this.lblLI.TabIndex = 45;
            this.lblLI.Text = "LI";
            // 
            // lblDFC2
            // 
            this.lblDFC2.AutoSize = true;
            this.lblDFC2.Location = new System.Drawing.Point(1616, 278);
            this.lblDFC2.Name = "lblDFC2";
            this.lblDFC2.Size = new System.Drawing.Size(28, 13);
            this.lblDFC2.TabIndex = 44;
            this.lblDFC2.Text = "DFC";
            // 
            // lblDFC1
            // 
            this.lblDFC1.AutoSize = true;
            this.lblDFC1.Location = new System.Drawing.Point(1354, 278);
            this.lblDFC1.Name = "lblDFC1";
            this.lblDFC1.Size = new System.Drawing.Size(28, 13);
            this.lblDFC1.TabIndex = 43;
            this.lblDFC1.Text = "DFC";
            // 
            // lblPortero
            // 
            this.lblPortero.AutoSize = true;
            this.lblPortero.Location = new System.Drawing.Point(1488, 321);
            this.lblPortero.Name = "lblPortero";
            this.lblPortero.Size = new System.Drawing.Size(30, 13);
            this.lblPortero.TabIndex = 42;
            this.lblPortero.Text = "POR";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(796, 264);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(171, 21);
            this.label13.TabIndex = 54;
            this.label13.Text = "Nombre del Jugador:";
            // 
            // txtNombreJug
            // 
            this.txtNombreJug.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreJug.Location = new System.Drawing.Point(796, 288);
            this.txtNombreJug.MaxLength = 232323;
            this.txtNombreJug.Name = "txtNombreJug";
            this.txtNombreJug.Size = new System.Drawing.Size(195, 29);
            this.txtNombreJug.TabIndex = 53;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(391, 264);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 21);
            this.label14.TabIndex = 56;
            this.label14.Text = "Nombre";
            this.label14.Visible = false;
            // 
            // txtNombreJugEditar
            // 
            this.txtNombreJugEditar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreJugEditar.Location = new System.Drawing.Point(391, 288);
            this.txtNombreJugEditar.MaxLength = 232323;
            this.txtNombreJugEditar.Name = "txtNombreJugEditar";
            this.txtNombreJugEditar.Size = new System.Drawing.Size(195, 29);
            this.txtNombreJugEditar.TabIndex = 55;
            this.txtNombreJugEditar.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1853, 806);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtNombreJugEditar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtNombreJug);
            this.Controls.Add(this.lblED);
            this.Controls.Add(this.lblDC);
            this.Controls.Add(this.lblEI);
            this.Controls.Add(this.lblMC3);
            this.Controls.Add(this.lblMC2);
            this.Controls.Add(this.lblMC1);
            this.Controls.Add(this.lblLD);
            this.Controls.Add(this.lblLI);
            this.Controls.Add(this.lblDFC2);
            this.Controls.Add(this.lblDFC1);
            this.Controls.Add(this.lblPortero);
            this.Controls.Add(this.txtEditarPuntuacion);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbPosEditar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbEquipoEditar);
            this.Controls.Add(this.txtDorsalEditar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnEditarJug);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.cmbEquipoJug);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPuntJug);
            this.Controls.Add(this.cmbPosJug);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridViewJugadores);
            this.Controls.Add(this.dataGridViewEquipos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDorsalJug);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddJug);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEquipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddEquipo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJugadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddEquipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEquipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDorsalJug;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddJug;
        private System.Windows.Forms.DataGridView dataGridViewEquipos;
        private System.Windows.Forms.DataGridView dataGridViewJugadores;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewButtonColumn BorrarEquipo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbPosJug;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPuntJug;
        private System.Windows.Forms.ComboBox cmbEquipoJug;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.DataGridViewButtonColumn Borrar;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.TextBox txtDorsalEditar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnEditarJug;
        private System.Windows.Forms.ComboBox cmbEquipoEditar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbPosEditar;
        private System.Windows.Forms.TextBox txtEditarPuntuacion;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblED;
        private System.Windows.Forms.Label lblDC;
        private System.Windows.Forms.Label lblEI;
        private System.Windows.Forms.Label lblMC3;
        private System.Windows.Forms.Label lblMC2;
        private System.Windows.Forms.Label lblMC1;
        private System.Windows.Forms.Label lblLD;
        private System.Windows.Forms.Label lblLI;
        private System.Windows.Forms.Label lblDFC2;
        private System.Windows.Forms.Label lblDFC1;
        private System.Windows.Forms.Label lblPortero;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNombreJug;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNombreJugEditar;
    }
}

