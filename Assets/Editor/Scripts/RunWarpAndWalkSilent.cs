using KTO.Game;

/// <summary>
/// Second warp-and-walk run — with DebugLogWalker OFF (default) — to
/// confirm the gating works (should produce no [WalkerDiag] entries
/// while still walking the player to the target).
/// </summary>
public static class RunWarpAndWalkSilent
{
    public static void Execute()
    {
        PlayerMotor.DebugLogWalker = false; // explicit, matches default
        WarpAndWalk.Execute();
    }
}

/// <summary>
/// Third run — verbose, for regression reference.
/// </summary>
public static class RunWarpAndWalkVerbose
{
    public static void Execute()
    {
        PlayerMotor.DebugLogWalker = true;
        WarpAndWalk.Execute();
    }
}
