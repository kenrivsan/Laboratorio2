
namespace WindowsFormsApp1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.navegadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inicioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.haciaAtrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.haciaDelanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escribirAquiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnIr = new System.Windows.Forms.Button();
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navegadorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1114, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // navegadorToolStripMenuItem
            // 
            this.navegadorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem1,
            this.haciaAtrasToolStripMenuItem,
            this.haciaDelanteToolStripMenuItem,
            this.escribirAquiToolStripMenuItem});
            this.navegadorToolStripMenuItem.Name = "navegadorToolStripMenuItem";
            this.navegadorToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.navegadorToolStripMenuItem.Text = "Navegador";
            // 
            // inicioToolStripMenuItem1
            // 
            this.inicioToolStripMenuItem1.Name = "inicioToolStripMenuItem1";
            this.inicioToolStripMenuItem1.Size = new System.Drawing.Size(184, 26);
            this.inicioToolStripMenuItem1.Text = "Inicio";
            this.inicioToolStripMenuItem1.Click += new System.EventHandler(this.inicioToolStripMenuItem1_Click);
            // 
            // haciaAtrasToolStripMenuItem
            // 
            this.haciaAtrasToolStripMenuItem.Name = "haciaAtrasToolStripMenuItem";
            this.haciaAtrasToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.haciaAtrasToolStripMenuItem.Text = "Hacia atras";
            this.haciaAtrasToolStripMenuItem.Click += new System.EventHandler(this.haciaAtrasToolStripMenuItem_Click);
            // 
            // haciaDelanteToolStripMenuItem
            // 
            this.haciaDelanteToolStripMenuItem.Name = "haciaDelanteToolStripMenuItem";
            this.haciaDelanteToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.haciaDelanteToolStripMenuItem.Text = "Hacia delante";
            this.haciaDelanteToolStripMenuItem.Click += new System.EventHandler(this.haciaDelanteToolStripMenuItem_Click);
            // 
            // escribirAquiToolStripMenuItem
            // 
            this.escribirAquiToolStripMenuItem.Name = "escribirAquiToolStripMenuItem";
            this.escribirAquiToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.escribirAquiToolStripMenuItem.Text = "Escribir aqui ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "https://github.com",
            "https://www.youtube.com"});
            this.comboBox1.Location = new System.Drawing.Point(13, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(877, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // btnIr
            // 
            this.btnIr.Location = new System.Drawing.Point(915, 37);
            this.btnIr.Name = "btnIr";
            this.btnIr.Size = new System.Drawing.Size(87, 23);
            this.btnIr.TabIndex = 3;
            this.btnIr.Text = "Ir";
            this.btnIr.UseVisualStyleBackColor = true;
            this.btnIr.Click += new System.EventHandler(this.btnIr_Click);
            // 
            // webView
            // 
            this.webView.AllowExternalDrop = true;
            this.webView.CreationProperties = null;
            this.webView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView.Location = new System.Drawing.Point(13, 67);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(989, 359);
            this.webView.Source = new System.Uri("https://www.google.com", System.UriKind.Absolute);
            this.webView.TabIndex = 4;
            this.webView.ZoomFactor = 1D;
            this.webView.Click += new System.EventHandler(this.webView21_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 450);
            this.Controls.Add(this.webView);
            this.Controls.Add(this.btnIr);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Explorador Web";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem navegadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem haciaAtrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem haciaDelanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escribirAquiToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnIr;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
    }
}

