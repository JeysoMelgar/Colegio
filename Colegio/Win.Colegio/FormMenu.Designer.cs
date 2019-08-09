using System;

namespace Win.Colegio
{
    partial class FormMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.matriculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encargadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesDeAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeEncargadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeDocentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matriculaToolStripMenuItem,
            this.encargadoToolStripMenuItem,
            this.seguridadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(871, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // matriculaToolStripMenuItem
            // 
            this.matriculaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnoToolStripMenuItem,
            this.notasToolStripMenuItem,
            this.docentesToolStripMenuItem});
            this.matriculaToolStripMenuItem.Name = "matriculaToolStripMenuItem";
            this.matriculaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.matriculaToolStripMenuItem.Text = "Matricula";
            // 
            // alumnoToolStripMenuItem
            // 
            this.alumnoToolStripMenuItem.Name = "alumnoToolStripMenuItem";
            this.alumnoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.alumnoToolStripMenuItem.Text = "Alumnos";
            this.alumnoToolStripMenuItem.Click += new System.EventHandler(this.alumnoToolStripMenuItem_Click);
            // 
            // notasToolStripMenuItem
            // 
            this.notasToolStripMenuItem.Name = "notasToolStripMenuItem";
            this.notasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.notasToolStripMenuItem.Text = "Notas";
            // 
            // encargadoToolStripMenuItem
            // 
            this.encargadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesDeAlumnosToolStripMenuItem,
            this.reporteDeEncargadosToolStripMenuItem,
            this.reporteDeNotasToolStripMenuItem,
            this.reporteDeDocentesToolStripMenuItem});
            this.encargadoToolStripMenuItem.Name = "encargadoToolStripMenuItem";
            this.encargadoToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.encargadoToolStripMenuItem.Text = "Reportes";
            // 
            // reportesDeAlumnosToolStripMenuItem
            // 
            this.reportesDeAlumnosToolStripMenuItem.Name = "reportesDeAlumnosToolStripMenuItem";
            this.reportesDeAlumnosToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.reportesDeAlumnosToolStripMenuItem.Text = "Reportes de Alumnos";
            // 
            // reporteDeEncargadosToolStripMenuItem
            // 
            this.reporteDeEncargadosToolStripMenuItem.Name = "reporteDeEncargadosToolStripMenuItem";
            this.reporteDeEncargadosToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.reporteDeEncargadosToolStripMenuItem.Text = "Reporte de Encargados";
            // 
            // reporteDeNotasToolStripMenuItem
            // 
            this.reporteDeNotasToolStripMenuItem.Name = "reporteDeNotasToolStripMenuItem";
            this.reporteDeNotasToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.reporteDeNotasToolStripMenuItem.Text = "Reporte de Notas";
            // 
            // reporteDeDocentesToolStripMenuItem
            // 
            this.reporteDeDocentesToolStripMenuItem.Name = "reporteDeDocentesToolStripMenuItem";
            this.reporteDeDocentesToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.reporteDeDocentesToolStripMenuItem.Text = "Reporte de Docentes";
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem});
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click_1);
            // 
            // docentesToolStripMenuItem
            // 
            this.docentesToolStripMenuItem.Name = "docentesToolStripMenuItem";
            this.docentesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.docentesToolStripMenuItem.Text = "Docentes";
            this.docentesToolStripMenuItem.Click += new System.EventHandler(this.docentesToolStripMenuItem_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 366);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenu";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem matriculaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encargadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesDeAlumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeEncargadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeNotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeDocentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem docentesToolStripMenuItem;
    }
}