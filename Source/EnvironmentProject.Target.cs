// For copyright see LICENSE in EnvironmentProject root dir, or:
//https://github.com/UE4-OceanProject/OceanProject/blob/Master-Environment-Project/LICENSE

using UnrealBuildTool;
using System.Collections.Generic;

public class EnvironmentProjectTarget : TargetRules
{
	public EnvironmentProjectTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("EnvironmentProject");
	}
}
