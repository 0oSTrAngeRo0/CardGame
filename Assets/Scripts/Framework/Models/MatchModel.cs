using System.Collections.Generic;

namespace Game
{
    public interface IMatchModel : IModel
    {
        /// <summary>
        /// 回合数
        /// </summary>
        public BindableProperty<uint> TurnCount { get; }
        
        /// <summary>
        /// 当前回合的玩家编号，玩家编号的取值范围：[0, 玩家数量]
        /// </summary>
        public BindableProperty<uint> CurrentPlayer { get; }
        
        /// <summary>
        /// 对局中的玩家数量，玩家编号不得大于玩家数量
        /// </summary>
        public BindableProperty<uint> TotalPlayer { get; }
        
        /// <summary>
        /// 所有玩家信息，字典含义：[玩家编号， 玩家信息]
        /// </summary>
        public Dictionary<uint, IPlayer> Players { get; }
    }

    public class MatchModel : AbstractModel, IMatchModel
    {
        protected override void OnInit()
        {
            TurnCount = new BindableProperty<uint>();
            CurrentPlayer = new BindableProperty<uint>();
            TotalPlayer = new BindableProperty<uint>();
            Players = new Dictionary<uint, IPlayer>();
        }

        public BindableProperty<uint> TurnCount { get; private set; }
        public BindableProperty<uint> CurrentPlayer { get; private set; }
        public BindableProperty<uint> TotalPlayer { get; private set; }
        public Dictionary<uint, IPlayer> Players { get; private set; }
    }
}