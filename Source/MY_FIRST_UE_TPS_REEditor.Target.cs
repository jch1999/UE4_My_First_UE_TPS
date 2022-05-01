// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class MY_FIRST_UE_TPS_REEditorTarget : TargetRules
{
	public MY_FIRST_UE_TPS_REEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.Add("MY_FIRST_UE_TPS_RE");
	}
}
