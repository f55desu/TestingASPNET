using TestingASPNET.Services.SendingDataService.Models;

namespace TestingASPNET.Services.SendingDataService;

public class SendingDataServiceClass : ISendingDataService
{
    public StringModel GetStringModel()
    {
        var stringModel = new StringModel();
        return stringModel;
    }
}