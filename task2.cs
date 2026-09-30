using System.Drawing;
using Modern.Forms;


public class displayName: Form
{

    private Label output = null!;


    private Button displayBtn = null!;
    private TextBox input = null!;

    public displayName()
    {
        Text = "Display";
        Size = new Size(450,300);
        initComponents();
        addComponents();

    }

    private void initComponents()
    {
        input = new TextBox
        {
            Left = 20,
            Top = 50,
            Width = 150
        };

        output = new Label
        {
            Text = "Output here",
            Left =220,
            Top = 35,
            Width = 200,
            Height = 60
        };
        output.Style.FontSize = 17;

        displayBtn = new Button
        {
            Text = "Display",
            Left = 150,
            Top = 100,
            Height = 30
        };
        displayBtn.Click += (sender,e) => display(output, input); 
    }

    private void addComponents()
    {
        Controls.Add(input);
        Controls.Add(output);
        Controls.Add(displayBtn);
    }

    private void display(Label outputLabel, TextBox InputBox)
    {
        outputLabel.Text = InputBox.Text;
        InputBox.Text = "";
    }
}
