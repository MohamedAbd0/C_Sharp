using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace os_project
{
    class Process
    {
        string process_id, arrival_time, burst_time ;
        int startTime,remaind,FinishTime;

        public Process(string process_id ,string arrival_time,string burst_time)
        {
            this.process_id = process_id;
            this.arrival_time = arrival_time;
            this.burst_time = burst_time;
            remaind = int.Parse(burst_time);
        }
        public double Wt
        {
            get { return Ta - (int.Parse(burst_time)); }
        }
        public double Ta
        {
            get { return FinishTime -(int.Parse( arrival_time)); }
        }
        public string Process_id
        {
            set { process_id = value; }
            get { return process_id; }
        }
        public string Arrival_Time
        {
            set { arrival_time = value; }
            get { return arrival_time; }
        }
        public string Burst_Time
        {
            set { burst_time = value; }
            get { return burst_time; }
        }
        public int StartTime
        {
            set { startTime = value; }
            get { return startTime; }
        }
        public int Remaind
        {
            set { remaind = value; }
            get { return remaind; }
        }
        
        public int finishTime
        {
            set { FinishTime = value; }
            get { return FinishTime; }
        }


        public override string ToString()
        {
            return process_id + "," + arrival_time + ";" + burst_time;
        }

      public static void sortarray(List<Process> l)
        {
            if (l.Count > 0)
            {
                int temp, inner;
                   
                for (int outer = 1; outer <l.Count; outer++)
                {
                    string id = l[outer].process_id;
                    int arr = int.Parse(l[outer].arrival_time);
                
                    temp = int.Parse(l[outer].Burst_Time);
                    inner = outer;

                    while (inner > 0 && int.Parse(l[inner - 1].Burst_Time) >= temp)
                    {

                        l[inner].Burst_Time = l[inner - 1].Burst_Time;
                        l[inner].process_id = l[inner - 1].process_id;
                        l[inner].arrival_time=l[inner - 1].arrival_time;
                        inner -= 1;

                    }

                    l[inner].Burst_Time = temp.ToString();
                    l[inner].process_id = id;
                    l[inner].arrival_time = arr.ToString();
                }
            }

        }

      public static void sortarrR(List<Process> list)
      {

          for (int i = 0; i < list.Count; i++)
          {
              int min = i;
              for (int j = i + 1; j < list.Count; j++)
              {
                  if (list[j].remaind < list[min].remaind)
                  {
                      min = j;
                  }
              }
              if (min != i)
              {
                  Process temp = list[i];
                  list[i] = list[min];
                  list[min] = temp;
              }
          }

      }

      public static void sortarray_ar(List<Process> l)
      {
          
              for (int i = 0; i <(l.Count); i++)
            {
                for (int j = 0; j <(l.Count-1); j++)
                {
                    if (int.Parse(l[j].Arrival_Time )> int.Parse(l[j + 1].Arrival_Time)&&int.Parse(l[j].Burst_Time) < int.Parse(l[j + 1].Burst_Time))
                    {
                            Process chan = l[j];
                            l[j] = l[j + 1];
                            l[j + 1] = chan;
                    }
                }
            }
                     


              
          }

      public static void sortarrARR(List<Process> l)
      {
          if (l.Count > 0)
          {
              int temp, inner;

              for (int outer = 1; outer < l.Count; outer++)
              {
                  string id = l[outer].process_id;
                  int arr = int.Parse(l[outer].burst_time);

                  temp = int.Parse(l[outer].arrival_time);
                  inner = outer;

                  while (inner > 0 && int.Parse(l[inner - 1].Burst_Time) >= temp)
                  {

                      l[inner].arrival_time = l[inner - 1].arrival_time;
                      l[inner].process_id = l[inner - 1].process_id;
                      l[inner].burst_time = l[inner - 1].burst_time;
                      inner -= 1;

                  }

                  l[inner].arrival_time = temp.ToString();
                  l[inner].process_id = id;
                  l[inner].burst_time = arr.ToString();
              }
          }

      }

      public static int ProcessorTime(List<Process> l)
      {
          int Time = 0;
          foreach (Process item in l)
          {
              Time += int.Parse(item.burst_time);
          }
          return Time;
      }
      public static void Sort_arrival(List<Process> list)
      {
          for (int i = 0; i < list.Count; i++)
          {
              int min = i;
              for (int j = i + 1; j < list.Count; j++)
              {
                  if (int.Parse(list[j].Arrival_Time) <int.Parse( list[min].Arrival_Time))
                  {
                      min = j;
                  }
              }
              if (min != i)
              {
                  Process temp = list[i];
                  list[i] = list[min];
                  list[min] = temp;
              }
          }
      }
      
    }
}
