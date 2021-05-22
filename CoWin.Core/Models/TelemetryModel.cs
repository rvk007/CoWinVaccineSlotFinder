using System;
using System.Collections.Generic;
using System.Text;

namespace CoWin.Core.Models
{
    public class TelemetryModel
    {
        public string AppVersion { get; set; }
        public string BookedOn { get; set; }
        public string TimeTakenToBookInSeconds { get; set; }
        public string CaptchaMode { get; set; }
        public long Latitude { get; set; }
        public long Longitude { get; set; }
        public long PinCode { get; set; }
        public string District { get; set; }
        public string State { get; set; }
        public long BeneficiaryCount { get; set; }
        public long MinimumAge { get; set; }
        public long MaximumAge { get; set; }
    }
}
