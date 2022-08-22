using System.Runtime.CompilerServices;

namespace PLCSE;

public static class MyConverters
{
	public static IntListConverter ILC = new IntListConverter();
	public static IntArrConverter IAC = new IntArrConverter();
	public static BoolArrConverter BAC = new BoolArrConverter();
	public static VectorConverter VC = new VectorConverter();

	public class IntListConverter : MudBlazor.DefaultConverter<List<int>>
	{
		protected override List<int> ConvertFromString(string str) =>
			string.IsNullOrEmpty(str)
				? new List<int>()
				: str.Replace(" ", null).Split(';', StringSplitOptions.RemoveEmptyEntries)
					.Where(i => !string.IsNullOrEmpty(i)).Select(int.Parse).ToList();

		protected override string ConvertToString(List<int> l) =>
			l.Count == 0 ? string.Empty : l.Select(i => $"{i};").Aggregate((to, add) => to + add);
	}

	public class IntArrConverter : MudBlazor.DefaultConverter<int[]>
	{
		protected override int[] ConvertFromString(string str)
		{
			var result = string.IsNullOrEmpty(str)
				? new int[0]
				: str.Replace(" ", null).Split(';', StringSplitOptions.RemoveEmptyEntries)
					.Where(i => !string.IsNullOrEmpty(i)).Select(int.Parse).ToArray();
			return result;
		}

		protected override string ConvertToString(int[] l) =>
			l.Length == 0 ? string.Empty : l.Select(i => $"{i};").Aggregate((to, add) => to + add);
	}

	public class BoolArrConverter : MudBlazor.DefaultConverter<bool[]>
	{
		protected override bool[] ConvertFromString(string str) =>
			string.IsNullOrEmpty(str)
				? new bool[0]
				: str.Replace(" ", null).Split(';', StringSplitOptions.RemoveEmptyEntries)
					.Where(i => !string.IsNullOrEmpty(i)).Select(bool.Parse).ToArray();

		protected override string ConvertToString(bool[] l) =>
			l.Length == 0 ? string.Empty 
				: l.Select(i => $"{i};").Aggregate((to, add) => to + add);
	}

	public class VectorConverter : MudBlazor.DefaultConverter<Vector3>
	{
		protected override Vector3 ConvertFromString(string str)
		{
			if (str.Count(c => c == ';') != 2) return Vector3.zero;
			try
			{
				var coords = str.Split(';', StringSplitOptions.RemoveEmptyEntries).Select(s => float.Parse(s))
					.ToArray();
				return new Vector3(coords[0], coords[1], coords[2]);
			}
			catch
			{
				return Vector3.zero;
			}
		}

		protected override string ConvertToString(Vector3 v) => $"{v.x};{v.y};{v.z}";
	}
}
