﻿namespace MathQuiz
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.timeLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.plusLeftLabel = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.plusRightLabel = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.sum = new System.Windows.Forms.NumericUpDown();
			this.minusLeftLabel = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.minusRightLabel = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.difference = new System.Windows.Forms.NumericUpDown();
			this.timesLeftLabel = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.timesRightLabel = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.product = new System.Windows.Forms.NumericUpDown();
			this.dividedLeftLabel = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.dividedRightLabel = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.quotient = new System.Windows.Forms.NumericUpDown();
			this.startButton = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.sum)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.difference)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.product)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.quotient)).BeginInit();
			this.SuspendLayout();
			// 
			// timeLabel
			// 
			this.timeLabel.BackColor = System.Drawing.SystemColors.Control;
			this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.timeLabel.Location = new System.Drawing.Point(270, 12);
			this.timeLabel.Name = "timeLabel";
			this.timeLabel.Size = new System.Drawing.Size(200, 30);
			this.timeLabel.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(91, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(127, 31);
			this.label1.TabIndex = 1;
			this.label1.Text = "Time Left";
			// 
			// plusLeftLabel
			// 
			this.plusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.plusLeftLabel.Location = new System.Drawing.Point(12, 70);
			this.plusLeftLabel.Name = "plusLeftLabel";
			this.plusLeftLabel.Size = new System.Drawing.Size(60, 50);
			this.plusLeftLabel.TabIndex = 2;
			this.plusLeftLabel.Text = "?";
			this.plusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(106, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 50);
			this.label2.TabIndex = 3;
			this.label2.Text = "+";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// plusRightLabel
			// 
			this.plusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.plusRightLabel.Location = new System.Drawing.Point(192, 70);
			this.plusRightLabel.Name = "plusRightLabel";
			this.plusRightLabel.Size = new System.Drawing.Size(60, 50);
			this.plusRightLabel.TabIndex = 4;
			this.plusRightLabel.Text = "?";
			this.plusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(273, 70);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 50);
			this.label3.TabIndex = 5;
			this.label3.Text = "=";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// sum
			// 
			this.sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.sum.Location = new System.Drawing.Point(355, 75);
			this.sum.Name = "sum";
			this.sum.Size = new System.Drawing.Size(100, 41);
			this.sum.TabIndex = 1;
			this.sum.Enter += new System.EventHandler(this.answer_Enter);
			// 
			// minusLeftLabel
			// 
			this.minusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.minusLeftLabel.Location = new System.Drawing.Point(12, 134);
			this.minusLeftLabel.Name = "minusLeftLabel";
			this.minusLeftLabel.Size = new System.Drawing.Size(60, 50);
			this.minusLeftLabel.TabIndex = 7;
			this.minusLeftLabel.Text = "?";
			this.minusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(106, 134);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(60, 50);
			this.label5.TabIndex = 8;
			this.label5.Text = "-";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// minusRightLabel
			// 
			this.minusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.minusRightLabel.Location = new System.Drawing.Point(192, 134);
			this.minusRightLabel.Name = "minusRightLabel";
			this.minusRightLabel.Size = new System.Drawing.Size(60, 50);
			this.minusRightLabel.TabIndex = 9;
			this.minusRightLabel.Text = "?";
			this.minusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(273, 134);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(60, 50);
			this.label7.TabIndex = 10;
			this.label7.Text = "=";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// difference
			// 
			this.difference.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.difference.Location = new System.Drawing.Point(355, 143);
			this.difference.Name = "difference";
			this.difference.Size = new System.Drawing.Size(100, 41);
			this.difference.TabIndex = 2;
			this.difference.Enter += new System.EventHandler(this.answer_Enter);
			// 
			// timesLeftLabel
			// 
			this.timesLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.timesLeftLabel.Location = new System.Drawing.Point(12, 197);
			this.timesLeftLabel.Name = "timesLeftLabel";
			this.timesLeftLabel.Size = new System.Drawing.Size(60, 50);
			this.timesLeftLabel.TabIndex = 12;
			this.timesLeftLabel.Text = "?";
			this.timesLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(106, 197);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(60, 50);
			this.label6.TabIndex = 13;
			this.label6.Text = "×";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// timesRightLabel
			// 
			this.timesRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.timesRightLabel.Location = new System.Drawing.Point(192, 197);
			this.timesRightLabel.Name = "timesRightLabel";
			this.timesRightLabel.Size = new System.Drawing.Size(60, 50);
			this.timesRightLabel.TabIndex = 14;
			this.timesRightLabel.Text = "?";
			this.timesRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label9.Location = new System.Drawing.Point(273, 197);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(60, 50);
			this.label9.TabIndex = 15;
			this.label9.Text = "=";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// product
			// 
			this.product.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.product.Location = new System.Drawing.Point(355, 206);
			this.product.Name = "product";
			this.product.Size = new System.Drawing.Size(100, 41);
			this.product.TabIndex = 3;
			this.product.Enter += new System.EventHandler(this.answer_Enter);
			// 
			// dividedLeftLabel
			// 
			this.dividedLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dividedLeftLabel.Location = new System.Drawing.Point(12, 264);
			this.dividedLeftLabel.Name = "dividedLeftLabel";
			this.dividedLeftLabel.Size = new System.Drawing.Size(60, 50);
			this.dividedLeftLabel.TabIndex = 17;
			this.dividedLeftLabel.Text = "?";
			this.dividedLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label8.Location = new System.Drawing.Point(106, 264);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(60, 50);
			this.label8.TabIndex = 18;
			this.label8.Text = "÷";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dividedRightLabel
			// 
			this.dividedRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dividedRightLabel.Location = new System.Drawing.Point(192, 264);
			this.dividedRightLabel.Name = "dividedRightLabel";
			this.dividedRightLabel.Size = new System.Drawing.Size(60, 50);
			this.dividedRightLabel.TabIndex = 19;
			this.dividedRightLabel.Text = "?";
			this.dividedRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label11.Location = new System.Drawing.Point(273, 264);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(60, 50);
			this.label11.TabIndex = 20;
			this.label11.Text = "=";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// quotient
			// 
			this.quotient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.quotient.Location = new System.Drawing.Point(355, 273);
			this.quotient.Name = "quotient";
			this.quotient.Size = new System.Drawing.Size(100, 41);
			this.quotient.TabIndex = 4;
			this.quotient.Enter += new System.EventHandler(this.answer_Enter);
			// 
			// startButton
			// 
			this.startButton.AutoSize = true;
			this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.startButton.Location = new System.Drawing.Point(165, 341);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(122, 39);
			this.startButton.TabIndex = 0;
			this.startButton.Text = "Start quiz";
			this.startButton.UseVisualStyleBackColor = true;
			this.startButton.Click += new System.EventHandler(this.startButton_Click);
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 408);
			this.Controls.Add(this.startButton);
			this.Controls.Add(this.quotient);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.dividedRightLabel);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.dividedLeftLabel);
			this.Controls.Add(this.product);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.timesRightLabel);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.timesLeftLabel);
			this.Controls.Add(this.difference);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.minusRightLabel);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.minusLeftLabel);
			this.Controls.Add(this.sum);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.plusRightLabel);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.plusLeftLabel);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.timeLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Math Quiz";
			((System.ComponentModel.ISupportInitialize)(this.sum)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.difference)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.product)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.quotient)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label timeLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label plusLeftLabel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label plusRightLabel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown sum;
		private System.Windows.Forms.Label minusLeftLabel;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label minusRightLabel;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.NumericUpDown difference;
		private System.Windows.Forms.Label timesLeftLabel;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label timesRightLabel;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.NumericUpDown product;
		private System.Windows.Forms.Label dividedLeftLabel;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label dividedRightLabel;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.NumericUpDown quotient;
		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.Timer timer1;
	}
}

