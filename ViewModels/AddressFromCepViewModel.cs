using Newtonsoft.Json;

namespace SupplierRegistrationContext.ViewModels;

public class AddressFromCepViewModel
{
    [JsonProperty("cep")]
    public string CEP { get; set; }
    [JsonProperty("logradouro")]
    public string Logradouro { get; set; }
    [JsonProperty("complemento")]
    public string Complemento { get; set; }
    [JsonProperty("bairro")]
    public string Bairro { get; set; }
    [JsonProperty("localidade")]
    public string Localidade { get; set; }
    [JsonProperty("uf")]
    public string UF { get; set; }
    [JsonProperty("unidade")]
    public string Unidade { get; set; }
    [JsonProperty("ibge")]
    public string IBGE { get; set; }
    [JsonProperty("gia")]
    public string Gia { get; set; }

    public override string? ToString()
    {
        string enderecoFormatado = $"{Logradouro}";

        if (!string.IsNullOrEmpty(Complemento))
            enderecoFormatado += $", {Complemento}";

        if (!string.IsNullOrEmpty(Bairro))
            enderecoFormatado += $" - {Bairro}";

        if (!string.IsNullOrEmpty(Localidade) && !string.IsNullOrEmpty(UF))
            enderecoFormatado += $". {CEP}. {Localidade} - {UF}.";

        return enderecoFormatado;
    }
    // Referência: http://www.visuarea.com.br/artigos/padronizacoes-corretas-de-informacoes-obrigatorias
}
