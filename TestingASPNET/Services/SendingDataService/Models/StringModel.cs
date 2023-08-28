using AutoMapper;

namespace TestingASPNET.Services.SendingDataService.Models;

public class StringModel
{
    public string String;

    public StringModel()
    {
        String = "Hello, ASP.NET!";
    }
}
public class StringModelProfile : Profile
{
    public StringModelProfile()
    {
    }
}