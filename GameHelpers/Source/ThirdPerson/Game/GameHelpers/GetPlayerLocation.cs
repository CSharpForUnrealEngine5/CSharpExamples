namespace Game.GameHelpers;

using GameFramework;
using static GameFramework.AActor;

public static class ActorExtensions
{
    public static FVector GetPlayerLocation(this AActor AnActor, bool showDebugMessage = false)
    {
        //GetWorld()->GetFirstPlayerController()->GetPawn()->GetActorLocation();
        UWorld theWorld = AnActor.GetWorld();
        APlayerController LocalPlayer = theWorld.GetFirstPlayerController();
        APawn PlayerPawn = LocalPlayer.GetPawn();
        return PlayerPawn.GetActorLocation();
    }
}
