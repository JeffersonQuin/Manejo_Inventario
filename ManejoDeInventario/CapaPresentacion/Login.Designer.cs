﻿namespace CapaPresentacion
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.txtdocumento = new System.Windows.Forms.TextBox();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btmingresar = new FontAwesome.Sharp.IconButton();
            this.btmcancelar = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(196)))), ((int)(((byte)(12)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 193);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(196)))), ((int)(((byte)(12)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "MANEJO DE INVENTARIO";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(196)))), ((int)(((byte)(12)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Black;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Warehouse;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Black;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 143;
            this.iconPictureBox1.Location = new System.Drawing.Point(31, 21);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(144, 143);
            this.iconPictureBox1.TabIndex = 2;
            this.iconPictureBox1.TabStop = false;
            // 
            // txtdocumento
            // 
            this.txtdocumento.BackColor = System.Drawing.Color.DarkGray;
            this.txtdocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdocumento.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtdocumento.Location = new System.Drawing.Point(234, 57);
            this.txtdocumento.Name = "txtdocumento";
            this.txtdocumento.Size = new System.Drawing.Size(209, 20);
            this.txtdocumento.TabIndex = 3;
            // 
            // txtclave
            // 
            this.txtclave.BackColor = System.Drawing.Color.DarkGray;
            this.txtclave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtclave.Location = new System.Drawing.Point(234, 98);
            this.txtclave.Name = "txtclave";
            this.txtclave.PasswordChar = '*';
            this.txtclave.Size = new System.Drawing.Size(209, 20);
            this.txtclave.TabIndex = 4;
            this.txtclave.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(231, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nro Documento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(231, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Contraseña:";
            // 
            // btmingresar
            // 
            this.btmingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(196)))), ((int)(((byte)(12)))));
            this.btmingresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmingresar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btmingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmingresar.ForeColor = System.Drawing.Color.Black;
            this.btmingresar.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.btmingresar.IconColor = System.Drawing.Color.Black;
            this.btmingresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btmingresar.IconSize = 18;
            this.btmingresar.Location = new System.Drawing.Point(252, 141);
            this.btmingresar.Name = "btmingresar";
            this.btmingresar.Size = new System.Drawing.Size(89, 23);
            this.btmingresar.TabIndex = 7;
            this.btmingresar.Text = "Ingresar";
            this.btmingresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btmingresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btmingresar.UseVisualStyleBackColor = false;
            this.btmingresar.Click += new System.EventHandler(this.btmingresar_Click);
            // 
            // btmcancelar
            // 
            this.btmcancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(196)))), ((int)(((byte)(12)))));
            this.btmcancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmcancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btmcancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmcancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmcancelar.ForeColor = System.Drawing.Color.Black;
            this.btmcancelar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btmcancelar.IconColor = System.Drawing.Color.Black;
            this.btmcancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btmcancelar.IconSize = 18;
            this.btmcancelar.Location = new System.Drawing.Point(347, 141);
            this.btmcancelar.Name = "btmcancelar";
            this.btmcancelar.Size = new System.Drawing.Size(89, 23);
            this.btmcancelar.TabIndex = 8;
            this.btmcancelar.Text = "Cancelar";
            this.btmcancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btmcancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btmcancelar.UseVisualStyleBackColor = false;
            this.btmcancelar.Click += new System.EventHandler(this.btmcancelar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(316, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "LOGIN";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(37)))), ((int)(((byte)(122)))));
            this.BackgroundImage = global::CapaPresentacion.Properties.Resources.preview;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(471, 193);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btmcancelar);
            this.Controls.Add(this.btmingresar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.txtdocumento);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.TextBox txtdocumento;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btmingresar;
        private FontAwesome.Sharp.IconButton btmcancelar;
        private System.Windows.Forms.Label label5;
    }
}