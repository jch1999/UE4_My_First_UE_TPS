// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class MY_FIRST_UE_TPS_RE : ModuleRules
{
	public MY_FIRST_UE_TPS_RE(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay" });
	}
}
