namespace FactorialCSWF
{
	partial class MainWindow
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			this.Enternumberlabel = new MetroFramework.Controls.MetroLabel();
			this.Startbutton = new MetroFramework.Controls.MetroButton();
			this.Timelabel = new MetroFramework.Controls.MetroLabel();
			this.OpenDocbutton = new MetroFramework.Controls.MetroButton();
			this.Outputbox = new MetroFramework.Controls.MetroTextBox();
			this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
			this.Infobox = new MetroFramework.Controls.MetroLabel();
			this.Limitbox = new MetroFramework.Controls.MetroLabel();
			this.metroTile1 = new MetroFramework.Controls.MetroTile();
			this.Inputbox = new MetroFramework.Controls.MetroTextBox();
			this.Counterbox = new MetroFramework.Controls.MetroLabel();
			((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
			this.SuspendLayout();
			// 
			// Enternumberlabel
			// 
			this.Enternumberlabel.AutoSize = true;
			this.Enternumberlabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.Enternumberlabel.Location = new System.Drawing.Point(24, 60);
			this.Enternumberlabel.Name = "Enternumberlabel";
			this.Enternumberlabel.Size = new System.Drawing.Size(136, 19);
			this.Enternumberlabel.Style = MetroFramework.MetroColorStyle.Purple;
			this.Enternumberlabel.TabIndex = 0;
			this.Enternumberlabel.Text = "Enter number below:";
			this.Enternumberlabel.Theme = MetroFramework.MetroThemeStyle.Dark;
			// 
			// Startbutton
			// 
			this.Startbutton.FontSize = MetroFramework.MetroButtonSize.Medium;
			this.Startbutton.Highlight = true;
			this.Startbutton.Location = new System.Drawing.Point(164, 82);
			this.Startbutton.Name = "Startbutton";
			this.Startbutton.Size = new System.Drawing.Size(75, 21);
			this.Startbutton.Style = MetroFramework.MetroColorStyle.Purple;
			this.Startbutton.TabIndex = 2;
			this.Startbutton.Text = "Start";
			this.Startbutton.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.Startbutton.UseSelectable = true;
			this.Startbutton.Click += new System.EventHandler(this.metroButton1_Click);
			// 
			// Timelabel
			// 
			this.Timelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Timelabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.Timelabel.Location = new System.Drawing.Point(549, 60);
			this.Timelabel.Name = "Timelabel";
			this.Timelabel.Size = new System.Drawing.Size(228, 23);
			this.Timelabel.Style = MetroFramework.MetroColorStyle.Purple;
			this.Timelabel.TabIndex = 4;
			this.Timelabel.Text = "Time: (click \"Start\")";
			this.Timelabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.Timelabel.Theme = MetroFramework.MetroThemeStyle.Dark;
			// 
			// OpenDocbutton
			// 
			this.OpenDocbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.OpenDocbutton.Location = new System.Drawing.Point(629, 34);
			this.OpenDocbutton.Name = "OpenDocbutton";
			this.OpenDocbutton.Size = new System.Drawing.Size(148, 23);
			this.OpenDocbutton.Style = MetroFramework.MetroColorStyle.Purple;
			this.OpenDocbutton.TabIndex = 5;
			this.OpenDocbutton.Text = "Open Documents folder";
			this.OpenDocbutton.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.OpenDocbutton.UseSelectable = true;
			this.OpenDocbutton.Click += new System.EventHandler(this.metroButton2_Click);
			// 
			// Outputbox
			// 
			this.Outputbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// 
			// 
			this.Outputbox.CustomButton.Image = null;
			this.Outputbox.CustomButton.Location = new System.Drawing.Point(437, 2);
			this.Outputbox.CustomButton.Name = "";
			this.Outputbox.CustomButton.Size = new System.Drawing.Size(313, 313);
			this.Outputbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.Outputbox.CustomButton.TabIndex = 1;
			this.Outputbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.Outputbox.CustomButton.UseSelectable = true;
			this.Outputbox.CustomButton.Visible = false;
			this.Outputbox.Lines = new string[0];
			this.Outputbox.Location = new System.Drawing.Point(24, 109);
			this.Outputbox.MaxLength = 2147483647;
			this.Outputbox.Multiline = true;
			this.Outputbox.Name = "Outputbox";
			this.Outputbox.PasswordChar = '\0';
			this.Outputbox.ReadOnly = true;
			this.Outputbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.Outputbox.SelectedText = "";
			this.Outputbox.SelectionLength = 0;
			this.Outputbox.SelectionStart = 0;
			this.Outputbox.ShortcutsEnabled = true;
			this.Outputbox.Size = new System.Drawing.Size(753, 318);
			this.Outputbox.Style = MetroFramework.MetroColorStyle.Purple;
			this.Outputbox.TabIndex = 6;
			this.Outputbox.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.Outputbox.UseSelectable = true;
			this.Outputbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.Outputbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// metroStyleManager1
			// 
			this.metroStyleManager1.Owner = this;
			this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Purple;
			this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
			// 
			// Infobox
			// 
			this.Infobox.Location = new System.Drawing.Point(245, 9);
			this.Infobox.Name = "Infobox";
			this.Infobox.Size = new System.Drawing.Size(197, 76);
			this.Infobox.Style = MetroFramework.MetroColorStyle.Purple;
			this.Infobox.TabIndex = 7;
			this.Infobox.Text = "If you enter number bigger then\r\n268609166, you got output in\r\nMy Documents folde" +
    "r in\r\nFactorialResult.txt";
			this.Infobox.Theme = MetroFramework.MetroThemeStyle.Dark;
			// 
			// Limitbox
			// 
			this.Limitbox.AutoSize = true;
			this.Limitbox.Location = new System.Drawing.Point(245, 87);
			this.Limitbox.Name = "Limitbox";
			this.Limitbox.Size = new System.Drawing.Size(168, 19);
			this.Limitbox.Style = MetroFramework.MetroColorStyle.Purple;
			this.Limitbox.TabIndex = 8;
			this.Limitbox.Text = "Input limits: (0-2147483647)";
			this.Limitbox.Theme = MetroFramework.MetroThemeStyle.Dark;
			// 
			// metroTile1
			// 
			this.metroTile1.ActiveControl = null;
			this.metroTile1.Location = new System.Drawing.Point(250, 87);
			this.metroTile1.Name = "metroTile1";
			this.metroTile1.PaintTileCount = false;
			this.metroTile1.Size = new System.Drawing.Size(160, 1);
			this.metroTile1.Style = MetroFramework.MetroColorStyle.Purple;
			this.metroTile1.TabIndex = 9;
			this.metroTile1.Text = "metroTile1";
			this.metroTile1.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroTile1.UseSelectable = true;
			// 
			// Inputbox
			// 
			// 
			// 
			// 
			this.Inputbox.CustomButton.Image = null;
			this.Inputbox.CustomButton.Location = new System.Drawing.Point(115, 1);
			this.Inputbox.CustomButton.Name = "";
			this.Inputbox.CustomButton.Size = new System.Drawing.Size(19, 19);
			this.Inputbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.Inputbox.CustomButton.TabIndex = 1;
			this.Inputbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.Inputbox.CustomButton.UseSelectable = true;
			this.Inputbox.CustomButton.Visible = false;
			this.Inputbox.Lines = new string[0];
			this.Inputbox.Location = new System.Drawing.Point(24, 82);
			this.Inputbox.MaxLength = 32767;
			this.Inputbox.Name = "Inputbox";
			this.Inputbox.PasswordChar = '\0';
			this.Inputbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.Inputbox.SelectedText = "";
			this.Inputbox.SelectionLength = 0;
			this.Inputbox.SelectionStart = 0;
			this.Inputbox.ShortcutsEnabled = true;
			this.Inputbox.Size = new System.Drawing.Size(135, 21);
			this.Inputbox.Style = MetroFramework.MetroColorStyle.Purple;
			this.Inputbox.TabIndex = 1;
			this.Inputbox.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.Inputbox.UseSelectable = true;
			this.Inputbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.Inputbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.Inputbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.metroTextBox1_KeyDown);
			// 
			// Counterbox
			// 
			this.Counterbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Counterbox.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.Counterbox.Location = new System.Drawing.Point(549, 83);
			this.Counterbox.Name = "Counterbox";
			this.Counterbox.Size = new System.Drawing.Size(228, 23);
			this.Counterbox.Style = MetroFramework.MetroColorStyle.Purple;
			this.Counterbox.TabIndex = 10;
			this.Counterbox.Text = "Numbers in answer: (click \"Start\")";
			this.Counterbox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.Counterbox.Theme = MetroFramework.MetroThemeStyle.Dark;
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.Counterbox);
			this.Controls.Add(this.metroTile1);
			this.Controls.Add(this.Limitbox);
			this.Controls.Add(this.Infobox);
			this.Controls.Add(this.Outputbox);
			this.Controls.Add(this.OpenDocbutton);
			this.Controls.Add(this.Timelabel);
			this.Controls.Add(this.Startbutton);
			this.Controls.Add(this.Inputbox);
			this.Controls.Add(this.Enternumberlabel);
			this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(680, 400);
			this.Name = "MainWindow";
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
			this.Style = MetroFramework.MetroColorStyle.Purple;
			this.Text = "Factorial Calculator";
			this.Theme = MetroFramework.MetroThemeStyle.Dark;
			((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroLabel Enternumberlabel;
		private MetroFramework.Controls.MetroButton Startbutton;
		private MetroFramework.Controls.MetroLabel Timelabel;
		private MetroFramework.Controls.MetroButton OpenDocbutton;
		private MetroFramework.Controls.MetroTextBox Outputbox;
		private MetroFramework.Components.MetroStyleManager metroStyleManager1;
		private MetroFramework.Controls.MetroLabel Limitbox;
		private MetroFramework.Controls.MetroLabel Infobox;
		private MetroFramework.Controls.MetroTile metroTile1;
		private MetroFramework.Controls.MetroTextBox Inputbox;
		private MetroFramework.Controls.MetroLabel Counterbox;
	}
}

