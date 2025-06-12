namespace CapaPresentacion
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombreEstudiante = new System.Windows.Forms.TextBox();
            this.btnAgregarEstudiante = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnAgregarDecima = new System.Windows.Forms.Button();
            this.btnEliminarDecima = new System.Windows.Forms.Button();
            this.btnExportarExcel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbEstudiantes = new System.Windows.Forms.ListBox();
            this.mthCalendario = new System.Windows.Forms.MonthCalendar();
            this.mtbCodigo = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.LightCyan;
            this.lblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodigo.Font = new System.Drawing.Font("PMingLiU-ExtB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(63, 65);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(117, 19);
            this.lblCodigo.TabIndex = 15;
            this.lblCodigo.Text = "Código Único:";
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(0, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(100, 23);
            this.lblNombre.TabIndex = 22;
            // 
            // txtNombreEstudiante
            // 
            this.txtNombreEstudiante.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEstudiante.Location = new System.Drawing.Point(373, 62);
            this.txtNombreEstudiante.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombreEstudiante.Name = "txtNombreEstudiante";
            this.txtNombreEstudiante.Size = new System.Drawing.Size(171, 27);
            this.txtNombreEstudiante.TabIndex = 12;
            // 
            // btnAgregarEstudiante
            // 
            this.btnAgregarEstudiante.BackColor = System.Drawing.Color.Lavender;
            this.btnAgregarEstudiante.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.btnAgregarEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarEstudiante.Font = new System.Drawing.Font("PMingLiU-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEstudiante.Location = new System.Drawing.Point(573, 50);
            this.btnAgregarEstudiante.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAgregarEstudiante.Name = "btnAgregarEstudiante";
            this.btnAgregarEstudiante.Size = new System.Drawing.Size(160, 34);
            this.btnAgregarEstudiante.TabIndex = 11;
            this.btnAgregarEstudiante.Text = "Agregar Estudiante";
            this.btnAgregarEstudiante.UseVisualStyleBackColor = false;
            this.btnAgregarEstudiante.Click += new System.EventHandler(this.btnAgregarEstudiante_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.BackColor = System.Drawing.Color.LightCyan;
            this.lblBuscar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBuscar.Font = new System.Drawing.Font("PMingLiU-ExtB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(63, 107);
            this.lblBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(221, 19);
            this.lblBuscar.TabIndex = 10;
            this.lblBuscar.Text = "Buscar por código o nombre:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(292, 107);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(273, 22);
            this.txtBuscar.TabIndex = 9;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Lavender;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("PMingLiU-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(573, 95);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(160, 34);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.BackColor = System.Drawing.Color.OldLace;
            this.lblMotivo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMotivo.Font = new System.Drawing.Font("PMingLiU-ExtB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivo.Location = new System.Drawing.Point(86, 410);
            this.lblMotivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(163, 19);
            this.lblMotivo.TabIndex = 6;
            this.lblMotivo.Text = "Motivo de la décima:";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotivo.Location = new System.Drawing.Point(263, 406);
            this.txtMotivo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(470, 27);
            this.txtMotivo.TabIndex = 5;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.OldLace;
            this.lblFecha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFecha.Font = new System.Drawing.Font("PMingLiU-ExtB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(105, 147);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(154, 19);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha de la décima:";
            // 
            // btnAgregarDecima
            // 
            this.btnAgregarDecima.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnAgregarDecima.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDecima.Font = new System.Drawing.Font("PMingLiU-ExtB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDecima.Location = new System.Drawing.Point(205, 447);
            this.btnAgregarDecima.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAgregarDecima.Name = "btnAgregarDecima";
            this.btnAgregarDecima.Size = new System.Drawing.Size(160, 35);
            this.btnAgregarDecima.TabIndex = 2;
            this.btnAgregarDecima.Text = "Agregar décima";
            this.btnAgregarDecima.UseVisualStyleBackColor = false;
            this.btnAgregarDecima.Click += new System.EventHandler(this.btnAgregarDecima_Click);
            // 
            // btnEliminarDecima
            // 
            this.btnEliminarDecima.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnEliminarDecima.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarDecima.Font = new System.Drawing.Font("PMingLiU-ExtB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDecima.Location = new System.Drawing.Point(424, 447);
            this.btnEliminarDecima.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEliminarDecima.Name = "btnEliminarDecima";
            this.btnEliminarDecima.Size = new System.Drawing.Size(160, 35);
            this.btnEliminarDecima.TabIndex = 1;
            this.btnEliminarDecima.Text = "Eliminar décima";
            this.btnEliminarDecima.UseVisualStyleBackColor = false;
            this.btnEliminarDecima.Click += new System.EventHandler(this.btnEliminarDecima_Click);
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.BackColor = System.Drawing.Color.MediumPurple;
            this.btnExportarExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarExcel.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarExcel.ForeColor = System.Drawing.Color.White;
            this.btnExportarExcel.Location = new System.Drawing.Point(778, 410);
            this.btnExportarExcel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(118, 63);
            this.btnExportarExcel.TabIndex = 0;
            this.btnExportarExcel.Text = "Exportar a Excel";
            this.btnExportarExcel.UseVisualStyleBackColor = false;
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MistyRose;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("PMingLiU-ExtB", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "GESTOR DE DECIMAS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.GIFTBUHO;
            this.pictureBox1.Location = new System.Drawing.Point(764, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // lbEstudiantes
            // 
            this.lbEstudiantes.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEstudiantes.FormattingEnabled = true;
            this.lbEstudiantes.ItemHeight = 20;
            this.lbEstudiantes.Location = new System.Drawing.Point(313, 168);
            this.lbEstudiantes.Name = "lbEstudiantes";
            this.lbEstudiantes.Size = new System.Drawing.Size(621, 204);
            this.lbEstudiantes.TabIndex = 19;
            // 
            // mthCalendario
            // 
            this.mthCalendario.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mthCalendario.Location = new System.Drawing.Point(64, 173);
            this.mthCalendario.Name = "mthCalendario";
            this.mthCalendario.TabIndex = 20;
            // 
            // mtbCodigo
            // 
            this.mtbCodigo.Location = new System.Drawing.Point(205, 66);
            this.mtbCodigo.Mask = "000000000";
            this.mtbCodigo.Name = "mtbCodigo";
            this.mtbCodigo.Size = new System.Drawing.Size(100, 22);
            this.mtbCodigo.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(952, 507);
            this.Controls.Add(this.mtbCodigo);
            this.Controls.Add(this.mthCalendario);
            this.Controls.Add(this.lbEstudiantes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExportarExcel);
            this.Controls.Add(this.btnEliminarDecima);
            this.Controls.Add(this.btnAgregarDecima);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.lblMotivo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.btnAgregarEstudiante);
            this.Controls.Add(this.txtNombreEstudiante);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de Décimas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombreEstudiante;
        private System.Windows.Forms.Button btnAgregarEstudiante;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnAgregarDecima;
        private System.Windows.Forms.Button btnEliminarDecima;
        private System.Windows.Forms.Button btnExportarExcel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lbEstudiantes;
        private System.Windows.Forms.MonthCalendar mthCalendario;
        private System.Windows.Forms.MaskedTextBox mtbCodigo;
    }
}

