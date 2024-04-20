namespace Uso_del_DatGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Agregar las columnas al DataGridView al iniciar el formulario
            // La primera cadena representa el nombre de la columna en la colecci�n de columnas
            // La segunda cadena representa el encabezado de la columna que se mostrar� al usuario
            dataGridView1.Columns.Add("Name", "Nombre");
            dataGridView1.Columns.Add("LastName", "Apellido");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Obtener el nombre y apellido ingresados en los TextBox
            string name = txtName.Text;
            string lastName = txtLastName.Text;

            // Verificar si se han ingresado datos v�lidos en los TextBox
            if (!string.IsNullOrEmpty(name.Trim()) && !string.IsNullOrEmpty(lastName.Trim()))
            {
                // Agregar una nueva fila al DataGridView con los datos ingresados
                dataGridView1.Rows.Add(name, lastName);
                // Limpiar los TextBox despu�s de agregar la fila
                txtName.Clear();
                txtLastName.Clear();
            }
            else
            {
                // Mostrar un mensaje de error si no se han ingresado datos v�lidos
                MessageBox.Show("Por favor ingrese un nombre y un apellido v�lidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Eliminar la fila seleccionada
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else
            {
                // Mostrar un mensaje de error si no se ha seleccionado ninguna fila
                MessageBox.Show("Por favor seleccione una fila para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            // Eliminar todas las filas del DataGridView
            dataGridView1.Rows.Clear();
        }

    }
}