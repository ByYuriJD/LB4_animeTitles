using System.ComponentModel;
using LB4_animeTypesApp.Models;
using Microsoft.EntityFrameworkCore;

namespace LB4_animeTypesApp {
	public partial class FormTypes : Form {
		private AnimeTitlesContext db;
		public FormTypes() {
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e) {
			db = new AnimeTitlesContext();
			db.AnimeTypes.Load();

			dataGridViewTypes.DataSource = db.AnimeTypes.Local.OrderBy(e => e.TypeOfAnime).ToList();
			dataGridViewTypes.Columns["Id"].Visible = false;
			dataGridViewTypes.Columns["AnimeTitles"].Visible = false;

			dataGridViewTypes.Columns["TypeOfAnime"].HeaderText = "Тип";
		}

		protected override void OnClosing(CancelEventArgs e) {
			base.OnClosing(e);

			db!.Dispose();
			db = null;
		}
		protected void buttonAdd_Click(object sender, EventArgs e) {
			FormTypeAdd formTypeAdd = new FormTypeAdd();

			DialogResult result = formTypeAdd.ShowDialog(this);
			if (result == DialogResult.Cancel) {
				return;
			}
			if (formTypeAdd.textBoxType.Text == String.Empty) 
				MessageBox.Show("Поле не может быть пустым");

			AnimeType animeType = new AnimeType {
				TypeOfAnime = formTypeAdd.textBoxType.Text
			};


			db.AnimeTypes.Add(animeType);
			db.SaveChanges();

			MessageBox.Show("Новый объект добавлен");

			dataGridViewTypes.DataSource = db.AnimeTypes.Local
				.OrderBy(o => o.TypeOfAnime).ToList();

		}
		protected void buttonEdit_Click(object sender, EventArgs e) {
			if (dataGridViewTypes.SelectedRows.Count == 0)
				return;
			int index = dataGridViewTypes.SelectedRows[0].Index;
			int id = 0;
			bool converted = Int32.TryParse(dataGridViewTypes[0, index].Value.ToString(), out id);
			if (!converted) {
				return;
			}

			AnimeType animeType = db.AnimeTypes.Find(id);

			FormTypeAdd formTypeAdd = new FormTypeAdd();
			formTypeAdd.textBoxType.Text = animeType.TypeOfAnime;
			DialogResult result = formTypeAdd.ShowDialog(this);
			if (result == DialogResult.Cancel) {
				return;
			}
			if (formTypeAdd.textBoxType.Text == String.Empty)
				MessageBox.Show("Поле не может быть пустым");

			animeType.TypeOfAnime = formTypeAdd.textBoxType.Text;
			db.SaveChanges();

			MessageBox.Show("Объект обновлен");
			dataGridViewTypes.DataSource = db.AnimeTypes.Local
				.OrderBy(o => o.TypeOfAnime).ToList();

		}
		protected void buttonDelete_Click(object sender, EventArgs e) {
			if (dataGridViewTypes.SelectedRows.Count == 0)
				return;

			DialogResult result = MessageBox.Show(
				"Вы уверены, что хотите удалить объект?",
				"",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);

			if (result == DialogResult.No)
				return;

			int index = dataGridViewTypes.SelectedRows[0].Index;
			int id = 0;
			bool converted = Int32.TryParse(dataGridViewTypes[0, index].Value.ToString(), out id);
			if (!converted) {
				return;
			}

			AnimeType animeType = db.AnimeTypes.Find(id);

			db.AnimeTypes.Remove(animeType);

			db.SaveChanges();

			MessageBox.Show("Объект удалён");
			dataGridViewTypes.DataSource = db.AnimeTypes.Local
				.OrderBy(o => o.TypeOfAnime).ToList();

		}

	}
}
