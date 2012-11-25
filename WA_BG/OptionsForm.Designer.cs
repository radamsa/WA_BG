namespace WA_BG
{
	partial class OptionsForm
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
			this.uiWoWPath = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.uiFolderSelectButton = new System.Windows.Forms.Button();
			this.uiCancelButton = new System.Windows.Forms.Button();
			this.uiOkButton = new System.Windows.Forms.Button();
			this.uiWoWFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.label3 = new System.Windows.Forms.Label();
			this.uiCheckInterval = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.uiCheckInterval)).BeginInit();
			this.SuspendLayout();
			// 
			// uiWoWPath
			// 
			this.uiWoWPath.Location = new System.Drawing.Point(15, 25);
			this.uiWoWPath.Name = "uiWoWPath";
			this.uiWoWPath.Size = new System.Drawing.Size(348, 20);
			this.uiWoWPath.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(123, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "World of Warcraft folder:";
			// 
			// uiFolderSelectButton
			// 
			this.uiFolderSelectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.uiFolderSelectButton.Location = new System.Drawing.Point(369, 22);
			this.uiFolderSelectButton.Name = "uiFolderSelectButton";
			this.uiFolderSelectButton.Size = new System.Drawing.Size(30, 23);
			this.uiFolderSelectButton.TabIndex = 2;
			this.uiFolderSelectButton.Text = "...";
			this.uiFolderSelectButton.UseVisualStyleBackColor = true;
			this.uiFolderSelectButton.Click += new System.EventHandler(this.uiFolderSelectButton_Click);
			// 
			// uiCancelButton
			// 
			this.uiCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.uiCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.uiCancelButton.Location = new System.Drawing.Point(324, 58);
			this.uiCancelButton.Name = "uiCancelButton";
			this.uiCancelButton.Size = new System.Drawing.Size(75, 23);
			this.uiCancelButton.TabIndex = 3;
			this.uiCancelButton.Text = "Cancel";
			this.uiCancelButton.UseVisualStyleBackColor = true;
			// 
			// uiOkButton
			// 
			this.uiOkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.uiOkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.uiOkButton.Location = new System.Drawing.Point(243, 58);
			this.uiOkButton.Name = "uiOkButton";
			this.uiOkButton.Size = new System.Drawing.Size(75, 23);
			this.uiOkButton.TabIndex = 4;
			this.uiOkButton.Text = "Ok";
			this.uiOkButton.UseVisualStyleBackColor = true;
			this.uiOkButton.Click += new System.EventHandler(this.uiOkButton_Click);
			// 
			// uiWoWFolderBrowserDialog
			// 
			this.uiWoWFolderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
			this.uiWoWFolderBrowserDialog.ShowNewFolderButton = false;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 62);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(104, 13);
			this.label3.TabIndex = 17;
			this.label3.Text = "Check interval (sec):";
			// 
			// uiCheckInterval
			// 
			this.uiCheckInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.uiCheckInterval.DecimalPlaces = 1;
			this.uiCheckInterval.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.uiCheckInterval.Location = new System.Drawing.Point(122, 60);
			this.uiCheckInterval.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.uiCheckInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.uiCheckInterval.Name = "uiCheckInterval";
			this.uiCheckInterval.Size = new System.Drawing.Size(62, 20);
			this.uiCheckInterval.TabIndex = 16;
			this.uiCheckInterval.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
			// 
			// OptionsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(411, 93);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.uiCheckInterval);
			this.Controls.Add(this.uiOkButton);
			this.Controls.Add(this.uiCancelButton);
			this.Controls.Add(this.uiFolderSelectButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.uiWoWPath);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "OptionsForm";
			this.Text = "Options";
			this.Load += new System.EventHandler(this.OptionsForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.uiCheckInterval)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox uiWoWPath;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button uiFolderSelectButton;
		private System.Windows.Forms.Button uiCancelButton;
		private System.Windows.Forms.Button uiOkButton;
		private System.Windows.Forms.FolderBrowserDialog uiWoWFolderBrowserDialog;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown uiCheckInterval;
	}
}