using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Semana07A2023.Services
{
    public interface IQrScanningService
    {

        Task<string> ScanAsync();

    }
}
