using System.Net.Http.Json;
using Inbursa.Client.Models;


namespace Inbursa.Client;

public class UsuarioClient
{
    private readonly HttpClient httpClient;
    private readonly string baseUrl;

    public UsuarioClient(HttpClient httpClient, IConfiguration configuration)
    {
        this.httpClient = httpClient;
        this.baseUrl = "http://localhost:5237/api/Usuario";
    }

    public async Task<List<Usuario>> GetUsuariosAsync()
    {
        return await httpClient.GetFromJsonAsync<List<Usuario>>($"{baseUrl}");
    }

    public async Task<Usuario> GetUsuarioAsync(int id)
    {
        return await httpClient.GetFromJsonAsync<Usuario>($"{baseUrl}/{id}");
    }

    public async Task<HttpResponseMessage> CrearUsuarioAsync(Usuario Usuario)
    {
        return await httpClient.PostAsJsonAsync($"{baseUrl}/Add", Usuario);
    }
}