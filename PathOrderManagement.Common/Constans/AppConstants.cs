
namespace PathOrderManagement.Common.Constans
{
    public class AppConstants
    {
        public const string ProductName = "PathOrderManagement";

        public const string JsonContentType = "application/json";

        public const string SymmetricKey = $"<!#_{ProductName}_Symmetric_Key_2022_#>";
        public static double AccessTokenExpireMinute = 6 * 60;//6 hour
        public static double RefreshTokenExpireMinute = 7 * 60; //7 hour
    }
}
