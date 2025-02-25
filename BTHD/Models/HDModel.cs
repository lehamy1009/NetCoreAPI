public class HDModel
{
    public float Nhapsoluong { get; set; }  
    public float Nhapdongia { get; set; }  
    public float Tinhtien { get; set; }  

    
    public void CalculateTotalAmount()
    {
        Tinhtien = Nhapsoluong * Nhapdongia ;
    }
}