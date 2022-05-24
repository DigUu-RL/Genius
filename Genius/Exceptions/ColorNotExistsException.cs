namespace Genius.Exceptions
{
	public class ColorNotExistsException : Exception
	{
		public ColorNotExistsException() : base("This color doesn't exist!") { }
	}
}
