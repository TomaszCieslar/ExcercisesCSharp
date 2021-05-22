using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LearningProjectsCSharp.DynamicMemory
{
    public class DynamicMemoryManagementArrayList
    {
        public void Main()
        {
            //Create a list of strings, using the class ArrayList which already exists in the DotNet Platform.

            // Once created, show all the items stored in the list.
            // Insert one new item in the second place of the list and then show again all the items checking if the insertion was correct.


            ArrayList miLista = new ArrayList();
            miLista.Add("item1");
            miLista.Add("item2");
            miLista.Add("item3");
            foreach (string frase in miLista)
                Console.WriteLine(frase);

            miLista.Insert(1, "item4");

            foreach (string frase in miLista)
                Console.WriteLine(frase);

            Console.ReadLine();
        }
    }
}
