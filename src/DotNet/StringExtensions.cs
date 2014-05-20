namespace Peons.DotNet
{
	public static class StringExtensions
	{
		public static bool IsNullOrWhiteSpace(this string value)
		{
			return string.IsNullOrWhiteSpace(value);
		}

		public static bool IsNullOrEmpty(this string value)
		{
			return string.IsNullOrEmpty(value);
		}

		public static bool HasVisibleCharacters(this string value)
		{
			return !string.IsNullOrWhiteSpace(value);
		}
	}
}
