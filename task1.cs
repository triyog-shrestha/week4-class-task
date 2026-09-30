using System.Drawing;
using Modern.Forms;


public class Counter : Form
{
    private Label counter_value = null!;
    private Button incrementButton = null!;

    public Counter()
    {
        Text = "Counter";
        Size = new Size(450,300);
        initComponents();
        addComponents();

    }
    private void initComponents()
    {
        counter_value = new Label
        {
            Text = "0",
            Left = 225,
            Top = 100,
            Width = 80,
            Height = 60
        };
        counter_value.Style.FontSize = 40;

        incrementButton = new Button
        {
            Text = "Increment",
            Left = 190,
            Top = 180,
            Height = 30
        };
        incrementButton.Click += (sender,e) => incrementValue(counter_value);

    }

    private void addComponents()
    {
        Controls.Add(counter_value);
        Controls.Add(incrementButton);

    }

    private void incrementValue(Label counter_value)
    {
        int value = int.Parse(counter_value.Text);
        value += 1;
        counter_value.Text = value.ToString();
    }
}
