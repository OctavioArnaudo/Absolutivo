public class ActionEnable : MapsActions
{
    protected override void OnEnable()
    {
        base.OnEnable();
        displacementAction.Enable();
        jumpAction.Enable();
    }
}