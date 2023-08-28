namespace PacienteCadastroFinal.telas
{
    partial class CadastroPaciente
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
            tx_data = new MaskedTextBox();
            tx_sexo = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            button1 = new Button();
            bt_cadastrar = new Button();
            bt_excluir = new Button();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            tx_rg = new TextBox();
            tx_cpf = new MaskedTextBox();
            tx_telefone = new MaskedTextBox();
            tx_nome = new TextBox();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tx_data
            // 
            tx_data.Location = new Point(356, 187);
            tx_data.Mask = "00/00/0000";
            tx_data.Name = "tx_data";
            tx_data.Size = new Size(107, 23);
            tx_data.TabIndex = 63;
            // 
            // tx_sexo
            // 
            tx_sexo.DropDownStyle = ComboBoxStyle.DropDownList;
            tx_sexo.FormattingEnabled = true;
            tx_sexo.Items.AddRange(new object[] { "Masculino", "Feminino", "Outro" });
            tx_sexo.Location = new Point(71, 223);
            tx_sexo.Name = "tx_sexo";
            tx_sexo.Size = new Size(121, 23);
            tx_sexo.TabIndex = 62;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(30, 231);
            label10.Name = "label10";
            label10.Size = new Size(35, 15);
            label10.TabIndex = 61;
            label10.Text = "Sexo:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(116, 20);
            label9.Name = "label9";
            label9.Size = new Size(316, 47);
            label9.TabIndex = 60;
            label9.Text = "Cadastro Paciente";
            // 
            // button1
            // 
            button1.Location = new Point(34, 289);
            button1.Name = "button1";
            button1.Size = new Size(89, 38);
            button1.TabIndex = 59;
            button1.Text = "NOVO";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // bt_cadastrar
            // 
            bt_cadastrar.Location = new Point(150, 289);
            bt_cadastrar.Name = "bt_cadastrar";
            bt_cadastrar.Size = new Size(89, 38);
            bt_cadastrar.TabIndex = 58;
            bt_cadastrar.Text = "CADASTRAR";
            bt_cadastrar.UseVisualStyleBackColor = true;
            bt_cadastrar.Click += bt_cadastrar_Click;
            // 
            // bt_excluir
            // 
            bt_excluir.Location = new Point(261, 289);
            bt_excluir.Name = "bt_excluir";
            bt_excluir.Size = new Size(89, 38);
            bt_excluir.TabIndex = 57;
            bt_excluir.Text = "EXCLUIR";
            bt_excluir.UseVisualStyleBackColor = true;
            bt_excluir.Click += bt_excluir_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(249, 190);
            label7.Name = "label7";
            label7.Size = new Size(101, 15);
            label7.TabIndex = 55;
            label7.Text = "Data Nascimento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(325, 149);
            label6.Name = "label6";
            label6.Size = new Size(25, 15);
            label6.TabIndex = 54;
            label6.Text = "RG:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 149);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 53;
            label4.Text = "CPF:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 190);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 52;
            label2.Text = "Celular:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 111);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 51;
            label1.Text = "Nome:";
            // 
            // tx_rg
            // 
            tx_rg.Location = new Point(356, 144);
            tx_rg.Name = "tx_rg";
            tx_rg.Size = new Size(107, 23);
            tx_rg.TabIndex = 49;
            // 
            // tx_cpf
            // 
            tx_cpf.Location = new Point(71, 146);
            tx_cpf.Mask = "000,000,000-00";
            tx_cpf.Name = "tx_cpf";
            tx_cpf.Size = new Size(122, 23);
            tx_cpf.TabIndex = 48;
            // 
            // tx_telefone
            // 
            tx_telefone.Location = new Point(71, 187);
            tx_telefone.Mask = "(00) 00000-0000";
            tx_telefone.Name = "tx_telefone";
            tx_telefone.Size = new Size(122, 23);
            tx_telefone.TabIndex = 47;
            // 
            // tx_nome
            // 
            tx_nome.Location = new Point(71, 108);
            tx_nome.Name = "tx_nome";
            tx_nome.Size = new Size(392, 23);
            tx_nome.TabIndex = 46;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 353);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(517, 154);
            dataGridView1.TabIndex = 64;
            // 
            // button2
            // 
            button2.Location = new Point(374, 289);
            button2.Name = "button2";
            button2.Size = new Size(89, 37);
            button2.TabIndex = 65;
            button2.Text = "SALVAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // CadastroPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 519);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(tx_data);
            Controls.Add(tx_sexo);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(button1);
            Controls.Add(bt_cadastrar);
            Controls.Add(bt_excluir);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tx_rg);
            Controls.Add(tx_cpf);
            Controls.Add(tx_telefone);
            Controls.Add(tx_nome);
            Name = "CadastroPaciente";
            Text = "CadastroPaciente";
            Load += CadastroPaciente_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox tx_data;
        private ComboBox tx_sexo;
        private Label label10;
        private Label label9;
        private Button button1;
        private Button bt_cadastrar;
        private Button bt_excluir;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox tx_rg;
        private MaskedTextBox tx_cpf;
        private MaskedTextBox tx_telefone;
        private TextBox tx_nome;
        private DataGridView dataGridView1;
        private Button button2;
    }
}