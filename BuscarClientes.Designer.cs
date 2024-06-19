namespace projClientes
{
    partial class BuscarClientes
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
            lblcpf = new Label();
            btnbuscar = new Button();
            txtcpf = new TextBox();
            lblnome = new Label();
            lblendereco = new Label();
            txtnome = new TextBox();
            txtendereco = new TextBox();
            btnalterar = new Button();
            btnexcluir = new Button();
            SuspendLayout();
            // 
            // lblcpf
            // 
            lblcpf.AutoSize = true;
            lblcpf.Location = new Point(12, 24);
            lblcpf.Name = "lblcpf";
            lblcpf.Size = new Size(28, 15);
            lblcpf.TabIndex = 0;
            lblcpf.Text = "CPF";
            lblcpf.Click += label1_Click;
            // 
            // btnbuscar
            // 
            btnbuscar.BackColor = SystemColors.ActiveCaption;
            btnbuscar.Location = new Point(115, 136);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(75, 23);
            btnbuscar.TabIndex = 1;
            btnbuscar.Text = "Buscar";
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // txtcpf
            // 
            txtcpf.Location = new Point(77, 21);
            txtcpf.Name = "txtcpf";
            txtcpf.Size = new Size(204, 23);
            txtcpf.TabIndex = 2;
            // 
            // lblnome
            // 
            lblnome.AutoSize = true;
            lblnome.Location = new Point(12, 61);
            lblnome.Name = "lblnome";
            lblnome.Size = new Size(43, 15);
            lblnome.TabIndex = 3;
            lblnome.Text = "Nome:";
            // 
            // lblendereco
            // 
            lblendereco.AutoSize = true;
            lblendereco.Location = new Point(12, 99);
            lblendereco.Name = "lblendereco";
            lblendereco.Size = new Size(59, 15);
            lblendereco.TabIndex = 4;
            lblendereco.Text = "Endereço:";
            // 
            // txtnome
            // 
            txtnome.Location = new Point(77, 58);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(204, 23);
            txtnome.TabIndex = 5;
            // 
            // txtendereco
            // 
            txtendereco.Location = new Point(77, 91);
            txtendereco.Name = "txtendereco";
            txtendereco.Size = new Size(204, 23);
            txtendereco.TabIndex = 6;
            // 
            // btnalterar
            // 
            btnalterar.Location = new Point(12, 136);
            btnalterar.Name = "btnalterar";
            btnalterar.Size = new Size(75, 23);
            btnalterar.TabIndex = 7;
            btnalterar.Text = "Alterar";
            btnalterar.UseVisualStyleBackColor = true;
            btnalterar.Click += btnalterar_Click;
            // 
            // btnexcluir
            // 
            btnexcluir.Location = new Point(215, 136);
            btnexcluir.Name = "btnexcluir";
            btnexcluir.Size = new Size(75, 23);
            btnexcluir.TabIndex = 8;
            btnexcluir.Text = "Excluir";
            btnexcluir.UseVisualStyleBackColor = true;
            btnexcluir.Click += btnexcluir_Click;
            // 
            // BuscarClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(305, 180);
            Controls.Add(btnexcluir);
            Controls.Add(btnalterar);
            Controls.Add(txtendereco);
            Controls.Add(txtnome);
            Controls.Add(lblendereco);
            Controls.Add(lblnome);
            Controls.Add(txtcpf);
            Controls.Add(btnbuscar);
            Controls.Add(lblcpf);
            Name = "BuscarClientes";
            Text = "BuscarClientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblcpf;
        private Button btnbuscar;
        private TextBox txtcpf;
        private Label lblnome;
        private Label lblendereco;
        private TextBox txtnome;
        private TextBox txtendereco;
        private Button btnalterar;
        private Button btnexcluir;
    }
}