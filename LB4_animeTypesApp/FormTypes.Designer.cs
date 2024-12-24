namespace LB4_animeTypesApp {
	partial class FormTypes {
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			flowLayoutPanel1 = new FlowLayoutPanel();
			buttonAdd = new Button();
			buttonEdit = new Button();
			buttonDelete = new Button();
			dataGridViewTypes = new DataGridView();
			flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridViewTypes).BeginInit();
			SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.Controls.Add(buttonAdd);
			flowLayoutPanel1.Controls.Add(buttonEdit);
			flowLayoutPanel1.Controls.Add(buttonDelete);
			flowLayoutPanel1.Dock = DockStyle.Top;
			flowLayoutPanel1.Location = new Point(10, 10);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(780, 71);
			flowLayoutPanel1.TabIndex = 0;
			// 
			// buttonAdd
			// 
			buttonAdd.Location = new Point(3, 3);
			buttonAdd.Name = "buttonAdd";
			buttonAdd.Size = new Size(120, 30);
			buttonAdd.TabIndex = 0;
			buttonAdd.Text = "Добавить";
			buttonAdd.UseVisualStyleBackColor = true;
			buttonAdd.Click += buttonAdd_Click;
			// 
			// buttonEdit
			// 
			buttonEdit.Location = new Point(129, 3);
			buttonEdit.Name = "buttonEdit";
			buttonEdit.Size = new Size(120, 30);
			buttonEdit.TabIndex = 1;
			buttonEdit.Text = "Редактировать";
			buttonEdit.UseVisualStyleBackColor = true;
			buttonEdit.Click += buttonEdit_Click;
			// 
			// buttonDelete
			// 
			buttonDelete.Location = new Point(255, 3);
			buttonDelete.Name = "buttonDelete";
			buttonDelete.Size = new Size(120, 30);
			buttonDelete.TabIndex = 2;
			buttonDelete.Text = "Удалить";
			buttonDelete.UseVisualStyleBackColor = true;
			buttonDelete.Click += this.buttonDelete_Click;
			// 
			// dataGridViewTypes
			// 
			dataGridViewTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewTypes.Dock = DockStyle.Fill;
			dataGridViewTypes.Location = new Point(10, 81);
			dataGridViewTypes.Name = "dataGridViewTypes";
			dataGridViewTypes.ReadOnly = true;
			dataGridViewTypes.Size = new Size(780, 359);
			dataGridViewTypes.TabIndex = 1;
			// 
			// FormTypes
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(dataGridViewTypes);
			Controls.Add(flowLayoutPanel1);
			Name = "FormTypes";
			Padding = new Padding(10);
			Text = "Form1";
			Load += Form1_Load;
			flowLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridViewTypes).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private FlowLayoutPanel flowLayoutPanel1;
		private DataGridView dataGridViewTypes;
		private Button buttonAdd;
		private Button buttonEdit;
		private Button buttonDelete;
	}
}
