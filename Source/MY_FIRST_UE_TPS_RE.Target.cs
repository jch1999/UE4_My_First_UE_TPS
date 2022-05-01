// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class MY_FIRST_UE_TPS_RETarget : TargetRules
{
	public MY_FIRST_UE_TPS_RETarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.Add("MY_FIRST_UE_TPS_RE");
	}
}
