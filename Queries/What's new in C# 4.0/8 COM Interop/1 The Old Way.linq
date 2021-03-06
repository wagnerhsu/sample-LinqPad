<Query Kind="Statements">
  <GACReference>Microsoft.Office.Interop.Excel, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c</GACReference>
  <GACReference>Microsoft.Office.Interop.Word, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c</GACReference>
  <Namespace>Microsoft.Office.Interop.Excel</Namespace>
</Query>

var missing = System.Reflection.Missing.Value;

var excel = new Application();
excel.Visible = true;
Workbook workBook = excel.Workbooks.Add (missing);
excel.Cells [1, 1] = "Hello world";

workBook.SaveAs (@"temp.xlsx", missing, missing, missing, missing,
	missing, XlSaveAsAccessMode.xlNoChange, missing, missing,
	missing, missing, missing);