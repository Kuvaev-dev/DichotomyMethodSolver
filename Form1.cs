namespace DichotomyMethodSolver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ������� ��� �������
        private double Function(double x)
        {
            return x * x - 9 * x + 14;
        }

        // ������� ������ ������ ������� ������쳿
        private double FindRoot(double a, double b, double eps)
        {
            // ��������, �� ������� �� ����� ���� �� ����� �� ������� ����� ���������
            if (Function(a) * Function(b) > 0)
            {
                throw new ArgumentException("������������ ��������: f(a) � f(b) ����� ���� � ��� �� ����.");
            }

            double c;
            while ((b - a) / 2 > eps)
            {
                c = (a + b) / 2;
                if (Function(a) * Function(c) > 0)
                {
                    a = c;
                }
                else
                {
                    b = c;
                }
            }
            return (a + b) / 2;
        }

        private void SearchZeroButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(LeftBoundTextBox.Text, out double leftBound) &&
                double.TryParse(RightBoundTextBox.Text, out double rightBound) &&
                double.TryParse(EpsilonTextBox.Text, out double epsilon))
            {
                try
                {
                    double result = FindRoot(leftBound, rightBound, epsilon);
                    ResultTextBox.Text = result.ToString();
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // ������� ����������� ��� �������, ���� �������� ������ ����������
                }
            }
            else
            {
                MessageBox.Show("������������ ������ �������� �����.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveResultButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(ResultTextBox.Text, out double result))
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;
                        string content = GetResultDetails(result);

                        File.WriteAllText(filePath, content);

                        MessageBox.Show("��������� ��������� � ����.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("������������ ������ ����������.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetResultDetails(double result)
        {
            double leftBound = double.Parse(LeftBoundTextBox.Text);
            double rightBound = double.Parse(RightBoundTextBox.Text);
            double epsilon = double.Parse(EpsilonTextBox.Text);
            string functionDescription = "������� F(x) = x^2 - 9x + 14";

            string content = $"˳�� ���� ���������: {leftBound}\n";
            content += $"����� ���� ���������: {rightBound}\n";
            content += $"������� ����������: {epsilon}\n";
            content += $"{functionDescription}\n";
            content += $"���������: {result}\n";

            return content;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}