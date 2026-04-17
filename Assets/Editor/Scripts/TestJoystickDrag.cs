using System.Reflection;
using UnityEngine;
/// <summary>
/// Runtime smoke test for KTO.Game.UIJoyStick drag.
/// Reads private state via reflection, then invokes the private UpdateJoyStick
/// to confirm the math actually moves swiper/handle/arrow.
/// </summary>
public static class TestJoystickDrag
{
    public static void Execute()
    {
        var js = KTO.Game.UIJoyStick.Inst;
        if (js == null)
        {
            Debug.LogError("[JoyTest] KTO.Game.UIJoyStick.Inst is null — Start() never ran.");
            return;
        }
        Debug.Log("[JoyTest] Inst OK on " + js.gameObject.name);

        var f = typeof(KTO.Game.UIJoyStick);
        var flags = BindingFlags.NonPublic | BindingFlags.Instance;

        var areaField = f.GetField("_joyStickArea", flags);
        Rect area = (Rect)areaField.GetValue(js);
        Debug.Log(string.Format("[JoyTest] _joyStickArea: x={0}  y={1}  w={2}  h={3}", area.x, area.y, area.width, area.height));

        Debug.Log("[JoyTest] swiper   = " + (js.swiper != null ? js.swiper.name : "NULL"));
        Debug.Log("[JoyTest] handle   = " + (js.handle != null ? js.handle.name : "NULL"));
        Debug.Log("[JoyTest] arrow    = " + (js.arrow  != null ? js.arrow.name  : "NULL"));

        // Simulate a drag: start in the middle of the joystick area, drag 80 px up-right.
        Vector2 mid = new Vector2(area.x + area.width * 0.5f, area.y + area.height * 0.5f);
        Vector2 end = mid + new Vector2(80f, 80f);
        Debug.Log("[JoyTest] simulated touch start=" + mid + " end=" + end);

        var m = f.GetMethod("UpdateJoyStick", flags);
        if (m == null) { Debug.LogError("[JoyTest] UpdateJoyStick method not found"); return; }
        m.Invoke(js, new object[] { mid, end });

        Debug.Log("[JoyTest] swiper.anchoredPosition after drag = " + js.swiper.anchoredPosition);
        Debug.Log("[JoyTest] handle.anchoredPosition after drag = " + js.handle.anchoredPosition);
        Debug.Log("[JoyTest] arrow.rotation.eulerZ after drag   = " + js.arrow.rotation.eulerAngles.z);

        var reset = f.GetMethod("ResetJoyStick", flags);
        reset.Invoke(js, null);
        Debug.Log("[JoyTest] reset done.");
    }
}
