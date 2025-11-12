using FigureShop.POS.UserControl.Operations;

namespace FigureShop.POS;

public partial class Form_Menu : Form
{
    private Button clickedButton;
    
    public Form_Menu()
    {
        InitializeComponent();
        GetHeaderLabel("Trang chủ");
    }

    private void GetHeaderLabel(string label)
    {
        label1.Text = label;
    }

    private void LoadControl(System.Windows.Forms.UserControl control, string headerText)
    {
        // Update the label
        GetHeaderLabel(headerText);
        
        panelMainContent.Controls.Clear();
        control.Dock = DockStyle.Fill;
        panelMainContent.Controls.Add(control);
    }

    private void btnNhanVien_Click(object sender, EventArgs e)
    {
        clickedButton = (Button)sender;
        LoadControl(new UserControl_NhanVien(),  clickedButton.Text);
    }

    private void btnBanHang_Click(object sender, EventArgs e)
    {
        clickedButton = (Button)sender;
        LoadControl(new UserControl_BanHang(), clickedButton.Text);
    }

    private void btnKhachHang_Click(object sender, EventArgs e)
    {
        clickedButton = (Button)sender;
        LoadControl(new UserControl_KhachHang(), clickedButton.Text);
    }

    private void btnNhapHang_Click(object sender, EventArgs e)
    {
        clickedButton = (Button)sender;
        LoadControl(new UserControl_NhapHang(), clickedButton.Text);
    }

    private void btnHang_Click(object sender, EventArgs e)
    {
        clickedButton = (Button)sender;
        LoadControl(new UserControl_Hang(), clickedButton.Text);
    }


    private void btnCongViec_Click(object sender, EventArgs e)
    {
        clickedButton = (Button)sender;
        LoadControl(new UserControl_CongViec(), clickedButton.Text);
    }

    private void btnTheLoai_Click(object sender, EventArgs e)
    {
        clickedButton = (Button)sender;
        LoadControl(new UserControl_TheLoai(), clickedButton.Text);
    }

    private void btnSanPham_Click(object sender, EventArgs e)
    {
        clickedButton = (Button)sender;
        LoadControl(new UserControl_SanPham(), clickedButton.Text);
    }
}