using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrequenciaMedica.Telas
{
    public partial class Form_RegistroDePonto : Form
    {

        DateTime relogio;
        private string digitCrachaLeitor;
        private DateTime timeCracha;
        List<int> times = new List<int>();
        public string tipo;

        public Form_RegistroDePonto()
        {
            InitializeComponent();
        }        

        private void Form_RegistroDePonto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                this.Close();
            }
        }

        private void timer_DataHora_Tick(object sender, EventArgs e)
        {
            relogio = DateTime.Now;
            lbl_DataHora.Text = relogio.ToLocalTime().ToString();

        }

        private void Form_RegistroDePonto_Load(object sender, EventArgs e)
        {

        }

        //código para ler o número do crachá
        private void Leitura_KeyUp(object sender, KeyEventArgs e)
        {
            DateTime time = DateTime.Now.ToLocalTime();
            

            if(e.KeyCode == Keys.Escape)
            {
                //fechar = true;
                Close();
            }
            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            {
                if ((timeCracha.ToString() != "01/01/0001 00:00:00") && (DateTime.Now.Subtract(timeCracha).Milliseconds > 0))
                {
                    times.Add(DateTime.Now.Subtract(timeCracha).Milliseconds);
                }
                digitCrachaLeitor += e.KeyCode.ToString().Substring(1, 1);
                timeCracha = DateTime.Now;
            }

            if (e.KeyCode == Keys.Enter && times.Count > 2 && times[1] - times[2] < 20 && times[1] - times[2] > -20)
            {
                long nLeituraR20C = long.Parse(digitCrachaLeitor);//padrão R20C
                string cHexImetame = nLeituraR20C.ToString("X8"); //padrão hex R20C e padrão imetame
                cHexImetame = cHexImetame.Length < 8 ? "0" + cHexImetame : cHexImetame;
                string cHexInvertido = cHexImetame.Substring(6, 2) + cHexImetame.Substring(4, 2) + cHexImetame.Substring(2, 2) + cHexImetame.Substring(0, 2);
                long nLeituraImet = Convert.ToInt64(cHexInvertido, 16); //padrão imetame
                                                                        //*"processar_leitura" é a função que faz a consulta na base de dados.
                RegraDeNegocio regraDeNegocio = new RegraDeNegocio();
                DtoFuncionario dtoColaborador = regraDeNegocio.GetInfDoFuncionario(nLeituraImet.ToString(), nLeituraR20C.ToString());
                
                if (dtoColaborador != null)
                {
                    lbl_NomeDoColaborador.Text = dtoColaborador.NOMFUN.ToUpper();
                    lbl_Matricula.Text = dtoColaborador.NUMCAD.ToString();
                    lbl_Equipe.Text = regraDeNegocio.GetEquipColaborador(dtoColaborador.EMPTOTVS.ToString(), dtoColaborador.NUMEMP.ToString(), dtoColaborador.NUMCAD.ToString());
                    string motivoBloqueio = regraDeNegocio.TipoDeBloqueio(dtoColaborador.NUMEMP.ToString(), dtoColaborador.NUMCAD.ToString());
                    lbl_Situacao.Text = "SITUAÇÃO DO COLABORADOR: " + regraDeNegocio.GetSituacao(dtoColaborador.SITAFA.ToString()) + " " + motivoBloqueio;
                    lbl_Situacao.ForeColor = lbl_Situacao.Text.Contains("VIAGEM") ? Color.Red : Color.Black;
                    lbl_UltimoPonto.Text = regraDeNegocio.GetUltimoPonto(dtoColaborador.EMPTOTVS.ToString(), dtoColaborador.NUMEMP.ToString(), dtoColaborador.NUMCAD.ToString(), dtoColaborador.TIPCOL.ToString());
                    lbl_UltimaViagem.Text = regraDeNegocio.GetUltimaViagem(dtoColaborador.EMPTOTVS.ToString(), dtoColaborador.NUMCAD.ToString());
                    lbl_Alocacao.Text = regraDeNegocio.GetAlocacao(dtoColaborador.EMPTOTVS.ToString(), dtoColaborador.NUMEMP.ToString(), dtoColaborador.NUMCAD.ToString());
                   //escrever os bloqueios
                    string status = regraDeNegocio.GravarColaborador(dtoColaborador.SITAFA.ToString(), dtoColaborador.NUMCRA.ToString(), dtoColaborador.NUMEMP.ToString(), dtoColaborador.NUMCAD.ToString(), dtoColaborador.EMPTOTVS.ToString(), dtoColaborador.NOMFUN);
                    lbl_Registrado.Text = status;

                    if (lbl_Situacao.Text.Contains("VIAGEM") || motivoBloqueio.Trim() != "")
                    {
                        status = "LIBERADO-BLOQUEADO";
                    }

                    switch (status)
                    {
                        case "BLOQUEADO - FERIAS":
                            lbl_Registrado.BackColor = Color.Red;
                            lbl_LiberadoBloqueado.Visible = false;
                            break;
                        case "LIBERADO-BLOQUEADO":
                            lbl_Registrado.BackColor = Color.Green;
                            lbl_LiberadoBloqueado.Visible = true;
                            break;
                        case "LIBERADO":
                            lbl_Registrado.BackColor = Color.Green;
                            lbl_LiberadoBloqueado.Visible = false;
                            break;
                    }


                    lbl_Registrado.Visible = true;
                   
                    lbl_ContaRegistros.Text = regraDeNegocio.GetContador();
                }
                else
                {
                    lbl_Registrado.Text = "CRACHÁ INVÁLIDO";
                    lbl_Registrado.BackColor = Color.Red;
                    //Cracha Inativo
                }

                lbl_Registrado.Visible = true;
                    var request = WebRequest.Create($@"https://minha.imetame.com.br/picture/interno/{dtoColaborador.NUMCPF.ToString()}.jpg");

                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        img_Colaborador.Image = Bitmap.FromStream(stream);
                    }
                    lbl_ContaRegistros.Text = regraDeNegocio.GetContador();                                                              
            }
            if (e.KeyCode == Keys.Enter)
            {
                digitCrachaLeitor = "";
                times.Clear();
            }
        }
    }
}

