namespace CapaPresentacion
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.panelMenuLeft = new System.Windows.Forms.Panel();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.BSalir = new System.Windows.Forms.Button();
            this.BReportes = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.BVentas = new System.Windows.Forms.Button();
            this.BCompras = new System.Windows.Forms.Button();
            this.BClientes = new System.Windows.Forms.Button();
            this.BProductos = new System.Windows.Forms.Button();
            this.BUsuarios = new System.Windows.Forms.Button();
            this.panelAvatar = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BEditarPerfil = new System.Windows.Forms.Button();
            this.PBAvatar = new System.Windows.Forms.PictureBox();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.panelMostrarFormu = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.LTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenuLeft.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.panelAvatar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBAvatar)).BeginInit();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenuLeft
            // 
            this.panelMenuLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.panelMenuLeft.Controls.Add(this.panelBotones);
            this.panelMenuLeft.Controls.Add(this.panelAvatar);
            this.panelMenuLeft.Location = new System.Drawing.Point(0, 0);
            this.panelMenuLeft.Name = "panelMenuLeft";
            this.panelMenuLeft.Size = new System.Drawing.Size(274, 680);
            this.panelMenuLeft.TabIndex = 0;
            // 
            // panelBotones
            // 
            this.panelBotones.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelBotones.Controls.Add(this.BSalir);
            this.panelBotones.Controls.Add(this.BReportes);
            this.panelBotones.Controls.Add(this.button6);
            this.panelBotones.Controls.Add(this.BVentas);
            this.panelBotones.Controls.Add(this.BCompras);
            this.panelBotones.Controls.Add(this.BClientes);
            this.panelBotones.Controls.Add(this.BProductos);
            this.panelBotones.Controls.Add(this.BUsuarios);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBotones.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelBotones.Location = new System.Drawing.Point(0, 246);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(274, 434);
            this.panelBotones.TabIndex = 1;
            // 
            // BSalir
            // 
            this.BSalir.Image = global::CapaPresentacion.Properties.Resources.salir_alt;
            this.BSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BSalir.Location = new System.Drawing.Point(0, 372);
            this.BSalir.Name = "BSalir";
            this.BSalir.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BSalir.Size = new System.Drawing.Size(274, 44);
            this.BSalir.TabIndex = 8;
            this.BSalir.Text = "Exit";
            this.BSalir.UseVisualStyleBackColor = true;
            this.BSalir.Click += new System.EventHandler(this.button8_Click);
            // 
            // BReportes
            // 
            this.BReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BReportes.Image = global::CapaPresentacion.Properties.Resources.chat_flecha_crecer;
            this.BReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BReportes.Location = new System.Drawing.Point(0, 271);
            this.BReportes.Name = "BReportes";
            this.BReportes.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BReportes.Size = new System.Drawing.Size(274, 45);
            this.BReportes.TabIndex = 2;
            this.BReportes.Text = "Reportes";
            this.BReportes.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.Image = global::CapaPresentacion.Properties.Resources.lado_del_camion;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(0, 227);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(274, 44);
            this.button6.TabIndex = 6;
            this.button6.Text = "Proveedores";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // BVentas
            // 
            this.BVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BVentas.Image = global::CapaPresentacion.Properties.Resources.usd_circulo1;
            this.BVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BVentas.Location = new System.Drawing.Point(0, 183);
            this.BVentas.Name = "BVentas";
            this.BVentas.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BVentas.Size = new System.Drawing.Size(274, 44);
            this.BVentas.TabIndex = 4;
            this.BVentas.Text = "Ventas";
            this.BVentas.UseVisualStyleBackColor = true;
            // 
            // BCompras
            // 
            this.BCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.BCompras.Image = global::CapaPresentacion.Properties.Resources.carrito_de_compras;
            this.BCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BCompras.Location = new System.Drawing.Point(0, 139);
            this.BCompras.Name = "BCompras";
            this.BCompras.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BCompras.Size = new System.Drawing.Size(274, 44);
            this.BCompras.TabIndex = 5;
            this.BCompras.Text = "Compras";
            this.BCompras.UseVisualStyleBackColor = true;
            // 
            // BClientes
            // 
            this.BClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BClientes.Image = global::CapaPresentacion.Properties.Resources.usuarios_alt;
            this.BClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BClientes.Location = new System.Drawing.Point(0, 95);
            this.BClientes.Name = "BClientes";
            this.BClientes.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BClientes.Size = new System.Drawing.Size(274, 44);
            this.BClientes.TabIndex = 7;
            this.BClientes.Text = "Clientes";
            this.BClientes.UseVisualStyleBackColor = true;
            // 
            // BProductos
            // 
            this.BProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BProductos.Image = global::CapaPresentacion.Properties.Resources.tienda;
            this.BProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BProductos.Location = new System.Drawing.Point(0, 51);
            this.BProductos.Name = "BProductos";
            this.BProductos.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BProductos.Size = new System.Drawing.Size(274, 44);
            this.BProductos.TabIndex = 1;
            this.BProductos.Text = "Productos";
            this.BProductos.UseVisualStyleBackColor = true;
            this.BProductos.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // BUsuarios
            // 
            this.BUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.BUsuarios.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUsuarios.Image = global::CapaPresentacion.Properties.Resources.usuario1;
            this.BUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BUsuarios.Location = new System.Drawing.Point(0, 0);
            this.BUsuarios.Name = "BUsuarios";
            this.BUsuarios.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BUsuarios.Size = new System.Drawing.Size(274, 51);
            this.BUsuarios.TabIndex = 3;
            this.BUsuarios.Text = "Usuarios";
            this.BUsuarios.UseVisualStyleBackColor = true;
            this.BUsuarios.Click += new System.EventHandler(this.button3_Click);
            // 
            // panelAvatar
            // 
            this.panelAvatar.BackColor = System.Drawing.Color.Black;
            this.panelAvatar.Controls.Add(this.label3);
            this.panelAvatar.Controls.Add(this.label2);
            this.panelAvatar.Controls.Add(this.BEditarPerfil);
            this.panelAvatar.Controls.Add(this.PBAvatar);
            this.panelAvatar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAvatar.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelAvatar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.panelAvatar.Location = new System.Drawing.Point(0, 0);
            this.panelAvatar.Name = "panelAvatar";
            this.panelAvatar.Size = new System.Drawing.Size(274, 246);
            this.panelAvatar.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(164, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Correo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(164, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rol";
            // 
            // BEditarPerfil
            // 
            this.BEditarPerfil.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEditarPerfil.Location = new System.Drawing.Point(29, 195);
            this.BEditarPerfil.Name = "BEditarPerfil";
            this.BEditarPerfil.Size = new System.Drawing.Size(216, 32);
            this.BEditarPerfil.TabIndex = 1;
            this.BEditarPerfil.Text = "Editar Perfil";
            this.BEditarPerfil.UseVisualStyleBackColor = true;
            this.BEditarPerfil.Click += new System.EventHandler(this.button1_Click);
            // 
            // PBAvatar
            // 
            this.PBAvatar.Image = global::CapaPresentacion.Properties.Resources.mujer;
            this.PBAvatar.Location = new System.Drawing.Point(29, 50);
            this.PBAvatar.Name = "PBAvatar";
            this.PBAvatar.Size = new System.Drawing.Size(106, 117);
            this.PBAvatar.TabIndex = 0;
            this.PBAvatar.TabStop = false;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelTitulo.Controls.Add(this.panelMostrarFormu);
            this.panelTitulo.Controls.Add(this.pictureBox3);
            this.panelTitulo.Controls.Add(this.LTitulo);
            this.panelTitulo.Controls.Add(this.pictureBox1);
            this.panelTitulo.Location = new System.Drawing.Point(272, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(925, 100);
            this.panelTitulo.TabIndex = 1;
            // 
            // panelMostrarFormu
            // 
            this.panelMostrarFormu.Location = new System.Drawing.Point(3, 106);
            this.panelMostrarFormu.Name = "panelMostrarFormu";
            this.panelMostrarFormu.Size = new System.Drawing.Size(907, 556);
            this.panelMostrarFormu.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CapaPresentacion.Properties.Resources.logo;
            this.pictureBox3.ImageLocation = "";
            this.pictureBox3.Location = new System.Drawing.Point(751, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(85, 85);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LTitulo.Location = new System.Drawing.Point(185, 41);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(280, 25);
            this.LTitulo.TabIndex = 1;
            this.LTitulo.Text = "Gestión de Sistemas de Ventas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(985, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 86);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelMenuLeft);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(960, 480);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Infinite Tienda";
            this.panelMenuLeft.ResumeLayout(false);
            this.panelBotones.ResumeLayout(false);
            this.panelAvatar.ResumeLayout(false);
            this.panelAvatar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBAvatar)).EndInit();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuLeft;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Panel panelAvatar;
        private System.Windows.Forms.PictureBox PBAvatar;
        private System.Windows.Forms.Button BEditarPerfil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BCompras;
        private System.Windows.Forms.Button BVentas;
        private System.Windows.Forms.Button BUsuarios;
        private System.Windows.Forms.Button BReportes;
        private System.Windows.Forms.Button BProductos;
        private System.Windows.Forms.Button BClientes;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button BSalir;
        private System.Windows.Forms.Panel panelMostrarFormu;
    }
}