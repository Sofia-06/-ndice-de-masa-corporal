namespace Masa_corporal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtv1 = new System.Windows.Forms.TextBox();
            this.txtv2 = new System.Windows.Forms.TextBox();
            this.cmdResultado = new System.Windows.Forms.Button();
            this.lblRes = new System.Windows.Forms.Label();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.pbimg1 = new System.Windows.Forms.PictureBox();
            this.pbimg2 = new System.Windows.Forms.PictureBox();
            this.pbimg3 = new System.Windows.Forms.PictureBox();
            this.cmdNormal = new System.Windows.Forms.Button();
            this.cmdSobre = new System.Windows.Forms.Button();
            this.cmdObe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbimg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbimg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbimg3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(78, 62);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(31, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Peso";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(78, 104);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(34, 13);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Altura";
            // 
            // txtv1
            // 
            this.txtv1.Location = new System.Drawing.Point(160, 62);
            this.txtv1.Name = "txtv1";
            this.txtv1.Size = new System.Drawing.Size(122, 20);
            this.txtv1.TabIndex = 2;
            // 
            // txtv2
            // 
            this.txtv2.Location = new System.Drawing.Point(160, 104);
            this.txtv2.Name = "txtv2";
            this.txtv2.Size = new System.Drawing.Size(122, 20);
            this.txtv2.TabIndex = 3;
            // 
            // cmdResultado
            // 
            this.cmdResultado.Location = new System.Drawing.Point(160, 154);
            this.cmdResultado.Name = "cmdResultado";
            this.cmdResultado.Size = new System.Drawing.Size(122, 46);
            this.cmdResultado.TabIndex = 4;
            this.cmdResultado.Text = "Resultado";
            this.cmdResultado.UseVisualStyleBackColor = true;
            this.cmdResultado.Click += new System.EventHandler(this.cmdResultado_Click);
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblRes.Font = new System.Drawing.Font("Lithos Pro Regular", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblRes.Location = new System.Drawing.Point(278, 227);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(37, 35);
            this.lblRes.TabIndex = 5;
            this.lblRes.Text = "0";
            this.lblRes.Click += new System.EventHandler(this.lblRes_Click);
            this.lblRes.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblRes_MouseMove);
            // 
            // cmdSalir
            // 
            this.cmdSalir.Font = new System.Drawing.Font("Lithos Pro Regular", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Location = new System.Drawing.Point(36, 320);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(127, 42);
            this.cmdSalir.TabIndex = 6;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // pbimg1
            // 
            this.pbimg1.Image = ((System.Drawing.Image)(resources.GetObject("pbimg1.Image")));
            this.pbimg1.Location = new System.Drawing.Point(568, 25);
            this.pbimg1.Name = "pbimg1";
            this.pbimg1.Size = new System.Drawing.Size(151, 138);
            this.pbimg1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbimg1.TabIndex = 7;
            this.pbimg1.TabStop = false;
            // 
            // pbimg2
            // 
            this.pbimg2.Image = ((System.Drawing.Image)(resources.GetObject("pbimg2.Image")));
            this.pbimg2.Location = new System.Drawing.Point(568, 169);
            this.pbimg2.Name = "pbimg2";
            this.pbimg2.Size = new System.Drawing.Size(163, 93);
            this.pbimg2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbimg2.TabIndex = 8;
            this.pbimg2.TabStop = false;
            // 
            // pbimg3
            // 
            this.pbimg3.Image = ((System.Drawing.Image)(resources.GetObject("pbimg3.Image")));
            this.pbimg3.Location = new System.Drawing.Point(568, 268);
            this.pbimg3.Name = "pbimg3";
            this.pbimg3.Size = new System.Drawing.Size(163, 94);
            this.pbimg3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbimg3.TabIndex = 9;
            this.pbimg3.TabStop = false;
            // 
            // cmdNormal
            // 
            this.cmdNormal.Location = new System.Drawing.Point(429, 62);
            this.cmdNormal.Name = "cmdNormal";
            this.cmdNormal.Size = new System.Drawing.Size(103, 50);
            this.cmdNormal.TabIndex = 10;
            this.cmdNormal.Text = "\"18.5 - 24.9\"";
            this.cmdNormal.UseVisualStyleBackColor = true;
            this.cmdNormal.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmdNormal_MouseClick);
            // 
            // cmdSobre
            // 
            this.cmdSobre.Location = new System.Drawing.Point(424, 181);
            this.cmdSobre.Name = "cmdSobre";
            this.cmdSobre.Size = new System.Drawing.Size(108, 51);
            this.cmdSobre.TabIndex = 11;
            this.cmdSobre.Text = "\"25.0 - 29.9\"";
            this.cmdSobre.UseVisualStyleBackColor = true;
            this.cmdSobre.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmdSobre_MouseClick);
            // 
            // cmdObe
            // 
            this.cmdObe.Location = new System.Drawing.Point(424, 299);
            this.cmdObe.Name = "cmdObe";
            this.cmdObe.Size = new System.Drawing.Size(117, 47);
            this.cmdObe.TabIndex = 12;
            this.cmdObe.Text = "\"30.0 - 39.9\"";
            this.cmdObe.UseVisualStyleBackColor = true;
            this.cmdObe.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmdObe_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdObe);
            this.Controls.Add(this.cmdSobre);
            this.Controls.Add(this.cmdNormal);
            this.Controls.Add(this.pbimg3);
            this.Controls.Add(this.pbimg2);
            this.Controls.Add(this.pbimg1);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.cmdResultado);
            this.Controls.Add(this.txtv2);
            this.Controls.Add(this.txtv1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbimg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbimg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbimg3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtv1;
        private System.Windows.Forms.TextBox txtv2;
        private System.Windows.Forms.Button cmdResultado;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.PictureBox pbimg1;
        private System.Windows.Forms.PictureBox pbimg2;
        private System.Windows.Forms.PictureBox pbimg3;
        private System.Windows.Forms.Button cmdNormal;
        private System.Windows.Forms.Button cmdSobre;
        private System.Windows.Forms.Button cmdObe;
    }
}

