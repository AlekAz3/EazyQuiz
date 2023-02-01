using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EazyQuiz.Desktop.Admin;
public partial class Panel : Form
{
    private readonly UserToken _userToken;

    public Panel(UserToken userToken)
    {
        _userToken = userToken;
        InitializeComponent();
    }

    public void Open()
    {
        StatusLabel.Text = $"{_userToken.User.UserName}\n{_userToken.User.Email}\n{_userToken.User.Age}\n{_userToken.User.Country}";
        TokenLabel.Text = _userToken.User.Token;
        this.Show();
    }
}
