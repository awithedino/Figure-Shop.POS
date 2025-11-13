using FigureShop.POS.Views.UserControl.Operations;
using FigureShop.POS.Views.UserControl.Management;
namespace FigureShop.POS.Views;

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
        LoadControl(new UserControl_DanhMuc(), clickedButton.Text);
    }

    private void btnSanPham_Click(object sender, EventArgs e)
    {
        clickedButton = (Button)sender;
        LoadControl(new UserControl_SanPham(), clickedButton.Text);
    }
    
    private void btnHoaDon_Click(object sender, EventArgs e)
    {
        clickedButton = (Button)sender;
        LoadControl(new UserControl_TraCuuHoaDon(), clickedButton.Text);
    }
    
    private void btnQuanLy_Click(object sender, EventArgs e)
    {
        flpManagementSubmenu.Visible = !flpManagementSubmenu.Visible;
    }

    private void btnNghiepVu_Click(object sender, EventArgs e)
    {
        flpOperationsSubmenu.Visible = !flpOperationsSubmenu.Visible;
    }

    private void Form_Menu_Load(object sender, EventArgs e)
    {
        var currentUser = Program.CurrentUser;
        
        if (currentUser == null) 
        {
            lblXinChao.Text = "Xin chào: Guest";
            lblQuyen.Text = "Quyền: Unknown";
            return;
        }
        
        string displayName = string.IsNullOrEmpty(currentUser.FullName) ? currentUser.Email : currentUser.FullName;
        lblXinChao.Text = $"Xin chào: {displayName}";
        
        string role = currentUser.RolesNames.FirstOrDefault()?.Name;
        lblQuyen.Text = $"Quyền: {role ?? "N/A"}";
    }
}