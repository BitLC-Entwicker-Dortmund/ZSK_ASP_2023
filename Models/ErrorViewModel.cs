using System;

namespace ZSK_ASP_2023.Models {
    public class ErrorViewModel {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty ( RequestId );
    }
}
