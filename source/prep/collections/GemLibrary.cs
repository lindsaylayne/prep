using System;
using System.Collections.Generic;

namespace prep.collections
{
  public class GemLibrary
  {
    IList<Gem> gems;

	public GemLibrary(IList<Gem> list_of_gems)
    {
		this.gems = list_of_gems;
    }

	public IEnumerable<Gem> all_movies()
    {
      return this.gems;
    }

    public void add(Gem gem)
    {
      throw new NotImplementedException();
    }

	public IEnumerable<Gem> sort_all_movies_by_title_descending()
    {
      throw new NotImplementedException();
    }
  }
}