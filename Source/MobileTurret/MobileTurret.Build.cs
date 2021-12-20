// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class MobileTurret : ModuleRules
{
	public MobileTurret(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });
	}
}
