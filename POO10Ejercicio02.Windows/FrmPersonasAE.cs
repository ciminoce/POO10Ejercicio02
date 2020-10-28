using System;
using System.Windows.Forms;
using POO10Ejercicio02.Datos;
using POO10Ejercicio02.Entidades;
using POO10Ejercicio02.Entidades.Emuns;

namespace POO10Ejercicio02.Windows
{
    public partial class FrmPersonasAE : Form
    {
        public FrmPersonasAE(RepositorioDePersonas repositorio)
        {
            InitializeComponent();
            this.repositorio = repositorio;
        }

        private bool EsModificacion = false;
        private RepositorioDePersonas repositorio;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CargarDatosComboLocalidades();
            if (persona!=null)
            {
                EsModificacion = true;
                DniTextBox.Enabled = false;
                NombreTextBox.Text = persona.Nombres;
                ApellidoTextBox.Text = persona.Apellido;
                DniTextBox.Text = persona.dni;
                FechaNacimientoDateTimePicker.Value = persona.FechaNacimiento;
                if (persona.Sexo==Sexo.Femenino)
                {
                    FemeninoRadioButton.Checked = true;
                }
                else
                {
                    MasculinoRadioButton.Checked = true;
                }

                LocalidadesComboBox.Text = persona.Localidad;
            }
        }

        private void CargarDatosComboLocalidades()
        {
            //Cargo la colección Items con datos usando el método Add.
            LocalidadesComboBox.Items.Add("Lobos");
            LocalidadesComboBox.Items.Add("Cañuelas");
            LocalidadesComboBox.Items.Add("Monte");
            LocalidadesComboBox.Items.Add("Roque Pérez");
            LocalidadesComboBox.Items.Add("Navarro");

            LocalidadesComboBox.SelectedIndex = 0;//Posiciona el combo en el primer item

        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private Persona persona;
        private void OkButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (persona==null)
                {
                    persona=new Persona();
                }
                persona.Nombres = NombreTextBox.Text;
                persona.Apellido = ApellidoTextBox.Text;
                persona.dni = DniTextBox.Text;
                persona.FechaNacimiento = FechaNacimientoDateTimePicker.Value.Date;
                persona.Sexo = FemeninoRadioButton.Checked ? Sexo.Femenino : Sexo.Masculino;
                persona.Localidad = LocalidadesComboBox.Text;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(NombreTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(NombreTextBox,"El nombre es requerido");
            }
            if (string.IsNullOrEmpty(ApellidoTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(ApellidoTextBox, "El apellido es requerido");
            }

            if (FechaNacimientoDateTimePicker.Value.Date>DateTime.Now.Date)
            {
                valido = false;
                errorProvider1.SetError(FechaNacimientoDateTimePicker,"Fecha mayor a la fecha actual");
            }

            if (string.IsNullOrEmpty(DniTextBox.Text))
            {
                valido = false;
                errorProvider1.SetError(DniTextBox,"Debe ingresar un DNI");
            }else if (repositorio.ExisteDni(DniTextBox.Text) && !EsModificacion)
            {
                valido = false;
                errorProvider1.SetError(DniTextBox,"DND repetido");
            }
            return valido;
        }

        public Persona GetPersona()
        {
            return persona;
        }

        public void SetPersona(Persona persona)
        {
            this.persona = persona;
        }
    }
}
