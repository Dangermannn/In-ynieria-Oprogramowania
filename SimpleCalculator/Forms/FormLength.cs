using SimpleCalculator.Abstracts;
using SimpleCalculator.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator.Forms
{
    public partial class FormLength : ChildForm
    {
        private LengthConverter _lengthConverter;
        public FormLength()
        {
            InitializeComponent();
            AddUnitsToComboBox(comboBoxConvertFrom);
            AddUnitsToComboBox(comboBoxConvertTo);
            _lengthConverter = new LengthConverter();
            _lengthConverter.SetLength(0);
            textBoxValue.Text = "0";
        }

        private void AddUnitsToComboBox(ComboBox comboBox)
        {
            comboBox.Items.Add(LengthUnits.Milimeters);
            comboBox.Items.Add(LengthUnits.Centimeters);
            comboBox.Items.Add(LengthUnits.Meters);
            comboBox.Items.Add(LengthUnits.Kilometers);
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double valueFromTextBox;
            try
            {
                if (String.IsNullOrEmpty(textBoxValue.Text))
                    throw new Exception("Field cannot be empty!");
                labelError.Text = "";
                Double.TryParse(textBoxValue.Text, out valueFromTextBox);
                _lengthConverter.SetLength(Double.Parse(textBoxValue.Text));
                if (comboBoxConvertFrom.SelectedItem == null || comboBoxConvertTo.SelectedItem == null)
                    throw new ArgumentNullException(null, "Pick a unit!");
                labelResult.Text = Math.Round(
                                    _lengthConverter.HandleConverter(
                                    comboBoxConvertFrom.SelectedItem.ToString(), comboBoxConvertTo.SelectedItem.ToString()), 2).ToString();

            }
            catch (ArgumentNullException ex)
            {
                labelError.Text = ex.Message;
            }
            catch (Exception ex)
            {
                labelError.Text = ex.Message;
            }
        }

        private void textBoxValue_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxValue.Text))
                return;
            var result = Double.TryParse(textBoxValue.Text, out _);
            if (!result)
                textBoxValue.Text = textBoxValue.Text.Remove(textBoxValue.Text.Length - 1);
        }
    }
}
