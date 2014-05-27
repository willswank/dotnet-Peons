using System.Data;

namespace Peons.NUnit.DataSets
{
	public static class DataTableExtensions
	{
		public static DataRow AddRow(this DataTable table)
		{
			var row = table.NewRow();
			table.Rows.Add(row);
			return row;
		}
	}
}