using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            TextEditor textEditor = new TextEditor();
            Compiller compiller = new Compiller();
            CLR clr = new CLR();

            VisualStudioFacade ide = new VisualStudioFacade(textEditor, compiller, clr);

            Programmer programmer = new Programmer();
            programmer.CreateApplication(ide);

            Console.ReadKey();
        }
    }

    class TextEditor
    {
        public void CreateCode()
        {
            Console.WriteLine("Write some code");
            Console.ReadKey();
            Console.WriteLine("Get bugs");
            Console.ReadKey();
            Console.WriteLine("Fix bugs");
            Console.ReadKey();
            Console.WriteLine("One eternity later");
            Console.ReadKey();
            Console.WriteLine("BugFixed");
        }
        public void Save()
        {
            Console.WriteLine("Save code");
        }
    }
    class Compiller
    {
        public void Compile()
        {
            Console.WriteLine("Compile code");
        }
    }
    class CLR
    {
        public void Execute()
        {
            Console.WriteLine("Run your app");
        }
        public void Finish()
        {
            Console.WriteLine("Exit your app");
            Console.ReadKey();
            Console.WriteLine("Publish your app");
        }
    }

    class VisualStudioFacade
    {
        TextEditor textEditor;
        Compiller compiller;
        CLR clr;
        public VisualStudioFacade(TextEditor te, Compiller compil, CLR clr)
        {
            this.textEditor = te;
            this.compiller = compil;
            this.clr = clr;
        }
        public void Start()
        {
            textEditor.CreateCode();
            Console.ReadKey();
            textEditor.Save();
            Console.ReadKey();
            compiller.Compile();
            Console.ReadKey();
            clr.Execute();
        }
        public void Stop()
        {
            clr.Finish();
        }
    }

    class Programmer
    {
        public void CreateApplication(VisualStudioFacade facade)
        {
            facade.Start();
            facade.Stop();
        }
    }
}
