// Copyright Epic Games, Inc. All Rights Reserved.

#include "MobileTurretGameMode.h"
#include "MobileTurretPawn.h"

AMobileTurretGameMode::AMobileTurretGameMode()
{
	// set default pawn class to our flying pawn
	DefaultPawnClass = AMobileTurretPawn::StaticClass();
}
