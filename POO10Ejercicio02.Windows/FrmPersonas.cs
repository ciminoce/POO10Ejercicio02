using System;
using System.Collections.Generic;
using System.Windows.Forms;
using POO10Ejercicio02.Datos;
using POO10Ejercicio02.Entidades;

namespace POO10Ejercicio02.Windows
{
    public partial class FrmPersonas : Form
    {
        public FrmPersonas()
        {
            InitializeComponent();
        }

        private void SalirToolStripButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private RepositorioDePersonas repositorio;
        private void NuevoToolStripButton_Click(object sender, EventArgs e)
        {
            FrmPersonasAE frm=new FrmPersonasAE(repositorio){Text = "Agregar una Persona"};
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.OK)
            {
                Persona persona = frm.GetPersona();
                repositorio.Agregar(persona);
                var r = ConstruirFila();
                SetearFila(r, persona);
                AgregarFila(r);
                MostrarCantidadDePersonas();
                MessageBox.Show("Registro agregado", "Mensaje", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            PersonasDataGridView.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Persona persona)
        {
            r.Cells[colPersona.Index].Value = persona.ToString();
            r.Cells[colDni.Index].Value = persona.dni;
            r.Cells[colFechaNac.Index].Value = persona.FechaNacimiento.ToShortDateString();
            r.Cells[colSexo.Index].Value = persona.Sexo;
            r.Cells[colLocalidad.Index].Value = persona.Localidad;
            r.Cells[colEdad.Index].Value = persona.Edad;
            r.Cells[colCategoria.Index].Value = repositorio.GetCategoriaSocio(persona);

            r.Tag = persona;
        }

        private DataGridViewRow ConstruirFila()
        {
            var r=new DataGridViewRow();
            r.CreateCells(PersonasDataGridView);
            return r;
        }

        private List<Persona> lista;
        private void FrmPersonas_Load(object sender, EventArgs e)
        {
            CargarLocalidadesEnCombo();
            repositorio=new RepositorioDePersonas();
            if (repositorio.GetCantidad()>0)
            {
                CargarTodosLosDatosEnGrilla();
            }

            MostrarCantidadDePersonas();
        }

        private void CargarTodosLosDatosEnGrilla()
        {
            lista = repositorio.GetLista();
            MostrarDatosEnGrilla();
        }

        private void CargarLocalidadesEnCombo()
        {
            //Cargo la colección Items con datos usando el método Add.
            FiltrarLocalidadesToolStripComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            FiltrarLocalidadesToolStripComboBox.Items.Add("Seleccione Localidad");

            FiltrarLocalidadesToolStripComboBox.Items.Add("Lobos");
            FiltrarLocalidadesToolStripComboBox.Items.Add("Cañuelas");
            FiltrarLocalidadesToolStripComboBox.Items.Add("Monte");
            FiltrarLocalidadesToolStripComboBox.Items.Add("Roque Pérez");
            FiltrarLocalidadesToolStripComboBox.Items.Add("Navarro");
            
            FiltrarLocalidadesToolStripComboBox.SelectedIndex = 0;//Posiciona el combo en el primer item

        }

        private void MostrarCantidadDePersonas()
        {
            CantidadTextBox.Text = repositorio.GetCantidad().ToString();
        }

        private void MostrarDatosEnGrilla()
        {
            PersonasDataGridView.Rows.Clear();
            foreach (var persona in lista)
            {
                var r = ConstruirFila();
                SetearFila(r,persona);
                AgregarFila(r);
            }
        }

        private void BorrarToolStripButton_Click(object sender, EventArgs e)
        {
            if (PersonasDataGridView.SelectedRows.Count==0)
            {
                return;
            }

            DataGridViewRow r = PersonasDataGridView.SelectedRows[0];
            Persona persona =(Persona) r.Tag;
            DialogResult dr = MessageBox.Show($"¿Desea borrar a {persona.ToString()}?",
                "Confirmar Baja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
            if (dr==DialogResult.No)
            {
                return;
            }
            repositorio.Borrar(persona);
            PersonasDataGridView.Rows.Remove(r);
            MessageBox.Show("Registro borrado", "Mensaje", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void EditarToolStripButton_Click(object sender, EventArgs e)
        {
            if (PersonasDataGridView.SelectedRows.Count==0)
            {
                return;
            }

            DataGridViewRow r = PersonasDataGridView.SelectedRows[0];
            Persona persona = (Persona) r.Tag;
            FrmPersonasAE frm=new FrmPersonasAE(repositorio){Text = "Editar Persona"};
            frm.SetPersona(persona);
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.OK)
            {
                repositorio.Modificar(persona);
                SetearFila(r,persona);
                MessageBox.Show("Registro Editado", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FiltrarLocalidadesToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FiltrarLocalidadesToolStripComboBox.SelectedIndex==0)
            {
                return;
            }

            lista = repositorio
                .FiltrarPorLocalidad(FiltrarLocalidadesToolStripComboBox.Text);
            MostrarDatosEnGrilla();
        }

        private void ActualizarToolStripButton_Click(object sender, EventArgs e)
        {
            CargarTodosLosDatosEnGrilla();
        }
    }
}
