
namespace CapaPresentacion.Modulo_Curso
{
    partial class FrmAgregarCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarCurso));
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnGuardarAC = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNombCurso = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Maestros = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar.Image")));
            this.btnRegresar.Location = new System.Drawing.Point(104, 328);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(66, 37);
            this.btnRegresar.TabIndex = 27;
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // btnGuardarAC
            // 
            this.btnGuardarAC.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarAC.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarAC.Image")));
            this.btnGuardarAC.Location = new System.Drawing.Point(273, 328);
            this.btnGuardarAC.Name = "btnGuardarAC";
            this.btnGuardarAC.Size = new System.Drawing.Size(58, 47);
            this.btnGuardarAC.TabIndex = 24;
            this.btnGuardarAC.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardarAC.UseVisualStyleBackColor = true;
            this.btnGuardarAC.Click += new System.EventHandler(this.btnGuardarAC_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Datos del Curso";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Maestros);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtNombCurso);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(17, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 224);
            this.panel1.TabIndex = 21;
            // 
            // txtNombCurso
            // 
            this.txtNombCurso.Location = new System.Drawing.Point(146, 48);
            this.txtNombCurso.Name = "txtNombCurso";
            this.txtNombCurso.Size = new System.Drawing.Size(157, 20);
            this.txtNombCurso.TabIndex = 8;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(110, 16);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(157, 20);
            this.txtCodigo.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre del curso";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Codigo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(36, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 40);
            this.label1.TabIndex = 20;
            this.label1.Text = "    AGREGAR CURSO  \r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 14);
            this.label9.TabIndex = 15;
            this.label9.Text = "Docente";
            // 
            // Maestros
            // 
            this.Maestros.FormattingEnabled = true;
            this.Maestros.Location = new System.Drawing.Point(110, 84);
            this.Maestros.Name = "Maestros";
            this.Maestros.Size = new System.Drawing.Size(204, 95);
            this.Maestros.TabIndex = 16;
            this.Maestros.SelectedIndexChanged += new System.EventHandler(this.lstCantones_SelectedIndexChanged);
            // 
            // FrmAgregarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 394);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnGuardarAC);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FrmAgregarCurso";
            this.Text = "FrmAgregarCurso";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnGuardarAC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNombCurso;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Maestros;
        private System.Windows.Forms.Label label9;
    }
}