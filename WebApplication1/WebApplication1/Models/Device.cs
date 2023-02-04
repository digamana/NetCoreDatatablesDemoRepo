using System.ComponentModel;

namespace WebApplication1.Models
{
    public class Device
    {
        [DisplayName("Id")]
        public int Id { get; set; }
        [DisplayName("類型")]
        public int DeviceTypeId { get; set; }
        [DisplayName("名稱")]
        public string ItemName { get; set; }
        [DisplayName("物品描述")]
        public string ItemDescription { get; set; }
    }
}
