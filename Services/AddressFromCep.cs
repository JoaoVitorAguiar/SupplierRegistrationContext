namespace SupplierRegistrationContext.Services;

using SupplierRegistrationContext.ViewModels;
using System.Text.Json;
using System.Text.Json.Serialization;

public static class AddressFromCep
{
    public static async Task<string> GetJson(string cep)
    {
        var url = $"https://viacep.com.br/ws/{cep}/json/";
        HttpClient cliente = new HttpClient();
        HttpResponseMessage resposta = await cliente.GetAsync(url);
        resposta.EnsureSuccessStatusCode();

        var jsonString = await resposta.Content.ReadAsStringAsync();
        var address = JsonSerializer.Deserialize<AddressFromCepViewModel>(jsonString, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        return address.ToString();
    }
}
