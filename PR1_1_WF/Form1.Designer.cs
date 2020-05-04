namespace PR1_1_WF
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.task1 = new System.Windows.Forms.GroupBox();
			this.task2 = new System.Windows.Forms.GroupBox();
			this.calculate = new System.Windows.Forms.Button();
			this.side_label = new System.Windows.Forms.Label();
			this.side = new System.Windows.Forms.TextBox();
			this.radius_label = new System.Windows.Forms.Label();
			this.result = new System.Windows.Forms.Label();
			this.check = new System.Windows.Forms.Button();
			this.SideA_label = new System.Windows.Forms.Label();
			this.SideB_label = new System.Windows.Forms.Label();
			this.SideC_label = new System.Windows.Forms.Label();
			this.SideA = new System.Windows.Forms.TextBox();
			this.SideB = new System.Windows.Forms.TextBox();
			this.SideC = new System.Windows.Forms.TextBox();
			this.rezult = new System.Windows.Forms.Label();
			this.task1.SuspendLayout();
			this.task2.SuspendLayout();
			this.SuspendLayout();
			// 
			// task1
			// 
			this.task1.Controls.Add(this.result);
			this.task1.Controls.Add(this.radius_label);
			this.task1.Controls.Add(this.side);
			this.task1.Controls.Add(this.side_label);
			this.task1.Controls.Add(this.calculate);
			this.task1.Location = new System.Drawing.Point(12, 12);
			this.task1.Name = "task1";
			this.task1.Size = new System.Drawing.Size(307, 188);
			this.task1.TabIndex = 0;
			this.task1.TabStop = false;
			this.task1.Text = "Задание 1";
			// 
			// task2
			// 
			this.task2.Controls.Add(this.rezult);
			this.task2.Controls.Add(this.SideC);
			this.task2.Controls.Add(this.SideB);
			this.task2.Controls.Add(this.SideA);
			this.task2.Controls.Add(this.SideC_label);
			this.task2.Controls.Add(this.SideB_label);
			this.task2.Controls.Add(this.SideA_label);
			this.task2.Controls.Add(this.check);
			this.task2.Location = new System.Drawing.Point(325, 12);
			this.task2.Name = "task2";
			this.task2.Size = new System.Drawing.Size(307, 188);
			this.task2.TabIndex = 1;
			this.task2.TabStop = false;
			this.task2.Text = "Задание 2 ";
			// 
			// calculate
			// 
			this.calculate.Location = new System.Drawing.Point(196, 151);
			this.calculate.Name = "calculate";
			this.calculate.Size = new System.Drawing.Size(105, 31);
			this.calculate.TabIndex = 0;
			this.calculate.Text = "Рассчитать";
			this.calculate.UseVisualStyleBackColor = true;
			this.calculate.Click += new System.EventHandler(this.calculate_Click);
			// 
			// side_label
			// 
			this.side_label.AutoSize = true;
			this.side_label.Location = new System.Drawing.Point(6, 33);
			this.side_label.Name = "side_label";
			this.side_label.Size = new System.Drawing.Size(64, 17);
			this.side_label.TabIndex = 1;
			this.side_label.Text = "Строна: ";
			// 
			// side
			// 
			this.side.Location = new System.Drawing.Point(78, 33);
			this.side.Name = "side";
			this.side.Size = new System.Drawing.Size(100, 22);
			this.side.TabIndex = 2;
			this.side.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.side_KeyPress);
			// 
			// radius_label
			// 
			this.radius_label.AutoSize = true;
			this.radius_label.Location = new System.Drawing.Point(6, 64);
			this.radius_label.Name = "radius_label";
			this.radius_label.Size = new System.Drawing.Size(63, 17);
			this.radius_label.TabIndex = 3;
			this.radius_label.Text = "Радиус: ";
			// 
			// result
			// 
			this.result.AutoSize = true;
			this.result.Location = new System.Drawing.Point(75, 64);
			this.result.Name = "result";
			this.result.Size = new System.Drawing.Size(0, 17);
			this.result.TabIndex = 4;
			// 
			// check
			// 
			this.check.Location = new System.Drawing.Point(190, 151);
			this.check.Name = "check";
			this.check.Size = new System.Drawing.Size(111, 31);
			this.check.TabIndex = 0;
			this.check.Text = "Проверить";
			this.check.UseVisualStyleBackColor = true;
			this.check.Click += new System.EventHandler(this.check_Click);
			// 
			// SideA_label
			// 
			this.SideA_label.AutoSize = true;
			this.SideA_label.Location = new System.Drawing.Point(6, 33);
			this.SideA_label.Name = "SideA_label";
			this.SideA_label.Size = new System.Drawing.Size(81, 17);
			this.SideA_label.TabIndex = 1;
			this.SideA_label.Text = "Сторона А:";
			// 
			// SideB_label
			// 
			this.SideB_label.AutoSize = true;
			this.SideB_label.Location = new System.Drawing.Point(6, 64);
			this.SideB_label.Name = "SideB_label";
			this.SideB_label.Size = new System.Drawing.Size(81, 17);
			this.SideB_label.TabIndex = 2;
			this.SideB_label.Text = "Сторона B:";
			// 
			// SideC_label
			// 
			this.SideC_label.AutoSize = true;
			this.SideC_label.Location = new System.Drawing.Point(6, 95);
			this.SideC_label.Name = "SideC_label";
			this.SideC_label.Size = new System.Drawing.Size(81, 17);
			this.SideC_label.TabIndex = 3;
			this.SideC_label.Text = "Сторона C:";
			// 
			// SideA
			// 
			this.SideA.Location = new System.Drawing.Point(93, 33);
			this.SideA.Name = "SideA";
			this.SideA.Size = new System.Drawing.Size(68, 22);
			this.SideA.TabIndex = 4;
			this.SideA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SideA_KeyPress);
			// 
			// SideB
			// 
			this.SideB.Location = new System.Drawing.Point(93, 61);
			this.SideB.Name = "SideB";
			this.SideB.Size = new System.Drawing.Size(68, 22);
			this.SideB.TabIndex = 5;
			this.SideB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SideB_KeyPress);
			// 
			// SideC
			// 
			this.SideC.Location = new System.Drawing.Point(93, 90);
			this.SideC.Name = "SideC";
			this.SideC.Size = new System.Drawing.Size(68, 22);
			this.SideC.TabIndex = 6;
			this.SideC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SideC_KeyPress);
			// 
			// rezult
			// 
			this.rezult.AutoSize = true;
			this.rezult.Location = new System.Drawing.Point(6, 126);
			this.rezult.Name = "rezult";
			this.rezult.Size = new System.Drawing.Size(0, 17);
			this.rezult.TabIndex = 7;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(641, 208);
			this.Controls.Add(this.task2);
			this.Controls.Add(this.task1);
			this.Name = "Form1";
			this.Text = "Практикум 1";
			this.task1.ResumeLayout(false);
			this.task1.PerformLayout();
			this.task2.ResumeLayout(false);
			this.task2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox task1;
		private System.Windows.Forms.Label result;
		private System.Windows.Forms.Label radius_label;
		private System.Windows.Forms.TextBox side;
		private System.Windows.Forms.Label side_label;
		private System.Windows.Forms.Button calculate;
		private System.Windows.Forms.GroupBox task2;
		private System.Windows.Forms.Label rezult;
		private System.Windows.Forms.TextBox SideC;
		private System.Windows.Forms.TextBox SideB;
		private System.Windows.Forms.TextBox SideA;
		private System.Windows.Forms.Label SideC_label;
		private System.Windows.Forms.Label SideB_label;
		private System.Windows.Forms.Label SideA_label;
		private System.Windows.Forms.Button check;
	}
}

