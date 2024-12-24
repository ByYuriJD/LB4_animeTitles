using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB4_animeTypesApp {
	public partial class FormTypeAdd : Form {
		public FormTypeAdd() {
			InitializeComponent();
		}

		private void textBoxType_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
			if (String.IsNullOrEmpty(textBoxType.Text)) {
				errorProvider.SetError(textBoxType, "Поле не может быть пустым");
				buttonSave.Enabled = false;
			} else {
				errorProvider.Clear();
				buttonSave.Enabled = true;
			}
		}
		private void textBoxType_TextChanged(object sender, EventArgs e) {
			if (String.IsNullOrEmpty(textBoxType.Text)) {
				errorProvider.SetError(textBoxType, "Поле не может быть пустым");
				buttonSave.Enabled = false;
			} else {
				errorProvider.Clear();
				buttonSave.Enabled = true;
			}
		}
	}
}
