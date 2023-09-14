using System.Collections.Generic;
using System;
using System.Drawing;

namespace InputReplicator
{
    public class UserInput
    {
        public MouseMessage mouseMessage;
        public Point positionInScreen;
        public int msSinceLastClick;
        public UserInput(MouseMessage mouseMessage, Point positionInScreen)
        {
            this.mouseMessage = mouseMessage;
            this.positionInScreen = positionInScreen;
        }
    }
    public class ObservableInput : List<UserInput>
    {
        private DateTime lastAdditionTime;

        public new void Add(UserInput item)
        {
            item.msSinceLastClick = this.Count == 0 ? 0 : (int)(DateTime.Now - lastAdditionTime).TotalMilliseconds;

            Console.WriteLine($"L'élément {item} va être ajouté.");
            TimeSpan timeSinceLastAddition = DateTime.Now - lastAdditionTime;
            Console.WriteLine($"Délai depuis la dernière ajout : {timeSinceLastAddition.TotalMilliseconds} ms");
            lastAdditionTime = DateTime.Now;

            base.Add(item);
            Console.WriteLine($"L'élément {item} a été ajouté.");
        }
    }

}
