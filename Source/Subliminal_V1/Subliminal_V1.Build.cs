// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Subliminal_V1 : ModuleRules
{
	public Subliminal_V1(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"Subliminal_V1",
			"Subliminal_V1/Variant_Horror",
			"Subliminal_V1/Variant_Horror/UI",
			"Subliminal_V1/Variant_Shooter",
			"Subliminal_V1/Variant_Shooter/AI",
			"Subliminal_V1/Variant_Shooter/UI",
			"Subliminal_V1/Variant_Shooter/Weapons"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
