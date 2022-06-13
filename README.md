# Process-Watcher
shitty process watcher
I can't be bothered to modify this for public usage, so enjoy kato src and hf figuring it out

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
        
        public void Inject()
        {
            if (!AutoInjectToggle && !Watcher.GetProcess())
            {
                MessageBox.Show("Please launch roblox first!", "Kato", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            Process roblox = Watcher.Process;
        }
```
