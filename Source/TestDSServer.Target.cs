// Copyright 1998-2017 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

[SupportedPlatforms(UnrealPlatformClass.Server)]
public class TestDSServerTarget : TargetRules    // Change this line of code as shown previously
{
	public TestDSServerTarget(TargetInfo Target) : base(Target) // Change this line of code as shown previously
       {
              Type = TargetType.Server;
              ExtraModuleNames.Add("TestDS");   // Change this line of code as shown previously
       }
}
