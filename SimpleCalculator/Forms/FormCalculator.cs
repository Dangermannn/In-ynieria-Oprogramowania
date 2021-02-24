using SimpleCalculator.Abstracts;
using SimpleCalculator.Helpers;
using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimpleCalculator.Forms
{
    public partial class FormCalculator : ChildForm
    {
        private StringBuilder _expression;
        private readonly char[] _operations = { '*', '/', '+', '-', '.' };
        private const int MAX_EXPRESSION_LENGTH = 17;
        private const int MAX_NUMBER_LENGTH = 8;
        private int _currentNumberLength = 0;
        public FormCalculator()
        {
            InitializeComponent();
            _expression = new StringBuilder();
        }   

        #region Number buttons
        private void btnZero_Click(object sender, EventArgs e)
        {
            AddNumber('0');
        }
        private void btnOne_Click(object sender, EventArgs e)
        {
            AddNumber('1');
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            AddNumber('2');
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            AddNumber('3');
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            AddNumber('4');
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            AddNumber('5');
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            AddNumber('6');
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            AddNumber('7');
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            AddNumber('8');
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            AddNumber('9');
        }

        #endregion

        #region Operation buttons
        private void btnDivide_Click(object sender, EventArgs e)
        {
            AddOperator('/');
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            AddOperator('*');
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            AddOperator('-');
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            AddOperator('+');
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(_expression.ToString()))
                return;
            try
            {
                textBoxDisplay.Text = CalculateExpression.Calculate(_expression.ToString());
            }
            catch(System.Data.SyntaxErrorException)
            {
                textBoxDisplay.Text = "Syntax error";
            }
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            _expression.Clear();
            textBoxDisplay.Text = _expression.ToString();
            _currentNumberLength = 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(_expression.ToString()))
                return;
            _expression.Remove(_expression.Length - 1, 1);
            textBoxDisplay.Text = _expression.ToString();
            _currentNumberLength--;
        }

        private void btnLeftParenthesis_Click(object sender, EventArgs e)
        {
            _expression.Append("(");
            textBoxDisplay.Text = _expression.ToString();
        }

        private void btnRightParenthesis_Click(object sender, EventArgs e)
        {
            _expression.Append(")");
            textBoxDisplay.Text = _expression.ToString();
        }

        #endregion

        #region Helpers

        private bool CheckIfSignAppearsAgain()
        {
            if (String.IsNullOrEmpty(_expression.ToString()))
                return false;
            if (_operations.Contains(_expression[_expression.Length - 1]))
                return true;
            return false;
        }

        private bool ExceedMaxLength()
        {
            if (_expression.Length >= MAX_EXPRESSION_LENGTH)
                return true;
            return false;
        }

        private bool ExceedMaxNumberLength()
        {
            if (_currentNumberLength >= MAX_NUMBER_LENGTH)
                return true;
            return false;
        }

        private void AddNumber(char digit)
        {
            if ((!ExceedMaxNumberLength()) && (_expression.Length == 0 || (_expression[_expression.Length - 1] != 0 && !ExceedMaxLength())))
            {
                _expression.Append(digit);
                textBoxDisplay.Text = _expression.ToString();
                _currentNumberLength++;
            }
        }

        private void AddOperator(char sign)
        {
            if (CheckIfSignAppearsAgain() || ExceedMaxLength())
                return;
            _expression.Append(sign);
            textBoxDisplay.Text = _expression.ToString();
            _currentNumberLength = 0;
        }
        #endregion
    }
}
