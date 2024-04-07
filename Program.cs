// See https://aka.ms/new-console-template for more information
using DesafioHubNexxo;

internal class Program
{
    private static void Main(string[] args)
    {
        Task task1 = Persistence.CriarCliente();
        Task task2 = Persistence.PesquisarCliente();
        Task task3 = Persistence.DeletarCliente();
        Task task4 = Persistence.AtualizarCliente();
    }
}