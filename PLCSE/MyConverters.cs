namespace PLCSE;

public static class MyConverters
{
	public static MudBlazor.Converter<List<int>> IntList = new MudBlazor.Converter<List<int>>()
	{
		SetFunc = l => l.Count == 0 ? string.Empty : l.Select(i => $"{i};").Aggregate((to, add) => to + add),
		GetFunc = str => str.Replace(" ", null).Split(';', StringSplitOptions.RemoveEmptyEntries).Select(i => int.Parse(i)).ToList()
	};

	public static MudBlazor.Converter<int[]> IntArr = new MudBlazor.Converter<int[]>()
	{
		SetFunc = l => l.Length == 0 ? string.Empty : l.Select(i => $"{i};").Aggregate((to, add) => to + add),
		GetFunc = str => str.Replace(" ", null).Split(';', StringSplitOptions.RemoveEmptyEntries).Select(i => int.Parse(i)).ToArray()
	};
	public static MudBlazor.Converter<bool[]> BoolArr = new MudBlazor.Converter<bool[]>()
	{
		SetFunc = l => l.Length == 0 ? string.Empty : l.Select(i => $"{i};").Aggregate((to, add) => to + add),
		GetFunc = str => str.Replace(" ", null).Split(';', StringSplitOptions.RemoveEmptyEntries).Select(i => bool.Parse(i)).ToArray()
	};
}
