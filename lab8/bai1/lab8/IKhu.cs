namespace lab8
{
    public interface IKhu
    {
        double ChieuDai { get; set; }
        double ChieuRong { get; set; }
        string MaSo { get; set; }

        double GiaTri();
    }
}