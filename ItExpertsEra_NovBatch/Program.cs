// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Console.WriteLine("Welcome to ItExpertsEra");

//Console.Write("I am Tanushree");
//Console.WriteLine("I am BCA student");

//Console.WriteLine("================================================");

//int firstNumber = 100;

//int secondNumber = 200; 

//int result = firstNumber + secondNumber;

//Console.WriteLine("The sum of two numbers is " + result);


//Console.WriteLine("================================================");

//Console.WriteLine("Please enter your first number");

//int first =Convert.ToInt32(Console.ReadLine());  //123 "123"

//Console.WriteLine("Please enter your second number");

//int second =Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Please enter the operation you want to perform");

//string operation = Console.ReadLine();

//int result = 0;

//// Conditional Statement

//if (operation == "Sum")
//{
//    result = first + second;
//}
//else if (operation == "Subtract")
//{
//    result = first - second;
//}
//else if (operation == "Multiply")
//{
//    result = first * second;
//}
//else if (operation == "Divide")
//{
//    result = first / second;
//}
//else
//{
//    Console.WriteLine("You have entered wrong operation.");
//}


//Console.WriteLine("The " + operation + " of two numbers is " + result);



// Q => tell if number is even number and greater than 100. 

//Console.WriteLine("Please enter your number");

//int number = Convert.ToInt32(Console.ReadLine());

//if ( number % 2 == 0 && number > 100)
//{
//    Console.WriteLine(number + " is an even number and greater than 100");
//}
//else
//{
//    Console.WriteLine(number + " is either not even or less than 100");
//}

// Q. tell if number is even number or greater than 100. 

//if (number % 2 == 0 || number > 100)
//{
//    Console.WriteLine(number + " is an even number or greater than 100");
//}
//else
//{
//    Console.WriteLine(number + " is either not even or less than 100");
//}

//Console.WriteLine("Please enter first student name ?");
//string Student1 = Console.ReadLine();

//Console.WriteLine("Please Enter Your Maths Number");
//int student1MathsNo = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Please Enter Your Hindi Number");
//int student1HindiNo = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Please Enter Your SST Number");
//int student1SSTNo = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Please Enter Your Science Number");
//int student1ScienceNo = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Please Enter Your English Number");
//int student1EngNo = Convert.ToInt32(Console.ReadLine());

//// Result of Student 1 

//int student1TotalMarks = student1MathsNo + student1HindiNo + student1SSTNo + student1ScienceNo + student1EngNo;
//int totalMarks = 500;

//int student1Percentage = (student1TotalMarks * 100) / totalMarks;

//// To Check pass
//string student1Result = "";
//if (student1Percentage < 33)
//{
//    student1Result = "Fail";
//}
//else if (student1Percentage > 33 && student1Percentage <= 40)
//{
//    student1Result = "Third";
//}
//else if (student1Percentage > 40 && student1Percentage <= 60)
//{
//    student1Result = "Second";
//}
//else
//{
//    student1Result = "First";
//}

//Console.WriteLine("Name of the first student is " + Student1);
//Console.WriteLine(Student1 + " got the total marks of " + student1TotalMarks + " out of " + totalMarks);
//Console.WriteLine(Student1 + " got the total percentage of " + student1Percentage);
//Console.WriteLine(Student1 + " is " + student1Result);


//uint varUint = 20;

//char varChar = 'a';

//bool varBool;

//object varObj = 's';

//string varStr = "this is a string";

//DateTime varDate = DateTime.Now;

//string varStr2 ="";


//Console.WriteLine(varUint);
//Console.WriteLine(varChar);
//Console.WriteLine(varBool);
//Console.WriteLine(varObj);
//Console.WriteLine(varDate);
//Console.WriteLine(varUint);
//Console.WriteLine(varStr);


///////////////////////////////////////////////////////////// 23rd November 2023 /////////////////////////////////////////////

// Collections.. Array

using ItExpertsEra_NovBatch;
using System.Globalization;
///
int[] arrayInt = new int[5]; // Array Declaration

// Data insert into the array

arrayInt[0] = 10;
arrayInt[1] = 20;
arrayInt[2] = 30;
arrayInt[3] = 40;
arrayInt[4] = 50;


// update value into the array. 

arrayInt[2] = 100;

//Console.WriteLine(arrayInt[0]);


// Loops 

//for loop. 

//for (int i = 0; i < arrayInt.Length; i++) //0, 1, 2, 3, 4
//{
//    Console.WriteLine(arrayInt[i]);
//}

//for (int i = 4; i >= 0; i--) //0, 1, 2, 3, 4
//{
//    Console.WriteLine(arrayInt[i]);
//}

// print table in console. 

int j = 1;

//for (int i = 10; i <= 100; i = i + 10)
//{
//    Console.WriteLine("10 * " + j + " = " + i);
//    j++;
//}

// print first 10 natural number 


//for (int k = 1; k <=10; k++)
//{
//    Console.WriteLine(k);
//}

//int sum = 0;

//for (int i = 1; i <= 10; i++)
//{
//    sum = sum + i;

//    Console.WriteLine(sum);
//}

//Console.WriteLine("The sum of first 10 natural number is " + sum);


// foreach

//string[] arrayString = new string[5] {"Shrikant", "Tanushree", "Shivani", "Aniket", "Anjali"};

//foreach (string value in arrayString)
//{

//        Console.WriteLine(value);

//}

// while loop

int i = 0;

//while (i < 10)
//{
//    Console.WriteLine(i);

//    i++;
//



// do while

//do
//{
//    Console.WriteLine(i);

//     i++;
//}
//while (i < 10);

//MethodExample objMethodEx = new MethodExample();

//objMethodEx.TestMethod();

//objMethodEx.Sum(20, 40);

//int result =  objMethodEx.Sum2(50, 50);

//string concatData = objMethodEx.Add("Tanushree", "Aggarwal");

//int[] arrayInt2 = new int[] { 10, 20, 30, 40 };

//int resultArray = objMethodEx.SumArray(arrayInt2);

///////////////////////////////////////// 05th December 2023 //////////////////////////////////
///

MethodOverloadingExample ex = new MethodOverloadingExample();

//ex.Sum("string");
//ex.Sum(10);
//ex.Sum();

//ex.Sum(10, 20);

//Cars Wagonr = new Cars();

//Wagonr.Name = "WagonR"; // setting the proeprties value. it will call setter of prperty. 
//Wagonr.Color = "Red";
//Wagonr.NoOfSeats = 4;
//Wagonr.IsHatchBack = true;


//Wagonr.Model = "latest";



//Console.WriteLine(Wagonr.Name);
//Console.WriteLine(Wagonr.Color);
//Console.WriteLine(Wagonr.NoOfSeats);
//Console.WriteLine(Wagonr.IsHatchBack);
//Console.WriteLine(Wagonr.MyProperty);
//Console.WriteLine(Wagonr.Model);

//////////////////////////////////////////////////// 07 December 2012 ///////////////////////////////
///

//int test;

//StaticExample objStatic = new StaticExample();

//objStatic.a = 100;

//StaticExample objStatic2 = new StaticExample();

//objStatic2.a = 250;
//Console.WriteLine(objStatic2.a); // 100

//StaticExample objStatic3 = new StaticExample();

//objStatic2.a = 2500;
//Console.WriteLine(objStatic3.a); // 100

//StaticExample objStatic4 = new StaticExample();

//objStatic4 = objStatic;

//objStatic4.a = 500;

//Console.WriteLine(objStatic4.a); //100  
//Console.WriteLine(objStatic.a); //500

//objStatic.a = 1000;

//Console.WriteLine(objStatic4.a);

//objStatic4 = objStatic;
//objStatic = null;

//objStatic4 = objStatic;

//objStatic4 = objStatic2;

//Console.WriteLine(objStatic.a); // error will come

//Console.WriteLine(objStatic4.a); //1000

////////////////////////////////////////////////////////////////// 16 December 2023 ////////////////////////////////////////////////////////

//MathsOperation objMaths = new MathsOperation();

//int var1 = 30;
//int result1 = objMaths.Sum(var1, 50);

//int result2 = objMaths.Sum(50, 100);

//int result3 = objMaths.Sum(100, 30);

//int[] arrayint = new int[5] { 10, 20, 40, 50, 60 };

//int result4 = objMaths.Sum(new int[3] {10, 20, 30});

//int result5 = objMaths.Sum(new int[4] { 1, 2, 3, 4, });

//string var7 = "Harry";

//string[] result6 = objMaths.GetAllStrings("Tom", "Jack", var7);

//foreach (string str in result6)
//{
//    Console.WriteLine(str); 
//}


//////////////////////////////////////////// 21 Dec 2023 ///////////////////////////


ConstructorExample.varStaticInt = 100;

//ConstructorExample objConstructor = new ConstructorExample();
//ConstructorExample objConstructor6 = new ConstructorExample();
//ConstructorExample objConstructor2 = new ConstructorExample(100);
//ConstructorExample objConstructor3 = new ConstructorExample(100, 200);

//ConstructorExample objConstructor4 = new ConstructorExample(objConstructor3);

//Console.WriteLine(objConstructor.varInt);
//Console.WriteLine(objConstructor2.varInt);
//Console.WriteLine(objConstructor3.varInt);
//Console.WriteLine(objConstructor4.varInt);


//ConstructorExample.TestMethod();

//Console.WriteLine("Static value " + ConstructorExample.varStaticInt);


//////////////////////////////////// 2nd January 2024 ////////////////////////////////////
///

//InheritanceExample.var1 = 200; // there is no statement to pass parameter for static constructor

//InheritanceExample objinheritance = new InheritanceExample(10);

//Child objChild = new Child();

//objChild.ChildMethod();
//objChild.ParentMethod();


//Parent objParent = new Parent();

//objParent.ParentMethod();

//GrandChild objGrandChild = new GrandChild();

//objGrandChild.ParentMethod();
//objGrandChild.ChildMethod();
//objGrandChild.GrandChildMethod();

//Child2 objChild2 = new Child2();

//objChild2.ParentMethod();
//objChild2.Child2Method();



//////////////////////////////////////////  4th Jan 2024 //////////////////////////////

//B objB = new B();

//objB.TestMethod();

//objB.TestMethod2();

////////////////////////////////////////////////////////////
/////

////A objA = new B();

////objA.TestMethod();
////objA.TestMethod2();

//AccessModifier objAccess = new AccessModifier();


//objAccess.varpublicInt = 100;

///////////////////////////// 16th January 2024 /////////////////////////////

//TestClass objTest = new TestClass();

//int result = objTest.Sum(10, 20);

//int result2 = objTest.Difference(10, 20);

//objTest.ChildMethod();

//objTest.GoodMethod();

//ITestInterface objInterface1 = new TestClass();

//objInterface1.GoodMethod2();
//objInterface1.Sum(20,40);


//ITestInterface2 objInterface2 = new TestClass();
//objInterface2.GoodMethod2();
//objInterface2.Difference(50, 30);


//Console.WriteLine(result);
//Console.WriteLine(result2);

/////////////////////////////////////// 18th January 2024 //////////////////

//ChildClass1 objChildClass = new ChildClass1();

//PartialClassExample objPartial = new PartialClassExample();

//objPartial.TestMethod();
//objPartial.TestMethod2();

//CollectionExample objCol = new CollectionExample();

//objCol.ArrayListExample();

//objCol.HashTableExample();


///////////////////////////////////// 02nd February 2024 ///////////////////////

ExceptionHandlingExample objException = new ExceptionHandlingExample();

objException.TestMethod(5);






Console.ReadLine();