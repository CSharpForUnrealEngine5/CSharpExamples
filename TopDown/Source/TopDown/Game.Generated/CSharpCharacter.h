#pragma once
#include "CoreMinimal.h"
#include "GameFramework/Character.h"
#include "GameFramework/CharacterMovementComponent.h"
#include "Components/CapsuleComponent.h"
#include "Camera/CameraComponent.h"
#include "GameFramework/SpringArmComponent.h"
#include "CSharpCharacter.generated.h"
UCLASS(Blueprintable, BlueprintType, ClassGroup = (Custom), meta = (BlueprintSpawnableComponent))
class ACSharpCharacter : public ACharacter {
GENERATED_BODY()
public:
UPROPERTY(BlueprintReadWrite,EditAnywhere)
UCameraComponent* TopDownCameraComponent;
UPROPERTY(BlueprintReadWrite,EditAnywhere)
USpringArmComponent* CameraBoom;
ACSharpCharacter();
};
