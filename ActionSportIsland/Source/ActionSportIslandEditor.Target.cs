

using UnrealBuildTool;
using System.Collections.Generic;

public class ActionSportIslandEditorTarget : TargetRules
{
	public ActionSportIslandEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "ActionSportIsland" } );
	}
}
