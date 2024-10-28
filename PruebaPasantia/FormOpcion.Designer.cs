namespace PruebaPasantia
{
    partial class FormOpcion
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
            this.txtOpcion = new System.Windows.Forms.TextBox();
            this.chkEstadO = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.opcionesDataGridView = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtRelacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.opcionesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOpcion
            // 
            this.txtOpcion.Location = new System.Drawing.Point(12, 22);
            this.txtOpcion.Name = "txtOpcion";
            this.txtOpcion.Size = new System.Drawing.Size(119, 20);
            this.txtOpcion.TabIndex = 0;
            // 
            // chkEstadO
            // 
            this.chkEstadO.AutoSize = true;
            this.chkEstadO.Location = new System.Drawing.Point(23, 90);
            this.chkEstadO.Name = "chkEstadO";
            this.chkEstadO.Size = new System.Drawing.Size(59, 17);
            this.chkEstadO.TabIndex = 1;
            this.chkEstadO.Text = "Estado";
            this.chkEstadO.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre de la opcion";
            // 
            // opcionesDataGridView
            // 
            this.opcionesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.opcionesDataGridView.Location = new System.Drawing.Point(12, 113);
            this.opcionesDataGridView.Name = "opcionesDataGridView";
            this.opcionesDataGridView.Size = new System.Drawing.Size(466, 150);
            this.opcionesDataGridView.TabIndex = 3;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(161, 84);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // txtRelacion
            // 
            this.txtRelacion.Location = new System.Drawing.Point(12, 64);
            this.txtRelacion.Name = "txtRelacion";
            this.txtRelacion.Size = new System.Drawing.Size(28, 20);
            this.txtRelacion.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Codigo del producto";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(253, 84);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(70, 22);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // FormOpcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 301);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRelacion);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.opcionesDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkEstadO);
            this.Controls.Add(this.txtOpcion);
            this.Name = "FormOpcion";
            this.Text = "FormOpcion";
            ((System.ComponentModel.ISupportInitialize)(this.opcionesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOpcion;
        private System.Windows.Forms.CheckBox chkEstadO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView opcionesDataGridView;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtRelacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnModificar;
    }
}