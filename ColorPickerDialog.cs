using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ColorPicker
{
	public partial class ColorPickerDialog : Form
	{
		ColorPickerCtrl m_colorPicker;
		public ColorPickerDialog()
		{
			InitializeComponent();

			colorPickerCtrl1 = new ColorPickerCtrl();
            colorPickerCtrl1.Dock = DockStyle.Fill;
      	}

		

        private void ColorPickerDialog_Load(object sender, EventArgs e)
        {

        }

        private void colorPickerCtrl1_Load(object sender, EventArgs e)
        {

        }
    }
}