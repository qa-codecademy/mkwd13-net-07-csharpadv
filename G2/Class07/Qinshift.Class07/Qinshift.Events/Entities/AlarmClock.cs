namespace Qinshift.Events.Entities
{
    public class AlarmClock
    {
        //old way
        public delegate void AlarmSounded();
        public event AlarmSounded OnAlarmSounded;

        // new way
        // In order to use this way, you need a delegate that will accept
        // two arguments: object source and EventArgs args

        //public delegate void AlarmSoundedNew(object source, EventArgs args);
        //public EventHandler<AlarmSounded> OnAlarmRing;

        public void Start()
        {
            Console.WriteLine("Alarm is about to ring!");
            Thread.Sleep(3000);
            OnAlarmSounded?.Invoke();
            //OnAlarmRing(source, args);
        }
    }
}
