namespace Game
{
    public class GameArchitecture : Architecture<GameArchitecture>
    {
        protected override void Init()
        {
            // Utilities
            RegisterUtility<ILogUtility>(new DebugLogUtility());
            
            // Models
            RegisterModel<IMatchModel>(new MatchModel());
            
            // Systems
        }
    }
}