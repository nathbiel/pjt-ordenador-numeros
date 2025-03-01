using System.Windows.Forms;

namespace pjt_ordenador_numeros
{
    public partial class frm_ordenaNumero : Form
    {
        public frm_ordenaNumero()
        {
            InitializeComponent();
        }

        private void btn_adiciona_Click(object sender, EventArgs e)
        {
            cls_validaNumero novoNumero = new cls_validaNumero();
            novoNumero.numero=txt_numeros.Text;
            if (novoNumero.validaInteiro())
            {
ltb_listaNumeros.Items.Add(novoNumero.numero);
                txt_numeros.Clear();
                txt_numeros.Focus();
            }
                
            else
            {
MessageBox.Show("Digite um número inteiro!", "Erro!", MessageBoxButtons.OK);
                txt_numeros.Clear();
                txt_numeros.Focus();
            }
                
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            String exibeLista;
           ofd_LeArquivo.ShowDialog();
            exibeLista = ofd_LeArquivo.FileName;
            var numerosOrdenados = File.ReadAllLines(exibeLista).Select(line => int.Parse(line)).OrderBy(num=>num).ToList();
            txt_lista.Text = string.Join(Environment.NewLine, numerosOrdenados);
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (ltb_listaNumeros.SelectedIndex != -1) 
            {
                ltb_listaNumeros.Items.RemoveAt(ltb_listaNumeros.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Selecione um item para remover!","Aviso!",MessageBoxButtons.OK);
            }
        }

        private void btn_grava_Click(object sender, EventArgs e)
        {
            int numeros = ltb_listaNumeros.Items.Count;
            string numerosGravar;
            cls_contaNumeros valida = new cls_contaNumeros(numeros);
            if (valida.quantNumeros())
                MessageBox.Show("Digite a quantidade de números necessária (1-10)","Erro!",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
            else
            {
                if (!Directory.Exists(Environment.CurrentDirectory + @"\Arquivos"))
                {
                    Directory.CreateDirectory(Environment.CurrentDirectory + @"\Arquivos");
                    MessageBox.Show("Diretório criado com sucesso","Aviso!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                String caminho = Environment.CurrentDirectory + @"\Arquivos";

                numerosGravar = ltb_listaNumeros.Items[0].ToString();

                for (int i = 1;i< numeros;i++)
                {
                    numerosGravar+="\n"+ ltb_listaNumeros.Items[i].ToString();
                }

                File.WriteAllText(caminho + @"\numeros.txt", numerosGravar);

                MessageBox.Show("Arquivo salvo com sucesso!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}