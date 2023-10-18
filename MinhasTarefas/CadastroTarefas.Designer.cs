namespace MinhasTarefas
{
    partial class CadastroTarefas
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
            label1 = new Label();
            txtNome = new TextBox();
            label2 = new Label();
            txtDescricao = new TextBox();
            label3 = new Label();
            dtpFinalizacao = new DateTimePicker();
            btnSalvar = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 24);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "NOME";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(108, 21);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(417, 23);
            txtNome.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 65);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 2;
            label2.Text = "DESCRIÇÃO";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(108, 62);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(417, 109);
            txtDescricao.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 190);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 4;
            label3.Text = "FINALIZAÇÃO";
            // 
            // dtpFinalizacao
            // 
            dtpFinalizacao.Location = new Point(108, 184);
            dtpFinalizacao.Name = "dtpFinalizacao";
            dtpFinalizacao.Size = new Size(417, 23);
            dtpFinalizacao.TabIndex = 5;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(450, 226);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(5, 255);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(520, 191);
            dataGridView1.TabIndex = 7;
            // 
            // CadastroTarefas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 469);
            Controls.Add(dataGridView1);
            Controls.Add(btnSalvar);
            Controls.Add(dtpFinalizacao);
            Controls.Add(label3);
            Controls.Add(txtDescricao);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Name = "CadastroTarefas";
            Text = "[ CADASTRO DE TAREFAS]";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private Label label2;
        private TextBox txtDescricao;
        private Label label3;
        private DateTimePicker dtpFinalizacao;
        private Button btnSalvar;
        private DataGridView dataGridView1;
    }
}