namespace MinhasTarefas
{
    public partial class CadastroTarefas : Form
    {
        List<Tarefas> tarefas;
        public CadastroTarefas()
        {
            InitializeComponent();
            tarefas = new List<Tarefas>();
            dataGridView1.DataSource = tarefas;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tarefa = new Tarefas();
            tarefa.Id = Guid.NewGuid().ToString().Substring(0, 6);
            tarefa.Nome = txtNome.Text;
            tarefa.Descricao = txtDescricao.Text;
            tarefa.DataInicio = DateTime.Now;
            tarefa.DataFim = DateTime.Parse(dtpFinalizacao.Text);

            tarefas.Add(tarefa);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = tarefas;
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            //MessageBox.Show("Tarefa adicionada com sucesso!");

        }
    }
}
