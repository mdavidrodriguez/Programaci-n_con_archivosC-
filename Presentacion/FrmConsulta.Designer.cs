namespace Presentacion
{
    partial class FrmConsulta
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
            this.grilladeempleados = new System.Windows.Forms.DataGridView();
            this.txtbuscadoempleado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Dtp1 = new System.Windows.Forms.DateTimePicker();
            this.Cmb1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grilladeempleados)).BeginInit();
            this.SuspendLayout();
            // 
            // grilladeempleados
            // 
            this.grilladeempleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilladeempleados.Location = new System.Drawing.Point(91, 184);
            this.grilladeempleados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grilladeempleados.Name = "grilladeempleados";
            this.grilladeempleados.RowHeadersWidth = 51;
            this.grilladeempleados.Size = new System.Drawing.Size(907, 290);
            this.grilladeempleados.TabIndex = 0;
            // 
            // txtbuscadoempleado
            // 
            this.txtbuscadoempleado.Location = new System.Drawing.Point(164, 66);
            this.txtbuscadoempleado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbuscadoempleado.Name = "txtbuscadoempleado";
            this.txtbuscadoempleado.Size = new System.Drawing.Size(132, 22);
            this.txtbuscadoempleado.TabIndex = 1;
            this.txtbuscadoempleado.TextChanged += new System.EventHandler(this.txtbuscadoempleado_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar:";
            // 
            // Dtp1
            // 
            this.Dtp1.Location = new System.Drawing.Point(434, 72);
            this.Dtp1.Name = "Dtp1";
            this.Dtp1.Size = new System.Drawing.Size(200, 22);
            this.Dtp1.TabIndex = 3;
            // 
            // Cmb1
            // 
            this.Cmb1.FormattingEnabled = true;
            this.Cmb1.Items.AddRange(new object[] {
            "Todos",
            "F",
            "M"});
            this.Cmb1.Location = new System.Drawing.Point(750, 70);
            this.Cmb1.Name = "Cmb1";
            this.Cmb1.Size = new System.Drawing.Size(121, 24);
            this.Cmb1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(434, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(750, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Cmb1);
            this.Controls.Add(this.Dtp1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbuscadoempleado);
            this.Controls.Add(this.grilladeempleados);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmConsulta";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilladeempleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grilladeempleados;
        private System.Windows.Forms.TextBox txtbuscadoempleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Dtp1;
        private System.Windows.Forms.ComboBox Cmb1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}