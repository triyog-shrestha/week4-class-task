using System.Drawing;
using Modern.Forms;

public class LoginForm : Form
{
    private TextBox username = null!;
    private TextBox password = null!;
    private Button loginButton = null!;
    private Label loginResult = null!;

    public LoginForm()
    {
        Text = "Login";
        Size = new Size(520, 320);

        initComponents();
        addComponents();
    }

    private void initComponents()
    {
        username = new TextBox
        {
            Placeholder = "Username",
            Left = 40,
            Top = 40,
            Width = 380,
            Height = 35
        };

        password = new TextBox
        {
            Placeholder = "Password",
            PasswordCharacter = '*',
            Left = 40,
            Top = 95,
            Width = 380,
            Height = 35
        };

        loginButton = new Button
        {
            Text = "Login",
            Left = 40,
            Top = 150,
            Width = 380,
            Height = 40
        };
        loginButton.Click += (sender, e) => showLoginResult();

        loginResult = new Label
        {
            Text = "Login result will appear here",
            Left = 40,
            Top = 215,
            Width = 420,
            Height = 45
        };
        loginResult.Style.FontSize = 18;
    }

    private void addComponents()
    {
        Controls.Add(username);
        Controls.Add(password);
        Controls.Add(loginButton);
        Controls.Add(loginResult);
    }

    private void showLoginResult()
    {
        if (string.IsNullOrWhiteSpace(username.Text) || string.IsNullOrWhiteSpace(password.Text))
        {
            loginResult.Text = "Enter both username and password.";
            username.Text = "";
            password.Text = "";
        }
        else if (username.Text == "admin" && password.Text == "1234")
        {
            loginResult.Text = "Login Successful";
            username.Text = "";
            password.Text = "";
        }
        else
        {
            loginResult.Text = "Invalid Username or Password";
            username.Text = "";
            password.Text = "";
        }

    }
}
