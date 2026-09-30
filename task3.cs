using System.ComponentModel;
using System.Drawing;
using Modern.Forms;

public class PercentageForm : Form
{
    private TextBox marksObtained = null!;
    private TextBox totalMarks = null!;
    private Button calculateButton = null!;
    private Label result = null!;

    public PercentageForm()
    {
        Text = "Percentage Calculator";
        Size = new Size(520, 320);

        initComponents();
        addComponents();
    }

    private void initComponents()
    {
        marksObtained = new TextBox
        {
            Placeholder = "Marks obtained",
            Left = 40,
            Top = 40,
            Width = 380,
            Height = 35
        };

        totalMarks = new TextBox
        {
            Placeholder = "Total marks",
            Left = 40,
            Top = 95,
            Width = 380,
            Height = 35
        };

        calculateButton = new Button
        {
            Text = "Calculate Percentage",
            Left = 40,
            Top = 150,
            Width = 380,
            Height = 40
        };
        calculateButton.Click += (sender, e) => calculatePercentage(marksObtained, totalMarks, result);

        result = new Label
        {
            Text = "Percentage will appear here",
            Left = 40,
            Top = 215,
            Width = 520,
            Height = 45
        };
        result.Style.FontSize = 18;
    }

    private void addComponents()
    {
        Controls.Add(marksObtained);
        Controls.Add(totalMarks);
        Controls.Add(calculateButton);
        Controls.Add(result);
    }

    private void calculatePercentage(TextBox marksBox, TextBox totalBox, Label resultLabel)
    {
        var marksObtained = float.Parse(marksBox.Text);
        var totalMarks = float.Parse(totalBox.Text);
        if (marksObtained == 0 || totalMarks == 0)
        {
            resultLabel.Text = "Error, the marks cant be 0";
            marksBox.Text = "";
            totalBox.Text = "";

        }
        else if (marksObtained > totalMarks)
        {
            resultLabel.Text = "Error, the obtained marks cant be greater the total marks";
            marksBox.Text = "";
            totalBox.Text = "";

        }
        else
        {
            var percentage = (marksObtained/totalMarks)*100.0;
            resultLabel.Text = $"Your Percentage = {percentage:F2}";
            marksBox.Text = "";
            totalBox.Text = "";
        }
    }
}
