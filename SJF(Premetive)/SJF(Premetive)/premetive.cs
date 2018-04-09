using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJF_Premetive_
{
    class premProject
    {
        

            public int timer = 0;//??????????

            bool b = false;//??????????
            public int non_prem(ClassProcess[] arr)
            {
                if (b == true)
                {
                    return -1;//بتخرجنا من الميثود
                }

                //العمليات اللى وصلت فى الوقت ده
                int number_process = 0; // عدد العمليات اللى وصلت 

                //بيدور على العمليات اللى وصلت ونحطها فى اراى
                for (int i = 0; i < arr.Length; i++) // لحساب عدد العمليات اللى وصلت فى الوقت
                {
                    if (arr[i].arrival /*يشوف كل عنصر*/ <= timer/*اللى هو وصل فى الوقت ده*/ && arr[i].end /**/== false)//ده بيفضل بفولص لحد اخر واحده تبقى تروو
                    {
                        number_process++; //كام عمليه وصلت عدد
                    }
                }
                if (number_process == 0)// لو عدد عمليات وصلت فى نفس الوقت
                {
                    timer++;//زود التايمر واحد
                    non_prem(arr);//?????? //عيد الميثود تانى
                    if (b == true)
                    {
                        return -1;
                    }
                }
                int node = 0;//????????\ المكان اللى هيتخزنوا فيه
                ClassProcess[] arr2 = new ClassProcess[number_process];//هعمل ارراى بعددهم بحجهم عشان اخزنهم فيه
                for (int c = 0; c < arr.Length; c++)//هلف تانى على الارراى اللى فوق اللى كان بيلف يعد عدد العمليات كام
                {
                    if (arr[c].arrival <= timer && (arr[c].end == false))
                    {
                        arr2[node] = arr[c];//اول واحده هتتخزن فى صفر وبعدين ازود واحد واخزن فى واحد
                        node++;
                    }
                }
                ////////////////////////////////////
                ClassProcess d;//عشان نعرف نعمل اسواب
                for (int i = 0; i < arr.Length; i++)//??????? بيلف 
                {
                    for (int e = 0; e < arr2.Length - 1; e++)// هلفها بعدد عناصر الارراى 
                    {
                        if (arr2[e].burst/*هيلف على عناصر الارراى كلهم ولو لقة العنصر اللى قبله اكبر من اللى بعده يعمل بينهم اسواب*/ > arr2[e + 1].burst)//
                        {
                            d = arr2[e];//
                            arr2[e] = arr2[e + 1];//
                            arr2[e + 1] = d;//
                        }
                    }
                } //هنا انا هخرج من الارراى وكلها مترتبه من الصغير للكبير فاصغر عنصر موجوود فى اصغر خانه

                int node_number = 0;
                int id = arr2[0].id;//عشان اعرف مكانه فى الااراى الاصليه ف هدور ب الاى دى بتاعها
                for (int f = 0; f < arr.Length; f++)//هعمل لوب بيلف على  الارراى بيشوف الاى دى بتاع كل عنصر فى الارااى 
                {
                    if (id == arr[f].id)//بيدور على الاى دى بتاع كل عنصر فى الارراى بيشوف الااى دى بتاعه لو بيساوى الاى دى اللى احنا محددينه بيساوى مكانه فى النود نامبر
                    {
                        node_number = f;//العنصر اللى انا حددته بقى اسمه النود نامبر
                    }
                }
                ///////////////////////////////////////////////////??????????????
                ///////////////////////////////////?????????????? ناقص حته

                arr[node_number].start = timer;// ده اول حاجه هنبدا نشتغل عليها
                timer = timer + arr[node_number].burst;
                arr[node_number].finish = timer;
                arr[node_number].end = true;


                for (int g = 0; g < arr.Length; g++)//هنعمل لوب يلف على كل عنصر من الااراى لو لقى اند ب فولص يعيدها تانى لسه ما اتنفزش يعنى
                {
                    if (arr[g].end == false)
                    {
                        non_prem(arr);
                        if (b == true)
                        {
                            return -1;
                        }
                    }
                }


                b = true;//لما كل العمليات تتنفز
                return -1;//بيخرجنا بره الميثود كلها اللى هى نن برمتيف اللى فوق دى

            }

            public void cal_wait_TA(ClassProcess[] arr)
            {
                for (int h = 0; h < arr.Length; h++)
                {
                    arr[h].wait = arr[h].start - arr[h].arrival;

                    arr[h].TA = arr[h].finish - arr[h].arrival;
                }

            }


        }
    }

