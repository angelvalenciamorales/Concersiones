
namespace NuevoCCCC
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboList = new System.Windows.Forms.ComboBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFinal = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnConvert);
            this.panel1.Controls.Add(this.cboList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(717, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 450);
            this.panel1.TabIndex = 0;
            // 
            // cboList
            // 
            this.cboList.FormattingEnabled = true;
            this.cboList.Items.AddRange(new object[] {
            "C->F",
            "F->C",
            "C->K",
            "F->K",
            "K->F"});
            this.cboList.Location = new System.Drawing.Point(15, 54);
            this.cboList.Name = "cboList";
            this.cboList.Size = new System.Drawing.Size(270, 33);
            this.cboList.TabIndex = 0;
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.Color.SteelBlue;
            this.btnConvert.FlatAppearance.BorderSize = 0;
            this.btnConvert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvert.Location = new System.Drawing.Point(63, 266);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(188, 41);
            this.btnConvert.TabIndex = 1;
            this.btnConvert.Text = "Convertir ";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(43, 179);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(206, 31);
            this.txtValor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(272, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "=";
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFinal.Location = new System.Drawing.Point(335, 182);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(0, 25);
            this.lblFinal.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1025, 450);
            this.Controls.Add(this.lblFinal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Conversiones ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.ComboBox cboList;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFinal;
    }
}

