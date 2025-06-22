namespace Demo
{
    internal class Program
    {
        class Person  
        {
            public string Name;
        }

        static void Main(string[] args)
        {
            #region Q01
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);
            Console.WriteLine("You entered: " + number);

            #endregion
            #region Q02
            string str = "123abc";
            int result = Convert.ToInt32(str); // This will throw exception

            #endregion
            #region Q03
            // برنامج بيجمع رقمين عشريين من نوع float
            float a = 5.5f;
            float b = 2.2f;
            float result = a + b;
            Console.WriteLine("Result: " + result);
            #endregion
            #region Q04
            string text = "Hello World";
            string part = text.Substring(6, 5);
            Console.WriteLine(part);

            #endregion
            #region Q05
            int a5 = 10;
            int b5 = a5;
            b5 = 20;

            Console.WriteLine("a = " + a5);
            Console.WriteLine("b = " + b5);

            // اللي هيحصل:
            //هتفضل قيمة a5زي ماهي 10 
            // لاننا لما عملنا b5 = a5 مغيرناش قيمه a5 
            // وقيمة المتغير b هتبقى 20 بعد التعديل.
            // ولما نسخنا a5 إلى b5، كل واحد بقى له نسخة مستقلة من القيمة.


            #endregion
            #region Q06


            Person p1 = new Person();
        p1.Name = "Ahmed";

        Person p2 = p1;
        p2.Name = "Ali";

       Console.WriteLine("p1 name = " + p1.Name);
       Console.WriteLine("p2 name = " + p2.Name);

            // اللي هيحصل:
            // الاسم في p1 هيتغير إلى "Ali" زي p2 بالضبط.
            // لأن النوع Person هو نوع مرجعي (reference type)،
            // وده معناه إن p1 و p2 بيشيروا لنفس الكائن في الذاكرة.

            #endregion
            #region @07
            string firstName = "Ahmed";
            string lastName = "Hashim";

            string fullName = string.Concat(firstName, " ", lastName);

            Console.WriteLine(fullName);

            #endregion
            #region Q08

            // السؤال 8:
            // What will be assigned to d in the following code?
            // int d;
            // d = Convert.ToInt32(!(30 < 20));

            // الخيارات:
            // a) 0
            // b) 1
            // c) -1
            // d) Error
            // e) Will only work if ! is replaced by Not

            // الإجابة الصحيحة:
            // b) A value 1 will be assigned to d.

            int d10 = Convert.ToInt32(!(30 < 20));
            Console.WriteLine("Value of d is: " + d10);


            #endregion

            #region Q09

            // السؤال 9:
            // ما هو الناتج الصحيح للكود التالي؟
            //
            // Console.WriteLine(13 / 2 + " " + 13 % 2);
            //
            // الاختيارات:
            // a) 6.5 1
            // b) 6.5 0
            // c) 6 0
            // d) 6 1
            // e) 6.5 6.5
            //
            // الإجابة الصحيحة:
            // d) 6 1
            //
            // الشرح:
            // 13 / 2 → نتيجة قسمة عددين صحيحين = 6 (بدون كسور)
            // 13 % 2 → باقي القسمة = 1
            // بيطبع: 6 + " " + 1 → الناتج النهائي: 6 1

            Console.WriteLine(13 / 2 + " " + 13 % 2);


            #endregion
            #region Q10
            // السؤال 10:
            // ما ناتج الكود التالي؟
            //
            // int num = 1, z = 5;
            //
            // if (!(num <= 0))
            //     Console.WriteLine(++num + z++ + " " + ++z);
            // else
            //     Console.WriteLine(--num + z-- + " " + --z);
            //
            // الاختيارات:
            // a) 5 6
            // b) 6 5
            // c) 6 6
            // d) 7 7
            //
            // الإجابة الصحيحة:
            // d) 7 7
            //
            // الشرح:
            // num = 1 → !(1 <= 0) = !(false) = true ⇒ هندخل في الـ if
            // ++num = 2 → يتم زيادته أولاً ثم استخدامه
            // z++ = 5 → يتم استخدام 5 أولاً ثم زيادته إلى 6
            // يبقى: 2 + 5 = 7
            // ++z = 7 → لأن z كان بقى 6 من السطر اللي فات، بيزيد يبقى 7
            // النتيجة: 7 7

            int num = 1, z = 5;

            if (!(num <= 0))
                Console.WriteLine(++num + z++ + " " + ++z);
            else
                Console.WriteLine(--num + z-- + " " + --z);

            #endregion


        }
    }
}
