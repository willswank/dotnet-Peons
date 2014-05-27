using NUnit.Framework;
using System;
using System.Data;

namespace Peons.NUnit.DataSets
{
	[TestFixture]
	class DataRowExtensionsTests
	{
		[Test]
		public void Set_Null_SetsValueOfColumnToDbNull()
		{
			var table = new DataTable();
			var columnName = "testColumn";
			table.Columns.Add(columnName, typeof(int));
			var row = table.NewRow();
			row.Set(columnName, (object)null);
			Assert.AreEqual(row[columnName], DBNull.Value);
		}

		[Test]
		public void Set_NonNull_SetsValueOfColumn()
		{
			int input = 42;
			var table = new DataTable();
			var columnName = "testColumn";
			table.Columns.Add(columnName, typeof(int));
			var row = table.NewRow();
			row.Set(columnName, input);
			Assert.AreEqual(row.Field<int>(columnName), input);
		}

		[Test]
		public void Set_ReturnsRow()
		{
			var table = new DataTable();
			var columnName = "testColumn";
			table.Columns.Add(columnName, typeof(int));
			var input = table.NewRow();
			var output = input.Set(columnName, 42);
			Assert.AreEqual(input, output);
		}

		[Test]
		public void FillValueTypeDefaults_ReturnsRow()
		{
			var table = new DataTable();
			var input = table.NewRow();
			var output = input.FillValueTypeDefaults();
			Assert.AreEqual(input, output);
		}

		[Test]
		public void FillValueTypeDefaults_DbNullValueTypeColumn_SetsValueToDefault()
		{
			var table = new DataTable();
			var columnName = "testColumn";
			table.Columns.Add(columnName, typeof(int));
			var row = table.NewRow();
			row.FillValueTypeDefaults();
			var output = row.Field<int>(columnName);
			Assert.AreEqual(default(int), output);
		}

		[Test]
		public void FillValueTypeDefaults_DbNullReferenceTypeColumn_LeavesValueAsDbNull()
		{
			var table = new DataTable();
			var columnName = "testColumn";
			table.Columns.Add(columnName, typeof(string));
			var row = table.NewRow();
			row.FillValueTypeDefaults();
			var output = row.Field<string>(columnName);
			Assert.AreEqual(null, output);
		}

		[Test]
		public void FillValueTypeDefaults_NonNullColumn_LeavesValues()
		{
			var table = new DataTable();
			var columnAName = "testValueColumn";
			var columnBName = "testReferenceColumn";
			table.Columns.Add(columnAName, typeof(int));
			table.Columns.Add(columnBName, typeof(string));
			var row = table.NewRow();
			var inputInt = 42;
			var inputString = "foobar";
			row[columnAName] = inputInt;
			row[columnBName] = inputString;
			row.FillValueTypeDefaults();
			var outputInt = row.Field<int>(columnAName);
			var outputString = row.Field<string>(columnBName);
			Assert.AreEqual(inputInt, outputInt);
			Assert.AreEqual(inputString, outputString);
		}
	}
}