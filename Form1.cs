using System.Globalization;

namespace DichotomyMethodSolver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ������� ��� ���������� �������� ������� F(x) = x^3 - 1.2x + 1
        private double Function(double x)
        {
            return Math.Pow(x, 3) - (1.2 * x) + 1;
        }

        // ������� ������ ������ ������� ������쳿
        private double FindRoot(double a, double b, double eps, int maxIterations = 1000)
        {
            // ��������, �� ������� �� ����� ���� �� ����� �� ������� ����� ���������
            if (Function(a) * Function(b) > 0)
            {
                throw new InvalidOperationException("������������ ��������: f(a) � f(b) ����� ���� � ��� �� ����.");
            }

            double c;
            int iterations = 0;
            do
            {
                // ��������� �������� ���������
                c = (a + b) / 2;
                if (Function(a) * Function(c) > 0)
                {
                    // ������ ��� ���� ��������� �� ��������
                    a = c;
                }
                else
                {
                    // ������ ����� ���� ��������� �� ��������
                    b = c;
                }

                iterations++;
                if (iterations > maxIterations)
                {
                    throw new InvalidOperationException("��������� ����������� ������� ��������. �������, ������� ������ ������� �������.");
                }
            } while (Math.Abs(Function(c)) > eps && iterations <= maxIterations);

            return c; // ��������� ��������� �����
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
                    ResultTextBox.Text = result.ToString(CultureInfo.InvariantCulture).Replace('.', ',');
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                using (SaveFileDialog saveFileDialog = new())
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
            string functionDescription = "������� F(x) = x^3 - 1.2x + 1";

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

        private void ClearButton_Click(object sender, EventArgs e)
        {
            LeftBoundTextBox.Clear();
            RightBoundTextBox.Clear();
            EpsilonTextBox.Clear();
        }
    }
}
