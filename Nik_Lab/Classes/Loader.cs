using System;
using System.Collections.Generic;
using System.IO;

namespace WorkShop_Nikiforov.Classes
{
    class Loader
    {
        public static void LoadRecipeFromTxt(List<Recipe> Recipes)
        {
            string path = @"C:\Users\Desh\Desktop\Projects\Nik_Lab\Nik_Lab\Recipes.txt";
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] strlist = line.Split(';');

                    Recipe Recipe_n = new Recipe(strlist[0]);

                    for (int l = 1; l < strlist.Length; l+=2)
                    {
                        Item baget = new Item(strlist[l], Convert.ToInt32(strlist[l+1]));
                        Recipe_n.MaterialsForRecipe.Add(baget);
                    }

                    Recipes.Add(Recipe_n);
                }
            }
        }
        public static void LoadMaterialsFromTxt(List<Materials> MaterialsInStorage)
        {
            string path = @"C:\Users\Desh\Desktop\Projects\Nik_Lab\Nik_Lab\Materials.txt";
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine())
                    != null)
                {
                    string[] strlist = line.Split(';');

                    Materials Material = new Materials(strlist[0], Convert.ToInt32(strlist[1]), Convert.ToInt32(strlist[2]));

                    MaterialsInStorage.Add(Material);
                }
            }
        }
    }
}
