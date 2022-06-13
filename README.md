# Process-Watcher
shitty process watcher

usage: 

```cs
 public class Kato2
    {
        private ProcessWatcher Watcher = new ProcessWatcher();
        
        public static bool AutoInjectToggle { get; set; }
        
        public void AutoInject()
        {
            if (!AutoInjectToggle)
                return;

            Task.Factory.StartNew(() =>
            {
                Watcher.Created += process
                    => Inject();

                Watcher.Auto();
            });
        }
```
