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
            this.CancelarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.ModificarButton = new System.Windows.Forms.Button();
            this.CodigoTextBox = new System.Windows.Forms.TextBox();
            this.CodigoLabel = new System.Windows.Forms.Label();
            this.TipoSoporteLabel = new System.Windows.Forms.Label();
            this.TipoSoporteComboBox = new System.Windows.Forms.ComboBox();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.SoporteDataGridView = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SoporteDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelarButton
            // 
            this.CancelarButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelarButton.Location = new System.Drawing.Point(497, 110);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(115, 33);
            this.CancelarButton.TabIndex = 24;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.Location = new System.Drawing.Point(255, 110);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(114, 33);
            this.GuardarButton.TabIndex = 23;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarButton.Location = new System.Drawing.Point(375, 110);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(116, 33);
            this.EliminarButton.TabIndex = 22;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // ModificarButton
            // 
            this.ModificarButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ModificarButton.Location = new System.Drawing.Point(123, 110);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(126, 33);
            this.ModificarButton.TabIndex = 21;
            this.ModificarButton.Text = "Modificar";
            this.ModificarButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ModificarButton.UseVisualStyleBackColor = true;
            this.ModificarButton.Click += new System.EventHandler(this.ModificarButton_Click);
            // 
            // CodigoTextBox
            // 
            this.CodigoTextBox.Enabled = false;
            this.CodigoTextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoTextBox.Location = new System.Drawing.Point(177, 27);
            this.CodigoTextBox.Name = "CodigoTextBox";
            this.CodigoTextBox.Size = new System.Drawing.Size(274, 22);
            this.CodigoTextBox.TabIndex = 19;
            // 
            // CodigoLabel
            // 
            this.CodigoLabel.AutoSize = true;
            this.CodigoLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoLabel.Location = new System.Drawing.Point(97, 31);
            this.CodigoLabel.Name = "CodigoLabel";
            this.CodigoLabel.Size = new System.Drawing.Size(47, 16);
            this.CodigoLabel.TabIndex = 17;
            this.CodigoLabel.Text = "Codigo";
            // 
            // TipoSoporteLabel
            // 
            this.TipoSoporteLabel.AutoSize = true;
            this.TipoSoporteLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoSoporteLabel.Location = new System.Drawing.Point(48, 71);
            this.TipoSoporteLabel.Name = "TipoSoporteLabel";
            this.TipoSoporteLabel.Size = new System.Drawing.Size(80, 16);
            this.TipoSoporteLabel.TabIndex = 16;
            this.TipoSoporteLabel.Text = "Tipo Soporte";
            // 
            // TipoSoporteComboBox
            // 
            this.TipoSoporteComboBox.Enabled = false;
            this.TipoSoporteComboBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoSoporteComboBox.FormattingEnabled = true;
            this.TipoSoporteComboBox.Items.AddRange(new object[] {
            "Soporte Equipo De Computo",
            "Soporte De Reparacion De Celular"});
            this.TipoSoporteComboBox.Location = new System.Drawing.Point(177, 68);
            this.TipoSoporteComboBox.Name = "TipoSoporteComboBox";
            this.TipoSoporteComboBox.Size = new System.Drawing.Size(274, 24);
            this.TipoSoporteComboBox.TabIndex = 25;
            // 
            // NuevoButton
            // 
            this.NuevoButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NuevoButton.Location = new System.Drawing.Point(10, 110);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(107, 33);
            this.NuevoButton.TabIndex = 20;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // SoporteDataGridView
            // 
            this.SoporteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SoporteDataGridView.Location = new System.Drawing.Point(1, 150);
            this.SoporteDataGridView.Name = "SoporteDataGridView";
            this.SoporteDataGridView.Size = new System.Drawing.Size(619, 150);
            this.SoporteDataGridView.TabIndex = 26;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // SoporteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 300);
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
            this.Text = "Soporte";
            this.Load += new System.EventHandler(this.SoporteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SoporteDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button ModificarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.TextBox CodigoTextBox;
        private System.Windows.Forms.Label CodigoLabel;
        private System.Windows.Forms.Label TipoSoporteLabel;
        private System.Windows.Forms.ComboBox TipoSoporteComboBox;
        private System.Windows.Forms.DataGridView SoporteDataGridView;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}