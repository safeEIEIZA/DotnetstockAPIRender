public partial class Category
{
    public int categoryid { get; set; }

    public string categoryname { get; set; } = null!;

    public int categorystatus { get; set; }

    // Constructor เพื่อกำหนดค่าเริ่มต้น
    public Category()
    {
        categoryname = string.Empty; // หรือค่าที่คุณต้องการให้เป็นค่าเริ่มต้น
    }
}
