using System;

namespace ConsoleApp {
    public class BankTerminal {
        protected string id;

        public BankTerminal(string id) {
            this.id = id;
        }
        public virtual void Connect() { 
            Console.WriteLine("General Connecting Server...");
        }
    }

    public class ModelXTerminal : BankTerminal {
        public ModelXTerminal(string id) : base(id) {
           
        }
        public override void Connect() {
            base.Connect();
            Console.WriteLine("Additional actions for model X");
        }
    }
}