using System.Collections.Generic;

public class RankList
{
    private ICollection<Team> teams;

    public RankList()
    {
        this.teams = new List<Team>();
    }

    public void Add(Team team)
    {
        this.teams.Add(team);
    }


}
