using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelDna.Integration;
using ExcelDna.Integration.CustomUI;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Excel;
using ApplicationXl = Microsoft.Office.Interop.Excel.Application;

using System.Diagnostics;
using System.Threading;
using System.Collections;

namespace Ribbon
{

	[ComVisible(true)]
	public class RibbonController : ExcelRibbon
	{

		private readonly int _excelThreadId;
		// private IteratorEditWindow _iteratorForm1;
		private Form _iteratorForm2;

		public RibbonController()
		{
			_excelThreadId = ExcelAddIn3.WindowsInterop.GetCurrentThreadId();
			//Control.CheckForIllegalCrossThreadCalls = false; // tried this here, doesnt't seem to do anything
		}

		private bool CheckWorkbook()
		{
			try
			{
				ApplicationXl app = (ApplicationXl)ExcelDnaUtil.Application;
				if (app.Workbooks.Count == 0)
				{
					MessageBox.Show("Please open a workbook before starting UI.", "Error");
					return false;
				}

				return true;
			}
			catch (Exception e)
			{
				Debug.Print("Couldn't check workbook: {0}", e);
				return false;
			}
		}




		
		public void ProblemSetUp(IRibbonControl control)
		{
			if (!CheckWorkbook())
			{
				return;
			}
			if (_iteratorForm2 == null)
			{
				try
				{
					_iteratorForm2 = new ExcelAddIn3.IteratorForm2(_excelThreadId);
					_iteratorForm2.Closed += delegate { _iteratorForm2 = null; };
					_iteratorForm2.Show();
				}
				catch (Exception e)
				{
					Debug.Print("Error: {0}", e);
				}
			}
			else
			{
				_iteratorForm2.Activate();
			}
		}





		public override string GetCustomUI(string RibbonID)
		{
			return @"
      <customUI xmlns='http://schemas.microsoft.com/office/2006/01/customui'>
      <ribbon>
        <tabs>
          <tab id='tab1' label='DotNetRefEditCollapse'>

            <group id='group3' label='Example'>
              <button id='g3_button1' label='Problem Set Up' onAction='On_g3_button1_Pressed'/>
			</group>
          </tab>
        </tabs>
      </ribbon>
    </customUI>";






			}




	

		public void On_g3_button1_Pressed(IRibbonControl control)
		{
			ProblemSetUp(control);
		}








	}







}