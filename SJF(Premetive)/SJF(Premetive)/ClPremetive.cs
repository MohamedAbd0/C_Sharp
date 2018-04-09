using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJF_Premetive_
{
    
        class SJF_Preemptive_
        {
            public int timer = 0;


            bool s = false;
            public int sjf_pree(ClassProcess[] arr)
            {
                if (s == true)
                {
                    return -1;
                }
                /*------------------find processes that arrived in this time ----------------*/
                int num_ele = 0;//number of proceses that arrived
                for (int n = 0; n < arr.Length; n++)//to calcu number of proceses that arrived by timer
                {
                    if (arr[n].arrival <= timer && (arr[n].end == false))
                    {
                        num_ele++;
                    }
                }
                if (num_ele == 0)//if not find any process arrived by the time
                {
                    timer++;
                    sjf_pree(arr);
                    if (s == true)
                    {
                        return -1;
                    }
                }
                int node = 0;//to save nodes of arr2
                ClassProcess[] arr2 = new ClassProcess[num_ele];
                for (int b = 0; b < arr.Length; b++)
                {
                    if (arr[b].arrival <= timer && (arr[b].end == false))
                    {
                        arr2[node] = arr[b];
                        node++;
                    }
                }
                /*---------------------------------------------------------------------*/


                /*------------------find the shotest burst time in arr2 ----------------*/

                //---------------------> sort arr2 nodes by bursh 
                ClassProcess x; //x use to swape the value in nodes
                for (int r = 0; r < arr.Length; r++)
                {
                    for (int m = 0; m < arr2.Length - 1; m++)
                    {
                        if (arr2[m].burst > arr2[m + 1].burst)
                        {
                            x = arr2[m];
                            arr2[m] = arr2[m + 1];
                            arr2[m + 1] = x;
                        }
                    }
                }//then the shortest burst time in the node arr2[0]

                //find the same node in arr using ID
                int node_num = 0;
                for (int a = 0; a < arr.Length; a++)
                {
                    if (arr2[0].id == arr[a].id)
                    {
                        node_num = a;
                    }
                }// then the shortest node is arr[node_num]
                /*------------------------end of find the shotest-----------------------*/

                /*---------------operation on the selected node-------------------------*/
                if (arr[node_num].worked == 0)
                {
                    arr[node_num].start = timer;
                    arr[node_num].opened = true;
                }
                //--------------to calcul the wait time 
                if (arr[node_num].worked == 0)
                {
                    arr[node_num].wait += arr[node_num].start - arr[node_num].arrival;
                }
                else
                {
                    arr[node_num].wait += timer - arr[node_num].last_see;
                }
                //-------------------------------------

                arr[node_num].worked++;
                arr[node_num].burst--;
                timer++;
                arr[node_num].last_see = timer;



                if (arr[node_num].worked == arr[node_num].source_burst)
                {
                    arr[node_num].finish = timer;
                    arr[node_num].end = true;
                    arr[node_num].opened = false;
                    arr[node_num].TA = arr[node_num].finish - arr[node_num].arrival;
                }

                /*---------------------------end of operation--------------------------*/
                for (int z = 0; z < arr.Length; z++)
                {
                    if (arr[z].end == false)
                    {
                        sjf_pree(arr);
                        if (s == true)
                        {
                            return -1;
                        }
                    }
                }
                s = true;
                return -1;
                /*------------------------------end of method--------------------------*/
            }

        }
    }

