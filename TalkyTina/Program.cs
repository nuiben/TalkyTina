using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalkyTina
{
    class Program
    {
        // MVC Menu Screen
        static void Main(string[] args)
        {

            ConsoleView view = new ConsoleView();
            PhraseLibrary model = new PhraseLibrary();
            int userSelection;
            do
            {
                userSelection = view.ShowMenu();
                if (userSelection == 1)
                {
                    model.AddPhrase(view.NewPhrase());
                }
                else if (userSelection == 2)
                {
                    model.RemovePhrase(view.DeletePhrase());
                }
                else if (userSelection == 3)
                {
                    view.DisplayPhrases(model.ListPhrases());
                    model.PlayPhrase(view.PlayPhrase());
                }
            }
            while (userSelection != 4);
        }
    }
}
