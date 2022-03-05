using System; 

namespace Dio.TechSystem
{
    public class Servicos : EntidadeBase
    {
        // Atributos
        private ServicosE ServicosE {get; set;}
        private string RazaoSocial {get;set;}
        private string CNPJ {get;set;}
        private string CEP {get;set;}
        private string Estado {get;set;}
        private string Cidade {get;set;}
        private string Telefone {get;set;}
        private string Email {get;set;}
        private string Descricao {get;set;}
        private bool Excluido{get; set;}

             // Métodos
		public Servicos (int id, ServicosE servicosE, string razaoSocial, string cnpj ,string cep ,string estado, string cidade, string telefone,string email ,string descricao)
		{
			this.Id = id;
			this.ServicosE = servicosE;
            this.RazaoSocial = razaoSocial;
            this.CNPJ = cnpj;
            this.CEP = cep;
            this.Estado = estado;
            this.Cidade = cidade;
            this.Telefone = telefone;
            this.Email = email;
            this.Descricao = descricao;
            this.Excluido = false;

		}
         public override string ToString()
		{
			//Como o sistema operacional interpleta um nova linha Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1
            string retorno = "";
            retorno += "Tipos de Serviços: " + this.ServicosE + Environment.NewLine;
            retorno += "Razão Social: " + this.RazaoSocial + Environment.NewLine;
            retorno += "CNPJ: " + this.CNPJ + Environment.NewLine;
            retorno += "CEP: " + this.CEP + Environment.NewLine;
            retorno += "Estado: " + this.Estado + Environment.NewLine;
            retorno += "Cidade: " + this.Cidade + Environment.NewLine;
            retorno += "Telefone: " + this.Telefone + Environment.NewLine;
            retorno += "Email: " + this.Email + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
			return retorno;
		}
                public string retornaRazaoSocial()
		{
			return this.RazaoSocial;
		}

		public int retornaId()
		{
			return this.Id;
		}
        public bool retornaExcluido()
		{
			return this.Excluido;
		}
        public void Excluir() {
            this.Excluido = true;
        }
    }
    
       

    
}