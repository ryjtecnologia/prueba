namespace capaPresentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgpersonas = new System.Windows.Forms.DataGridView();
            this.btn_traer_datos = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.tdato = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_buscarAqui = new System.Windows.Forms.Button();
            this.t2 = new System.Windows.Forms.TextBox();
            this.t0 = new System.Windows.Forms.TextBox();
            this.t1 = new System.Windows.Forms.TextBox();
            this.t3 = new System.Windows.Forms.TextBox();
            this.ri = new System.Windows.Forms.RadioButton();
            this.rf = new System.Windows.Forms.RadioButton();
            this.rc = new System.Windows.Forms.RadioButton();
            this.rt = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgpersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgpersonas
            // 
            this.dgpersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgpersonas.Location = new System.Drawing.Point(70, 62);
            this.dgpersonas.Name = "dgpersonas";
            this.dgpersonas.Size = new System.Drawing.Size(401, 184);
            this.dgpersonas.TabIndex = 0;
            // 
            // btn_traer_datos
            // 
            this.btn_traer_datos.Location = new System.Drawing.Point(70, 24);
            this.btn_traer_datos.Name = "btn_traer_datos";
            this.btn_traer_datos.Size = new System.Drawing.Size(137, 32);
            this.btn_traer_datos.TabIndex = 1;
            this.btn_traer_datos.Text = "TRAER DATOS";
            this.btn_traer_datos.UseVisualStyleBackColor = true;
            this.btn_traer_datos.Click += new System.EventHandler(this.btn_traer_datos_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(70, 318);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(137, 44);
            this.btn_buscar.TabIndex = 2;
            this.btn_buscar.Text = "BUSCAR PERSONAS POR NOMBRE";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // tdato
            // 
            this.tdato.Location = new System.Drawing.Point(341, 337);
            this.tdato.Name = "tdato";
            this.tdato.Size = new System.Drawing.Size(100, 20);
            this.tdato.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Coloque un nombre";
            // 
            // btn_buscarAqui
            // 
            this.btn_buscarAqui.Location = new System.Drawing.Point(542, 318);
            this.btn_buscarAqui.Name = "btn_buscarAqui";
            this.btn_buscarAqui.Size = new System.Drawing.Size(137, 44);
            this.btn_buscarAqui.TabIndex = 5;
            this.btn_buscarAqui.Text = "BUSCAR PERSONAS POR NOMBRE";
            this.btn_buscarAqui.UseVisualStyleBackColor = true;
            this.btn_buscarAqui.Click += new System.EventHandler(this.btn_buscarAqui_Click);
            // 
            // t2
            // 
            this.t2.Location = new System.Drawing.Point(486, 114);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(100, 20);
            this.t2.TabIndex = 6;
            // 
            // t0
            // 
            this.t0.Location = new System.Drawing.Point(486, 62);
            this.t0.Name = "t0";
            this.t0.Size = new System.Drawing.Size(100, 20);
            this.t0.TabIndex = 7;
            // 
            // t1
            // 
            this.t1.Location = new System.Drawing.Point(486, 88);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(100, 20);
            this.t1.TabIndex = 8;
            // 
            // t3
            // 
            this.t3.Location = new System.Drawing.Point(486, 140);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(100, 20);
            this.t3.TabIndex = 9;
            // 
            // ri
            // 
            this.ri.AutoSize = true;
            this.ri.Location = new System.Drawing.Point(225, 301);
            this.ri.Name = "ri";
            this.ri.Size = new System.Drawing.Size(57, 17);
            this.ri.TabIndex = 10;
            this.ri.TabStop = true;
            this.ri.Text = "INICIO";
            this.ri.UseVisualStyleBackColor = true;
            // 
            // rf
            // 
            this.rf.AutoSize = true;
            this.rf.Location = new System.Drawing.Point(225, 324);
            this.rf.Name = "rf";
            this.rf.Size = new System.Drawing.Size(42, 17);
            this.rf.TabIndex = 11;
            this.rf.TabStop = true;
            this.rf.Text = "FIN";
            this.rf.UseVisualStyleBackColor = true;
            // 
            // rc
            // 
            this.rc.AutoSize = true;
            this.rc.Location = new System.Drawing.Point(225, 347);
            this.rc.Name = "rc";
            this.rc.Size = new System.Drawing.Size(80, 17);
            this.rc.TabIndex = 12;
            this.rc.TabStop = true;
            this.rc.Text = "CONTIENE";
            this.rc.UseVisualStyleBackColor = true;
            // 
            // rt
            // 
            this.rt.AutoSize = true;
            this.rt.Location = new System.Drawing.Point(225, 278);
            this.rt.Name = "rt";
            this.rt.Size = new System.Drawing.Size(84, 17);
            this.rt.TabIndex = 13;
            this.rt.TabStop = true;
            this.rt.Text = "COMPLETO";
            this.rt.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(486, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 32);
            this.button1.TabIndex = 14;
            this.button1.Text = "GUARDAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 391);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rt);
            this.Controls.Add(this.rc);
            this.Controls.Add(this.rf);
            this.Controls.Add(this.ri);
            this.Controls.Add(this.t3);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.t0);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.btn_buscarAqui);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tdato);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_traer_datos);
            this.Controls.Add(this.dgpersonas);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgpersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgpersonas;
        private System.Windows.Forms.Button btn_traer_datos;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox tdato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_buscarAqui;
        private System.Windows.Forms.TextBox t2;
        private System.Windows.Forms.TextBox t0;
        private System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.TextBox t3;
        private System.Windows.Forms.RadioButton ri;
        private System.Windows.Forms.RadioButton rf;
        private System.Windows.Forms.RadioButton rc;
        private System.Windows.Forms.RadioButton rt;
        private System.Windows.Forms.Button button1;
    }
}

