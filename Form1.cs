using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nomina
{
    public partial class maestro_nomina : Form
    {
        public maestro_nomina()
        {
            InitializeComponent();
        }
        public void consultarnomina()
        {
            //declaramos la clase operacion 
            //luego nos conectamos a la db 
            //hacemos un select con un where en idnominana
            operacion oper = new operacion();
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\sistema\\tarea2.db;Version=3;");
            cnx.Open();
            string consultanomina = ("select * from detalle_nomina WHERE idnomina ='" + idnomina + "'");
            SQLiteDataAdapter co = new SQLiteDataAdapter(consultanomina, cnx);
            DataSet ds = new DataSet();
            ds.Reset();
            DataTable dt = new DataTable();
            co.Fill(ds);
            dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            cnx.Close();
            
        }
        private void btndetalle_factura_Click(object sender, EventArgs e)
        {

            vernomina();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            operacion oper = new operacion();
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\sistema\\tarea2.db;Version=3;");
            SQLiteCommand su1 = new SQLiteCommand("SELECT SUM(sueldo_emple) FROM empleados;", cnx);
            SQLiteCommand su2 = new SQLiteCommand("SELECT SUM(sueldo_emple*0.08) FROM empleados;", cnx);
            SQLiteCommand su3 = new SQLiteCommand("SELECT SUM(sueldo_emple*0.04) FROM empleados;", cnx);
            SQLiteCommand su4 = new SQLiteCommand("SELECT SUM(sueldo_emple)-SUM(sueldo*0.14) FROM empleados;", cnx);
            SQLiteCommand su5 = new SQLiteCommand("SELECT SUM(sueldo_empleo*0.02) FROM empleados;", cnx);
            SQLiteCommand su6 = new SQLiteCommand("SELECT SUM(sueldo_emple*0.14) FROM empleados;", cnx);
            cnx.Open();
            string generaciondenomina = ("SELECT idempleado, nombre, apellido, sueldo,*0.08 AS ISR, sueldo*0.04 AS ss, sueldo*0.02 AS otros_desceunto, sueldo*0.14 AS total_descuentos, sueldo-(sueldo*0.14) AS total_sueldo_Neto FROM empleados");
            SQLiteDataAdapter db = new SQLiteDataAdapter(generarnomina, cnx);
            DataSet ds = new DataSet();
            ds.Reset();
            DataTable dt = new DataTable();
            db.Fill(ds);
            dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            sueldoTotal.Text = cmd1.ExecuteScalar().ToString();
            isrTotal.Text = cmd2.ExecuteScalar().ToString();
            ssTotal.Text = cmd3.ExecuteScalar().ToString();
            netoTotal.Text = cmd4.ExecuteScalar().ToString();
            otrosDesc.Text = cmd5.ExecuteScalar().ToString();
            deduccTotal.Text = cmd6.ExecuteScalar().ToString();
            idNomina.Enabled = true;

            cnx.Close();
        }

        private void btir_Click(object sender, EventArgs e)
        {
            operacion oper = new operacion();
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\sistema\\tarea2.db;Version=3;");

            oper.ConsultaSinResultado("insert into cabeza_nomina (fecha_ini, fecha_fin, sueldo_total, isr, ss, otros, total_dedu, total_sueldo_neto) vALUES('" + fechaini.text + "','" + FechaFin.Text + "','" + SueldoTotal + "','" + irs.Text + "','" + ss.Text + "','" + otrosDecu.Text + "','" + totalDeduc.Text + "','" + sueldo_Neto.Text + "')");

            string idNomina;
            DataSet ds;
            ds = oper.ConsultaConResultado("select max(idnomina) from cabeza_nomina;");
            idNomina = ds.Tables[0].Rows[0][0].ToString();

            int filas = dataGridView1.RowCount;
            string idempleado, sueldo, isr, ss, otros, neto;

            for (int i = 0; i < (CantidaddDeFilas - 1); i++)
            {
                idempleado = dataGridView1.Rows[i].Cells[0].Value.ToString();
                sueldo = dataGridView1.Rows[i].Cells[3].Value.ToString();
                isr = dataGridView1.Rows[i].Cells[4].Value.ToString();
                ss = dataGridView1.Rows[i].Cells[5].Value.ToString();
                otros = dataGridView1.Rows[i].Cells[6].Value.ToString();
                neto = dataGridView1.Rows[i].Cells[8].Value.ToString();

                oper.ConsultaSinResultado("insert into detalle_nomina VALUES (" + NumNomina + "," + idempleado + "," + sueldo + "," + isr + "," + ss + "," + otros + "," + neto + ");");
            }

            DataTable dt = null;
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();

           
            Dedu.Clear();
            irsTotal.Clear();
            netoTotal.Clear();
            numNomina.Clear();
            otrosDesc.Clear();
            ss.Clear();
            sueldoTotal.Clear();
            fechaIni.Value = DateTime.Now;
            fechaIni.Value = DateTime.Now;
            dataGridView1 = null;
            MessageBox.Show("exitoso!");
        }
    }
}
