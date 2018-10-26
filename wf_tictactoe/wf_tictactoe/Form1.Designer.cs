namespace wf_tictactoe {
	partial class Form1 {
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.resetCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.A1 = new System.Windows.Forms.Button();
			this.B3 = new System.Windows.Forms.Button();
			this.B2 = new System.Windows.Forms.Button();
			this.B1 = new System.Windows.Forms.Button();
			this.A3 = new System.Windows.Forms.Button();
			this.A2 = new System.Windows.Forms.Button();
			this.C2 = new System.Windows.Forms.Button();
			this.C1 = new System.Windows.Forms.Button();
			this.C3 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.x_win_count = new System.Windows.Forms.Label();
			this.draw_count = new System.Windows.Forms.Label();
			this.o_win_count = new System.Windows.Forms.Label();
			this.p1 = new System.Windows.Forms.TextBox();
			this.p2 = new System.Windows.Forms.TextBox();
			this.setPlayerDefaultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(264, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.setPlayerDefaultsToolStripMenuItem,
            this.resetCountToolStripMenuItem,
            this.optionToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// newGameToolStripMenuItem
			// 
			this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
			this.newGameToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
			this.newGameToolStripMenuItem.Text = "New Game";
			this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
			// 
			// resetCountToolStripMenuItem
			// 
			this.resetCountToolStripMenuItem.Name = "resetCountToolStripMenuItem";
			this.resetCountToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
			this.resetCountToolStripMenuItem.Text = "Reset Win Count";
			this.resetCountToolStripMenuItem.Click += new System.EventHandler(this.resetCountToolStripMenuItem_Click);
			// 
			// optionToolStripMenuItem
			// 
			this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
			this.optionToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
			this.optionToolStripMenuItem.Text = "Exit";
			this.optionToolStripMenuItem.Click += new System.EventHandler(this.optionToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// A1
			// 
			this.A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.A1.Location = new System.Drawing.Point(7, 32);
			this.A1.Margin = new System.Windows.Forms.Padding(20);
			this.A1.Name = "A1";
			this.A1.Size = new System.Drawing.Size(75, 75);
			this.A1.TabIndex = 1;
			this.A1.UseVisualStyleBackColor = true;
			this.A1.Click += new System.EventHandler(this.button_Click);
			this.A1.MouseEnter += new System.EventHandler(this.button_enter);
			this.A1.MouseLeave += new System.EventHandler(this.button_leave);
			// 
			// B3
			// 
			this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.B3.Location = new System.Drawing.Point(176, 113);
			this.B3.Margin = new System.Windows.Forms.Padding(20);
			this.B3.Name = "B3";
			this.B3.Size = new System.Drawing.Size(75, 75);
			this.B3.TabIndex = 2;
			this.B3.UseVisualStyleBackColor = true;
			this.B3.Click += new System.EventHandler(this.button_Click);
			this.B3.MouseEnter += new System.EventHandler(this.button_enter);
			this.B3.MouseLeave += new System.EventHandler(this.button_leave);
			// 
			// B2
			// 
			this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.B2.Location = new System.Drawing.Point(91, 113);
			this.B2.Margin = new System.Windows.Forms.Padding(20);
			this.B2.Name = "B2";
			this.B2.Size = new System.Drawing.Size(75, 75);
			this.B2.TabIndex = 3;
			this.B2.UseVisualStyleBackColor = true;
			this.B2.Click += new System.EventHandler(this.button_Click);
			this.B2.MouseEnter += new System.EventHandler(this.button_enter);
			this.B2.MouseLeave += new System.EventHandler(this.button_leave);
			// 
			// B1
			// 
			this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.B1.Location = new System.Drawing.Point(7, 113);
			this.B1.Margin = new System.Windows.Forms.Padding(20);
			this.B1.Name = "B1";
			this.B1.Size = new System.Drawing.Size(75, 75);
			this.B1.TabIndex = 4;
			this.B1.UseVisualStyleBackColor = true;
			this.B1.Click += new System.EventHandler(this.button_Click);
			this.B1.MouseEnter += new System.EventHandler(this.button_enter);
			this.B1.MouseLeave += new System.EventHandler(this.button_leave);
			// 
			// A3
			// 
			this.A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.A3.Location = new System.Drawing.Point(176, 32);
			this.A3.Margin = new System.Windows.Forms.Padding(20);
			this.A3.Name = "A3";
			this.A3.Size = new System.Drawing.Size(75, 75);
			this.A3.TabIndex = 5;
			this.A3.UseVisualStyleBackColor = true;
			this.A3.Click += new System.EventHandler(this.button_Click);
			this.A3.MouseEnter += new System.EventHandler(this.button_enter);
			this.A3.MouseLeave += new System.EventHandler(this.button_leave);
			// 
			// A2
			// 
			this.A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.A2.Location = new System.Drawing.Point(91, 32);
			this.A2.Margin = new System.Windows.Forms.Padding(20);
			this.A2.Name = "A2";
			this.A2.Size = new System.Drawing.Size(75, 75);
			this.A2.TabIndex = 6;
			this.A2.UseVisualStyleBackColor = true;
			this.A2.Click += new System.EventHandler(this.button_Click);
			this.A2.MouseEnter += new System.EventHandler(this.button_enter);
			this.A2.MouseLeave += new System.EventHandler(this.button_leave);
			// 
			// C2
			// 
			this.C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.C2.Location = new System.Drawing.Point(91, 194);
			this.C2.Margin = new System.Windows.Forms.Padding(20);
			this.C2.Name = "C2";
			this.C2.Size = new System.Drawing.Size(75, 75);
			this.C2.TabIndex = 7;
			this.C2.UseVisualStyleBackColor = true;
			this.C2.Click += new System.EventHandler(this.button_Click);
			this.C2.MouseEnter += new System.EventHandler(this.button_enter);
			this.C2.MouseLeave += new System.EventHandler(this.button_leave);
			// 
			// C1
			// 
			this.C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.C1.Location = new System.Drawing.Point(7, 194);
			this.C1.Margin = new System.Windows.Forms.Padding(20);
			this.C1.Name = "C1";
			this.C1.Size = new System.Drawing.Size(75, 75);
			this.C1.TabIndex = 8;
			this.C1.UseVisualStyleBackColor = true;
			this.C1.Click += new System.EventHandler(this.button_Click);
			this.C1.MouseEnter += new System.EventHandler(this.button_enter);
			this.C1.MouseLeave += new System.EventHandler(this.button_leave);
			// 
			// C3
			// 
			this.C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.C3.Location = new System.Drawing.Point(177, 194);
			this.C3.Margin = new System.Windows.Forms.Padding(20);
			this.C3.Name = "C3";
			this.C3.Size = new System.Drawing.Size(75, 75);
			this.C3.TabIndex = 9;
			this.C3.UseVisualStyleBackColor = true;
			this.C3.Click += new System.EventHandler(this.button_Click);
			this.C3.MouseEnter += new System.EventHandler(this.button_enter);
			this.C3.MouseLeave += new System.EventHandler(this.button_leave);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(91, 276);
			this.label2.MaximumSize = new System.Drawing.Size(75, 20);
			this.label2.MinimumSize = new System.Drawing.Size(75, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 20);
			this.label2.TabIndex = 11;
			this.label2.Text = "Draw count";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// x_win_count
			// 
			this.x_win_count.AutoSize = true;
			this.x_win_count.Location = new System.Drawing.Point(38, 307);
			this.x_win_count.Name = "x_win_count";
			this.x_win_count.Size = new System.Drawing.Size(13, 13);
			this.x_win_count.TabIndex = 13;
			this.x_win_count.Text = "0";
			// 
			// draw_count
			// 
			this.draw_count.AutoSize = true;
			this.draw_count.Location = new System.Drawing.Point(124, 307);
			this.draw_count.Name = "draw_count";
			this.draw_count.Size = new System.Drawing.Size(13, 13);
			this.draw_count.TabIndex = 14;
			this.draw_count.Text = "0";
			// 
			// o_win_count
			// 
			this.o_win_count.AutoSize = true;
			this.o_win_count.Location = new System.Drawing.Point(210, 307);
			this.o_win_count.Name = "o_win_count";
			this.o_win_count.Size = new System.Drawing.Size(13, 13);
			this.o_win_count.TabIndex = 15;
			this.o_win_count.Text = "0";
			// 
			// p1
			// 
			this.p1.Location = new System.Drawing.Point(7, 277);
			this.p1.MaximumSize = new System.Drawing.Size(75, 20);
			this.p1.MinimumSize = new System.Drawing.Size(75, 20);
			this.p1.Name = "p1";
			this.p1.Size = new System.Drawing.Size(75, 20);
			this.p1.TabIndex = 16;
			this.p1.Text = "Player 1";
			this.p1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// p2
			// 
			this.p2.Location = new System.Drawing.Point(177, 277);
			this.p2.MaximumSize = new System.Drawing.Size(75, 20);
			this.p2.MinimumSize = new System.Drawing.Size(75, 20);
			this.p2.Name = "p2";
			this.p2.Size = new System.Drawing.Size(75, 20);
			this.p2.TabIndex = 17;
			this.p2.Text = "Player 2";
			this.p2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.p2.TextChanged += new System.EventHandler(this.p2_TextChanged);
			// 
			// setPlayerDefaultsToolStripMenuItem
			// 
			this.setPlayerDefaultsToolStripMenuItem.Name = "setPlayerDefaultsToolStripMenuItem";
			this.setPlayerDefaultsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.setPlayerDefaultsToolStripMenuItem.Text = "Set Player Defaults";
			this.setPlayerDefaultsToolStripMenuItem.Click += new System.EventHandler(this.setPlayerDefaultsToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(264, 329);
			this.Controls.Add(this.p2);
			this.Controls.Add(this.p1);
			this.Controls.Add(this.o_win_count);
			this.Controls.Add(this.draw_count);
			this.Controls.Add(this.x_win_count);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.C3);
			this.Controls.Add(this.C1);
			this.Controls.Add(this.C2);
			this.Controls.Add(this.A2);
			this.Controls.Add(this.A3);
			this.Controls.Add(this.B1);
			this.Controls.Add(this.B2);
			this.Controls.Add(this.B3);
			this.Controls.Add(this.A1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tic Tac Toe";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.Button A1;
		private System.Windows.Forms.Button B3;
		private System.Windows.Forms.Button B2;
		private System.Windows.Forms.Button B1;
		private System.Windows.Forms.Button A3;
		private System.Windows.Forms.Button A2;
		private System.Windows.Forms.Button C2;
		private System.Windows.Forms.Button C1;
		private System.Windows.Forms.Button C3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label x_win_count;
		private System.Windows.Forms.Label draw_count;
		private System.Windows.Forms.Label o_win_count;
		private System.Windows.Forms.ToolStripMenuItem resetCountToolStripMenuItem;
		private System.Windows.Forms.TextBox p1;
		private System.Windows.Forms.TextBox p2;
		private System.Windows.Forms.ToolStripMenuItem setPlayerDefaultsToolStripMenuItem;
	}
}

