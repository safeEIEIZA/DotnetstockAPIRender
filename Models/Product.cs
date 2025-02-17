﻿public partial class Product
{
    public int productid { get; set; }

    public string? productname { get; set; }

    public decimal? unitprice { get; set; }

    public int? unitinstock { get; set; }

    public string? productpicture { get; set; }

    public int categoryid { get; set; }

    public DateTime createddate { get; set; }

    public DateTime? modifieddate { get; set; }

    // Constructor เพื่อกำหนดค่าเริ่มต้น
    public Product()
    {
        createddate = DateTime.Now; // กำหนดค่า default
        // กำหนดค่า default อื่น ๆ ถ้าจำเป็น
    }
}
