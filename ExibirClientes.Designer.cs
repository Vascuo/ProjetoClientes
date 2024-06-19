namespace projClientes
{
    partial class ExibirClientes
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
            btnExibir = new Button();
            lbclientes = new ListBox();
            SuspendLayout();
            // 
            // btnExibir
            // 
            btnExibir.Location = new Point(77, 340);
            btnExibir.Name = "btnExibir";
            btnExibir.Size = new Size(204, 34);
            btnExibir.TabIndex = 0;
            btnExibir.Text = "Exibir Clientes";
            btnExibir.UseVisualStyleBackColor = true;
            btnExibir.Click += btnExibir_Click;
            // 
            // lbclientes
            // 
            lbclientes.FormattingEnabled = true;
            lbclientes.ItemHeight = 15;
            lbclientes.Location = new Point(0, 7);
            lbclientes.Name = "lbclientes";
            lbclientes.Size = new Size(390, 289);
            lbclientes.TabIndex = 1;
            // 
            // ExibirClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 450);
            Controls.Add(lbclientes);
            Controls.Add(btnExibir);
            Name = "ExibirClientes";
            Text = "ExibirClientes";
            ResumeLayout(false);
        }

        #endregion

        private Button btnExibir;
        private ListBox lbclientes;
    }
}