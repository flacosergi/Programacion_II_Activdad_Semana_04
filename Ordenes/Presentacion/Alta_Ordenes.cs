using Ordenes.Datos;
using Ordenes.Entidades;
using Ordenes.Servicios;

namespace Ordenes
{
    public partial class Alta_Ordenes : Form
    {
        GestorMaterial gestor_mat = new GestorMaterial(new MaterialDao());
        GestorOrden gestor_ord = new GestorOrden(new OrdenDao());
        Orden_Retiro nuevaOrden = new Orden_Retiro();

        public Alta_Ordenes()
        {
            InitializeComponent();

        }

        private void Alta_Ordenes_Load(object sender, EventArgs e)
        {
            CargaMateriales();
 
        }


        private void CargaMateriales()
        {
            List<Material> lista = gestor_mat.ObtenerMateriales();
            cbo_material.DataSource = lista;
            cbo_material.DisplayMember = "nombre";
            cbo_material.ValueMember = "codigo";
            cbo_material.SelectedIndex = -1;
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (cbo_material.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un material", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbo_material.Focus();
                return;
            }

            foreach (DataGridViewRow fila in dgv_ordenes.Rows)
            {
                if ((int)fila.Cells["CodMaterial"].Value == (int)cbo_material.SelectedValue)
                {
                    MessageBox.Show("Ya ha cargado este material", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            Material Mat = (Material)cbo_material.SelectedItem;
            dgv_ordenes.Rows.Add(Mat.codigo, Mat.nombre, (int)Mat.stock, (int)nud_cantidad.Value, "Eliminar");
            cbo_material.SelectedIndex = -1;
            nud_cantidad.Value = 1;

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (Validar() == false)
                return;

            
            nuevaOrden.responsable = txt_responsable.Text;
            List<Detalle_Orden> lista_detalle = new();
            foreach (DataGridViewRow fila in dgv_ordenes.Rows)
            {
                Detalle_Orden nuevodetalle = new();
                nuevodetalle.detalle_nro = fila.Index + 1;
                nuevodetalle.material.codigo = (int)fila.Cells["CodMaterial"].Value;
                nuevodetalle.cantidad = (int)fila.Cells["Cantidad"].Value;
                nuevaOrden.lista_detalle.Add(nuevodetalle);
            }

            int resultado = gestor_ord.CargarOrden(nuevaOrden);

            MessageBox.Show("Se ingresó la Orden con el número " + resultado + ".", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt_responsable.Text = string.Empty;
            dgv_ordenes.Rows.Clear();
            cbo_material.SelectedIndex = -1;
            nud_cantidad.Value = 1;
        }

        private bool Validar()
        {
            if (txt_responsable.Text == string.Empty)
            {
                MessageBox.Show("Debe cargar un responsable.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_responsable.Focus();
                return false;
            }

            if (dgv_ordenes.Rows.Count == 0)
            {
                MessageBox.Show("Debe cargar al menos un detalle para la orden.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbo_material.Focus();
                return false;
            }

            foreach (DataGridViewRow fila in dgv_ordenes.Rows)
            {
                if ((int)fila.Cells["Stock"].Value < (int)fila.Cells["Cantidad"].Value)
                {
                    MessageBox.Show("Existen materiales con stock insuficiente. Verifique.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }

            return true;

        }

        private void dgv_ordenes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_ordenes.Columns["Acciones"].Index)
            {
                dgv_ordenes.Rows.RemoveAt(e.RowIndex);

            }
        }
    }
}