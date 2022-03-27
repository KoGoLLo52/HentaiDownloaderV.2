namespace HentaiDownloaderV._2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.URLERROR = new System.Windows.Forms.Label();
            this.TextoH = new System.Windows.Forms.Label();
            this.Download = new System.Windows.Forms.Button();
            this.Path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PathB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(296, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // URLERROR
            // 
            this.URLERROR.AutoSize = true;
            this.URLERROR.ForeColor = System.Drawing.Color.Red;
            this.URLERROR.Location = new System.Drawing.Point(198, 9);
            this.URLERROR.Name = "URLERROR";
            this.URLERROR.Size = new System.Drawing.Size(110, 13);
            this.URLERROR.TabIndex = 9;
            this.URLERROR.Text = "hidrogenos no validos";
            this.URLERROR.Visible = false;
            // 
            // TextoH
            // 
            this.TextoH.AutoSize = true;
            this.TextoH.Location = new System.Drawing.Point(12, 9);
            this.TextoH.Name = "TextoH";
            this.TextoH.Size = new System.Drawing.Size(181, 13);
            this.TextoH.TabIndex = 10;
            this.TextoH.Text = "Introduzca Url/code del Hidrogeno/s";
            // 
            // Download
            // 
            this.Download.Location = new System.Drawing.Point(11, 101);
            this.Download.Name = "Download";
            this.Download.Size = new System.Drawing.Size(182, 65);
            this.Download.TabIndex = 11;
            this.Download.Text = "Descargar";
            this.Download.UseVisualStyleBackColor = true;
            this.Download.Click += new System.EventHandler(this.Download_Click);
            // 
            // Path
            // 
            this.Path.HideSelection = false;
            this.Path.Location = new System.Drawing.Point(75, 76);
            this.Path.Name = "Path";
            this.Path.ReadOnly = true;
            this.Path.Size = new System.Drawing.Size(233, 20);
            this.Path.TabIndex = 12;
            this.Path.WordWrap = false;
            this.Path.Click += new System.EventHandler(this.Path_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ubicación de destino\r\n";
            // 
            // PathB
            // 
            this.PathB.Location = new System.Drawing.Point(12, 73);
            this.PathB.Name = "PathB";
            this.PathB.Size = new System.Drawing.Size(57, 23);
            this.PathB.TabIndex = 14;
            this.PathB.Text = "Browse";
            this.PathB.UseVisualStyleBackColor = true;
            this.PathB.Click += new System.EventHandler(this.PathB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 178);
            this.Controls.Add(this.PathB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Path);
            this.Controls.Add(this.Download);
            this.Controls.Add(this.TextoH);
            this.Controls.Add(this.URLERROR);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "HDownloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label URLERROR;
        private System.Windows.Forms.Label TextoH;
        private System.Windows.Forms.Button Download;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Path;
        private System.Windows.Forms.Button PathB;
    }
}

