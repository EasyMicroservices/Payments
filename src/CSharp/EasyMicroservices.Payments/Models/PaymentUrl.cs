using EasyMicroservices.Payments.DataTypes;

namespace EasyMicroservices.Payments.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class PaymentUrl
    {
        /// <summary>
        /// 
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public RequestUrlType Type { get; set; }
    }
}
