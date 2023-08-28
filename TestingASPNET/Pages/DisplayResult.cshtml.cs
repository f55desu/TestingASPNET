using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TestingASPNET.Services.SendingDataService;

namespace TestingASPNET.Pages
{
    public class DisplayResultModel : PageModel
    {
        private readonly IMapper _mapper;
        private readonly ILogger<DisplayResultModel> _logger;
        private readonly ISendingDataService _SendingDataService;

        public string String { get; set; }

        public DisplayResultModel(
            IMapper mapper,
            ILogger<DisplayResultModel> logger,
            ISendingDataService SendingDataService
        )
        {
            _mapper = mapper;
            _logger = logger;
            _SendingDataService = SendingDataService;
        }

        public void OnGet()
        {
            var data = _SendingDataService.GetStringModel();
            String = data.String;
        }
    }
}