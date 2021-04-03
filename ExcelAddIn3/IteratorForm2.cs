using ExcelDna.Integration;
using System;
using System.Windows.Forms;
using ApplicationXl = Microsoft.Office.Interop.Excel.Application;

namespace ExcelAddIn3
{
    public partial class IteratorForm2 : Form
    {
        private readonly ExcelSelectionTracker _selectionTracker;
        private readonly ApplicationXl _application;
        private RichTextBox _focusedBox;


        public IteratorForm2(int excelThreadId)
        {
            InitializeComponent();
            _selectionTracker = new ExcelSelectionTracker(excelThreadId);
            _application = (ApplicationXl)ExcelDnaUtil.Application;

            Closed += delegate
            {
                _selectionTracker.NewSelection -= ChangeText;
                _selectionTracker.Stop();
            };

            _selectionTracker.NewSelection += ChangeText;

            Deactivate += CheckFocus;

            inputBox1.TextChanged += OnNewInput;
            inputBox2.TextChanged += OnNewInput;

            inputBox1.KeyDown += CheckF4;
            inputBox2.KeyDown += CheckF4;
            destinationBox.KeyDown += CheckF4;


            // enter event for the InputBox1:
            inputBox1.KeyDown += inputBox1_CheckEnterKeyPress;
            inputBox2.KeyDown += inputBox2_CheckEnterKeyPress;
            destinationBox.KeyDown += destinationBox_CheckEnterKeyPress;




        }

        private void CheckFocus(object sender, EventArgs eventArgs)
        {
            if (inputBox1.Focused)
            {
                _focusedBox = inputBox1;
            }
            else if (inputBox2.Focused)
            {
                _focusedBox = inputBox2;
            }
            else if (destinationBox.Focused)
            {
                _focusedBox = destinationBox;
            }
            else
            {
                _focusedBox = null;
            }
        }


        /// <summary>
        /// Build final formula: to be run in UI thread
        /// </summary>
        /// <returns></returns>
        private string BuildFormula()
        {
            return string.Format("=sum({0},{1})", inputBox1.Text, inputBox2.Text);
        }


        /// <summary>
        /// Evaluate the formula: to be run in Excel thread
        /// </summary>
        private void UpdateEvaluation(string formula)
        {
            object formulaResult = ExcelHelper.EvaluateFormula(formula, _application);
            Invoke(new Action(() => EvaluationBox.Text = (formulaResult ?? "").ToString()));
        }

        private void OnNewInput(object sender, EventArgs e)
        {
            string formula = BuildFormula();
            ExcelAsyncUtil.QueueAsMacro(() => UpdateEvaluation(formula));
        }

        private void ChangeText(object sender, RangeAddressEventArgs args)
        {
            Invoke(new Action(() =>
            {
            if (_focusedBox != null)
            {
                _focusedBox.Text = args.Address;
                _focusedBox.Select(_focusedBox.Text.Length, 0);
                // want the cursor in the box so that you can hit enter instead of the button to go back to the rest of the form
                _focusedBox.Focus();
                }
            }));
        }

        private void CheckF4(object sender, KeyEventArgs e)
        {
            RichTextBox textBox = sender as RichTextBox;
            if (e.KeyCode == Keys.F4 && textBox != null)
            {
                string text = textBox.Text;

                ExcelAsyncUtil.QueueAsMacro(() =>
                {
                    string newAddress;
                    if (ExcelHelper.TryF4(text, _application, out newAddress))
                    {
                        Invoke(new Action(() =>
                        {
                            textBox.Text = newAddress;
                            textBox.Select(textBox.Text.Length, 0);
                        }));
                    }
                });
            }
        }


        private void InsertButton_Click(object sender, EventArgs e)
        {
            string formula = BuildFormula();
            string destination = destinationBox.Text;

            if (formula != null && !string.IsNullOrEmpty(destination))
            {
                ExcelAsyncUtil.QueueAsMacro(() => ExcelHelper.InsertFormula(formula, _application, destination));
            }
        }














        /// <summary>
        /// Buttons and handlers for the three RefEdit
        /// TODO The functions are very repetitive and are in need of refactoring
        /// </summary>


        private void inputBox1_RefEdit_Click(object sender, EventArgs e)
        {
            // collapse the form so that only the top strip is visible with the text box that is now visible
            // that is the actual inputBox that does the selecting, the one in the form is a fake mirror only
            this.inputBox1.Visible = true;
            this.inputBox1_RefEdit_Done.Visible = true;
            this.groupBox1.Visible = false;
            this.inputBox1.Focus();
            this.TopMost = true;

        }

        private void inputBox1_RefEdit_Done_Click(object sender, EventArgs e)
        {
            // uncollapse the form and go back to normal view
            // can be done via button or when inputbox accepts Enter, either way do the same thing
            this.inputBox1.Visible = false;
            this.inputBox1_RefEdit_Done.Visible = false;
            this.groupBox1.Visible = true;
            this.inputBox1_Mirror.Text = this.inputBox1.Text;
            // this.TopMost = true; // do we need this? No.

        }

        private void inputBox1_CheckEnterKeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // same as above for when the button is  pressed:
                this.inputBox1.Visible = false;
                this.inputBox1_RefEdit_Done.Visible = false;
                this.groupBox1.Visible = true;
                this.inputBox1_Mirror.Text = this.inputBox1.Text;

                // gets rid of the ding on enter into textbox:
                e.Handled = true;
                e.SuppressKeyPress = true;

            }

        }



        private void inputBox2_RefEdit_Click(object sender, EventArgs e)
        {
            // collapse the form so that only the top strip is visible with the text box that is now visible
            // that is the actual inputBox that does the selecting, the one in the form is a fake mirror only
            this.inputBox2.Visible = true;
            this.inputBox2_RefEdit_Done.Visible = true;
            this.groupBox1.Visible = false;
            this.inputBox2.Focus();
            this.TopMost = true;

        }

        private void inputBox2_RefEdit_Done_Click(object sender, EventArgs e)
        {
            // uncollapse the form and go back to normal view
            // can be done via button or when inputbox accepts Enter, either way do the same thing
            this.inputBox2.Visible = false;
            this.inputBox2_RefEdit_Done.Visible = false;
            this.groupBox1.Visible = true;
            this.inputBox2_Mirror.Text = this.inputBox2.Text;
            // this.TopMost = true; // do we need this? No.

        }

        private void inputBox2_CheckEnterKeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // same as above for when the button is  pressed:
                this.inputBox2.Visible = false;
                this.inputBox2_RefEdit_Done.Visible = false;
                this.groupBox1.Visible = true;
                this.inputBox2_Mirror.Text = this.inputBox2.Text;

                // gets rid of the ding on enter into textbox:
                e.Handled = true;
                e.SuppressKeyPress = true;

            }

        }




        private void destinationBox_RefEdit_Click(object sender, EventArgs e)
        {
            // collapse the form so that only the top strip is visible with the text box that is now visible
            // that is the actual inputBox that does the selecting, the one in the form is a fake mirror only
            this.destinationBox.Visible = true;
            this.destinationBox_RefEdit_Done.Visible = true;
            this.groupBox1.Visible = false;
            this.destinationBox.Focus();
            this.TopMost = true;

        }

        private void destinationBox_RefEdit_Done_Click(object sender, EventArgs e)
        {
            // uncollapse the form and go back to normal view
            // can be done via button or when inputbox accepts Enter, either way do the same thing
            this.destinationBox.Visible = false;
            this.destinationBox_RefEdit_Done.Visible = false;
            this.groupBox1.Visible = true;
            this.destinationBox_Mirror.Text = this.destinationBox.Text;
            // this.TopMost = true; // do we need this? No.

        }

        private void destinationBox_CheckEnterKeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // same as above for when the button is  pressed:
                this.destinationBox.Visible = false;
                this.destinationBox_RefEdit_Done.Visible = false;
                this.groupBox1.Visible = true;
                this.destinationBox_Mirror.Text = this.destinationBox.Text;

                // gets rid of the ding on enter into textbox:
                e.Handled = true;
                e.SuppressKeyPress = true;

            }

        }



    }






}
