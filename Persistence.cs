using DesafioHubNexxo.Models;
using System.Text.Json;
using System.Text;
using RestSharp;
using RestSharp.Authenticators;

namespace DesafioHubNexxo
{
    public class Persistence
    {
        public static async Task CriarCliente()
        {
            Customer cus;
            cus = new Customer();
            cus.Name = "cleiton_001_code";
            cus.Email = "john.doe@asaas.com.br";
            cus.Phone = "4738010919";
            cus.MobilePhone = "4799376637";
            cus.CpfCnpj = "24971563792";
            cus.PostalCode = "01310-000";
            cus.Address = "Av. Paulista";
            cus.AddressNumber = "150";
            cus.Complement = "Sala 201";
            cus.Province = "Centro";
            cus.ExternalReference = "12987382";
            cus.NotificationDisabled = false;
            cus.AdditionalEmails = "150";
            cus.MunicipalInscription = "46683695908";
            cus.StateInscription = "646681195275";
            cus.Observations = "ótimo pagador, nenhum problema até o momento";

            // Serializar o objeto Customer para JSON
            var jsonCustomer = JsonSerializer.Serialize(cus);

            // Crie um cliente RestSharp
            var client = new RestClient("https://sandbox.asaas.com/api/v3/customers");

            // Defina o método POST
            var request = new RestRequest("https://sandbox.asaas.com/api/v3/customers", Method.Post);

            // Adicione a autorização do tipo API Key
            request.AddHeader("access_token", "$aact_YTU5YTE0M2M2N2I4MTliNzk0YTI5N2U5MzdjNWZmNDQ6OjAwMDAwMDAwMDAwMDAwNzc5NDM6OiRhYWNoXzEwZWVkMDIxLTQ0MDUtNGI3NS1hMzY0LTk0NmE5NTRjNGQzYQ==");

            // Configure o corpo da solicitação
            request.AddJsonBody(cus);

            // Execute a solicitação
            var response = client.Execute<Customer>(request);

            // Verifique a resposta
            if (response.IsSuccessful)
            {
                var customerResponse = response.Data;
                Console.WriteLine("Request bem sucedido. Objeto Customer na resposta:");
                Console.WriteLine($"cliente criado com o ID: {customerResponse.Id}");
                Console.WriteLine($"cliente criado com o Name: {customerResponse.Name}");
                // Adicione outras propriedades conforme necessário
            }
            else
            {
                Console.WriteLine($"Ocorreu um erro: {response.StatusCode}");
            }
        }




        public static async Task PesquisarCliente()
        {
            Customer cus;
            cus = new Customer();
            cus.Id = "cus_000005955234";

            var client = new RestClient("https://sandbox.asaas.com/api/v3/customers");

            var request = new RestRequest($"https://sandbox.asaas.com/api/v3/customers/{cus.Id}", Method.Get);

            request.AddHeader("access_token", "$aact_YTU5YTE0M2M2N2I4MTliNzk0YTI5N2U5MzdjNWZmNDQ6OjAwMDAwMDAwMDAwMDAwNzc5NDM6OiRhYWNoXzEwZWVkMDIxLTQ0MDUtNGI3NS1hMzY0LTk0NmE5NTRjNGQzYQ==");

            var response = client.Execute<Customer>(request);

            if (response.IsSuccessful)
            {
                var customerResponse = response.Data;
                Console.WriteLine("Request bem sucedido. Objeto Customer na resposta:");
                Console.WriteLine($"cliente localizado com o ID: {customerResponse.Id}");
                Console.WriteLine($"cliente localizado com o Name: {customerResponse.Name}");
            }
            else
            {
                Console.WriteLine($"Ocorreu um erro: {response.StatusCode}");
            }
        }

        public static async Task DeletarCliente()
        {
            Customer cus;
            cus = new Customer();
            cus.Id = "cus_000005955234";

            var client = new RestClient("https://sandbox.asaas.com/api/v3/customers");

            var request = new RestRequest($"https://sandbox.asaas.com/api/v3/customers/{cus.Id}", Method.Delete);

            request.AddHeader("access_token", "$aact_YTU5YTE0M2M2N2I4MTliNzk0YTI5N2U5MzdjNWZmNDQ6OjAwMDAwMDAwMDAwMDAwNzc5NDM6OiRhYWNoXzEwZWVkMDIxLTQ0MDUtNGI3NS1hMzY0LTk0NmE5NTRjNGQzYQ==");

            var response = client.Execute<Customer>(request);

            if (response.IsSuccessful)
            {
                var customerResponse = response.Data;
                Console.WriteLine("Request bem sucedido. Objeto Customer na resposta:");
                Console.WriteLine($"cliente deletado  com o ID: {customerResponse.Id}");
                Console.WriteLine($"cliente deletado : {customerResponse.Deleted}");
            }
            else
            {
                Console.WriteLine($"Ocorreu um erro: {response.StatusCode}");
            }
        }

        public static async Task AtualizarCliente()
        {
            Customer cus;
            cus = new Customer();
            cus.Id = "cus_000005955278";
            cus.Name = "cleiton_001_code_update";
            cus.Email = "john.doe@asaas.com.br";
            cus.Phone = "4738010919";
            cus.MobilePhone = "4799376637";
            cus.CpfCnpj = "24971563792";
            cus.PostalCode = "01310-000";
            cus.Address = "Av. Paulista";
            cus.AddressNumber = "150";
            cus.Complement = "Sala 201";
            cus.Province = "Centro";
            cus.ExternalReference = "12987382";
            cus.NotificationDisabled = false;
            cus.AdditionalEmails = "150";
            cus.MunicipalInscription = "46683695908";
            cus.StateInscription = "646681195275";
            cus.Observations = "ótimo pagador, nenhum problema até o momento";

            // Serializar o objeto Customer para JSON
            var jsonCustomer = JsonSerializer.Serialize(cus);

            // Crie um cliente RestSharp
            var client = new RestClient("https://sandbox.asaas.com/api/v3/customers");

            // Defina o método PUT
            var request = new RestRequest($"https://sandbox.asaas.com/api/v3/customers/{cus.Id}", Method.Put);


            // Adicione a autorização do tipo API Key
            request.AddHeader("access_token", "$aact_YTU5YTE0M2M2N2I4MTliNzk0YTI5N2U5MzdjNWZmNDQ6OjAwMDAwMDAwMDAwMDAwNzc5NDM6OiRhYWNoXzEwZWVkMDIxLTQ0MDUtNGI3NS1hMzY0LTk0NmE5NTRjNGQzYQ==");

            // Configure o corpo da solicitação
            request.AddJsonBody(cus);

            // Execute a solicitação
            var response = client.Execute<Customer>(request);

            // Verifique a resposta
            if (response.IsSuccessful)
            {
                var customerResponse = response.Data;
                Console.WriteLine("Request bem sucedido. Objeto Customer na resposta:");
                Console.WriteLine($"cliente atualizado com o ID: {customerResponse.Id}");
                Console.WriteLine($"cliente atualizado com o Name: {customerResponse.Name}");
           
                // Adicione outras propriedades conforme necessário
            }
            else
            {
                Console.WriteLine($"Ocorreu um erro: {response.StatusCode}");
            }
        }
    }
}
