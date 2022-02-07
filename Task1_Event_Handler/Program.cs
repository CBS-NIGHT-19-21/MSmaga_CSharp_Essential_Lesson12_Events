namespace Events
{
    // Declare ClassDelegate PressKeyEventDelegate().
    public delegate void PressKeyEventDelegate();

    // Declare ClassDelegate EventDelegate().
    public class Keyboard
    {
        // Declare field as delegate  => Event-Delegate.
        // So the field turns into Event.

        // Can be virtual.
        public event PressKeyEventDelegate? PressA = null;
        public event PressKeyEventDelegate? PressB = null;
        public event PressKeyEventDelegate? PressC = null;
        public event PressKeyEventDelegate? PressD = null;
        public event PressKeyEventDelegate? PressE = null;
        public event PressKeyEventDelegate? PressF = null;

        // Call Method which located in Event-Delegate myEvent.
        public void PressAEvent()
        {
            if (PressA != null) PressA!.Invoke();
        }
        public void PressBEvent()
        {
            if (PressB != null) PressB!.Invoke();
        }
        public void PressCEvent()
        {
            if (PressC != null) PressC!.Invoke();
        }
        public void PressDEvent()
        {
            if (PressD != null) PressD!.Invoke();
        }
        public void PressEEvent()
        {
            if (PressE != null) PressE!.Invoke();
        }
        public void PressFEvent()
        {
            if (PressF != null) PressF!.Invoke();
        }
        public void Start()
        {
            while (true)
            {
                string? str = Console.ReadLine();
                switch (str)
                {
                    case "a":
                    case "A":
                        PressAEvent();
                        break;
                    case "b":
                    case "B":
                        PressBEvent();
                        break;
                    case "c":
                    case "C":
                        PressCEvent();
                        break;
                    case "d":
                    case "D":
                        PressDEvent();
                        break;
                    case "e":
                    case "E":
                        PressEEvent();
                        break;
                    case "f":
                    case "F":
                        PressFEvent();
                        break;
                    case "exit":
                        goto Exit;

                    default:
                        Console.WriteLine("There is no handler {0}", str);
                        break;
                }
            }
        Exit:
            Console.WriteLine("Exit!");
        }
    }
    class Programm
    {
        // HandlerMethods.
        static private void PressAHandler()
        {
            Console.WriteLine("    *     ");
            Console.WriteLine("   * *    ");
            Console.WriteLine("  *****   ");
            Console.WriteLine(" *     *  ");
            Console.WriteLine("*       * ");
        }

        static private void PressBHandler()
        {
            Console.WriteLine(" *****    ");
            Console.WriteLine(" *    *    ");
            Console.WriteLine(" *****   ");
            Console.WriteLine(" *    *  ");
            Console.WriteLine(" *****   ");
        }

        static private void PressCHandler()
        {
            Console.WriteLine(" ******    ");
            Console.WriteLine(" *    *    ");
            Console.WriteLine(" *         ");
            Console.WriteLine(" *    *    ");
            Console.WriteLine(" ******    ");
        }

        static private void PressDHandler()
        {
            Console.WriteLine(" *****     ");
            Console.WriteLine(" *    *    ");
            Console.WriteLine(" *    *    ");
            Console.WriteLine(" *    *    ");
            Console.WriteLine(" *****     ");
        }

        static private void PressEHandler()
        {
            Console.WriteLine(" *****     ");
            Console.WriteLine(" *         ");
            Console.WriteLine(" *****     ");
            Console.WriteLine(" *         ");
            Console.WriteLine(" *****     ");
        }

        static private void PressFHandler()
        {
            Console.WriteLine(" *****     ");
            Console.WriteLine(" *         ");
            Console.WriteLine(" *****     ");
            Console.WriteLine(" *         ");
            Console.WriteLine(" *         ");
        }
 
        static void Main()
        {
            // Declare instance of the class whitch
            // consists Event.
            Keyboard keyboard = new Keyboard();

            // Connect Handlers to Event of the instance.
            keyboard.PressA += PressAHandler;
            keyboard.PressB += PressBHandler;
            keyboard.PressC += PressCHandler;
            keyboard.PressD += PressDHandler;
            keyboard.PressE += PressEHandler;
            keyboard.PressF += PressFHandler;

            keyboard.Start();
      


            // Delay
            Console.ReadLine();
        }
    }
}
