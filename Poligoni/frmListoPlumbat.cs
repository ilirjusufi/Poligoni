using Microsoft.VisualBasic.ApplicationServices;
using Poligoni.BO;
using Poligoni.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using Microsoft.Win32;
using System.Configuration;

namespace Poligoni
{
	public partial class frmListoPlumbat : Form
	{
		private List<RegjistroPlumbatBO> ListoArmet;
		public frmListoPlumbat()
		{
			InitializeComponent();
			ListoArmet = new List<RegjistroPlumbatBO>();
			LoadData();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}
		private void LoadData()
		{
			ListoArmet.Clear();

			ListoArmet = RegjistroPlumbatDAL.ListPlumbat();

			this.bindingSource1.Clear();

			ListoArmet.ForEach(delegate (RegjistroPlumbatBO d)
			{
				this.bindingSource1.Add(d);

			});
		}
		private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}


		private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == ListoPlumbatGrid.Columns["Edito"].Index && e.RowIndex >= 0)
			{



				frmRegjistrimiPlumbave frmRegjistrimiPlumbave = new frmRegjistrimiPlumbave();
				if (this.ListoPlumbatGrid[3, ListoPlumbatGrid.CurrentCell.RowIndex].Value.ToString() != null)
				{

					var d = new RegjistroPlumbatBO();
					int PlumbiID = Convert.ToInt32(this.ListoPlumbatGrid[0, ListoPlumbatGrid.CurrentCell.RowIndex].Value);
					int Kalibri = Convert.ToInt32(this.ListoPlumbatGrid[1, ListoPlumbatGrid.CurrentCell.RowIndex].Value);
					int Sasia = Convert.ToInt32(this.ListoPlumbatGrid[1, ListoPlumbatGrid.CurrentCell.RowIndex].Value);
					frmRegjistrimiPlumbave.NdryshoPlumbat(PlumbiID, Kalibri, Sasia);
				}
			}



			else
		   if (e.ColumnIndex == ListoPlumbatGrid.Columns["Fshij"].Index && e.RowIndex >= 0)
			{
				if (this.ListoPlumbatGrid[1, ListoPlumbatGrid.CurrentCell.RowIndex].Value.ToString() != null)
				{
					var d = new RegjistroPlumbatBO();

					d.PlumbiID = Convert.ToInt32(this.ListoPlumbatGrid[0, ListoPlumbatGrid.CurrentCell.RowIndex].Value);

					int qo = d.PlumbiID;

					RegjistroPlumbatDAL.fshij(qo);

					LoadData();

				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (this.ListoPlumbatGrid[0, ListoPlumbatGrid.CurrentCell.RowIndex].Value.ToString() != null)
			{
				var d = new RegjistroPlumbatBO();

				d.PlumbiID = Convert.ToInt32(this.ListoPlumbatGrid[0, ListoPlumbatGrid.CurrentCell.RowIndex].Value);

				int qo = d.PlumbiID;

				RegjistroPlumbatDAL.fshij(qo);

				LoadData();

			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			frmRegjistrimiPlumbave frmRegjistrimiPlumbave = new frmRegjistrimiPlumbave();
			if (frmRegjistrimiPlumbave.ShowDialog() == DialogResult.Abort)
			{
				if (this.ListoPlumbatGrid[0, ListoPlumbatGrid.CurrentCell.RowIndex].Value.ToString() != null)
				{

					var d = new RegjistroPlumbatBO();
					int PlumbiID = Convert.ToInt32(this.ListoPlumbatGrid[0, ListoPlumbatGrid.CurrentCell.RowIndex].Value);
					int Kalibri = Convert.ToInt32(this.ListoPlumbatGrid[1, ListoPlumbatGrid.CurrentCell.RowIndex].Value);
					int Sasia = Convert.ToInt32(this.ListoPlumbatGrid[2, ListoPlumbatGrid.CurrentCell.RowIndex].Value);
					frmRegjistrimiPlumbave.NdryshoPlumbat(PlumbiID, Kalibri, Sasia);
				}
			}
			
		}

		private void btnkerko_Click(object sender, EventArgs e)
		{
			string search;
			search = txtKerko.Text;
			ListoArmet = RegjistroPlumbatDAL.kerkoPlumbat(search, "p");

			this.bindingSource1.Clear();

			ListoArmet.ForEach(delegate (RegjistroPlumbatBO d)
			{
				this.bindingSource1.Add(d);

			});
		}
	}
}
