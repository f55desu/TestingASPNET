using AutoMapper;
using TestingASPNET.Services.SendingDataService.Models;

namespace TestingASPNET.Data.Models;

public class ResultModel
{
    public string? String { get; set; }
}

public class ResultModelProfile : Profile
{
    public ResultModelProfile()
    {
        CreateMap<ResultModelProfile, ResultModel>();
        CreateMap<ResultModel, ResultModelProfile>();
    }
}