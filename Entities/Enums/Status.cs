using System.ComponentModel;

namespace Entities.Enums
{
    public enum Status
    {
        [Description("Yeni")]
        New = 0,
        [Description("Devam Ediyor")]
        InProgress = 1,
        [Description("Tamamlandı")]
        Completed = 2,
    }
}
