using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List <Masina> parcare = new List<Masina>();

        parcare.Add(new Masina());
        parcare.Add(new MasinaRally());

        foreach(var m in parcare)
        {
            if(m is MasinaRally rally)
            {
                rally.sunet();
            }
        }
    }
}