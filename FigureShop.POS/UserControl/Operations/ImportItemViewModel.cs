using System;
using System.Collections.Generic;
namespace FigureShop.POS.UserControl.Operations;

public class ImportItemViewModel
{
    public Guid MaSP { get; set; }
    public string TenSP { get; set; }
    public int SoLuong { get; set; }
    public double DonGiaNhap { get; set; } // We'll show this in the grid
    public double ThanhTien => SoLuong * DonGiaNhap;
}