namespace ColorPicker
{
	partial class ColorPickerDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorPickerDialog));
            this.colorPickerCtrl1 = new ColorPicker.ColorPickerCtrl();
            this.SuspendLayout();
            // 
            // colorPickerCtrl1
            // 
            this.colorPickerCtrl1.BackColor = System.Drawing.Color.Transparent;
            this.colorPickerCtrl1.Location = new System.Drawing.Point(13, 13);
            this.colorPickerCtrl1.Name = "colorPickerCtrl1";
            this.colorPickerCtrl1.Padding = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.colorPickerCtrl1.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.colorPickerCtrl1.Size = new System.Drawing.Size(507, 250);
            this.colorPickerCtrl1.TabIndex = 0;
            this.colorPickerCtrl1.Load += new System.EventHandler(this.colorPickerCtrl1_Load);
            // 
            // ColorPickerDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(534, 276);
            this.Controls.Add(this.colorPickerCtrl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColorPickerDialog";
            this.Text = "ColorDrop";
            this.Load += new System.EventHandler(this.ColorPickerDialog_Load);
            this.ResumeLayout(false);

		}

        #endregion

        private ColorPickerCtrl colorPickerCtrl1;
    }
}

