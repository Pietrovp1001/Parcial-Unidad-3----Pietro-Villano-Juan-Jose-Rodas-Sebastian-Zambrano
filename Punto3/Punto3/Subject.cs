using System;
using System.Collections.Generic;
using System.Text;

namespace Punto3
{
    class Subject   
    {
            
            public Observer[] observers = new Observer[20];
            public string name;            
            public Subject(string name)
            {
                this.name = name;             
            }

            public virtual int RegisterObs(Subject subject, Observer observer)
            {

                for (int i = 0; i < 20; i++)
                {
                    if (subject.observers[i] == null)
                    {
                        subject.observers[i] = observer;
                        return 0;
                    }
                }
                return RegisterObs(subject, observer); ;
            }
        
            public void NotifyObs(Subject subject)
            {
                for (int i = 0; i < 20; i++)
                {
                    if (subject.observers[i] != null)
                    {
                        subject.observers[i].Notify(subject.observers[i], subject);
                    }
                }
            }
        }
    }
