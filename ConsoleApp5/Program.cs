// https://youtu.be/T9BeejD3i0g?t=5193  
// if condition

// 如果 我肚子餓
//      我就去吃飯
bool hungry = true;

if(hungry)
{
    System.Console.WriteLine("Go to eat");
}

// 如果 今天有下雨
//      我就去開車上班
// 否則
//      我就走路去上班
bool rainy = false; 
if (rainy)
{
    System.Console.WriteLine("I go to work by walking");
}
else
{
    System.Console.WriteLine("I go to work by driving car");
}

/*
如果 你考100分
    我給你1000元
或是如果 你考80分以上
    我給你500元
或是如果 你考60分以上
    我給你100元
否則 
    你給我300元
*/
// int score = 100;

//System.Console.Write("Please input your score: ");
//int score = System.Convert.ToInt32(System.Console.ReadLine());

//if (score == 100)
//{
//    System.Console.WriteLine("I will give you a thousand");
//}
//else if (score >= 80)
//{
//    System.Console.WriteLine("I will give you 800");
//}
//else if (score >= 60)
//{
//    System.Console.WriteLine("I will give you 500");
//}
//else
//{
//    System.Console.WriteLine("You give me 300");
//}

/*
如果你考100分 且今天有下雨
    我給你1000元
否則
    你給我100元
*/
//int score = 90;
//bool rain = false;
//if (score == 100 && rain) 
//{
//    System.Console.WriteLine("我給你1000元");
//}
//else 
//{
//    System.Console.WriteLine("你給我100元");
//}
/*
如果你考100分 或 今天有下雨
    我給你1000元
否則
    你給我100元
*/
//if (score == 100 || rainy) // 只要其中一邊是true
//{
//    System.Console.WriteLine("我給你1000元");
//}
//else // 兩邊都是false
//{
//    System.Console.WriteLine("你給我100元");
//}

/* 
如果 你沒有考100分 或 今天沒有下雨
    我給你1000元
否則
    你給我100元
*/

int score = 100;
bool rain = false;

if (score != 100 || !rain)
        // false     false
{
    System.Console.WriteLine("我給你1000元");
}
else
{
    System.Console.WriteLine("你給我100元");
}