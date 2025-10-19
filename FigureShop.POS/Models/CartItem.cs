using System;
using System.ComponentModel;

namespace FigureShop.POS.Models;

public class CartItem 
{
    public Guid FigureId { get; set; }
    public string FigureName { get; set; } = string.Empty;
    public double UnitPrice { get; set; }

    private int _quantity;

    public int Quantity
    {
        get => _quantity;
        set
        {
            if (value != _quantity)
            {
                _quantity = value;
                OnPropertyChanged(nameof(Quantity));
                OnPropertyChanged(nameof(TotalPrice));
            }
        }
    }
        
    public double TotalPrice => UnitPrice * Quantity;
        
    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}