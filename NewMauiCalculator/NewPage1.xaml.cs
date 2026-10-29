namespace NewMauiCalculator;

public partial class NewPage1 : ContentPage
{
    public NewPage1()
    {
        InitializeComponent();
    }

    private void OnNumberClicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        string pressedNumber = button.Text;

        if (resultLabel.Text == "0" || string.IsNullOrWhiteSpace(resultLabel.Text))
            resultLabel.Text = pressedNumber;
        else
            resultLabel.Text += pressedNumber;
    }

    private void OnClearClicked(object sender, EventArgs e)
    {
        resultLabel.Text = "0";
    }

    private void OnDeleteClicked(object sender, EventArgs e)
    {
        if (resultLabel.Text.Length > 0 && resultLabel.Text != "0")
        {
            resultLabel.Text = resultLabel.Text.Substring(0, resultLabel.Text.Length - 1);
            if (resultLabel.Text.Length == 0)
                resultLabel.Text = "0";
        }
    }

    private void OnDivideClicked(object sender, EventArgs e) { HandleOperator("/"); }
    private void OnMultiplyClicked(object sender, EventArgs e) { HandleOperator("X"); }
    private void OnSubtractClicked(object sender, EventArgs e) { HandleOperator("-"); }
    private void OnAddClicked(object sender, EventArgs e) { HandleOperator("+"); }
    private void OnPercentClicked(object sender, EventArgs e) { HandleOperator("%"); }
    private void OnParenthesisClicked(object sender, EventArgs e)
    {

    }
    private void OnDecimalClicked(object sender, EventArgs e)
    {

    }

    private void OnEqualsClicked(object sender, EventArgs e)
    {

    }

    private void HandleOperator(string op)
    {
        resultLabel.Text += $" {op} ";
    }
}