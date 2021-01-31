using System;

namespace ClassWork26._01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pop
            string[] last = { "Hurmat", "Aka", "Chi", "heli" };
            string str = ArrayHelper.Pop(ref last);
            Console.WriteLine(str);
            //
            int[] lastNum = { 3, 65, 23, 654, 231, 23 };
            int num = ArrayHelper.Pop(ref lastNum);
            Console.WriteLine(num);
            //
            double[] lastDouble = { 1.1, 3.5, 6.7, 35.2, 65.7 };
            double doubleNum = ArrayHelper.Pop(ref lastDouble);
            Console.WriteLine(doubleNum);
            //
            decimal[] lastDecimal = { 3.2m, 4324.4m, 22.5m, 432.4m };
            decimal decimalNum = ArrayHelper.Pop(ref lastDecimal);
            Console.WriteLine(decimalNum);
            //
            float[] lastFloat = { 1.3f, 32.5f,432.4f,54.6f };
            float floatNum = ArrayHelper.Pop(ref lastFloat);
            Console.WriteLine(floatNum);
            //Push
            string[] pushString = new string[] { "Developer", "Tester", "Product Owner", "Scrum Master" };
            int arrayPush = ArrayHelper.Push(ref pushString, "Project Manager");
            Console.WriteLine("Pushed String " + arrayPush);
            //
            int[] pushInt = new int[] { 21, 43, 54, 32, 45, 45, 21, 4 };
            int arrayPushInt = ArrayHelper.Push(ref pushInt, 22);
            Console.WriteLine("Pushed Integer " + arrayPushInt);
            //
            double[] pushDouble = new double[] { 432.123, 4324.34, 3423.33, 3432.5, 343.3 };
            double arrayPushDouble = ArrayHelper.Push(ref pushDouble, 92);
            Console.WriteLine("Pushed double " + arrayPushDouble);
            //
            decimal[] pushDecimal = new decimal[] { 3213.43m, 22.3m, 3.1m, 443.6m };
            decimal arrayPushDecimal = ArrayHelper.Push(ref pushDecimal, 323.4m);
            Console.WriteLine("Pushed decimal "+ arrayPushDecimal);
            //
            float[] pushFloat = new float[] { 322.4f, 2.3f, 43.4f, 9.4f, 4.3f };
            float arrayPushFloat = ArrayHelper.Push(ref pushFloat, 1.1f);
            Console.WriteLine("Pushed Float " + arrayPushFloat);
            //Shift
            string[] shiftString = new string[] { "Accounter", "Lawyer", "Security" };
            string str2 = ArrayHelper.Shift(ref shiftString);
            Console.WriteLine("Shifted String -- " + str2);
            //
            int[] shiftInt = new int[] { 2,5,6,32,1,5,21};
            int shiftInt2 = ArrayHelper.Shift(ref shiftInt);
            Console.WriteLine("Shifted Int -- " + shiftInt2);
            //
            double[] shiftDouble = new double[] { 1.2, 45.3, 54.3 };
            double shiftDouble2 = ArrayHelper.Shift(ref shiftDouble);
            Console.WriteLine("Shifted Double -- " + shiftDouble2);
            //
            decimal[] shiftDecimal = new decimal[] { 1.2m, 43.4m, 46.6m };
            decimal shiftDecimal2 = ArrayHelper.Shift(ref shiftDecimal);
            Console.WriteLine("Shifted Decimal -- " + shiftDecimal2 );
            //
            float[] shiftFloat = new float[] { 1.9f, 43.4f, 46.6f};
            float shiftFloat2 = ArrayHelper.Shift(ref shiftFloat);
            Console.WriteLine("Shifted Decimal -- " + shiftFloat2);
            //Unshift
            string[] unShiftString = new string[] { "Developer", "Tester", "Scrum Master" };
            int unShiftstr = ArrayHelper.UnShift(ref unShiftString, "Product Owner");
            Console.WriteLine("Un Shifted Element -- " + unShiftstr);
            //
            int[] unShiftInt = new int[] { 3,4,5,5,2, };
            int unShiftInt1 = ArrayHelper.UnShift(ref unShiftInt, 2);
            Console.WriteLine("Un Shifted Element -- " + unShiftInt1);
            //
            double[] unShiftDouble = new double[] { 3.1, 4.2, 5.4, 5.1, 2,6 };
            double unShiftDouble1 = ArrayHelper.UnShift(ref unShiftDouble, 2);
            Console.WriteLine("Un Shifted Element -- " + unShiftDouble1);
            //
            decimal[] unShiftDecimal = new decimal[] { 3.1m, 4.2m, 5.4m, 5.1m, 2.6m };
            decimal unShiftDecimal1 = ArrayHelper.UnShift(ref unShiftDecimal, 2);
            Console.WriteLine("Un Shifted Element -- " + unShiftDecimal1);
            //
            float[] unShiftFloat = new float[] { 3.1f, 4.2f, 5.4f, 5.1f, 2.6f };
            float unShiftFloat1 = ArrayHelper.UnShift(ref unShiftFloat, 2);
            Console.WriteLine("Un Shifted Element -- " + unShiftFloat1);
        }
    }
    public static class ArrayHelper
    {
        //Pop Methods
        public static string Pop(ref string[] lastElement)
        {
            string arrLastElement = lastElement[lastElement.Length - 1];
            return arrLastElement;
        }
        public static int Pop(ref int[] lastElement)
        {
            int arrLastElement = lastElement[lastElement.Length - 1];
            return arrLastElement;
        }
        public static double Pop(ref double[] lastElement)
        {
            double arrLastElement = lastElement[lastElement.Length - 1];
            return arrLastElement;
        }
        public static decimal Pop(ref decimal[] lastElement)
        {
            decimal  arrLastElement = lastElement[lastElement.Length - 1];
            return arrLastElement;
        }
        public static float Pop(ref float[] lastElement)
        {
            float arrLastElement = lastElement[lastElement.Length - 1];
            return arrLastElement;
        }
        //Push Methods
        public static int Push(ref string[] addToLast, string updatedArray)
        {
            Array.Resize(ref addToLast, addToLast.Length + 1);
            addToLast[addToLast.Length - 1] = updatedArray;
            return addToLast.Length;
        }
        public static int Push(ref int[] addToLast, int updatedArray)
        {
            Array.Resize(ref addToLast, addToLast.Length + 1);
            addToLast[addToLast.Length - 1] = updatedArray;
            return addToLast.Length;
        }
        public static double Push(ref double[] addToLast, double updatedArray)
        {
            Array.Resize(ref addToLast, addToLast.Length + 1);
            addToLast[addToLast.Length - 1] = updatedArray;
            return addToLast.Length;
        }
        public static decimal Push(ref decimal[] addToLast, decimal updatedArray)
        {
            Array.Resize(ref addToLast, addToLast.Length + 1);
            addToLast[addToLast.Length - 1] = updatedArray;
            return addToLast.Length;
        }
        public static float Push(ref float[] addToLast, float updatedArray)
        {
            Array.Resize(ref addToLast, addToLast.Length+1);
            addToLast[addToLast.Length - 1] = updatedArray;
            return addToLast.Length;
        }
        //Shift Methods
        public static string Shift(ref string[] shiftElement)
        {
            string shift = shiftElement[0];
            for (int i = 0; i < shiftElement.Length -1; i++)
            {
                shiftElement[i] = shiftElement[i + 1];
            }
            Array.Resize(ref shiftElement, shiftElement.Length - 1);
            return shift;
        }
        public static int Shift(ref int[] shiftElement)
        {
            int shift = shiftElement[0];
            for (int i = 0; i < shiftElement.Length - 1; i++)
            {
                shiftElement[i] = shiftElement[i + 1];
            }
            Array.Resize(ref shiftElement, shiftElement.Length - 1);
            return shift;
        }
        public static double Shift(ref double[] shiftElement)
        {
            double shift = shiftElement[0];
            for (int i = 0; i < shiftElement.Length - 1; i++)
            {
                shiftElement[i] = shiftElement[i + 1];
            }
            Array.Resize(ref shiftElement, shiftElement.Length - 1);
            return shift;
        }
        public static decimal Shift(ref decimal[] shiftElement)
        {
            decimal shift = shiftElement[0];
            for (int i = 0; i < shiftElement.Length - 1; i++)
            {
                shiftElement[i] = shiftElement[i + 1];
            }
            Array.Resize(ref shiftElement, shiftElement.Length - 1);
            return shift;
        }
        public static float Shift(ref float[] shiftElement)
        {
            float shift = shiftElement[0];
            for (int i = 0; i < shiftElement.Length - 1; i++)
            {
                shiftElement[i] = shiftElement[i + 1];
            }
            Array.Resize(ref shiftElement, shiftElement.Length - 1);
            return shift;
        }
        //Unshift Methods
        public static int UnShift(ref string[] addToFirst, string toFirstElement)
        {
            Array.Resize(ref addToFirst, addToFirst.Length + 1);
            for (int i = addToFirst.Length -1; i >= 1; i--)
            {
                addToFirst[i] = addToFirst[i - 1];
            }
            addToFirst[0] = toFirstElement;
            return addToFirst.Length - 1;
        }
        public static int UnShift(ref int[] addToFirst, int toFirstElement)
        {
            Array.Resize(ref addToFirst, addToFirst.Length + 1);
            for (int i = addToFirst.Length - 1; i >= 1; i--)
            {
                addToFirst[i] = addToFirst[i - 1];
            }
            addToFirst[0] = toFirstElement;
            return addToFirst.Length - 1;
        }
        public static double UnShift(ref double[] addToFirst, double toFirstElement)
        {
            Array.Resize(ref addToFirst, addToFirst.Length + 1);
            for (int i = addToFirst.Length - 1; i >= 1; i--)
            {
                addToFirst[i] = addToFirst[i - 1];
            }
            addToFirst[0] = toFirstElement;
            return addToFirst.Length - 1;
        }
        public static decimal UnShift(ref decimal[] addToFirst, decimal toFirstElement)
        {
            Array.Resize(ref addToFirst, addToFirst.Length + 1);
            for (int i = addToFirst.Length - 1; i >= 1; i--)
            {
                addToFirst[i] = addToFirst[i - 1];
            }
            addToFirst[0] = toFirstElement;
            return addToFirst.Length - 1;
        }
        public static float UnShift(ref float[] addToFirst, float toFirstElement)
        {
            Array.Resize(ref addToFirst, addToFirst.Length + 1);
            for (int i = addToFirst.Length - 1; i >= 1; i--)
            {
                addToFirst[i] = addToFirst[i - 1];
            }
            addToFirst[0] = toFirstElement;
            return addToFirst.Length - 1;
        }
    }

}
