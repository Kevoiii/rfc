/*
 * Created by SharpDevelop.
 * User: CC2_PC36
 * Date: 22/10/2024
 * Time: 07:38 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace curpilla
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
			
		
		void BtncalcularClick(object sender, EventArgs e)
		{
			//Declarar una variable string que servirá para sustituir al txt nombre
			string nombre=txtnombre.Text;
			
			//Declarar una variable string que servirá para sustituir al txtap1
			string apellido1=txtap1.Text;
			
			//Declarar una variable string que servirá para sustituir al txtap2
			string apellido2=txtap2.Text;
			
			//Declarar una variable que tomará las primeras dos letras de apellido1 usando el substring
			string letrasapellido1=apellido1.Substring(0,2);
			//Declarar una variable que tomará las primera letra de apellido2 usando el substring
			string letrasapellido2=apellido2.Substring(0,1);
			//Declarar una variable que tomará la primera letra de nombre usando el substring
			string letranombre=nombre.Substring(0,1);
			//aqui damos a entender que vamos a elegir un dato del mt_nacimiento con selection start, ademas estaremos manejando fechas, por eso usamos date time
			DateTime fechas=mt_nacimiento.SelectionStart;
			//declaramos una variable que nos va a servir para manejar el año en nuestra fecha
			int año = fechas.Year;
			//declaramos una variable que tome las dos ultimas cifras del año dividiendolo entre 100, usamor tostring"00" para asegurarnos que solo muestre dos digitos
			string sifrasaño = (año%100).ToString("00");
			//lo mismo que con el año pero ahora con el mes
			DateTime mesito=mt_nacimiento.SelectionStart; 
			int mes = mesito.Month;
			//ahora con el dia 
			DateTime diaa = mt_nacimiento.SelectionStart;
			int dia=diaa.Day;
			//igualmente usamos "00" para asegurarnos que sean 2 cifras 
			string messtring=mes.ToString("00");
			string diastring=dia.ToString("00");
			//declarar una variable que junte todo 
			string rfc = letrasapellido1 + letrasapellido2 + letranombre + sifrasaño + messtring + diastring;
			//mostramos el rfc ya junto
			string nombree=txtnombre.Text;
			string apellidoo=txtap1.Text;
			string apellidooo2=txtap2.Text;
			string nombrecompleto = nombree + apellidoo + apellidooo2;
			Form2 calculo = new Form2();
			calculo.RFC = rfc;
			calculo.name = nombrecompleto;
			
			calculo.Show();
			
		}
	}
}
