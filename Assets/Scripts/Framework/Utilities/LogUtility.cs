using System;
using UnityEngine;

namespace Game
{
	public enum LogLevel
	{
		Normal,
		Warning,
		Error,
	}
	public interface ILogUtility : IUtility
	{
		public void Log(string log, LogLevel level = LogLevel.Normal);
	}
	
	public class DebugLogUtility : ILogUtility
	{
		public void Log(string log, LogLevel level = LogLevel.Normal)
		{
			switch (level)
			{
				case LogLevel.Normal:
					Debug.Log(log);
					break;
				case LogLevel.Warning:
					Debug.LogWarning(log);
					break;
				case LogLevel.Error:
					Debug.LogError(log);
					break;
			}
		}
	}
}