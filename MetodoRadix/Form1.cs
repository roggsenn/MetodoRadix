namespace MetodoRadix
{
    public partial class Form1 : Form
    {
        int[] numeros;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidad = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("¿Cuántos números desea ingresar?", "Cantidad de Números"));
                numeros = new int[cantidad];
                for (int i = 0; i < cantidad; i++)
                {
                    numeros[i] = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el número"));
                }
                lsbNumeros.Items.Clear();
                foreach (var num in numeros)
                {
                    lsbNumeros.Items.Add(num);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un número válido.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (numeros == null || numeros.Length == 0)
            {
                MessageBox.Show("Primero ingrese los números antes de ordenar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Radix.RadixSort(numeros);
            foreach (var num in numeros)
            {
                lsbOrdenados.Items.Add(num);
            }
            MessageBox.Show("Los números se han ordenado correctamente.", "Ordenamiento completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void bntLimpiar_Click(object sender, EventArgs e)
        {
            numeros = null;
            lsbNumeros.Items.Clear();
            lsbOrdenados.Items.Clear();
        }
    }
}
