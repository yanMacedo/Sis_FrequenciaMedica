using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;





namespace FrequenciaMedica
{
    public class RegraDeNegocio
    {

        string conexao = "Server=srvbdhomologa;Database=DADOSADV;User Id=usu_escolinha;Password=3sc0l1nh@";
        string baseLocal = "Server=NB044461;Database=FREQUENCIA_MEDICA;User Id=sa;Password=S@";
        //INFORMAÇÕES DO FUNCIONÁRIO.
        public DtoFuncionario GetInfDoFuncionario(string cracha, string crachaInvert)
        {
            SqlConnection connection = new SqlConnection(conexao);
            connection.Open();
            string sqlCommand = $@"SELECT A.NUMCRA, B.TIPCOL, B.NUMCAD, B.NOMFUN, B.NUMEMP, B.CODESC, B.SITAFA,
                                                 (SELECT TOP 1 M0_CODIGO 
                                                    FROM SYS_COMPANY (NOLOCK)
                                                   WHERE M0_CGC <> '' AND 
                                                         TRY_CAST(M0_CGC AS bigint) IN (SELECT numcgc 
                                                                                          FROM VETORH..R030FIL FIL (NOLOCK)
                                                                                         WHERE FIL.numemp = B.NUMEMP 
                                                    AND numcgc IS NOT NULL)) EMPTOTVS,
                                                    B.NumCpf 
                                            FROM VETORH..R069FIS A (NOLOCK), VETORH..R034FUN B (NOLOCK) 
                                           WHERE NUMFIS  in ('{cracha}','{crachaInvert}') AND
                                    		     TECCRA = '2' AND
                                    		     DATFIM = '19001231' AND
                                           	     A.NUMCRA = B.NUMCRA AND
                                    	         B.SITAFA <> 7 
                                    	   ORDER BY B.DATADM DESC";

            var listaFuncionarios = new SqlCommand(sqlCommand, connection);
            SqlDataReader lFuncionarios = listaFuncionarios.ExecuteReader();
            List<DtoFuncionario> funcionarios = new List<DtoFuncionario>();
            while (lFuncionarios.Read())
            {
                DtoFuncionario funcionario = new DtoFuncionario();
                funcionario.NUMCRA = int.Parse(lFuncionarios["numcra"].ToString());//1
                funcionario.NUMCAD = int.Parse(lFuncionarios["numcad"].ToString());//2
                funcionario.NOMFUN = lFuncionarios["nomfun"].ToString();//3
                funcionario.CODESC = int.Parse(lFuncionarios["codesc"].ToString());//4
                funcionario.SITAFA = int.Parse(lFuncionarios["sitafa"].ToString());//5
                funcionario.NUMEMP = int.Parse(lFuncionarios["numemp"].ToString());//6
                funcionario.TIPCOL = int.Parse(lFuncionarios["tipcol"].ToString());//7
                funcionario.EMPTOTVS = lFuncionarios["EMPTOTVS"].ToString();
                funcionario.NUMCPF = long.Parse(lFuncionarios["NumCpf"].ToString());

                funcionarios.Add(funcionario);
            }
            connection.Close();

            if (funcionarios.Count == 0)
            {
                return null;
            }
            else
            {
                return funcionarios.First();
            }
        }

        //INFORMAÇÕES DO COLABORADOR 
        public string GetEquipColaborador(string EmpTotvs, string numEmp, string numCad)
        {
            SqlConnection connection = new SqlConnection(conexao);
            connection.Open();
            string sqlCommand = @$"SELECT Descricao = 'EQUIPE: ' + ISNULL(RTRIM(UZD_SIGLA),'') + ' - PERFIL: ' + ISNULL(RTRIM(ZA3.ZA3_DESC),'') 
                                      FROM SRA{EmpTotvs}0 SRA (NOLOCK)
                                     INNER JOIN UZD{EmpTotvs}0 UZD (NOLOCK) ON UZD.UZD_FILIAL = '' AND UZD_CODIGO = SRA.RA_YEQATUA AND UZD.D_E_L_E_T_ = ''
                                      LEFT JOIN ZA3{EmpTotvs}0 ZA3 (NOLOCK) ON ZA3.ZA3_FILIAL = '' AND ZA3.ZA3_CODIGO =  UZD.UZD_CODPER AND ZA3.D_E_L_E_T_ = '' 
                                    WHERE SRA.RA_YNUMEMP = '{numEmp}' AND SRA.RA_YNUMCAD = '{numCad}' AND SRA.D_E_L_E_T_ = ''";

            var listaRegistros = new SqlCommand(sqlCommand, connection);
            SqlDataReader lRegistros = listaRegistros.ExecuteReader();
            string descricao = "";
            while (lRegistros.Read())
            {
                descricao = lRegistros["Descricao"].ToString();

            }
            connection.Close();
            return descricao;
        }

        public string GetSituacao(string codSituacao)
        {
            SqlConnection connection = new SqlConnection(conexao);
            connection.Open();

            string sqlCommand = $@"SELECT Descricao = DesSit FROM vetorh..R010SIT (NOLOCK) WHERE CODSit = '{codSituacao}' ";

            var listaRegistros = new SqlCommand(sqlCommand, connection);
            SqlDataReader lRegistros = listaRegistros.ExecuteReader();
            string descricao = "";
            while (lRegistros.Read())
            {
                descricao = lRegistros["Descricao"].ToString();
            }
            connection.Close();
            return descricao;
        }
        public string GetUltimoPonto(string EmpTotvs, string numEmp, string numCad, string tipCol)
        {
            SqlConnection connection = new SqlConnection(conexao);
            connection.Open();

            string sqlCommand = $@" SELECT 'ULTIMO PONTO - DIA ' + CONVERT(VARCHAR(10) , MARCA.DatMar, 103) + ' AS ' + 
 		SUBSTRING(CONVERT(VARCHAR(10) , MARCA.HorMar, 114),1,5) + ' EM ' + 
 		CASE WHEN Estacao = 'CATRACA' THEN 
 														(SELECT TOP 1 RLG.desrlg  
 														FROM VETORH..R070ACC AS ACC (nolock), VetoRH..R058RLG AS RLG  (nolock)
 														WHERE	ACC.numcra = MARCA.NumCra AND 
 																RLG.codrlg = ACC.codrlg 
 														order by datacc desc) 
 					WHEN Estacao = 'APP CELULAR' THEN 'APP CELULAR' 
 					ELSE (SELECT TOP 1 ZR1_LCREAL FROM ZR1{EmpTotvs}0 AS ZR1 (nolock) WHERE ZR1_FILIAL = '' AND ZR1_NUMOS = MARCA.Os COLLATE Latin1_General_BIN and ZR1.D_E_L_E_T_ = '') COLLATE Latin1_General_CI_AI 
 					END AS Descricao 
 			FROM  
 					(SELECT TOP 1 NumEmp, TipCol, NumCad, NumCra, DatMar, HorMar, Estacao, Os FROM PONTO_REFEICAO..MARCACAO (nolock)  
 					WHERE NumEmp = '{numEmp}'  AND TipCol = '{tipCol}' AND NumCad = '{numCad}' 
 					ORDER BY DatMar DESC) AS MARCA";

            var listaRegistros = new SqlCommand(sqlCommand, connection);
            SqlDataReader lRegistros = listaRegistros.ExecuteReader();
            string descricao = "";
            while (lRegistros.Read())
            {
                descricao = lRegistros["Descricao"].ToString();
            }
            connection.Close();
            return descricao;
        }
        public string GetAlocacao(string EmpTotvs, string numEmp, string numCad)
        {
            SqlConnection connection = new SqlConnection(conexao);
            connection.Open();

            string sqlCommand = $@"SELECT Descricao =(SELECT TOP 1 CASE WHEN '{numEmp}' <> 1 AND ZNB_OS <> OS2 THEN 'SEM ALOCACAO' ELSE '' END 
                                            FROM (SELECT ALO1.ZNB_MATRIC, ALO1.ZNB_OS, ALO1.ZNB_EQUIPE, UZD_CHAPAA, RA_MAT, ALO2.ZNB_MATRIC MATRIC2, ALO2.ZNB_OS OS2, ALO2.ZNB_EQUIPE EQUIPE2 
                                            FROM 
                                         (SELECT ZNB_MATRIC, ZNB_OS, ZNB_EQUIPE  
                                            FROM ZNB{EmpTotvs}0 ZNB (nolock)
                                           WHERE ZNB.D_E_L_E_T_ = ''  
                                             AND CONVERT(VARCHAR(8), DATEADD(DAY,-1,GETDATE()), 112) BETWEEN ZNB_DTINI AND ZNB_DTFIM) ALO1 
                                           INNER JOIN UZD{EmpTotvs}0 UZD ON UZD.D_E_L_E_T_ = '' AND UZD.UZD_CODIGO = ZNB_EQUIPE 
                                           INNER JOIN SRA{EmpTotvs}0 SRA ON SRA.D_E_L_E_T_ = '' AND SRA.RA_CHAPA = UZD_CHAPAA 
                                           INNER JOIN (SELECT ZNB_MATRIC, ZNB_OS, ZNB_EQUIPE  
                                            FROM ZNB{EmpTotvs}0 ZNB (nolock)
                                           WHERE ZNB.D_E_L_E_T_ = ''  
                                             AND CONVERT(VARCHAR(8), DATEADD(DAY,-1,GETDATE()), 112) BETWEEN ZNB_DTINI AND ZNB_DTFIM) ALO2 ON ALO2.ZNB_MATRIC = RA_MAT) TAB 
                                           WHERE ZNB_MATRIC = {numCad})";

            var listaRegistros = new SqlCommand(sqlCommand, connection);
            SqlDataReader lRegistros = listaRegistros.ExecuteReader();
            string descricao = "";
            while (lRegistros.Read())
            {
                descricao = lRegistros["Descricao"].ToString();
            }
            connection.Close();
            return descricao;
        }

        public string GetUltimaViagem(string EmpTotvs, string numCad)
        {
            SqlConnection connection = new SqlConnection(conexao);
            connection.Open();

            string sqlCommand = $@"SELECT  Descricao = ISNULL((SELECT TOP 1  
 					'ULTIMA VIAGEM: ' + RTRIM(UZN.UZN_DESTIN) + ' EM ' + CONVERT(VARCHAR(10), CAST(UZP.UZP_DSAIDA AS date), 103) 
 			FROM UZQ{EmpTotvs}0 AS UZQ (NOLOCK), UZP010 AS UZP (NOLOCK), UZN010 AS UZN (NOLOCK) 
 			WHERE	UZQ.UZQ_FILIAL = UZP.UZP_FILIAL AND 
 					UZQ_CODVIA = UZP.UZP_CODIGO AND 
 					UZQ_MAT = {numCad} AND  
 					UZN.UZN_CODIGO = UZP.UZP_CODD AND 
 					UZQ.D_E_L_E_T_ = '' AND 
 					UZP.D_E_L_E_T_ = ''  
 			ORDER BY UZP.UZP_DSAIDA DESC),'')";

            var listaRegistros = new SqlCommand(sqlCommand, connection);
            SqlDataReader lRegistros = listaRegistros.ExecuteReader();
            string descricao = "";
            while (lRegistros.Read())
            {
                descricao = lRegistros["Descricao"].ToString();
            }
            connection.Close();
            return descricao;
        }

        public string TipoDeBloqueio(string numEmp, string numCad)
        {
            SqlConnection connection = new SqlConnection(conexao);
            connection.Open();
            string sqlCommand = $@"SELECT *  
	                                 FROM  
	                                 (SELECT FUN.NUMEMP, FUN.TIPCOL, FUN.NUMCAD, BLC.DATBLO, MBL.DESMOT 
	                                 FROM	VETORH..R034FUN FUN, 
	 		                                VETORH..R070BLC BLC, 
	 		                                VETORH..R070MBL MBL 
	                                 WHERE FUN.NUMCRA = BLC.NUMCRA 
	                                    AND FUN.SITAFA NOT IN (7, 26) 
	                                    AND BLC.CODMOT = MBL.CODMOT 
	                                 UNION ALL 

	                                 -- BLOQUEIO POR MATRÍCULA 
	                                 SELECT FUN.NUMEMP, FUN.TIPCOL, FUN.NUMCAD, BLO.DATBLO, MBL.DESMOT 
	                                 FROM	VETORH..R034FUN FUN, 
	 		                                VETORH..R070BLO BLO, 
	                                         VETORH..R070MBL MBL 
	                                 WHERE FUN.NUMEMP = BLO.NUMEMP 
	                                    AND FUN.TIPCOL = BLO.TIPCOL 
	                                    AND FUN.NUMCAD = BLO.NUMCAD 
	                                    AND FUN.SITAFA NOT IN (7, 26) 
	                                    AND BLO.CODMOT = MBL.CODMOT) AS A 
	                                 WHERE	A.NUMEMP = {numEmp}  AND A.NUMCAD = {numCad}  AND A.DATBLO = CONVERT(VARCHAR(08),GETDATE(),112)";
            var listaRegistros = new SqlCommand(sqlCommand, connection);
            SqlDataReader lRegistros = listaRegistros.ExecuteReader();
            string motivos = "";
            while (lRegistros.Read())
            {
                motivos = lRegistros["DESMOT"].ToString();   
            }

            connection.Close();
            return motivos;
        }
        public string VerificaSeHaBloqueio(string numCad, string empTotvs)
        {
            SqlConnection connection = new SqlConnection(conexao);
            connection.Open();
            string sqlCommand = $@"SELECT count(*) NREG 
                                   FROM UZE{empTotvs}0 
                                   WHERE UZE_MAT = {numCad} AND D_E_L_E_T_ = '' 
                                   AND UZE_DATINI >= CONVERT(VARCHAR(08),GETDATE(),112) 
                                   AND UZE_DATFIM <= CONVERT(VARCHAR(08),GETDATE(),112) 
                                   AND UZE_FLAG IN('PO','AM')";

            var listaRegistros = new SqlCommand(sqlCommand, connection);
            SqlDataReader lRegistros = listaRegistros.ExecuteReader();
            int nReg = 0;
            while (lRegistros.Read())
            {
                nReg = int.Parse(lRegistros["NREG"].ToString());
            }
            connection.Close();

            if (nReg > 0)
            {
                return "SIM";
            }

            return "";

        }
        public DateTime VerificaSeHaRegistroDePonto
            (//Parametros da função 
            string numCra,
            string numEmp
            )
        {
            SqlConnection connection = new SqlConnection(baseLocal);
            connection.Open();

            string sqlCommand = $@"SELECT top(1) HORA AS Horas 
                                FROM TBL_FREQUENCIA_MEDICA  
                                WHERE DATA = CONVERT(VARCHAR(08),GETDATE(),112)  
                                AND NUMCRA = {numCra} 
                                AND  EMPRESA = {numEmp} ORDER BY HORA DESC";

            var listaRegistros = new SqlCommand(sqlCommand, connection);
            SqlDataReader lRegistros = listaRegistros.ExecuteReader();
            DateTime descricao = new DateTime();

            while (lRegistros.Read())
            {
                descricao = DateTime.Parse(lRegistros["Horas"].ToString());
                connection.Close();
                return descricao;
            }
            connection.Close();
            return descricao;
            //connection.Close();            
        }

        public string GravarColaborador
            (//parametros
            string sitafa,
            string numCra,
            string numEmp,
            string numCad,
            string empTotvs,
            string nomFunc
            )
        {
            string cStatus = "";
            SqlConnection connection = new SqlConnection(baseLocal);
            connection.Open();
            //verifica se está de férias:
            if (sitafa == "2")
            {
                cStatus = "BLOQUEADO-FERIAS";

            }
            else
            {
                RegraDeNegocio rn = new RegraDeNegocio();
                DateTime bateu = rn.VerificaSeHaRegistroDePonto(numCra, numEmp);
                string bloq = rn.VerificaSeHaBloqueio(numCad, empTotvs);

                if (bateu != null)
                {
                    if (DateTime.Now.ToLocalTime() > bateu.AddMinutes(15))
                    {
                        string sqlCommand= $@"INSERT INTO TBL_FREQUENCIA_MEDICA ([NUMCRA],[NUMCAD],[DATA],[HORA],[NOME],[EMPRESA],[CODRELOGIO],[OS],[SINCRONIZADO],[USUA_CRIACAO],[USUA_LANCAMENTO],[OBS],DIRACC) VALUES({numCra},{numCad},CONVERT(VARCHAR(08),GETDATE(),112),'{DateTime.Now.ToLocalTime().ToString("HH:mm")}','{nomFunc}','{numEmp}', '148', '9999','NAO', '{Parametros.User}' ,'','','{Parametros.Tipo}')";
                        var listaRegistros = new SqlCommand(sqlCommand, connection);
                        SqlDataReader lRegistros = listaRegistros.ExecuteReader();

                        if (bloq == "SIM")
                        {
                            cStatus = "LIBERADO-BLOQUEADO";
                        }
                        else
                        {
                            cStatus = "LIBERADO";
                        }
                    }
                    else
                    {
                        if (bloq == "SIM")
                        {
                            cStatus = "LIBERADO-BLOQUEADO";
                        }
                        else
                        {
                            cStatus = "LIBERADO";
                        }
                    }

                }
                else
                {
                    string sqlCommand= $@"INSERT INTO TBL_FREQUENCIA_MEDICA ([NUMCRA],[NUMCAD],[DATA],[HORA],[NOME],[EMPRESA],[CODRELOGIO],[OS],[SINCRONIZADO],[USUA_CRIACAO],[USUA_LANCAMENTO],[OBS],DIRACC) VALUES({numCra},{numCad},CONVERT(VARCHAR(08),GETDATE(),112),SUBSTR(TIME(),1,5),{nomFunc},{numEmp}, 148, 9999,'NAO', {Parametros.User} ,'','',{Parametros.Tipo}";
                    var listaRegistros = new SqlCommand(sqlCommand, connection);
                    SqlDataReader lRegistros = listaRegistros.ExecuteReader();
                    cStatus = "LIBERADO";
                }
            }
            connection.Close();
            return cStatus;

        }

        public string GetContador()
        {
            SqlConnection connection = new SqlConnection(baseLocal);
            connection.Open();
            string sqlCommand = $@"SELECT COUNT(*) AS QUANTT FROM TBL_FREQUENCIA_MEDICA (nolock) WHERE DATA = CONVERT(VARCHAR(08),GETDATE(),112) ";
            var listaRegistros = new SqlCommand(sqlCommand, connection);
            SqlDataReader lRegistros = listaRegistros.ExecuteReader();
            string contador= "";

            while (lRegistros.Read())
            {
                contador = lRegistros["QUANTT"].ToString();
                //connection.Close();
                //return contador;
            }
            connection.Close();
            return contador;
        }

        //public string GetStatusColaborador(string sitafa, string numCra, string numEmp, string numCad,string empTotvs, string nomFunc)
        //{
        //    string status = LiberaColaborador(sitafa, numCra, numEmp,numCad,empTotvs, nomFunc);
        //    if (status == "LIBERADO")
        //    {
        //        return "REGISTRADO";
        //    }
        //    else
        //    {
        //        return status;
        //    }
           

        //}
    }  
}
