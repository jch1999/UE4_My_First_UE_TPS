// Copyright Epic Games, Inc. All Rights Reserved.

#include "MY_FIRST_UE_TPS_REGameMode.h"
#include "MY_FIRST_UE_TPS_RECharacter.h"
#include "UObject/ConstructorHelpers.h"

AMY_FIRST_UE_TPS_REGameMode::AMY_FIRST_UE_TPS_REGameMode()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnBPClass(TEXT("/Game/ThirdPersonCPP/Blueprints/ThirdPersonCharacter"));
	if (PlayerPawnBPClass.Class != NULL)
	{
		DefaultPawnClass = PlayerPawnBPClass.Class;
	}
}
