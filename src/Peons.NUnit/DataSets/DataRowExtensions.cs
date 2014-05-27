using System;
using System.Data;

namespace Peons.NUnit.DataSets
{
	public static class DataRowExtensions
	{
		public static DataRow Set<T>(this DataRow row,
				string columnName, T value)
		{
			if (value == null)
			{
				row[columnName] = DBNull.Value;
			}
			else
			{
				row[columnName] = value;
			}
			return row;
		}

		public static DataRow FillValueTypeDefaults(this DataRow row)
		{
			var columns = row.Table.Columns;
			for (int i = 0; i < columns.Count; i++)
			{
				var column = columns[i];
				if (column.DataType.IsValueType
					&& row[column.ColumnName] == DBNull.Value)
				{
					var value = Activator.CreateInstance(column.DataType);
					row[column.ColumnName] = value;
				}
			}
			return row;
		}
	}
}