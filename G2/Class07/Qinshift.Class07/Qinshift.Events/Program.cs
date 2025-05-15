


using Qinshift.Events.Entities;

AlarmClock alarmClock = new AlarmClock();
Person person = new Person { Name = "Martin"};
Person ana = new Person { Name = "Ana" };
Person sandra = new Person { Name = "Sandra" };

alarmClock.OnAlarmSounded += person.WakeUp;

alarmClock.OnAlarmSounded += ana.WakeUp;

alarmClock.OnAlarmSounded += sandra.WakeUp;



alarmClock.Start();

Thread.Sleep(5000);

if (person.HasWokeUp)
{
    Console.WriteLine($"{person.Name} has woke up!");
    alarmClock.OnAlarmSounded -= person.WakeUp;
}


alarmClock.Start();
