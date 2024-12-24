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
			dataGridViewTypes = new DataGridView();
			((System.ComponentModel.ISupportInitialize)dataGridViewTypes).BeginInit();
			SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.Dock = DockStyle.Top;
			flowLayoutPanel1.Location = new Point(0, 0);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(800, 100);
			flowLayoutPanel1.TabIndex = 0;
			// 
			// dataGridViewTypes
			// 
			dataGridViewTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewTypes.Dock = DockStyle.Fill;
			dataGridViewTypes.Location = new Point(0, 100);
			dataGridViewTypes.Name = "dataGridViewTypes";
			dataGridViewTypes.ReadOnly = true;
			dataGridViewTypes.Size = new Size(800, 350);
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
			Text = "Form1";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)dataGridViewTypes).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private FlowLayoutPanel flowLayoutPanel1;
		private DataGridView dataGridViewTypes;
	}
}
