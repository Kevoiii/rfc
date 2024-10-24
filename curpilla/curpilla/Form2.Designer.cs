/*
 * Created by SharpDevelop.
 * User: CC2_PC36
 * Date: 23/10/2024
 * Time: 08:06 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace curpilla
{
	partial class Form2
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
			this.lblname = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblrfc = new System.Windows.Forms.Label();
			this.btnsiguiente = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(46, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(141, 44);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tu nombre compreto es:";
			// 
			// lblname
			// 
			this.lblname.Location = new System.Drawing.Point(208, 57);
			this.lblname.Name = "lblname";
			this.lblname.Size = new System.Drawing.Size(100, 23);
			this.lblname.TabIndex = 1;
			this.lblname.Text = "/////////";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(46, 116);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "tu rfc es:";
			// 
			// lblrfc
			// 
			this.lblrfc.Location = new System.Drawing.Point(208, 121);
			this.lblrfc.Name = "lblrfc";
			this.lblrfc.Size = new System.Drawing.Size(100, 23);
			this.lblrfc.TabIndex = 3;
			this.lblrfc.Text = "///////";
			// 
			// btnsiguiente
			// 
			this.btnsiguiente.Location = new System.Drawing.Point(154, 166);
			this.btnsiguiente.Name = "btnsiguiente";
			this.btnsiguiente.Size = new System.Drawing.Size(75, 23);
			this.btnsiguiente.TabIndex = 4;
			this.btnsiguiente.Text = "siguiente";
			this.btnsiguiente.UseVisualStyleBackColor = true;
			this.btnsiguiente.Click += new System.EventHandler(this.BtnsiguienteClick);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(385, 208);
			this.Controls.Add(this.btnsiguiente);
			this.Controls.Add(this.lblrfc);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblname);
			this.Controls.Add(this.label1);
			this.Name = "Form2";
			this.Text = "Form2";
			this.Load += new System.EventHandler(this.Form2Load);
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.Label lblrfc;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblname;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnsiguiente;
	}
}
