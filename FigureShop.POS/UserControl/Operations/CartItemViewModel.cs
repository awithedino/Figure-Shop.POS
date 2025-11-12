using System;
using System.Collections.Generic;
namespace FigureShop.POS.UserControl.Operations;

public class CartItemViewModel
{
    public Guid MaSP { get; set; }
    public string TenSP { get; set; }
    public int SoLuong { get; set; }
    public double DonGia { get; set; }
    public double GiamGia { get; set; }
    public double ThanhTien => (DonGia - GiamGia) * SoLuong;
}