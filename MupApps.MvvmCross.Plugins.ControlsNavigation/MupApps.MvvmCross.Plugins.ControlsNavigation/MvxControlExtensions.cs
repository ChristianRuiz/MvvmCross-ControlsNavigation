
namespace MupApps.MvvmCross.Plugins.ControlsNavigation
{
    public static class MvxControlExtensions
    {
        public static EmptyControlBehaviours GetDefaultEmptyControlBehaviour(this IMvxControl control)
        {
            return EmptyControlBehaviours.Hide;
        }

        public static void CheckEmptyControlBehaviour(this IMvxControl control)
        {
            control.CheckEmptyControlBehaviour(null);
        }

        public static void CheckEmptyControlBehaviour(this IMvxControl control, EmptyControlBehaviours? lastBehaviour)
        {
            if ((lastBehaviour.HasValue && lastBehaviour == EmptyControlBehaviours.Hide)
                || (control.EmptyControlBehaviour == EmptyControlBehaviours.Hide && control.ViewModel != null))
                control.ChangeVisibility(true);

            if ((lastBehaviour.HasValue && lastBehaviour == EmptyControlBehaviours.Disable)
                || (control.EmptyControlBehaviour == EmptyControlBehaviours.Disable && control.ViewModel != null))
                control.ChangeVisibility(true);
         
            if (control.ViewModel == null)
            {
                if (control.EmptyControlBehaviour == EmptyControlBehaviours.Hide)
                    control.ChangeVisibility(false);
                else if (control.EmptyControlBehaviour == EmptyControlBehaviours.Disable)
                    control.ChangeEnabled(false);
            }
        }
    }
}
