namespace EasyMicroservices.Payments.DataTypes
{
    /// <summary>
    /// 
    /// </summary>
    public enum PaymentStatusType : byte
    {
        /// <summary>
        /// value is none, Never use the None to return values
        /// </summary>
        None = 0,
        /// <summary>
        /// error value is default
        /// </summary>
        Default = 1,
        /// <summary>
        /// for the filter values from web admin panel you can sent all for types
        /// </summary>
        All = 2,
        /// <summary>
        /// there is other error that is not in the types
        /// </summary>
        Other = 3,
        /// <summary>
        /// the error type is uknown to us
        /// </summary>
        Unknown = 4,
        /// <summary>
        /// there is nothing to show or validate error
        /// </summary>
        Nothing = 5,
        /// <summary>
        /// 
        /// </summary>
        Created = 6,
        /// <summary>
        /// 
        /// </summary>
        RedirectedToBankPortal = 7,
        /// <summary>
        /// 
        /// </summary>
        Paid = 8,
        /// <summary>
        /// 
        /// </summary>
        Canceled = 9,
        /// <summary>
        /// 
        /// </summary>
        Failed = 10,
        /// <summary>
        /// 
        /// </summary>
        Successful = 11,
        /// <summary>
        /// 
        /// </summary>
        Closed = 12,
        /// <summary>
        /// 
        /// </summary>
        PaidBack = 13,
        /// <summary>
        /// 
        /// </summary>
        InProgress = 14,
        /// <summary>
        /// 
        /// </summary>
        Verified = 15,
        /// <summary>
        /// 
        /// </summary>
        UnPaid = 16
    }
}
