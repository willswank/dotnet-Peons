using NUnit.Framework;
using System.Data;

namespace Peons.NUnit.DataSets
{
	[TestFixture]
	class DataTableExtensionsTests
	{
		[Test]
		public void AddRow_AddsNewRowToTableAndReturnsNewRow()
		{
			var table = new DataTable();
			var row = table.AddRow();
			Assert.AreEqual(1, table.Rows.Count);
			Assert.AreEqual(table.Rows[0], row);
		}
	}
}