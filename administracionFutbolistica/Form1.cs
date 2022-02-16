using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace administracionFutbolistica
{
    public partial class Form1 : Form
    {

        int idSelecPosJug = 0;
        int idSelecEquipoJug = 0;
        int idEditar = 0;
        SqlConnection conn = new SqlConnection("Data Source = localhost; Initial Catalog = administracionFutbol; Integrated Security = True");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn.Open();

            

            cargarEquiposDis();
            cargarEquiposDisEditar();

            cargarMejorEquipo();

            //RELLENAR DATA GRID VIEW EQUIPOS//
            cargarTablaEquipos();

            //RELLENAR DATA GRID VIEW JUGADORES//
            cargarTablaJug();
        }

        public void cargarEquiposDis()
        {
            List<string> equiposDis = new List<string>(40);
            int cont = 0;
            string query = "SELECT equipo FROM equipos";
            SqlCommand comando = new SqlCommand(query, conn);
            SqlDataReader Reader = comando.ExecuteReader();

            while (Reader.Read())
            {
                equiposDis.Add(Reader[0].ToString());
                cmbEquipoJug.Items.Add(equiposDis[cont].ToString());
                cont++;
            }
            Reader.Close();

            cmbEquipoJug.Items.Add("LIBRE");
        }

        public void cargarEquiposDisEditar ()
        {
            List<string> equiposDis = new List<string>(40);
            int cont = 0;
            string query = "SELECT equipo FROM equipos";
            SqlCommand comando = new SqlCommand(query, conn);
            SqlDataReader Reader = comando.ExecuteReader();

            while (Reader.Read())
            {
                equiposDis.Add(Reader[0].ToString());
                cmbEquipoEditar.Items.Add(Reader[0].ToString());
                cont++;
                equiposDis.Remove(cont.ToString());
            }
            Reader.Close();

            cmbEquipoEditar.Items.Add("LIBRE");
        }

        public void cargarTablaJug ()
        {
            SqlCommand comando = new SqlCommand("SELECT equipo, dorsal, posicion, puntuacion, id, nombre, id_equipo FROM jugadores;", conn);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridViewJugadores.DataSource = tabla;
        }

        public void cargarTablaEquipos()
        {
            SqlCommand comando = new SqlCommand("SELECT equipo, pais, id FROM equipos;", conn);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridViewEquipos.DataSource = tabla;
        }

        public void addEquipo (string nombreEquipo, string paisEquipo)
        {
            string query = "INSERT INTO equipos (equipo, pais) VALUES ('" + nombreEquipo + "', '" + paisEquipo + "');";
            SqlCommand comando = new SqlCommand(query, conn);
            comando.ExecuteNonQuery();
            cargarTablaEquipos();
            cargarEquiposDis();
            cargarEquiposDisEditar();
        }

        public void addJugador (string equipo, int dorsal, int idPos, int puntuacion, string nombre)
        {
            if (dorsal >= 1 && dorsal <= 99 && puntuacion >= 1 && puntuacion <= 99)
            {
                string query = "SELECT * FROM equipos WHERE equipo = '" + equipo.ToString() + "';";
                SqlCommand comando = new SqlCommand(query, conn);
                SqlDataReader Reader = comando.ExecuteReader();
                string idEquipo = "";
                string nombreEquipo = "";

                if (Reader.Read())
                {
                    idEquipo = Reader["id"].ToString();
                    string query2 = "INSERT INTO jugadores  (id_equipo, dorsal, equipo, posicion, puntuacion, nombre) VALUES ('" + idEquipo + "', '" + dorsal + "', '" + equipo + "', '" + cmbPosJug.Items[idSelecPosJug].ToString() + "', '" + puntuacion + "', '" + nombre + "');";
                    SqlCommand comando2 = new SqlCommand(query2, conn);
                    Reader.Close();
                    comando2.ExecuteNonQuery();
                    cargarTablaJug();
                } 
                else
                {
                    MessageBox.Show("Error: no hay datos para leer", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Reader.Close();
            } 
            else
            {
                MessageBox.Show("Error: el campo 'dorsal' tiene que ser mayor que 1 y menor que 99 al igual que el campo 'puntuación'", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddEquipo_Click(object sender, EventArgs e)
        {
            if (txtPais.Text != "" && txtEquipo.Text != "")
            {
                addEquipo(txtEquipo.Text.ToString(), txtPais.Text.ToString());
                txtPais.Text = "";
                txtEquipo.Text = "";
            } 
            else
            {
                MessageBox.Show("ERROR: Los campos 'País' y 'Nombre del Equipo' son OBLIGATORIOS", "ERROR: A", MessageBoxButtons.OK, MessageBoxIcon.Error);  
            }
        }

        private void btnAddJug_Click(object sender, EventArgs e)
        {
            if (txtDorsalJug.Text != "" && txtPuntJug.Text != "" && txtNombreJug.Text != "")
            {
                addJugador(cmbEquipoJug.Items[idSelecEquipoJug].ToString(), Int32.Parse(txtDorsalJug.Text), idSelecPosJug, Int32.Parse(txtPuntJug.Text), txtNombreJug.Text.ToString());
                txtDorsalJug.Text = "";
                txtPuntJug.Text = "";
            } 
            else
            {
                MessageBox.Show("ERROR: Los campos 'Equipo del Jugador' y 'Dorsal del Jugador' son OBLIGATORIOS", "ERROR: A", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewJugadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string idBorrar = "";
                DataGridViewRow fila = dataGridViewJugadores.Rows[e.RowIndex];
                string query = "SELECT id FROM jugadores WHERE dorsal = '" + fila.Cells[3].Value.ToString() + "' AND equipo = '" + fila.Cells[2].Value.ToString() + "';";
                SqlCommand comando = new SqlCommand(query, conn);
                SqlDataReader Reader = comando.ExecuteReader();
                
                if (Reader.Read())
                {
                    idBorrar = Reader["id"].ToString();
                    string query2 = "DELETE FROM jugadores WHERE id = '" + idBorrar + "';";
                    SqlCommand comando2 = new SqlCommand(query2, conn);
                    Reader.Close();
                    comando2.ExecuteNonQuery();
                    cargarTablaJug();
                    MessageBox.Show("Jugador borrado con éxito", "Ventana Emergente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("ERROR: No se encontro el 'id' del jugador deseado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Reader.Close();
            }
            if (e.ColumnIndex == 1)
            {
                //HAGO TODOS LOS FORMULARIOS VISIBLES//
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                label14.Visible = true;
                txtDorsalEditar.Visible = true;
                txtEditarPuntuacion.Visible = true;
                cmbPosEditar.Visible = true;
                cmbEquipoEditar.Visible = true;
                btnEditarJug.Visible = true;
                txtNombreJugEditar.Visible = true;

                //METO TODOS LOS DATOS DE LOS JUGADORES EN VARIABLES PARA LOS FORMULARIOS//
                int dorsalJugEditar = 0;
                string posJug = "";
                string equipoJug = "";
                int puntuacionJug = 0;
                string nombreJug = "";
                DataGridViewRow fila = dataGridViewJugadores.Rows[e.RowIndex];
                dorsalJugEditar = Int32.Parse(fila.Cells[3].Value.ToString());
                posJug = fila.Cells[4].Value.ToString();
                equipoJug = fila.Cells[2].Value.ToString();
                puntuacionJug = Int32.Parse(fila.Cells[5].Value.ToString());
                nombreJug = fila.Cells[7].Value.ToString();

                //METO LOS CAMPOS DEL JUGADOR SELECCIONADO EN LOS FORMULARIOS//
                txtDorsalEditar.Text = dorsalJugEditar.ToString();
                txtEditarPuntuacion.Text = puntuacionJug.ToString();
                cmbPosEditar.Text = posJug.ToString();
                cmbEquipoEditar.Text = equipoJug.ToString();
                txtNombreJugEditar.Text = nombreJug.ToString();

                idEditar = Int32.Parse(fila.Cells[6].Value.ToString());
            }
        }

        private void dataGridViewEquipos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string idBorrar = "";
                DataGridViewRow fila = dataGridViewEquipos.Rows[e.RowIndex];
                string query = "SELECT id FROM equipos WHERE equipo = '" + fila.Cells[1].Value.ToString() + "' AND pais = '" + fila.Cells[2].Value.ToString() + "';";
                SqlCommand comando = new SqlCommand(query, conn);
                SqlDataReader Reader = comando.ExecuteReader();

                if (Reader.Read())
                {
                    idBorrar = Reader["id"].ToString();
                    string query2 = "DELETE FROM equipos WHERE id = '" + idBorrar + "';" + 
                    "UPDATE jugadores SET equipo = 'LIBRE', id_equipo = null WHERE id_equipo = '" + idBorrar + "'";
                    SqlCommand comando2 = new SqlCommand(query2, conn);
                    Reader.Close();
                    comando2.ExecuteNonQuery();
                    cargarTablaEquipos();
                    cargarTablaJug();
                    MessageBox.Show("Equipo borrado con éxito", "Ventana Emergente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("ERROR: No se encontro el 'id' del equipo deseado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Reader.Close();

                cargarEquiposDis();
            }
        }

        private void cmbPosJug_SelectedIndexChanged(object sender, EventArgs e)
        {
            idSelecPosJug = cmbPosJug.SelectedIndex;
        }

        private void txtDorsalJug_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 47 || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("ADVERTENCIA: Solo se permiten caracteres numericos en este campo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txtPuntJug_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 47 || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("ADVERTENCIA: Solo se permiten caracteres numericos en este campo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void cmbEquipoJug_SelectedIndexChanged(object sender, EventArgs e)
        {
            idSelecEquipoJug = cmbEquipoJug.SelectedIndex;
        }

        private void btnEditarJug_Click(object sender, EventArgs e)
        {
            int idSelecEquipo = cmbEquipoEditar.SelectedIndex;
            int idSelecPosEditar = cmbPosEditar.SelectedIndex;
            string idEquipo = "";
            string query = "";
            if (txtEditarPuntuacion.Text != "" && txtDorsalEditar.Text != "")
            {
                string query2 = "SELECT id FROM equipos WHERE equipo = '" + cmbEquipoEditar.Items[idSelecEquipo].ToString() + "';";
                SqlCommand comando2 = new SqlCommand(query2, conn);
                SqlDataReader Reader2 = comando2.ExecuteReader();
                if (Reader2.Read())
                {
                    idEquipo = Reader2[0].ToString();
                }
                Reader2.Close();

                if (cmbEquipoEditar.Items[idSelecEquipo].ToString() != "LIBRE")
                {
                    query = "UPDATE jugadores SET dorsal = '" + txtDorsalEditar.Text.ToString() + "', equipo = '" + cmbEquipoEditar.Items[idSelecEquipo].ToString() + "', " +
                    "posicion = '" + cmbPosEditar.Items[idSelecPosEditar].ToString() + "', puntuacion = '" + txtEditarPuntuacion.Text.ToString() + "'," +
                    " nombre = '" + txtNombreJugEditar.Text.ToString() + "', id_equipo = '" + idEquipo.ToString() + "' WHERE id = '" + idEditar + "'";
                }
                else
                {
                    query = "UPDATE jugadores SET dorsal = '" + txtDorsalEditar.Text.ToString() + "', equipo = '" + cmbEquipoEditar.Items[idSelecEquipo].ToString() + "', " +
                    "posicion = '" + cmbPosEditar.Items[idSelecPosEditar].ToString() + "', puntuacion = '" + txtEditarPuntuacion.Text.ToString() + "'," +
                    " nombre = '" + txtNombreJugEditar.Text.ToString() + "', id_equipo = null WHERE id = '" + idEditar + "'";
                }
                SqlCommand comando = new SqlCommand(query, conn);
                comando.ExecuteNonQuery();
                //MessageBox.Show("Los cambios se produjeron satisfactoriamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarTablaJug();

                //OCULTO TODOS LOS FORMULARIOS//
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                label14.Visible = false;
                txtEditarPuntuacion.Visible = false;
                txtDorsalEditar.Visible = false;
                cmbEquipoEditar.Visible = false;
                cmbPosEditar.Visible = false;
                btnEditarJug.Visible = false;
                txtNombreJugEditar.Visible = false;
            }
            else
            {
                MessageBox.Show("ERROR: Todos los campos son obligatorios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDorsalEditar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 47 || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("ADVERTENCIA: Solo se permiten caracteres numericos en este campo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }
        
        public void cargarMejorEquipo ()
        {
            //SELECCIONAR MEJOR PORTERO//
            
            string query = "SELECT nombre FROM jugadores WHERE posicion = 'POR' ORDER BY puntuacion";
            SqlCommand comando = new SqlCommand(query, conn);
            SqlDataReader Reader = comando.ExecuteReader();
            if (Reader.Read())
            {

            }

            Reader.Close();
        }
    }
}
