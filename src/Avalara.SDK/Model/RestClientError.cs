using System;
using System.Collections.Generic;
using System.Text;

namespace Avalara.SDK.Model
{
    /// <summary>
    /// Error class returned by Resharp rest client
    /// </summary>
    public class RestClientError
    {
        /// <summary>
        /// Error code returned by rest client
        /// </summary>
        public string errorCode { get; set; }
        /// <summary>
        /// Summary of the error
        /// </summary>
        public string errorSummary { get; set; }
        /// <summary>
        /// Error Link
        /// </summary>
        public string errorLink { get; set; }
        /// <summary>
        /// Error ID
        /// </summary>
        public string errorId { get; set; }
        /// <summary>
        /// ErrorCauses
        /// </summary>
        public List<object> errorCauses { get; set; }

    }
}
