// Tiny wrapper so coplay-mcp execute_script can fire the smoke test.
// Not a menu item — just a programmatic entry point.
public static class RunClickMoveSmoke
{
    public static void Execute()
    {
        ClickToMoveSmokeTest.Execute();
    }
}
