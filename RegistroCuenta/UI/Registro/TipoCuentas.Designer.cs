﻿namespace RegistroCuenta.UI.Registro
{
    partial class TipoCuentas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button NuevoButton;
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.TipoIDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.errorProviderTipo = new System.Windows.Forms.ErrorProvider(this.components);
            NuevoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TipoIDnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTipo)).BeginInit();
            this.SuspendLayout();
            // 
            // NuevoButton
            // 
            NuevoButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            NuevoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            NuevoButton.Location = new System.Drawing.Point(18, 117);
            NuevoButton.Margin = new System.Windows.Forms.Padding(2);
            NuevoButton.Name = "NuevoButton";
            NuevoButton.Size = new System.Drawing.Size(56, 42);
            NuevoButton.TabIndex = 49;
            NuevoButton.Text = "Nuevo";
            NuevoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            NuevoButton.UseVisualStyleBackColor = true;
            NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click_1);
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Location = new System.Drawing.Point(77, 62);
            this.DescripciontextBox.Margin = new System.Windows.Forms.Padding(2);
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(162, 20);
            this.DescripciontextBox.TabIndex = 55;
            this.DescripciontextBox.TextChanged += new System.EventHandler(this.DescripciontextBox_TextChanged);
            // 
            // TipoIDnumericUpDown
            // 
            this.TipoIDnumericUpDown.Location = new System.Drawing.Point(77, 38);
            this.TipoIDnumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.TipoIDnumericUpDown.Name = "TipoIDnumericUpDown";
            this.TipoIDnumericUpDown.Size = new System.Drawing.Size(90, 20);
            this.TipoIDnumericUpDown.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Tipo ID";
            // 
            // EliminarButton
            // 
            this.EliminarButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.EliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.Location = new System.Drawing.Point(188, 117);
            this.EliminarButton.Margin = new System.Windows.Forms.Padding(2);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(65, 42);
            this.EliminarButton.TabIndex = 51;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click_1);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarButton.Location = new System.Drawing.Point(100, 117);
            this.GuardarButton.Margin = new System.Windows.Forms.Padding(2);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(67, 42);
            this.GuardarButton.TabIndex = 50;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click_1);
            // 
            // BuscarButton
            // 
            this.BuscarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BuscarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarButton.Location = new System.Drawing.Point(172, 29);
            this.BuscarButton.Margin = new System.Windows.Forms.Padding(2);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(51, 27);
            this.BuscarButton.TabIndex = 48;
            this.BuscarButton.Text = "buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click_1);
            // 
            // errorProviderTipo
            // 
            this.errorProviderTipo.ContainerControl = this;
            // 
            // TipoCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(299, 236);
            this.Controls.Add(this.DescripciontextBox);
            this.Controls.Add(this.TipoIDnumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(NuevoButton);
            this.Controls.Add(this.BuscarButton);
            this.Name = "TipoCuentas";
            this.Text = "TipoCuentas";
            ((System.ComponentModel.ISupportInitialize)(this.TipoIDnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DescripciontextBox;
        private System.Windows.Forms.NumericUpDown TipoIDnumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.ErrorProvider errorProviderTipo;
    }
}