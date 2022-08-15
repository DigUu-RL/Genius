using Genius.Exceptions;
using Color = Genius.Enums.Color;

namespace Genius.Classes;

public static class Extensions
{
	/// <summary>
	/// Converte um número do tipo <see cref="int"/> em seu correspondente na enumaração <see cref="Color"/>
	/// </summary>
	/// <returns></returns>
	/// <exception cref="ColorNotExistsException"></exception>
	public static Color ToColor(this int x)
	{
		return x switch
		{
			0 => Color.Yellow,
			1 => Color.Blue,
			2 => Color.Green,
			3 => Color.Red,
			_ => throw new ColorNotExistsException()
		};
	}
}
