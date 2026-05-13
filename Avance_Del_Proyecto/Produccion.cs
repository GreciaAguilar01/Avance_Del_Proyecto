using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avance_Del_Proyecto
{
    
    public partial class Produccion : Form
    {
        string SQLConection = "server=localhost;database=Ortopedia;uid=root;pwd=root;";
        public Produccion()
        {
            InitializeComponent();
            RefrescarTablero();
        }

        private void Produccion_Resize(object sender, EventArgs e)
        {
           // this.Invalidate();
            //this.Refresh();
        }
        private void RefrescarTablero()
        {
            flowPendientes.Controls.Clear();
            flowProceso.Controls.Clear();
            flowTerminados.Controls.Clear();

            CargarColumna("Pendiente", flowPendientes);
            CargarColumna("En proceso", flowProceso);
            CargarColumna("Terminado", flowTerminados);
            ActualizarResumen();
        }
        private void CargarColumna(string estado, FlowLayoutPanel panel)
        {
            using (MySqlConnection con = new MySqlConnection(SQLConection))
            {
                con.Open();
                string query = "SELECT id_pedido, prioridad FROM pedidos WHERE estado_produccion = @est";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@est", estado);

                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int id = Convert.ToInt32(dr["id_pedido"]);
                        string prio = dr["prioridad"].ToString();

                        Button btn = new Button();
                        btn.Text = $"PEDIDO #{id}\n({prio})";
                        btn.Size = new Size(panel.Width - 20, 60);
                        btn.Margin = new Padding(10);
                        btn.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                        btn.Tag = id; // Guardamos el ID para saber cuál es al hacer clic

                        // Colores según prioridad
                        if (prio == "Urgente")
                        {
                            btn.BackColor = Color.Crimson;
                            btn.ForeColor = Color.White;
                        }
                        else
                        {
                            btn.BackColor = Color.White;
                        }

                        // Evento para moverlo al siguiente estado
                        btn.Click += (s, e) => {
                            string siguienteEstado = (estado == "Pendiente") ? "En proceso" : "Terminado";
                            if (estado != "Terminado") ActualizarEstadoPedido(id, siguienteEstado);
                        };

                        panel.Controls.Add(btn);
                    }
                }
            }
        }
        private void ActualizarEstadoPedido(int id, string nuevoEstado)
        {
            using (MySqlConnection con = new MySqlConnection(SQLConection))
            {
                con.Open();
                string sql = "UPDATE pedidos SET estado_produccion = @est WHERE id_pedido = @id";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@est", nuevoEstado);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            RefrescarTablero(); // Volvemos a dibujar todo
        }
        private void ActualizarResumen()
        {
            using (MySqlConnection con = new MySqlConnection(SQLConection))
            {
                con.Open();
                // Una sola consulta para traer todos los conteos de un golpe
                string query = @"SELECT 
                            COUNT(*) AS total,
                            SUM(CASE WHEN estado_produccion = 'Pendiente' THEN 1 ELSE 0 END) AS pendientes,
                            SUM(CASE WHEN estado_produccion = 'En proceso' THEN 1 ELSE 0 END) AS en_proceso,
                            SUM(CASE WHEN estado_produccion = 'Terminado'  THEN 1 ELSE 0 END) AS terminados,
                            SUM(CASE WHEN prioridad = 'Urgente' THEN 1 ELSE 0 END) AS urgentes
                         FROM pedidos";

                MySqlCommand cmd = new MySqlCommand(query, con);
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        // Asignamos los resultados a tus etiquetas (Labels)
                        // Asegúrate de que los nombres coincidan con los de tu diseño
                        lblTotal2.Text = dr["total"].ToString();
                        lblPendientes2.Text = dr["pendientes"].ToString();
                        lblEnProceso2.Text = dr["en_proceso"].ToString();
                        lblTerminados2.Text = dr["terminados"].ToString();
                        lblUrgentes2.Text = dr["urgentes"].ToString();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu_Interfaz VentanaManu = new Menu_Interfaz();
            VentanaManu.Show();
            this.Hide();
        }
    }
}
