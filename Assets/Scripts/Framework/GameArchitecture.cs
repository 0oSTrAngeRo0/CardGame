using UnityEngine;

namespace Game
{
    public class GameArchitecture : Architecture<GameArchitecture>
    {
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ClearStatic()
        {
            mArchitecture = null;
        }
        
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