

using UnrealBuildTool;
using System.Collections.Generic;

public class ActionSportIslandTarget : TargetRules
{
	public ActionSportIslandTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "ActionSportIsland" } );
	}
}
