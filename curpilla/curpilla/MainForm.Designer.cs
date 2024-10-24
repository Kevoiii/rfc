/*
 * Created by SharpDevelop.
 * User: CC2_PC36
 * Date: 22/10/2024
 * Time: 07:38 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace curpilla
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.txtnombre = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtap1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtap2 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txttel = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtdire = new System.Windows.Forms.TextBox();
			this.cmbsemestre = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.mt_nacimiento = new System.Windows.Forms.MonthCalendar();
			this.label7 = new System.Windows.Forms.Label();
			this.btncalcular = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(13, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombre";
			// 
			// txtnombre
			// 
			this.txtnombre.Location = new System.Drawing.Point(132, 38);
			this.txtnombre.Name = "txtnombre";
			this.txtnombre.Size = new System.Drawing.Size(100, 20);
			this.txtnombre.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(13, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(113, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Apellido paterno";
			// 
			// txtap1
			// 
			this.txtap1.Location = new System.Drawing.Point(132, 64);
			this.txtap1.Name = "txtap1";
			this.txtap1.Size = new System.Drawing.Size(100, 20);
			this.txtap1.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(13, 91);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(137, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Apellido materno";
			// 
			// txtap2
			// 
			this.txtap2.Location = new System.Drawing.Point(132, 91);
			this.txtap2.Name = "txtap2";
			this.txtap2.Size = new System.Drawing.Size(100, 20);
			this.txtap2.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label4.Location = new System.Drawing.Point(13, 118);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Telefono";
			// 
			// txttel
			// 
			this.txttel.Location = new System.Drawing.Point(132, 119);
			this.txttel.Name = "txttel";
			this.txttel.Size = new System.Drawing.Size(100, 20);
			this.txttel.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label5.Location = new System.Drawing.Point(13, 145);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "Direccion";
			// 
			// txtdire
			// 
			this.txtdire.Location = new System.Drawing.Point(132, 148);
			this.txtdire.Name = "txtdire";
			this.txtdire.Size = new System.Drawing.Size(100, 20);
			this.txtdire.TabIndex = 9;
			// 
			// cmbsemestre
			// 
			this.cmbsemestre.FormattingEnabled = true;
			this.cmbsemestre.Items.AddRange(new object[] {
			"Semestre 1",
			"Semestre 2",
			"Semestre 3",
			"Semestre 4",
			"Semestre 5",
			"Semestre 6"});
			this.cmbsemestre.Location = new System.Drawing.Point(132, 174);
			this.cmbsemestre.Name = "cmbsemestre";
			this.cmbsemestre.Size = new System.Drawing.Size(121, 21);
			this.cmbsemestre.TabIndex = 10;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label6.Location = new System.Drawing.Point(13, 171);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(85, 23);
			this.label6.TabIndex = 11;
			this.label6.Text = "Semestre";
			// 
			// mt_nacimiento
			// 
			this.mt_nacimiento.Location = new System.Drawing.Point(132, 207);
			this.mt_nacimiento.Name = "mt_nacimiento";
			this.mt_nacimiento.TabIndex = 12;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label7.Location = new System.Drawing.Point(13, 198);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 44);
			this.label7.TabIndex = 13;
			this.label7.Text = "Fecha de nacimiento";
			// 
			// btncalcular
			// 
			this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btncalcular.Location = new System.Drawing.Point(316, 410);
			this.btncalcular.Name = "btncalcular";
			this.btncalcular.Size = new System.Drawing.Size(94, 46);
			this.btncalcular.TabIndex = 15;
			this.btncalcular.Text = "Calcular ";
			this.btncalcular.UseVisualStyleBackColor = true;
			this.btncalcular.Click += new System.EventHandler(this.BtncalcularClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(492, 468);
			this.Controls.Add(this.btncalcular);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.mt_nacimiento);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.cmbsemestre);
			this.Controls.Add(this.txtdire);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txttel);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtap2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtap1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtnombre);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "curpilla";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.Button btncalcular;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.MonthCalendar mt_nacimiento;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cmbsemestre;
		private System.Windows.Forms.TextBox txtdire;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txttel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtap2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtap1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtnombre;
		private System.Windows.Forms.Label label1;
	}
}
