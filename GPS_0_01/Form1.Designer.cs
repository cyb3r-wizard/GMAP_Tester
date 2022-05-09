﻿namespace GPS_0_01
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
            this.gmpVisor = new GMap.NET.WindowsForms.GMapControl();
            this.btnCargarMapa = new System.Windows.Forms.Button();
            this.txbLatitud = new System.Windows.Forms.TextBox();
            this.txbLongitud = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gmpVisor
            // 
            this.gmpVisor.Bearing = 0F;
            this.gmpVisor.CanDragMap = true;
            this.gmpVisor.Cursor = System.Windows.Forms.Cursors.Cross;
            this.gmpVisor.EmptyTileColor = System.Drawing.Color.LightGreen;
            this.gmpVisor.GrayScaleMode = false;
            this.gmpVisor.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmpVisor.LevelsKeepInMemory = 5;
            this.gmpVisor.Location = new System.Drawing.Point(13, 13);
            this.gmpVisor.MarkersEnabled = true;
            this.gmpVisor.MaxZoom = 18;
            this.gmpVisor.MinZoom = 0;
            this.gmpVisor.MouseWheelZoomEnabled = true;
            this.gmpVisor.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmpVisor.Name = "gmpVisor";
            this.gmpVisor.NegativeMode = false;
            this.gmpVisor.PolygonsEnabled = true;
            this.gmpVisor.RetryLoadTile = 0;
            this.gmpVisor.RoutesEnabled = true;
            this.gmpVisor.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmpVisor.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmpVisor.ShowTileGridLines = false;
            this.gmpVisor.Size = new System.Drawing.Size(566, 425);
            this.gmpVisor.TabIndex = 0;
            this.gmpVisor.Zoom = 0D;
            // 
            // btnCargarMapa
            // 
            this.btnCargarMapa.Location = new System.Drawing.Point(627, 64);
            this.btnCargarMapa.Name = "btnCargarMapa";
            this.btnCargarMapa.Size = new System.Drawing.Size(120, 23);
            this.btnCargarMapa.TabIndex = 1;
            this.btnCargarMapa.Text = "Cargar Mapa";
            this.btnCargarMapa.UseVisualStyleBackColor = true;
            this.btnCargarMapa.Click += new System.EventHandler(this.btnCargarMapa_Click);
            // 
            // txbLatitud
            // 
            this.txbLatitud.Location = new System.Drawing.Point(627, 12);
            this.txbLatitud.Name = "txbLatitud";
            this.txbLatitud.Size = new System.Drawing.Size(119, 20);
            this.txbLatitud.TabIndex = 2;
            // 
            // txbLongitud
            // 
            this.txbLongitud.Location = new System.Drawing.Point(627, 38);
            this.txbLongitud.Name = "txbLongitud";
            this.txbLongitud.Size = new System.Drawing.Size(119, 20);
            this.txbLongitud.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(591, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "LAT:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(581, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "LONG:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbLongitud);
            this.Controls.Add(this.txbLatitud);
            this.Controls.Add(this.btnCargarMapa);
            this.Controls.Add(this.gmpVisor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gmpVisor;
        private System.Windows.Forms.Button btnCargarMapa;
        private System.Windows.Forms.TextBox txbLatitud;
        private System.Windows.Forms.TextBox txbLongitud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

