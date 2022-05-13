
using System.ComponentModel.DataAnnotations;

namespace PathOrderManagement.Entity.DbPathOrderManagement.Order
{
    public enum OrderStatus
    {
        [Display(Name = "Receipt")]
        Receipt = 0, //Alındı

        [Display(Name = "Accepted")]
        Accepted = 1, //Kabul edildi

        [Display(Name = "Preparing")]
        Preparing = 2, //Hazırlanıyor

        [Display(Name = "In cargo")]
        InCargo = 3, //Kargoda

        [Display(Name = "Completed")]
        Completed = 4, //Tamamlandı

        [Display(Name = "Cancellation confirmation pending")]
        CancellationConfirmationPending = 5, //İptal onayı bekleniyor

        [Display(Name = "Canceled")]
        Canceled = 6 //İptal edildi
    }
}
