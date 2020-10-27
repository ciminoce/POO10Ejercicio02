namespace POO10Ejercicio02.Windows
{
    partial class FrmPersonas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonas));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NuevoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.BorrarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.EditarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.OrdenarToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.OrdenarAZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrdenarZAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FiltrarToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.FiltrarSexoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FitrarSexoFemeninoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FiltrarSexoMasculinoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FiltrarLocalidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FiltrarLocalidadesToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.ActualizarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SalirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PersonasDataGridView = new System.Windows.Forms.DataGridView();
            this.colNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelInferior = new System.Windows.Forms.Panel();
            this.CantidadTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersonasDataGridView)).BeginInit();
            this.PanelInferior.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NuevoToolStripButton,
            this.BorrarToolStripButton,
            this.EditarToolStripButton,
            this.toolStripSeparator1,
            this.OrdenarToolStripDropDownButton,
            this.FiltrarToolStripDropDownButton,
            this.ActualizarToolStripButton,
            this.toolStripSeparator2,
            this.SalirToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1089, 62);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // NuevoToolStripButton
            // 
            this.NuevoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoToolStripButton.Image")));
            this.NuevoToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NuevoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NuevoToolStripButton.Name = "NuevoToolStripButton";
            this.NuevoToolStripButton.Size = new System.Drawing.Size(46, 59);
            this.NuevoToolStripButton.Text = "Nuevo";
            this.NuevoToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NuevoToolStripButton.Click += new System.EventHandler(this.NuevoToolStripButton_Click);
            // 
            // BorrarToolStripButton
            // 
            this.BorrarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("BorrarToolStripButton.Image")));
            this.BorrarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BorrarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BorrarToolStripButton.Name = "BorrarToolStripButton";
            this.BorrarToolStripButton.Size = new System.Drawing.Size(44, 59);
            this.BorrarToolStripButton.Text = "Borrar";
            this.BorrarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BorrarToolStripButton.Click += new System.EventHandler(this.BorrarToolStripButton_Click);
            // 
            // EditarToolStripButton
            // 
            this.EditarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("EditarToolStripButton.Image")));
            this.EditarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditarToolStripButton.Name = "EditarToolStripButton";
            this.EditarToolStripButton.Size = new System.Drawing.Size(44, 59);
            this.EditarToolStripButton.Text = "Editar";
            this.EditarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 62);
            // 
            // OrdenarToolStripDropDownButton
            // 
            this.OrdenarToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OrdenarAZToolStripMenuItem,
            this.OrdenarZAToolStripMenuItem});
            this.OrdenarToolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("OrdenarToolStripDropDownButton.Image")));
            this.OrdenarToolStripDropDownButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.OrdenarToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OrdenarToolStripDropDownButton.Name = "OrdenarToolStripDropDownButton";
            this.OrdenarToolStripDropDownButton.Size = new System.Drawing.Size(63, 59);
            this.OrdenarToolStripDropDownButton.Text = "Ordenar";
            this.OrdenarToolStripDropDownButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // OrdenarAZToolStripMenuItem
            // 
            this.OrdenarAZToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("OrdenarAZToolStripMenuItem.Image")));
            this.OrdenarAZToolStripMenuItem.Name = "OrdenarAZToolStripMenuItem";
            this.OrdenarAZToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.OrdenarAZToolStripMenuItem.Text = "A-Z";
            // 
            // OrdenarZAToolStripMenuItem
            // 
            this.OrdenarZAToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("OrdenarZAToolStripMenuItem.Image")));
            this.OrdenarZAToolStripMenuItem.Name = "OrdenarZAToolStripMenuItem";
            this.OrdenarZAToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.OrdenarZAToolStripMenuItem.Text = "Z-A";
            // 
            // FiltrarToolStripDropDownButton
            // 
            this.FiltrarToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FiltrarSexoToolStripMenuItem,
            this.FiltrarLocalidadToolStripMenuItem});
            this.FiltrarToolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("FiltrarToolStripDropDownButton.Image")));
            this.FiltrarToolStripDropDownButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.FiltrarToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FiltrarToolStripDropDownButton.Name = "FiltrarToolStripDropDownButton";
            this.FiltrarToolStripDropDownButton.Size = new System.Drawing.Size(53, 59);
            this.FiltrarToolStripDropDownButton.Text = "Filtrar";
            this.FiltrarToolStripDropDownButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // FiltrarSexoToolStripMenuItem
            // 
            this.FiltrarSexoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FitrarSexoFemeninoToolStripMenuItem,
            this.FiltrarSexoMasculinoToolStripMenuItem});
            this.FiltrarSexoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("FiltrarSexoToolStripMenuItem.Image")));
            this.FiltrarSexoToolStripMenuItem.Name = "FiltrarSexoToolStripMenuItem";
            this.FiltrarSexoToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.FiltrarSexoToolStripMenuItem.Text = "Sexo";
            // 
            // FitrarSexoFemeninoToolStripMenuItem
            // 
            this.FitrarSexoFemeninoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("FitrarSexoFemeninoToolStripMenuItem.Image")));
            this.FitrarSexoFemeninoToolStripMenuItem.Name = "FitrarSexoFemeninoToolStripMenuItem";
            this.FitrarSexoFemeninoToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.FitrarSexoFemeninoToolStripMenuItem.Text = "Femenino";
            // 
            // FiltrarSexoMasculinoToolStripMenuItem
            // 
            this.FiltrarSexoMasculinoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("FiltrarSexoMasculinoToolStripMenuItem.Image")));
            this.FiltrarSexoMasculinoToolStripMenuItem.Name = "FiltrarSexoMasculinoToolStripMenuItem";
            this.FiltrarSexoMasculinoToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.FiltrarSexoMasculinoToolStripMenuItem.Text = "Masculino";
            // 
            // FiltrarLocalidadToolStripMenuItem
            // 
            this.FiltrarLocalidadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FiltrarLocalidadesToolStripComboBox});
            this.FiltrarLocalidadToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("FiltrarLocalidadToolStripMenuItem.Image")));
            this.FiltrarLocalidadToolStripMenuItem.Name = "FiltrarLocalidadToolStripMenuItem";
            this.FiltrarLocalidadToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.FiltrarLocalidadToolStripMenuItem.Text = "Localidad";
            // 
            // FiltrarLocalidadesToolStripComboBox
            // 
            this.FiltrarLocalidadesToolStripComboBox.Name = "FiltrarLocalidadesToolStripComboBox";
            this.FiltrarLocalidadesToolStripComboBox.Size = new System.Drawing.Size(121, 23);
            // 
            // ActualizarToolStripButton
            // 
            this.ActualizarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ActualizarToolStripButton.Image")));
            this.ActualizarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ActualizarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ActualizarToolStripButton.Name = "ActualizarToolStripButton";
            this.ActualizarToolStripButton.Size = new System.Drawing.Size(63, 59);
            this.ActualizarToolStripButton.Text = "Actualizar";
            this.ActualizarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 62);
            // 
            // SalirToolStripButton
            // 
            this.SalirToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SalirToolStripButton.Image")));
            this.SalirToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SalirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SalirToolStripButton.Name = "SalirToolStripButton";
            this.SalirToolStripButton.Size = new System.Drawing.Size(44, 59);
            this.SalirToolStripButton.Text = "Salir";
            this.SalirToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SalirToolStripButton.Click += new System.EventHandler(this.SalirToolStripButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PersonasDataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1089, 586);
            this.panel1.TabIndex = 1;
            // 
            // PersonasDataGridView
            // 
            this.PersonasDataGridView.AllowUserToAddRows = false;
            this.PersonasDataGridView.AllowUserToDeleteRows = false;
            this.PersonasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombres,
            this.colApellido,
            this.colDni,
            this.colFechaNac,
            this.colSexo,
            this.colLocalidad});
            this.PersonasDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PersonasDataGridView.Location = new System.Drawing.Point(0, 0);
            this.PersonasDataGridView.MultiSelect = false;
            this.PersonasDataGridView.Name = "PersonasDataGridView";
            this.PersonasDataGridView.ReadOnly = true;
            this.PersonasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PersonasDataGridView.Size = new System.Drawing.Size(1089, 586);
            this.PersonasDataGridView.TabIndex = 0;
            this.PersonasDataGridView.Text = "dataGridView1";
            // 
            // colNombres
            // 
            this.colNombres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNombres.HeaderText = "Nombres";
            this.colNombres.Name = "colNombres";
            this.colNombres.ReadOnly = true;
            this.colNombres.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colApellido
            // 
            this.colApellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colApellido.HeaderText = "Apellido";
            this.colApellido.Name = "colApellido";
            this.colApellido.ReadOnly = true;
            this.colApellido.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colDni
            // 
            this.colDni.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colDni.HeaderText = "DNI";
            this.colDni.Name = "colDni";
            this.colDni.ReadOnly = true;
            this.colDni.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDni.Width = 52;
            // 
            // colFechaNac
            // 
            this.colFechaNac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colFechaNac.HeaderText = "Fec. Nto.";
            this.colFechaNac.Name = "colFechaNac";
            this.colFechaNac.ReadOnly = true;
            this.colFechaNac.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colFechaNac.Width = 79;
            // 
            // colSexo
            // 
            this.colSexo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSexo.HeaderText = "Sexo";
            this.colSexo.Name = "colSexo";
            this.colSexo.ReadOnly = true;
            this.colSexo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSexo.Width = 57;
            // 
            // colLocalidad
            // 
            this.colLocalidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLocalidad.HeaderText = "Localidad";
            this.colLocalidad.Name = "colLocalidad";
            this.colLocalidad.ReadOnly = true;
            this.colLocalidad.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // PanelInferior
            // 
            this.PanelInferior.Controls.Add(this.CantidadTextBox);
            this.PanelInferior.Controls.Add(this.label1);
            this.PanelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelInferior.Location = new System.Drawing.Point(0, 548);
            this.PanelInferior.Name = "PanelInferior";
            this.PanelInferior.Size = new System.Drawing.Size(1089, 100);
            this.PanelInferior.TabIndex = 2;
            // 
            // CantidadTextBox
            // 
            this.CantidadTextBox.Enabled = false;
            this.CantidadTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CantidadTextBox.Location = new System.Drawing.Point(173, 36);
            this.CantidadTextBox.Name = "CantidadTextBox";
            this.CantidadTextBox.Size = new System.Drawing.Size(88, 23);
            this.CantidadTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de Registros:";
            // 
            // FrmPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 648);
            this.ControlBox = false;
            this.Controls.Add(this.PanelInferior);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmPersonas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Personas";
            this.Load += new System.EventHandler(this.FrmPersonas_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PersonasDataGridView)).EndInit();
            this.PanelInferior.ResumeLayout(false);
            this.PanelInferior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton NuevoToolStripButton;
        private System.Windows.Forms.ToolStripButton BorrarToolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton SalirToolStripButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView PersonasDataGridView;
        private System.Windows.Forms.Panel PanelInferior;
        private System.Windows.Forms.ToolStripButton EditarToolStripButton;
        private System.Windows.Forms.ToolStripDropDownButton OrdenarToolStripDropDownButton;
        private System.Windows.Forms.ToolStripDropDownButton FiltrarToolStripDropDownButton;
        private System.Windows.Forms.ToolStripButton ActualizarToolStripButton;
        private System.Windows.Forms.TextBox CantidadTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem OrdenarAZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OrdenarZAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FiltrarSexoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FiltrarLocalidadToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocalidad;
        private System.Windows.Forms.ToolStripMenuItem FitrarSexoFemeninoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FiltrarSexoMasculinoToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox FiltrarLocalidadesToolStripComboBox;
    }
}

