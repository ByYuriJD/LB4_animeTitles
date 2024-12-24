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

			dataGridViewTypes.Columns["TypeOfAnime"].HeaderText = "“ип";
		}
	}
}
