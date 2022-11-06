namespace Examen
{
    partial class SoporteForm
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
            this.SoporteDataGridView = new System.Windows.Forms.DataGridView();
            this.TipoSoporteComboBox = new System.Windows.Forms.ComboBox();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.ModificarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.CodigoTextBox = new System.Windows.Forms.TextBox();
            this.CodigoLabel = new System.Windows.Forms.Label();
            this.TipoSoporteLabel = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SoporteDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // SoporteDataGridView
            // 
            this.SoporteDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SoporteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SoporteDataGridView.Location = new System.Drawing.Point(-6, 139);
            this.SoporteDataGridView.Name = "SoporteDataGridView";
            this.SoporteDataGridView.Size = new System.Drawing.Size(716, 173);
            this.SoporteDataGridView.TabIndex = 36;
            // 
            // TipoSoporteComboBox
            // 
            this.TipoSoporteComboBox.Enabled = false;
            this.TipoSoporteComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TipoSoporteComboBox.FormattingEnabled = true;
            this.TipoSoporteComboBox.Items.AddRange(new object[] {
            "Soporte Equipo de Computo",
            "Soporte Celular"});
            this.TipoSoporteComboBox.Location = new System.Drawing.Point(267, 57);
            this.TipoSoporteComboBox.Name = "TipoSoporteComboBox";
            this.TipoSoporteComboBox.Size = new System.Drawing.Size(274, 24);
            this.TipoSoporteComboBox.TabIndex = 35;
            // 
            // CancelarButton
            // 
            this.CancelarButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelarButton.Location = new System.Drawing.Point(572, 100);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(115, 33);
            this.CancelarButton.TabIndex = 34;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.Location = new System.Drawing.Point(330, 100);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(114, 33);
            this.GuardarButton.TabIndex = 33;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarButton.Location = new System.Drawing.Point(450, 100);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(116, 33);
            this.EliminarButton.TabIndex = 32;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // ModificarButton
            // 
            this.ModificarButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ModificarButton.Location = new System.Drawing.Point(198, 100);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(126, 33);
            this.ModificarButton.TabIndex = 31;
            this.ModificarButton.Text = "Modificar";
            this.ModificarButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ModificarButton.UseVisualStyleBackColor = true;
            this.ModificarButton.Click += new System.EventHandler(this.ModificarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NuevoButton.Location = new System.Drawing.Point(85, 100);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(107, 33);
            this.NuevoButton.TabIndex = 30;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // CodigoTextBox
            // 
            this.CodigoTextBox.Enabled = false;
            this.CodigoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.CodigoTextBox.Location = new System.Drawing.Point(267, 16);
            this.CodigoTextBox.Name = "CodigoTextBox";
            this.CodigoTextBox.Size = new System.Drawing.Size(274, 22);
            this.CodigoTextBox.TabIndex = 29;
            // 
            // CodigoLabel
            // 
            this.CodigoLabel.AutoSize = true;
            this.CodigoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoLabel.Location = new System.Drawing.Point(187, 20);
            this.CodigoLabel.Name = "CodigoLabel";
            this.CodigoLabel.Size = new System.Drawing.Size(56, 18);
            this.CodigoLabel.TabIndex = 28;
            this.CodigoLabel.Text = "Codigo";
            // 
            // TipoSoporteLabel
            // 
            this.TipoSoporteLabel.AutoSize = true;
            this.TipoSoporteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoSoporteLabel.Location = new System.Drawing.Point(138, 60);
            this.TipoSoporteLabel.Name = "TipoSoporteLabel";
            this.TipoSoporteLabel.Size = new System.Drawing.Size(94, 18);
            this.TipoSoporteLabel.TabIndex = 27;
            this.TipoSoporteLabel.Text = "Tipo Soporte";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // SoporteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 305);
            this.Controls.Add(this.SoporteDataGridView);
            this.Controls.Add(this.TipoSoporteComboBox);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.ModificarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.CodigoTextBox);
            this.Controls.Add(this.CodigoLabel);
            this.Controls.Add(this.TipoSoporteLabel);
            this.Name = "SoporteForm";
            this.Text = "SoporteForm";
            this.Load += new System.EventHandler(this.SoporteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SoporteDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SoporteDataGridView;
        private System.Windows.Forms.ComboBox TipoSoporteComboBox;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button ModificarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.TextBox CodigoTextBox;
        private System.Windows.Forms.Label CodigoLabel;
        private System.Windows.Forms.Label TipoSoporteLabel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}