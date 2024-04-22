using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa("Pessoa1", "Sobrenome1");
Pessoa p2 = new Pessoa("Pessoa2", "Sobrenome2");

hospedes.Add(p1);
hospedes.Add(p2);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 110);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

decimal valorTotal = reserva.CalcularValorDiaria();
int qtdeHospedes = reserva.ObterQuantidadeHospedes();

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine("Informações da reserva:");
int i = 0;
foreach(Pessoa pessoa in reserva.Hospedes){
    Console.WriteLine($"Hospede {i+1}: {pessoa.Nome} {pessoa.Sobrenome}");
    i++;
}
Console.WriteLine($"Tipo de suite: {reserva.Suite.TipoSuite}\nQuantidade máxima: {reserva.Suite.Capacidade} \nValor da diária: R${reserva.Suite.ValorDiaria}");
Console.WriteLine($"Quantidade de hóspedes: {qtdeHospedes}\nDias reservados: {reserva.DiasReservados}\nValor total a pagar: R${valorTotal}");