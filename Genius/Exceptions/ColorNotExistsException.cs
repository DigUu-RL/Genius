namespace Genius.Exceptions;

[Serializable]
public class ColorNotExistsException : Exception
{
	public ColorNotExistsException() : base("This color doesn't exist!") { }
}
