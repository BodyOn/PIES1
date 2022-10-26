using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyOn.Models
{
    public class ClientModel
    {
        int Id { get; set; }
        string Nome { get; set; }
        string End { get; set; }
        string Telefone { get; set; }
        string Email { get; set; }
        string Cpf { get; set; }
        float Peso { get; set; }
        float Altura { get; set; }
        string Horario { get; set; }
        int Plano { get; set; }
        string DataPagamento { get; set; }
        bool Pendente { get; set; }

        public ClientModel(int id,
                           string nome,
                           string end,
                           string telefone,
                           string email,
                           string cpf,
                           float peso,
                           float altura,
                           string horario,
                           int plano,
                           string dt,
                           bool pend) {
            this.Id = id;
            this.Nome = nome;
            this.End = end;
            this.Telefone = telefone;
            this.Email = email;
            this.Cpf = cpf;
            this.Peso = peso;
            this.Altura = altura;
            this.Horario = horario;
            this.Plano = plano;
            this.DataPagamento = dt;
            this.Pendente = pend;
        }
    }
}
