namespace Ex1_Forms {
	partial class Form1 {
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent() {
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.ATextBox = new System.Windows.Forms.TextBox();
			this.BTextBox = new System.Windows.Forms.TextBox();
			this.HTextBox = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.CalculateButton = new System.Windows.Forms.Button();
			this.ResultTextBox = new System.Windows.Forms.RichTextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(214, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Введите начальное значение интервала:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(208, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Введите конечное значение интервала:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 65);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(120, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Введите шаг функции:";
			// 
			// ATextBox
			// 
			this.ATextBox.Location = new System.Drawing.Point(232, 6);
			this.ATextBox.Name = "ATextBox";
			this.ATextBox.Size = new System.Drawing.Size(100, 20);
			this.ATextBox.TabIndex = 3;
			// 
			// BTextBox
			// 
			this.BTextBox.Location = new System.Drawing.Point(232, 33);
			this.BTextBox.Name = "BTextBox";
			this.BTextBox.Size = new System.Drawing.Size(100, 20);
			this.BTextBox.TabIndex = 4;
			// 
			// HTextBox
			// 
			this.HTextBox.Location = new System.Drawing.Point(138, 62);
			this.HTextBox.Name = "HTextBox";
			this.HTextBox.Size = new System.Drawing.Size(100, 20);
			this.HTextBox.TabIndex = 5;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Ex1_Forms.Properties.Resources._085849;
			this.pictureBox1.Location = new System.Drawing.Point(15, 88);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(276, 57);
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// CalculateButton
			// 
			this.CalculateButton.Location = new System.Drawing.Point(12, 274);
			this.CalculateButton.Name = "CalculateButton";
			this.CalculateButton.Size = new System.Drawing.Size(108, 34);
			this.CalculateButton.TabIndex = 7;
			this.CalculateButton.Text = "Вычислить";
			this.CalculateButton.UseVisualStyleBackColor = true;
			this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
			// 
			// ResultTextBox
			// 
			this.ResultTextBox.Location = new System.Drawing.Point(338, 6);
			this.ResultTextBox.Name = "ResultTextBox";
			this.ResultTextBox.ReadOnly = true;
			this.ResultTextBox.Size = new System.Drawing.Size(383, 302);
			this.ResultTextBox.TabIndex = 8;
			this.ResultTextBox.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(733, 320);
			this.Controls.Add(this.ResultTextBox);
			this.Controls.Add(this.CalculateButton);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.HTextBox);
			this.Controls.Add(this.BTextBox);
			this.Controls.Add(this.ATextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox ATextBox;
		private System.Windows.Forms.TextBox BTextBox;
		private System.Windows.Forms.TextBox HTextBox;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button CalculateButton;
		private System.Windows.Forms.RichTextBox ResultTextBox;
	}
}

