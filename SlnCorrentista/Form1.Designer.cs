namespace SlnCorrentista
{
    partial class frmCorrentista
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnCadastrar = new Button();
            label2 = new Label();
            txtId = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNome = new TextBox();
            txtCpf = new TextBox();
            txtRendaMensal = new TextBox();
            dtpDataNascimento = new DateTimePicker();
            btnVerCorrentista1 = new Button();
            btnVerCorrentista2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(235, 31);
            label1.Name = "label1";
            label1.Size = new Size(43, 37);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastrar.Location = new Point(641, 341);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(153, 47);
            btnCadastrar.TabIndex = 1;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(188, 91);
            label2.Name = "label2";
            label2.Size = new Size(90, 37);
            label2.TabIndex = 2;
            label2.Text = "Nome";
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(296, 28);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 43);
            txtId.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(220, 151);
            label3.Name = "label3";
            label3.Size = new Size(58, 37);
            label3.TabIndex = 4;
            label3.Text = "Cpf";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(20, 211);
            label4.Name = "label4";
            label4.Size = new Size(258, 37);
            label4.TabIndex = 5;
            label4.Text = "Data de Nascimento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(41, 271);
            label5.Name = "label5";
            label5.Size = new Size(237, 37);
            label5.TabIndex = 6;
            label5.Text = "Renda Mensal (R$)";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(296, 88);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(498, 43);
            txtNome.TabIndex = 7;
            // 
            // txtCpf
            // 
            txtCpf.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtCpf.Location = new Point(296, 148);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(498, 43);
            txtCpf.TabIndex = 8;
            // 
            // txtRendaMensal
            // 
            txtRendaMensal.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtRendaMensal.Location = new Point(296, 268);
            txtRendaMensal.Name = "txtRendaMensal";
            txtRendaMensal.Size = new Size(498, 43);
            txtRendaMensal.TabIndex = 9;
            // 
            // dtpDataNascimento
            // 
            dtpDataNascimento.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDataNascimento.Location = new Point(296, 208);
            dtpDataNascimento.Name = "dtpDataNascimento";
            dtpDataNascimento.Size = new Size(498, 43);
            dtpDataNascimento.TabIndex = 10;
            // 
            // btnVerCorrentista1
            // 
            btnVerCorrentista1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnVerCorrentista1.Location = new Point(20, 341);
            btnVerCorrentista1.Name = "btnVerCorrentista1";
            btnVerCorrentista1.Size = new Size(228, 47);
            btnVerCorrentista1.TabIndex = 11;
            btnVerCorrentista1.Text = "Ver Correntista 1";
            btnVerCorrentista1.UseVisualStyleBackColor = true;
            btnVerCorrentista1.Visible = false;
            btnVerCorrentista1.Click += btnVerCorrentista1_Click;
            // 
            // btnVerCorrentista2
            // 
            btnVerCorrentista2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnVerCorrentista2.Location = new Point(254, 341);
            btnVerCorrentista2.Name = "btnVerCorrentista2";
            btnVerCorrentista2.Size = new Size(222, 47);
            btnVerCorrentista2.TabIndex = 12;
            btnVerCorrentista2.Text = "Ver Correntista 2";
            btnVerCorrentista2.UseVisualStyleBackColor = true;
            btnVerCorrentista2.Visible = false;
            btnVerCorrentista2.Click += btnVerCorrentista2_Click;
            // 
            // frmCorrentista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 421);
            Controls.Add(btnVerCorrentista2);
            Controls.Add(btnVerCorrentista1);
            Controls.Add(dtpDataNascimento);
            Controls.Add(txtRendaMensal);
            Controls.Add(txtCpf);
            Controls.Add(txtNome);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(btnCadastrar);
            Controls.Add(label1);
            Name = "frmCorrentista";
            Text = "Cadastro Correntista";
            Load += frmCorrentista_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCadastrar;
        private Label label2;
        private TextBox txtId;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNome;
        private TextBox txtCpf;
        private TextBox txtRendaMensal;
        private DateTimePicker dtpDataNascimento;
        private Button btnVerCorrentista1;
        private Button btnVerCorrentista2;
    }
}