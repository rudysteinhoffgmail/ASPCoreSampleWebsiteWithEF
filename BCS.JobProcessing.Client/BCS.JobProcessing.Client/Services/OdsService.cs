using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json; 
using BCS.JobProcessing.Client.Models;



namespace BCS.JobProcessing.Client.Services;
public class OdsService
{

    private readonly HttpClient _httpClient;

    public OdsService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<GrossPremiumDTO>> GetAllGrossPremiums()
    {
        try
        {
            Uri requestUrl = new Uri("https://localhost:7141/api/ODS");
            var results = await _httpClient.GetFromJsonAsync<List<GrossPremiumDTO>>(requestUrl);
            return results ?? [];
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error fetching gross premiums: {ex.Message}");
            return new List<GrossPremiumDTO>();
        }
    }

}
//    public async Task<List<ValidateGutOdsPremiumDataDTO>> GetOdsDataAsync()
//    {
//        List<ValidateGutOdsPremiumDataDTO> results = new List<ValidateGutOdsPremiumDataDTO>();

//        try
//        {
//            Uri requestUrl = new Uri("https://localhost:7141/api/ODS");
//            List<ValidateGutOdsPremiumDataDTO>? validateGutOdsPremiumDataDTOs = await _httpClient.GetFromJsonAsync<List<ValidateGutOdsPremiumDataDTO>>(requestUrl);
//            return validateGutOdsPremiumDataDTOs; 
//        }
//        catch (Exception ex)
//        {
//            var msg = ex.Message;
//            return new List<ValidateGutOdsPremiumDataDTO>();
//        }
//    }
//}
//    private readonly HttpClient _httpClient;

//    public OdsService(HttpClient httpClient)
//    {
//        _httpClient = httpClient;
//    }

//    public async Task<List<ValidateGutOdsPremiumDataDTO>> GetOdsDataAsync()
//    {

//        List<ValidateGutOdsPremiumDataDTO> results = new List<ValidateGutOdsPremiumDataDTO>();

//        try  
//        {
//            Uri? requestUrl = new Uri("https://localhost:7141/api/ods");
//            results = await _httpClient.GetFromJsonAsync<List<ValidateGutOdsPremiumDataDTO>>(requestUrl);
//            return results;
//        }
//        catch (Exception ex)  
//        {  
//            var msg = ex.Message;
//            return new List<ValidateGutOdsPremiumDataDTO>();
//        }
//    }
//}

        //catch (HttpRequestException httpEx)
        //{
        //    Console.WriteLine($"Request error: {httpEx.Message}");
        //    return Array.Empty<ValidateGutOdsPremiumDataDTO>();
        //}
        //catch (NotSupportedException nsEx) // When content type is not valid
        //{
        //    Console.WriteLine($"The content type is not supported: {nsEx.Message}");
        //    return Array.Empty<ValidateGutOdsPremiumDataDTO>();
        //}
        //catch (JsonException jsonEx) // Invalid JSON
        //{
        //    Console.WriteLine($"Invalid JSON: {jsonEx.Message}");
        //    return Array.Empty<ValidateGutOdsPremiumDataDTO>();
        //}
        //catch (TaskCanceledException tcEx) // Handle request timeout
        //{
        //    Console.WriteLine($"Request timed out: {tcEx.Message}");
        //    return Array.Empty<ValidateGutOdsPremiumDataDTO>();
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine($"An error occurred: {ex.Message}");
        //    return Array.Empty<ValidateGutOdsPremiumDataDTO>();
        //}
        
