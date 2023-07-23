namespace Game_Vehicle;

using GameFramework;

public class CSharpPlayerController : APlayerController
{
    /** MappingContext */
    UInputMappingContext DefaultMappingContext;

    protected override void BeginPlay()
    {
        base.BeginPlay();

        //Add Input Mapping Context
        APlayerController PlayerController = Cast<APlayerController>(this);
        if (PlayerController != null)
        {
            UEnhancedInputLocalPlayerSubsystem Subsystem = ULocalPlayer.GetSubsystem<UEnhancedInputLocalPlayerSubsystem>(PlayerController.GetLocalPlayer());
            if (Subsystem != null)
            {
                Subsystem.AddMappingContext(DefaultMappingContext, 0);
            }
        }

       

    }

}