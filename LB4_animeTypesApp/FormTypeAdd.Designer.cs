namespace LB4_animeTypesApp {
	partial class FormTypeAdd {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			components = new System.ComponentModel.Container();
			flowLayoutPanel1 = new FlowLayoutPanel();
			labelType = new Label();
			textBoxType = new TextBox();
			flowLayoutPanel2 = new FlowLayoutPanel();
			buttonCancel = new Button();
			buttonSave = new Button();
			errorProvider = new ErrorProvider(components);
			flowLayoutPanel1.SuspendLayout();
			flowLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
			SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.Controls.Add(labelType);
			flowLayoutPanel1.Controls.Add(textBoxType);
			flowLayoutPanel1.Dock = DockStyle.Fill;
			flowLayoutPanel1.Location = new Point(0, 0);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(285, 195);
			flowLayoutPanel1.TabIndex = 0;
			// 
			// labelType
			// 
			labelType.Dock = DockStyle.Top;
			labelType.Location = new Point(3, 0);
			labelType.Name = "labelType";
			labelType.Size = new Size(100, 23);
			labelType.TabIndex = 0;
			labelType.Text = "Тип Аниме";
			labelType.TextAlign = ContentAlignment.TopCenter;
			// 
			// textBoxType
			// 
			textBoxType.Dock = DockStyle.Top;
			textBoxType.Location = new Point(3, 26);
			textBoxType.Name = "textBoxType";
			textBoxType.Size = new Size(270, 23);
			textBoxType.TabIndex = 1;
			textBoxType.TextChanged += textBoxType_TextChanged;
			textBoxType.Validating += textBoxType_Validating;
			// 
			// flowLayoutPanel2
			// 
			flowLayoutPanel2.Controls.Add(buttonCancel);
			flowLayoutPanel2.Controls.Add(buttonSave);
			flowLayoutPanel2.Dock = DockStyle.Bottom;
			flowLayoutPanel2.Location = new Point(0, 147);
			flowLayoutPanel2.Name = "flowLayoutPanel2";
			flowLayoutPanel2.Size = new Size(285, 48);
			flowLayoutPanel2.TabIndex = 1;
			// 
			// buttonCancel
			// 
			buttonCancel.Location = new Point(3, 3);
			buttonCancel.Name = "buttonCancel";
			buttonCancel.Size = new Size(104, 33);
			buttonCancel.TabIndex = 0;
			buttonCancel.Text = "Отмена";
			buttonCancel.UseVisualStyleBackColor = true;
			// 
			// buttonSave
			// 
			buttonSave.DialogResult = DialogResult.OK;
			buttonSave.Enabled = false;
			buttonSave.Location = new Point(113, 3);
			buttonSave.Name = "buttonSave";
			buttonSave.Size = new Size(104, 33);
			buttonSave.TabIndex = 1;
			buttonSave.Text = "Сохранить";
			buttonSave.UseVisualStyleBackColor = true;
			// 
			// errorProvider
			// 
			errorProvider.ContainerControl = this;
			// 
			// FormTypeAdd
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(285, 195);
			Controls.Add(flowLayoutPanel2);
			Controls.Add(flowLayoutPanel1);
			Name = "FormTypeAdd";
			Text = "Form1";
			flowLayoutPanel1.ResumeLayout(false);
			flowLayoutPanel1.PerformLayout();
			flowLayoutPanel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private FlowLayoutPanel flowLayoutPanel1;
		private Label labelType;
		private FlowLayoutPanel flowLayoutPanel2;
		private Button buttonCancel;
		private Button buttonSave;
		private ErrorProvider errorProvider;
		protected internal TextBox textBoxType;
	}
}