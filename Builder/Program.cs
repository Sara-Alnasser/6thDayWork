using System;

namespace Builder
{
    class Program
    {
        class MyBuilder {

            private String Recipe;

            public MyBuilder()
            {
                this.Recipe = "";
            }
            public MyBuilder RecipeName(string value)
            {
                this.Recipe += "***"+value+"***" ;
                return this;
            }
            public MyBuilder RecipeIngredints(string value)
            {
                this.Recipe += "" + value + "";
                return this;
            }
            
            public MyBuilder RecipeMethods(string value)
            {
                this.Recipe += "" + value + "";
                return this;
            }
           
            public MyBuilder RecipeURL(string value)
            {
                this.Recipe +="URL:(" + value + ")";
                return this;
            }
            public String get()
            {
                return this.Recipe;
            }
        }

        static void Main(string[] args)
        {
            MyBuilder MB = new MyBuilder();
            String s = MB.RecipeName("Sweet Carrot").RecipeIngredints(" " +
                "\n\t # 10 large Carrots " +
                "\n\t # 2 medium Apples " +
                "\n\t # 1 / 4 cup Parsley(optional)").RecipeMethods(" \n\t #### Wash, prep, and chop produce." +
                "\n\t #### Add produce to juicer one at a time.Serve cold over ice. " +
                "\n\t #### May store in tightly sealed jars or glasses in the refrigerator for 7-10 days. " +
                "\n\t #### Shake or stir well before drinking.  ").RecipeURL(" \n\n https://www.modernhoney.com/healthy-juice-cleanse-recipes/").get();
            Console.WriteLine(s);
        }
    }

}