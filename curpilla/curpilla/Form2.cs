/*
 * Created by SharpDevelop.
 * User: CC2_PC36
 * Date: 23/10/2024
 * Time: 08:06 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace curpilla
{
	/// <summary>
	/// Description of Form2.
	/// </summary>
	public partial class Form2 : Form
	{
		public string RFC, name;
		public Form2()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
		}

			
		
		void Form2Load(object sender, EventArgs e)
		{
			lblrfc.Text=RFC;
			lblname.Text=name;
			
		}
	}
}
