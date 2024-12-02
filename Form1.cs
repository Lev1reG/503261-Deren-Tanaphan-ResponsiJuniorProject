using Npgsql;
using System.Data;
using System.Windows.Forms;

namespace ResponsiJunpro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private NpgsqlConnection conn;
        string connString = "Host=localhost;Username=postgres;Password=G4nbattePostgres!;Database=responsi_junpro";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;
        string id_departemen;
        int id_jabatan;

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connString);
            LoadData();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvData.Rows[e.RowIndex];
                tbNama.Text = r.Cells["nama"].Value.ToString();
                rbHR.Checked = r.Cells["departemen"].Value.ToString() == "HR";
                rbENG.Checked = r.Cells["departemen"].Value.ToString() == "Engineer";
                rbDEV.Checked = r.Cells["departemen"].Value.ToString() == "Developer";
                rbPM.Checked = r.Cells["departemen"].Value.ToString() == "Product Manager";
                rbFIN.Checked = r.Cells["departemen"].Value.ToString() == "Finance";
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"SELECT * FROM st_insert(:_nama, :_id_departemen, :_id_jabatan);";
                if (rbHR.Checked)
                {
                    id_departemen = "HR";
                }
                else if (rbENG.Checked)
                {
                    id_departemen = "ENG";
                }
                else if (rbDEV.Checked)
                {
                    id_departemen = "DEV";
                }
                else if (rbPM.Checked)
                {
                    id_departemen = "PM";
                }
                else if (rbFIN.Checked)
                {
                    id_departemen = "FIN";
                }

                id_jabatan = 1;

                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_nama", tbNama.Text);
                cmd.Parameters.AddWithValue("_id_departemen", id_departemen);
                cmd.Parameters.AddWithValue("_id_jabatan", id_jabatan);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data berhasil ditambahkan", "SUCCESS!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    LoadData();
                    ClearField();
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error: " + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(r == null)
            {
                MessageBox.Show("Pilih data yang akan diubah", "WARNING!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                conn.Open();
                sql = @"SELECT * FROM st_update(:_id_karyawan, :_nama, :_id_departemen, :_id_jabatan);";
                if (rbHR.Checked)
                {
                    id_departemen = "HR";
                }
                else if (rbENG.Checked)
                {
                    id_departemen = "ENG";
                }
                else if (rbDEV.Checked)
                {
                    id_departemen = "DEV";
                }
                else if (rbPM.Checked)
                {
                    id_departemen = "PM";
                }
                else if (rbFIN.Checked)
                {
                    id_departemen = "FIN";
                }

                id_jabatan = 1;

                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id_karyawan", r.Cells["id_karyawan"].Value);
                cmd.Parameters.AddWithValue("_nama", tbNama.Text);
                cmd.Parameters.AddWithValue("_id_departemen", id_departemen);
                cmd.Parameters.AddWithValue("_id_jabatan", id_jabatan);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data berhasil diubah", "SUCCESS!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    LoadData();
                    ClearField();
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error: " + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Pilih data yang akan diubah", "WARNING!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Apakah anda yakin akan menghapus data ini?", "WARNING!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
               try
               {
                    conn.Open();
                    sql = @"SELECT * FROM st_delete(:_id_karyawan);";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_id_karyawan", r.Cells["id_karyawan"].Value);
                    if ((int)cmd.ExecuteScalar() == 1)
                    {
                        MessageBox.Show("Data berhasil dihapus", "SUCCESS!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                        LoadData();
                        ClearField();
                    }
                }
               catch(Exception ex)
               {
                    conn.Close();
                    MessageBox.Show("Error: " + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
            }
        }

        private void LoadData()
        {
            try
            {
                conn.Open();
                dgvData.DataSource = null;
                sql = "SELECT * FROM st_select();";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dgvData.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error: " + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearField()
        {
            tbNama.Text = null;
            rbHR.Checked = false;
            rbENG.Checked = false;
            rbDEV.Checked = false;
            rbPM.Checked = false;
            rbFIN.Checked = false;
            r = null;
        }
    }
}
